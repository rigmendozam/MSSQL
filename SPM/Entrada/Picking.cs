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
using ITD.Log;
using System.Drawing;

namespace APP {

  public partial class Picking : FrmBaseGrid {

    #region Declaraciones

    #region Por Defecto

    private static readonly ACCESO_OPCION Acceso = ACCESO_OPCION.Picking;
    private static readonly ACCESO_OPCION RecibirPicking = ACCESO_OPCION.RecibirPicking;
    private static readonly ACCESO_OPCION AutorizarPicking = ACCESO_OPCION.PickingAutoriza;
    private static readonly ACCESO_OPCION PickingCambioProc = ACCESO_OPCION.PickingCambioProc;
    private static readonly ACCESO_OPCION PickingRech = ACCESO_OPCION.PickingRech;
    private static readonly ACCESO_OPCION Segregacion = ACCESO_OPCION.Segregacion;

    private DataSet dtsDatos;

    private Type[] formulariosRefrescar = new Type[] {
      typeof(PickingCons)
    };

    bool bolRecibirPicking;

    private enum REPORTES {
      Detalle,
      PickingOT
    }

    private enum TABLAS {
      Principal = 0,
      PTT = 1,
      Detalle = 2,
      //DistribucionOT = 3,
      CompDePicking = 3,
      Participantes = 4,
      Lineas = 5,
      Movipack = 6
    }

    public static bool TieneAcceso {
      get { return Global.DatosApp.TieneAcceso(Acceso) != TIPO_ACCESO.Sin_Acceso || Global.DatosApp.TieneAcceso(RecibirPicking) != TIPO_ACCESO.Sin_Acceso; }
    }

    public int Id { get; set; }

    public object[] Parametros { set { Id = (int)value[0] ; } }
    int intIdDetOT;
    #endregion

    ESTADO_PICKING objEstado;

    Color colorMuestra = Color.LightSteelBlue;
    
    bool bolAutoriza = false;
    bool bolPickingCambioProc = false;
    bool bolPickingRech = false;
    bool bolLoteObliga = false;
    bool bolSegregacion = false;

    #endregion

    #region Inicial

    public Picking() {
      InitializeComponent();
      LlenarDdls();
    }

    private void ActualizacionGrilla_Load(object sender, EventArgs e) {
      InicializarParametros();
      RefrescarTodo();
    }

    private void InicializarParametros() {
      ValidarCambios(spcPrincipal.Panel1);

      if (ddlReporte.Items.Count > 0) {
        ddlReporte.SelectedIndex = (int)REPORTES.Detalle;
        ddlReporte.Visible = ddlReporte.Items.Count > 1;
      } else
        tsbReporte.Visible = ddlReporte.Visible = false;


      tbcPrincipal.TabPages.RemoveAt(0);
      lblEnMuestra.BackColor = colorMuestra;
    }

    private void ValidarAcceso(bool bolAccesoPlanta) {
      PuedeActualizar = Global.DatosApp.TieneAcceso(Acceso) == TIPO_ACCESO.Editar && bolAccesoPlanta;
      bolRecibirPicking = Global.DatosApp.TieneAcceso(RecibirPicking) == TIPO_ACCESO.Editar && bolAccesoPlanta;
      bolAutoriza = Global.DatosApp.TieneAcceso(AutorizarPicking) == TIPO_ACCESO.Editar && bolAccesoPlanta;
      bolPickingCambioProc = Global.DatosApp.TieneAcceso(PickingCambioProc) == TIPO_ACCESO.Editar && bolAccesoPlanta;
      bolPickingRech = Global.DatosApp.TieneAcceso(PickingRech) == TIPO_ACCESO.Editar && bolAccesoPlanta;
      bolSegregacion = Global.DatosApp.TieneAcceso(Segregacion) == TIPO_ACCESO.Editar;
    }

    #endregion
    
    #region Actualizacion

    public override GUARDAR_RESULT GuardarTodo() {
      GUARDAR_RESULT resultado = GUARDAR_RESULT.CanceladoGuardar;
      if (!dtgPrincipal.FinalizaEdicion() || !dtgPTT.FinalizaEdicion() || !dtgParticipantes.FinalizaEdicion()|| !dtgMovipack.FinalizaEdicion()) {
        return resultado;
      }

      if (!Validar()) {
        return resultado;
      }

      if (dtgPrincipal.HayErrores || dtgPTT.HayErrores || dtgPTT.HayErrores|| dtgMovipack.HayErrores) {
        MessageBox.Show("No se pueden guardar los cambios porque existen filas con errores.", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return resultado;
      }

      bool bolOK = EstadoForma == ESTADO_FORMA.Agregando ? Insertar() :  Modificar();
      Cursor = Cursors.WaitCursor;

      if (bolOK) {
        EstadoForma = ESTADO_FORMA.Modificando;
        resultado = GUARDAR_RESULT.GuardadoOk;

        bool bolHayError = false;

        var listaCambios = TomarFilasModificadas(dtgPrincipal);
        var listaResultados = Global.DatosApp.ActualizarMasivo("PickingDet", listaCambios, false);
        SincronizarCambios(dtgPrincipal, listaResultados);

        bolHayError = dtgPrincipal.HayErrores;

        listaCambios = TomarFilasModificadas(dtgParticipantes);
        listaResultados = Global.DatosApp.ActualizarMasivo("PickingParticipante", listaCambios, false);
        SincronizarCambios(dtgParticipantes, listaResultados);

        if(!bolHayError)
          bolHayError = dtgParticipantes.HayErrores;
        
        listaCambios = TomarFilasModificadas(dtgPTT);
        listaResultados = Global.DatosApp.ActualizarMasivo("PickingPTT", listaCambios, false);
        SincronizarCambios(dtgPTT, listaResultados);

        if (!bolHayError)
          bolHayError = dtgPTT.HayErrores;

        listaCambios = TomarFilasModificadas(dtgMovipack);
        listaResultados = Global.DatosApp.ActualizarMasivo("PickingExistencia", listaCambios, false);
        SincronizarCambios(dtgMovipack, listaResultados);

        if (!bolHayError)
          bolHayError = dtgMovipack.HayErrores;


        if (bolHayError) {
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
      if (dtgParticipantes == dtgGrilla) {
        dtrFila["IdPicking"] = Id;
        return dtrFila.ItemArray.Take(dtrFila.ItemArray.Length - 1).ToArray();
      }
      else if (dtgPTT == dtgGrilla) {
        dtrFila["IdPicking"] = Id;
        return dtrFila.ItemArray.Take(7).ToArray();
      }
      else
        return new object[] { 0, Id, dtrFila["IdDetPTT"], dtrFila["Id"], dtrFila["cant_detPick"] };
    }

    protected override object[] TomarParametrosAModificar(DataGridView dtgGrilla, DataRow dtrFila) {
      if (dtgParticipantes == dtgGrilla) {
        return dtrFila.ItemArray.Take(dtrFila.ItemArray.Length - 1).ToArray();
      } else if (dtgPTT == dtgGrilla) {
        dtrFila["IdPicking"] = Id;
        return dtrFila.ItemArray.Take(7).ToArray();
      } else if (dtgMovipack == dtgGrilla) {
        dtrFila["IdPicking"] = Id;
        return dtrFila.ItemArray.Take(5).ToArray();
      } else
        return new object[] { dtrFila["IdPickingDet"], Id, dtrFila["IdDetPTT"], dtrFila["Id"], dtrFila["cant_detPick"] };
    }

    private bool Eliminar() {
      return null != this.XEjecutarProcedimiento(formulariosRefrescar, "PickingDel", Id);
    }

    private bool Insertar() {
      object[] objParam = new object[] {
        0,
        txtid_OT.Tag,
        string.IsNullOrWhiteSpace(txtobs_picking.Text) ? null : txtobs_picking.Text.Trim(),
        ddlPlanta.SelectedValue,
        Global.DatosApp.InfoUsr.IdUsuario,
        dtpFecha.Value,
        ddlLinea.SelectedValue
      };

      objParam = this.XEjecutarProcedimiento(formulariosRefrescar, "PickingIns", objParam);

      if (objParam != null)
        Id = (int)objParam[0];

      return objParam != null;
    }

    private bool Modificar() {
      object[] objParam = new object[] {
        Id,
        string.IsNullOrWhiteSpace(txtobs_picking.Text) ? null : txtobs_picking.Text.Trim(),
        Global.DatosApp.InfoUsr.IdUsuario,
        dtpFecha.Value,
        ddlLinea.SelectedValue
      };

      return null != this.XEjecutarProcedimiento(formulariosRefrescar, "PickingUpd", objParam);
    }
    
    private bool CambiarEstado(ESTADO_PICKING objNuevoEstado, int? intIdMotivo, string strObsMotivo, int? intIdResponsable) {
      return null != this.XEjecutarProcedimiento(formulariosRefrescar, "PickingCambioEstado", Id, (int)objNuevoEstado, Global.DatosApp.InfoUsr.IdUsuario, intIdMotivo, strObsMotivo, intIdResponsable);
    }

    public override string ProcesarError(ITDError objError) {
      return base.ProcesarError(objError);
    }

    private bool TiempoPrepara() {
      return null != this.XEjecutarProcedimiento(formulariosRefrescar, "PickingTiempoPreparaUpd", Id, Global.DatosApp.InfoUsr.IdUsuario);
    }

    private bool Autorizar() {
      return null != this.XEjecutarProcedimiento(formulariosRefrescar, "PickingAutorizar", Id, Global.DatosApp.InfoUsr.IdUsuario);
    }
    
    private bool Copiar() {
      object[] objParam = this.XEjecutarProcedimiento(formulariosRefrescar, "PickingCopiar", 0, Id, Global.DatosApp.InfoUsr.IdUsuario);

      if (objParam != null) {
        Id = objParam[0].XEntero();
      }

      return objParam != null;
    }
    
    #endregion

    #region Interfaz

    public void LlamadoDesdePrincipal(params object[] parametros) {
      if (this.XGuardaCambios(dtgPrincipal, dtgParticipantes, dtgPTT)) {
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
        dtgPTT.Vista.Table.Clear();
      }
      Id = 0;
      objEstado = ESTADO_PICKING.Creado;
      spcPrincipal.Panel1.XLimpiarControl();
      
      txtid_OT.Focus();
      txtid_OT.ReadOnly = false;
      dtgPrincipal.ReadOnly = false;
      tsbProcesar.Visible = false;
      tsbCancelar.Visible = false;
      tsbRechazar.Visible = false;
      tsbValidar.Visible  = false;
      tsbEntregar.Visible = false;
      tsbAutorizar.Visible = false;
      tsbPreparar.Visible = false;
      tsbCopiar.Visible = false;
      tsbSegregar.Visible = false;

      tsbEliminar.Enabled = false;
      tsbReporte.Enabled = false;
      tsbGuardar.Enabled = PuedeActualizar;
      tsbNuevo.Enabled = false;
      CadenaValoresInicial = CrearCadenaValores();
      ValidaCambios = tsbGuardar.Enabled;
    }

    private void LlenarControles() {
      Cursor = Cursors.WaitCursor;
      dtsDatos = Global.DatosApp.TraerDataset("PickingSel_Id", new object[] { Id });
      Cursor = Cursors.Default;

      if (!tbcProd.TabPages.Contains(tbpExistencia))
        tbcProd.TabPages.Add(tbpExistencia);

      if (dtsDatos != null) {
        RefrescarGrilla(dtgPrincipal, TomarTabla(TABLAS.Detalle).DefaultView);
        //RefrescarGrilla(dtgDistribucionOT, TomarTabla(TABLAS.DistribucionOT).DefaultView);
        RefrescarGrilla(dtgPTT, TomarTabla(TABLAS.PTT).DefaultView);
        RefrescarGrilla(dtgComponentes, TomarTabla(TABLAS.CompDePicking).DefaultView);
        RefrescarGrilla(dtgParticipantes, TomarTabla(TABLAS.Participantes).DefaultView);
        RefrescarGrilla(dtgMovipack, TomarTabla(TABLAS.Movipack).DefaultView);

        if (TomarTabla(TABLAS.Principal).Rows.Count == 0) {
          LimpiarControles();
          return;
        }

        DataRow dtr = TomarTabla(TABLAS.Principal).Rows[0];
        EstadoForma = ESTADO_FORMA.Modificando;

        Id = (int)dtr["Id"];

        ddlPlanta.SelectedValue = dtr["id_planta"];
        objEstado = (ESTADO_PICKING)(int)dtr["IdEstado"];
        txtrut_clie.Text = dtr["rut_clie"].ToString();
        txtrut_clie.Tag = dtr.XEntero("IdCliente");
        txtnombre_clie.Text = dtr["nombre_clie"].ToString();
        txtid_picking.Text = dtr["id_picking"].ToString();
        txtobs_picking.Text = dtr["obs_picking"].ToString();
        txtCantProgramado.Text = ((int)dtr["CantPrograma"]).ToString("#,##0");
        txtid_OT.Text = dtr["id_OT"].ToString();
        txtid_OT.Tag = dtr["IdOT"];
        txtid_OT.ReadOnly = true;
        txtEstado.Text = dtr["Estado"].ToString();
        intIdDetOT = dtr.XEntero("IdDetOT");
        bolLoteObliga = dtr.XBooleano("LoteObliga");

        try {
          dtpFecha.Value = dtr.XFechaHora("Fecha");
        } catch (Exception ex) {
          dtpFecha.Value = DateTime.Now.Date;
        }
        //dtpFecha.Enabled = false;
        ddlLinea.DataSource = new DataView(TomarTabla(TABLAS.Lineas), string.Format("Fecha=#{0}#", dtpFecha.Value.ToString("yyyy/MM/dd")), "", DataViewRowState.OriginalRows);
        ddlLinea.SelectedValue = dtr["IdLinea"];
        //ddlLinea.Enabled = false;

        ValidarAcceso(Global.DatosApp.InfoUsr.Plantas.XExisteEnTabla("Id", false, ddlPlanta.SelectedValue));

        tsbEliminar.Enabled = PuedeActualizar && objEstado == ESTADO_PICKING.Creado;
        tsbReporte.Enabled = true;
        tsbGuardar.Enabled = PuedeActualizar && (objEstado == ESTADO_PICKING.Creado || objEstado == ESTADO_PICKING.Entregado || objEstado == ESTADO_PICKING.Rechazado || objEstado == ESTADO_PICKING.PorPreparar); 
        tsbNuevo.Enabled = PuedeActualizar;
        
        dtgPrincipal.ReadOnly = !PuedeActualizar || objEstado != ESTADO_PICKING.Creado;
        
        tsbProcesar.Visible = PuedeActualizar && objEstado == ESTADO_PICKING.Creado;

        tsbPreparar.Visible = PuedeActualizar && objEstado == ESTADO_PICKING.PorPreparar;
        tsbPreparado.Visible = PuedeActualizar && objEstado == ESTADO_PICKING.EnPreparacion;
        tsbEntregar.Visible = PuedeActualizar && (objEstado == ESTADO_PICKING.Preparado || objEstado == ESTADO_PICKING.Rechazado);

        tsbSegregar.Visible = bolSegregacion && (objEstado == ESTADO_PICKING.Creado || objEstado == ESTADO_PICKING.PorPreparar || objEstado == ESTADO_PICKING.Preparado || objEstado == ESTADO_PICKING.Cancelado || objEstado == ESTADO_PICKING.Rechazado);

        tsbCancelar.Visible = PuedeActualizar && objEstado.XEnInt(ESTADO_PICKING.EnPreparacion, ESTADO_PICKING.PorPreparar, ESTADO_PICKING.Preparado);
        tsbRechazar.Visible = (bolPickingRech || Global.DatosApp.InfoUsr.TipoUsuario == USUARIO_TIPO.EncargadadeLinea ) && (objEstado == ESTADO_PICKING.Entregado || objEstado == ESTADO_PICKING.Validado);
        tsbValidar.Visible = PuedeActualizar && bolRecibirPicking && (objEstado == ESTADO_PICKING.Entregado );
        tsbCopiar.Visible = PuedeActualizar && objEstado.XEnInt(ESTADO_PICKING.Cancelado);
        tsbAutorizar.Visible = bolAutoriza && !dtr.XEsNuloOVacio("Autoriza") && !dtr.XBooleano("Autoriza") && objEstado == ESTADO_PICKING.Creado;
        tsbCambiarProceso.Visible = PuedeActualizar && bolPickingCambioProc && objEstado.XEnInt(ESTADO_PICKING.EnPreparacion, ESTADO_PICKING.PorPreparar, ESTADO_PICKING.Preparado, ESTADO_PICKING.Entregado);


        CadenaValoresInicial = CrearCadenaValores();
        ValidaCambios = tsbGuardar.Enabled;
      } else {
        MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void LlenarDdls() {

      ddlPlanta.DataSource = Global.DatosApp.TomarMisPlantas();

    }

    private bool Validar() {
      StringBuilder stbError = new StringBuilder();
      if (bolLoteObliga && dtgPTT.FilaActual.XEsNuloOVacio("Lote"))
        stbError.AppendLine("Debe ingresar el Lote de transformación");

      if (stbError.Length > 0) {
        stbError.Insert(0, "Campos con errores o vacíos:\n");
        MessageBox.Show(stbError.ToString(), APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;
    }

    private void ValidarFila(DataRow dtrFila) {
      StringBuilder stbError = new StringBuilder();

      if (!dtrFila.IsNull("cant_detPick") && (int)dtrFila["cant_detPick"] > (int)dtrFila["Stock"])
        stbError.AppendLine("La cantidad del picking no debe ser mayor que el stock.");

      if (stbError.Length > 0)
        stbError.Insert(0, "Campos con errores o vacíos:\n");
      dtrFila.RowError = stbError.ToString();
    }

    private void ValidarFilaParticipante(DataRow dtrFila) {
      StringBuilder stbError = new StringBuilder();

      if (dtrFila.IsNull("IdParticipante") || string.IsNullOrWhiteSpace(dtrFila["nombre_empleado"].ToString()))
        stbError.AppendLine("Participante es requerido.");

      if (stbError.Length > 0)
        stbError.Insert(0, "Campos con errores o vacíos:\n");
      dtrFila.RowError = stbError.ToString();
    }

    private void ValidarFilaMovipack(DataRow dtr) {
      StringBuilder stbError = new StringBuilder();

      if (dtr.XEsNuloOVacio("IdTarjaIngreso"))
        stbError.AppendLine("Producto/Insumo es requerido");

      if (dtr.XEsNuloOVacio("Cantidad"))
        stbError.AppendLine("Cantidad es requerido");
      else if(dtr.XDecimal("Cantidad") > dtr.XDecimal("cant_taring"))
        stbError.AppendLine("La cantidad no puede ser mayor que el saldo");

      if (stbError.Length > 0) {
        stbError.Insert(0, "Campos con errores o vacíos.\n");
      }
      dtr.RowError = stbError.ToString();
    }

    private void LlenarcontrolesOT() {
      Cursor = Cursors.WaitCursor;
      dtsDatos = Global.DatosApp.TraerDataset("PickingSel_OT", new object[] { txtid_OT.Text });
      Cursor = Cursors.Default;

      if (dtsDatos != null) {
        TomarTabla(TABLAS.PTT).AsEnumerable().ToList().ForEach(s => s.SetAdded());
        RefrescarGrilla(dtgPrincipal, TomarTabla(TABLAS.Detalle).DefaultView);
        //RefrescarGrilla(dtgDistribucionOT, TomarTabla(TABLAS.DistribucionOT).DefaultView);
        RefrescarGrilla(dtgPTT, TomarTabla(TABLAS.PTT).DefaultView);
        RefrescarGrilla(dtgComponentes, TomarTabla(TABLAS.CompDePicking).DefaultView);

        DataRow dtr = TomarTabla(TABLAS.Principal).Rows[0];
        ddlPlanta.SelectedValue = dtr["IdPlanta"];
        txtrut_clie.Text = dtr["rut_clie"].ToString();
        txtrut_clie.Tag = dtr.XEntero("IdCliente");
        txtnombre_clie.Text = dtr["nombre_clie"].ToString();
        txtCantProgramado.Text = ((int)dtr["CantPrograma"]).ToString("#,##0");
        txtid_OT.Text = dtr["id_OT"].ToString();
        txtid_OT.Tag = dtr["Id"];
        bolLoteObliga = dtr.XBooleano("LoteObliga");

        dtpFecha.Enabled = true;
        ddlLinea.Enabled = true;

        dtpFecha.Value = DateTime.Now.Date;

        ddlLinea.DataSource = new DataView( TomarTabla(TABLAS.Participantes), string.Format("Fecha=#{0}#", dtpFecha.Value.ToString("yyyy/MM/dd")), "", DataViewRowState.OriginalRows);


        ValidarAcceso(Global.DatosApp.InfoUsr.Plantas.XExisteEnTabla("Id", false, ddlPlanta.SelectedValue));

        tsbGuardar.Enabled = PuedeActualizar;

      } else {
        MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    #endregion

    #region Acciones

    public override bool HayCambios() {
      return base.HayCambios() || dtgPrincipal.HayCambios || dtgParticipantes.HayCambios;
    }

    private void MostrarReporte() {
      Reporte objReporte = null;
      object[] objParam;
      DataSet dtsDatos;
      switch ((REPORTES)ddlReporte.SelectedIndex) {
        case REPORTES.Detalle:
          objParam = new object[] { Id };

          Cursor = Cursors.WaitCursor;
          dtsDatos = APP_GEN.Global.DatosApp.TraerDataset("PickingListSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.PickingList.rdlc","Reportes");
          objReporte.Titulo = "Picking List";

          foreach (DataTable dttReporte in dtsDatos.Tables) {
            objReporte.Datos.Add(dttReporte);
          }

          objReporte.Parametros.Add("Usuario", APP_GEN.Global.DatosApp.InfoUsr.Nombre);
          Cursor = Cursors.Default;
          break;
        case REPORTES.PickingOT:
          objParam = new object[] { Id };

          Cursor = Cursors.WaitCursor;
          dtsDatos = APP_GEN.Global.DatosApp.TraerDataset("PickingOTPickeadoSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.PickingOTPickeado.rdlc", "Reportes");
          objReporte.Titulo = "Picking por OT";

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

    private void LlamaBuscadorFT(DataRow dtrFilaActual, string strNombre) {
      
      var dttTabla = Global.BuscarUsuario("", strNombre, USUARIO_TIPO.LogisticaEntrada);
      if (dttTabla != null) {
        if (dttTabla.Rows.Count > 0) {
          foreach (DataRow dtr in dttTabla.Rows) {
            DataRow dtrNueva = null;
         
              dtrNueva = dtrFilaActual;
            
            dtrNueva["IdPicking"] = Id;
            dtrNueva["IdParticipante"] = dtr["Id"];
            dtrNueva["nombre_empleado"] = dtr["nombre_empleado"];

            ValidarFilaParticipante(dtrNueva);
          }
        }
      }
    }

    private bool ValidarPickingOT() {
      DataTable dt = Global.DatosApp.TraerTabla("PickingValidarOT", new object[] { Id });

      if (dt == null) {
        MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }

      if (dt.Rows.Count == 0)
        return true;

      StringBuilder stb = new StringBuilder();

      stb.AppendLine("Los siguientes productos o insumos, sobrepasan lo necesario para terminar la orden de trabajo. Deberá solicitar autorización para poder cambiar de estado");

      dt.AsEnumerable().ToList().ForEach(s => stb.AppendFormat("Componente: {0} - Necesario: {1:#,##0} - Pickeado: {2:#,##0}", s["nombre_detPtt"], s.XEntero("AUsar"), s.XEntero("Cantidad")).AppendLine());

      MessageBox.Show(stb.ToString(), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
      return false;
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
      if (this.XGuardaCambios(dtgPrincipal, dtgParticipantes, dtgPTT)) {
        LimpiarControles();
      }
    }

    private void tsbRefrescar_Click(object sender, EventArgs e) {
      if (this.XGuardaCambios(dtgPrincipal, dtgParticipantes, dtgPTT)) {
        RefrescarTodo();
      }
    }

    private void tsbReporte_Click(object sender, EventArgs e) {
      MostrarReporte();
    }

    private void tsbProcesar_Click(object sender, EventArgs e) {
      if (!ValidarPickingOT()) return;

      if (MessageBox.Show("Va a procesar el picking ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (CambiarEstado(ESTADO_PICKING.PorPreparar, null, null, null))
          RefrescarTodo();
      }
    }

    private void tsbValidar_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a validar el picking ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (CambiarEstado(ESTADO_PICKING.Validado, null, null, null))
          RefrescarTodo();
      }
    }

    private void tsbCancelar_Click(object sender, EventArgs e) {
      PickingMotivo objFRm = new PickingMotivo(objEstado);
      if (objFRm.ShowDialog() == DialogResult.OK) {
        if (CambiarEstado(ESTADO_PICKING.Cancelado, (int)objFRm.ddlMotivo.SelectedValue, objFRm.txtObs.Text, objFRm.ddlResponsable.SelectedValue.XEnteroONulo()))
          RefrescarTodo();
      }
    }

    private void tsbRechazar_Click(object sender, EventArgs e) {
      PickingMotivo objFRm = new PickingMotivo(objEstado);
      if (objFRm.ShowDialog() == DialogResult.OK) {
        if (CambiarEstado(ESTADO_PICKING.Rechazado, (int)objFRm.ddlMotivo.SelectedValue, objFRm.txtObs.Text, objFRm.ddlResponsable.SelectedValue.XEnteroONulo()))
          RefrescarTodo();
      }
    }

    private void tsbEntregar_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a entregar el picking ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (CambiarEstado(ESTADO_PICKING.Entregado, null, null, null))
          RefrescarTodo();
      }
    }
    
    private void tsbAutorizar_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a aprobar el uso de este picking ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (Autorizar())
          RefrescarTodo();
      }
    }

    private void tsbPreparar_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a preparar el picking ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (CambiarEstado(ESTADO_PICKING.EnPreparacion, null, null, null))
          RefrescarTodo();
      }
    }

    private void tsbPreparado_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a terminar de preparar el picking ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (CambiarEstado(ESTADO_PICKING.Preparado, null, null, null))
          RefrescarTodo();
      }
    }
    #endregion

    #region Eventos de controles

    private void Control_Enter(object sender, EventArgs e) {
      sender.XSeleccionarTextoEnControl();
    }

    private void txtid_OT_Validated(object sender, EventArgs e) {
      if (!string.IsNullOrWhiteSpace(txtid_OT.Text) && txtid_OT.Tag == null && !Inicializando)
        LlenarcontrolesOT();
    }

    private void txtid_OT_TextChanged(object sender, EventArgs e) {
      txtid_OT.Tag = null;
    }

    private void dtpFecha_ValueChanged(object sender, EventArgs e) {
      if (ddlLinea.DataSource == null) return;

      ((DataView)ddlLinea.DataSource).RowFilter = string.Format("Fecha=#{0}#", dtpFecha.Value.ToString("yyyy/MM/dd"));
    }

    private void ddlLinea_SelectedIndexChanged(object sender, EventArgs e) {
      txtCantProgramado.Text = ddlLinea.XTomarDataRowSeleccionado().XEntero("Cantidad").ToString("#,##0");
    }

    #endregion

    #region Eventos de grilla

    private void dtgPrincipal_AntesInsertar(object sender, FilaEventArg e) {
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

    private void dtgPTT_DespuesCambioFila(object sender, FilaGrillaEventArg e) {
      int intIdPTT = 0;

      if (e.FilaDatos != null) {
        intIdPTT = (int)e.FilaDatos["IdPTT"];
      }

      dtgPrincipal.Vista.RowFilter = string.Format("IdPTT={0}", intIdPTT);
    }

    private void dtgPTT_CellContentClick(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex == -1) return;


      if (e.ColumnIndex == colid_ptt.Index)
        Global.LlamarFormulario<FichaPTT>(true, dtgPTT.FilaActual.XEntero("IdPTT"));
    }

    private void dtgParticipantes_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex == -1) return;

      LlamaBuscadorFT(dtgParticipantes.FilaActual, dtgParticipantes.FilaActual["nombre_empleado"].ToString());

    }

    private void dtgParticipantes_AntesInsertar(object sender, FilaEventArg e) {
      ValidarFilaParticipante(e.Fila);
    }

    private void dtgParticipantes_DespuesModificarFila(object sender, FilaEventArg e) {
      ValidarFilaParticipante(e.Fila);
    }

    private void dtgPrincipal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
      if (e.RowIndex == -1) return;

      int intEnMuestra = dtgPrincipal.Rows[e.RowIndex].XTomarDataRow().XEntero("EnMuestra");

      if (intEnMuestra > 0)
        e.CellStyle.BackColor = colorMuestra;

    }

    private void dtgMovipack_AntesInsertar(object sender, FilaEventArg e) {
      ValidarFilaMovipack(e.Fila);
    }

    private void dtgMovipack_DespuesModificarFila(object sender, FilaEventArg e) {
      ValidarFilaMovipack(e.Fila);
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

    private void tsbCambiarProceso_Click(object sender, EventArgs e) {
      Global.LlamarFormulario<PickingCambioProceso>(true, intIdDetOT, txtid_picking.Text, Id);
    }

    private void tsbCopiar_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a copiar el picking actual ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (Copiar())
          RefrescarTodo();
      }
    }

    private void tsbSegregar_Click(object sender, EventArgs e) {
      var objFrm = Global.LlamarFormulario<PickingSegregacion>(true, dtgPrincipal.FilaActual);

      if (objFrm.DialogResult == DialogResult.OK)
        RefrescarTodo();
    }
  }
}