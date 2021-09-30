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

namespace APP {

  public partial class MantencionAct : FrmBaseGrid {

    #region Declaraciones

    #region Por Defecto

    MANTENCION_ESTADO objEstado;

    private static readonly ACCESO_OPCION Acceso = ACCESO_OPCION.Defecto;

    private DataSet dtsDatos;

    private Type[] formulariosRefrescar = new Type[] {
      typeof(Mantencion)
    };

    private enum REPORTES {
      Detalle
    }

    private enum TABLAS {
      Principal = 0,
      Detalle = 1,
      Participantes = 2
    }

    public object[] Parametros { set { Id = (int)value[0]; } }

    public static bool TieneAcceso {
      get { return Global.DatosApp.TieneAcceso(Acceso) != TIPO_ACCESO.Sin_Acceso; }
    }

    public int Id { get; set; }

    #endregion

    #endregion

    #region Inicial

    public MantencionAct() {
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
      } else
        tsbReporte.Visible = ddlReporte.Visible = false;

    }

    private void ValidarAcceso() {
      PuedeActualizar = Global.DatosApp.TieneAcceso(Acceso) == TIPO_ACCESO.Editar;
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

      bool bolOK = EstadoForma == ESTADO_FORMA.Agregando ? Insertar() : Modificar();
      Cursor = Cursors.WaitCursor;



      if (bolOK) {
        EstadoForma = ESTADO_FORMA.Modificando;
        resultado = GUARDAR_RESULT.GuardadoOk;


        bool bolHayError = false;

        var listaCambios = TomarFilasModificadas(dtgPrincipal);
        var listaResultados = Global.DatosApp.ActualizarMasivo("MantencionActividad", listaCambios, false);
        SincronizarCambios(dtgPrincipal, listaResultados);

        if (!bolHayError)
          bolHayError = dtgPrincipal.HayErrores;


        listaCambios = TomarFilasModificadas(dtgParticipantes);
        listaResultados = Global.DatosApp.ActualizarMasivo("MantencionParticipante", listaCambios, false);
        SincronizarCambios(dtgParticipantes, listaResultados);

        if (!bolHayError)
          bolHayError = dtgParticipantes.HayErrores;


        if (dtgPrincipal.HayErrores || dtgParticipantes.HayErrores) {
          MessageBox.Show("No se guardaron todos los cambios porque existen filas con errores.", Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
          resultado = GUARDAR_RESULT.GuardadoError;
        }
      } else {
        resultado = GUARDAR_RESULT.GuardadoError;
      }
      Cursor = Cursors.Default;
      return resultado;
    }

    protected override object[] TomarParametrosAInsertar(DataGridView dtgGrilla, DataRow dtrFila) {
      dtrFila["IdMantencion"] = Id;

      if (dtgGrilla == dtgParticipantes) {
        return dtrFila.ItemArray.Take(3).ToArray();
      }

      return base.TomarParametrosAInsertar(dtgGrilla, dtrFila);


      //else if (dtgParticipantes == dtgGrilla) {
      //  dtrFila["IdUsuario"]= Id;
      //  return base.TomarParametrosAInsertar(dtgGrilla, dtrFila);
      //} else {
      //  return new object[] { dtrFila["Id"]};
      //}



    }

    protected override object[] TomarParametrosAModificar(DataGridView dtgGrilla, DataRow dtrFila) {

      if (dtgGrilla == dtgParticipantes) {
        return dtrFila.ItemArray.Take(3).ToArray();
      }

      return base.TomarParametrosAModificar(dtgGrilla, dtrFila);
    }

    private bool CambiarEstado(MANTENCION_ESTADO objNuevoEstado) {
      return null != this.XEjecutarProcedimiento(formulariosRefrescar, "MantencionCambiarEstado", Id, (int)objNuevoEstado, Global.DatosApp.InfoUsr.IdUsuario);
    }

    private bool Eliminar() {
      return null != this.XEjecutarProcedimiento(formulariosRefrescar, "MantencionDel", Id);
    }

    private bool Insertar() {
      object[] objParam = new object[] {
        0,
        ddlPlantaOrigen.SelectedValue,
        dtpFechaEmisionMant.Value,
        string.IsNullOrWhiteSpace(txtObsMant.Text) ? null : txtObsMant.Text,
        Global.DatosApp.InfoUsr.IdUsuario

        
        //IdPlanta,  Numero,  IdEstado,  Fecha,  Observacion,  IdUsuario,  FechaCrea,  IdUsuarioMod,  FechaMod
      };

      objParam = this.XEjecutarProcedimiento(formulariosRefrescar, "MantencionIns", objParam);

      if (objParam != null)
        Id = (int)objParam[0];
      return objParam != null;
    }

    private bool Modificar() {
      object[] objParam = new object[] {
        Id,
        ddlPlantaOrigen.SelectedValue,
        dtpFechaEmisionMant.Value,
        string.IsNullOrWhiteSpace(txtObsMant.Text) ? null : txtObsMant.Text,
        Global.DatosApp.InfoUsr.IdUsuario
      };
      
      return null != this.XEjecutarProcedimiento(formulariosRefrescar, "MantencionUpd", objParam);
    }

    #endregion

    #region Interfaz

    private void LlamaBuscadorUsuario(DataRow dtrFilaActual, string strNombre) {

      var dttTabla = Global.BuscarUsuario("", strNombre, USUARIO_TIPO.Mantencion);
      if (dttTabla != null) {
        if (dttTabla.Rows.Count > 0) {
          foreach (DataRow dtr in dttTabla.Rows) {
            DataRow dtrNueva = null;

            dtrNueva = dtrFilaActual;

            dtrNueva["IdMantencion"] = Id;
            dtrNueva["IdUsuario"] = dtr["Id"];
            dtrNueva["nombre_empleado"] = dtr["nombre_empleado"];

            ValidarFila(dtrNueva);
          }
        }
      }
    }

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
      objEstado = MANTENCION_ESTADO.Creado;

      if (!Inicializando) {
        dtgPrincipal.Vista.Table.Clear();
        dtgParticipantes.Vista.Table.Clear();
      }
      Id = 0;

      pnlPrincipal.XLimpiarControl();

      tsbEliminar.Enabled = false;
      tsbReporte.Enabled = false;
      tsbGuardar.Enabled = PuedeActualizar;
      tsbNuevo.Enabled = false;
      CadenaValoresInicial = CrearCadenaValores();
      ValidaCambios = tsbGuardar.Enabled;
      tsbRealizado.Visible = false;
      tsbIniciar.Visible = false;
    }

    private void LlenarControles() {
      Cursor = Cursors.WaitCursor;
      dtsDatos = Global.DatosApp.TraerDataset("MantencionSel_Id", new object[] { Id });
      Cursor = Cursors.Default;

      if (dtsDatos != null) {
        RefrescarGrilla(dtgPrincipal, TomarTabla(TABLAS.Detalle).DefaultView);
        RefrescarGrilla(dtgParticipantes, TomarTabla(TABLAS.Participantes).DefaultView);

        if (TomarTabla(TABLAS.Principal).Rows.Count == 0) {
          LimpiarControles();
          return;
        }

        DataRow dtr = TomarTabla(TABLAS.Principal).Rows[0];
        EstadoForma = ESTADO_FORMA.Modificando;

        Id = dtr.XEntero("Id");
        ddlPlantaOrigen.SelectedValue = dtr["IdPlanta"];
        txtNumero.Text = dtr["Numero"].ToString();
        txtObsMant.Text = dtr["Observacion"].ToString();
        dtpFechaEmisionMant.Value = dtr.XFechaHora("Fecha");
        objEstado = (MANTENCION_ESTADO)dtr.XEntero("IdEstado");

        tsbEliminar.Enabled = PuedeActualizar;
        tsbReporte.Enabled = true;
        tsbGuardar.Enabled = PuedeActualizar;
        tsbNuevo.Enabled = PuedeActualizar;
        CadenaValoresInicial = CrearCadenaValores();
        ValidaCambios = tsbGuardar.Enabled;
        tsbIniciar.Visible = PuedeActualizar && objEstado == MANTENCION_ESTADO.Creado;
        tsbRealizado.Visible = PuedeActualizar && objEstado == MANTENCION_ESTADO.EnProceso;

        tsbEliminar.Enabled = PuedeActualizar && objEstado == MANTENCION_ESTADO.EnProceso;
        tsbReporte.Enabled = true;
        tsbGuardar.Enabled = (PuedeActualizar && objEstado == MANTENCION_ESTADO.Creado) || ((objEstado == MANTENCION_ESTADO.EnProceso));
        tsbNuevo.Enabled = PuedeActualizar;

      } else {
        MessageBox.Show(ProcesarError(Global.DatosApp.UltimoError), Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }


    

    private void LlenarDdls() {
      ddlPlantaOrigen.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Planta, "Id > 0 and activo_planta = 1", ddlPlantaOrigen.DisplayMember);

    }

    private bool Validar() {
      StringBuilder stbError = new StringBuilder();

      if (ddlPlantaOrigen.SelectedValue == null) {
        stbError.AppendLine("Planta es requerido");
      }
      if (String.IsNullOrWhiteSpace(txtObsMant.Text)) {
        stbError.AppendLine("Observación es requerido");
      }

      if (stbError.Length > 0) {
        stbError.Insert(0, "Campos con errores o vacíos:\n");
        MessageBox.Show(stbError.ToString(), APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;
    }

    private void ValidarFila(DataRow dtrFila) {
      StringBuilder stbError = new StringBuilder();

      //if (dtrFila.XEsNuloOVacio("Actividad"))
      //  stbError.AppendLine("Actividad es requerido");

      //if (stbError.Length > 0)
      //  stbError.Insert(0, "Campos con errores o vacíos:\n");
      //dtrFila.RowError = stbError.ToString();
    }


    private void ValidarFilaParticipante(DataRow dtrFila) {
      StringBuilder stbError = new StringBuilder();
      
      if (dtrFila.XEsNuloOVacio("nombre_empleado"))
        stbError.AppendLine("Trabajador es requerido");

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
          objReporte = new Reporte("APP.Reportes.NOMBREREPORTE.rdlc");
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

    #endregion

    #region Eventos de controles

    private void Control_Enter(object sender, EventArgs e) {
      sender.XSeleccionarTextoEnControl();
    }

    #endregion

    #region Eventos de grilla

    private void dtgPrincipal_AntesInsertar(object sender, FilaEventArg e) {
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

    private void dtgParticipantes_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex == -1)
        return;
      if (e.ColumnIndex == colParticipantesMant.Index) {
        DataRow dtrActual = dtgParticipantes.FilaActual;
        if (!dtrActual.XEsNuloOVacio("nombre_empleado")) {
          LlamaBuscadorUsuario(dtrActual, dtrActual["nombre_empleado"].ToString());

        }
      }

    }

    private void dtgParticipantes_AntesInsertar(object sender, FilaEventArg e) {
      ValidarFilaParticipante(e.Fila);
    }

    private void dtgParticipantes_DespuesModificarFila(object sender, FilaEventArg e) {
      ValidarFilaParticipante(e.Fila);
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



    private void dtgParticipantes_Validated(object sender, EventArgs e) {
      //if (!dtgParticipantes.Text.XEsNuloOVacio() && dtgParticipantes.Tag.XEntero() == 0) {
      //  DataRow dtr = LlamaBuscadorUsuario(dtgParticipantes.Text);
      //}
    }

    private void tsbIniciar_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a iniciar la mantención actual ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (CambiarEstado(MANTENCION_ESTADO.EnProceso))
          RefrescarTodo();
      }
    }

    private void tsbRealizado_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a finalizar la mantención actual ¿Confirma?", Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        if (CambiarEstado(MANTENCION_ESTADO.Finalizado))
          RefrescarTodo();
      }
    }
  }
}
