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

  public partial class Rack : FrmBaseGrid {

    #region Declaraciones

    #region Por Defecto

    private static readonly ACCESO_OPCION Acceso = ACCESO_OPCION.Configuracion;

    public static bool TieneAcceso {
      get { return Global.DatosApp.TieneAcceso(Acceso) != TIPO_ACCESO.Sin_Acceso; }
    }

    #endregion

    #endregion

    #region Inicial

    public Rack() {
      InitializeComponent();
      LlenarDdls();
    }

    public void InicializarParametros() {
      ValidarAcceso();
      dtgPrincipal.ReadOnly = !PuedeActualizar;
    }

    public void ValidarAcceso() {
      PuedeActualizar = Global.DatosApp.TieneAcceso(Acceso) == TIPO_ACCESO.Editar;
    }

    private void GrillaAct_Load(object sender, EventArgs e) {
      InicializarParametros();
      RefrescarTodo();
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
      List<Registro> listaResultados = Global.DatosApp.ActualizarMasivo("Rack", listaCambios, false);
      Cursor = Cursors.Default;
      if (listaResultados.HayErrores()) {
        SincronizarCambios(dtgPrincipal, listaResultados);
        MessageBox.Show("No se guardaron todos los datos porque existen filas con errores.", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return GUARDAR_RESULT.GuardadoError;
      }
      return GUARDAR_RESULT.GuardadoOk;
    }

    protected override object[] TomarParametrosAInsertar(DataGridView dtgGrilla, DataRow dtrFila) {
      return dtrFila.ItemArray.Take(dtrFila.ItemArray.Length - 2).ToArray();
    }

    protected override object[] TomarParametrosAModificar(DataGridView dtgGrilla, DataRow dtrFila) {
      return dtrFila.ItemArray.Take(dtrFila.ItemArray.Length - 2).ToArray();
    }
    
    private bool GenerarPosicion() {
      return null != this.XEjecutarProcedimiento(null, "RackGenerarPosiciones", TomarId(dtgPrincipal));
    }
    
    #endregion

    #region Interfaz

    private void LlenarDdls() {

      colid_planta.DisplayMember = "Planta";
      colid_planta.ValueMember = "Id";
      colid_planta.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Planta, "Id > 0 and activo_planta = 1", "");

      ColTipo.DisplayMember = "Tipo";
      ColTipo.ValueMember = "Id";
      ColTipo.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.RackTipo, "Id > 0", ColTipo.DisplayMember);

      ColModo.DisplayMember = "Modo";
      ColModo.ValueMember = "Id";
      ColModo.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.RackModoUbica, "Id > 0", "");
    }

    private void LlenarDdlBodega(DataGridViewRow dgvr) {


      int intId = (((DataRowView)dgvr.DataBoundItem).Row["id_planta"] as int?) ?? 0;
      DataGridViewComboBoxCell celCombo = (DataGridViewComboBoxCell)dgvr.Cells[colid_bodega.Index];
      celCombo.DisplayMember = "Bodega";
      celCombo.ValueMember = "Id";
      celCombo.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Bodega, string.Format("id_planta={0}", intId), celCombo.DisplayMember);
    }

    public override void RefrescarTodo() {
      tsbGuardar.Enabled = false;
      Cursor = Cursors.WaitCursor;
      DataTable dtTabla = Global.DatosApp.TraerTabla("RackSel_Grids");
      Cursor = Cursors.Default;
      if (dtTabla != null) {
        RefrescarGrilla(dtgPrincipal, dtTabla.DefaultView);
        MostrarModificado(false);
      } else {
        MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);

      }
      ValidaCambios = PuedeActualizar;
      CadenaValoresInicial = CrearCadenaValores();

    }

    private void ValidarFila(DataRow dtrFila) {
      StringBuilder stbError = new StringBuilder();

      if (string.IsNullOrWhiteSpace(dtrFila["id_bodega"].ToString()))
        stbError.AppendLine("Bodega es requerido.");

      if (string.IsNullOrWhiteSpace(dtrFila["IdTipo"].ToString()))
        stbError.AppendLine("Tipo es requerido.");

      if (string.IsNullOrWhiteSpace(dtrFila["nombre_rack"].ToString()))
        stbError.AppendLine("Rack es requerido.");

      if (string.IsNullOrWhiteSpace(dtrFila["posiciones_rack"].ToString()))
        stbError.AppendLine("Posiciones es requerido.");

      if (string.IsNullOrWhiteSpace(dtrFila["filas_rack"].ToString()))
        stbError.AppendLine("Filas es requerido.");

      if (string.IsNullOrWhiteSpace(dtrFila["colu_rack"].ToString()))
        stbError.AppendLine("Columnas es requerido.");

      if (string.IsNullOrWhiteSpace(dtrFila["FilaValorInicial"].ToString()))
        stbError.AppendLine("Valor inicial de la fila es requerido.");

      if (stbError.Length > 0) {
        stbError.Insert(0, "Campos con errores o vacíos.\n");
      }
      dtrFila.RowError = stbError.ToString();
    }

    #endregion

    #region Acciones

    public override bool HayCambios() {
      return dtgPrincipal.HayCambios;
    }

    #endregion

    #region Eventos de Barra

    private void tsbGuardar_Click(object sender, EventArgs e) {
      if (GuardarTodo() == GUARDAR_RESULT.GuardadoOk) {
        RefrescarTodo();
      }
    }

    private void tsbRefrescar_Click(object sender, EventArgs e) {
      if (this.XGuardaCambios(dtgPrincipal)) {
        RefrescarTodo();
      }
    }

    private void tsbGenerarPosicion_Click(object sender, EventArgs e) {
      DataRow dtr = dtgPrincipal.FilaActual;
      bool bolGenerado = Convert.ToBoolean(dtr["Generado"]);
      DialogResult dlgOK = DialogResult.Cancel;
      if (bolGenerado) 
        dlgOK = MessageBox.Show("Va a regenerar las posiciones, esto implica que se eliminarán las posiciones actuales y se crearán nuevamente. ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question);          
      else
        dlgOK = MessageBox.Show("Va a generar las posiciones. ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question);


      if (dlgOK == DialogResult.Yes) {
        if (GenerarPosicion())
          RefrescarTodo();
      }
    }

    #endregion

    #region Eventos de Controles

    #endregion

    #region Eventos de Grilla

    private void dtgPrincipal_AntesInsertar(object sender, FilaEventArg e) {
      e.Fila["Generado"] = 0;
      ValidarFila(e.Fila);
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

    private void dtgPrincipal_InformaCambios(object sender, EventArgs e) {
      tsbGuardar.Enabled = PuedeActualizar;
      MostrarModificado(true);
      sbpFilas.Text = dtgPrincipal.RowCount.ToString();
    }

    private void dtgPrincipal_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex > -1) {
        if (e.ColumnIndex == colid_planta.Index) {
          LlenarDdlBodega(dtgPrincipal.CurrentRow);
        }
        else if (e.ColumnIndex == colfilas_rack.Index || e.ColumnIndex == colcolu_rack.Index) {
          DataRow dtr = dtgPrincipal.FilaActual;

          dtr["posiciones_rack"] = ((dtr["filas_rack"] as int?) ?? 0) * ((dtr["colu_rack"] as int?) ?? 0);
          dtr.EndEdit();
        }
      }
    }

    private void dtgPrincipal_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
      if (e.ListChangedType == System.ComponentModel.ListChangedType.Reset) {
        foreach (DataGridViewRow item in dtgPrincipal.Rows) {
          LlenarDdlBodega(item);

          DataRow dtr = ((DataRowView)item.DataBoundItem).Row;

          item.Cells[ColLetraInicial.Index].ReadOnly = item.Cells[colcolu_rack.Index].ReadOnly = item.Cells[colfilas_rack.Index].ReadOnly = Convert.ToBoolean(dtr["Generado"]);
        }
      }
    }

    private void dtgPrincipal_DespuesCambioFila(object sender, FilaGrillaEventArg e) {
      if (e.FilaDatos != null) {

        if(Convert.ToBoolean(e.FilaDatos["Generado"]))
          dtgPrincipal.DesctivarOpcionMenu(Grilla.OPC_MENU.Eliminar);
        else
          dtgPrincipal.ActivarOpcionMenu(Grilla.OPC_MENU.Eliminar);

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