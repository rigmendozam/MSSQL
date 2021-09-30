using APP_GEN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ITD.Win;
using ITD.Win.Formas;
using Global = APP_GEN.Global;

namespace APP {

  public partial class PickingCons : FrmBaseGrid {

    #region Declaraciones

    #region Por Defecto

    private static readonly ACCESO_OPCION Acceso = ACCESO_OPCION.Picking;

    //private Type frmALlamar = typeof(Consulta);

    private enum REPORTES {
      Listado,
      ListadoDet,
      Pickeadores
    }

    public static bool TieneAcceso {
      get { return Global.DatosApp.TieneAcceso(Acceso) != TIPO_ACCESO.Sin_Acceso; }
    }

    #endregion

    #endregion

    #region Inicial

    public PickingCons() {
      InitializeComponent();
      IniciarPaginado(1, 150);
      LlenarDdls();
      InicializarFiltros(true);
    }

    public override void InicializarFiltros(bool guardaPersistencia = true) {
      base.InicializarFiltros(guardaPersistencia);

      Filtro.Agregar(new FiltroDropDown(ddlPlanta, chkPlanta, TIPO_OPERADOR.Igual, "Picking.Id_Planta", "Planta", TIPO_DATO.Entero));

      Filtro.Agregar(new FiltroTextBox(txtNumero, chkNumero, ddlNumero, "Picking.id_picking", "Número", TIPO_DATO.Texto));
      Filtro.Agregar(new FiltroTextBox(txtCliente, chkCliente, ddlCliente, "Entidad.Nombre", "Cliente", TIPO_DATO.Texto));

      Filtro.Agregar(new FiltroTextBox(txtProceso, chkProceso, ddlProceso, "Programacion.id_programa", "N° Proceso", TIPO_DATO.Entero));
      Filtro.Agregar(new FiltroTextBox(txtTarja, chkTarja, ddlTarja, "TarjaIngreso.id_taring", "Tarja", TIPO_DATO.Entero, false, "Exists(Select 1 From TarjaIngreso inner join DetPicking on TarjaIngreso.id = DetPicking.IdTarjaIng where DetPicking.IdPicking = Picking.Id And &&)" ));
      Filtro.Agregar(new FiltroTextBox(txtOT, chkOT, ddlOT, "OrdenTrabajo.id_ot", "OT", TIPO_DATO.Entero));
      Filtro.Agregar(new FiltroTextBox(txtEncargada, chkEncargada, ddlEncargada, "Usuarios.nombre_empleado", "Encargada", TIPO_DATO.Texto));
      Filtro.Agregar(new FiltroTextBox(txtPTT, chkPTT, ddlPTT, "PTT.id_ptt", "PTT", TIPO_DATO.Texto));
      Filtro.Agregar(new FiltroTextBox(txtCodigo, chkCodigo, ddlCodigo, "PTT.codigo_ptt", "Código", TIPO_DATO.Texto));
      Filtro.Agregar(new FiltroTextBox(txtNombrePTT, chkNombrePTT, ddlNombrePTT, "PTT.nombre_ptt", "Nombre PTT", TIPO_DATO.Texto));
      Filtro.Agregar(new FiltroTextBox(txtPreparador, chkPreparador, ddlPreparador, "Prepara.nombre_empleado", "Preparador", TIPO_DATO.Texto));

      Filtro.Agregar(new FiltroListBox(lstEstado, chkEstado, ddlEstado, "Picking.IdEstado", "Estado", TIPO_DATO.Entero));
      Filtro.Agregar(new FiltroDatePicker(dtpFechaCreaDesde, chkFechaCreaDesde, ddlFechaCreaDesde, "Picking.FechaCrea", "Fecha creación desde", TIPO_DATO.Fecha, TIPO_OPERADOR.MayorIgual));
      Filtro.Agregar(new FiltroDatePicker(dtpFechaCreaHasta, chkFechaCreaHasta, ddlFechaCreaHasta, "Picking.FechaCrea", "Fecha creación hasta", TIPO_DATO.Fecha, TIPO_OPERADOR.MenorIgual));

      Filtro.Agregar(new FiltroBase(chkContieneInsumos, TIPO_OPERADOR.Ninguno, "Exists(Select 1 from PickingExistencia where PickingExistencia.IdPicking = Picking.Id)", "Contiene Insumo Movipack"));

    }

    private void ConsultaPaginada_Load(object sender, EventArgs e) {
      InicializarParametros();
      Filtrar();
    }

    private void InicializarParametros() {
      ValidarAcceso();
      tsbMostrarFiltros_Click(null, null);

      if (ddlReporte.Items.Count > 0) {
        ddlReporte.SelectedIndex = (int)REPORTES.Listado;
        ddlReporte.Visible = ddlReporte.Items.Count > 1;
      } else
        tsbReporte.Visible = ddlReporte.Visible = false;

      //dtgTotal.AgregarColumnaTotal(ColNombreCol, GrillaTotal.AGREGADO.Suma);
      //dtgTotal[ColNombreCol.Index].Celda.Style.BackColor = Global.DatosApp.ColorSoloLectura;

    }

    private void ValidarAcceso() {
      PuedeActualizar = Global.DatosApp.TieneAcceso(Acceso) == TIPO_ACCESO.Editar;
    }

    #endregion

    #region Actualizacion

    private bool Eliminar() {
      return null != this.XEjecutarProcedimiento(null, "PickingDel", TomarId(dtgPrincipal));
    }

    #endregion

    #region Interfaz

    public override void CargarPagina(int pagina, int pagTamano, int cantidad) {
      object[] objParam = new object[]{
        pagina - 1,
        pagTamano,
        0,
        TomarOrden(dtgPrincipal),
        Filtro.Filtro,
        null,
        Global.DatosApp.InfoUsr.IdUsuario
      };
      Cursor = Cursors.WaitCursor;
      var dtTabla = Global.DatosApp.TraerTabla("PickingSel_Grids", objParam);
      Cursor = Cursors.Default;
      if (dtTabla != null) {
        tsbEliminar.Enabled = tsbModificar.Enabled = tsbReporte.Enabled = dtTabla.Rows.Count > 0;
        RefrescarGrilla(dtgPrincipal, dtTabla.DefaultView);
      } else {
        MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      base.CargarPagina(pagina, pagTamano, (int)objParam[2]);
    }

    public void Filtrar() {
      string strError = Filtro.ValidarFiltros();
      if (string.IsNullOrEmpty(strError)) {
        Filtro.FormarFiltro();
        sbpFiltro.Text = Filtro.FiltroDesc;
        CargarPaginaActual();
      } else
        MessageBox.Show(strError, APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void LlenarDdls() {
      ddlPlanta.DataSource = Global.DatosApp.TomarMisPlantas();
      lstEstado.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.PickingEstado, "Id > 0", "Orden");
    }

    #endregion

    #region Acciones

    private void MostrarReporte() {
      Reporte objReporte = null;
      DataTable dttDatos;
      DataSet dtsDatos;
      object[] objParam;
      switch ((REPORTES)ddlReporte.SelectedIndex) {
        case REPORTES.Listado:
          objParam = new object[] {
              0,
              APP_GEN.Global.DatosApp.CantidadFilasReportes,
              0,
              TomarOrden(dtgPrincipal),
              Filtro.Filtro,
              null
          };

          Cursor = Cursors.WaitCursor;
          dttDatos = Global.CargarDatosReporte("PROCEDIMIENTO", objParam);
          objReporte = new Reporte("Reportes.Reportes.NOMBREREPORTE.rdlc","Reportes");
          objReporte.Titulo = "TITULO";

          objReporte.Datos.Add(dttDatos);

          objReporte.Parametros.Add("Sistema", APP_GEN.Global.DatosApp.Sistema);
          objReporte.Parametros.Add("DescFiltro", Filtro.FiltroDesc);
          Cursor = Cursors.Default;
          sbpProgreso.Visible = false;
          break;

        case REPORTES.ListadoDet:
          objParam = new object[] { Filtro.Filtro };

          Cursor = Cursors.WaitCursor;
          dtsDatos = APP_GEN.Global.DatosApp.TraerDataset("PickingDetSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.PickingDetLst.rdlc","Reportes");
          objReporte.Titulo = "Listado Detallado de Picking";

          foreach (DataTable dttReporte in dtsDatos.Tables) {
            objReporte.Datos.Add(dttReporte);
          }
          objReporte.Parametros.Add("DescFiltro", Filtro.FiltroDesc);
          objReporte.Parametros.Add("Sistema", APP_GEN.Global.DatosApp.Sistema);
          Cursor = Cursors.Default;
          break;
        case REPORTES.Pickeadores:
          objParam = new object[] { Filtro.Filtro };

          Cursor = Cursors.WaitCursor;
          dtsDatos = APP_GEN.Global.DatosApp.TraerDataset("PickingDetPickeadoresSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.PickingDetPickeadores.rdlc","Reportes");
          objReporte.Titulo = "Listado Detallado de Pickeadores";

          foreach (DataTable dttReporte in dtsDatos.Tables) {
            objReporte.Datos.Add(dttReporte);
          }
          objReporte.Parametros.Add("DescFiltro", Filtro.FiltroDesc);
          objReporte.Parametros.Add("Sistema", APP_GEN.Global.DatosApp.Sistema);
          Cursor = Cursors.Default;
          break;
      }

      if (objReporte != null)
        objReporte.MostrarReporte(APP_GEN.Global.FormaPrincipal);
    }

    #endregion

    #region Eventos de barra

    private void tsbEliminar_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a eliminar el registro seleccionado. ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (Eliminar()) {
          CargarPaginaActual();
        }
      }
    }

    private void tsbFiltrar_Click(object sender, EventArgs e) {
      Filtrar();
    }

    private void tsbModificar_Click(object sender, EventArgs e) {
      //Global.LlamarFormulario(frmALlamar, TomarId(dtgPrincipal));
      Global.LlamarFormulario<Picking>(false, TomarId(dtgPrincipal));
    }

    private void tsbMostrarFiltros_Click(object sender, EventArgs e) {
      if (!Inicializando) {
        pnlPrincipal.Visible = !pnlPrincipal.Visible;
      }
      if (pnlPrincipal.Visible) {
        tsbMostrarFiltros.Image = Properties.Resources.NoVer;
        tsbMostrarFiltros.ToolTipText = "Ocultar filtro";
      } else {
        tsbMostrarFiltros.Image = Properties.Resources.Ver;
        tsbMostrarFiltros.ToolTipText = "Mostrar filtro";
      }
    }

    private void tsbNuevo_Click(object sender, EventArgs e) {
      //Global.LlamarFormulario(frmALlamar, -1);
      Global.LlamarFormulario<Picking>(false, -1);
    }

    private void tsbQuitarFiltro_Click(object sender, EventArgs e) {
      Filtro.LimpiarFiltros();
    }

    private void tsbReporte_Click(object sender, EventArgs e) {
      MostrarReporte();
    }

    #endregion

    #region Eventos de controles

    private void Control_Enter(object sender, EventArgs e) {
      sender.XSeleccionarTextoEnControl();
    }

    #endregion

    #region Eventos de grilla

    private void dtgPrincipal_CambiaOperacionRapida(object sender, CambiaOperacionRapidaEvengArg e) {
      sbpMensaje.Text = e.ValorFormateado;
    }

    private void dtgPrincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex > -1) {
        tsbModificar_Click(null, null);
      }
    }

    private void dtgPrincipal_Sorted(object sender, EventArgs e) {
      CargarPaginaActual();
    }

    private void dtgPrincipal_DespuesCambioFila(object sender, FilaGrillaEventArg e) {
      tsbEliminar.Enabled = e.FilaDatos != null && (ESTADO_PICKING)e.FilaDatos.XEntero("IdEstado") == ESTADO_PICKING.Creado;
    }

    #endregion

    #region Persistencia

    private enum Llaves {
      Grilla = 100,
      Panel = 1
    }

    protected override void CargarForma() {
      base.CargarForma();
      bool bolValor;

      CargarGrilla(dtgPrincipal, (int)Llaves.Grilla);

      if (bool.TryParse(TraerLlave((int)Llaves.Panel), out bolValor))
        pnlPrincipal.Visible = bolValor;
    }

    protected override void SalvarForma() {
      base.SalvarForma();
      SalvarGrilla(dtgPrincipal, (int)Llaves.Grilla);
      GuardarLlave((int)Llaves.Panel, pnlPrincipal.Visible.ToString());
    }


    #endregion

    private void dtgPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e) {

    }
  }
}