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

  public partial class InventarioTarja : FrmBase {

    #region Declaraciones

    #region Por Defecto

    private static readonly ACCESO_OPCION Acceso = ACCESO_OPCION.Inventario;

    public static bool TieneAcceso {
      get { return Global.DatosApp.TieneAcceso(Acceso) != TIPO_ACCESO.Sin_Acceso; }
    }

    public int IdInventario { get; set; }
    string strCliente;
    int intIdCliente;
    int intIdPlanta;
    public object[] Parametros { set {IdInventario = value[0].XEntero() ; intIdCliente = value[1].XEntero(); strCliente = value[2].ToString(); intIdPlanta = value[3].XEntero(); } }
    public DataTable Resultado { get; set; }

    #endregion

    #endregion

    #region Inicial

    public InventarioTarja() {
      InitializeComponent();
      LlenarDdls();
    }

    public void InicializarParametros() {
      ValidarAcceso();
      btnAceptar.Enabled = PuedeActualizar;
      ddlPlanta.SelectedValue = intIdPlanta;
      txtnombre_clie.Text = strCliente;
      txtnombre_clie.Tag = intIdCliente;
    }

    public void ValidarAcceso() {
      PuedeActualizar = Global.DatosApp.TieneAcceso(Acceso) == TIPO_ACCESO.Editar;
    }

    private void FormularioPopUp_Load(object sender, EventArgs e) {
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

      Resultado = Global.DatosApp.TraerTabla("InventarioAgregarTarja", new object[] {
        IdInventario,
        ddlPlanta.SelectedValue,
        txtnombre_clie.Tag,
        ddlIdTipo.SelectedValue,
        txtCodigo.Text,
        txtDescripcion.Text,
        txtOC.XTextoONulo(),
        txtLote.XTextoONulo(),
        dtpVence.XTomarValorConCheck(),
        nudCantidad.Value,
        Global.DatosApp.InfoUsr.IdUsuario
      });

      if(Resultado == null)
        MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);

      return Resultado != null;
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
      
      if (ddlPlanta.SelectedValue == null)
        stbError.AppendLine("Planta es requerido.");

      if (txtnombre_clie.Tag.XEntero() == 0)
        stbError.AppendLine("Cliente es requerido.");


      if (ddlIdTipo.SelectedValue == null)
        stbError.AppendLine("Tipo es requerido.");

      if (string.IsNullOrWhiteSpace(txtCodigo.Text))
        stbError.AppendLine("Código es requerido.");


      if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
        stbError.AppendLine("Descripción es requerido.");

      if (nudCantidad.Value == 0)
        stbError.AppendLine("Cantidad es requerido.");


      if (stbError.Length > 0) {
        stbError.Insert(0, "Campos con errores o vacíos:\n");
        MessageBox.Show(stbError.ToString(), APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;
    }

    private void LlenarDdls() {

      ddlPlanta.DataSource = Global.DatosApp.InfoUsr.Plantas.DefaultView;
      ddlIdTipo.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Tipo, "Id > 0", ddlIdTipo.DisplayMember);

    }

    #endregion

    #region Acciones

    private void LlamaBuscadorCliente(string strCodigo, string strNombre) {
      var dttTabla = Global.BuscarEntidad(strCodigo, strNombre, true, true);
      if (dttTabla != null) {
        if (dttTabla.Rows.Count > 0) {
          var dtrFila = dttTabla.Rows[0];
          txtnombre_clie.Text = dtrFila["nombre_clie"].ToString();
          txtnombre_clie.Tag = dtrFila["Id"];

        }
      } else {
        txtnombre_clie.Tag = null;
      }
    }

    private void LlamaBuscadorIsnumo(string strCodigo, string strDescripcion) {
      var dttTabla = Global.BuscarInsumo(intIdCliente, strCodigo, strDescripcion, true, true, txtnombre_clie.Tag.XEntero() == Global.IdMovipack);
      if (dttTabla != null) {
        if (dttTabla.Rows.Count > 0) {

          DataRow dtr = dttTabla.Rows[0];
          
          ddlIdTipo.SelectedValue = dtr["IdTipo"];
          txtDescripcion.Text = dtr["Descripcion"].ToString();
          txtCodigo.Text = dtr["Codigo"].ToString();
          txtCodigo.Tag = 1;
        }
      }
    }

    #endregion

    #region Eventos de Barra

    #endregion

    #region Eventos de Controles

    private void btnAceptar_Click(object sender, EventArgs e) {
      if (GuardarTodo() == GUARDAR_RESULT.GuardadoOk) {
        DialogResult = DialogResult.OK;
        Close();
      }
    }

    private void Control_Enter(object sender, EventArgs e) {
      sender.XSeleccionarTextoEnControl();
    }

    private void txtrut_Prove_TextChanged(object sender, EventArgs e) {
      txtnombre_clie.Tag = null;
    }

    private void txtnombre_Prove_Validated(object sender, EventArgs e) {
      if (txtnombre_clie.Tag == null && !string.IsNullOrWhiteSpace(txtnombre_clie.Text))
        LlamaBuscadorCliente("", txtnombre_clie.Text);
    }

    private void txtCodigo_TextChanged(object sender, EventArgs e) {
      txtCodigo.Tag = null;
    }

    private void txtCodigo_Validated(object sender, EventArgs e) {
      if (!string.IsNullOrWhiteSpace(txtCodigo.Text) && txtCodigo.Tag == null) {
        LlamaBuscadorIsnumo(txtCodigo.Text, "");
      }
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