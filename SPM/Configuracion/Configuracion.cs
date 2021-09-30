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
using System.Drawing;

namespace APP {

  public partial class Configuracion : FrmBase {

    #region Declaraciones

    #region Por Defecto
    
    public static bool TieneAcceso {
      get { return Global.DatosApp.InfoUsr.Administrador; }
    }

    #endregion

    #endregion

    #region Inicial

    public Configuracion() {
      InitializeComponent();
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
      LlenarControles();
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

      if (bolOK) {
        Global.DatosApp.TiempoDashboard = (int)nudTiempoDashboard.Value;
        Global.DatosApp.DiasLlegadaProducto = (int)nudDiasLlegadaProducto.Value;
        Global.DatosApp.DiasOSAEmpezar = (int)nudDiasOSAEmpezar.Value;
        Global.DatosApp.PorcTerminoOC = (int)nudDiasOSATerminar.Value;
        Global.DatosApp.DiasOSSinCerrar = (int)nudDiasOSSinCerrar.Value;
        Global.DatosApp.MinPickingProceso = (int)nudMinPickingProceso.Value;
        Global.DatosApp.ColorSoloLectura =   btnColorSoloLectura.BackColor;


      }

      return resultado;
    }

    private bool Modificar() {
      return null != this.XEjecutarProcedimiento(null, "ConfiguracionUpd", nudTiempoDashboard.Value, nudDiasLlegadaProducto.Value, nudDiasOSAEmpezar.Value, nudDiasOSATerminar.Value, nudDiasOSSinCerrar.Value, nudMinPickingProceso.Value, btnColorSoloLectura.BackColor.ToArgb(), nudValorCaja.Value);
    }

    #endregion

    #region Interfaz

    private void LlenarControles() {
      Cursor = Cursors.WaitCursor;
      var dttTabla = Global.DatosApp.TraerTabla("ConfiguracionSel_Id");
      Cursor = Cursors.Default;

      if (dttTabla != null) {

        if (dttTabla.Rows.Count == 0) {
          MessageBox.Show("El registro no existe.", Global.STR_INFORMACION, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        DataRow dtr = dttTabla.Rows[0];

        nudTiempoDashboard.Value = (int)dtr["TiempoDashboard"];
        nudDiasLlegadaProducto.Value = (int)dtr["DiasLlegadaProducto"];
        nudDiasOSAEmpezar.Value = (int)dtr["DiasOSAEmpezar"];
        nudDiasOSATerminar.Value = (decimal)dtr["PorcTerminoOC"];
        nudDiasOSSinCerrar.Value = (int)dtr["DiasOSSinCerrar"];
        nudMinPickingProceso.Value = (int)dtr["MinPickingProceso"];
        btnColorSoloLectura.BackColor = Color.FromArgb((int)dtr["ColorSoloLectura"]);
        
        CadenaValoresInicial = CrearCadenaValores();
        ValidaCambios = btnAceptar.Enabled;
      }
      else {
        MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private bool Validar() {
      StringBuilder stbError = new StringBuilder();

      if (stbError.Length > 0) {
        stbError.Insert(0, "Campos con errores o vacíos:\n");
        MessageBox.Show(stbError.ToString(), APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;
    }

    #endregion

    #region Acciones

    #endregion

    #region Eventos de Barra

    #endregion

    #region Eventos de Controles

    private void btnAceptar_Click(object sender, EventArgs e) {
      if(GuardarTodo() == GUARDAR_RESULT.GuardadoOk)
        this.DialogResult = System.Windows.Forms.DialogResult.OK;
    }

    private void Control_Enter(object sender, EventArgs e) {
      sender.XSeleccionarTextoEnControl();
    }

    private void btnColorSoloLectura_Click(object sender, EventArgs e) {
      ColorDialog objFrm = new ColorDialog();
      if (objFrm.ShowDialog() == DialogResult.OK)
        btnColorSoloLectura.BackColor = objFrm.Color;
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