using APP_GEN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ITD.AccDatos;
using ITD.Win;
using ITD.Win.Formas;
using Global = APP_GEN.Global;
using System.Linq;

namespace APP {

  public partial class TarjaIngPos : FrmBaseGrid {

    #region Declaraciones

    #region Por Defecto

    private static readonly ACCESO_OPCION Acceso = ACCESO_OPCION.PosTarjaIng;

    public static bool TieneAcceso {
      get { return Global.DatosApp.TieneAcceso(Acceso) != TIPO_ACCESO.Sin_Acceso; }
    }

    private enum REPORTES {
      Detalle
    }

    #endregion

    #endregion

    #region Inicial

    public TarjaIngPos() {
      InitializeComponent();
      IniciarPaginado(1, 150);
      InicializarFiltros(true);
      LlenarDdls();
    }

    public void InicializarParametros() {
      ValidarAcceso();
      ddlReporte.SelectedIndex = 0;
    }

    public void ValidarAcceso() {
      PuedeActualizar = Global.DatosApp.TieneAcceso(Acceso) == TIPO_ACCESO.Editar;
    }

    private void GrillaAct_Load(object sender, EventArgs e) {
      InicializarParametros();
      RefrescarTodo();
    }

    public override void InicializarFiltros(bool guardaPersistencia = true) {
      base.InicializarFiltros(guardaPersistencia);
      Filtro.Agregar(new FiltroDropDown(ddlPlantaTarja, OPC_SELECCION.Seleccionado, TIPO_OPERADOR.Igual, "TarjaIngreso.Id_Planta", "Planta", TIPO_DATO.Entero));
      Filtro.Agregar(new FiltroTextBox(txtCliente, chkCliente, ddlCliente, "Entidad.Nombre", "Cliente", TIPO_DATO.Texto));
      Filtro.Agregar(new FiltroTextBox(txtTarja, chkTarja, ddlTarja, "Tarjaingreso.id_taring", "Tarja", TIPO_DATO.Texto));
      Filtro.Agregar(new FiltroTextBox(txtCodigo, chkCodigo, ddlCodigo, "TarjaIngreso.id_insumo", "Código", TIPO_DATO.Texto));
      Filtro.Agregar(new FiltroTextBox(txtProducto, chkProducto, ddlProducto, "TarjaIngreso.nombre_insumo", "Prod/Ins", TIPO_DATO.Texto));
      Filtro.Agregar(new FiltroTextBox(txtOC, chkOC, ddlOC, "TarjaIngreso.OC", "OC", TIPO_DATO.Texto));
      Filtro.Agregar(new FiltroDatePicker(dtpFechaDesde, chkFechaDesde, ddlFechaDesde, "TarjaIngreso.venceLote_tarIng", "Fecha Vence desde", TIPO_DATO.Fecha, TIPO_OPERADOR.MayorIgual));
      Filtro.Agregar(new FiltroDatePicker(dtpFechaHasta, chkFechaHasta, ddlFechaHasta, "TarjaIngreso.venceLote_tarIng", "Fecha Vence hasta", TIPO_DATO.Fecha, TIPO_OPERADOR.MenorIgual));
      Filtro.Agregar(new FiltroTextBox(txtRecepcion, chkRecepcion, ddlRecepcion, "Recepcion.Numero", "Recepción", TIPO_DATO.Entero));

    }

    #endregion

    #region Actualizar

    public override GUARDAR_RESULT GuardarTodo() {
      if (!dtgPrincipal.FinalizaEdicion()) {
        return GUARDAR_RESULT.CanceladoGuardar;
      }
      if (dtgPrincipal.HayErrores) {
        MessageBox.Show("No se pueden guardar los datos porque existen filas con errores.", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return GUARDAR_RESULT.CanceladoGuardar;
      }
      Cursor = Cursors.WaitCursor;
      List<Registro> listaCambios = TomarFilasModificadas(dtgPrincipal);
      List<Registro> listaResultados = Global.DatosApp.ActualizarMasivo("TarjaIngresoPos", listaCambios, false);
      Cursor = Cursors.Default;
      if (listaResultados.HayErrores()) {
        SincronizarCambios(dtgPrincipal, listaResultados);
        MessageBox.Show("No se guardaron todos los datos porque existen filas con errores.", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return GUARDAR_RESULT.GuardadoError;
      }

      MessageBox.Show("Datos guardados con éxito.", Global.STR_INFORMACION, MessageBoxButtons.OK, MessageBoxIcon.Information);

      return GUARDAR_RESULT.GuardadoOk;
    }

    protected override object[] TomarParametrosAModificar(DataGridView dtgGrilla, DataRow dtrFila) {
      return new object[] { dtrFila["Id"], dtrFila["IdPosicion"], Global.DatosApp.InfoUsr.IdUsuario, dtrFila["Mixto"] };
    }

    private bool UbicaPone() {
      return null != this.XEjecutarProcedimiento(null, "TarjaIngresoPosUbicaPoner", dtgPrincipal.FilasSeleccionadas().XConcatenarValoresColumna("Id","|",false), TomarId(dtgPosiciones) );
    }

    private bool UbicaSacar() {
      return null != this.XEjecutarProcedimiento(null, "TarjaIngresoPosUbicaSacar", TomarId(dtgPosiciones));
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
        null
      };
      Cursor = Cursors.WaitCursor;
      var dtTabla = Global.DatosApp.TraerTabla("TarjaIngresoPosPrincipalSel_Grids", objParam);
      Cursor = Cursors.Default;
      if (dtTabla != null) {
        tsbReporte.Enabled = dtTabla.Rows.Count > 0;
        btnIzquierda.Enabled = dtTabla.Rows.Count > 0;
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

    private void LlenarGrillaPosiciones() {
      object[] objParam = new object[]{
       ddlPlanta.SelectedValue,
       ddlRack.SelectedValue,
       ddlEstado.SelectedValue
      };
      Cursor = Cursors.WaitCursor;
      var dtTabla = Global.DatosApp.TraerTabla("TarjaIngresoPosPosicionSel_Grids", objParam);
      Cursor = Cursors.Default;
      if (dtTabla != null) {
        tsbReporte.Enabled = dtTabla.Rows.Count > 0;
        RefrescarGrilla(dtgPosiciones, dtTabla.DefaultView);
      } else {
        MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }


    private void ValidarFila(DataRow dtrFila) {
      StringBuilder stbError = new StringBuilder();

      if (stbError.Length > 0) {
        stbError.Insert(0, "Campos con errores o vacíos.\n");
      }
      dtrFila.RowError = stbError.ToString();
    }

    private void LlenarDdls() {
      ddlPlanta.DataSource = ddlPlantaTarja.DataSource = Global.DatosApp.InfoUsr.Plantas.DefaultView;

      ddlEstado.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.PosicionEstado, "", "");
    }

    #endregion

    #region Acciones

    public override bool HayCambios() {
      return dtgPrincipal.HayCambios;
    }

    //private void LlenarCeldaBodega(DataGridViewRow dgvr) {
    //  DataRow dtr = ((DataRowView)dgvr.DataBoundItem).Row;

    //  DataGridViewComboBoxCell cell = dgvr.Cells[colid_bodega.Index] as DataGridViewComboBoxCell;

    //  cell.DisplayMember = "Bodega";
    //  cell.ValueMember = "Id";
    //  cell.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Bodega, string.Format("Id_planta={0}", dtr["id_planta"]), cell.DisplayMember);

    //}

    //private void LlenarCeldaRack(DataGridViewRow dgvr) {
    //  DataRow dtr = ((DataRowView)dgvr.DataBoundItem).Row;

    //  DataGridViewComboBoxCell cell = dgvr.Cells[colid_rack.Index] as DataGridViewComboBoxCell;

    //  cell.DisplayMember = "Nombre";
    //  cell.ValueMember = "Id";
    //  cell.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Rack, string.Format("Id_Bodega={0}", (dtr["Id_Bodega"] as int?)??0), cell.DisplayMember);

    //}

    private void MostrarReporte() {
      Reporte objReporte = null;
      object[] objParam;
      switch ((REPORTES)ddlReporte.SelectedIndex) {
        case REPORTES.Detalle:
          objParam = new object[] { ddlPlanta.SelectedValue };

          Cursor = Cursors.WaitCursor;
          var dtsDatos = APP_GEN.Global.DatosApp.TraerDataset("TarjaIngresoSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.TarjaUbicacion.rdlc","Reportes");
          objReporte.Titulo = "Estado de ocupación en bodega";

          foreach (DataTable dttReporte in dtsDatos.Tables) {
            objReporte.Datos.Add(dttReporte);
          }

          Cursor = Cursors.Default;
          break;
      }

      if (objReporte != null)
        objReporte.MostrarReporte(APP_GEN.Global.FormaPrincipal);
    }

    private void LlamaBuscadorCliente(string strCodigo, string strNombre) {
      var dttTabla = Global.BuscarEntidad(strCodigo, strNombre, true, true);
      if (dttTabla != null) {
        if (dttTabla.Rows.Count > 0) {
          var dtrFila = dttTabla.Rows[0];
          txtCliente.Text = dtrFila["nombre_clie"].ToString();
          txtCliente.Tag = dtrFila["Id"];
          RefrescarTodo();
        }
      } else {
        txtCliente.Tag = null;
      }
    }

    #endregion

    #region Eventos de Barra

    private void tsbGuardar_Click(object sender, EventArgs e) {
      if (GuardarTodo() == GUARDAR_RESULT.GuardadoOk) {
        RefrescarTodo();
      }
    }

    private void tsbRefrescar_Click(object sender, EventArgs e) {
        Filtrar();
    }

    private void tsbReporte_Click(object sender, EventArgs e) {
      MostrarReporte();
    }

    #endregion

    #region Eventos de Controles

    private void txtrut_clie_TextChanged(object sender, EventArgs e) {
      txtCliente.Tag = null;
    }

    private void txtnombre_clie_Validated(object sender, EventArgs e) {
      if (txtCliente.Tag == null && !string.IsNullOrWhiteSpace(txtCliente.Text))
        LlamaBuscadorCliente("", txtCliente.Text);
    }

    private void ddlPlanta_SelectedIndexChanged(object sender, EventArgs e) {
      if (!Inicializando)
        Filtrar();

      ddlRack.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Rack, string.Format("id_planta = 0 or id_planta={0} and Activo = 1", ddlPlanta.SelectedValue.XEntero()), ddlRack.DisplayMember);
      
    }

    private void ddlPlantaTarja_SelectedIndexChanged(object sender, EventArgs e) {
      Filtrar();
    }

    private void ddlRack_SelectedIndexChanged(object sender, EventArgs e) {
      if (!Inicializando)
        LlenarGrillaPosiciones();
    }

    private void ddlEstado_SelectedIndexChanged(object sender, EventArgs e) {
      LlenarGrillaPosiciones();
    }

    private void btnDerecha_Click(object sender, EventArgs e) {
      if (UbicaSacar()) {
        CargarPaginaActual();
        dtgPosiciones.FilaActual["Cantidad"] = 0;
        dtgPosiciones.FilaActual["Estado"] = "VACIA";
        dtgPosiciones.FilaActual["Contenido"] =DBNull.Value;
        dtgPosiciones.Vista.Table.AcceptChanges();
      }
    }

    private void btnIzquierda_Click(object sender, EventArgs e) {
      if (UbicaPone()) {
        dtgPosiciones.FilaActual["Cantidad"] =dtgPrincipal.FilasSeleccionadas().Count;
        dtgPosiciones.FilaActual["Estado"] = "OCUPADA";
        dtgPosiciones.FilaActual["Contenido"] = "BODEGA";
        dtgPosiciones.FilaActual["TipoContenido"] = (int)TIPO_CONTENIDO.Bodega;
        dtgPosiciones.Vista.Table.AcceptChanges();
        CargarPaginaActual();
      }
    }

    #endregion

    #region Eventos de Grilla

    private void dtgPrincipal_Enter(object sender, EventArgs e) {
      sbpFilas.Text = ((DataGridView)sender).RowCount.ToString();
    }

    private void dtgPrincipal_Sorted(object sender, EventArgs e) {
      CargarPaginaActual();
    }

    private void dtgPrincipal_CambiaOperacionRapida(object sender, CambiaOperacionRapidaEvengArg e) {
      sbpMensaje.Text = e.ValorFormateado;
    }

    private void dtgPosiciones_DespuesCambioFila(object sender, FilaGrillaEventArg e) {
      btnDerecha.Enabled = dtgPosiciones.FilaActual != null && dtgPosiciones.FilaActual.XEntero("Cantidad") > 0;
    }

    private void dtgPosiciones_CellContentClick(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex == -1) return;

      if (e.ColumnIndex == ColTarjas.Index && dtgPosiciones.FilaActual.XEntero("Cantidad") > 0)
        switch ((TIPO_CONTENIDO)dtgPosiciones.FilaActual.XEntero("TipoContenido")) {
          case TIPO_CONTENIDO.Bodega:
            Global.LlamarFormulario<TarjaIngresoPosVer>(true, TomarId(dtgPosiciones), ddlPlanta.SelectedValue);
            break;
          case TIPO_CONTENIDO.Produccion:
            Global.LlamarFormulario<TarjaProdPosVer>(true, TomarId(dtgPosiciones), ddlPlanta.SelectedValue);
            break;
          default:
            break;
        }

    }

    #endregion

    #region Persistencia

    public enum Llaves {
      Grilla = 10
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

  }
}