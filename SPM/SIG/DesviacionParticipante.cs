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

  public partial class DesviacionParticipante : FrmBaseGrid {

    #region Declaraciones

    #region Por Defecto

    private static readonly ACCESO_OPCION Acceso = ACCESO_OPCION.Defecto;

    public static bool TieneAcceso {
      get { return Global.DatosApp.TieneAcceso(Acceso) != TIPO_ACCESO.Sin_Acceso; }
    }

    public object[] Parametros { set { IdParte = value[0].XEntero() ; } }

    public int IdParte { get; set; }

    #endregion

    #endregion

    #region Inicial

    public DesviacionParticipante() {
      InitializeComponent();
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
      List<Registro> listaResultados = Global.DatosApp.ActualizarMasivo("ParteReunionAnalisis", listaCambios, false);
      Cursor = Cursors.Default;
      if (listaResultados.HayErrores()) {
        SincronizarCambios(dtgPrincipal, listaResultados);
        MessageBox.Show("No se guardaron todos los datos porque existen filas con errores.", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return GUARDAR_RESULT.GuardadoError;
      }
      return GUARDAR_RESULT.GuardadoOk;
    }

    protected override object[] TomarParametrosAInsertar(DataGridView dtgGrilla, DataRow dtrFila) {
      dtrFila["IdParte"] = IdParte;
      return dtrFila.ItemArray.Take(3).ToArray();
    }

    protected override object[] TomarParametrosAModificar(DataGridView dtgGrilla, DataRow dtrFila) {
      return dtrFila.ItemArray.Take(3).ToArray();
    }

    #endregion

    #region Interfaz

    public override void RefrescarTodo() {
      tsbGuardar.Enabled = false;
      Cursor = Cursors.WaitCursor;
      DataTable dtTabla = Global.DatosApp.TraerTabla("ParteReunionAnalisisSel_Grids", new object[] { IdParte });
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

      if (dtrFila.XEntero("IdParticipante") == 0)
        stbError.AppendLine("Participante es requerido");

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

    private void LlamaBuscadorUsuario(string strNombre) {

      var dttTabla = Global.BuscarUsuario("", strNombre);
      if (dttTabla != null) {
        if (dttTabla.Rows.Count > 0) {

          DataRow dtr = dttTabla.Rows[0];


          dtgPrincipal.FilaActual["nombre_empleado"] = dtr["nombre_empleado"];
          dtgPrincipal.FilaActual["Email"] = dtr["Email"];
          dtgPrincipal.FilaActual["IdParticipante"] = dtr["Id"];

        }
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
      if (this.XGuardaCambios(dtgPrincipal)) {
        RefrescarTodo();
      }
    }

    #endregion

    #region Eventos de Controles

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

      if (e.ColumnIndex == ColParticipante.Index) {
        DataRow dtr = dtgPrincipal.FilaActual;

        if (!dtr.XEsNuloOVacio("nombre_empleado"))
          LlamaBuscadorUsuario(dtr["nombre_empleado"].ToString());

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