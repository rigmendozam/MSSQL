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

namespace APP {

  public partial class CorreoSistema : FrmBaseGrid {

    #region Declaraciones

    #region Por Defecto

    private static readonly ACCESO_OPCION Acceso = ACCESO_OPCION.Configuracion;

    private DataSet dtsDatos;

    private enum REPORTES {
      Listado,
      Detalle
    }

    private enum TABLAS {
      Principal,
      Detalle
    }

    public static bool TieneAcceso {
      get { return Global.DatosApp.TieneAcceso(Acceso) != TIPO_ACCESO.Sin_Acceso; }
    }

    public int Id { get; set; }

    #endregion

    #endregion

    #region Inicial

    public CorreoSistema() {
      InitializeComponent();
      IniciarPaginado(1, 50);
      LlenarDdls();
      InicializarFiltros(true);
    }

    private void ConsultaActConDet_Load(object sender, EventArgs e) {
      InicializarParametros();
      RefrescarTodo();
    }

    private void InicializarParametros() {
      ValidarAcceso();
      ValidarCambios(tbpDatos);
      tsbMostrarFiltros_Click(null, null);

      if (ddlReporte.Items.Count > 0) {
        ddlReporte.SelectedIndex = (int)REPORTES.Listado;
        ddlReporte.Visible = ddlReporte.Items.Count > 1;
      } else
        tsbReporte.Visible = ddlReporte.Visible = false;

    }

    private void ValidarAcceso() {
      PuedeActualizar = Global.DatosApp.TieneAcceso(Acceso) == TIPO_ACCESO.Editar;
    }

    #endregion

    #region Actualizacion

    public override GUARDAR_RESULT GuardarTodo() {
      GUARDAR_RESULT resultado = GUARDAR_RESULT.CanceladoGuardar;
      if (!dtgDetalles.FinalizaEdicion()) {
        return resultado;
      }

      if (!Validar()) {
        return resultado;
      }

      if (dtgDetalles.HayErrores) {
        MessageBox.Show("No se pueden guardar los cambios porque existen filas con errores.", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return resultado;
      }

      bool bolOK =  Modificar();

      if (bolOK) {
        EstadoForma = ESTADO_FORMA.Modificando;
        resultado = GUARDAR_RESULT.GuardadoOk;

        var listaCambios = TomarFilasModificadas(dtgDetalles);
        var listaResultados = Global.DatosApp.ActualizarMasivo("CorreoSistemaUsuario", listaCambios, false);
        SincronizarCambios(dtgDetalles, listaResultados);

        if (dtgDetalles.HayErrores) {
          MessageBox.Show("No se guardaron todos los cambios porque existen filas con errores.", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
          resultado = GUARDAR_RESULT.GuardadoError;
        }
      } else {
        resultado = GUARDAR_RESULT.GuardadoError;
      }
      return resultado;
    }

    protected override object[] TomarParametrosAInsertar(DataGridView dtgGrilla, DataRow dtrFila) {
      dtrFila["IdCorreoSistema"] = Id;
      return dtrFila.ItemArray.Take(5).ToArray();
    }

    protected override object[] TomarParametrosAModificar(DataGridView dtgGrilla, DataRow dtrFila) {
      dtrFila["IdCorreoSistema"] = Id;
      return dtrFila.ItemArray.Take(5).ToArray();
    }

    private bool Insertar() {
      object[] objParam = new object[] {

      };

      objParam = this.XEjecutarProcedimiento(null, "", objParam);

      if (objParam != null)
        Id = (int)objParam[0];

      return objParam != null;
    }

    private bool Modificar() {
      return null != this.XEjecutarProcedimiento(null, "CorreoSistemaUpd", Id, txtNombre.Text, txtAsunto.Text, txtTexto.Text);
    }

    private bool Eliminar() {
      return null != this.XEjecutarProcedimiento(null, "", Id);
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
      var dtTabla = Global.DatosApp.TraerTabla("CorreoSistemaSel_Grids", objParam);
      Cursor = Cursors.Default;
      if (dtTabla != null) {
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

    private void LimpiarControles() {
      EstadoForma = ESTADO_FORMA.Agregando;

      if (!Inicializando) {
        dtgDetalles.Vista.Table.Clear();
      }

      Id = 0;

      spcPrincipal.Panel2.XLimpiarControl();
      
      tsbReporte.Enabled = false;
      tsbGuardar.Enabled = PuedeActualizar;
      CadenaValoresInicial = CrearCadenaValores();
      ValidaCambios = tsbGuardar.Enabled;
    }

    private void LlenarControles() {
      Cursor = Cursors.WaitCursor;
      dtsDatos = Global.DatosApp.TraerDataset("CorreoSistemaSel_Id", new object[] { Id });
      Cursor = Cursors.Default;

      if (dtsDatos != null) {

        RefrescarGrilla(dtgDetalles, TomarTabla(TABLAS.Detalle).DefaultView);

        if (TomarTabla(TABLAS.Principal).Rows.Count == 0) {
          LimpiarControles();
          return;
        }

        DataRow dtr = TomarTabla(TABLAS.Principal).Rows[0];
        EstadoForma = ESTADO_FORMA.Modificando;

        txtNombre.Text = dtr["Descripcion"].ToString();
        txtAsunto.Text = dtr["Asunto"].ToString();
        txtTexto.Text = dtr["Texto"].ToString();
        
        tsbReporte.Enabled = true;
        tsbGuardar.Enabled = PuedeActualizar;

        CadenaValoresInicial = CrearCadenaValores();
        ValidaCambios = tsbGuardar.Enabled;
      } else {
        MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void LlenarDdls() {
    }

    private bool Validar() {
      StringBuilder stbError = new StringBuilder();

      if (string.IsNullOrWhiteSpace(txtNombre.Text))
        stbError.AppendLine("Nombre es requerido.");

      if (string.IsNullOrWhiteSpace(txtAsunto.Text))
        stbError.AppendLine("Asunto es requerido.");

      if (string.IsNullOrWhiteSpace(txtTexto.Text))
        stbError.AppendLine("Texto es requerido.");

      if (stbError.Length > 0) {
        stbError.Insert(0, "Campos con errores o vacíos:\n");
        MessageBox.Show(stbError.ToString(), APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;
    }

    private void ValidarFila(DataRow dtrFila) {
      StringBuilder stbError = new StringBuilder();

      if(dtrFila.IsNull("IdUsuario"))
        stbError.AppendLine("Usuario es requerido.");

      if (stbError.Length > 0)
        stbError.Insert(0, "Campos con errores o vacíos:\n");
      dtrFila.RowError = stbError.ToString();
    }

    #endregion

    #region Acciones

    public override bool HayCambios() {
      return base.HayCambios() || dtgDetalles.HayCambios;
    }

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

    private DataTable TomarTabla(TABLAS objTabla) {
      return dtsDatos.Tables[(int)objTabla];
    }

    private void LlamaBuscadorFT(DataRow dtrFilaActual, string strNombre) {

      var dttTabla = Global.BuscarUsuario("", strNombre);
      if (dttTabla != null) {
        if (dttTabla.Rows.Count > 0) {
          foreach (DataRow dtr in dttTabla.Rows) {
            DataRow dtrNueva = null;

            dtrNueva = dtrFilaActual;
            
            dtrNueva["IdUsuario"] = dtr["Id"];
            dtrNueva["nombre_empleado"] = dtr["nombre_empleado"];
            
          }
        }
      }
    }

    #endregion

    #region Eventos de barra

    private void tsbEliminar_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a eliminar el registro actual. ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (Eliminar()) {
          LimpiarControles();
          CargarPaginaActual();
        }
      }
    }

    private void tsbFiltrar_Click(object sender, EventArgs e) {
      Filtrar();
    }

    private void tsbGuardar_Click(object sender, EventArgs e) {
      if (GuardarTodo() == GUARDAR_RESULT.GuardadoOk) {
        RefrescarTodo();
      }
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
      if (this.XGuardaCambios(dtgDetalles))
        dtgPrincipal.CurrentCell = null;
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

    private void dtgDetalles_AntesInsertar(object sender, FilaEventArg e) {
      e.Fila["IdCorreoSistema"] = Id;
      e.Fila["Copia"] = true;
      e.Fila["Oculto"] = false;
      ValidarFila(e.Fila);
    }

    private void dtgDetalles_CambiaOperacionRapida(object sender, CambiaOperacionRapidaEvengArg e) {
      sbpMensaje.Text = e.ValorFormateado;
    }

    private void dtgDetalles_CurrentCellDirtyStateChanged(object sender, EventArgs e) {
      DataGridView dgv = sender as DataGridView;
      if (null == dgv || null == dgv.CurrentCell || !dgv.IsCurrentCellDirty) {
        return;
      }

      if ((dgv.CurrentCell is DataGridViewComboBoxCell || dgv.CurrentCell is DataGridViewCheckBoxCell)) {
        dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
      }
    }

    private void dtgDetalles_DespuesModificarFila(object sender, FilaEventArg e) {
      ValidarFila(e.Fila);
    }

    private void dtgDetalles_Enter(object sender, EventArgs e) {
      sbpFilas.Text = ((DataGridView)sender).RowCount.ToString();
    }

    private void dtgPrincipal_AntesCambioFila(object sender, FilaEventArg e) {
      if (!this.XGuardaCambios(dtgDetalles))
        e.Cancel = true;
    }

    private void dtgPrincipal_DespuesCambioFila(object sender, FilaGrillaEventArg e) {
      Id = e.FilaDatos == null ? 0 : (int)TomarId(dtgPrincipal);
      LlenarControles();
    }

    private void dtgDetalles_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex == -1) return;

      if (e.ColumnIndex == colnombre_empleado.Index) {
        LlamaBuscadorFT(dtgDetalles.FilaActual, dtgDetalles.FilaActual["nombre_empleado"].ToString());
      }
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

  }
}