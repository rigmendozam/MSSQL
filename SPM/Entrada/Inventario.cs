using APP_GEN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ITD.Win;
using ITD.Win.Formas;
using Global = APP_GEN.Global;
using ITD.Funciones;

namespace APP {

  public partial class Inventario : FrmBaseGrid {

    #region Declaraciones

    #region Por Defecto

    private static readonly ACCESO_OPCION Acceso = ACCESO_OPCION.Inventario;
    private static readonly ACCESO_OPCION AccesoAprobar = ACCESO_OPCION.InventarioAprobar;

    private DataSet dtsDatos;

    private Type[] formulariosRefrescar = new Type[] {

    };

    private enum REPORTES {
      Detalle
    }

    private enum TABLAS {
      Principal = 0,
      Detalle = 1
    }
    bool bolPuedeAprobar = false;
    public static bool TieneAcceso {
      get { return Global.DatosApp.TieneAcceso(Acceso) != TIPO_ACCESO.Sin_Acceso; }
    }

    public int Id { get; set; }

    public object[] Parametros { set {Id = (int)value[0] ; } }

    #endregion

    ESTADO_INVENTARIO objEstado;
    bool bolDesdeCodigo = false;
    #endregion

    #region Inicial

    public Inventario() {
      InitializeComponent();
      LlenarDdls();
    }

    private void ActualizacionGrilla_Load(object sender, EventArgs e) {
      InicializarParametros();
      RefrescarTodo();
    }

    private void InicializarParametros() {
      ValidarCambios(pnlPrincipal);

      if (ddlReporte.Items.Count > 0) {
        ddlReporte.SelectedIndex = (int)REPORTES.Detalle;
        ddlReporte.Visible = ddlReporte.Items.Count > 1;
      }
      else
        tsbReporte.Visible = ddlReporte.Visible = false;

    }

    private void ValidarAcceso(bool bolAccesoPlanta) {
      PuedeActualizar = Global.DatosApp.TieneAcceso(Acceso) == TIPO_ACCESO.Editar && bolAccesoPlanta;
      bolPuedeAprobar = Global.DatosApp.TieneAcceso(AccesoAprobar) == TIPO_ACCESO.Editar;
    }

    #endregion

    #region Actualizacion

    public override GUARDAR_RESULT GuardarTodo() {
      GUARDAR_RESULT resultado = GUARDAR_RESULT.CanceladoGuardar;
      if (!dtgPrincipal.FinalizaEdicion()) {
        return resultado;
      }

      if (!Validar()) {
        return resultado;
      }

      if (dtgPrincipal.HayErrores) {
        MessageBox.Show("No se pueden guardar los cambios porque existen filas con errores.", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return resultado;
      }

      bool bolOK = EstadoForma == ESTADO_FORMA.Agregando ? Insertar() : Modificar() ;
      Cursor = Cursors.WaitCursor;

      if (bolOK) {
        EstadoForma = ESTADO_FORMA.Modificando;
        resultado = GUARDAR_RESULT.GuardadoOk;

        var listaCambios = TomarFilasModificadas(dtgPrincipal);
        var listaResultados = Global.DatosApp.ActualizarMasivo("InventarioDet", listaCambios, false);
        SincronizarCambios(dtgPrincipal, listaResultados);

        if (dtgPrincipal.HayErrores) {
          MessageBox.Show("No se guardaron todos los cambios porque existen filas con errores.", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
          resultado = GUARDAR_RESULT.GuardadoError;
        }
      }
      else {
        resultado = GUARDAR_RESULT.GuardadoError;
      }
      Cursor = Cursors.Default;

      if (resultado == GUARDAR_RESULT.GuardadoOk)
        MessageBox.Show("Datos guardados con éxito.", Global.STR_INFORMACION, MessageBoxButtons.OK, MessageBoxIcon.Information);

      return resultado;
    }

    protected override object[] TomarParametrosAInsertar(DataGridView dtgGrilla, DataRow dtrFila) {
      return dtrFila.ItemArray.Take(dtrFila.ItemArray.Length - 1).ToArray();
    }

    protected override object[] TomarParametrosAModificar(DataGridView dtgGrilla, DataRow dtrFila) {
      return dtrFila.ItemArray.Take(dtrFila.ItemArray.Length - 1).ToArray();
    }

    private bool Eliminar() {
      return null != this.XEjecutarProcedimiento(formulariosRefrescar, "InventarioDel", Id);
    }

    private bool Insertar() {
      object[] objParam = new object[] {
        0,
        txtNombre.Text,
        dtpFecha.Value,
        ddlPlanta.SelectedValue,
        txtIdCliente.Tag,
        null,
        null,
        ddlIdRack.SelectedValue,
        string.IsNullOrWhiteSpace(txtObservacion.Text) ? null : txtObservacion.Text,
        Global.DatosApp.InfoUsr.IdUsuario,
        ddlTipo.SelectedValue,
        txtCodDesc.XTextoONulo(),
        txtResponsable.Tag,
        txtMonitora.Tag
      };

      objParam = this.XEjecutarProcedimiento(formulariosRefrescar, "InventarioIns", objParam);

      if (objParam != null)
        Id = (int)objParam[0];

      return objParam != null;
    }

    private bool Modificar() {
      object[] objParam = new object[] {
        Id,
        txtNombre.Text,
        dtpFecha.Value,
        txtIdCliente.Tag,
        null,
        null,
        ddlIdRack.SelectedValue,
        string.IsNullOrWhiteSpace(txtObservacion.Text) ? null : txtObservacion.Text,
        Global.DatosApp.InfoUsr.IdUsuario,
        ddlTipo.SelectedValue,
        txtCodDesc.XTextoONulo(),
        txtResponsable.Tag,
        txtMonitora.Tag
      };

      return null != this.XEjecutarProcedimiento(formulariosRefrescar, "InventarioUpd", objParam);
    }

    private bool CambiarEstado(ESTADO_INVENTARIO objNuevoEstado) {
      return null != this.XEjecutarProcedimiento(formulariosRefrescar, "InventarioCambiarEstado", Id, (int)objNuevoEstado, Global.DatosApp.InfoUsr.IdUsuario);
    }

    #endregion

    #region Interfaz

    public void LlamadoDesdePrincipal(params object[] parametros) {
      if (this.XGuardaCambios(dtgPrincipal)) {
        Id = (int)parametros[0];
        if (Id == 0)
          LimpiarControles();
        else
          RefrescarTodo();
      }
    }

    public override void RefrescarTodo() {
      LlenarControles();
    }

    private void LimpiarControles() {
      EstadoForma = ESTADO_FORMA.Agregando;

      if (!Inicializando) {
        dtgPrincipal.Vista.Table.Clear();
      }
      Id = 0;

      pnlPrincipal.XLimpiarControl();

      tsbIniciar.Visible = tsbFinalizar.Visible = tsbAprobar.Visible = tsbCancelar.Visible = tsbAuditar.Visible = false;

      dtgPrincipal.ReadOnly = true;

      ddlPlanta.DataSource = Global.DatosApp.InfoUsr.Plantas.DefaultView;
      ddlPlanta.Enabled = true;
      ddlPlanta.SelectedIndex = -1;
      ddlPlanta.Focus();
      ValidarAcceso(true);

      tsbEliminar.Enabled = false;
      tsbReporte.Enabled = false;
      tsbGuardar.Enabled = PuedeActualizar;
      tsbNuevo.Enabled = false;
      CadenaValoresInicial = CrearCadenaValores();
      ValidaCambios = tsbGuardar.Enabled;
    }

    private void LlenarControles() {
      Cursor = Cursors.WaitCursor;
      dtsDatos = Global.DatosApp.TraerDataset("InventarioSel_Id", new object[] { Id });
      Global.Cache.EliminarTabla(ClaseCache.TABLA.Posiciones);
      Cursor = Cursors.Default;
      if (dtsDatos != null) {
        RefrescarGrilla(dtgPrincipal, TomarTabla(TABLAS.Detalle).DefaultView);

        if (TomarTabla(TABLAS.Principal).Rows.Count == 0) {
          LimpiarControles();
          return;
        }

        DataRow dtr = TomarTabla(TABLAS.Principal).Rows[0];
        EstadoForma = ESTADO_FORMA.Modificando;

        ddlPlanta.DataSource = Global.DatosApp.TomarMisPlantas();
        ddlPlanta.Enabled = false;
        ddlPlanta.SelectedValue = dtr["IdPlanta"];


        colIdPosicionNueva.DisplayMember = "Nombre";
        colIdPosicionNueva.ValueMember = "Id";
        colIdPosicionNueva.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Posiciones, "id_planta="+ dtr["IdPlanta"].ToString(), "");


        ValidarAcceso(Global.DatosApp.InfoUsr.Plantas.XExisteEnTabla("Id", false, ddlPlanta.SelectedValue));

        Id = (int)dtr["Id"];
        txtNombre.Text = dtr["Nombre"].ToString();
        dtpFecha.Value = (DateTime)dtr["Fecha"];

        txtIdCliente.Text = dtr["nombre_clie"].ToString();
        txtIdCliente.Tag = dtr["IdCliente"];

        txtResponsable.Text = dtr["Responsable"].ToString();
        txtResponsable.Tag = dtr["IdResponsable"];

        txtMonitora.Text = dtr["Monitora"].ToString();
        txtMonitora.Tag = dtr["IdMonitora"];

        ddlTipo.SelectedValue = dtr["IdTipoProd"];
        
        ddlIdBodega.SelectedValue = dtr["id_bodega"];
        ddlIdRack.SelectedValue = dtr["IdRack"];
        objEstado = (ESTADO_INVENTARIO) (int)dtr["IdEstado"];
        txtObservacion.Text = dtr["Observacion"].ToString();
        txtCodDesc.Text = dtr["CodDesc"].ToString();

        dtgPrincipal.ReadOnly = !PuedeActualizar || objEstado != ESTADO_INVENTARIO.EnProceso;
        colIdPosicion.ReadOnly = colCodigo.ReadOnly = colDescripcion.ReadOnly = colCantidad.ReadOnly = true;

        dtgPrincipal_DataBindingComplete(dtgPrincipal, new DataGridViewBindingCompleteEventArgs(System.ComponentModel.ListChangedType.Reset));


        tsbEliminar.Enabled = PuedeActualizar && objEstado == ESTADO_INVENTARIO.Creado;
        tsbReporte.Enabled = true;
        tsbGuardar.Enabled = PuedeActualizar && objEstado != ESTADO_INVENTARIO.Finalizado;
        tsbNuevo.Enabled = PuedeActualizar;

        tsbCancelar.Visible = PuedeActualizar && (objEstado == ESTADO_INVENTARIO.EnProceso || objEstado == ESTADO_INVENTARIO.PorAprobar);

        tsbAuditar.Visible = PuedeActualizar && !dtr.XBooleano("Auditado") && objEstado.XEnInt(ESTADO_INVENTARIO.PorAprobar, ESTADO_INVENTARIO.Finalizado) && (Global.DatosApp.InfoUsr.Administrador || Global.DatosApp.InfoUsr.IdUsuario == txtMonitora.Tag.XEntero());
        tsbIniciar.Visible = PuedeActualizar && objEstado == ESTADO_INVENTARIO.Creado;
        tsbFinalizar.Visible = PuedeActualizar && objEstado == ESTADO_INVENTARIO.EnProceso;
        tsbAprobar.Visible = bolPuedeAprobar && PuedeActualizar && objEstado == ESTADO_INVENTARIO.PorAprobar;

        CadenaValoresInicial = CrearCadenaValores();
        ValidaCambios = tsbGuardar.Enabled;
      }
      else {
        MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void LlenarDdls() {

      colIdPosicion.DisplayMember = "Nombre";
      colIdPosicion.ValueMember = "Id";
      colIdPosicion.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Posiciones, "Id > 0 ", "");


      ddlTipo.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Tipo, "", ddlTipo.DisplayMember);

    }

    private bool Validar() {
      StringBuilder stbError = new StringBuilder();
      
      if (ddlPlanta.SelectedValue == null)
        stbError.AppendLine("Planta es requerido.");
      
      if (string.IsNullOrWhiteSpace(txtNombre.Text))
        stbError.AppendLine("Nombre es requerido.");
      
      if (!(txtIdCliente.Tag is int))
        stbError.AppendLine("Cliente es requerido.");

      if (!(txtResponsable.Tag is int))
        stbError.AppendLine("Responsable es requerido.");

      //if (!(txtMonitora.Tag is int))
      //  stbError.AppendLine("Monitora es requerido.");
      
      if (stbError.Length > 0) {
        stbError.Insert(0, "Campos con errores o vacíos:\n");
        MessageBox.Show(stbError.ToString(), APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;
    }

    private void ValidarFila(DataRow dtrFila) {
      StringBuilder stbError = new StringBuilder();

      //if (dtrFila.XBooleano("Automatico") && dtrFila.XEntero("CanitidadNueva") > dtrFila.XEntero("Cantidad"))
      //  stbError.AppendLine("La nueva cantidad no puede ser mayor que la cantidad actual de la tarja, para ello, debe agregar una nueva línea y se creará una nueva tarja.");

      if (stbError.Length > 0)
        stbError.Insert(0, "Campos con errores o vacíos:\n");
      dtrFila.RowError = stbError.ToString();
    }

    #endregion

    #region Acciones

    public override bool HayCambios() {
      return base.HayCambios() || dtgPrincipal.HayCambios;
    }

    private void MostrarReporte() {
      Reporte objReporte = null;
      object[] objParam;
      switch ((REPORTES)ddlReporte.SelectedIndex) {
        case REPORTES.Detalle:
          objParam = new object[] { Id };

          Cursor = Cursors.WaitCursor;
          var dtsDatos = APP_GEN.Global.DatosApp.TraerDataset("InventarioSel_Rpt", objParam);
          objReporte = new Reporte("Reportes.Reportes.InventarioDet.rdlc","Reportes");
          objReporte.Titulo = "Inventario detallado";

          foreach (DataTable dttReporte in dtsDatos.Tables) {
            objReporte.Datos.Add(dttReporte);
          }

          objReporte.Parametros.Add("Usuario", APP_GEN.Global.DatosApp.InfoUsr.Nombre);
          Cursor = Cursors.Default;
          break;
      }

      if (objReporte != null)
        objReporte.MostrarReporte(APP_GEN.Global.FormaPrincipal);
    }

    private DataTable TomarTabla(TABLAS objTabla) {
      return dtsDatos.Tables[(int)objTabla];
    }

    private void LlamaBuscadorUsuario(TextBox txt, USUARIO_TIPO? objUsuario) {

      var dttTabla = Global.BuscarUsuario("", txt.Text, objUsuario);
      if (dttTabla != null) {
        if (dttTabla.Rows.Count > 0) {

          DataRow dtrUsuario = dttTabla.Rows[0];
          txt.Text = dtrUsuario["nombre_empleado"].ToString();
          txt.Tag = dtrUsuario["Id"];

        }
      }
    }

    private void LlamaBuscadorCliente(string strCodigo, string strNombre) {
      var dttTabla = Global.BuscarEntidad(strCodigo, strNombre, true, true);
      if (dttTabla != null) {
        if (dttTabla.Rows.Count > 0) {
          var dtrFila = dttTabla.Rows[0];
          txtIdCliente.Text = dtrFila["nombre_clie"].ToString();
          txtIdCliente.Tag = dtrFila["Id"];
        }
      }
      else {
        txtIdCliente.Tag = null;
      }
    }

    private void LlamaBuscadorUsuario(DataRow dtrFilaActual, string strNombre) {

      var dttTabla = Global.BuscarUsuario("", strNombre);
      if (dttTabla != null) {
        if (dttTabla.Rows.Count > 0) {

          foreach (DataRow dtr in dttTabla.Rows) {
            DataRow dtrNueva = null;

            dtrNueva = dtrFilaActual;

            bolDesdeCodigo = true;
            dtrNueva["IdContador"] = dtr["Id"];
            dtrNueva["Contador"] = dtr["nombre_empleado"];
            bolDesdeCodigo = false;
          }
        }
      }
    }

    //private void LlenarCeldaPosicion(DataGridViewRow dgvr) {
    //  DataRow dtr = ((DataRowView)dgvr.DataBoundItem).Row;

    //  string strFiltroPosicion = "";
    //  DataGridViewComboBoxCell cell = dgvr.Cells[colIdPosicionNueva.Index] as DataGridViewComboBoxCell;
    //  if (dtgPrincipal.Vista != null) {

    //    List<DataRow> listaFilasNoMixtos = dtgPrincipal.Vista.Table.AsEnumerable().Where(s => !string.IsNullOrWhiteSpace(s["IdPosicionNueva"].ToString()) && !(bool)s["Mixto"] && (int)s["IdPosicionNueva"] != ((dtr["IdPosicionNueva"] as int?) ?? 0)).ToList();
    //    List<DataRow> listaFilasMixtos = dtgPrincipal.Vista.Table.AsEnumerable().Where(s => !string.IsNullOrWhiteSpace(s["IdPosicionNueva"].ToString()) && (bool)s["Mixto"] && (int)s["IdPosicionNueva"] != ((dtr["IdPosicionNueva"] as int?) ?? 0)).ToList();

    //    StringBuilder stbNoMixto = new StringBuilder();
    //    StringBuilder stbMixto = new StringBuilder();

    //    listaFilasNoMixtos.ForEach(s => stbNoMixto.AppendFormat("{0},", s["IdPosicionNueva"]));
    //    if (stbNoMixto.Length > 0) {
    //      stbNoMixto.Remove(stbNoMixto.Length - 1, 1);
    //    }

    //    listaFilasMixtos.ForEach(s => stbMixto.AppendFormat("{0},", s["IdPosicionNueva"]));
    //    if (stbMixto.Length > 0) {
    //      stbMixto.Remove(stbMixto.Length - 1, 1);
    //    }

    //    if ((bool)dtr["Mixto"]) {
    //      if (stbNoMixto.Length > 0)
    //        strFiltroPosicion = string.Format("Id not in( {0})", stbNoMixto.ToString());
    //    }
    //    else {
    //      if (stbNoMixto.Length > 0) {
    //        if (stbMixto.Length > 0)
    //          stbNoMixto.Append(",").Append(stbMixto.ToString());
    //      }
    //      else if (stbMixto.Length > 0)
    //        stbNoMixto.Append(stbMixto);

    //      if (stbNoMixto.Length > 0)
    //        strFiltroPosicion = string.Format("Id not in( {0})", stbNoMixto.ToString());
    //    }

    //    string strFiltroMedidas = "";

    //    strFiltroMedidas = string.Format("IdEstado = 1 And Activo = 1");

    //    strFiltroMedidas = strFiltroMedidas + "";

    //    if (strFiltroPosicion.Length > 0 && !string.IsNullOrWhiteSpace(strFiltroMedidas)) {
    //      strFiltroPosicion = string.Format("({0} And {1})", strFiltroPosicion, strFiltroMedidas);
    //    }
    //    else if (!string.IsNullOrWhiteSpace(strFiltroPosicion))
    //      strFiltroPosicion = string.Format(" And ({0})", strFiltroMedidas);
    //    else
    //      strFiltroPosicion = strFiltroMedidas;

    //    if (!dtr.IsNull("IdPosicionNueva"))
    //      strFiltroPosicion = string.Format(" (Id = {0} or {1})", dtr["IdPosicionNueva"], strFiltroPosicion);

    //  }

    //  if (string.IsNullOrWhiteSpace(strFiltroPosicion))
    //    strFiltroPosicion = "IdEstado = 1";

    //  cell.DisplayMember = "Nombre";
    //  cell.ValueMember = "Id";
    //  cell.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Posiciones, string.Format("(Id is null) or {0}", strFiltroPosicion), "");

    //}

    #endregion

    #region Eventos de barra

    private void tsbEliminar_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a eliminar el registro actual. ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (Eliminar()) {
          LimpiarControles();
        }
      }
    }

    private void tsbGuardar_Click(object sender, EventArgs e) {
      if (GuardarTodo() == GUARDAR_RESULT.GuardadoOk) {
        RefrescarTodo();
      }
    }

    private void tsbNuevo_Click(object sender, EventArgs e) {
      if (this.XGuardaCambios(dtgPrincipal)) {
        LimpiarControles();
      }
    }

    private void tsbRefrescar_Click(object sender, EventArgs e) {
      if (this.XGuardaCambios(dtgPrincipal)) {
        RefrescarTodo();
      }
    }

    private void tsbReporte_Click(object sender, EventArgs e) {
      MostrarReporte();
    }

    private void tsbIniciar_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a iniciar el proceso de inventario. Según el filtro aplicado, se agregarán las tarjas para validar su información. ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (CambiarEstado(ESTADO_INVENTARIO.EnProceso))
          RefrescarTodo();
      }
    }

    private void tsbFinalizar_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a terminar el proceso de inventario. ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (CambiarEstado(ESTADO_INVENTARIO.PorAprobar))
          RefrescarTodo();
      }
    }

    private void tsbAprobar_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a aprobar el inventario. Se crearán o actualizarán las tarjas según la información ingresada. ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (CambiarEstado(ESTADO_INVENTARIO.Finalizado))
          RefrescarTodo();
      }
    }

    private void tsbCancelar_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a cancelar el inventario. ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (CambiarEstado(ESTADO_INVENTARIO.Cancelar))
          RefrescarTodo();
      }
    }

    #endregion

    #region Eventos de controles

    private void Control_Enter(object sender, EventArgs e) {
      sender.XSeleccionarTextoEnControl();
    }

    private void ddlIdBodega_SelectedIndexChanged(object sender, EventArgs e) {
      int intIdBodega = 0;

      if (!ddlIdBodega.SelectedValue.XEsNuloOVacio())
        intIdBodega = ddlIdBodega.SelectedValue.XEntero();


      ddlIdRack.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Rack, string.Format("id_bodega={0}", intIdBodega), ddlIdRack.DisplayMember);

    }

    private void txtIdCliente_TextChanged(object sender, EventArgs e) {
      txtIdCliente.Tag = null;
    }

    private void txtIdCliente_Validated(object sender, EventArgs e) {
      if (txtIdCliente.Tag == null && !string.IsNullOrWhiteSpace(txtIdCliente.Text))
        LlamaBuscadorCliente("", txtIdCliente.Text);
    }
    
    private void ddlPlanta_SelectedIndexChanged(object sender, EventArgs e) {
      int intIdPlanta = ddlPlanta.SelectedValue.XEntero();

      ddlIdBodega.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Bodega, string.Format("Id is null or id_planta = {0}", intIdPlanta), ddlIdBodega.DisplayMember);

    }

    #endregion

    #region Eventos de grilla

    private void dtgPrincipal_AntesInsertar(object sender, FilaEventArg e) {
      InventarioTarja objFrm = Global.LlamarFormulario<InventarioTarja>(true, Id, txtIdCliente.Tag, txtIdCliente.Text, ddlPlanta.SelectedValue);

      e.Cancel = true;
      if (objFrm.Resultado == null || objFrm.Resultado.Rows.Count == 0) {
        return;
      }

      DataRow dtr = dtgPrincipal.Vista.Table.NewRow();

      for (int i = 0; i < dtr.ItemArray.Length; i++) {
        dtr[i] = objFrm.Resultado.Rows[0][i];
      }
      dtgPrincipal.Vista.Table.Rows.Add(dtr);


      dtr.AcceptChanges();
      dtr.SetModified();


      e.Fila["Automatico"] = false;
      e.Fila["Mixto"] = false;
      e.Fila["IdInventario"] = Id;

      ValidarFila(e.Fila);
    }

    private void dtgPrincipal_CambiaOperacionRapida(object sender, CambiaOperacionRapidaEvengArg e) {
      sbpMensaje.Text = e.ValorFormateado;
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

    private void dtgPrincipal_Enter(object sender, EventArgs e) {
      sbpFilas.Text = ((DataGridView)sender).RowCount.ToString();
    }

    private void dtgPrincipal_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
      if (!dtgPrincipal.RefrescandoGrilla && e.ListChangedType == System.ComponentModel.ListChangedType.Reset) {
        foreach (DataGridViewRow item in dtgPrincipal.Rows) {
          DataRow dtr = ((DataRowView)item.DataBoundItem).Row;

          //LlenarCeldaPosicion(item);
          bool bolAutomatico = (bool)dtr["Automatico"] && !dtr.IsNull("IdTarjaIngreso");
          item.Cells[colid_taring.Index].ReadOnly = item.Cells[colLote.Index].ReadOnly = item.Cells[colVence.Index].ReadOnly = bolAutomatico;

        }
      }
    }

    private void dtgPrincipal_CellEnter(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex == -1) return;

      if (e.ColumnIndex == colIdPosicionNueva.Index) {
        //LlenarCeldaPosicion(dtgPrincipal.CurrentRow);
      }
    }

    private void dtgPrincipal_DespuesCambioFila(object sender, FilaGrillaEventArg e) {
      if (e.FilaDatos != null) {
        if((bool)e.FilaDatos["Automatico"])
          dtgPrincipal.DesctivarOpcionMenu(Grilla.OPC_MENU.Eliminar);
        else
          dtgPrincipal.ActivarOpcionMenu(Grilla.OPC_MENU.Eliminar);
      }
    }

    private void dtgPrincipal_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex == -1) return;

      if (e.ColumnIndex == colid_taring.Index) {
        DataRow dtr = dtgPrincipal.FilaActual;

        Cursor = Cursors.WaitCursor;
        DataTable dt = Global.DatosApp.TraerTabla("InventarioSel_TarjaIng", new object[] { dtr["id_taring"], ddlPlanta.SelectedValue, txtIdCliente.Tag });
        Cursor = Cursors.Default;

        if (dt != null) {

          if (dt.Rows.Count > 0) {
            DataRow dtrTarja = dt.Rows[0];

            dtr["Codigo"] = dtrTarja["id_insumo"];
            dtr["Descripcion"] = dtrTarja["nombre_insumo"];
            dtr["Cantidad"] = dtrTarja["saldo_taring"];
            dtr["Lote"] = dtrTarja["Lote"];
            dtr["Vence"] = dtrTarja["venceLote_tarIng"];
            dtr["Mixto"] = dtrTarja["Mixto"];
            dtr["IdTarjaIngreso"] = dtrTarja["Id"];

          } else {
            dtgPrincipal.CurrentRow.Cells[colCodigo.Index].ReadOnly = false;
            dtgPrincipal.CurrentRow.Cells[colDescripcion.Index].ReadOnly = false;
            dtgPrincipal.CurrentRow.Cells[colLote.Index].ReadOnly = false;
            dtgPrincipal.CurrentRow.Cells[colVence.Index].ReadOnly = false;

            dtr["Cantidad"] = 0;

            dtgPrincipal.InvalidateRow(e.RowIndex);
          }
        } else {
          MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

      } else if (e.ColumnIndex == ColContador.Index) {
        if (bolDesdeCodigo)
          return;
        LlamaBuscadorUsuario(dtgPrincipal.FilaActual, dtgPrincipal.FilaActual["Contador"].ToString());
      }

    }

    #endregion

    #region Persistencia

    private enum Llaves {
      Grilla = 100
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

    private void txtResponsable_TextChanged(object sender, EventArgs e) {
      txtResponsable.Tag = null;
    }

    private void txtResponsable_Validated(object sender, EventArgs e) {
      if (txtResponsable.Tag == null && !string.IsNullOrWhiteSpace(txtResponsable.Text))
        LlamaBuscadorUsuario(txtResponsable, null);
    }

    private void txtMonitora_TextChanged(object sender, EventArgs e) {
      txtMonitora.Tag = null;
    }

    private void txtMonitora_Validated(object sender, EventArgs e) {
      if (txtMonitora.Tag == null && !string.IsNullOrWhiteSpace(txtMonitora.Text))
        LlamaBuscadorUsuario(txtMonitora, USUARIO_TIPO.Calidad);
    }

    private void tsbAuditar_Click(object sender, EventArgs e) {
      var form =  Global.LlamarFormulario<InventarioAuditar>(true, Id);

      if (form.DialogResult == DialogResult.OK)
        RefrescarTodo();
    }
  }
}