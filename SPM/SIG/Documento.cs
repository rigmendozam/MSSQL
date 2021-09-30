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
using System.IO;
using ITD.Log;
using System.Text.RegularExpressions;

namespace APP {

  public partial class Documento : FrmBaseGrid {

    #region Declaraciones

    #region Por Defecto

    private static readonly ACCESO_OPCION Acceso = ACCESO_OPCION.GestorDocumental;

    public static bool TieneAcceso {
      get { return Global.DatosApp.TieneAcceso(Acceso) != TIPO_ACCESO.Sin_Acceso; }
    }

    #endregion

    #endregion

    #region Inicial

    public Documento() {
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
      List<Registro> listaResultados = Global.DatosApp.ActualizarMasivo("Documento", listaCambios, false);
      Cursor = Cursors.Default;
      if (listaResultados.HayErrores()) {
        SincronizarCambios(dtgPrincipal, listaResultados);
        MessageBox.Show("No se guardaron todos los datos porque existen filas con errores.", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return GUARDAR_RESULT.GuardadoError;
      }
      return GUARDAR_RESULT.GuardadoOk;
    }

    protected override object[] TomarParametrosAInsertar(DataGridView dtgGrilla, DataRow dtrFila) {
      if (PathIsValid(dtrFila["Extencion"].ToString())) {
        DateTime dtFecha = DateTime.MinValue;
        string strExtencion = Path.GetExtension(dtrFila["Extencion"].ToString());
        var res = Global.Transfer.SubirArchivo(dtrFila["Extencion"].ToString(), Path.Combine(Global.CARPETA_GESTOR_DOC, dtrFila["IdSubcategoria"].ToString(), dtrFila["NombreDoc"].ToString() + strExtencion), ref dtFecha);

        dtrFila["Extencion"] = strExtencion;
        dtrFila["FechaDoc"] = dtFecha;


      }

      return base.TomarParametrosAInsertar(dtgGrilla, dtrFila);
    }

    protected override object[] TomarParametrosAModificar(DataGridView dtgGrilla, DataRow dtrFila) {
      if (PathIsValid(dtrFila["Extencion"].ToString())) {
        DateTime dtFecha = DateTime.MinValue;
        string strExtencion = Path.GetExtension(dtrFila["Extencion"].ToString());
        var res = Global.Transfer.SubirArchivo(dtrFila["Extencion"].ToString(), Path.Combine(Global.CARPETA_GESTOR_DOC, dtrFila["IdSubcategoria"].ToString(), dtrFila["NombreDoc"].ToString() + strExtencion), ref dtFecha);

        dtrFila["Extencion"] = strExtencion;
        dtrFila["FechaDoc"] = dtFecha;


      }
      return base.TomarParametrosAModificar(dtgGrilla, dtrFila);
    }

    #endregion

    #region Interfaz

    public override void RefrescarTodo() {
      tsbGuardar.Enabled = false;
      Cursor = Cursors.WaitCursor;
      DataTable dtTabla = Global.DatosApp.TraerTabla("DocumentoSel_Grids");
      Cursor = Cursors.Default;
      if (dtTabla != null) {
        RefrescarGrilla(dtgPrincipal, dtTabla.DefaultView);
        RefrescarGrilla(dtgSubcategoria, Global.Cache.TomarVista(ClaseCache.TABLA.DocSubcategoria, "Id>0", "Subcategoria"));
        RefrescarGrilla(dtgCategoria, Global.Cache.TomarVista(ClaseCache.TABLA.DocCategoria, "Id> 0", "Categoria"));
        MostrarModificado(false);
      } else {
        MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);

      }
      ValidaCambios = PuedeActualizar;
      CadenaValoresInicial = CrearCadenaValores();

    }

    private void ValidarFila(DataRow dtrFila) {
      StringBuilder stbError = new StringBuilder();

      if (dtrFila.XEsNuloOVacio("NombreDoc"))
        stbError.AppendLine("Nombre del documento es requerido");

      if (dtrFila.XEsNuloOVacio("Extencion"))
        stbError.AppendLine("Archivo es requerido");

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

    #endregion

    #region Eventos de Controles

    #endregion

    #region Eventos de Grilla

    private void dtgPrincipal_AntesInsertar(object sender, FilaEventArg e) {
      e.Fila["IdSubcategoria"] = TomarId(dtgSubcategoria);
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

    private void dtgPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex == -1) return;

      if (e.ColumnIndex == ColCargar.Index) {
        OpenFileDialog ofd = new OpenFileDialog();
        ofd.Filter = "PDF files (*.pdf)|*.pdf|Word files (*.docx)|*.docx|Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
        ofd.Multiselect = false;

        if (ofd.ShowDialog() == DialogResult.OK) {
          dtgPrincipal.FilaActual["Extencion"] = ofd.FileName;
          dtgPrincipal.FilaActual["FechaDoc"] = File.GetCreationTime(ofd.FileName);
          ValidarFila(dtgPrincipal.FilaActual);
        }

      } else if (e.ColumnIndex == ColVer.Index) {

        bool bolEsPathValido = PathIsValid(dtgPrincipal.FilaActual["Extencion"].ToString());

        if (dtgPrincipal.FilaActual.RowState == DataRowState.Added || bolEsPathValido)
          System.Diagnostics.Process.Start(dtgPrincipal.FilaActual["Extencion"].ToString());
        else {
          string str = Path.Combine(Global.CARPETA_GESTOR_DOC, TomarId(dtgSubcategoria).ToString(), dtgPrincipal.FilaActual["NombreDoc"].ToString() + dtgPrincipal.FilaActual["Extencion"].ToString());
          string strLocal = Path.Combine(Global.CAMINO_DOC_LOCAL, str);

          if (dtgPrincipal.FilaActual.RowState != DataRowState.Added && !File.Exists(strLocal)) {
            ITDError objError = null;

            if (!Directory.Exists(Path.GetDirectoryName(strLocal)))
              Directory.CreateDirectory(Path.GetDirectoryName(strLocal));

            strLocal = Global.Transfer.TomarArchivoRuta(str, dtgPrincipal.FilaActual.XFechaHora("FechaDoc"), ref objError);

          }
          System.Diagnostics.Process.Start(strLocal);

        }
      }

    }

    public bool PathIsValid(string inputPath) {
      return !inputPath.StartsWith(".");
    }

    private void dtgCategoria_DespuesCambioFila(object sender, FilaGrillaEventArg e) {
      int intIdCategoria = 0;

      if (e.FilaDatos != null)
        intIdCategoria = TomarId(dtgCategoria).XEntero();

      dtgSubcategoria.Vista.RowFilter = string.Format("IdCategoria={0}", intIdCategoria);
    }

    private void dtgSubcategoria_DespuesCambioFila(object sender, FilaGrillaEventArg e) {
      int intIdSubcategoria = 0;

      if (e.FilaDatos != null)
        intIdSubcategoria = TomarId(dtgSubcategoria).XEntero();

      dtgPrincipal.Vista.RowFilter = string.Format("IdSubcategoria={0}", intIdSubcategoria);


      dtgPrincipal.ReadOnly = intIdSubcategoria == 0;
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