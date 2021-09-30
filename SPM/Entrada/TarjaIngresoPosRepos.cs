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

  public partial class TarjaIngresoPosRepos : FrmBase {

    #region Declaraciones

    #region Por Defecto

    private static readonly ACCESO_OPCION Acceso = ACCESO_OPCION.PosTarjaIng;

    public static bool TieneAcceso {
      get { return Global.DatosApp.TieneAcceso(Acceso) != TIPO_ACCESO.Sin_Acceso; }
    }

    public int IdPlanta { get; set; }

    public object[] Parametros { set { IdPlanta = value[0].XEntero(); } }
    
    #endregion

    #endregion

    #region Inicial

    public TarjaIngresoPosRepos() {
      InitializeComponent();
    }

    public void InicializarParametros() {
      ValidarAcceso();
      btnAceptar.Enabled = PuedeActualizar;
    }

    public void ValidarAcceso() {
      PuedeActualizar = Global.DatosApp.TieneAcceso(Acceso) == TIPO_ACCESO.Editar;
    }

    private void FormularioPopUp_Load(object sender, EventArgs e) {
      LlenarDdls();
      InicializarParametros();
      RefrescarTodo();
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

      if (stbError.Length > 0) {
        stbError.Insert(0, "Campos con errores o vacíos:\n");
        MessageBox.Show(stbError.ToString(), APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;
    }

    private void LlenarDdls() {

      ddlBodega.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Bodega, string.Format("Id > 0 And Id_Planta={0}" ,IdPlanta), ddlBodega.DisplayMember);
    }

    #endregion

    #region Acciones

    #endregion

    #region Eventos de Barra

    #endregion

    #region Eventos de Controles

    private void btnAceptar_Click(object sender, EventArgs e) {

      this.DialogResult = System.Windows.Forms.DialogResult.OK;
      Close();
    }

    private void Control_Enter(object sender, EventArgs e) {
      sender.XSeleccionarTextoEnControl();
    }

    private void ddlBodega_SelectedIndexChanged(object sender, EventArgs e) {
      int intId = ddlBodega.SelectedValue.XEntero();
      
      ddlRack.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Rack, string.Format("Id_Bodega={0}", intId), ddlRack.DisplayMember);

    }
    private void ddlRack_SelectedIndexChanged(object sender, EventArgs e) {
      int intId = ddlRack.SelectedValue.XEntero();

      ddlPosicion.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Posiciones, string.Format("IdRack={0}", intId), ddlPosicion.DisplayMember);
    }
    private void ddlPosicion_SelectedIndexChanged(object sender, EventArgs e) {
  
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