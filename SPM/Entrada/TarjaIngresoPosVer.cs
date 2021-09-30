using APP_GEN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ITD.Win;
using ITD.Win.Formas;
using Global = APP_GEN.Global;

namespace APP {

  public partial class TarjaIngresoPosVer : FrmBaseGrid {

    #region Declaraciones

    #region Por Defecto

    private static readonly ACCESO_OPCION Acceso = ACCESO_OPCION.Defecto;
    
    private enum REPORTES {
      Listado,
      Detalle
    }

    public int Id { get; set; }
    public int IdPlanta { get; set; }

    public object[] Parametros { set {Id = value[0].XEntero(); IdPlanta = value[1].XEntero(); } }

    public static bool TieneAcceso {
      get { return Global.DatosApp.TieneAcceso(Acceso) != TIPO_ACCESO.Sin_Acceso; }
    }

    #endregion

    #endregion

    #region Inicial

    public TarjaIngresoPosVer() {
      InitializeComponent();
      LlenarDdls();
      InicializarFiltros(true);
    }
    
    private void Consulta_Load(object sender, EventArgs e) {
      InicializarParametros();
      RefrescarTodo();
    }

    private void InicializarParametros() {
      ValidarAcceso();
    }

    private void ValidarAcceso() {
      PuedeActualizar = Global.DatosApp.TieneAcceso(Acceso) == TIPO_ACCESO.Editar;
    }

    #endregion

    #region Actualizacion

    private bool Quitar(int intIdTarja, int intIdPosicionNueva) {
      return null != this.XEjecutarProcedimiento(null, "TarjaIngresoPosUbicaReubicar", intIdTarja, intIdPosicionNueva);
    }

    #endregion

    #region Interfaz
    
    public override void RefrescarTodo() {
      Cursor = Cursors.WaitCursor;
      var dtTabla = Global.DatosApp.TraerTabla("TarjaIngresoPosSel_Posicionado", new object[] { Id });
      Cursor = Cursors.Default;
      if (dtTabla != null) {
        RefrescarGrilla(dtgPrincipal, dtTabla.DefaultView);
      } else {
        MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void LlenarDdls() {
    }

    #endregion

    #region Acciones
    
    #endregion

    #region Eventos de barra
    
    #endregion

    #region Eventos de controles

    private void Control_Enter(object sender, EventArgs e) {
      sender.XSeleccionarTextoEnControl();
    }

    #endregion

    #region Eventos de grilla

    private void dtgPrincipal_CambiaOperacionRapida(object sender, CambiaOperacionRapidaEvengArg e) {
      sbpMensaje.Text = e.ValorFormateado;
    }

    private void dtgPrincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex > -1) {
      }
    }

    #endregion

    #region Persistencia

    private enum Llaves {
      Grilla = 100,
      Panel = 1
    }

    protected override void CargarForma() {
      base.CargarForma();
      bool bolValor;

      CargarGrilla(dtgPrincipal, (int)Llaves.Grilla);
      
    }

    protected override void SalvarForma() {
      base.SalvarForma();
      SalvarGrilla(dtgPrincipal, (int)Llaves.Grilla);
    }

    #endregion

    private void dtgPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex == -1) return;

      //if (e.ColumnIndex == ColQuitar.Index) {
      //  if (Quitar())
      //    RefrescarTodo();

      //}
    }

    private void tsmReposicionar_Click(object sender, EventArgs e) {
      var forma = Global.LlamarFormulario<TarjaIngresoPosRepos>(true, IdPlanta);

      if (forma.DialogResult == DialogResult.OK) {
        foreach (DataRow item in dtgPrincipal.FilasSeleccionadas()) {
          Quitar(item.XEntero("Id"), forma.ddlPosicion.SelectedValue.XEntero());
        }

        RefrescarTodo();
      }
    }
  }
}