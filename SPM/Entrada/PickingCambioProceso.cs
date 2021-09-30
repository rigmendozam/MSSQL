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

namespace APP {

  public partial class PickingCambioProceso : FrmBase {

    #region Declaraciones

    #region Por Defecto

    private static readonly ACCESO_OPCION Acceso = ACCESO_OPCION.Defecto;

    public static bool TieneAcceso {
      get { return Global.DatosApp.TieneAcceso(Acceso) != TIPO_ACCESO.Sin_Acceso; }
    }

    public int IdDetOT { get; set; }
    public int IdPicking { get; set; }

    public object[] Parametros { set { IdDetOT = value[0].XEntero() ; txtid_picking.Text = value[1].ToString(); IdPicking = value[2].XEntero(); } }

    #endregion

    #endregion

    #region Inicial

    public PickingCambioProceso() {
      InitializeComponent();
      LlenarDdls();
    }

    public void InicializarParametros() {
      ValidarAcceso();
      btnAceptar.Enabled = PuedeActualizar;
      dtpFecha.MinDate = DateTime.Now.Date;
    }

    public void ValidarAcceso() {
      PuedeActualizar = true;
    }

    private void FormularioPopUp_Load(object sender, EventArgs e) {
      InicializarParametros();
    }

    #endregion

    #region Actualizar

    public override GUARDAR_RESULT GuardarTodo() {
      GUARDAR_RESULT resultado = GUARDAR_RESULT.CanceladoGuardar;

      if (!Validar()) {
        return resultado;
      }

      bool bolOK = Modificar();
      Cursor = Cursors.WaitCursor;
      resultado = bolOK ? GUARDAR_RESULT.GuardadoOk : GUARDAR_RESULT.GuardadoError;
      Cursor = Cursors.Default;

      return resultado;
    }

    private bool Modificar() {
      return null != this.XEjecutarProcedimiento(null, "PickingCambioProceso", IdPicking, txtid_OT.Text, ddlLinea.SelectedValue, dtpFecha.Value);
    }

    #endregion

    #region Interfaz

    private void LlenarControles() {
      Cursor = Cursors.WaitCursor;
      var dttTabla = Global.DatosApp.TraerTabla("");
      Cursor = Cursors.Default;

      if (dttTabla != null) {

        if (dttTabla.Rows.Count == 0) {
          MessageBox.Show("El registro no existe.", Global.STR_INFORMACION, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        DataRow dtr = dttTabla.Rows[0];

        CadenaValoresInicial = CrearCadenaValores();
        ValidaCambios = btnAceptar.Enabled;
      } else {
        MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private bool Validar() {
      StringBuilder stbError = new StringBuilder();


      if (string.IsNullOrWhiteSpace(txtid_OT.Text))
        stbError.AppendLine("Proceso es requerido.");


      if (ddlLinea.SelectedValue == null)
        stbError.AppendLine("Línea es requerido.");

      if (stbError.Length > 0) {
        stbError.Insert(0, "Campos con errores o vacíos:\n");
        MessageBox.Show(stbError.ToString(), APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;
    }

    private void LlenarDdls() {
      
    }

    #endregion

    #region Acciones

    private void LlenarcontrolesOT() {
      Cursor = Cursors.WaitCursor;
      DataSet dtsDatos = Global.DatosApp.TraerDataset("PickingSel_OT", new object[] { txtid_OT.Text, IdDetOT });
      Cursor = Cursors.Default;

      if (dtsDatos != null) {
        dtpFecha.Enabled = true;
        ddlLinea.Enabled = true;

        dtpFecha.Value = DateTime.Now.Date;

        ddlLinea.DataSource = new DataView(dtsDatos.Tables[4], string.Format("Fecha=#{0}#", dtpFecha.Value.ToString("yyyy/MM/dd")), "", DataViewRowState.OriginalRows);
      } else {
        MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    #endregion

    #region Eventos de Barra

    #endregion

    #region Eventos de Controles

    private void btnAceptar_Click(object sender, EventArgs e) {
      if (GuardarTodo() == GUARDAR_RESULT.GuardadoOk)
        Close();
    }

    private void Control_Enter(object sender, EventArgs e) {
      sender.XSeleccionarTextoEnControl();
    }

    private void txtid_OT_Validated(object sender, EventArgs e) {
      if (!string.IsNullOrWhiteSpace(txtid_OT.Text) && txtid_OT.Tag == null && !Inicializando)
        LlenarcontrolesOT();
    }

    private void txtid_OT_TextChanged(object sender, EventArgs e) {
      txtid_OT.Tag = null;
    }

    private void dtpFecha_ValueChanged(object sender, EventArgs e) {
      if (ddlLinea.DataSource == null) return;

      ((DataView)ddlLinea.DataSource).RowFilter = string.Format("Fecha=#{0}#", dtpFecha.Value.ToString("yyyy/MM/dd"));
    }

    #endregion

    #region Eventos de Grilla

    #endregion

    #region Persistencia

    public enum Llaves {
      Grilla = 10
    }

    protected override void CargarForma() {
      base.CargarForma();
    }

    protected override void SalvarForma() {
      base.SalvarForma();
    }

    #endregion

  }
}