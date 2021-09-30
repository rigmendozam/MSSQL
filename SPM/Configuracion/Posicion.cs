using APP_GEN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ITD.AccDatos;
using ITD.Win;
using ITD.Win.Formas;
using System.Linq;
using Global = APP_GEN.Global;

namespace APP {

  public partial class Posicion : FrmBaseGrid {

    #region Declaraciones

    #region Por Defecto

    private static readonly ACCESO_OPCION Acceso = ACCESO_OPCION.Configuracion;
    StringBuilder stbSQL;

    public static bool TieneAcceso {
      get { return Global.DatosApp.TieneAcceso(Acceso) != TIPO_ACCESO.Sin_Acceso; }
    }

    #endregion

    #endregion

    #region Inicial

    public Posicion() {
      InitializeComponent();
    }

    public void InicializarParametros() {
      ValidarAcceso();
      dtgPrincipal.ReadOnly = !PuedeActualizar;
      btnAsignarMasivo.Enabled = false;
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
      List<Registro> listaResultados = Global.DatosApp.ActualizarMasivo("Posiciones", listaCambios, false);
      Cursor = Cursors.Default;

      Global.Cache.EliminarTabla(ClaseCache.TABLA.Posiciones);

      if (listaResultados.HayErrores()) {
        SincronizarCambios(dtgPrincipal, listaResultados);
        MessageBox.Show("No se guardaron todos los datos porque existen filas con errores.", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return GUARDAR_RESULT.GuardadoError;
      }



      return GUARDAR_RESULT.GuardadoOk;
    }

    protected override object[] TomarParametrosAModificar(DataGridView dtgGrilla, DataRow dtrFila) {
      return dtrFila.ItemArray.Take(dtrFila.ItemArray.Length - 3).ToArray();
    }

    #endregion

    #region Interfaz

    public override void RefrescarTodo() {
      tsbGuardar.Enabled = false;
      Cursor = Cursors.WaitCursor;
      DataTable dtTabla = Global.DatosApp.TraerTabla("PosicionesSel_Grids");
      Cursor = Cursors.Default;
      if (dtTabla != null) {
        RefrescarGrilla(dtgPrincipal, dtTabla.DefaultView);
        FormarFiltroLocal();
        MostrarModificado(false);
      }
      else {
        MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);

      }
      ValidaCambios = PuedeActualizar;
      CadenaValoresInicial = CrearCadenaValores();

    }

    private void ValidarFila(DataRow dtrFila) {
      StringBuilder stbError = new StringBuilder();

      if (stbError.Length > 0) {
        stbError.Insert(0, "Campos con errores o vacíos.\n");
      }
      dtrFila.RowError = stbError.ToString();
    }

    private void FormarFiltroLocal() {
      StringBuilder stb = new StringBuilder();
      stbSQL = new StringBuilder();

      if (!string.IsNullOrWhiteSpace(txtFiltro.Text)) {

        string[] strFiltro = txtFiltro.Text.Split(',');

        foreach (string filtro in strFiltro) {
          if (!string.IsNullOrWhiteSpace(filtro)) {

            stb.Append("(");
            stbSQL.Append("(");
            dtgPrincipal.Vista.Table.Columns.Cast<DataColumn>().ToList().ForEach(s => {
              if (s.ColumnName != "Id") stb.AppendFormat("{0} like '%{1}%'", s.DataType != typeof(string) ? string.Format("CONVERT({0}, System.String)", s.ColumnName) : s.ColumnName, filtro).Append(" Or ");
              if (s.ColumnName != "Id") stbSQL.AppendFormat("{0} like '%{1}%'", s.DataType != typeof(string) ? string.Format("cast({0} as varchar)", s.ColumnName) : s.ColumnName, filtro).Append(" Or ");


            });


            if (stb.Length > 0) {
              stb.Remove(stb.Length - 3, 3);
              stb.Append(") And ");
              stbSQL.Remove(stbSQL.Length - 3, 3);
              stbSQL.Append(") And ");
            }
          }
        }

      }
      if (stb.Length > 0) {
        stb.Remove(stb.Length - 4, 4);
        stbSQL.Remove(stbSQL.Length - 4, 4);
      }


      dtgPrincipal.Vista.RowFilter = stb.ToString();

    }

    #endregion

    #region Acciones

    public override bool HayCambios() {
      return dtgPrincipal.HayCambios;
    }

    private DataRow LlamaBuscadorCliente(string strNombre) {
      var dttTabla = Global.BuscarEntidad("", strNombre, true, true);
      if (dttTabla != null) {
        if (dttTabla.Rows.Count > 0) {
          return dttTabla.Rows[0];
        }
        return null;
      }
      else {
        return null;
      }
    }

    private void MostrarReporte() {
      Reporte objReporte = null;
      object[] objParam;
      DataSet dtsDatos;

      objParam = new object[] { stbSQL.ToString() };

          Cursor = Cursors.WaitCursor;
          dtsDatos = APP_GEN.Global.DatosApp.TraerDataset("PosicionesOcupacionSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.PosicionOcupacionLst.rdlc", "Reportes");
          objReporte.Titulo = "Ocupación de posiciones";

          foreach (DataTable dttReporte in dtsDatos.Tables) {
            objReporte.Datos.Add(dttReporte);
          }
          
          Cursor = Cursors.Default;
   
      
      if (objReporte != null)
        objReporte.MostrarReporte(APP_GEN.Global.FormaPrincipal);
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

    #endregion

    #region Eventos de Controles

    private void txtFiltro_TextChanged(object sender, EventArgs e) {
      FormarFiltroLocal();
    }

    private void txtnombre_clie_TextChanged(object sender, EventArgs e) {
      txtnombre_clie.Tag = null;
      btnAsignarMasivo.Enabled = false;
    }

    private void txtnombre_clie_Validated(object sender, EventArgs e) {

      if (txtnombre_clie.Tag == null && !string.IsNullOrWhiteSpace(txtnombre_clie.Text)) {
        DataRow dtr = LlamaBuscadorCliente(txtnombre_clie.Text);

        if (dtr == null)
          txtnombre_clie.Tag = null;
        else {
          txtnombre_clie.Text = dtr["nombre_clie"].ToString();
          txtnombre_clie.Tag = dtr["Id"];
        }
      }

      btnAsignarMasivo.Enabled = txtnombre_clie.Tag as int? != null;

    }

    private void btnAsignarMasivo_Click(object sender, EventArgs e) {
      foreach (DataRowView item in dtgPrincipal.Vista) {
        item["IdCliente"] = txtnombre_clie.Tag;
        item["nombre_clie"] = txtnombre_clie.Text;
        item.EndEdit();
      }

      dtgPrincipal.Refresh();
    }

    private void btnLimpiarMasivo_Click(object sender, EventArgs e) {
      foreach (DataRowView item in dtgPrincipal.Vista) {
        item["IdCliente"] = DBNull.Value;
        item["nombre_clie"] = DBNull.Value;
        item.EndEdit();
      }
      dtgPrincipal.Refresh();
    }
    #endregion

    #region Eventos de Grilla

    private void dtgPrincipal_AntesInsertar(object sender, FilaEventArg e) {
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
      if (e.RowIndex == -1) return;
      if (e.ColumnIndex == colnombre_clie.Index) {

        DataRow dtrFila = dtgPrincipal.FilaActual;

        if (!string.IsNullOrWhiteSpace(dtrFila["nombre_clie"].ToString())) {
          DataRow dtr = LlamaBuscadorCliente(dtrFila["nombre_clie"].ToString());

          if (dtr == null)
            dtrFila["IdCliente"] = DBNull.Value;
          else {
            dtrFila["IdCliente"] = dtr["Id"];
            dtrFila["nombre_clie"] = dtr["nombre_clie"].ToString();
          }
        }
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

    private void tsbReporte_Click(object sender, EventArgs e) {
      MostrarReporte();
    }
  }
}