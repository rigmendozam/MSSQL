using APP_GEN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ITD.Win;
using ITD.Win.Formas;
using Global = APP_GEN.Global;
using System.IO;
using ITD.Log;

namespace APP {

  public partial class DesviacionPlanAccionCons : FrmBaseGrid {

    #region Declaraciones

    #region Por Defecto

    private static readonly ACCESO_OPCION Acceso = ACCESO_OPCION.Desviacion;
    private static readonly ACCESO_OPCION AccesoPlanAccionCerrar = ACCESO_OPCION.PlanAccionCerrar;

    private enum REPORTES {
      Listado,
      Detalle
    }

    public static bool TieneAcceso {
      get { return Global.DatosApp.TieneAcceso(Acceso) != TIPO_ACCESO.Sin_Acceso; }
    }

    #endregion

    bool bolPlanAccionCerrar = false;

    #endregion

    #region Inicial

    public DesviacionPlanAccionCons() {
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

      Filtro.Agregar(new FiltroTextBox(txtSolicitante, chkSolicitante, TIPO_OPERADOR.Contiene, "Usuarios.nombre_empleado", "Responsable", TIPO_DATO.Texto));
      Filtro.Agregar(new FiltroDropDown(ddlOrigen, chkOrigen, TIPO_OPERADOR.Igual, "Parte.IdOrigen", "Origen", TIPO_DATO.Entero));
      Filtro.Agregar(new FiltroDropDown(ddlArea, chkArea, TIPO_OPERADOR.Igual, "Parte.IdAreas", "Área", TIPO_DATO.Entero));
      Filtro.Agregar(new FiltroDropDown(ddlTipoHallazgo, chkTipoHallazgo, TIPO_OPERADOR.Igual, "Parte.IdTipoHallazgo", "Tipo Hallazgo", TIPO_DATO.Entero));
      Filtro.Agregar(new FiltroDatePicker(dtpFechaDesde, chkFechaDesde, ddlFechaDesde, "PartePlanAccion.Fecha", "Fecha Desde", TIPO_DATO.Fecha, TIPO_OPERADOR.MayorIgual));
      Filtro.Agregar(new FiltroDatePicker(dtpFechaHasta, chkFechaHasta, ddlFechaHasta, "PartePlanAccion.Fecha", "Fecha Hasta", TIPO_DATO.Fecha, TIPO_OPERADOR.MenorIgual));

      Filtro.Agregar(new FiltroListBox(lstEstado, chkEstado, ddlEstado, "PartePlanAccion.IdEstado", "Estado", TIPO_DATO.Entero));
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
      bolPlanAccionCerrar = Global.DatosApp.TieneAcceso(AccesoPlanAccionCerrar) == TIPO_ACCESO.Editar;
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
      var dtTabla = Global.DatosApp.TraerTabla("PartePlanAccionSel_Grids", objParam);
      Cursor = Cursors.Default;
      if (dtTabla != null) {
        tsbModificar.Enabled = tsbCerrar.Enabled = tsbReporte.Enabled = dtTabla.Rows.Count > 0;
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

      lstEstado.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.PartePlanAccionEstado, "Id > 0", "");
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
          dttDatos = Global.CargarDatosReporte("PROCEDIMIENTO", objParam);
          objReporte = new Reporte("APP.Reportes.NOMBREREPORTE.rdlc");
          objReporte.Titulo = "TITULO";

          objReporte.Datos.Add(dttDatos);

          objReporte.Parametros.Add("Sistema", APP_GEN.Global.DatosApp.Sistema);
          objReporte.Parametros.Add("DescFiltro", Filtro.FiltroDesc);
          Cursor = Cursors.Default;
          sbpProgreso.Visible = false;
          break;

        case REPORTES.Detalle:
          objParam = new object[] { TomarId(dtgPrincipal) };

          Cursor = Cursors.WaitCursor;
          var dtsDatos = APP_GEN.Global.DatosApp.TraerDataset("PROCEDIMIENTO", objParam);
          objReporte = new Reporte("APP.Reportes.NOMBREREPORTE.rdlc");
          objReporte.Titulo = "TITULO";

          foreach (DataTable dttReporte in dtsDatos.Tables) {
            objReporte.Datos.Add(dttReporte);
          }
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
      Global.LlamarFormulario<DesviacionInterna>(false, dtgPrincipal.FilaActual.XEntero("IdParte"));
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

    private void tsbQuitarFiltro_Click(object sender, EventArgs e) {
      Filtro.LimpiarFiltros();
    }

    private void tsbReporte_Click(object sender, EventArgs e) {
      MostrarReporte();
    }

    private void tsbCerrar_Click(object sender, EventArgs e) {
      var res = Global.LlamarFormulario<DesviacionPlanAccionCerrar>(true, TomarId(dtgPrincipal));

      if (res.DialogResult == DialogResult.OK)
        Filtrar();
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
      tsbCerrar.Enabled = e.FilaDatos != null && e.FilaDatos.XEnInt("IdEstadoPlanAccion", PLAN_ACCION_ESTADO.EnProceso) && (e.FilaDatos.XEnInt("IdResponsable", Global.DatosApp.InfoUsr.IdUsuario) || bolPlanAccionCerrar);
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
      if (e.RowIndex == -1) return;

      if (e.ColumnIndex == ColCargar.Index) {
        OpenFileDialog ofd = new OpenFileDialog();
        ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
        ofd.Multiselect = false;

        if (ofd.ShowDialog() == DialogResult.OK) {
          DateTime dtFecha = DateTime.MinValue;
          string strNombreArchivo = Path.GetFileName(ofd.FileName);
          var res = Global.Transfer.SubirArchivo(ofd.FileName, Path.Combine(Global.CARPETA_PLAN_ACCION, TomarId(dtgPrincipal).ToString(), strNombreArchivo), ref dtFecha);

          Global.DatosApp.Ejecutar("PartePlanAccionSubirImagen", new object[] { TomarId(dtgPrincipal), strNombreArchivo, dtFecha });

        } 

      } else if (e.ColumnIndex == ColVer.Index && !dtgPrincipal.FilaActual.XEsNuloOVacio("NombreArchivo")) {
        string str = Path.Combine(Global.CARPETA_PLAN_ACCION, TomarId(dtgPrincipal).ToString(), dtgPrincipal.FilaActual["NombreArchivo"].ToString());
        string strLocal = Path.Combine(Global.CAMINO_DOC_LOCAL, str);

        ITDError objError = null;

        if (!Directory.Exists(Path.GetDirectoryName(strLocal)))
          Directory.CreateDirectory(Path.GetDirectoryName(strLocal));

        strLocal = Global.Transfer.TomarArchivoRuta(str, dtgPrincipal.FilaActual.XFechaHora("FechaArchivo"), ref objError);
        System.Diagnostics.Process.Start(strLocal);
      }
    }
  }
}