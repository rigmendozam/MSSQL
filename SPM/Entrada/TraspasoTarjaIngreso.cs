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

  public partial class TraspasoTarjaIngreso : FrmBaseGrid {

    #region Declaraciones

    #region Por Defecto

    private static readonly ACCESO_OPCION Acceso = ACCESO_OPCION.TraspasoTarjaIng;

    private DataSet dtsDatos;

    private Type[] formulariosRefrescar = new Type[] {
      typeof(TraspasoTarjaProdCons)
    };

    private enum REPORTES {
      Detalle
    }

    private enum TABLAS {
      Principal = 0,
      Detalle = 1
    }

    public static bool TieneAcceso {
      get { return Global.DatosApp.TieneAcceso(Acceso) != TIPO_ACCESO.Sin_Acceso; }
    }

    public object[] Parametros { set { Id = value.XTomarId(); } }

    public int Id { get; set; }

    #endregion

    TRASPASO_ESTADO objEstado;

    #endregion

    #region Inicial

    public TraspasoTarjaIngreso() {
      InitializeComponent();
      LlenarDdls();
    }

    private void ActualizacionGrilla_Load(object sender, EventArgs e) {
      InicializarParametros();
      RefrescarTodo();
    }

    private void InicializarParametros() {
      ValidarAcceso();
      ValidarCambios(pnlPrincipal);

      if (ddlReporte.Items.Count > 0) {
        ddlReporte.SelectedIndex = (int)REPORTES.Detalle;
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
      if (!dtgPrincipal.FinalizaEdicion()) {
        return resultado;
      }

      if (!Validar()) {
        return resultado;
      }

      if (dtgPrincipal.HayErrores) {
        MessageBox.Show("No se pueden guardar los cambios porque existen filas con errores.", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return resultado;
      }

      bool bolOK = EstadoForma == ESTADO_FORMA.Agregando ? Insertar() : Modificar();
      Cursor = Cursors.WaitCursor;

      if (bolOK) {
        EstadoForma = ESTADO_FORMA.Modificando;
        resultado = GUARDAR_RESULT.GuardadoOk;

        var listaCambios = TomarFilasModificadas(dtgPrincipal);
        var listaResultados = Global.DatosApp.ActualizarMasivo("TraspasoTarjaIngDet", listaCambios, false);
        SincronizarCambios(dtgPrincipal, listaResultados);

        if (dtgPrincipal.HayErrores) {
          MessageBox.Show("No se guardaron todos los cambios porque existen filas con errores.", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
          resultado = GUARDAR_RESULT.GuardadoError;
        }
      } else {
        resultado = GUARDAR_RESULT.GuardadoError;
      }
      Cursor = Cursors.Default;
      return resultado;
    }

    protected override object[] TomarParametrosAInsertar(DataGridView dtgGrilla, DataRow dtrFila) {
      dtrFila["IdTraspaso"] = Id;
      return dtrFila.ItemArray.Take(4).ToArray();
    }

    protected override object[] TomarParametrosAModificar(DataGridView dtgGrilla, DataRow dtrFila) {
      return dtrFila.ItemArray.Take(4).ToArray();
    }

    private bool Eliminar() {
      return null != this.XEjecutarProcedimiento(formulariosRefrescar, "TraspasoTarjaIngDel", Id);
    }

    private bool Insertar() {
      object[] objParam = new object[] {
        Id,
        ddlOrigen.SelectedValue,
        ddlDestino.SelectedValue,
        txtObservaciones.XTextoONulo(),
        Global.DatosApp.InfoUsr.IdUsuario
      };

      objParam = this.XEjecutarProcedimiento(formulariosRefrescar, "TraspasoTarjaIngIns", objParam);

      if (objParam != null)
        Id = (int)objParam[0];

      return objParam != null;
    }

    private bool Modificar() {
      object[] objParam = new object[] {
        Id,
        ddlOrigen.SelectedValue,
        ddlDestino.SelectedValue,
        txtObservaciones.XTextoONulo(),
        Global.DatosApp.InfoUsr.IdUsuario
      };

      return null != this.XEjecutarProcedimiento(formulariosRefrescar, "TraspasoTarjaIngUpd", objParam);
    }

    private bool CambiarEstado(TRASPASO_ESTADO objNuevoEstado) {
      return null != this.XEjecutarProcedimiento(formulariosRefrescar, "TraspasoTarjaIngCambiarEstado", Id, (int)objNuevoEstado, Global.DatosApp.InfoUsr.IdUsuario);
    }

    #endregion

    #region Interfaz

    public void LlamadoDesdePrincipal(params object[] parametros) {
      if (this.XGuardaCambios(dtgPrincipal)) {
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
      }
      Id = 0;

      pnlPrincipal.XLimpiarControl();
      objEstado = TRASPASO_ESTADO.EnEdicion;

      colCantidad.ReadOnly = colNombre.ReadOnly = colnombre_ptt.ReadOnly = colcodigo_ptt.ReadOnly = true;
      

      tsbEliminar.Enabled = false;
      tsbReporte.Enabled = false;
      tsbGuardar.Enabled = PuedeActualizar;
      tsbNuevo.Enabled = false;
      tsbValidar.Visible = false;
      tsbAnular.Visible = false;
      CadenaValoresInicial = CrearCadenaValores();
      ValidaCambios = tsbGuardar.Enabled;
    }

    private void LlenarControles() {
      Cursor = Cursors.WaitCursor;
      dtsDatos = Global.DatosApp.TraerDataset("TraspasoTarjaIngSel_Id", new object[] { Id });
      Cursor = Cursors.Default;

      if (dtsDatos != null) {
        RefrescarGrilla(dtgPrincipal, TomarTabla(TABLAS.Detalle).DefaultView);

        if (TomarTabla(TABLAS.Principal).Rows.Count == 0) {
          LimpiarControles();
          return;
        }

        DataRow dtr = TomarTabla(TABLAS.Principal).Rows[0];
        EstadoForma = ESTADO_FORMA.Modificando;

        ddlOrigen.SelectedValue = dtr["IdPlantaOrigen"];
        ddlOrigen_SelectedIndexChanged(null, null);
        ddlDestino.SelectedValue = dtr["IdPlantaDestino"];

        txtObservaciones.Text = dtr["Observacion"].ToString();

        objEstado = (TRASPASO_ESTADO)dtr.XEntero("IdEstado");

        tsbEliminar.Enabled = PuedeActualizar;
        tsbReporte.Enabled = true;
        tsbGuardar.Enabled = PuedeActualizar;
        tsbNuevo.Enabled = PuedeActualizar;
        tsbValidar.Visible = PuedeActualizar && objEstado == TRASPASO_ESTADO.EnEdicion;
        tsbAnular.Visible = PuedeActualizar && objEstado == TRASPASO_ESTADO.Validado;

        CadenaValoresInicial = CrearCadenaValores();
        ValidaCambios = tsbGuardar.Enabled;
      } else {
        MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void LlenarDdls() {

      ddlOrigen.DataSource = Global.DatosApp.TomarMisPlantas();
    }

    private bool Validar() {
      StringBuilder stbError = new StringBuilder();

      if (ddlOrigen.SelectedValue == null)
        stbError.AppendLine("Origen es requerido.");

      if (ddlDestino.SelectedValue == null)
        stbError.AppendLine("Destino es requerido.");

      if (stbError.Length > 0) {
        stbError.Insert(0, "Campos con errores o vacíos:\n");
        MessageBox.Show(stbError.ToString(), APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;
    }

    private void ValidarFila(DataRow dtrFila) {
      StringBuilder stbError = new StringBuilder();

      if (string.IsNullOrWhiteSpace(dtrFila["id_taring"].ToString()))
        stbError.AppendLine("Tarja es requerida");

      if (string.IsNullOrWhiteSpace(dtrFila["Cantidad"].ToString()))
        stbError.AppendLine("Cantidad es requerida");
      else if(dtrFila.XEntero("Cantidad") <= 0)
        stbError.AppendLine("Cantidad no válida");


      if (stbError.Length > 0)
        stbError.Insert(0, "Campos con errores o vacíos:\n");
      dtrFila.RowError = stbError.ToString();
    }

    #endregion

    #region Acciones

    public override bool HayCambios() {
      return base.HayCambios() || dtgPrincipal.HayCambios;
    }

    private void MostrarReporte() {
      Reporte objReporte = null;
      object[] objParam;
      switch ((REPORTES)ddlReporte.SelectedIndex) {
        case REPORTES.Detalle:
          objParam = new object[] { Id };

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

    private DataRow TraerTarja(string strNumTarja) {

      DataTable dt = Global.DatosApp.TraerTabla("TarjaIngresoBuscarTarja", new object[] { strNumTarja, ddlOrigen.SelectedValue });

      if (dt != null) {
        if(dt.Rows.Count > 0)
          return dt.Rows[0];
        else
          MessageBox.Show("No existe la tarja ingresada o la tarja no se encuentra en un estado para ser usada.", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
      } else
        MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);

      return null;
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
      if (this.XGuardaCambios(dtgPrincipal)) {
        LimpiarControles();
      }
    }

    private void tsbRefrescar_Click(object sender, EventArgs e) {
      if (this.XGuardaCambios(dtgPrincipal)) {
        RefrescarTodo();
      }
    }

    private void tsbReporte_Click(object sender, EventArgs e) {
      MostrarReporte();
    }

    private void tsbValidar_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a validar el traspaso ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (CambiarEstado(TRASPASO_ESTADO.Validado))
          RefrescarTodo();
      }
    }

    private void tsbAnular_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a anular el traspaso ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (CambiarEstado(TRASPASO_ESTADO.Anulado))
          RefrescarTodo();
      }
    }

    #endregion

    #region Eventos de controles

    private void Control_Enter(object sender, EventArgs e) {
      sender.XSeleccionarTextoEnControl();
    }

    private void ddlOrigen_SelectedIndexChanged(object sender, EventArgs e) {
      ddlDestino.DataSource = Global.DatosApp.TomarMisPlantas(string.Format("Id <> {0}", ddlOrigen.SelectedValue.XEntero()));
      ddlDestino.SelectedIndex = -1;
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

    private void dtgPrincipal_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex == -1) return;

      DataRow dtrFila = dtgPrincipal.FilaActual;
      if (e.ColumnIndex == colNumTarja.Index) {

        DataRow dtr = TraerTarja(dtrFila["id_taring"].ToString());


        if (dtr != null) {

          dtrFila["IdTarjaIng"] = dtr["Id"];
          dtrFila["id_taring"] = dtr["id_taring"];
          dtrFila["Cantidad"] = dtr["Cantidad"];
          dtrFila["id_insumo"] = dtr["id_insumo"];
          dtrFila["nombre_insumo"] = dtr["nombre_insumo"];
          dtrFila["Nombre"] = dtr["Nombre"];

          dtgPrincipal.InvalidateRow(dtgPrincipal.CurrentRow.Index);

        }

      }

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

    private void dtgPrincipal_KeyDown(object sender, KeyEventArgs e) {
     
    }
  }
}