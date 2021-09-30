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

  public partial class PickingMotivo : FrmBase {

    #region Declaraciones

    #region Por Defecto

    private static readonly ACCESO_OPCION Acceso = ACCESO_OPCION.Picking;



    public static bool TieneAcceso {
      get { return Global.DatosApp.TieneAcceso(Acceso) != TIPO_ACCESO.Sin_Acceso; }
    }

    public ESTADO_PICKING EstadoActual { get; set; }

    #endregion

    #endregion

    #region Inicial

    public PickingMotivo(ESTADO_PICKING objEstadoActual) {
      InitializeComponent();
      EstadoActual = objEstadoActual;
      LlenarDdls();
    }

    public void InicializarParametros() {
      ValidarAcceso();
      btnAceptar.Enabled = PuedeActualizar;
    }

    public void ValidarAcceso() {
      PuedeActualizar = true;
    }

    private void FormularioPopUp_Load(object sender, EventArgs e) {
      InicializarParametros();
      ddlMotivo.SelectedIndex = -1;
      ddlResponsable.SelectedIndex = -1;
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
      return null != this.XEjecutarProcedimiento(null, "", null);
    }

    #endregion

    #region Interfaz
    
    private bool Validar() {
      StringBuilder stbError = new StringBuilder();


      if (ddlMotivo.SelectedValue == null)
        stbError.AppendLine("Motivo es requerido.");
      
      if (string.IsNullOrWhiteSpace(txtObs.Text))
        stbError.AppendLine("Observación es requerido.");

      if(((DataView)ddlResponsable.DataSource).Count > 0 && ddlResponsable.SelectedValue == null)
        stbError.AppendLine("Responsable es requerido.");


      if (stbError.Length > 0) {
        stbError.Insert(0, "Campos con errores o vacíos:\n");
        MessageBox.Show(stbError.ToString(), APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;
    }

    private void LlenarDdls() {

      ddlMotivo.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.PickingMotivo, string.Format("IdEstado = {0}", (int)EstadoActual), ddlMotivo.DisplayMember);
      ddlResponsable.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.PickingMotivoResp, string.Format("IdEstado = {0}", (int)EstadoActual), "");

    }

    #endregion

    #region Acciones

    #endregion

    #region Eventos de Barra

    #endregion

    #region Eventos de Controles

    private void btnAceptar_Click(object sender, EventArgs e) {
      if (Validar()) {
        this.DialogResult = System.Windows.Forms.DialogResult.OK;
        Close();
      }
    }

    private void Control_Enter(object sender, EventArgs e) {
      sender.XSeleccionarTextoEnControl();
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