using APP_GEN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ITD.Funciones;
using ITD.Win;
using ITD.AccDatos;
using Global = APP_GEN.Global;

namespace APP {

  public partial class CliProvAct : ITD.Win.Formas.FrmBaseGrid {

    #region Declaraciones

    public int IdEntidad { get; set; }

    private bool bolActivo = false;

    private DataTable dtCiudades;
    private const string SIN_GIRO = "SIN GIRO";

    #region Por Defecto

    private static readonly ACCESO_OPCION Acceso = ACCESO_OPCION.Cliente;

    private DataSet dtsDatos;

    private Type[] formulariosRefrescar = new Type[] {
      typeof(CliProvCons)
    };
    
    private enum REPORTES {
      Detalle
    }

    private enum TABLAS {
      Clientes,
      Contactos,
      Direcciones
    }

    public static bool TieneAcceso {
      get { return Global.DatosApp.TieneAcceso(Acceso) != TIPO_ACCESO.Sin_Acceso; }
    }
    
    public object[] Parametros { set { IdEntidad = (int)value[0]; } }

    #endregion

    bool bolAgregando = false;

    #endregion

    #region Inicial

    public CliProvAct() {
      InitializeComponent();
      LlenarDdls();
    }

    private void ClientesDatos_Load(object sender, EventArgs e) {
      Cursor = Cursors.WaitCursor;
      InicializaParametros();
      RefrescarTodo();
      Cursor = Cursors.Default;
    }

    public void InicializaParametros() {
      ValidarAcceso();
      ValidarCambios(grpDatos);
    }

    public void ValidarAcceso() {
      PuedeActualizar = APP_GEN.Global.DatosApp.TieneAcceso(ACCESO_OPCION.Cliente) == TIPO_ACCESO.Editar;
    }

    #endregion

    #region Actualizar

    public override GUARDAR_RESULT GuardarTodo() {
      GUARDAR_RESULT resultado = GUARDAR_RESULT.CanceladoGuardar;
      if(!Validar())
        return resultado;
      if(!dtgContactos.FinalizaEdicion())
        return resultado;
      if(!dtgDirecciones.FinalizaEdicion())
        return resultado;
      if(dtgContactos.HayErrores || dtgDirecciones.HayErrores) {
        MessageBox.Show("No se pueden guardar los datos porque existen filas con errores.", APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return resultado;
      }
      Cursor = Cursors.WaitCursor;
      bool boOk = EstadoForma == ESTADO_FORMA.Agregando ? Insertar() : Modificar();
      if(boOk) {
        EstadoForma = ESTADO_FORMA.Modificando;
        resultado = GUARDAR_RESULT.GuardadoOk;
        var listaContCambios = TomarFilasModificadas(dtgContactos);
        var listContResultados = APP_GEN.Global.DatosApp.ActualizarMasivo("EntidadContacto", listaContCambios, false);
        SincronizarCambios(dtgContactos, listContResultados);
        bool bolHayErrores = listContResultados.HayErrores();
        var listaDirCambios = TomarFilasModificadas(dtgDirecciones);
        var listaDirResultados = APP_GEN.Global.DatosApp.ActualizarMasivo("EntidadDireccion", listaDirCambios, false);
        SincronizarCambios(dtgDirecciones, listaDirResultados);
        if(!bolHayErrores) bolHayErrores = listaDirResultados.HayErrores();
        if(bolHayErrores) {
          MessageBox.Show("No se guardaron todos los datos porque existen filas con errores.", APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
          resultado = GUARDAR_RESULT.GuardadoError;
        } else {
          APP_GEN.Global.FormaPrincipal.RefrescarFormulario(typeof(CliProvCons).FullName);
        }
      } else {
        resultado = GUARDAR_RESULT.GuardadoError;
      }
      Cursor = Cursors.Default;
      return resultado;
    }

    private string RetornaTexto(string texto) {
      if (string.IsNullOrEmpty(texto) || string.IsNullOrWhiteSpace(texto))
        return null;
      else
        return texto;
    }

    public bool Insertar() {
      object[] parametros = new object[]{
            0,
            txtRut.Text.Trim(),
            rdbSi.Checked,
            txtNombre.Text.Trim(),
            RetornaTexto(txtRazonSocial.Text),
            txtGiro.Text.Trim(),
            chkCliente.Checked,
            chkProveedor.Checked,
            RetornaTexto(txtTelefono.Text),
            RetornaTexto(txtEmailFact.Text),
            nudDiasPago.XValorNumeric(),
            APP_GEN.Global.DatosApp.InfoUsr.IdUsuario,
            chkLoteObligatorio.Checked
        };
      if (!APP_GEN.Global.DatosApp.Ejecutar("EntidadIns", parametros)) {
        MessageBox.Show(ProcesarError(APP_GEN.Global.DatosApp.UltimoError), APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      IdEntidad = Convert.ToInt32(parametros[0]);
      return true;
    }

    public bool Modificar() {
      object[] parametros = new object[]{
            IdEntidad,
            txtRut.Text.Trim(),
            rdbSi.Checked,
            txtNombre.Text.Trim(),
            RetornaTexto(txtRazonSocial.Text),
            txtGiro.Text.Trim(),
            chkCliente.Checked,
            chkProveedor.Checked,
            RetornaTexto(txtTelefono.Text),
            RetornaTexto(txtEmailFact.Text),
            nudDiasPago.XValorNumeric(),
            APP_GEN.Global.DatosApp.InfoUsr.IdUsuario,
            chkLoteObligatorio.Checked
        };
      if (!APP_GEN.Global.DatosApp.Ejecutar("EntidadUpd", parametros)) {
        MessageBox.Show(ProcesarError(APP_GEN.Global.DatosApp.UltimoError), APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }

      return true;
    }

    public bool Eliminar() {
      if (!APP_GEN.Global.DatosApp.Ejecutar("EntidadDel", new object[] { IdEntidad })) {
        MessageBox.Show(ProcesarError(APP_GEN.Global.DatosApp.UltimoError), APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;
    }

    public bool Activar() {
      object[] objParam = new object[] {
        IdEntidad,
        !bolActivo,
        APP_GEN.Global.DatosApp.InfoUsr.IdUsuario
        };
      if(!APP_GEN.Global.DatosApp.Ejecutar("EntidadActivar", objParam)) {
        MessageBox.Show(ProcesarError(APP_GEN.Global.DatosApp.UltimoError), APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;

    }

    protected override object[] TomarParametrosAInsertar(DataGridView dtgGrilla, DataRow dtrFila) {
      if(dtgGrilla == dtgContactos) {
        return new object[] {
                0,
                IdEntidad,
                dtrFila["Nombre"],
                dtrFila["Telefono"],
                dtrFila["Celular"],
                dtrFila["Email"],
                dtrFila["Activo"],
                APP_GEN.Global.DatosApp.InfoUsr.IdUsuario
            };
      }
      if(dtgGrilla == dtgDirecciones) {
        return new object[]{
                0,
                IdEntidad,
                dtrFila["NombreDireccion"],
                dtrFila["Telefono"],
                dtrFila["Direccion"],
                dtrFila["IdComuna"],
                dtrFila["Ciudad"],
                APP_GEN.Global.DatosApp.InfoUsr.IdUsuario,
                dtrFila["Activo"],
                dtrFila["Principal"]
            };
      }
      return base.TomarParametrosAInsertar(dtgGrilla, dtrFila);
    }

    protected override object[] TomarParametrosAModificar(DataGridView dtgGrilla, DataRow dtrFila) {
      if(dtgGrilla == dtgContactos) {
        return new object[] {
                dtrFila["IdContacto"],
                dtrFila["Nombre"],
                dtrFila["Telefono"],
                dtrFila["Celular"],
                dtrFila["Email"],
                dtrFila["Activo"],
                APP_GEN.Global.DatosApp.InfoUsr.IdUsuario
            };
      }
      if(dtgGrilla == dtgDirecciones) {
        return new object[]{
                dtrFila["IdDireccion"],
                dtrFila["NombreDireccion"],
                dtrFila["Telefono"],
                dtrFila["Direccion"],
                dtrFila["IdComuna"],
                dtrFila["Ciudad"],
                APP_GEN.Global.DatosApp.InfoUsr.IdUsuario,
                dtrFila["Activo"],
                dtrFila["Principal"]
            };
      }
      return base.TomarParametrosAModificar(dtgGrilla, dtrFila);
    }

    public override string ProcesarError(DataGridView dtgGrilla, Registro parametros, DataRow dtrFila) {
      if (parametros.Error.Excepcion.Contains("IX_EntidadDireccion"))
        return "El nombre de la dirección ya se encuentra ingresado";
      return base.ProcesarError(dtgGrilla, parametros, dtrFila);
    }

    #endregion

    #region Interfaz

    public override bool HayCambios() {
      return base.HayCambios() || dtgContactos.HayCambios || dtgDirecciones.HayCambios;
    }

    private void LlenarDdls() {
      dtCiudades = APP_GEN.Global.Cache.TomarTabla(ClaseCache.TABLA.Ciudad, true);

      ColRegion.DisplayMember = "Region";
      ColRegion.ValueMember = "IdRegion";
      ColRegion.DataSource = Global.Cache.TomarVista(ClaseCache.TABLA.Region, "IdRegion > 0", "");
      
    }

    private bool Validar() {
      StringBuilder strError = new StringBuilder();
      if(rdbSi.Checked)
        if(!ITD.Funciones.FuncGen.ValidarRut(txtRut.Text.Trim()))
          strError.AppendLine("    RUT, ");
      if(string.IsNullOrWhiteSpace(txtNombre.Text.Trim()))
        strError.AppendLine("    Nombre, ");
      if(string.IsNullOrWhiteSpace(txtGiro.Text))
        strError.AppendLine("    Giro, ");

      if(!string.IsNullOrWhiteSpace(txtEmailFact.Text))
        if(!FuncGen.EsEmailValido(txtEmailFact.Text.Trim()))
          strError.AppendLine("    Email no válido, ");

      if(dtgDirecciones.Vista.Table.Rows.Count  == 0 ||!dtgDirecciones.Vista.Table.AsEnumerable().Where(s => s.RowState != DataRowState.Deleted && s.RowState != DataRowState.Detached).Any(s => (bool)s["Principal"]))
        strError.AppendLine("Debe existir una dirección como principal, ");

      if(strError.Length > 0) {
        strError.Insert(0, "Campos omitidos o con error:\n");
        MessageBox.Show(strError.ToString().Substring(0, strError.Length - 4) + ".", APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }

      return true;
    }

    public override void RefrescarTodo() {
      if (IdEntidad > 0)
        LlenarControles();
      else
        LimpiarControles();
    }

    private void LimpiarControles() {
      Cursor = Cursors.WaitCursor;
      var dtDatos = APP_GEN.Global.DatosApp.TraerDataset("EntidadSel_Id", new object[] { IdEntidad });
      if(dtDatos != null) {
        RefrescarGrilla(dtgContactos, dtDatos.Tables[1].DefaultView);
        RefrescarGrilla(dtgDirecciones, dtDatos.Tables[2].DefaultView);
        EstadoForma = ESTADO_FORMA.Agregando;
        rdbSi.Checked = true;
        lblRut.Text = "Rut";
        txtRut.Clear();
        
        chkCliente.Checked = true;
        chkProveedor.Checked = false;
        txtNombre.Clear();
        txtRazonSocial.Clear();
        chkGiro.Checked = true;
        txtGiro.Clear();
        txtEmailFact.Clear();
        txtTelefono.Clear();
        nudDiasPago.Value = 0;
        txtEstado.Text = "Activo";
        txtModificadoPor.Text = APP_GEN.Global.DatosApp.InfoUsr.Usuario;
        txtFecMod.Text = DateTime.Now.ToString("g");
        bolActivo = true;
        tsbActivar.ToolTipText = "Desactivar";
        tsbActivar.Image = APP.Properties.Resources.Activar_d;
        tsbNuevo.Enabled = false;
        tsbGuardar.Enabled = PuedeActualizar;
        tsbEliminar.Enabled = false;
        tsbActivar.Enabled = false;
        tsbReporte.Enabled = false;
      } else
        MessageBox.Show(ProcesarError(APP_GEN.Global.DatosApp.UltimoError), APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
      ValidaCambios = tsbGuardar.Enabled;
      CadenaValoresInicial = CrearCadenaValores();
      Cursor = Cursors.Default;
    }

    public void LlenarControles() {
      Cursor = Cursors.WaitCursor;
      var dtDatos = APP_GEN.Global.DatosApp.TraerDataset("EntidadSel_Id", new object[] { IdEntidad });
      EstadoForma = ESTADO_FORMA.Modificando;
      if(dtDatos != null) {
        RefrescarGrilla(dtgContactos, dtDatos.Tables[1].DefaultView);
        RefrescarGrilla(dtgDirecciones, dtDatos.Tables[2].DefaultView);
        if(dtDatos.Tables[0].Rows.Count > 0){
        EstadoForma = ESTADO_FORMA.Modificando;
        DataRow drFila = dtDatos.Tables[0].Rows[0];
        if((bool)drFila["TieneRut"]) {
          rdbSi.Checked = true;
          lblRut.Text = "Rut";
        } else {
          rdbNo.Checked = true;
          lblRut.Text = "Código";
        }
        txtRut.Text = drFila["Codigo"].ToString();
        chkCliente.Checked = (bool)drFila["EsCliente"];
        chkProveedor.Checked = (bool)drFila["EsProveedor"];
        txtNombre.Text = drFila["Nombre"].ToString();
        txtRazonSocial.Text = drFila["RazonSocial"].ToString();
        chkGiro.Checked = !drFila["Giro"].ToString().Equals(SIN_GIRO);
        chkGiro_CheckedChanged(null, null);
        txtGiro.Text = drFila["Giro"].ToString();
        txtEmailFact.Text = drFila["EmailFacturacion"].ToString();
        txtTelefono.Text = drFila["Telefono"].ToString();
        nudDiasPago.Value = Convert.ToDecimal(drFila["DiasPago"]);
        txtEstado.Text = drFila["Estado"].ToString();
        txtModificadoPor.Text = drFila["Usuario"].ToString();
        txtFecMod.Text = ((DateTime)drFila["FechaMod"]).ToString("g");
          chkLoteObligatorio.Checked = drFila.XBooleano("LoteObliga");
        bolActivo = (bool)drFila["Activo"];
          if (bolActivo) {
          tsbActivar.ToolTipText = "Desactivar";
          tsbActivar.Image = APP.Properties.Resources.Activar_d;
        } else {
          tsbActivar.ToolTipText = "Activar";
          tsbActivar.Image = APP.Properties.Resources.Activar;
        }
          tsbNuevo.Enabled = PuedeActualizar;
          tsbGuardar.Enabled = PuedeActualizar;
          tsbEliminar.Enabled = PuedeActualizar;
          tsbActivar.Enabled = PuedeActualizar;
          tsbReporte.Enabled = dtDatos.Tables[0].Rows.Count > 0;
        }
      } else
        MessageBox.Show(ProcesarError(APP_GEN.Global.DatosApp.UltimoError), APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
      ValidaCambios = tsbGuardar.Enabled;
      CadenaValoresInicial = CrearCadenaValores();
      Cursor = Cursors.Default;
    }

    private string LimpiarTexto(string strIn) {
      return System.Text.RegularExpressions.Regex.Replace(strIn, @"[^\w\.@-]", "").Replace("@", "").Replace(".", "").Replace("-", "");
    }

    private bool ValidarRut() {
      if (!string.IsNullOrEmpty(txtRut.Text.Trim()) && rdbSi.Checked) {
        txtRut.Text = APP_GEN.Global.FormatearRut(txtRut.Text.ToString().Trim());
        if(!FuncGen.ValidarRut(txtRut.Text.Trim())) {
          MessageBox.Show("Rut ingresado no válido", APP_GEN.Global.STR_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
          txtRut.Focus();
          return false;
        }
      }
      return true;
    }

    private void ValidarFilaContactos(DataRow dtrFila) {
      StringBuilder strError = new StringBuilder();
      if(string.IsNullOrWhiteSpace(dtrFila["Nombre"].ToString()))
        strError.AppendLine("Nombre es requerido. ");
      if(!string.IsNullOrWhiteSpace(dtrFila["Email"].ToString()))
        if(!FuncGen.EsEmailValido(dtrFila["Email"].ToString()))
          strError.AppendLine("Email no válido. ");
      if (strError.Length > 0)
        strError.Insert(0, "Existen campos con errores o vacíos:\n");
      dtrFila.RowError = strError.ToString();
    }

    private void ValidarFilaDirecciones(DataRow dtrFila) {
      StringBuilder strError = new StringBuilder();

      dtrFila.XValidarNuloOVacio(strError, new Dictionary<string, string>() {
        {"NombreDireccion","Nombre"},
        {"Direccion","Dirección."},
        {"Ciudad","Ciudad."}
      });
      
      if(strError.Length > 0)
        strError.Insert(0, "Existen campos con errores o vacíos:\n");
      dtrFila.RowError = strError.ToString();
    }

    public void LlamadoDesdePrincipal(params object[] parametros) {
      if (this.XGuardaCambios(dtgContactos, dtgDirecciones)) {
        Parametros = parametros;
        if (IdEntidad == 0)
          LimpiarControles();
        else
          RefrescarTodo();
      }
    }

    #endregion

    #region Acciones

    private void MostrarReporte() {
      Reporte objReporte = null;
      object[] objParam;
      objParam = new object[]{
                     IdEntidad
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
      if(objReporte != null)
        objReporte.MostrarReporte(APP_GEN.Global.FormaPrincipal);
      Cursor = Cursors.Default;
    }

    private AutoCompleteStringCollection CargarAutoCompletado(DataRow dtrFila) {
      AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();
      dtCiudades.AsEnumerable().Where(s => s.XEntero("IdRegion") == dtrFila.XEntero("IdRegion")).ToList().ForEach(s => stringCol.Add(s["Ciudad"].ToString().Trim()));
      return stringCol;
    }

    #endregion

    #region Eventos de Barra

    private void tsbNuevo_Click(object sender, EventArgs e) {
      if(!ValidaCambios || GuardarSiHayCambios() == GUARDAR_RESULT.GuardadoOk) {
        IdEntidad = 0;
        LimpiarControles();
      }
    }

    private void tsbGuardar_Click(object sender, EventArgs e) {
      if(GuardarTodo() == GUARDAR_RESULT.GuardadoOk) {
        RefrescarTodo();
      }
    }

    private void tsbEliminar_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Va a eliminar el cliente seleccionado ¿Confirma?", APP_GEN.Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
        if (Eliminar())
          LimpiarControles();
      APP_GEN.Global.FormaPrincipal.RefrescarFormulario(typeof(CliProvCons).FullName);
    }

    private void tsbRefrescar_Click(object sender, EventArgs e) {
      if (!ValidaCambios || GuardarSiHayCambios() == GUARDAR_RESULT.GuardadoOk)
        RefrescarTodo();
    }

    private void tsbActivar_Click(object sender, EventArgs e) {
      string mensaje = string.Format("Va a {0} al cliente/proveedor seleccionado ¿Confirma?", tsbActivar.ToolTipText.ToLower());
      if (MessageBox.Show(mensaje, APP_GEN.Global.STR_CONFIRMA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
        if (Activar())
          RefrescarTodo();

    }
    
    private void tsbReporte_Click(object sender, EventArgs e) {
      MostrarReporte();
    }

    #endregion

    #region Eventos Controles

    private void rdbSi_CheckedChanged(object sender, EventArgs e) {
      if(!Inicializando) {
        if(rdbSi.Checked) {
          lblRut.Text = "Rut";
          ValidarRut();
        }
      }
    }

    private void rdbNo_CheckedChanged(object sender, EventArgs e) {
      if(!Inicializando) {
        if(rdbNo.Checked) {
          lblRut.Text = "Código";
          txtRut.Text = RutSinformato(txtRut.Text.Trim());
        }
      }
    }

    private void txtRut_Validating(object sender, CancelEventArgs e) {
      ValidarRut();
    }

    private string RutSinformato(string strRut) {
      string RutSinFormato = strRut;
      if (!String.IsNullOrEmpty(RutSinFormato)) {
        string[] rutArray = RutSinFormato.Split('.', '-');
        StringBuilder strResult = new StringBuilder();
        for (int i = 0; i < rutArray.Length; i++) {
          strResult.Append(rutArray[i]);
        }
        RutSinFormato = strResult.ToString();
      }
      return RutSinFormato;

    }

    private void chkGiro_CheckedChanged(object sender, EventArgs e) {
      if (chkGiro.Checked) {
        this.XCambiarHabilitado(true, txtGiro);
        txtGiro.Clear();
      }
      else {
        txtGiro.Text = SIN_GIRO;
        this.XCambiarHabilitado(false, txtGiro);
      }
    }

    #endregion

    #region Eventos de Grilla

    private void dtgContactos_AntesInsertar(object sender, FilaEventArg e) {
      e.Fila["Activo"] = 1;
      ValidarFilaContactos(e.Fila);
    }

    private void dtgContactos_DespuesModificarFila(object sender, FilaEventArg e) {
      ValidarFilaContactos(e.Fila);
    }

    private void dtgContactos_Enter(object sender, EventArgs e) {
      sbpFilas.Text = dtgContactos.RowCount.ToString();
    }

    private void dtgDirecciones_AntesInsertar(object sender, FilaEventArg e) {
      e.Fila["Activo"] = 1;
      if (dtgDirecciones.RowCount == 0)
        e.Fila["NombreDireccion"] = "CASA MATRIZ";
      e.Fila["IdRegion"] = APP_GEN.Global.RegionMetropolitana;
      bolAgregando = true;
      e.Fila["Principal"] = dtgDirecciones.RowCount > 0 ? 0 : 1;
      ValidarFilaDirecciones(e.Fila);
    }

    private void dtgDirecciones_DespuesCambioFila(object sender, FilaGrillaEventArg e) {
      if(bolAgregando && e.FilaDatos != null)
        e.FilaGrilla.Cells[ColComuna.Index].XLlenarDdl(APP_GEN.Global.Cache.TomarVista(ClaseCache.TABLA.Comuna, string.Format("IdRegion ={0}", e.FilaDatos["IdRegion"]), "Comuna"), "Comuna", "Id");
      
    }

    private void dtgDirecciones_DespuesModificarFila(object sender, FilaEventArg e) {
      ValidarFilaDirecciones(e.Fila);
    }

    private void dtgDirecciones_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
      if(e.RowIndex > -1) {
        DataRow dtrFila = dtgDirecciones.FilaActual;
        if(e.ColumnIndex == ColPrincipal.Index) {
          if(dtrFila.XBooleano("Principal")) {
            foreach(DataRowView item in dtgDirecciones.Vista) {
              if(item.Row != dtgDirecciones.FilaActual) {
                item["Principal"] = false;
              }
            }
          }
        } 
        //else if (e.ColumnIndex == ColPais.Index) {
        //  //dtgDirecciones.Rows[e.RowIndex].Cells[ColRegion.Index].XLlenarDdl(APP_GEN.Global.Cache.TomarVista(ClaseCache.TABLA.Region, dtrFila.XEntero("IdPais") == APP_GEN.Global.Chile ? "IdRegion > 0" : "IdRegion = 0", ""), "Region", "IdRegion");
        //  //dtgDirecciones.Rows[e.RowIndex].Cells[ColComuna.Index].XLlenarDdl(APP_GEN.Global.Cache.TomarVista(ClaseCache.TABLA.Comuna, string.Format("IdRegion ={0}", dtrFila.XEntero("IdPais") == APP_GEN.Global.Chile ? dtrFila.XEntero("IdRegion", APP_GEN.Global.RegionMetropolitana) : 0), "Comuna"), "Comuna", "IdComuna");

        //} 
        else if(e.ColumnIndex == ColRegion.Index) {


          dtgDirecciones.Rows[e.RowIndex].Cells[ColComuna.Index].XLlenarDdl(APP_GEN.Global.Cache.TomarVista(ClaseCache.TABLA.Comuna, string.Format("IdRegion ={0}", dtrFila["IdRegion"]), "Comuna"), "Comuna", "Id");

        }
      }
    }

    private void dtgDirecciones_Enter(object sender, EventArgs e) {
      sbpFilas.Text = dtgDirecciones.RowCount.ToString();
    }

    private void dtgDirecciones_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
      if(dtgDirecciones.Vista != null) {
        if(e.ListChangedType == ListChangedType.Reset || e.ListChangedType == ListChangedType.ItemAdded) {
          foreach(DataGridViewRow dgvFila in dtgDirecciones.Rows) {
            DataRow drFila = dgvFila.XTomarDataRow();
            //dgvFila.Cells[ColRegion.Index].XLlenarDdl(APP_GEN.Global.Cache.TomarVista(ClaseCache.TABLA.Region, drFila.XEntero("IdPais") == APP_GEN.Global.Chile ? "IdRegion > 0" : "IdRegion = 0", ""), "Region", "IdRegion");
            dgvFila.Cells[ColComuna.Index].XLlenarDdl(APP_GEN.Global.Cache.TomarVista(ClaseCache.TABLA.Comuna, string.Format("IdRegion = {0}", drFila.XEntero("IdRegion")), "Comuna"), "Comuna", "Id");
          }
        }
      }
    }

    private void dtgDirecciones_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) {
      int columnIndex = dtgDirecciones.CurrentCell.ColumnIndex;
      if(e.Control is TextBox) {
        ((TextBox)e.Control).AutoCompleteCustomSource = null;
        ((TextBox)e.Control).CharacterCasing = CharacterCasing.Normal;
        if (columnIndex.XEnInt(ColNombreDireccion.Index, ColDireccion.Index)) {
          ((TextBox)e.Control).CharacterCasing = CharacterCasing.Upper;
        } else if (columnIndex.XEnInt(ColCiudad.Index)) {
          ((TextBox)e.Control).AutoCompleteCustomSource = CargarAutoCompletado(dtgDirecciones.FilaActual);
          ((TextBox)e.Control).AutoCompleteMode = AutoCompleteMode.Suggest;
          ((TextBox)e.Control).AutoCompleteSource = AutoCompleteSource.CustomSource;

        }
      }
    }

    private void dtgDirecciones_CurrentCellDirtyStateChanged(object sender, EventArgs e) {
      if (dtgDirecciones.CurrentCell is DataGridViewCheckBoxCell || dtgDirecciones.CurrentCell is DataGridViewComboBoxCell) {
        if (dtgDirecciones.IsCurrentCellDirty) {
          dtgDirecciones.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
      }
    }

    private void dtgDirecciones_CellContentClick(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex == -1) return;

    }

    #endregion

    #region Persistencia

    public enum Llaves : int {
      Contactos = 100,
      Direcciones = 200
    }

    protected override void SalvarForma() {
      base.SalvarForma();
      SalvarGrilla(dtgContactos, (int)Llaves.Contactos);
      SalvarGrilla(dtgDirecciones, (int)Llaves.Direcciones);

    }

    protected override void CargarForma() {
      base.CargarForma();
      CargarGrilla(dtgContactos, (int)Llaves.Contactos);
      CargarGrilla(dtgDirecciones, (int)Llaves.Direcciones);
    }

    #endregion

    private void tlsPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

    }

  }
}