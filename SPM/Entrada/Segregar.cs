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
using ITD.AccDatos;

namespace APP {

  public partial class Segregar : FrmBaseGrid {

    #region Declaraciones

    #region Por Defecto

    private static readonly ACCESO_OPCION Acceso = ACCESO_OPCION.Segregacion;

    private DataSet dtsDatos;

    private Type[] formulariosRefrescar = new Type[] {

    };

    private enum REPORTES {
      Detalle
    }

    private enum TABLAS {
      Principal = 0,
      TarjaIngreso = 1,
      Detalle = 2
    }

    public static bool TieneAcceso {
      get { return Global.DatosApp.TieneAcceso(Acceso) != TIPO_ACCESO.Sin_Acceso; }
    }

    public int Id { get; set; }

    public object[] Parametros { set { Id = value[0].XEntero() ; } }

    ESTADO_SEGREGACION objEstado;

    #endregion

    #endregion

    #region Inicial

    public Segregar() {
      InitializeComponent();
      LlenarDdls();
    }

    private void ActualizacionGrilla_Load(object sender, EventArgs e) {
      InicializarParametros();
      RefrescarTodo();
    }

    private void InicializarParametros() {
      ValidarAcceso();
      ValidarCambios(pnlPrincipal);

      if (ddlReporte.Items.Count > 0) {
        ddlReporte.SelectedIndex = (int)REPORTES.Detalle;
        ddlReporte.Visible = ddlReporte.Items.Count > 1;
      }
      else
        tsbReporte.Visible = ddlReporte.Visible = false;

      grillaTotal1.AgregarColumnaTotal(colCantNuevo.Index, GrillaTotal.AGREGADO.Suma);
    }

    private void ValidarAcceso() {
      PuedeActualizar = Global.DatosApp.TieneAcceso(Acceso) == TIPO_ACCESO.Editar;
    }

    #endregion

    #region Actualizacion

    public override GUARDAR_RESULT GuardarTodo() {
      GUARDAR_RESULT resultado = GUARDAR_RESULT.CanceladoGuardar;
      if (!dtgPrincipal.FinalizaEdicion() || !dtgTarjaIngreso.FinalizaEdicion()) {
        return resultado;
      }

      if (!Validar()) {
        return resultado;
      }

      if (dtgPrincipal.HayErrores || dtgTarjaIngreso.HayErrores) {
        MessageBox.Show("No se pueden guardar los cambios porque existen filas con errores.", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return resultado;
      }

      bool bolOK = EstadoForma == ESTADO_FORMA.Agregando ? Insertar() : Modificar();
      Cursor = Cursors.WaitCursor;

      if (bolOK) {
        EstadoForma = ESTADO_FORMA.Modificando;
        resultado = GUARDAR_RESULT.GuardadoOk;

        bool bolError = false;

        var listaCambios = TomarFilasModificadas(dtgTarjaIngreso);
        var listaResultados = Global.DatosApp.ActualizarMasivo("SegregacionDet", listaCambios, false);
        SincronizarCambios(dtgTarjaIngreso, listaResultados);

        bolError = dtgPrincipal.HayErrores;

        listaCambios = TomarFilasModificadas(dtgPrincipal);
        listaResultados = Global.DatosApp.ActualizarMasivo("SegregacionDetNuevo", listaCambios, false);
        SincronizarCambios(dtgPrincipal, listaResultados);


        if (bolError) {
          MessageBox.Show("No se guardaron todos los cambios porque existen filas con errores.", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
          resultado = GUARDAR_RESULT.GuardadoError;
        }
      }
      else {
        resultado = GUARDAR_RESULT.GuardadoError;
      }
      Cursor = Cursors.Default;
      return resultado;
    }

    protected override void SincronizarFilaIns(DataGridView dtgGrilla, Registro nuevo, DataRow dtrFila) {
      if (dtgTarjaIngreso == dtgGrilla) {
        if (nuevo.Parametros[0].XEntero() > 0) {
          List<DataRow> lista = dtgPrincipal.Vista.Table.AsEnumerable().Where(s => s.XEntero("IdSegregacionDet") == dtrFila.XEntero("Id")).ToList();

          lista.ForEach(s => s["IdSegregacionDet"] = nuevo.Parametros[0].XEntero());
        }
      }
      base.SincronizarFilaIns(dtgGrilla, nuevo, dtrFila);
    }

    protected override object[] TomarParametrosAInsertar(DataGridView dtgGrilla, DataRow dtrFila) {
      if (dtgTarjaIngreso == dtgGrilla) {
        dtrFila["IdSegregacion"] = Id;
        return dtrFila.ItemArray.Take(4).ToArray();
      }
      else
        return base.TomarParametrosAInsertar(dtgGrilla, dtrFila);
    }

    protected override object[] TomarParametrosAModificar(DataGridView dtgGrilla, DataRow dtrFila) {
      if (dtgTarjaIngreso == dtgGrilla)
        return dtrFila.ItemArray.Take(4).ToArray();
      else
        return base.TomarParametrosAModificar(dtgGrilla, dtrFila);
    }

    private bool Eliminar() {
      return null != this.XEjecutarProcedimiento(formulariosRefrescar, "SegregacionDel", Id);
    }

    private bool Insertar() {
      object[] objParam = new object[] {
        0,
        ddlIdPlanta.SelectedValue,
        txtnombre_clie.Tag,
        txtObservacion.XTextoONulo(),
        Global.DatosApp.InfoUsr.IdUsuario
      };

      objParam = this.XEjecutarProcedimiento(formulariosRefrescar, "SegregacionIns", objParam);

      if (objParam != null)
        Id = (int)objParam[0];

      return objParam != null;
    }

    private bool Modificar() {
      object[] objParam = new object[] {
        Id,
        txtnombre_clie.Tag,
        txtObservacion.XTextoONulo(),
        Global.DatosApp.InfoUsr.IdUsuario
      };

      return null != this.XEjecutarProcedimiento(formulariosRefrescar, "SegregacionUpd", objParam);
    }

    private bool CambiarEstado(ESTADO_SEGREGACION objEstado) {
      return null != this.XEjecutarProcedimiento(formulariosRefrescar, "SegregacionCambiarEstado", Id, (int)objEstado, Global.DatosApp.InfoUsr.IdUsuario);
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

      ddlIdPlanta.DataSource = Global.DatosApp.InfoUsr.Plantas.DefaultView;
      ddlIdPlanta.Enabled = true;
      ddlIdPlanta.SelectedIndex = -1;

      tsbEliminar.Enabled = false;
      tsbReporte.Enabled = false;
      tsbGuardar.Enabled = PuedeActualizar;
      tsbNuevo.Enabled = false;
      tsbFinalizar.Visible = false;
      CadenaValoresInicial = CrearCadenaValores();
      ValidaCambios = tsbGuardar.Enabled;
    }

    private void LlenarControles() {
      Cursor = Cursors.WaitCursor;
      dtsDatos = Global.DatosApp.TraerDataset("SegregacionSel_Id", new object[] { Id });
      Cursor = Cursors.Default;

      if (dtsDatos != null) {
        RefrescarGrilla(dtgPrincipal, TomarTabla(TABLAS.Detalle).DefaultView);
        RefrescarGrilla(dtgTarjaIngreso, TomarTabla(TABLAS.TarjaIngreso).DefaultView);

        if (TomarTabla(TABLAS.Principal).Rows.Count == 0) {
          LimpiarControles();
          return;
        }

        DataRow dtr = TomarTabla(TABLAS.Principal).Rows[0];
        EstadoForma = ESTADO_FORMA.Modificando;

        ddlIdPlanta.DataSource = Global.DatosApp.TomarMisPlantas();
        ddlIdPlanta.Enabled = false;

        Id = dtr.XEntero("Id");
        txtNumero.Text = dtr["Numero"].ToString();
        ddlIdPlanta.SelectedValue = dtr["IdPlanta"];
        txtnombre_clie.Text = dtr["nombre_clie"].ToString();
        txtnombre_clie.Tag = dtr["IdCliente"];
        txtObservacion.Text = dtr["Observacion"].ToString();
        txtEstado.Text = dtr["Estado"].ToString();

        objEstado = (ESTADO_SEGREGACION)dtr.XEntero("IdEstado");

        tsbEliminar.Enabled = PuedeActualizar && objEstado == ESTADO_SEGREGACION.Creado;
        tsbReporte.Enabled = true;
        tsbGuardar.Enabled = PuedeActualizar && objEstado == ESTADO_SEGREGACION.Creado;
        tsbNuevo.Enabled = PuedeActualizar;
        tsbFinalizar.Visible = PuedeActualizar && objEstado == ESTADO_SEGREGACION.Creado;

        CadenaValoresInicial = CrearCadenaValores();
        ValidaCambios = tsbGuardar.Enabled;
      }
      else {
        MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void LlenarDdls() {
    }

    private bool Validar() {
      StringBuilder stbError = new StringBuilder();
      
      if (ddlIdPlanta.SelectedValue == null)
        stbError.AppendLine("Planta es requerido.");
      
      if (txtnombre_clie.Tag.XEntero() == 0)
        stbError.AppendLine("Cliente es requerido.");

      if (string.IsNullOrWhiteSpace(txtObservacion.Text))
        stbError.AppendLine("Observación es requerido.");


      dtgTarjaIngreso.Vista.Table.AsEnumerable().Where(s => s.RowState != DataRowState.Detached && s.RowState != DataRowState.Deleted).ToList().ForEach(s => ValidarFilaTI(s));

      if (stbError.Length > 0) {
        stbError.Insert(0, "Campos con errores o vacíos:\n");
        MessageBox.Show(stbError.ToString(), APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;
    }

    private void ValidarFila(DataRow dtrFila) {
      StringBuilder stbError = new StringBuilder();

      if (dtrFila.XEntero("CantNuevo") <= 0)
        stbError.AppendLine("Cantidad no válido");

      if (dtrFila.XEsNuloOVacio("Codigo") )
        stbError.AppendLine("Código no válido");

      if (stbError.Length > 0)
        stbError.Insert(0, "Campos con errores o vacíos:\n");
      dtrFila.RowError = stbError.ToString();
    }

    private void ValidarFilaTI(DataRow dtrFila) {
      StringBuilder stbError = new StringBuilder();

      int intSuma = dtgPrincipal.Vista.Table.AsEnumerable().Where(s => s.RowState != DataRowState.Detached && s.RowState != DataRowState.Deleted && s.XEntero("IdSegregacionDet") == dtrFila.XEntero("Id")).Sum(s => s.XEntero("CantNuevo"));

      if(dtrFila.XEntero("Cantidad") < intSuma)
        stbError.AppendLine("La suma de las cantidades a segregar, superan la cantidad de la tarja");

      if(dtgPrincipal.Vista.Table.AsEnumerable().Where(s => s.RowState != DataRowState.Detached && s.RowState != DataRowState.Deleted && s.XEntero("IdSegregacionDet") == dtrFila.XEntero("Id")).ToList().Exists(s => !s.RowError.XEsNuloOVacio()))
        stbError.AppendLine("Hay errores en la lista segregadas");

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
          var dtsDatos = APP_GEN.Global.DatosApp.TraerDataset("PROCEDIMIENTO", objParam);
          objReporte = new Reporte("Reportes.Reportes.NOMBREREPORTE.rdlc","Reportes");
          objReporte.Titulo = "TITULO";

          foreach (DataTable dttReporte in dtsDatos.Tables) {
            objReporte.Datos.Add(dttReporte);
          }

          objReporte.Parametros.Add("Sistema", APP_GEN.Global.DatosApp.Sistema);
          Cursor = Cursors.Default;
          break;
      }

      if (objReporte != null)
        objReporte.MostrarReporte(APP_GEN.Global.FormaPrincipal);
    }

    private DataTable TomarTabla(TABLAS objTabla) {
      return dtsDatos.Tables[(int)objTabla];
    }

    private void LlamaBuscadorCliente(string strCodigo, string strNombre) {
      var dttTabla = Global.BuscarEntidad(strCodigo, strNombre, true, true);
      if (dttTabla != null) {
        if (dttTabla.Rows.Count > 0) {
          var dtrFila = dttTabla.Rows[0];
          txtnombre_clie.Text = dtrFila["nombre_clie"].ToString();
          txtnombre_clie.Tag = dtrFila["Id"];
          
        }
      }
      else {
        txtnombre_clie.Tag = null;
      }
    }

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

    private void tsbFinalizar_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a cambiar el estado de la segregación. Con esto, se crearán las nuevas tarjas de ingreso. ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (CambiarEstado(ESTADO_SEGREGACION.Finalizado))
          RefrescarTodo();
      }
    }

    #endregion

    #region Eventos de controles

    private void Control_Enter(object sender, EventArgs e) {
      sender.XSeleccionarTextoEnControl();
    }

    private void txtnombre_clie_Validated(object sender, EventArgs e) {
      if (txtnombre_clie.Tag == null && !string.IsNullOrWhiteSpace(txtnombre_clie.Text))
        LlamaBuscadorCliente("", txtnombre_clie.Text);
    }

    private void txtrut_clie_TextChanged(object sender, EventArgs e) {
      txtnombre_clie.Tag = null;
    }

    #endregion

    #region Eventos de grilla

    private void dtgPrincipal_AntesInsertar(object sender, FilaEventArg e) {

      if (dtgTarjaIngreso.FilaActual == null) {
        MessageBox.Show("Debe agregar una fila en las tarjas", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        e.Cancel = true;
        return;
      }

      if (dtgTarjaIngreso.FilaActual.XEsNuloOVacio("IdTarjaIngreso")) {
        MessageBox.Show("Debe ingresar una tarja válida antes de segregar", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        e.Cancel = true;
        return;
      }

      e.Fila["IdSegregacionDet"] = TomarId(dtgTarjaIngreso);
      e.Fila["Codigo"] = dtgTarjaIngreso.FilaActual["id_insumo"];
      e.Fila["LoteNuevo"] = dtgTarjaIngreso.FilaActual["lote_tarIng"];
      e.Fila["VenceNuevo"] = dtgTarjaIngreso.FilaActual["venceLote_tarIng"];
      e.Fila["OCNuevo"] = dtgTarjaIngreso.FilaActual["OC"];

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

    private void dtgTarjaIngreso_AntesInsertar(object sender, FilaEventArg e) {
      if (ddlIdPlanta.SelectedValue.XEntero() == 0) {
        MessageBox.Show("Debe seleccionar la planta", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        e.Cancel = true;
        return;
      }

      if (txtnombre_clie.Tag.XEntero() == 0) {
        MessageBox.Show("Debe ingresar el cliente", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        e.Cancel = true;
        return;
      }
    }

    private void dtgTarjaIngreso_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex == -1) return;


      if (e.ColumnIndex == colid_taring.Index) {
        DataRow dtr = dtgTarjaIngreso.FilaActual;
        DataTable dt = Global.DatosApp.TraerTabla("SegregacionSel_TarjaIng", new object[] { ddlIdPlanta.SelectedValue, dtr["id_taring"].ToString(), txtnombre_clie.Tag.XEntero() });

        if (dt == null) {
          MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        if (dt.Rows.Count == 0) {
          MessageBox.Show("La tarja no existe, no tiene saldo o no se encuentra en un estado válido", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        DataRow dtrTarja = dt.Rows[0];

        dtr["IdTarjaIngreso"] = dtrTarja["Id"];
        dtr["id_taring"] = dtrTarja["id_taring"];
        dtr["Cantidad"] = dtrTarja["saldo_taring"];
        dtr["nombre_insumo"] = dtrTarja["nombre_insumo"];
        dtr["lote_tarIng"] = dtrTarja["lote_tarIng"];
        dtr["venceLote_tarIng"] = dtrTarja["venceLote_tarIng"];
        dtr["OC"] = dtrTarja["OC"];
        dtr["id_insumo"] = dtrTarja["id_insumo"];

        dtgTarjaIngreso.InvalidateRow(dtgTarjaIngreso.CurrentRow.Index);

      }

    }

    private void dtgTarjaIngreso_DespuesCambioFila(object sender, FilaGrillaEventArg e) {
      dtgPrincipal.Vista.RowFilter = string.Format("IdSegregacionDet={0}", TomarId(dtgTarjaIngreso).XEntero());
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

  }
}