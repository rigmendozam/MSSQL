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
using ITD.Funciones;
using ITD.Log;

namespace APP {

  public partial class RecepcionAct : FrmBaseGrid {

    #region Declaraciones

    #region Por Defecto

    private static readonly ACCESO_OPCION Acceso = ACCESO_OPCION.Recepcion;
    private ACCESO_OPCION accesoValidar = ACCESO_OPCION.AutorizaRecpMayor;

    private DataSet dtsDatos;

    private Type[] formulariosRefrescar = new Type[] {
      typeof(RecepcionCons)
    };

    public object[] Parametros { set { Id = (int)value[0]; } }

    private enum REPORTES {
      Detalle
    }

    private enum TABLAS {
      Principal = 0,
      Detalle = 1,
      Problema = 2,
      ProblemaFoto = 3,
      Pallets = 4
    }

    public static bool TieneAcceso {
      get { return Global.DatosApp.TieneAcceso(Acceso) != TIPO_ACCESO.Sin_Acceso; }
    }

    public int Id { get; set; }
    
    bool bolPorContar = false;

    ESTADO_RECEPCION objEstado;

    #endregion

    bool bolAgregando;
    bool bolLoteObligatorio = false;
    const int DOC_PICKING = 99;
    #endregion

    #region Inicial

    public RecepcionAct() {
      InitializeComponent();
      LlenarDdls();
    }

    private void ActualizacionGrilla_Load(object sender, EventArgs e) {
      InicializarParametros();
      RefrescarTodo();
    }

    private void InicializarParametros() {
      ValidarCambios(pnlPrincipal);

      if (ddlReporte.Items.Count > 0) {
        ddlReporte.SelectedIndex = (int)REPORTES.Detalle;
        ddlReporte.Visible = ddlReporte.Items.Count > 1;
      } else
        tsbReporte.Visible = ddlReporte.Visible = false;



    }

    private void ValidarAcceso(bool bolAccesoPlanta) {
      PuedeActualizar = Global.DatosApp.TieneAcceso(Acceso) == TIPO_ACCESO.Editar && bolAccesoPlanta;
    }

    #endregion

    #region Actualizacion

    public override GUARDAR_RESULT GuardarTodo() {
      GUARDAR_RESULT resultado = GUARDAR_RESULT.CanceladoGuardar;
      if (!dtgPrincipal.FinalizaEdicion() || !dtgProblemas.FinalizaEdicion() || !dtgPallets.FinalizaEdicion()) {
        return resultado;
      }

      if (!Validar()) {
        return resultado;
      }

      if (dtgPrincipal.HayErrores || dtgProblemas.HayErrores || dtgPallets.HayErrores) {
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
        var listaResultados = Global.DatosApp.ActualizarMasivo("RecepcionDet", listaCambios, false);
        SincronizarCambios(dtgPrincipal, listaResultados);

        bolHayErrores = dtgPrincipal.HayErrores;


        listaCambios = TomarFilasModificadas(dtgProblemas);
        listaResultados = Global.DatosApp.ActualizarMasivo("RecepcionProblema", listaCambios, false);
        SincronizarCambios(dtgProblemas, listaResultados);

        if (!bolHayErrores)
          bolHayErrores = dtgProblemas.HayErrores;

        listaCambios = TomarFilasModificadas(dtgImagenes);
        listaResultados = Global.DatosApp.ActualizarMasivo("RecepcionProblemaFoto", listaCambios, false);
        SincronizarCambios(dtgImagenes, listaResultados);

        if (!bolHayErrores)
          bolHayErrores = dtgImagenes.HayErrores;


        listaCambios = TomarFilasModificadas(dtgPallets);
        listaResultados = Global.DatosApp.ActualizarMasivo("RecepcionPallet", listaCambios, false);
        SincronizarCambios(dtgPallets, listaResultados);

        if (!bolHayErrores)
          bolHayErrores = dtgImagenes.HayErrores;

        if (bolHayErrores) {
          MessageBox.Show("No se guardaron todos los cambios porque existen filas con errores.", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
          resultado = GUARDAR_RESULT.GuardadoError;
        }
      } else {
        resultado = GUARDAR_RESULT.GuardadoError;
      }
      Cursor = Cursors.Default;

      if (resultado == GUARDAR_RESULT.GuardadoOk)
        MessageBox.Show("Datos guardados con éxito.", Global.STR_INFORMACION, MessageBoxButtons.OK, MessageBoxIcon.Information);

      return resultado;
    }

    protected override object[] TomarParametrosAInsertar(DataGridView dtgGrilla, DataRow dtrFila) {

      if (dtgGrilla == dtgImagenes)
        return dtrFila.ItemArray.Take(dtrFila.ItemArray.Length - 1).ToArray();
      else
        dtrFila["IdRecepcion"] = Id;

      if (dtgGrilla == dtgPrincipal) {
        return dtrFila.ItemArray.Take(dtrFila.ItemArray.Length - 4).ToArray();
      }

      return base.TomarParametrosAInsertar(dtgGrilla, dtrFila);
    }

    protected override object[] TomarParametrosAModificar(DataGridView dtgGrilla, DataRow dtrFila) {
      if (dtgGrilla == dtgPrincipal) {
        return dtrFila.ItemArray.Take(dtrFila.ItemArray.Length - 4).ToArray();
      }
      return base.TomarParametrosAModificar(dtgGrilla, dtrFila);
    }

    private bool Eliminar() {
      return null != this.XEjecutarProcedimiento(formulariosRefrescar, "RecepcionDel", Id);
    }

    private bool Insertar() {
      object[] objParam = new object[] {
        0,
        dtpFechaIng.Value,
        txtrut_clie.Tag,
        txtrut_Prove.Tag,
        ddlIdTipoDoc.SelectedValue,
        txtNumeroDoc.Text,
        ddlPlanta.SelectedValue,
        string.IsNullOrWhiteSpace(txtObservacion.Text) ? null : txtObservacion.Text.Trim(),
        string.IsNullOrWhiteSpace(txtOC.Text) ? null : txtOC.Text.Trim(),
        nudPallet.Value,
        Global.DatosApp.InfoUsr.IdUsuario,
        txtOCProv.XTextoONulo(),
        chkPorTraslado.Checked,
        txtUsuarioRecep.Tag
      };

      objParam = this.XEjecutarProcedimiento(formulariosRefrescar, "RecepcionIns", objParam);

      if (objParam != null)
        Id = (int)objParam[0];

      return objParam != null;
    }

    private bool Modificar() {
      object[] objParam = new object[] {
        Id,
        dtpFechaIng.Value,
        txtrut_clie.Tag,
        txtrut_Prove.Tag,
        ddlIdTipoDoc.SelectedValue,
        txtNumeroDoc.Text,
        string.IsNullOrWhiteSpace(txtObservacion.Text) ? null : txtObservacion.Text.Trim(),
        string.IsNullOrWhiteSpace(txtOC.Text) ? null : txtOC.Text.Trim(),
        nudPallet.Value,
        Global.DatosApp.InfoUsr.IdUsuario,
        ddlPlanta.SelectedValue,
        txtOCProv.XTextoONulo(),
        chkPorTraslado.Checked,
        txtUsuarioRecep.Tag
      };

      return null != this.XEjecutarProcedimiento(formulariosRefrescar, "RecepcionUpd", objParam);
    }

    private bool CambiarEstado(ESTADO_RECEPCION objEst) {
      bool bol = null != this.XEjecutarProcedimiento(formulariosRefrescar, "RecepcionCambiarEstado", Id, (int)objEst, Global.DatosApp.InfoUsr.IdUsuario);

      if (bol) {
        DataTable dt = Global.DatosApp.TraerTabla("RecepcionSel_Tarjas", new object[] { Id });

        if (dt == null)
          MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        else {


#if !DEBUG

          if (ddlIdTipoDoc.SelectedValue.XEntero() != DOC_PICKING)
            Global.ImprimirDocumento(DOCUMENTO_IMPRIMIR.TarjaIngreso, dt.XConcatenarValoresColumna("Id", "|", false)); 
#endif
        }
      }

      return bol;

    }

    #endregion

    #region Interfaz

    public void LlamadoDesdePrincipal(params object[] parametros) {
      if (this.XGuardaCambios(dtgPrincipal, dtgPallets, dtgProblemas)) {
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
        dtgPrincipal.Vista.Table.Clear();
        dtgProblemas.Vista.Table.Clear();
        dtgPallets.Vista.Table.Clear();
      }
      Id = 0;
      ddlPlanta.SelectedIndex = -1;

      ddlPlanta.Focus();

      ValidarAcceso(true);

      pnlPrincipal.XLimpiarControl();
      txtEstado.Text = "Creado";
      objEstado = ESTADO_RECEPCION.Creado;
      tsbEliminar.Enabled = false;
      tsbReporte.Enabled = false;
      tsbGuardar.Enabled = PuedeActualizar;
      tsbRechazar.Visible = tsbFinalizar.Visible = tsbTerminarConteo.Visible = false;
      tsbReversar.Visible = false;
      tsbNuevo.Enabled = false;
      
      txtOC.ReadOnly = txtrut_clie.ReadOnly = txtnombre_clie.ReadOnly = dtgPrincipal.ReadOnly = false;

      HabilitarGrillaOC(PuedeActualizar && objEstado == ESTADO_RECEPCION.Creado);
      CadenaValoresInicial = CrearCadenaValores();
      ValidaCambios = tsbGuardar.Enabled;
    }

    private void LlenarControles() {
      Cursor = Cursors.WaitCursor;
      dtsDatos = Global.DatosApp.TraerDataset("RecepcionSel_Id", new object[] { Id });
      Cursor = Cursors.Default;

      if (dtsDatos != null) {
        RefrescarGrilla(dtgPrincipal, TomarTabla(TABLAS.Detalle).DefaultView);
        try {
          TomarTabla(TABLAS.ProblemaFoto).Columns["Imagen"].DataType = typeof(byte[]);
        } catch (Exception) {

        }
        RefrescarGrilla(dtgImagenes, TomarTabla(TABLAS.ProblemaFoto).DefaultView);
        RefrescarGrilla(dtgProblemas, TomarTabla(TABLAS.Problema).DefaultView);
        RefrescarGrilla(dtgPallets, TomarTabla(TABLAS.Pallets).DefaultView);

        if (TomarTabla(TABLAS.Principal).Rows.Count == 0) {
          LimpiarControles();
          return;
        }

        DataRow dtr = TomarTabla(TABLAS.Principal).Rows[0];
        EstadoForma = ESTADO_FORMA.Modificando;


        ddlPlanta.DataSource = Global.DatosApp.TomarMisPlantas();
        ddlPlanta.SelectedValue = dtr["IdPlanta"];

        ValidarAcceso(Global.DatosApp.InfoUsr.Plantas.XExisteEnTabla("Id", false, ddlPlanta.SelectedValue));

        objEstado = (ESTADO_RECEPCION)(int)dtr["IdEstado"];
        RefrescarGrilla(dtgPrincipal, TomarTabla(TABLAS.Detalle).DefaultView);
        Id = (int)dtr["Id"];
        txtNumero.Text = dtr["Numero"].ToString();
        dtpFechaIng.Value = (DateTime)dtr["FechaIng"];
        ddlIdTipoDoc.SelectedValue = dtr["IdTipoDoc"];
        txtNumeroDoc.Text = dtr["NumeroDoc"].ToString();
        txtrut_clie.Text = dtr["rut_clie"].ToString();
        txtnombre_clie.Text = dtr["nombre_clie"].ToString();
        txtrut_clie.Tag = dtr["IdCliente"];
        chkPorTraslado.Checked = dtr.XBooleano("PorTraslado");
        
        txtUsuarioRecep.Text = dtr["nombre_empleado"].ToString();
        txtUsuarioRecep.Tag = dtr["IdUsuarioCamion"];

        nudPallet.Value = (int)dtr["CantPallet"];
        txtOC.Text = dtr["OC"].ToString();
        txtOCProv.Text = dtr["OCProv"].ToString();

        txtrut_Prove.Text = dtr["rut_Prove"].ToString();
        txtnombre_Prove.Text = dtr["nombre_Prove"].ToString();
        txtrut_Prove.Tag = dtr["IdProveedor"];
        bolLoteObligatorio = dtr.XBooleano("LoteObliga");
        
        txtEstado.Text = dtr["Estado"].ToString();
        txtObservacion.Text = dtr["Observacion"].ToString();

        tsbEliminar.Enabled = PuedeActualizar && objEstado == ESTADO_RECEPCION.Creado;
        tsbReporte.Enabled = true;
        tsbGuardar.Enabled = PuedeActualizar && objEstado != ESTADO_RECEPCION.Rechazado;
        tsbNuevo.Enabled = PuedeActualizar;
        tsbFinalizar.Visible = PuedeActualizar && ((objEstado == ESTADO_RECEPCION.Creado || objEstado == ESTADO_RECEPCION.PorFinalizar) || (objEstado == ESTADO_RECEPCION.PorFinalizar && Global.DatosApp.TieneAcceso(accesoValidar) == TIPO_ACCESO.Editar)) ;
        tsbRechazar.Visible = PuedeActualizar && (objEstado == ESTADO_RECEPCION.PorFinalizar) && Global.DatosApp.TieneAcceso(accesoValidar) == TIPO_ACCESO.Editar;
        tsbReversar.Visible = PuedeActualizar && objEstado == ESTADO_RECEPCION.Finalizado;
        tsbTerminarConteo.Visible = PuedeActualizar && objEstado == ESTADO_RECEPCION.EnConteo;

        dtgPrincipal_DataBindingComplete(dtgPrincipal, new DataGridViewBindingCompleteEventArgs(System.ComponentModel.ListChangedType.Reset));
        HabilitarGrillaOC(PuedeActualizar && objEstado == ESTADO_RECEPCION.Creado);


        txtrut_clie.ReadOnly = txtnombre_clie.ReadOnly = PuedeActualizar && objEstado != ESTADO_RECEPCION.Creado;


        CadenaValoresInicial = CrearCadenaValores();
        ValidaCambios = tsbGuardar.Enabled;
      } else {
        MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void LlenarDdls() {

      ddlPlanta.DataSource = Global.DatosApp.InfoUsr.Plantas.DefaultView;

      ddlIdTipoDoc.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.DocumentoTributario, "Id > 0 and identifica_tipodoc = 1", ddlIdTipoDoc.DisplayMember);

      ColTipo.DisplayMember = "Nombre";
      ColTipo.ValueMember = "Id";
      ColTipo.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Tipo, "Id > 0", ColTipo.DisplayMember);


      colIdProblema.DisplayMember = "Problema";
      colIdProblema.ValueMember = "Id";
      colIdProblema.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.ProblemaIngreso, "Id > 0", colIdProblema.DisplayMember);



      ColTipoPallet.DisplayMember = "Tipo";
      ColTipoPallet.ValueMember = "Id";
      ColTipoPallet.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.TipoPallet, "Id > 0", ColTipoPallet.DisplayMember);



    }

    private bool Validar() {
      StringBuilder stbError = new StringBuilder();
      long lngVal;

      if (txtrut_clie.Tag == null)
        stbError.AppendLine("Cliente es requerido.");

      if(txtrut_clie.Tag.XEnInt(Global.IdMovipack) && txtrut_Prove.Tag.XEntero() == 0)
        stbError.AppendLine("Proveedor es requerido.");

      if (ddlIdTipoDoc.SelectedValue == null)
        stbError.AppendLine("Tipo doc es requerido.");

      if (string.IsNullOrWhiteSpace(txtNumeroDoc.Text))
        stbError.AppendLine("Número de documento es requerido.");
      else if (!long.TryParse(txtNumeroDoc.Text, out lngVal))
        stbError.AppendLine("Número de documento no válido.");


      if (txtUsuarioRecep.Tag.XEsNuloOVacio())
        stbError.AppendLine("Recepcionador es requerido.");


      if (stbError.Length > 0) {
        stbError.Insert(0, "Campos con errores o vacíos:\n");
        MessageBox.Show(stbError.ToString(), APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;
    }

    private void ValidarFila(DataRow dtrFila) {
      StringBuilder stbError = new StringBuilder();

      if (string.IsNullOrWhiteSpace(dtrFila["IdTipo"].ToString()))
        stbError.AppendLine("Tipo es requerido");

      if (string.IsNullOrWhiteSpace(dtrFila["Descripcion"].ToString()))
        stbError.AppendLine("Descripción es requerido");

      if (string.IsNullOrWhiteSpace(dtrFila["Cantidad"].ToString()))
        stbError.AppendLine("Cantidad es requerido");

      if (!string.IsNullOrWhiteSpace(dtrFila["IdTipo"].ToString()) && (TIPO_DETALLE_FT)(int)dtrFila["IdTipo"] == TIPO_DETALLE_FT.Producto && dtrFila.XBooleano("AplicaVence")) {

        if (string.IsNullOrWhiteSpace(dtrFila["FechaVcto"].ToString()))
          stbError.AppendLine("Fecha de vcto es requerida");
        else if (((DateTime)dtrFila["FechaVcto"]).Date <= DateTime.Now.Date)
          stbError.AppendLine("Fecha de vcto es debe ser mayor a hoy");

      }

      //if (bolLoteObligatorio && string.IsNullOrWhiteSpace(dtrFila["Lote"].ToString()))
      //  stbError.AppendLine("Lote es requerida");



      if (stbError.Length > 0)
        stbError.Insert(0, "Campos con errores o vacíos:\n");
      dtrFila.RowError = stbError.ToString();
    }

    private void ValidarProblema(DataRow dtrFila) {
      StringBuilder stbError = new StringBuilder();

      if (string.IsNullOrWhiteSpace(dtrFila["IdProblema"].ToString()))
        stbError.AppendLine("Incidencia requerido");

      if (string.IsNullOrWhiteSpace(dtrFila["CodProblema"].ToString()))
        stbError.AppendLine("Código es requerido");

      if (string.IsNullOrWhiteSpace(dtrFila["CantProblema"].ToString()))
        stbError.AppendLine("Cantidad es requerido");

      if (stbError.Length > 0)
        stbError.Insert(0, "Campos con errores o vacíos:\n");
      dtrFila.RowError = stbError.ToString();
    }

    private void HabilitarGrillaOC(bool bolPuedeEditar) {
      dtgPrincipal.ReadOnly = false;
      if (bolPuedeEditar) {
        dtgPrincipal.ActivarOpcionMenu(Grilla.OPC_MENU.Agregar);
        dtgPrincipal.ActivarOpcionMenu(Grilla.OPC_MENU.Eliminar);
        dtgPrincipal.ActivarOpcionMenu(Grilla.OPC_MENU.EditarMasivo);
        dtgPrincipal.ActivarOpcionMenu(Grilla.OPC_MENU.Copiar);

        ColTipo.ReadOnly = false;

      } else {
        dtgPrincipal.DesctivarOpcionMenu(Grilla.OPC_MENU.Agregar);
        dtgPrincipal.DesctivarOpcionMenu(Grilla.OPC_MENU.Eliminar);
        dtgPrincipal.DesctivarOpcionMenu(Grilla.OPC_MENU.EditarMasivo);
        dtgPrincipal.DesctivarOpcionMenu(Grilla.OPC_MENU.Copiar);

        ColTipo.ReadOnly = true;

      }
    }

    #endregion

    #region Acciones

    public override bool HayCambios() {
      return base.HayCambios() || dtgPrincipal.HayCambios || dtgProblemas.HayCambios || dtgImagenes.HayCambios || dtgPallets.HayCambios;
    }

    private void MostrarReporte() {
      Reporte objReporte = null;
      object[] objParam;
      switch ((REPORTES)ddlReporte.SelectedIndex) {
        case REPORTES.Detalle:
          objParam = new object[] { Id };

          Cursor = Cursors.WaitCursor;
          dtsDatos = APP_GEN.Global.DatosApp.TraerDataset("RecepcionFichaSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.FichaRecepcion.rdlc", "Reportes");
          objReporte.Titulo = "Ficha de recepción";

          foreach (DataTable dttReporte in dtsDatos.Tables) {
            objReporte.Datos.Add(dttReporte);
          }
          objReporte.Parametros.Add("Usuario", APP_GEN.Global.DatosApp.InfoUsr.Nombre);
          Cursor = Cursors.Default;
          break;
      }

      if (objReporte != null)
        objReporte.MostrarReporte(APP_GEN.Global.FormaPrincipal);
    }

    private DataTable TomarTabla(TABLAS objTabla) {
      return dtsDatos.Tables[(int)objTabla];
    }

    private void LlamaBuscadorCliente(string strCodigo, string strNombre) {
      var dttTabla = Global.BuscarEntidad(strCodigo, strNombre, true, true);
      if (dttTabla != null) {
        if (dttTabla.Rows.Count > 0) {
          var dtrFila = dttTabla.Rows[0];
          txtrut_clie.Text = dtrFila["rut_clie"].ToString();
          txtnombre_clie.Text = dtrFila["nombre_clie"].ToString();
          txtrut_clie.Tag = dtrFila["Id"];
          bolLoteObligatorio = dtrFila.XBooleano("LoteObliga");
          
        }
      } else {
        txtrut_clie.Tag = null;
      }
    }

    private void LlamaBuscadorProveedor(string strCodigo, string strNombre) {
      var dttTabla = Global.BuscarEntidad(strCodigo, strNombre, true, false, false, true);
      if (dttTabla != null) {
        if (dttTabla.Rows.Count > 0) {
          var dtrFila = dttTabla.Rows[0];
          txtrut_Prove.Text = dtrFila["rut_clie"].ToString();
          txtnombre_Prove.Text = dtrFila["nombre_clie"].ToString();
          txtrut_Prove.Tag = dtrFila["Id"];
        }
      } else {
        txtrut_Prove.Tag = null;
      }
    }

    private void LlamaBuscadorUsuario(string nombre) {
      DataTable dttDato;
      dttDato = APP_GEN.Global.BuscarUsuario("", nombre);
      if (dttDato != null) {
        txtUsuarioRecep.Text = dttDato.Rows[0]["nombre_empleado"].ToString();
        txtUsuarioRecep.Tag = dttDato.Rows[0]["Id"];
      } else {
        txtUsuarioRecep.Tag = null;
        txtUsuarioRecep.Focus();
      }
    }

    private void LlamaBuscadorIsnumo(string strCodigo, string strDescripcion) {
      var dttTabla = Global.BuscarInsumo(txtrut_clie.Tag.XEntero(), strCodigo, strDescripcion, true, true);
      if (dttTabla != null) {
        if (dttTabla.Rows.Count > 0) {

          DataRow dtr = dttTabla.Rows[0];

          DataRow dtrNueva = dtgPrincipal.FilaActual;
          
          dtrNueva["IdTipo"] = dtr["IdTipo"];
          dtrNueva["Descripcion"] = dtr["Descripcion"];
          dtrNueva["Codigo"] = dtr["Codigo"];
          
        }
      }
    }

    #endregion

    #region Eventos de barra

    private void tsbReversar_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a reversar la recepción ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (CambiarEstado(ESTADO_RECEPCION.Creado)) {
          RefrescarTodo();
        }
      }
    }

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
      if (this.XGuardaCambios(dtgPrincipal, dtgPallets, dtgProblemas)) {
        LimpiarControles();
      }
    }

    private void tsbRefrescar_Click(object sender, EventArgs e) {
      if (this.XGuardaCambios(dtgPrincipal, dtgPallets, dtgProblemas)) {
        RefrescarTodo();
      }
    }

    private void tsbReporte_Click(object sender, EventArgs e) {
      MostrarReporte();
    }

    private void tsbFinalizar_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a finalizar la recepción ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (CambiarEstado(ESTADO_RECEPCION.Finalizado)) {
          RefrescarTodo();
        }
      }
    }

    private void tsbTerminarConteo_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a finalizar el conteo ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (CambiarEstado(ESTADO_RECEPCION.Finalizado))
          RefrescarTodo();
      }
    }

    #endregion

    #region Eventos de controles

    private void Control_Enter(object sender, EventArgs e) {
      sender.XSeleccionarTextoEnControl();
    }

    private void txtrut_clie_TextChanged(object sender, EventArgs e) {
      txtrut_clie.Tag = null;
    }

    private void txtrut_clie_Validated(object sender, EventArgs e) {
      if (txtrut_clie.Tag == null && !string.IsNullOrWhiteSpace(txtrut_clie.Text))
        LlamaBuscadorCliente(txtrut_clie.Text, "");
    }

    private void txtnombre_clie_Validated(object sender, EventArgs e) {
      if (txtrut_clie.Tag == null && !string.IsNullOrWhiteSpace(txtnombre_clie.Text))
        LlamaBuscadorCliente("", txtnombre_clie.Text);
    }

    private void btnBuscarCliente_Click(object sender, EventArgs e) {
      LlamaBuscadorCliente(null, null);
    }

    private void txtrut_Prove_TextChanged(object sender, EventArgs e) {
      txtrut_Prove.Tag = null;
    }

    private void txtrut_Prove_Validated(object sender, EventArgs e) {
      if (txtrut_Prove.Tag == null && !string.IsNullOrWhiteSpace(txtrut_Prove.Text))
        LlamaBuscadorProveedor(txtrut_Prove.Text, "");

    }

    private void txtnombre_Prove_Validated(object sender, EventArgs e) {
      if (txtrut_Prove.Tag == null && !string.IsNullOrWhiteSpace(txtnombre_Prove.Text))
        LlamaBuscadorProveedor("", txtnombre_Prove.Text);
    }

    private void btnCargarImagenes_Click(object sender, EventArgs e) {
      DataRow dtr = dtgProblemas.FilaActual;
      if (dtr == null) {
        MessageBox.Show("Debe seleccionar un problema antes de subir las imagenes", Global.STR_INFORMACION, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        return;
      }

      if (dtr.RowState == DataRowState.Added) {
        MessageBox.Show("Debe guardar todo antes de subir las imagenes", Global.STR_INFORMACION, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        return;
      }

      OpenFileDialog ofd = new OpenFileDialog();
      ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
      ofd.Multiselect = true;
      if (ofd.ShowDialog() == DialogResult.OK) {

        foreach (string item in ofd.FileNames) {
          if (dtgImagenes.Vista.Count >= 3) {
            MessageBox.Show("Solo se permite un máximo de 3 imagenes por insidencia.", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }
          string strExtension = Path.GetExtension(item).ToUpper();

          if (strExtension.Contains("BMP") || strExtension.Contains("JPG") || strExtension.Contains("GIF") || strExtension.Contains("PNG")) {
            DataRow dtrImagenes = dtgImagenes.Vista.Table.NewRow();

            dtrImagenes["Id"] = 0;
            dtrImagenes["IdRecProblema"] = TomarId(dtgProblemas);
            dtrImagenes["NombreImagen"] = Path.GetFileName(item);
            string strError = "";
            dtrImagenes["Imagen"] = FuncGen.FileToByte(item, ref strError);

            dtgImagenes.Vista.Table.Rows.Add(dtrImagenes);

          }

        }

      }

    }

    #endregion

    #region Eventos de grilla

    private void dtgPrincipal_AntesInsertar(object sender, FilaEventArg e) {
      e.Fila["Mixto"] = false;
      e.Fila["AplicaVence"] = false;
      e.Fila["VerOS"] = "Ver OS";
      int intCant = 0;

      if(dtgPrincipal.Vista.Table.Rows.Count > 0)
        intCant = dtgPrincipal.Vista.Table.AsEnumerable().Where(s => s.RowState != DataRowState.Deleted).Max(s => s.XEntero("Numero"));

      e.Fila["Numero"] = intCant + 1;
      bolAgregando = true;
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
      if (e.RowIndex < 0)
        return;

      DataRow dtr = dtgPrincipal.FilaActual;
      if (e.ColumnIndex == colCodigo.Index) {

        string strCodigo = "", strDescripcion = "";
        if (e.ColumnIndex == colCodigo.Index)
          strCodigo = dtr["Codigo"].ToString();
        else
          strDescripcion = dtr["Descripcion"].ToString();

        LlamaBuscadorIsnumo(strCodigo, strDescripcion);

      } else if (e.ColumnIndex == ColTipo.Index) {

        if ((TIPO_DETALLE_FT)(int)dtr["IdTipo"] == TIPO_DETALLE_FT.Insumo) {
          dtr["AplicaVence"] = false;
          dtgPrincipal.CurrentRow.Cells[ColAplicaVence.Index].ReadOnly = true;
        } else {
          dtr["AplicaVence"] = true;
          dtgPrincipal.CurrentRow.Cells[ColAplicaVence.Index].ReadOnly = false;
        }
        dtgPrincipal.InvalidateRow(dtgPrincipal.CurrentRow.Index);
      } else if (e.ColumnIndex == ColAplicaVence.Index) {
        if (!dtr.XBooleano("AplicaVence"))
          dtr["FechaVcto"] = DBNull.Value;

        dtgPrincipal.CurrentRow.Cells[ColFechaVcto.Index].ReadOnly = !dtr.XBooleano("AplicaVence");
        dtgPrincipal.InvalidateRow(dtgPrincipal.CurrentRow.Index);

      } else if (e.ColumnIndex == ColBodega.Index) {
        DataGridViewComboBoxCell combo = dtgPrincipal.CurrentRow.Cells[ColRack.Index] as DataGridViewComboBoxCell;
        combo.DisplayMember = "Nombre";
        combo.ValueMember = "Id";
        combo.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Rack, string.Format("id_bodega={0}", dtgPrincipal.FilaActual.XEntero("id_bodega")), combo.DisplayMember); 
      } else if (e.ColumnIndex == ColRack.Index) {
        DataGridViewComboBoxCell combo = dtgPrincipal.CurrentRow.Cells[ColPosicion.Index] as DataGridViewComboBoxCell;
        combo.DisplayMember = "Nombre";
        combo.ValueMember = "Id";
        combo.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Posiciones, string.Format("IdRack={0} and IdEstado = 1", dtgPrincipal.FilaActual.XEntero("id_rack")), combo.DisplayMember);
      }
    }

    private void dtgPrincipal_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) {

    }

    private void dtgPrincipal_DespuesCambioFila(object sender, FilaGrillaEventArg e) {
      if (e.FilaDatos != null && bolAgregando)
        dtgPrincipal.PosicionarEnCelda(colLote.Index, e.FilaGrilla.Index);

      if (objEstado == ESTADO_RECEPCION.EnConteo && e.FilaDatos != null && e.FilaDatos.RowState != DataRowState.Added) {
        dtgPrincipal.DesctivarOpcionMenu(Grilla.OPC_MENU.Eliminar);
      } else
        dtgPrincipal.ActivarOpcionMenu(Grilla.OPC_MENU.Eliminar);

      bolAgregando = false;
    }

    private void dtgPrincipal_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
      if (e.ListChangedType == System.ComponentModel.ListChangedType.Reset)
        foreach (DataGridViewRow item in dtgPrincipal.Rows) {
          DataRow dtr = ((DataRowView)item.DataBoundItem).Row;
          item.Cells[ColTipo.Index].ReadOnly = objEstado != ESTADO_RECEPCION.Creado;
          item.Cells[ColFechaVcto.Index].ReadOnly = (TIPO_DETALLE_FT)(int)dtr["IdTipo"] == TIPO_DETALLE_FT.Producto && !dtr.XBooleano("AplicaVence");
          item.Cells[ColAplicaVence.Index].ReadOnly = (TIPO_DETALLE_FT)(int)dtr["IdTipo"] == TIPO_DETALLE_FT.Insumo && objEstado != ESTADO_RECEPCION.Creado;

          DataGridViewComboBoxCell combo = item.Cells[ColRack.Index] as DataGridViewComboBoxCell;
          combo.DisplayMember = "Nombre";
          combo.ValueMember = "Id";
          combo.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Rack, string.Format("id_bodega={0}", dtr.XEntero("id_bodega")), combo.DisplayMember);

          combo = item.Cells[ColPosicion.Index] as DataGridViewComboBoxCell;
          combo.DisplayMember = "Nombre";
          combo.ValueMember = "Id";
          combo.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Posiciones, string.Format("(IdRack={0} and IdEstado = 1) or Id = {1}", dtr.XEntero("id_rack"), dtr.XEntero("IdPosicion")), combo.DisplayMember);
        }
    }

    private void dtgProblemas_AntesInsertar(object sender, FilaEventArg e) {
      e.Fila["IdRecepcion"] = Id;
      ValidarProblema(e.Fila);
    }

    private void dtgProblemas_DespuesModificarFila(object sender, FilaEventArg e) {
      ValidarProblema(e.Fila);
    }
    #endregion

    #region Persistencia

    private enum Llaves {
      Grilla = 100
    }

    protected override void CargarForma() {
      base.CargarForma();
      CargarGrilla(dtgPrincipal, (int)Llaves.Grilla);
    }

    protected override void SalvarForma() {
      base.SalvarForma();
      SalvarGrilla(dtgPrincipal, (int)Llaves.Grilla);
    }

    #endregion

    private void dtgImagenes_CellContentClick(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex == -1) return;

      DataRow dtr = dtgImagenes.FilaActual;
      if (e.ColumnIndex == ColVer.Index) {
        if (dtr.RowState == DataRowState.Added) return;
        ITDError objError = null;

        Cursor = Cursors.WaitCursor;
        byte[] byt = Global.Transfer.TomarArchivoBytes(dtr["NombreImagen"].ToString(), (DateTime)dtr["FechaImagen"], "RecepcionProblemaFotoSel", new object[] { null, TomarId(dtgImagenes) }, ref objError);
        Cursor = Cursors.Default;

        if (byt == null) {
          MessageBox.Show(ProcesarError(objError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        string strArchivo = Global.Transfer.TomarArchivoRuta(dtr["NombreImagen"].ToString(), (DateTime)dtr["FechaImagen"], ref objError);


        if (!string.IsNullOrWhiteSpace(strArchivo))
          System.Diagnostics.Process.Start(strArchivo);
        else
          MessageBox.Show(ProcesarError(objError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);

      } else if (e.ColumnIndex == ColEliminar.Index) {
        dtr.Delete();
      }
    }

    private void dtgProblemas_DespuesCambioFila(object sender, FilaGrillaEventArg e) {
      int intId = 0;

      if (e.FilaDatos != null) {
        intId = (int)e.FilaDatos["Id"];
      }

      dtgImagenes.Vista.RowFilter = string.Format("IdRecProblema={0}", intId);

    }

    private void btnVerOS_Click(object sender, EventArgs e) {
      if (txtnombre_clie.Text.XEsNuloOVacio()) {
        MessageBox.Show("Debe buscar el cliente primero.", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }


      Global.LlamarFormulario<OrdenServicioDetCons>(false, new object[] { txtnombre_clie.Text });
    }

    private void dtgPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex == -1)
        return;

      if (e.ColumnIndex == ColVerOS.Index) {
        string strCodigo = dtgPrincipal.FilaActual["Codigo"].ToString();

        if (!strCodigo.XEsNuloOVacio()) {
          Global.LlamarFormulario<RecepcionVerOS>(true, strCodigo, txtrut_clie.Tag.XEntero());
        }
      }
    }

    private void txtnombre_clie_TextChanged(object sender, EventArgs e) {

    }

    private void txtUsuarioRecep_TextChanged(object sender, EventArgs e) {
      txtUsuarioRecep.Tag = null;
    }

    private void txtUsuarioRecep_Validated(object sender, EventArgs e) {

      if (!string.IsNullOrEmpty(txtUsuarioRecep.Text.Trim()) && txtUsuarioRecep.Tag == null) {
        LlamaBuscadorUsuario(txtUsuarioRecep.Text);
      }
    }

    private void ddlPlanta_SelectedIndexChanged(object sender, EventArgs e) {
      ColBodega.DisplayMember = "Bodega";
      ColBodega.ValueMember = "Id";
      ColBodega.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Bodega, string.Format("Id > 0 and id_planta={0}",ddlPlanta.SelectedValue.XEntero()), ColBodega.DisplayMember);
    }

    private void tsbRechazar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Va a Rechazar la recepción ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
      {
        if (CambiarEstado(ESTADO_RECEPCION.Rechazado))
        {
          RefrescarTodo();
        }
      }
    }
  }
}