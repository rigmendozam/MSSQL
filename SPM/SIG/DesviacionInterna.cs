using APP_GEN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ITD.Win;
using ITD.Win.Formas;
using Global = APP_GEN.Global;
using System.IO;
using ITD.Log;
using ITD.AccDatos;
using ITD.Funciones;
using Tulpep.NotificationWindow;
using System.Drawing;

namespace APP {

  public partial class DesviacionInterna : FrmBaseGrid {

    #region Declaraciones

    #region Por Defecto

    private static readonly ACCESO_OPCION Acceso = ACCESO_OPCION.Desviacion;
    private static readonly ACCESO_OPCION AccesoAnalisis = ACCESO_OPCION.DesviacionAnalisis;

    private DataSet dtsDatos;

    private Type[] formulariosRefrescar = new Type[] {
      typeof(DesviacionCons)
    };

    private enum REPORTES {
      Detalle
    }

    private enum TABLAS {
      Principal = 0,
      Detalle = 1,
      Imagenes = 2
    }

    List<Grilla> listaGrillas = new List<Grilla>();

    public static bool TieneAcceso {
      get { return Global.DatosApp.TieneAcceso(Acceso) != TIPO_ACCESO.Sin_Acceso; }
    }

    public int Id { get; set; }

    public object[] Parametros { set { Id = value[0].XEntero(); } }

    bool bolAccesoAnalisis;

    #endregion

    ESTADO_PARTE objEstado;

    #endregion

    #region Inicial

    public DesviacionInterna() {
      InitializeComponent();
      LlenarDdls();
      listaGrillas = new List<Grilla>() { dtgPrincipal, dtgImagenes };
    }

    private void ActualizacionGrilla_Load(object sender, EventArgs e) {
      InicializarParametros();
      RefrescarTodo();
    }

    private void InicializarParametros() {
      ValidarAcceso();
      ValidarCambios(this);

      if (ddlReporte.Items.Count > 0) {
        ddlReporte.SelectedIndex = (int)REPORTES.Detalle;
        ddlReporte.Visible = ddlReporte.Items.Count > 1;
      } else
        tsbReporte.Visible = ddlReporte.Visible = false;

    }

    private void ValidarAcceso() {
      PuedeActualizar = Global.DatosApp.TieneAcceso(Acceso) == TIPO_ACCESO.Editar;
      bolAccesoAnalisis = Global.DatosApp.TieneAcceso(AccesoAnalisis) == TIPO_ACCESO.Editar;
    }

    #endregion

    #region Actualizacion

    public override GUARDAR_RESULT GuardarTodo() {
      GUARDAR_RESULT resultado = GUARDAR_RESULT.CanceladoGuardar;
      if (listaGrillas.Any(s => !s.FinalizaEdicion())) {
        return resultado;
      }

      if (!Validar()) {
        return resultado;
      }

      if (listaGrillas.Any(s => s.HayErrores)) {
        MessageBox.Show("No se pueden guardar los cambios porque existen filas con errores.", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return resultado;
      }

      bool bolOK = EstadoForma == ESTADO_FORMA.Agregando ? Insertar() : Modificar();
      Cursor = Cursors.WaitCursor;

      if (bolOK) {
        EstadoForma = ESTADO_FORMA.Modificando;
        resultado = GUARDAR_RESULT.GuardadoOk;
        bool bolHayErrores = false;

        var listaCambios = TomarFilasModificadas(dtgPrincipal);
        var listaResultados = Global.DatosApp.ActualizarMasivo("PartePlanAccion", listaCambios, false);
        SincronizarCambios(dtgPrincipal, listaResultados);

        bolHayErrores = dtgPrincipal.HayErrores;


        //listaCambios = TomarFilasModificadas(dtgImagenes);
        //listaResultados = Global.DatosApp.ActualizarMasivo("ParteArchivo", listaCambios, false);
        //SincronizarCambios(dtgImagenes, listaResultados);

        //if (!bolHayErrores)
        //  bolHayErrores = dtgImagenes.HayErrores;


        if (bolHayErrores) {
          MessageBox.Show("No se guardaron todos los cambios porque existen filas con errores.", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
          resultado = GUARDAR_RESULT.GuardadoError;
        }
      } else {
        resultado = GUARDAR_RESULT.GuardadoError;
      }
      Cursor = Cursors.Default;

      Global.MostrarNotificacion(Global.STR_INFORMACION, "Registros guardados con éxito");

      return resultado;
    }

    protected override object[] TomarParametrosAInsertar(DataGridView dtgGrilla, DataRow dtrFila) {
      dtrFila["IdParte"] = Id;
      if (dtgGrilla == dtgPrincipal)
        return dtrFila.ItemArray.Take(6).ToArray();
      else if (dtgGrilla == dtgImagenes) {
        object[] obj = dtrFila.ItemArray;
        obj[2] = Path.GetFileName(dtrFila["NombreArchivo"].ToString());
        return obj;
      } else
        return base.TomarParametrosAInsertar(dtgGrilla, dtrFila);

    }

    protected override object[] TomarParametrosAModificar(DataGridView dtgGrilla, DataRow dtrFila) {
      if (dtgGrilla == dtgPrincipal)
        return dtrFila.ItemArray.Take(6).ToArray();
      else if (dtgGrilla == dtgImagenes)
        return new object[] { dtrFila["Id"], dtrFila["IdParte"], dtrFila["Observacion"] };
      else
        return base.TomarParametrosAModificar(dtgGrilla, dtrFila);
    }

    protected override object[] TomarParametrosABorrar(DataGridView dtgGrilla, DataRow dtrFila) {
      if (dtgGrilla == dtgImagenes)
        return new object[] { dtrFila["Id", DataRowVersion.Original], dtrFila["NombreArchivo", DataRowVersion.Original] };

      return base.TomarParametrosABorrar(dtgGrilla, dtrFila);
    }

    protected override void SincronizarFilaIns(DataGridView dtgGrilla, Registro nuevo, DataRow dtrFila) {
      base.SincronizarFilaIns(dtgGrilla, nuevo, dtrFila);

      if (dtgGrilla == dtgImagenes) {
        DateTime dtFecha = DateTime.MinValue;
        var res = Global.Transfer.SubirArchivo(dtrFila["NombreArchivo"].ToString(), Path.Combine(Global.CARPETA_HALLAZGO, Id.ToString(), Path.GetFileName(dtrFila["NombreArchivo"].ToString())), ref dtFecha);

        //strRutaCarpetaImagen = Path.Combine(Global.CAMINO_DOC_LOCAL, Global.CARPETA_PTT, Id.ToString());
      }
    }

    protected override void SincronizarFilaDel(DataGridView dtgGrilla, Registro nuevo, DataRow dtrFila) {

      if (dtgGrilla == dtgImagenes) {

        string strCarpetaDoc = Path.Combine(Global.CARPETA_HALLAZGO, Id.ToString(), nuevo.Parametros[1].ToString());
        var res = Global.Transfer.BorrarArchivo(strCarpetaDoc);
        base.SincronizarFilaDel(dtgGrilla, nuevo, dtrFila);
      }
    }

    private void GuardarImagenes() {

      var listaCambios = TomarFilasModificadas(dtgImagenes);
      var listaResultados = Global.DatosApp.ActualizarMasivo("ParteArchivo", listaCambios, false);
      SincronizarCambios(dtgImagenes, listaResultados);

    }


    private bool Eliminar() {
      return null != this.XEjecutarProcedimiento(formulariosRefrescar, "ParteDel", Id);
    }

    private bool Insertar() {

      object[] objParam = new object[] {
        Id,
        dtpFecha.Value,
        ddlIdPlanta.SelectedValue,
        ddlIdOrigen.SelectedValue,
        ddlIdAreas.SelectedValue,
        ddlIdSistema.SelectedValue,
        Global.DatosApp.InfoUsr.IdUsuario,
        ddlIdTipoHallazgo.SelectedValue,
        txtResponsable.Tag,
        txtCliProv.Tag,
        txtNumProc.Tag,
        txtTitulo.Text,
        string.IsNullOrWhiteSpace(txtDetalle.Text) ? null : txtDetalle.Text,
        string.IsNullOrWhiteSpace(txtAccionInmediata.Text) ? null : txtAccionInmediata.Text,
        dtpFechaAI.XTomarValorConCheck(),
        ddlCriticidad.SelectedValue,
        nudRecibida.Value,
        nudRevisada.Value,
        nudRechazada.Value,
        txtNumRec.Tag,
        txtTipoProd.XTextoONulo(),
        ddlUM.SelectedValue,
        ddlTipoAsunto.SelectedValue,
        txtPersonalAmonestado.Tag,
        ddlIdPlantaOrigen.SelectedValue,
        txtCorreoEntidad.XTextoONulo(),
        ddlAsunto.SelectedValue
      };

      objParam = this.XEjecutarProcedimiento(formulariosRefrescar, "ParteIns", objParam);

      if (objParam != null)
        Id = (int)objParam[0];

      return objParam != null;
    }

    private bool Modificar() {
      object[] objParam = new object[] {
        Id,
        dtpFecha.Value,
        ddlIdPlanta.SelectedValue,
        ddlIdOrigen.SelectedValue,
        ddlIdAreas.SelectedValue,
        ddlIdSistema.SelectedValue,
        ddlIdTipoHallazgo.SelectedValue,
        txtResponsable.Tag,
        txtCliProv.Tag,
        txtNumProc.Tag,
        txtTitulo.Text,
        string.IsNullOrWhiteSpace(txtDetalle.Text) ? null : txtDetalle.Text,
        string.IsNullOrWhiteSpace(txtAccionInmediata.Text) ? null : txtAccionInmediata.Text,
        dtpFechaAI.XTomarValorConCheck(),
        txtAnaHombre.XTextoONulo(),
        txtAnaMaterial.XTextoONulo(),
        txtAnaMaquina.XTextoONulo(),
        txtAnaMetodo.XTextoONulo(),
        txtAnaEntorno.XTextoONulo(),
        txtAnaMedida.XTextoONulo(),
        dtpFechaRA.XTomarValorConCheck(),
        Global.DatosApp.InfoUsr.IdUsuario,
        ddlCriticidad.SelectedValue,
        nudRecibida.Value,
        nudRevisada.Value,
        nudRechazada.Value,
        txtNumRec.Tag,
        txtTipoProd.XTextoONulo(),
        ddlUM.SelectedValue,
        ddlTipoAsunto.SelectedValue,
        txtPersonalAmonestado.Tag,
        ddlIdPlantaOrigen.SelectedValue,
        txtCorreoEntidad.XTextoONulo(),
        ddlAsunto.SelectedValue
      };

      return null != this.XEjecutarProcedimiento(formulariosRefrescar, "ParteUpd", objParam);
    }

    private bool CambiarEstado(ESTADO_PARTE objNuevoEstado) {
      return null != this.XEjecutarProcedimiento(formulariosRefrescar, "ParteCambiarEstado", Id, (int)objNuevoEstado, Global.DatosApp.InfoUsr.IdUsuario);
    }


    private bool EnviarCorreoParticipantes() {
      return null != this.XEjecutarProcedimiento(formulariosRefrescar, "ParteEnviarCorreoParticipantes", Id, Global.DatosApp.InfoUsr.IdUsuario);
    }

    #endregion

    #region Interfaz

    public void LlamadoDesdePrincipal(params object[] parametros) {
      if (this.XGuardaCambios(listaGrillas.ToArray())) {
        Id = (int)parametros[0];
        if (Id == 0)
          LimpiarControles();
        else
          RefrescarTodo();
      }
    }

    public override void RefrescarTodo() {
      LlenarControles();
    }

    private void LimpiarControles() {
      EstadoForma = ESTADO_FORMA.Agregando;

      if (!Inicializando) {
        listaGrillas.ForEach(s => s.Vista.Table.Clear());
      }
      Id = 0;

      ddlTipoAsunto.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.ParteTipoAsunto, "Id > 0 and Activo = 1", ddlTipoAsunto.DisplayMember);

      pnlPrincipal.XLimpiarControl();
      tbcPrincipal.XLimpiarControl();
      dtpFechaAI.Checked = false;

      lblFechaRA.Visible = dtpFechaRA.Visible = btnFechaRA.Visible = btnEnviarCorreo.Visible = false;

      objEstado = ESTADO_PARTE.EnEdicion;

      tsbEnviar.Visible = false;
      tsbAceptar.Visible = false;
      tsbRechazar.Visible = false;
      tsbRealizado.Visible = false;
      //tsbVerificarImp.Visible = false;
      //tsbRechazarImp.Visible = false;
      //tsbVerificarEfec.Visible = false;
      //tsbRechazarEfec.Visible = false;

      txtEstado.Text = "En Edición";

      tsbEliminar.Enabled = false;
      tsbReporte.Enabled = false;
      tsbGuardar.Enabled = PuedeActualizar;
      tsbNuevo.Enabled = false;
      CadenaValoresInicial = CrearCadenaValores();
      ValidaCambios = tsbGuardar.Enabled;
    }

    private void LlenarControles() {
      Cursor = Cursors.WaitCursor;
      dtsDatos = Global.DatosApp.TraerDataset("ParteSel_Id", new object[] { Id });
      Cursor = Cursors.Default;

      if (dtsDatos != null) {
        RefrescarGrilla(dtgPrincipal, TomarTabla(TABLAS.Detalle).DefaultView);
        RefrescarGrilla(dtgImagenes, TomarTabla(TABLAS.Imagenes).DefaultView);

        if (TomarTabla(TABLAS.Principal).Rows.Count == 0) {
          LimpiarControles();
          return;
        }

        DataRow dtr = TomarTabla(TABLAS.Principal).Rows[0];
        EstadoForma = ESTADO_FORMA.Modificando;

        objEstado = (ESTADO_PARTE)dtr.XEntero("IdEstado");

        Id = dtr.XEntero("Id");

        ddlIdPlantaOrigen.SelectedValue = dtr["IdPlantaOrigen"];
        ddlIdPlanta.SelectedValue = dtr["IdPlanta"];
        ddlIdPlanta_SelectedIndexChanged(null, null);
        ddlIdAreas.SelectedValue = dtr["IdAreas"];
        ddlIdSistema.SelectedValue = dtr["IdSistema"];
        ddlIdTipoHallazgo.SelectedValue = dtr["IdTipoHallazgo"];
        txtNumero.Text = dtr.XEntero("Numero").ToString("#,##0");
        txtTipoProd.Text = dtr["TipoProducto"].ToString();

        ddlTipoAsunto.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.ParteTipoAsunto, "(Id > 0 and Activo = 1) or Id = " + dtr["IdTipoAsunto"].XEntero().ToString(), ddlTipoAsunto.DisplayMember);

        ddlTipoAsunto.SelectedValue = dtr["IdTipoAsunto"];

        ddlAsunto.SelectedValue = dtr["IdParteAsunto"];

        ddlCriticidad.SelectedValue = dtr["IdALerta"];
        ddlIdOrigen.SelectedValue = dtr["IdOrigen"];
        txtResponsable.Text = dtr["Responsable"].ToString();
        txtResponsable.Tag = dtr["IdResponsable"];

        txtPersonalAmonestado.Text = dtr["Amonestado"].ToString();
        txtPersonalAmonestado.Tag = dtr["IdPersonalAmonestado"];


        txtCliProv.Text = dtr["EntidadEx"].ToString();
        txtCliProv.Tag = dtr["IdEntidad"];
        txtCorreoEntidad.ReadOnly = string.IsNullOrWhiteSpace(txtCliProv.Text);

        dtpFechaProc.Value = dtr.XFechaHora("FechaProc", DateTime.Now.Ticks);
        dtpFecha.Value = dtr.XFechaHora("Fecha", DateTime.Now.Ticks);

        txtNumProc.Text = dtr["id_Programa"].ToString();
        txtNumProc.Tag = dtr["IdPlanificacionDet"];
        txtEncargadaProc.Text = dtr["Encargada"].ToString();
        txtCodProc.Text = dtr["codigo_ptt"].ToString();
        txtDescProc.Text = dtr["nombre_ptt"].ToString();
        txtClienteProc.Text = dtr["CliProc"].ToString();

        nudRecibida.Value = dtr.XEntero("CantidadRecibida");
        nudRevisada.Value = dtr.XEntero("CantidadRevisada");
        nudRechazada.Value = dtr.XEntero("CantidadRechazada");

        txtAccionInmediata.Text = dtr["AccionInmediata"].ToString();
        txtAnaHombre.Text = dtr["Hombre"].ToString();
        txtAnaMaterial.Text = dtr["Material"].ToString();
        txtAnaMaquina.Text = dtr["Maquina"].ToString();
        txtAnaMetodo.Text = dtr["Metodo"].ToString();
        txtAnaEntorno.Text = dtr["Entorno"].ToString();
        txtAnaMedida.Text = dtr["Medida"].ToString();

        txtTitulo.Text = dtr["Asunto"].ToString();
        txtDetalle.Text = dtr["Descripcion"].ToString();

        txtNumRec.Text = dtr["NumRec"].ToString();
        txtNumRec.Tag = dtr["IdRecepcion"];
        txtTipoDocRec.Text = dtr["nombre_tipodoc"].ToString();
        txtNumDocRec.Text = dtr["NumeroDoc"].ToString();
        txtOCRec.Text = dtr["OC"].ToString();
        txtClienteRec.Text = dtr["CliRec"].ToString();
        txtProveedorRec.Text = dtr["ProvRec"].ToString();
        txtCorreoEntidad.Text = dtr["EmailFacturacion"].ToString();

        ddlUM.SelectedValue = dtr["IdMedida"];

        txtEstado.Text = dtr["Estado"].ToString();
        dtpFechaAI.XSetearValorConCheck(dtr.XFechaHoraONulo("FechaAI"));
        dtpFechaRA.XSetearValorConCheck(dtr.XFechaHoraONulo("FechaHoraRA"));
        //txtRecomendación.Text = dtr["Recomendación"].ToString();

        lblFechaRA.Visible = dtpFechaRA.Visible = btnFechaRA.Visible = objEstado != ESTADO_PARTE.EnEdicion;
        btnEnviarCorreo.Visible = lblFechaRA.Visible && dtr.XEntero("CantReunion") > 0;

        dtgPrincipal.ReadOnly = !PuedeActualizar || objEstado == ESTADO_PARTE.EnEdicion;
        //dtgImagenes.ReadOnly = !PuedeActualizar || objEstado != ESTADO_PARTE.EnEdicion;

        tsbEnviar.Visible = PuedeActualizar && objEstado == ESTADO_PARTE.EnEdicion;
        tsbAceptar.Visible = (PuedeActualizar && bolAccesoAnalisis) && objEstado == ESTADO_PARTE.Enviado;
        tsbRechazar.Visible = (PuedeActualizar && bolAccesoAnalisis) && objEstado.XEnInt(ESTADO_PARTE.Enviado, ESTADO_PARTE.Aceptado, ESTADO_PARTE.EnSeguimiento);
        tsbRealizado.Visible = (PuedeActualizar && bolAccesoAnalisis) && objEstado == ESTADO_PARTE.Aceptado;
        //tsbVerificarImp.Visible = PuedeActualizar && objEstado == ESTADO_PARTE.EnSeguimiento;
        //tsbRechazarImp.Visible = PuedeActualizar && objEstado == ESTADO_PARTE.EnSeguimiento;
        //tsbVerificarEfec.Visible = PuedeActualizar && objEstado == ESTADO_PARTE.VerificarImplementacion;
        //tsbRechazarEfec.Visible = PuedeActualizar && objEstado == ESTADO_PARTE.VerificarImplementacion;

        tsbEliminar.Enabled = PuedeActualizar && objEstado == ESTADO_PARTE.EnEdicion;
        tsbReporte.Enabled = true;
        tsbGuardar.Enabled = (PuedeActualizar && objEstado == ESTADO_PARTE.EnEdicion) || ((objEstado == ESTADO_PARTE.Enviado || objEstado == ESTADO_PARTE.Aceptado || objEstado == ESTADO_PARTE.EnSeguimiento) && PuedeActualizar && bolAccesoAnalisis);
        tsbNuevo.Enabled = PuedeActualizar;

        CadenaValoresInicial = CrearCadenaValores();
        ValidaCambios = tsbGuardar.Enabled;
      } else {
        MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    //private void MostrarTabSegunEstado() {
    //  switch (objEstado) {
    //    case ESTADO_PARTE.EnEdicion:
    //      RemoverTab(tbpVerEfect);
    //      tbpPrincipal.Controls.Cast<Control>().ToList().ForEach(s => s.Enabled = true);
    //      break;
    //    case ESTADO_PARTE.Enviado:
    //    case ESTADO_PARTE.Rechazado:
    //      RemoverTab(tbpVerEfect);
    //      //tbpAprobaRech.Controls.Cast<Control>().ToList().ForEach(s => s.Enabled = objEstado == ESTADO_PARTE.Enviado);
    //      tbpPrincipal.Controls.Cast<Control>().ToList().ForEach(s => s.Enabled = false);
    //      break;
    //    case ESTADO_PARTE.Aceptado:
    //      RemoverTab(tbpVerEfect);
    //      tbpPrincipal.Controls.Cast<Control>().ToList().ForEach(s => s.Enabled = false);
    //      //tbpAprobaRech.Controls.Cast<Control>().ToList().ForEach(s => s.Enabled = false);
    //      //tbpAnalisis.Controls.Cast<Control>().ToList().ForEach(s => s.Enabled = objEstado == ESTADO_PARTE.Aceptado);
    //      break;
    //    case ESTADO_PARTE.Realizado:
    //    case ESTADO_PARTE.RechazoImplementacion:
    //      RemoverTab(tbpVerEfect);
    //      tbpPrincipal.Controls.Cast<Control>().ToList().ForEach(s => s.Enabled = false);
    //      //tbpAprobaRech.Controls.Cast<Control>().ToList().ForEach(s => s.Enabled = false);
    //      //tbpAnalisis.Controls.Cast<Control>().ToList().ForEach(s => s.Enabled = false);
    //      //tbpAnalisis.Controls.Cast<Control>().ToList().ForEach(s => s.Enabled = objEstado == ESTADO_PARTE.Realizado);
    //      break;
    //    case ESTADO_PARTE.VerificarImplementacion:
    //    case ESTADO_PARTE.VerificarEfectividad:
    //    case ESTADO_PARTE.RechazoEfectividad:
    //      AgregarTab(tbpVerEfect);
    //      tbpPrincipal.Controls.Cast<Control>().ToList().ForEach(s => s.Enabled = false);
    //      //tbpAprobaRech.Controls.Cast<Control>().ToList().ForEach(s => s.Enabled = false);
    //      //tbpAnalisis.Controls.Cast<Control>().ToList().ForEach(s => s.Enabled = false);
    //      //tbpVerImple.Controls.Cast<Control>().ToList().ForEach(s => s.Enabled = false);
    //      tbpVerEfect.Controls.Cast<Control>().ToList().ForEach(s => s.Enabled = objEstado == ESTADO_PARTE.VerificarEfectividad);
    //      break;
    //    default:
    //      break;
    //  }
    //}

    private void RemoverTab(TabPage tab) {
      if (tbcPrincipal.TabPages.Contains(tab))
        tbcPrincipal.TabPages.Remove(tab);
    }

    private void AgregarTab(TabPage tab) {
      if (!tbcPrincipal.TabPages.Contains(tab))
        tbcPrincipal.TabPages.Add(tab);
    }

    private void LlenarDdls() {

      ddlIdPlantaOrigen.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Planta, "Id > 0 And activo_planta = 1", "");

      ddlIdPlanta.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Planta, "Id > 0 And activo_planta = 1", "");

      ddlIdTipoHallazgo.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.TipoHallazgoSolo, "Id> 0 and Parte = 1", ddlIdTipoHallazgo.DisplayMember);

      ddlIdOrigen.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.ParteOrigen, "Id > 0", ddlIdOrigen.DisplayMember);

      ddlIdSistema.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.ParteSistema, "Id > 0", ddlIdSistema.DisplayMember);

      ddlCriticidad.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.ParteAlerta, "Id>0", "");

      ddlUM.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Medidas, "Id > 0 and Id <= 3", "");

    }

    private bool Validar() {
      StringBuilder stbError = new StringBuilder();

      if (objEstado == ESTADO_PARTE.EnEdicion) {

        if (ddlIdPlantaOrigen.SelectedValue == null)
          stbError.AppendLine("Planta de Origen es requerido.");

        if (ddlIdSistema.SelectedValue == null)
          stbError.AppendLine("Sistema es requerido.");

        if (ddlIdPlanta.SelectedValue == null)
          stbError.AppendLine("Planta es requerido.");

        if (ddlIdOrigen.SelectedValue == null)
          stbError.AppendLine("Origen es requerido.");

        if (ddlIdAreas.SelectedValue == null)
          stbError.AppendLine("Área es requerido.");

        if (ddlIdTipoHallazgo.SelectedValue == null)
          stbError.AppendLine("Tipo hallazgo es requerido.");

        if (ddlIdTipoHallazgo.SelectedValue == null)
          stbError.AppendLine("Tipo es requerido.");

        if (ddlTipoAsunto.SelectedValue == null)
          stbError.AppendLine("Tipo asunto es requerido.");
        
        if (!txtCorreoEntidad.Text.XEsNuloOVacio() && !FuncGen.EsEmailMultipleValido(txtCorreoEntidad.Text.Trim()))
          stbError.AppendLine("Correo Cliente/Proveedor no válido.");

        //if (gpbExterno.Enabled) {
        //  if (txtCliProv.Tag.XEsNuloOVacio())
        //    stbError.AppendLine("Cliente/Proveedor es requerido.");
        //}

        //if (gpbInterno.Enabled) {
        //  if (txtNumProc.Tag.XEsNuloOVacio())
        //    stbError.AppendLine("Número de proceso es requerido.");
        //}

        if (string.IsNullOrWhiteSpace(txtTitulo.Text))
          stbError.AppendLine("Asunto es requerido.");

        if (string.IsNullOrWhiteSpace(txtDetalle.Text))
          stbError.AppendLine("Detalle es requerido.");

        if (!txtAccionInmediata.Text.XEsNuloOVacio() && !dtpFechaAI.Checked)
          stbError.AppendLine("Fecha AI es requerido.");

        if (!txtNumProc.Tag.XEsNuloOVacio() && !txtNumRec.Tag.XEsNuloOVacio())
          stbError.AppendLine("Ha ingresado un número de recepción y un número de proceso. Favor de quitar uno de ellos.");

      }

      if (stbError.Length > 0) {
        stbError.Insert(0, "Campos con errores o vacíos:\n");
        MessageBox.Show(stbError.ToString(), APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;
    }

    private void ValidarFila(DataRow dtrFila) {
      StringBuilder stbError = new StringBuilder();

      if (stbError.Length > 0)
        stbError.Insert(0, "Campos con errores o vacíos:\n");
      dtrFila.RowError = stbError.ToString();
    }

    private void ValidarFilaImagenes(DataRow dtr) {
      StringBuilder stbError = new StringBuilder();

      if (dtr.XEsNuloOVacio("Observacion"))
        stbError.AppendLine("Observación es requerido");

      if (dtr.XEsNuloOVacio("NombreArchivo"))
        stbError.AppendLine("Falta agregar la imagen");

      if (stbError.Length > 0) {
        stbError.Insert(0, "Campos con errores o vacíos.\n");
      }
      dtr.RowError = stbError.ToString();
    }
    
    #endregion

    #region Acciones

    public override bool HayCambios() {
      return base.HayCambios() || listaGrillas.Any(s => s.HayCambios);
    }

    private void MostrarReporte() {
      Reporte objReporte = null;
      object[] objParam;
      switch ((REPORTES)ddlReporte.SelectedIndex) {
        case REPORTES.Detalle:
          objParam = new object[] { Id };

          Cursor = Cursors.WaitCursor;
          var dtsDatos = APP_GEN.Global.DatosApp.TraerDataset("ParteSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.Parte.rdlc", "Reportes");
          objReporte.Titulo = "Reporte Planilla de Hallazgo";

          ITDError objError = null;

          dtsDatos.Tables[0].AsEnumerable().ToList().ForEach(s => {

            string strCarpeta = Path.Combine(Global.CAMINO_DOC_LOCAL, Global.CARPETA_HALLAZGO, Id.ToString());

            if (!Directory.Exists(strCarpeta))
              Directory.CreateDirectory(strCarpeta);

            Global.Transfer.TomarArchivoRuta(Path.Combine(Global.CARPETA_HALLAZGO, Id.ToString(), s["NombreArchivo"].ToString()), s.XFechaHora("FechaArchivo"), ref objError);

            s["NombreArchivo"] = "File://" + Path.Combine(Global.CAMINO_DOC_LOCAL, Global.CARPETA_HALLAZGO, Id.ToString(), s["NombreArchivo"].ToString());


          });

          foreach (DataTable dttReporte in dtsDatos.Tables) {
            objReporte.Datos.Add(dttReporte);
          }

          Cursor = Cursors.Default;
          break;
      }

      if (objReporte != null)
        objReporte.MostrarReporte(APP_GEN.Global.FormaPrincipal);
    }

    private DataTable TomarTabla(TABLAS objTabla) {
      return dtsDatos.Tables[(int)objTabla];
    }

    private DataRow LlamaBuscadorUsuario(string strNombre) {

      var dttTabla = Global.BuscarUsuario("", strNombre);
      if (dttTabla != null) {
        if (dttTabla.Rows.Count > 0) {

          DataRow dtr = dttTabla.Rows[0];

          return dtr;

        }
      }

      return null;
    }

    private void TraerCliente(string strNombre) {
      var dttTabla = Global.BuscarEntidad(null, strNombre, true, true, true, true);
      //Console.WriteLine(dttTabla);
      if (dttTabla != null) {
        if (dttTabla.Rows.Count > 0) {
          var dtrFila = dttTabla.Rows[0];
          txtCliProv.Text = dtrFila["nombre_clie"].ToString();
          txtCliProv.Tag = dtrFila["Id"];

          txtCorreoEntidad.Text = dtrFila["EmailFacturacion"].ToString() ;
          txtCorreoEntidad.ReadOnly = false;
        }
      } else {
        txtCliProv.Tag = null;
      }
      
    }

    private void TraerProceso() {
      Cursor = Cursors.WaitCursor;
      DataTable dt = Global.DatosApp.TraerTabla("Parte_SelPlanDet", new object[] { ddlIdPlanta.SelectedValue, dtpFechaProc.Value, txtNumProc.Text });
      Cursor = Cursors.Default;

      if (dt == null) {
        MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtNumProc.Focus();
        return;
      }

      if (dt.Rows.Count == 0) {
        MessageBox.Show("No existe el proceso ingresado", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtNumProc.Focus();
        return;
      }

      DataRow dtr = dt.Rows[0];

      txtCodProc.Text = dtr["codigo_ptt"].ToString();
      txtNumProc.Tag = dtr["Id"];
      txtEncargadaProc.Text = dtr["nombre_empleado"].ToString();
      txtDescProc.Text = dtr["nombre_ptt"].ToString();
      txtClienteProc.Text = dtr["Nombre"].ToString();

    }

    private void TraerRecepcion() {
      Cursor = Cursors.WaitCursor;
      DataTable dt = Global.DatosApp.TraerTabla("Parte_SelRecepcion", new object[] { ddlIdPlanta.SelectedValue, txtNumRec.Text });
      Cursor = Cursors.Default;

      if (dt == null) {
        MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtNumProc.Focus();
        return;
      }

      if (dt.Rows.Count == 0) {
        MessageBox.Show("No existe la recepción ingresada", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtNumProc.Focus();
        return;
      }

      DataRow dtr = dt.Rows[0];

      txtTipoDocRec.Text = dtr["nombre_tipodoc"].ToString();
      txtNumRec.Tag = dtr["Id"];
      txtNumDocRec.Text = dtr["NumeroDoc"].ToString();
      txtOCRec.Text = dtr["OC"].ToString();
      txtClienteRec.Text = dtr["Cliente"].ToString();
      txtProveedorRec.Text = dtr["Proveedor"].ToString();

    }
    #endregion

    #region Eventos de barra

    private void tsbEliminar_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a eliminar el registro actual. ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (Eliminar()) {
          LimpiarControles();
        }
      }
    }

    private void tsbGuardar_Click(object sender, EventArgs e) {
      if (GuardarTodo() == GUARDAR_RESULT.GuardadoOk) {
        RefrescarTodo();
      }
    }

    private void tsbNuevo_Click(object sender, EventArgs e) {
      if (this.XGuardaCambios(listaGrillas.ToArray())) {
        LimpiarControles();
      }
    }

    private void tsbRefrescar_Click(object sender, EventArgs e) {
      if (this.XGuardaCambios(listaGrillas.ToArray())) {
        RefrescarTodo();
      }
    }

    private void tsbReporte_Click(object sender, EventArgs e) {
      MostrarReporte();
    }

    private void tsbEnviar_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a enviar la planilla al responsable del área ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (CambiarEstado(ESTADO_PARTE.Enviado))
          RefrescarTodo();
      }
    }

    private void tsbAceptar_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a aceptar la planilla actual. ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (CambiarEstado(ESTADO_PARTE.Aceptado))
          RefrescarTodo();
      }
    }

    private void tsbRealizado_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Ha concluido con el análisis para dar inici. ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (CambiarEstado(ESTADO_PARTE.EnSeguimiento))
          RefrescarTodo();
      }
    }

    private void tsbRechazar_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a rechazar la planilla actual. ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (CambiarEstado(ESTADO_PARTE.Rechazado))
          RefrescarTodo();
      }
    }

    #endregion

    #region Eventos de controles

    private void Control_Enter(object sender, EventArgs e) {
      sender.XSeleccionarTextoEnControl();
    }

    private void ddlIdPlanta_SelectedIndexChanged(object sender, EventArgs e) {

      ddlIdAreas.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Area, string.Format("IdPlanta is null or IdPlanta={0}", ddlIdPlanta.SelectedValue.XEntero()), ddlIdAreas.DisplayMember);
    }

    private void txtnombre_empleado_TextChanged(object sender, EventArgs e) {
      txtResponsable.Tag = null;
    }

    private void txtnombre_empleado_Validated(object sender, EventArgs e) {
      if (!txtResponsable.Text.XEsNuloOVacio() && txtResponsable.Tag.XEntero() == 0) {
        DataRow dtr = LlamaBuscadorUsuario(txtResponsable.Text);

        if (dtr != null) {
          txtResponsable.Text = dtr["nombre_empleado"].ToString();
          txtResponsable.Tag = dtr["Id"];
        }

      }
    }

    private void txtCliProv_TextChanged(object sender, EventArgs e) {
      txtCliProv.Tag = null;
      
    }

    private void txtCliProv_Validated(object sender, EventArgs e) {
      if (!txtCliProv.Text.XEsNuloOVacio() && txtCliProv.Tag.XEntero() == 0)
        TraerCliente(txtCliProv.Text);
        
     

    }

    private void txtNumProc_TextChanged(object sender, EventArgs e) {
      txtNumProc.Tag = null;
    }

    private void txtNumProc_Validated(object sender, EventArgs e) {
      if (!txtNumProc.Text.XEsNuloOVacio() && txtNumProc.Tag.XEntero() == 0)
        TraerProceso();
    }

    private void ddlIdTipoHallazgo_SelectedIndexChanged(object sender, EventArgs e) {
      if (ddlIdTipoHallazgo.SelectedItem == null)
        return;
      bool bolInterno = ((DataRowView)ddlIdTipoHallazgo.SelectedItem).Row.XBooleano("Interno");

    

      txtCliProv.Clear();
      txtNumProc.Clear();
      txtEncargadaProc.Clear();
      txtCodProc.Clear();
      txtDescProc.Clear();
      txtClienteProc.Clear();

    }

    private void btnFechaRA_Click(object sender, EventArgs e) {

      if (this.XGuardaCambios()) {
        Global.LlamarFormulario<DesviacionParticipante>(true, Id);
        LlenarControles();
      }
    }

    private void btnEnviarCorreo_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a enviar el correo a los participantes de la reunión. ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (EnviarCorreoParticipantes()) { }
          //RefrescarTodo();
      }
    }

    private void txtNumRec_TextChanged(object sender, EventArgs e) {
      txtNumRec.Tag = null;
    }

    private void txtNumRec_Validated(object sender, EventArgs e) {
      if (!txtNumRec.Text.XEsNuloOVacio() && txtNumRec.Tag.XEntero() == 0)
        TraerRecepcion();
    }

    private void txtPersonalAmonestado_TextChanged(object sender, EventArgs e) {
      txtPersonalAmonestado.Tag = null;
    }

    private void txtPersonalAmonestado_Validated(object sender, EventArgs e) {
      if (!txtPersonalAmonestado.Text.XEsNuloOVacio() && txtPersonalAmonestado.Tag.XEntero() == 0) {
        DataRow dtr = LlamaBuscadorUsuario(txtPersonalAmonestado.Text);

        if (dtr != null) {
          txtPersonalAmonestado.Text = dtr["nombre_empleado"].ToString();
          txtPersonalAmonestado.Tag = dtr["Id"];
        }

      }
    }

    #endregion

    #region Eventos de grilla

    private void dtgPrincipal_AntesInsertar(object sender, FilaEventArg e) {
      DataRow dtrUltima = null;

      if (dtgPrincipal.Vista.Table.Rows.Count > 0)
        dtrUltima = dtgPrincipal.Vista.Table.AsEnumerable().Where(s => s.RowState != DataRowState.Deleted && s.RowState != DataRowState.Detached).LastOrDefault();

      if (dtrUltima != null)
        e.Fila["Problema"] = dtrUltima["Problema"];
      ValidarFila(e.Fila);
    }

    private void dtgPrincipal_CambiaOperacionRapida(object sender, CambiaOperacionRapidaEvengArg e) {
      sbpMensaje.Text = e.ValorFormateado;
    }

    private void dtgPrincipal_CurrentCellDirtyStateChanged(object sender, EventArgs e) {
      DataGridView dgv = sender as DataGridView;
      if (null == dgv || null == dgv.CurrentCell || !dgv.IsCurrentCellDirty) {
        return;
      }

      if ((dgv.CurrentCell is DataGridViewComboBoxCell || dgv.CurrentCell is DataGridViewCheckBoxCell)) {
        dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
      }
    }

    private void dtgPrincipal_DespuesModificarFila(object sender, FilaEventArg e) {
      ValidarFila(e.Fila);
    }

    private void dtgPrincipal_Enter(object sender, EventArgs e) {
      sbpFilas.Text = ((DataGridView)sender).RowCount.ToString();
    }

    private void dtgPrincipal_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex == -1)
        return;

      if (e.ColumnIndex == ColResponsable.Index) {
        DataRow dtrActual = dtgPrincipal.FilaActual;
        if (!dtrActual.XEsNuloOVacio("nombre_empleado")) {
          DataRow dtr = LlamaBuscadorUsuario(dtrActual["nombre_empleado"].ToString());

          if (dtr != null) {
            dtrActual["nombre_empleado"] = dtr["nombre_empleado"];
            dtrActual["IdResponsable"] = dtr["Id"];
          }

        }
      }
    }

    private void dtgImagenes_CellContentClick(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex == -1) return;

      if (e.ColumnIndex == ColCargarImagen.Index && dtgImagenes.FilaActual.RowState == DataRowState.Added) {
        OpenFileDialog ofd = new OpenFileDialog();
        ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
        ofd.Multiselect = false;

        if (ofd.ShowDialog() == DialogResult.OK) {
          dtgImagenes.FilaActual["NombreArchivo"] = ofd.FileName;
          dtgImagenes.FilaActual["FechaArchivo"] = File.GetCreationTime(ofd.FileName);
          ValidarFila(dtgImagenes.FilaActual);
        }

      } else if (e.ColumnIndex == ColVerImagen.Index) {
        if (dtgImagenes.FilaActual.RowState == DataRowState.Added)
          System.Diagnostics.Process.Start(dtgImagenes.FilaActual["NombreArchivo"].ToString());
        else {
          string str = Path.Combine(Global.CARPETA_HALLAZGO, Id.ToString(), dtgImagenes.FilaActual["NombreArchivo"].ToString());
          string strLocal = Path.Combine(Global.CAMINO_DOC_LOCAL, str);

          if (dtgImagenes.FilaActual.RowState != DataRowState.Added && !File.Exists(strLocal)) {
            ITDError objError = null;

            if (!Directory.Exists(Path.GetDirectoryName(strLocal)))
              Directory.CreateDirectory(Path.GetDirectoryName(strLocal));

            strLocal = Global.Transfer.TomarArchivoRuta(str, dtgImagenes.FilaActual.XFechaHora("FechaArchivo"), ref objError);

          }
          System.Diagnostics.Process.Start(strLocal);

        }
      }

    }

    private void dtgImagenes_AntesInsertar(object sender, FilaEventArg e) {
      ValidarFilaImagenes(e.Fila);
    }

    private void dtgImagenes_DespuesModificarFila(object sender, FilaEventArg e) {
      ValidarFilaImagenes(e.Fila);
    }

    #endregion

    #region Persistencia

    private enum Llaves {
      Grilla = 100,
      Imagenes = 200
    }

    protected override void CargarForma() {
      base.CargarForma();
      CargarGrilla(dtgPrincipal, (int)Llaves.Grilla);
      CargarGrilla(dtgImagenes, (int)Llaves.Imagenes);
    }

    protected override void SalvarForma() {
      base.SalvarForma();
      SalvarGrilla(dtgPrincipal, (int)Llaves.Grilla);
      SalvarGrilla(dtgImagenes, (int)Llaves.Imagenes);
    }

    #endregion

       
    private void ddlTipoAsunto_SelectionChangeCommitted(object sender, EventArgs e) {
      //private void ddlIdTipoHallazgo_SelectedIndexChanged(object sender, EventArgs e) {
      // if (ddlIdTipoHallazgo.SelectedItem == null)
      //   return;
      // bool bolInterno = ((DataRowView)ddlIdTipoHallazgo.SelectedItem).Row.XBooleano("Interno");
    }

    private void ddlTipoAsunto_SelectedIndexChanged(object sender, EventArgs e) {
      
      ddlAsunto.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.ParteAsunto, string.Format("IdParteTipoAsunto={0}", ddlTipoAsunto.SelectedValue.XEntero()), ddlAsunto.ValueMember);
    }

    private void txtAnaHombre_MouseClick(object sender, MouseEventArgs e) {
      Global.MostrarNotificacion("Análisis Hombre", " No sabe... No quiere... No puede... \n");
    }

    private void txtAnaMaterial_MouseClick(object sender, MouseEventArgs e) {
      Global.MostrarNotificacion("Análisis Material", " Es el adecuado, Cumple los estandares para el proceso.");
    }

    private void txtAnaMaquina_MouseClick(object sender, MouseEventArgs e) {
      Global.MostrarNotificacion("Análisis Maquina", " Tiene parametros establecidos y registrados en SPM/Ficha PTT \n Mantenciónes correctivas/Preventivas al día.");
    }

    private void txtAnaMetodo_MouseClick(object sender, MouseEventArgs e) {
      Global.MostrarNotificacion("Análisis Método", " Existe instructivo o procedimiento escrito, Se encuentra personal \n capacitado según instructivo.");
    }

    private void txtAnaEntorno_MouseClick(object sender, MouseEventArgs e) {
      Global.MostrarNotificacion("Análisis Entorno", " Espacio suficiente, Lugar adecuado para generar actividad.");
    }

    private void txtAnaMedida_MouseClick(object sender, MouseEventArgs e) {
      Global.MostrarNotificacion("Observación", " Se añade un pequeño resumen de lo analizado anteriormente.");
    }

    private void btnGuardarImagenes_Click(object sender, EventArgs e) {
      GuardarImagenes();
    }
  }
}