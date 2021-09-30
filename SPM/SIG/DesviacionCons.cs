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

  public partial class DesviacionCons : FrmBaseGrid {

    #region Declaraciones

    #region Por Defecto

    private static readonly ACCESO_OPCION Acceso = ACCESO_OPCION.Desviacion;
    
    private enum REPORTES {
      Listado,
      TotalHallazgo,
      HallazgoSistema,
      TipoHallazgoEstado,
      TipoHallazgoEncargada,
      TipoHallazgoResponsable,
      TipoHallazgoSolicitante,
      CantidadTotalHallazgos,
      TipoAsuntoHallazgos,
      TipoHallazgoCliente,
      ParteTipoAsuntoArea,
      ParteDescripcionDet,
      EncargadaDetalle,
      ParteTotalDescripcion
    }

    public static bool TieneAcceso {
      get { return Global.DatosApp.TieneAcceso(Acceso) != TIPO_ACCESO.Sin_Acceso; }
    }

    #endregion

    #endregion

    #region Inicial

    public DesviacionCons() {
      InitializeComponent();
      IniciarPaginado(1, 50);
      LlenarDdls();
      InicializarFiltros(true);
    }

    public override void InicializarFiltros(bool guardaPersistencia = true) {
      base.InicializarFiltros(guardaPersistencia);

      Filtro.Agregar(new FiltroTextBox(txtNumero, chkNumero, ddlNumero, "Parte.Numero", "Número", TIPO_DATO.Entero));
      Filtro.Agregar(new FiltroDropDown(ddlPlanta, chkPlanta, TIPO_OPERADOR.Igual, "Parte.IdPlanta", "Planta", TIPO_DATO.Entero));
      Filtro.Agregar(new FiltroDropDown(ddlSistema, chkSistema, TIPO_OPERADOR.Igual, "Parte.IdSistema", "Sistema", TIPO_DATO.Entero));

      Filtro.Agregar(new FiltroTextBox(txtSolicitante, chkSolicitante, TIPO_OPERADOR.Contiene, "Solicitante.nombre_empleado", "Solicitante", TIPO_DATO.Texto));
      Filtro.Agregar(new FiltroTextBox(txtCliente, chkCliente, TIPO_OPERADOR.Contiene, "Entidad.Nombre", "Cliente", TIPO_DATO.Texto));
      Filtro.Agregar(new FiltroDropDown(ddlOrigen, chkOrigen, TIPO_OPERADOR.Igual, "Parte.IdOrigen", "Origen", TIPO_DATO.Entero));
      Filtro.Agregar(new FiltroDropDown(ddlArea, chkArea, TIPO_OPERADOR.Igual, "Parte.IdAreas", "Área", TIPO_DATO.Entero));
      Filtro.Agregar(new FiltroDropDown(ddlTipoHallazgo, chkTipoHallazgo, TIPO_OPERADOR.Igual, "Parte.IdTipoHallazgo", "Tipo Hallazgo", TIPO_DATO.Entero));
      Filtro.Agregar(new FiltroDatePicker(dtpFechaDesde, chkFechaDesde, ddlFechaDesde, "Parte.Fecha", "Fecha Desde", TIPO_DATO.Fecha, TIPO_OPERADOR.MayorIgual));
      Filtro.Agregar(new FiltroDatePicker(dtpFechaHasta, chkFechaHasta, ddlFechaHasta, "Parte.Fecha", "Fecha Hasta", TIPO_DATO.Fecha, TIPO_OPERADOR.MenorIgual));

      Filtro.Agregar(new FiltroListBox(lstEstado, chkEstado, ddlEstado, "Parte.IdEstado", "Estado", TIPO_DATO.Entero));

      Filtro.Agregar(new FiltroDropDown(ddlPlantaOrigen, chkPlantaOrigen, TIPO_OPERADOR.Igual, "Parte.IdPlantaOrigen", "PlantaOrigen", TIPO_DATO.Entero));


      Filtro.Agregar(new FiltroTextBox(txtResponsable, chkResponsable, TIPO_OPERADOR.Contiene, "Responsable.nombre_empleado", "Responsable", TIPO_DATO.Texto));

      //Filtro.Agregar(new FiltroTextBox(txtTexto, chkTexto, ddlTexto, "", "", TIPO_DATO.Texto));
      //Filtro.Agregar(new FiltroDropDown(ddlDrop, chkDrop, TIPO_OPERADOR.Igual, "", "", TIPO_DATO.Entero));
      //Filtro.Agregar(new FiltroNumeric(nudNumeric, chkNumeric, ddlNumeric, "", "", TIPO_DATO.Numero));
      //Filtro.Agregar(new FiltroListBox(lstList, chkList, ddlList, "", "", TIPO_DATO.Entero));
      //Filtro.Agregar(new FiltroRadioButton(new Dictionary<object, RadioButton>() { { 1, rbtRadioSi }, { 0, rbtRadioNo } }.ToList(), chkRadio, TIPO_OPERADOR.Igual, "", "", TIPO_DATO.Entero));
      //Filtro.Agregar(new FiltroBase(chkCheck, TIPO_OPERADOR.Ninguno, "Expresion Where Ej: Activo=1", "Descripcion"));
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
      return null != this.XEjecutarProcedimiento(null, "", TomarId(dtgPrincipal));
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
      var dtTabla = Global.DatosApp.TraerTabla("ParteSel_Grids", objParam);
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


      ddlPlanta.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Planta, "Id > 0 and activo_planta = 1", ddlPlanta.DisplayMember);

      ddlSistema.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.ParteSistema, "Id > 0", ddlSistema.DisplayMember);

      ddlOrigen.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.ParteOrigen, "Id > 0", ddlOrigen.DisplayMember);

      ddlTipoHallazgo.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.TipoHallazgoSolo, "Id> 0 and Parte = 1", ddlTipoHallazgo.DisplayMember);

      ddlArea.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Area, "Id > 0", ddlArea.DisplayMember);

      lstEstado.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.ParteEstado, "Id > 0", "");

      ddlPlantaOrigen.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Planta, "Id > 0 And activo_planta = 1", "");



    }

    #endregion

    #region Acciones

    private void MostrarReporte() {
      Reporte objReporte = null;
      DataTable dttDatos;
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
          dttDatos = Global.CargarDatosReporte("ParteLstSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.ParteLst.rdlc","Reportes");
          objReporte.Titulo = "Listado de Planillas de Hallazgo";

          objReporte.Datos.Add(dttDatos);

          objReporte.Parametros.Add("Sistema", APP_GEN.Global.DatosApp.Sistema);
          objReporte.Parametros.Add("DescFiltro", Filtro.FiltroDesc);
          Cursor = Cursors.Default;
          sbpProgreso.Visible = false;
          break;

        case REPORTES.TotalHallazgo:
          objParam = new object[] {
              Filtro.Filtro
          };

          Cursor = Cursors.WaitCursor;
          dttDatos = Global.DatosApp.TraerTabla("ParteTotalHallazgoSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.ParteTotalHallazgo.rdlc", "Reportes");
          objReporte.Titulo = "Gráfico Total de Hallazgos";

          objReporte.Datos.Add(dttDatos);
          
          objReporte.Parametros.Add("DescFiltro", Filtro.FiltroDesc);
          Cursor = Cursors.Default;
          sbpProgreso.Visible = false;
          break;
        case REPORTES.HallazgoSistema:
          objParam = new object[] {
              Filtro.Filtro
          };

          Cursor = Cursors.WaitCursor;
          dttDatos = Global.DatosApp.TraerTabla("ParteSistemaSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.ParteHallazgoSistema.rdlc", "Reportes");
          objReporte.Titulo = "Gráfico Total de Hallazgos por sistema";

          objReporte.Datos.Add(dttDatos);

          objReporte.Parametros.Add("DescFiltro", Filtro.FiltroDesc);
          Cursor = Cursors.Default;
          sbpProgreso.Visible = false;
          break;
        case REPORTES.TipoHallazgoEstado:
          objParam = new object[] {
              Filtro.Filtro
          };

          Cursor = Cursors.WaitCursor;
          dttDatos = Global.DatosApp.TraerTabla("ParteTipoHallazgoEstadoSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.ParteTipoHallazgoEstado.rdlc", "Reportes");
          objReporte.Titulo = "Hallazgo Por Estados";

          objReporte.Datos.Add(dttDatos);

          objReporte.Parametros.Add("DescFiltro", Filtro.FiltroDesc);
          Cursor = Cursors.Default;
          sbpProgreso.Visible = false;
          break;
        case REPORTES.TipoHallazgoEncargada:
          objParam = new object[] {
              Filtro.Filtro
          };

          Cursor = Cursors.WaitCursor;
          dttDatos = Global.DatosApp.TraerTabla("TipoHallazgoEncargadaSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.TipoHallazgoEncargada.rdlc", "Reportes");
          objReporte.Titulo = "Tipos de Hallazgos por Encargada";

          objReporte.Datos.Add(dttDatos);

          objReporte.Parametros.Add("DescFiltro", Filtro.FiltroDesc);
          Cursor = Cursors.Default;
          sbpProgreso.Visible = false;
          break;
        case REPORTES.TipoHallazgoResponsable:
          objParam = new object[] {
              Filtro.Filtro
          };

          Cursor = Cursors.WaitCursor;
          dttDatos = Global.DatosApp.TraerTabla("TipoHallazgoResponsableSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.TipoHallazgoResponsable.rdlc", "Reportes");
          objReporte.Titulo = "Tipos de Hallazgos por Responsable";

          objReporte.Datos.Add(dttDatos);

          objReporte.Parametros.Add("DescFiltro", Filtro.FiltroDesc);
          Cursor = Cursors.Default;
          sbpProgreso.Visible = false;
          break;
        case REPORTES.TipoHallazgoSolicitante:
          objParam = new object[] {
              Filtro.Filtro
          };

          Cursor = Cursors.WaitCursor;
          dttDatos = Global.DatosApp.TraerTabla("TipoHallazgoSolicitanteSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.TipoHallazgoSolicitante.rdlc", "Reportes");
          objReporte.Titulo = "Tipos de Hallazgos por Solicitante";

          objReporte.Datos.Add(dttDatos);

          objReporte.Parametros.Add("DescFiltro", Filtro.FiltroDesc);
          Cursor = Cursors.Default;
          sbpProgreso.Visible = false;
          break;
        case REPORTES.CantidadTotalHallazgos:
          objParam = new object[] {
              Filtro.Filtro
          };

          Cursor = Cursors.WaitCursor;
          dttDatos = Global.DatosApp.TraerTabla("CantidadTotalHallazgoSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.CantidadTotalHallazgos.rdlc", "Reportes");
          objReporte.Titulo = "Cantidad Hallazgos - Totales";

          objReporte.Datos.Add(dttDatos);

          objReporte.Parametros.Add("DescFiltro", Filtro.FiltroDesc);
          Cursor = Cursors.Default;
          sbpProgreso.Visible = false;
          break;
        case REPORTES.TipoAsuntoHallazgos:
          objParam = new object[] {
              Filtro.Filtro
          };

          Cursor = Cursors.WaitCursor;
          dttDatos = Global.DatosApp.TraerTabla("TipoAsuntoHallazgoSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.TipoAsuntoHallazgos.rdlc", "Reportes");
          objReporte.Titulo = "Tipos de Asunto - Hallazgo";

          objReporte.Datos.Add(dttDatos);

          objReporte.Parametros.Add("DescFiltro", Filtro.FiltroDesc);
          Cursor = Cursors.Default;
          sbpProgreso.Visible = false;
          break;
        case REPORTES.ParteDescripcionDet:
          objParam = new object[] {
              Filtro.Filtro
          };

          Cursor = Cursors.WaitCursor;
          dttDatos = Global.DatosApp.TraerTabla("ParteDescripcionDetSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.ParteDescripcionDet.rdlc", "Reportes");
          objReporte.Titulo = "Descripcion Hallazgo";

          objReporte.Datos.Add(dttDatos);

          objReporte.Parametros.Add("DescFiltro", Filtro.FiltroDesc);
          Cursor = Cursors.Default;
          sbpProgreso.Visible = false;
          break;
        case REPORTES.TipoHallazgoCliente:
          objParam = new object[] {
              Filtro.Filtro
          };

          Cursor = Cursors.WaitCursor;
          dttDatos = Global.DatosApp.TraerTabla("TipoHallazgoClienteSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.TipoHallazgoCliente.rdlc", "Reportes");
          objReporte.Titulo = "Tipo de Hallazgos - Cliente";

          objReporte.Datos.Add(dttDatos);

          objReporte.Parametros.Add("DescFiltro", Filtro.FiltroDesc);
          Cursor = Cursors.Default;
          sbpProgreso.Visible = false;
          break;
        case REPORTES.ParteTipoAsuntoArea:
          objParam = new object[] {
              Filtro.Filtro
          };

          Cursor = Cursors.WaitCursor;
          dttDatos = Global.DatosApp.TraerTabla("ParteTipoAsuntoAreaSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.ParteTipoAsuntoArea.rdlc", "Reportes");
          objReporte.Titulo = "Tipo de Asunto por Area";

          objReporte.Datos.Add(dttDatos);

          objReporte.Parametros.Add("DescFiltro", Filtro.FiltroDesc);
          Cursor = Cursors.Default;
          sbpProgreso.Visible = false;
          break;
        case REPORTES.EncargadaDetalle:
          objParam = new object[] {
              Filtro.Filtro
          };

          Cursor = Cursors.WaitCursor;
          dttDatos = Global.DatosApp.TraerTabla("EncargadaDetalleSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.EncargadaDetalleHallazgo.rdlc", "Reportes");
          objReporte.Titulo = "Asunto por Encargada";

          objReporte.Datos.Add(dttDatos);

          objReporte.Parametros.Add("DescFiltro", Filtro.FiltroDesc);
          Cursor = Cursors.Default;
          sbpProgreso.Visible = false;
          break;
        case REPORTES.ParteTotalDescripcion:
          objParam = new object[] {
              Filtro.Filtro
          };

          Cursor = Cursors.WaitCursor;
          dttDatos = Global.DatosApp.TraerTabla("ParteTotalDetSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.ParteTotalDescripcion.rdlc", "Reportes");
          objReporte.Titulo = "Descripcion Total Hallazgos";

          objReporte.Datos.Add(dttDatos);

          objReporte.Parametros.Add("DescFiltro", Filtro.FiltroDesc);
          Cursor = Cursors.Default;
          sbpProgreso.Visible = false;
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
      Global.LlamarFormulario<DesviacionInterna>(false, TomarId(dtgPrincipal));
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
      Global.LlamarFormulario<DesviacionInterna>(false, -1);
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
      tsbEliminar.Enabled = e.FilaDatos != null && PuedeActualizar && e.FilaDatos.XEnInt(ESTADO_PARTE.EnEdicion);
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

    private void txtSolicitante_TextChanged(object sender, EventArgs e) {

    }
  }
}