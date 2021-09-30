using APP_GEN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ITD.Win;
using ITD.Win.Formas;
using Global = APP_GEN.Global;
using System.Drawing;
using System.Text;

namespace APP {

  public partial class TarjaIngresoCons : FrmBaseGrid {

    #region Declaraciones

    #region Por Defecto

    private static readonly ACCESO_OPCION Acceso = ACCESO_OPCION.PosTarjaIng;

    //private Type frmALlamar = typeof(Consulta);

    private enum REPORTES {
      TarjaIngresoHist,
      Listado,
      ConsolidadoProducto,
      Detalle,
      Vence,
      Consolidado,
      Historia
    }

    public static bool TieneAcceso {
      get { return Global.DatosApp.TieneAcceso(Acceso) != TIPO_ACCESO.Sin_Acceso; }
    }

    string strCodigo;
    string strCliente;

    public object[] Parametros { set { strCliente = value[0].ToString(); strCodigo = value[1].ToString(); } }

    #endregion

    TARJA_INGRESO_ESTADO objEstado;


    enum FILTRO_DEVO {
      Planta = 0,
      Cliente = 1,
      Estado = 11,
      Tipo
    }
    
    #endregion

    #region Inicial

    public TarjaIngresoCons() {
      InitializeComponent();
      IniciarPaginado(1, 150);
      LlenarDdls();
      InicializarFiltros(true);
    }

    public override void InicializarFiltros(bool guardaPersistencia = true) {
      base.InicializarFiltros(guardaPersistencia);
      Filtro.Agregar(new FiltroDropDown(ddlPlanta, chkPlanta, TIPO_OPERADOR.Igual, "TarjaIngreso.Id_Planta", "Planta", TIPO_DATO.Entero));
      Filtro.Agregar(new FiltroTextBox(txtCliente, chkCliente, ddlCliente, "Entidad.Nombre", "Cliente", TIPO_DATO.Texto));
      Filtro.Agregar(new FiltroTextBox(txtTarja, chkTarja, ddlTarja, "Tarjaingreso.id_taring", "Tarja", TIPO_DATO.Texto));
      Filtro.Agregar(new FiltroTextBox(txtCodigo, chkCodigo, ddlCodigo, "TarjaIngreso.id_insumo", "Código", TIPO_DATO.Texto));
      Filtro.Agregar(new FiltroTextBox(txtProducto, chkProducto, ddlProducto, "TarjaIngreso.nombre_insumo", "Prod/Ins", TIPO_DATO.Texto));
      Filtro.Agregar(new FiltroTextBox(txtOC, chkOC, ddlOC, "TarjaIngreso.OC", "OC", TIPO_DATO.Texto));
      Filtro.Agregar(new FiltroTextBox(txtOCPRov, chkOCPRov, ddlOCPRov, "TarjaIngreso.OCProv", "OC Proveedor", TIPO_DATO.Texto));
      Filtro.Agregar(new FiltroTextBox(txtRecepcion, chkRecepcion, ddlRecepcion, "Recepcion.Numero", "Recepción", TIPO_DATO.Texto));

      Filtro.Agregar(new FiltroDatePicker(dtpFechaIngDesde, chkFechaIngDesde, ddlFechaIngDesde, "TarjaIngreso.fecha_ingreso", "Fecha Ingreso desde", TIPO_DATO.Fecha, TIPO_OPERADOR.MayorIgual));
      Filtro.Agregar(new FiltroDatePicker(dtpFechaIngHasta, chkFechaIngHasta, ddlFechaIngHasta, "TarjaIngreso.fecha_ingreso", "Fecha Ingreso hasta", TIPO_DATO.Fecha, TIPO_OPERADOR.MenorIgual));

      Filtro.Agregar(new FiltroDatePicker(dtpFechaDesde, chkFechaDesde, ddlFechaDesde, "TarjaIngreso.venceLote_tarIng", "Fecha Vence desde", TIPO_DATO.Fecha, TIPO_OPERADOR.MayorIgual));
      Filtro.Agregar(new FiltroDatePicker(dtpFechaHasta, chkFechaHasta, ddlFechaHasta, "TarjaIngreso.venceLote_tarIng", "Fecha Vence hasta", TIPO_DATO.Fecha, TIPO_OPERADOR.MenorIgual));
      Filtro.Agregar(new FiltroListBox(lstEstado, chkEstado, ddlEstado, "TarjaIngreso.id_Estadotarja", "Estado", TIPO_DATO.Entero));

      Filtro.Agregar(new FiltroTextBox(txtCantidad, chkCantidad, ddlCantidad, "TarjaIngreso.Saldo_taring", "Saldo", TIPO_DATO.Entero, TIPO_OPERADOR.Mayor));

      Filtro.Agregar(new FiltroBase(chkSoloIngresos, TIPO_OPERADOR.Ninguno, "TarjaIngreso.IdRecepcionDet is not null and TarjaIngreso.IdSegregacionDetNuevo is null and TarjaIngreso.IdTarjaDevo is null and TarjaIngreso.IdDespachoDet is null and TarjaIngreso.PorTraslado = 0", "Solo ingresos"));
      Filtro.Agregar(new FiltroBase(chkPosicionados, TIPO_OPERADOR.Ninguno, "TarjaIngreso.IdPosicion is not null ", "Ver tarjas posicionadas"));

    }

    private void ConsultaPaginada_Load(object sender, EventArgs e) {
      InicializarParametros();
      Filtrar();
    }

    private void InicializarParametros() {
      ValidarAcceso();
      tsbMostrarFiltros_Click(null, null);
      dtgTotal.Grilla = dtgPrincipal;
      dtgTotal.AgregarColumnaTotal(ColSaldo.Index, GrillaTotal.AGREGADO.Suma);

     

      BuscarComponente();


      if (ddlReporte.Items.Count > 0) {
        ddlReporte.SelectedIndex = (int)REPORTES.Listado;
        ddlReporte.Visible = ddlReporte.Items.Count > 1;
      } else
        tsbReporte.Visible = ddlReporte.Visible = false;
      stbPrincipal.SendToBack();
      //dtgTotal.AgregarColumnaTotal(ColNombreCol, GrillaTotal.AGREGADO.Suma);
      //dtgTotal[ColNombreCol.Index].Celda.Style.BackColor = Global.DatosApp.ColorSoloLectura;

    }

    private void ValidarAcceso() {
      PuedeActualizar = Global.DatosApp.TieneAcceso(Acceso) == TIPO_ACCESO.Editar;
    }

    #endregion

    #region Actualizacion

    private bool Eliminar() {
      return null != this.XEjecutarProcedimiento(null, "", TomarId(dtgPrincipal));
    }

    private bool CambiarEstado(TARJA_INGRESO_ESTADO objNuevoEstado) {
      return null != this.XEjecutarProcedimiento(null, "TarjaIngresoCambiarEstado", TomarId(dtgPrincipal), (int)objNuevoEstado);
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
      var dtTabla = Global.DatosApp.TraerDataset("TarjaIngresoConsSel_Grids", objParam);
      Cursor = Cursors.Default;
      if (dtTabla != null) {
        tsbModificar.Enabled = tsbReporte.Enabled = tsbBloquear.Visible = tsbHabilitar.Visible = dtTabla.Tables[0].Rows.Count > 0;
        RefrescarGrilla(dtgPrincipal, dtTabla.Tables[0].DefaultView);
        dtgTotal[ColSaldo.Index].Total = dtTabla.Tables[1].Rows[0]["saldo_taring"].XDouble();
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
      lstEstado.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.TarjaIngresoEstado, "Id > 0", "");
    }

    private bool ValidarPicking() {
      StringBuilder stbError = new StringBuilder();

      if (Filtro[(int)FILTRO_DEVO.Planta].Filtro.Length == 0)
        stbError.AppendLine("Aplicar filtro Planta");

      if (Filtro[(int)FILTRO_DEVO.Cliente].Filtro.Length == 0)
        stbError.AppendLine("Aplicar filtro Cliente");

      if (Filtro[(int)FILTRO_DEVO.Estado].Filtro.Length == 0)
        stbError.AppendLine("Aplicar filtro Estado");
      else
        if (lstEstado.SelectedValue.XEntero() != (int)TARJA_INGRESO_ESTADO.Creada)
        stbError.AppendLine("Aplicar filtro Estado Creado");
      
      if (stbError.Length > 0) {
        stbError.Insert(0, "Para crear el picking debe: \n");
        MessageBox.Show(stbError.ToString(), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;
    }

    #endregion

    #region Acciones

    public void LlamadoDesdePrincipal(params object[] parametros) {
      Parametros = parametros;
      BuscarComponente();
    }

    private void MostrarReporte() {
      Reporte objReporte = null;
      DataTable dttDatos;
      DataSet dtsDatos;
      object[] objParam;
      switch ((REPORTES)ddlReporte.SelectedIndex) {

        case REPORTES.TarjaIngresoHist:
          objParam = new object[] {
            txtCodigo.Text,
            dtpFechaDesde.Value,
            dtpFechaHasta.Value
          };

          Cursor = Cursors.WaitCursor;
          dtsDatos = Global.DatosApp.TraerDataset("TarjaIngresoHistCodigoSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.TarjaIngresoHistCodigo.rdlc", "Reportes");
          objReporte.Titulo = "Historia Tarjas Ingreso";

          foreach (DataTable dttReporte in dtsDatos.Tables) {
            objReporte.Datos.Add(dttReporte);
          }
          objReporte.Parametros.Add("Sistema", APP_GEN.Global.DatosApp.Sistema);
          Cursor = Cursors.Default;
          sbpProgreso.Visible = false;
          break;
        case REPORTES.Listado:

          chkCantidad.Checked = true;
          ddlCantidad.SelectedValue = TIPO_OPERADOR.Mayor;
          txtCantidad.Text = "0";
          Filtrar();

          objParam = new object[] {
              0,
              APP_GEN.Global.DatosApp.CantidadFilasReportes,
              0,
              TomarOrden(dtgPrincipal),
              Filtro.Filtro,
              null,
        Global.DatosApp.InfoUsr.IdUsuario          };

          Cursor = Cursors.WaitCursor;
          dttDatos = Global.CargarDatosReporte("TarjaIngresoConsSel_Grids", objParam);
          objReporte = new Reporte("Reportes.Reportes.TarjaListado.rdlc", "Reportes");
          objReporte.Titulo = "Listado de Tarjas de Ingreso";

          objReporte.Datos.Add(dttDatos);

          objReporte.Parametros.Add("Sistema", APP_GEN.Global.DatosApp.Sistema);
          objReporte.Parametros.Add("DescFiltro", Filtro.FiltroDesc);
          Cursor = Cursors.Default;
          sbpProgreso.Visible = false;
          break;


        case REPORTES.ConsolidadoProducto:
          objParam = new object[] {
              Filtro.Filtro,
              Global.DatosApp.InfoUsr.IdUsuario
          };

          Cursor = Cursors.WaitCursor;
          dttDatos = Global.DatosApp.TraerTabla("TarjaIngresoConsolidadoSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.TarjaIngresoConsolidado.rdlc","Reportes");
          objReporte.Titulo = "Consolidado de productos / insumos";

          objReporte.Datos.Add(dttDatos);

          objReporte.Parametros.Add("Sistema", APP_GEN.Global.DatosApp.Sistema);
          objReporte.Parametros.Add("DescFiltro", Filtro.FiltroDesc);
          Cursor = Cursors.Default;
          sbpProgreso.Visible = false;
          break;

        case REPORTES.Detalle:
          objParam = new object[] { dtgPrincipal.FilasSeleccionadas().XConcatenarValoresColumna("Id", "|", false) };

          Cursor = Cursors.WaitCursor;
          dtsDatos = APP_GEN.Global.DatosApp.TraerDataset("TarjaIngresoPos_Imprimir", objParam);
          objReporte = new Reporte("Reportes.Reportes.TarjaUbicacionImp.rdlc","Reportes");
          objReporte.Titulo = "Imprimir ubicación de tarjas";

          foreach (DataTable dttReporte in dtsDatos.Tables) {
            objReporte.Datos.Add(dttReporte);
          }
          Cursor = Cursors.Default;
          break;

        case REPORTES.Vence:
          objParam = null;

          Cursor = Cursors.WaitCursor;
          dtsDatos = APP_GEN.Global.DatosApp.TraerDataset("TarjaIngresoVence_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.TarjaIngresoVence.rdlc", "Reportes");
          objReporte.Titulo = "Tarjas por vencimiento";

          foreach (DataTable dttReporte in dtsDatos.Tables) {
            objReporte.Datos.Add(dttReporte);
          }
          Cursor = Cursors.Default;
          break;
        case REPORTES.Consolidado:
          objParam = new object[] {
              Filtro.Filtro,
              Global.DatosApp.InfoUsr.IdUsuario
          };

          Cursor = Cursors.WaitCursor;
          dttDatos = Global.DatosApp.TraerTabla("TarjaIngresoSaldoConsSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.TarjaIngresoConsSaldo.rdlc", "Reportes");
          objReporte.Titulo = "Consolidado de productos / insumos";

          objReporte.Datos.Add(dttDatos);

          objReporte.Parametros.Add("Sistema", APP_GEN.Global.DatosApp.Sistema);
          objReporte.Parametros.Add("DescFiltro", Filtro.FiltroDesc);
          Cursor = Cursors.Default;
          sbpProgreso.Visible = false;
          break;
        case REPORTES.Historia :
          objParam = new object[] {
              TomarId(dtgPrincipal)
          };

          Cursor = Cursors.WaitCursor;
          dtsDatos = Global.DatosApp.TraerDataset("TarjaIngresoTrackSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.TarjaIngresoHist.rdlc", "Reportes");
          objReporte.Titulo = "Historia de tarja";

          foreach (DataTable dttReporte in dtsDatos.Tables) {
            objReporte.Datos.Add(dttReporte);
          }

          objReporte.Parametros.Add("Sistema", APP_GEN.Global.DatosApp.Sistema);
          Cursor = Cursors.Default;
          sbpProgreso.Visible = false;
          break;

      }

      if (objReporte != null)
        objReporte.MostrarReporte(APP_GEN.Global.FormaPrincipal);
    }

    private void BuscarComponente() {
      if (!strCodigo.XEsNuloOVacio()) {
        Filtro.LimpiarFiltros();

        chkCodigo.Checked = true;
        txtCodigo.Text = strCodigo;

        chkCantidad.Checked = true;
        txtCantidad.Text = "0";

        chkCliente.Checked = true;
        txtCliente.Text = strCliente;
        Filtrar();
      }
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
      if (e.RowIndex < 0) return;

      if (e.ColumnIndex == ColImprimir.Index) {
        Global.ImprimirDocumento(DOCUMENTO_IMPRIMIR.TarjaIngreso, TomarId(dtgPrincipal).ToString() + "|");
      }

    }

    private void tsbImprimirTarjas_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a imprimir todas las tarjas seleccionadas ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        var lista = dtgPrincipal.FilasSeleccionadas();

        StringBuilder stb = new StringBuilder();

        lista.ForEach(s => stb.Append(s[0]).Append("|"));


        Global.ImprimirDocumento(DOCUMENTO_IMPRIMIR.TarjaIngreso, stb.ToString());

      }
    }

    private void tsbBloquear_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a bloquear la tarja seleccionada ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (CambiarEstado(TARJA_INGRESO_ESTADO.Bloqueado))
          CargarPaginaActual();
      }
    }

    private void tsbHabilitar_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a habilitar la tarja seleccionada ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (CambiarEstado(TARJA_INGRESO_ESTADO.Creada))
          CargarPaginaActual();
      }
    }

    private void dtgPrincipal_DespuesCambioFila(object sender, FilaGrillaEventArg e) {
      tsbHabilitar.Visible = PuedeActualizar && e.FilaDatos != null && e.FilaDatos.XEnInt("id_estadoTarja", (int)TARJA_INGRESO_ESTADO.Bloqueado);
      tsbBloquear.Visible = PuedeActualizar && e.FilaDatos != null && e.FilaDatos.XEnInt("id_estadoTarja", (int)TARJA_INGRESO_ESTADO.Creada);
    }

    private void chkSoloIngresos_CheckedChanged(object sender, EventArgs e) {

    }

    private void tsbPickingDevo_Click(object sender, EventArgs e) {
      if (!ValidarPicking())
        return;

      List<DataRow> listaFilas = dtgPrincipal.FilasSeleccionadas();

      DatosPickingInt objDatos = new DatosPickingInt();
      DataRow dtr = dtgPrincipal.FilaActual;

      objDatos.Cliente = dtr["nombre_clie"].ToString();
      objDatos.IdCliente = dtr.XEntero("IdCliente");
      objDatos.IdPlanta = ddlPlanta.SelectedValue.XEntero();
      objDatos.OC = txtOC.Text;
      objDatos.IdTipo = 3;

      objDatos.ListaTarja = listaFilas;

      Global.LlamarFormulario<PickingInt>(false, -1, objDatos);
    }
  }
}