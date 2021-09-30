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

namespace APP {

  public partial class Correlativo : FrmBaseGrid {

    #region Declaraciones

    #region Por Defecto

    private static readonly ACCESO_OPCION Acceso = ACCESO_OPCION.Configuracion;

    public static bool TieneAcceso {
      get { return Global.DatosApp.TieneAcceso(Acceso) != TIPO_ACCESO.Sin_Acceso; }
    }

    #endregion

    #endregion

    #region Inicial

    public Correlativo() {
      InitializeComponent();
    }

    public void InicializarParametros() {
      ValidarAcceso();
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
      List<Registro> listaResultados = Global.DatosApp.ActualizarMasivo("Correlativos", listaCambios, false);
      Cursor = Cursors.Default;
      if (listaResultados.HayErrores()) {
        SincronizarCambios(dtgPrincipal, listaResultados);
        MessageBox.Show("No se guardaron todos los datos porque existen filas con errores.", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return GUARDAR_RESULT.GuardadoError;
      }
      return GUARDAR_RESULT.GuardadoOk;
    }

    #endregion

    #region Interfaz

    public override void RefrescarTodo() {
      tsbGuardar.Enabled = false;
      Cursor = Cursors.WaitCursor;
      DataSet dtTabla = Global.DatosApp.TraerDataset("CorrelativosSel_Grids");
      Cursor = Cursors.Default;
      if (dtTabla != null) {
        RefrescarGrilla(dtgCAF, dtTabla.Tables[1].DefaultView);
        RefrescarGrilla(dtgPrincipal, dtTabla.Tables[0].DefaultView);
        MostrarModificado(false);
      } else {
        MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);

      }
      ValidaCambios = PuedeActualizar;
      CadenaValoresInicial = CrearCadenaValores();

    }

    private void ValidarFila(DataRow dtrFila) {
      StringBuilder stbError = new StringBuilder();

      if (string.IsNullOrWhiteSpace(dtrFila["id_prefijo_correlativo"].ToString()))
        stbError.AppendLine("Prefijo es requerido");
      
      if (string.IsNullOrWhiteSpace(dtrFila["nombre_correlativo"].ToString()))
        stbError.AppendLine("Nombre es requerido");
      
      if (string.IsNullOrWhiteSpace(dtrFila["modulo_correlativo"].ToString()))
        stbError.AppendLine("Módulo es requerido");
      
      if (string.IsNullOrWhiteSpace(dtrFila["numero_correlativo"].ToString()))
        stbError.AppendLine("Número es requerido");
      

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

    private void tsbCargarCAF_Click(object sender, EventArgs e) {
      OpenFileDialog oflNum = new OpenFileDialog();
      oflNum.DefaultExt = ".xml";
      oflNum.Filter = "xml files (*.xml)|*.xml"; ;
      oflNum.RestoreDirectory = true;

      if (oflNum.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
        if (Path.GetExtension(oflNum.SafeFileName).ToUpper() == ".XML") {
          DataSet dtsNum = new DataSet("Num");

          try {

            dtsNum.ReadXml(oflNum.FileName);

            string strRutEmiros = dtsNum.Tables["DA"].Rows[0]["RE"].ToString();
            int intTipoDoc = Convert.ToInt32(dtsNum.Tables["DA"].Rows[0]["TD"]);
            DateTime dttFecha = Convert.ToDateTime(dtsNum.Tables["DA"].Rows[0]["FA"]);

            long lngMinimo = Convert.ToInt32(dtsNum.Tables["RNG"].Rows[0]["D"]);
            long lngMaximo = Convert.ToInt32(dtsNum.Tables["RNG"].Rows[0]["H"]);

            StringBuilder strError = new StringBuilder();

            //if (strRutEmiros.Replace(".", "").Replace("-", "") != dtgPrincipal.FilaActual["Rut"].ToString().Replace(".", "").Replace("-", ""))
            //  strError.AppendLine("Rut del archivo no pertenece al rut del emisor seleccionado.");
            if (intTipoDoc != (int)TomarId(dtgPrincipal))
              strError.AppendLine("Tipo documento del archivo no pertenece al tipo documento seleccionado.");

            if (strError.Length > 0) {
              strError.Insert(0, "Existen errores al importar los números de SII. \n");
              MessageBox.Show(strError.ToString(), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
              return;
            }

            string strByteError = "";
            byte[] bytArchivo = ITD.Funciones.FuncGen.FileToByte(oflNum.FileName, ref strByteError);

            if (!string.IsNullOrEmpty(strByteError)) {
              MessageBox.Show(strByteError, Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
              return;
            }

            string strErrorSubir = Global.SubirCAF(bytArchivo, Global.DatosApp.InfoUsr.RUTEmpresa, (int)TomarId(dtgPrincipal));

            if (!string.IsNullOrWhiteSpace(strErrorSubir)) {
              MessageBox.Show(strErrorSubir, Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
              return;
            }

            if (Global.DatosApp.Ejecutar("CorrelativoCAFIns", new object[] { 0, TomarId(dtgPrincipal), lngMinimo, lngMaximo, dttFecha, bytArchivo })) {
              RefrescarTodo();
            } else {
              MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          } catch (Exception ex) {

            ITD.Log.ManejadorLog.Log.Error("Error al importar los números. ", ex);
            MessageBox.Show("El archivo seleccionado no cumple con el formato indicado por el SII.", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
          }

        }
      }

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

    private void dtgPrincipal_DespuesCambioFila(object sender, FilaGrillaEventArg e) {
      spcPrincipal.Panel2Collapsed = e.FilaDatos == null || !(bool)e.FilaDatos["Electronico"];
      int intIdCorrelativo = 0;

      if (e.FilaDatos != null)
        intIdCorrelativo = (int)TomarId(dtgPrincipal);

      dtgCAF.Vista.RowFilter = string.Format("IdCorrelativo={0}", intIdCorrelativo);

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