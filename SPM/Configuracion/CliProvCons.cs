using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ITD.Win;
using ITD.Funciones;
using System.IO;
using APP_GEN;
using Global = APP_GEN.Global;

namespace APP {
  public partial class CliProvCons :ITD.Win.Formas.FrmBaseGrid {

    #region Declaraciones

    #region Por Defecto

    private static readonly ACCESO_OPCION Acceso = ACCESO_OPCION.Cliente;

    private DataSet dtsDatos;

    private Type[] formulariosRefrescar = new Type[] {
      typeof(CesionCons)
    };

    enum REPORTES : byte {
      Listado = 0,
      Ficha = 1
    }

    private enum TABLAS {
      Principal = 0,
      Detalle = 1
    }

    public static bool TieneAcceso {
      get { return Global.DatosApp.TieneAcceso(Acceso) != TIPO_ACCESO.Sin_Acceso; }
    }

    public int Id { get; set; }

    public List<DataRow> ListaFacturas { get; set; }

    public object[] Parametros { set { Id = (int)value[0]; ListaFacturas = value.Length > 1 ? (List<DataRow>)value[1] : null; } }

    #endregion

    enum FILTROS :int {
      Rut = 0
    }

    #endregion

    #region Inicial

    public CliProvCons() {
      InitializeComponent();
      LlenarDdls();
      IniciarPaginado(1, 50);
      InicializarFiltros(true);

    }

    private void ClientesCons_Load(object sender, EventArgs e) {
      Cursor = Cursors.WaitCursor;
      InicializaParametros();
      Filtrar();
      Cursor = Cursors.Default;
    }

    public void ValidarAcceso() {
      PuedeActualizar = APP_GEN.Global.DatosApp.TieneAcceso(ACCESO_OPCION.Cliente) == TIPO_ACCESO.Editar;
    }

    public void InicializaParametros() {
      ValidarAcceso();
      ddlReporte.SelectedIndex = 0;
      tsbNuevo.Enabled = PuedeActualizar;
      if(pnlFiltro.Visible) {
        tsbMostrarFiltros.Image = APP.Properties.Resources.NoVer;
        tsbMostrarFiltros.ToolTipText = "Ocultar filtros";
      } else {
        tsbMostrarFiltros.Image = APP.Properties.Resources.Ver;
        tsbMostrarFiltros.ToolTipText = "Ver filtros";
      }
    }

    public override void InicializarFiltros(bool guardaPersistencia = true) {
      base.InicializarFiltros(guardaPersistencia);

      Filtro.Agregar(new FiltroTextBox(txtRutF, chkRutF, ddlRutF, "Entidad.Codigo", "RUT", TIPO_DATO.Texto, TIPO_OPERADOR.Igual ));
      Filtro.Agregar(new FiltroTextBox(txtNombreF, chkNombreF, ddlNombreF, "Entidad.NombreCompleto", "Nombre", TIPO_DATO.Texto));
      Filtro.Agregar(new FiltroTextBox(txtEmailF, chkEmailF, ddlEmailF, "Entidad.EmailFacturacion", "Email facturación", TIPO_DATO.Texto));
      Filtro.Agregar(new FiltroTextBox(txtTelefonoF, chkTelefonoF, ddlTelefonoF, "Entidad.Telefono", "Teléfono", TIPO_DATO.Texto));
      Filtro.Agregar(new FiltroTextBox(txtContactoF, chkContactoF, ddlContactoF, "EntidadContacto.Nombre", "Contacto", TIPO_DATO.Texto, false, "Exists(Select 1 From EntidadContacto Where IdEntidad = Entidad.IdEntidad And &&)"));
      Filtro.Agregar(new FiltroTextBox(txtDireccionF, chkDireccionF, ddlDireccionF, "EntidadDireccion.Direccion", "Dirección", TIPO_DATO.Texto, false, "Exists(Select 1 From EntidadDireccion Where IdEntidad = Entidad.IdEntidad And &&)"));
      Filtro.Agregar(new FiltroDropDown(ddlRegionF, chkRegionF, TIPO_OPERADOR.Igual, "Comuna.IdRegion", "Region", TIPO_DATO.Entero, "Exists(Select 1 From vExComuna As Comuna Inner Join EntidadDireccion On Comuna.IdComuna = EntidadDireccion.IdComuna Where EntidadDireccion.IdEntidad =Entidad.IdEntidad And &&)"));
      Filtro.Agregar(new FiltroTextBox(txtCiudadF, chkCiudadF, ddlCiudadF, "EntidadDireccion.Ciudad", "Ciudad", TIPO_DATO.Texto ,false, "Exists(Select 1 From  EntidadDireccion Where EntidadDireccion.IdEntidad = Entidad.IdEntidad And &&)"));
      Filtro.Agregar(new FiltroDropDown(ddlComunaF, chkComunaF, TIPO_OPERADOR.Igual, "EntidadDireccion.IdComuna", "Comuna", TIPO_DATO.Entero, "Exists(Select 1 From  EntidadDireccion Where EntidadDireccion.IdEntidad = Entidad.IdEntidad And &&)"));

      var lstCliente = new List<KeyValuePair<object, RadioButton>>()
        { 
          new KeyValuePair<object,RadioButton>(1,rdbCSi),
          new KeyValuePair<object,RadioButton>(0,rdbCNo)
        };
      Filtro.Agregar(new FiltroRadioButton(lstCliente, chkClienteF, TIPO_OPERADOR.Igual, "Entidad.EsCliente", "Cliente", TIPO_DATO.Entero));

      var lstProveedor = new List<KeyValuePair<object, RadioButton>>()
        { 
          new KeyValuePair<object,RadioButton>(1,rdbPSi),
          new KeyValuePair<object,RadioButton>(0,rdbPNo)
        };
      Filtro.Agregar(new FiltroRadioButton(lstProveedor, chkProveedorF, TIPO_OPERADOR.Igual, "Entidad.EsProveedor", "Proveedor", TIPO_DATO.Entero));

      var lstActivo = new List<KeyValuePair<object, RadioButton>>()
        { 
          new KeyValuePair<object,RadioButton>(1,rdbSi),
          new KeyValuePair<object,RadioButton>(0,rdbNo)
        };
      Filtro.Agregar(new FiltroRadioButton(lstActivo, chkActivoF, TIPO_OPERADOR.Igual, "Entidad.Activo", "Activo", TIPO_DATO.Entero));

      Filtro.Agregar(new FiltroDatePicker(dtpDesdeF, chkDesdeF, ddlDesdeF, "Entidad.FechaCreado", "Desde", TIPO_DATO.Fecha, TIPO_OPERADOR.MayorIgual));
      Filtro.Agregar(new FiltroDatePicker(dtpHastaF, chkHastaF, ddlHastaF, "Entidad.FechaCreado", "Hasta", TIPO_DATO.Fecha, TIPO_OPERADOR.MenorIgual));
      Filtro.Agregar(new FiltroBase(chkCargSII, TIPO_OPERADOR.Ninguno, "Entidad.CargadoSII = 1", "Cargado SII"));
    }

    #endregion

    #region Actualizar

    public bool Activar() {
      object[] objParam = new object[]{
        TomarId(dtgPrincipal),
        !(bool)dtgPrincipal.FilaActual["Activo"],
        APP_GEN.Global.DatosApp.InfoUsr.IdUsuario
      };
      if(!APP_GEN.Global.DatosApp.Ejecutar("EntidadActivar", objParam)) {
        MessageBox.Show(ProcesarError(APP_GEN.Global.DatosApp.UltimoError), APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;
    }

    public bool Eliminar() {
      if(!APP_GEN.Global.DatosApp.Ejecutar("EntidadDel", new object[] { TomarId(dtgPrincipal) })) {
        MessageBox.Show(ProcesarError(APP_GEN.Global.DatosApp.UltimoError), APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;
    }

    #endregion

    #region Interfaz

    private void LlenarDdls() {
      //ddlRegionF.DataSource = APP_GEN.Global.Cache.TomarVista(ClaseCache.TABLA.Region, "IdRegion > 0", "Region");    
      //ddlComunaF.DataSource = APP_GEN.Global.Cache.TomarVista(ClaseCache.TABLA.Comuna, "IdComuna > 0", "Comuna");

    }

    public void Filtrar() {
      string strError = Filtro.ValidarFiltros();
      if(string.IsNullOrEmpty(strError)) {
        Filtro.FormarFiltro();
        sbpFiltro.Text = Filtro.FiltroDesc;
        CargarPaginaActual();
      } else
        MessageBox.Show(strError, APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public override void CargarPagina(int pagina, int pagTamano, int cantidad) {
      string strFiltro = Filtro.Filtro;
      if(!string.IsNullOrEmpty(Filtro[(int)FILTROS.Rut].Filtro)){
        strFiltro = strFiltro.Replace(string.Format("(Entidad.Codigo='{0}')", txtRutF.Text), string.Format("(Entidad.Codigo = '{0}' or Entidad.Codigo ='{1}')", APP_GEN.Global.FormatearRut(txtRutF.Text), txtRutF.Text));
      }
      object[] objParam = new object[]{
      pagina -1,
      pagTamano,
      0,
      TomarOrden(dtgPrincipal),
      strFiltro,
      null
    };

      Cursor = Cursors.WaitCursor;
      var dtTabla = APP_GEN.Global.DatosApp.TraerTabla("EntidadConsSel_Grids", objParam);
      if(dtTabla != null) {
        tsbModificar.Enabled = dtTabla.Rows.Count > 0;
        tsbEliminar.Enabled = PuedeActualizar && dtTabla.Rows.Count > 0;
        tsbReporte.Enabled = dtTabla.Rows.Count > 0;
        tsbActivar.Enabled = dtTabla.Rows.Count > 0;        
        RefrescarGrilla(dtgPrincipal, dtTabla.DefaultView);        
      } else {
        MessageBox.Show(APP_GEN.Global.DatosApp.UltimoError.Mensaje, APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      Cursor = Cursors.Default;
      base.CargarPagina(pagina, pagTamano, Convert.ToInt32(objParam[2]));
    }

    #endregion

    #region Acciones

    private void MostrarReporte() {
      Reporte objReporte = null;
      DataTable dttDatos;
      object[] objParam;

      switch((REPORTES)ddlReporte.SelectedIndex) {
      case REPORTES.Listado:
        objParam = new object[] {
        0,
        APP_GEN.Global.DatosApp.CantidadFilasReportes,
        0,
        TomarOrden(dtgPrincipal),
        Filtro.Filtro
      };
      Cursor = Cursors.WaitCursor;
      dttDatos = APP_GEN.Global.CargarDatosReporte("EntidadConsRpt_Lst", objParam);      
      objReporte = new Reporte("APP.Reportes.rptEntidadLst.rdlc");
      objReporte.Datos.Add(dttDatos);
      objReporte.Titulo = "Listado de clientes/proveedores";
      objReporte.Parametros.Add("Sistema", APP_GEN.Global.DatosApp.Sistema);
      objReporte.Parametros.Add("DescFiltro", Filtro.FiltroDesc);
      Cursor = Cursors.Default;

      break;

      case REPORTES.Ficha:
      objParam = new object[]{
                    TomarId(dtgPrincipal)
                  };
      Cursor = Cursors.WaitCursor;
      objReporte = new Reporte("APP.Reportes.rptEntidadFicha.rdlc");
      var dtsDatos = APP_GEN.Global.DatosApp.TraerDataset("EntidadFicha", objParam);
      objReporte.Datos.Add(dtsDatos.Tables[0]);
      objReporte.Datos.Add(dtsDatos.Tables[1]);
      objReporte.Datos.Add(dtsDatos.Tables[2]);
      objReporte.Parametros.Add("Sistema", APP_GEN.Global.DatosApp.Sistema);
      objReporte.Titulo = "Ficha del cliente/proveedor";
      Cursor = Cursors.Default;

      break;
      }
      if(objReporte != null)
        objReporte.MostrarReporte(APP_GEN.Global.FormaPrincipal);
    }

    #endregion

    #region Eventos de Barra

    private void tsbNuevo_Click(object sender, EventArgs e) {
      Global.LlamarFormulario<CliProvAct>(false, -1);
    }

    private void tsbModificar_Click(object sender, EventArgs e) {
      Global.LlamarFormulario<CliProvAct>(false, TomarId(dtgPrincipal));

    }

    private void tsbEliminar_Click(object sender, EventArgs e) {
      if(MessageBox.Show("Va a eliminar al cliente seleccionado ¿Confirma?", APP_GEN.Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
        if(Eliminar())
          Filtrar();
    }

    private void tsbFiltrar_Click(object sender, EventArgs e) {
      Filtrar();
    }

    private void tsbQuitarFiltro_Click(object sender, EventArgs e) {
      Filtro.LimpiarFiltros();
    }

    private void tsbMostrarFiltros_Click(object sender, EventArgs e) {
      pnlFiltro.Visible = !pnlFiltro.Visible;
      if(pnlFiltro.Visible) {
        tsbMostrarFiltros.Image = APP.Properties.Resources.NoVer;
        tsbMostrarFiltros.ToolTipText = "Ocultar filtros";
      } else {
        tsbMostrarFiltros.Image = APP.Properties.Resources.Ver;
        tsbMostrarFiltros.ToolTipText = "Ver filtros";
      }
    }

    private void tsbActivar_Click(object sender, EventArgs e) {     
      string strMensaje = String.Format("Va a {0} el registro seleccionado. ¿Confirma? ", tsbActivar.ToolTipText.ToLower());
      if(MessageBox.Show(strMensaje, APP_GEN.Global.STR_INFORMACION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
        if(Activar())
          Filtrar();
      }
    }

    private void tsbReporte_Click(object sender, EventArgs e) {
      MostrarReporte();
    }   
    
    #endregion

    #region Eventos de Controles    

    private void txtRutF_KeyPress(object sender, KeyPressEventArgs e) {
      if(Char.IsDigit(e.KeyChar))
        e.Handled = false;
      else if(Char.IsControl(e.KeyChar))
        e.Handled = false;
      else if(Char.IsSeparator(e.KeyChar))
        e.Handled = false;
      else if(e.KeyChar.Equals('K') || e.KeyChar.Equals('k') || e.KeyChar.Equals('-') || e.KeyChar.Equals('.'))
        e.Handled = false;
      else
        e.Handled = true;
    }

    #endregion

    #region Eventos de Grilla

    private void dtgPrincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
      if(e.RowIndex > -1) {
        tsbModificar_Click(null, null);
      }
    }

    private void dtgPrincipal_DespuesCambioFila(object sender, FilaGrillaEventArg e) {
      if(e.FilaDatos != null) {
        if((bool)e.FilaDatos["Activo"]) {
          tsbActivar.Image = APP.Properties.Resources.Activar_d;
          tsbActivar.ToolTipText = "Desactivar";
        } else {
          tsbActivar.Image = APP.Properties.Resources.Activar;
          tsbActivar.ToolTipText = "Activar";
        }
      }
    }

    private void dtgPrincipal_Sorted(object sender, EventArgs e) {
      CargarPaginaActual();
    }

    #endregion

    #region Persistencia

    public enum Llaves :int {
      Principal = 10,
      MostrarFiltro = 100
    }

    protected override void SalvarForma() {
      base.SalvarForma();
      SalvarGrilla(dtgPrincipal, (int)Llaves.Principal);
      GuardarLlave((int)Llaves.MostrarFiltro, pnlFiltro.Visible.ToString());

    }

    protected override void CargarForma() {
      base.CargarForma();
      bool bolValor;
      CargarGrilla(dtgPrincipal, (int)Llaves.Principal);
      if(bool.TryParse(TraerLlave((int)Llaves.MostrarFiltro), out bolValor))
        pnlFiltro.Visible = bolValor;
    }

    #endregion

    
  }
}
