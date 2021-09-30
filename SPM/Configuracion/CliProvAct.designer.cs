namespace APP
{
  partial class CliProvAct {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.tlsPrincipal = new System.Windows.Forms.ToolStrip();
      this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
      this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
      this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbActivar = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbReporte = new System.Windows.Forms.ToolStripButton();
      this.dtgDirecciones = new ITD.Win.Grilla(this.components);
      this.ColNombreDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColRegion = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.ColComuna = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.ColCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.ColPrincipal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.dtgContactos = new ITD.Win.Grilla(this.components);
      this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColTelefonoC = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColActivoC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.label1 = new System.Windows.Forms.Label();
      this.rdbSi = new System.Windows.Forms.RadioButton();
      this.rdbNo = new System.Windows.Forms.RadioButton();
      this.lblRut = new System.Windows.Forms.Label();
      this.txtRut = new System.Windows.Forms.TextBox();
      this.lblNombre = new System.Windows.Forms.Label();
      this.txtNombre = new System.Windows.Forms.TextBox();
      this.lblRazon = new System.Windows.Forms.Label();
      this.txtRazonSocial = new System.Windows.Forms.TextBox();
      this.chkCliente = new System.Windows.Forms.CheckBox();
      this.chkProveedor = new System.Windows.Forms.CheckBox();
      this.txtGiro = new System.Windows.Forms.TextBox();
      this.lblTelefono = new System.Windows.Forms.Label();
      this.txtTelefono = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtEmailFact = new System.Windows.Forms.TextBox();
      this.txtFecMod = new System.Windows.Forms.TextBox();
      this.lblEl = new System.Windows.Forms.Label();
      this.txtModificadoPor = new System.Windows.Forms.TextBox();
      this.lblModificadoPor = new System.Windows.Forms.Label();
      this.txtEstado = new System.Windows.Forms.TextBox();
      this.lblEstado = new System.Windows.Forms.Label();
      this.grpDatos = new System.Windows.Forms.GroupBox();
      this.chkGiro = new System.Windows.Forms.CheckBox();
      this.label3 = new System.Windows.Forms.Label();
      this.nudDiasPago = new System.Windows.Forms.NumericUpDown();
      this.splPrincipal = new System.Windows.Forms.SplitContainer();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.chkLoteObligatorio = new System.Windows.Forms.CheckBox();
      this.tlsPrincipal.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgDirecciones)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtgContactos)).BeginInit();
      this.grpDatos.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudDiasPago)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splPrincipal)).BeginInit();
      this.splPrincipal.Panel1.SuspendLayout();
      this.splPrincipal.Panel2.SuspendLayout();
      this.splPrincipal.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // tlsPrincipal
      // 
      this.tlsPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.tlsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar,
            this.tsbEliminar,
            this.toolStripSeparator1,
            this.tsbRefrescar,
            this.toolStripSeparator2,
            this.tsbActivar,
            this.toolStripSeparator3,
            this.tsbReporte});
      this.tlsPrincipal.Location = new System.Drawing.Point(0, 0);
      this.tlsPrincipal.Name = "tlsPrincipal";
      this.tlsPrincipal.Size = new System.Drawing.Size(1040, 27);
      this.tlsPrincipal.TabIndex = 80;
      this.tlsPrincipal.Text = "toolStrip1";
      this.tlsPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tlsPrincipal_ItemClicked);
      // 
      // tsbNuevo
      // 
      this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbNuevo.Image = global::APP.Properties.Resources.Nuevo;
      this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbNuevo.Name = "tsbNuevo";
      this.tsbNuevo.Size = new System.Drawing.Size(24, 24);
      this.tsbNuevo.Text = "Nuevo";
      this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
      // 
      // tsbGuardar
      // 
      this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbGuardar.Image = global::APP.Properties.Resources.grabar;
      this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbGuardar.Name = "tsbGuardar";
      this.tsbGuardar.Size = new System.Drawing.Size(24, 24);
      this.tsbGuardar.Text = "Guardar";
      this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
      // 
      // tsbEliminar
      // 
      this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbEliminar.Image = global::APP.Properties.Resources.Cancelar;
      this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbEliminar.Name = "tsbEliminar";
      this.tsbEliminar.Size = new System.Drawing.Size(24, 24);
      this.tsbEliminar.Text = "Eliminar";
      this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
      // 
      // tsbRefrescar
      // 
      this.tsbRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbRefrescar.Image = global::APP.Properties.Resources.refrescar;
      this.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbRefrescar.Name = "tsbRefrescar";
      this.tsbRefrescar.Size = new System.Drawing.Size(24, 24);
      this.tsbRefrescar.Text = "Refrescar";
      this.tsbRefrescar.Click += new System.EventHandler(this.tsbRefrescar_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
      // 
      // tsbActivar
      // 
      this.tsbActivar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbActivar.Image = global::APP.Properties.Resources.Activar;
      this.tsbActivar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbActivar.Name = "tsbActivar";
      this.tsbActivar.Size = new System.Drawing.Size(24, 24);
      this.tsbActivar.Text = "Activar";
      this.tsbActivar.ToolTipText = "Activar";
      this.tsbActivar.Click += new System.EventHandler(this.tsbActivar_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
      // 
      // tsbReporte
      // 
      this.tsbReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbReporte.Image = global::APP.Properties.Resources.Reporte;
      this.tsbReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbReporte.Name = "tsbReporte";
      this.tsbReporte.Size = new System.Drawing.Size(24, 24);
      this.tsbReporte.ToolTipText = "Ficha del cliente";
      this.tsbReporte.Click += new System.EventHandler(this.tsbReporte_Click);
      // 
      // dtgDirecciones
      // 
      this.dtgDirecciones.AllowUserToAddRows = false;
      this.dtgDirecciones.AllowUserToDeleteRows = false;
      this.dtgDirecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgDirecciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombreDireccion,
            this.ColTelefono,
            this.ColDireccion,
            this.ColRegion,
            this.ColComuna,
            this.ColCiudad,
            this.ColActivo,
            this.ColPrincipal});
      this.dtgDirecciones.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgDirecciones.IdCopia = 0;
      this.dtgDirecciones.Location = new System.Drawing.Point(3, 16);
      this.dtgDirecciones.Name = "dtgDirecciones";
      this.dtgDirecciones.OpcionCopiarVisible = false;
      this.dtgDirecciones.OpcionesActivas = 63;
      this.dtgDirecciones.OpcionesVisibles = 3;
      this.dtgDirecciones.OpcionInmovilizarVisible = false;
      this.dtgDirecciones.OpcionOperacionVisible = false;
      this.dtgDirecciones.OpcionPegarVisible = false;
      this.dtgDirecciones.RefrescandoGrilla = false;
      this.dtgDirecciones.Size = new System.Drawing.Size(1030, 233);
      this.dtgDirecciones.TabIndex = 0;
      this.dtgDirecciones.AntesInsertar += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgDirecciones_AntesInsertar);
      this.dtgDirecciones.DespuesModificarFila += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgDirecciones_DespuesModificarFila);
      this.dtgDirecciones.DespuesCambioFila += new System.EventHandler<ITD.Win.FilaGrillaEventArg>(this.dtgDirecciones_DespuesCambioFila);
      this.dtgDirecciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDirecciones_CellContentClick);
      this.dtgDirecciones.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDirecciones_CellValueChanged);
      this.dtgDirecciones.CurrentCellDirtyStateChanged += new System.EventHandler(this.dtgDirecciones_CurrentCellDirtyStateChanged);
      this.dtgDirecciones.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgDirecciones_DataBindingComplete);
      this.dtgDirecciones.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgDirecciones_EditingControlShowing);
      this.dtgDirecciones.Enter += new System.EventHandler(this.dtgDirecciones_Enter);
      // 
      // ColNombreDireccion
      // 
      this.ColNombreDireccion.DataPropertyName = "NombreDireccion";
      this.ColNombreDireccion.HeaderText = "Nombre";
      this.ColNombreDireccion.MaxInputLength = 50;
      this.ColNombreDireccion.Name = "ColNombreDireccion";
      this.ColNombreDireccion.Width = 150;
      // 
      // ColTelefono
      // 
      this.ColTelefono.DataPropertyName = "Telefono";
      this.ColTelefono.HeaderText = "Teléfono";
      this.ColTelefono.MaxInputLength = 50;
      this.ColTelefono.Name = "ColTelefono";
      // 
      // ColDireccion
      // 
      this.ColDireccion.DataPropertyName = "Direccion";
      this.ColDireccion.HeaderText = "Dirección";
      this.ColDireccion.MaxInputLength = 150;
      this.ColDireccion.Name = "ColDireccion";
      this.ColDireccion.Width = 150;
      // 
      // ColRegion
      // 
      this.ColRegion.DataPropertyName = "IdRegion";
      this.ColRegion.DisplayStyleForCurrentCellOnly = true;
      this.ColRegion.HeaderText = "Region";
      this.ColRegion.Name = "ColRegion";
      this.ColRegion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.ColRegion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.ColRegion.Width = 150;
      // 
      // ColComuna
      // 
      this.ColComuna.DataPropertyName = "IdComuna";
      this.ColComuna.DisplayStyleForCurrentCellOnly = true;
      this.ColComuna.HeaderText = "Comuna";
      this.ColComuna.Name = "ColComuna";
      this.ColComuna.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.ColComuna.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.ColComuna.Width = 120;
      // 
      // ColCiudad
      // 
      this.ColCiudad.DataPropertyName = "Ciudad";
      this.ColCiudad.HeaderText = "Ciudad";
      this.ColCiudad.Name = "ColCiudad";
      this.ColCiudad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.ColCiudad.Width = 120;
      // 
      // ColActivo
      // 
      this.ColActivo.DataPropertyName = "Activo";
      this.ColActivo.HeaderText = "Activo";
      this.ColActivo.Name = "ColActivo";
      this.ColActivo.Width = 60;
      // 
      // ColPrincipal
      // 
      this.ColPrincipal.DataPropertyName = "Principal";
      this.ColPrincipal.HeaderText = "Principal";
      this.ColPrincipal.Name = "ColPrincipal";
      this.ColPrincipal.Width = 70;
      // 
      // dtgContactos
      // 
      this.dtgContactos.AllowUserToAddRows = false;
      this.dtgContactos.AllowUserToDeleteRows = false;
      this.dtgContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgContactos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombre,
            this.ColTelefonoC,
            this.ColCelular,
            this.ColEmail,
            this.ColActivoC});
      this.dtgContactos.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgContactos.IdCopia = 0;
      this.dtgContactos.Location = new System.Drawing.Point(3, 16);
      this.dtgContactos.Name = "dtgContactos";
      this.dtgContactos.OpcionCopiarVisible = false;
      this.dtgContactos.OpcionesActivas = 63;
      this.dtgContactos.OpcionesVisibles = 3;
      this.dtgContactos.OpcionInmovilizarVisible = false;
      this.dtgContactos.OpcionOperacionVisible = false;
      this.dtgContactos.OpcionPegarVisible = false;
      this.dtgContactos.RefrescandoGrilla = false;
      this.dtgContactos.Size = new System.Drawing.Size(623, 229);
      this.dtgContactos.TabIndex = 0;
      this.dtgContactos.AntesInsertar += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgContactos_AntesInsertar);
      this.dtgContactos.DespuesModificarFila += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgContactos_DespuesModificarFila);
      this.dtgContactos.Enter += new System.EventHandler(this.dtgContactos_Enter);
      // 
      // ColNombre
      // 
      this.ColNombre.DataPropertyName = "Nombre";
      this.ColNombre.HeaderText = "Nombre";
      this.ColNombre.MaxInputLength = 50;
      this.ColNombre.Name = "ColNombre";
      this.ColNombre.Width = 180;
      // 
      // ColTelefonoC
      // 
      this.ColTelefonoC.DataPropertyName = "Telefono";
      this.ColTelefonoC.HeaderText = "Teléfono";
      this.ColTelefonoC.MaxInputLength = 50;
      this.ColTelefonoC.Name = "ColTelefonoC";
      // 
      // ColCelular
      // 
      this.ColCelular.DataPropertyName = "Celular";
      this.ColCelular.HeaderText = "Celular";
      this.ColCelular.MaxInputLength = 20;
      this.ColCelular.Name = "ColCelular";
      // 
      // ColEmail
      // 
      this.ColEmail.DataPropertyName = "Email";
      this.ColEmail.HeaderText = "Email";
      this.ColEmail.MaxInputLength = 150;
      this.ColEmail.Name = "ColEmail";
      // 
      // ColActivoC
      // 
      this.ColActivoC.DataPropertyName = "Activo";
      this.ColActivoC.HeaderText = "Activo";
      this.ColActivoC.Name = "ColActivoC";
      this.ColActivoC.Width = 60;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(54, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Tiene Rut";
      // 
      // rdbSi
      // 
      this.rdbSi.AutoSize = true;
      this.rdbSi.Checked = true;
      this.rdbSi.Location = new System.Drawing.Point(101, 21);
      this.rdbSi.Name = "rdbSi";
      this.rdbSi.Size = new System.Drawing.Size(34, 17);
      this.rdbSi.TabIndex = 1;
      this.rdbSi.TabStop = true;
      this.rdbSi.Text = "Si";
      this.rdbSi.UseVisualStyleBackColor = true;
      this.rdbSi.CheckedChanged += new System.EventHandler(this.rdbSi_CheckedChanged);
      // 
      // rdbNo
      // 
      this.rdbNo.AutoSize = true;
      this.rdbNo.Location = new System.Drawing.Point(141, 21);
      this.rdbNo.Name = "rdbNo";
      this.rdbNo.Size = new System.Drawing.Size(39, 17);
      this.rdbNo.TabIndex = 2;
      this.rdbNo.Text = "No";
      this.rdbNo.UseVisualStyleBackColor = true;
      this.rdbNo.CheckedChanged += new System.EventHandler(this.rdbNo_CheckedChanged);
      // 
      // lblRut
      // 
      this.lblRut.AutoSize = true;
      this.lblRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblRut.Location = new System.Drawing.Point(9, 44);
      this.lblRut.Name = "lblRut";
      this.lblRut.Size = new System.Drawing.Size(24, 13);
      this.lblRut.TabIndex = 3;
      this.lblRut.Text = "Rut";
      // 
      // txtRut
      // 
      this.txtRut.Location = new System.Drawing.Point(101, 40);
      this.txtRut.MaxLength = 12;
      this.txtRut.Name = "txtRut";
      this.txtRut.Size = new System.Drawing.Size(127, 20);
      this.txtRut.TabIndex = 4;
      this.txtRut.Validating += new System.ComponentModel.CancelEventHandler(this.txtRut_Validating);
      // 
      // lblNombre
      // 
      this.lblNombre.AutoSize = true;
      this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNombre.Location = new System.Drawing.Point(9, 66);
      this.lblNombre.Name = "lblNombre";
      this.lblNombre.Size = new System.Drawing.Size(44, 13);
      this.lblNombre.TabIndex = 7;
      this.lblNombre.Text = "Nombre";
      // 
      // txtNombre
      // 
      this.txtNombre.Location = new System.Drawing.Point(101, 62);
      this.txtNombre.MaxLength = 100;
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new System.Drawing.Size(295, 20);
      this.txtNombre.TabIndex = 8;
      // 
      // lblRazon
      // 
      this.lblRazon.AutoSize = true;
      this.lblRazon.Location = new System.Drawing.Point(9, 88);
      this.lblRazon.Name = "lblRazon";
      this.lblRazon.Size = new System.Drawing.Size(68, 13);
      this.lblRazon.TabIndex = 9;
      this.lblRazon.Text = "Razón social";
      // 
      // txtRazonSocial
      // 
      this.txtRazonSocial.Location = new System.Drawing.Point(101, 84);
      this.txtRazonSocial.MaxLength = 100;
      this.txtRazonSocial.Name = "txtRazonSocial";
      this.txtRazonSocial.Size = new System.Drawing.Size(295, 20);
      this.txtRazonSocial.TabIndex = 10;
      // 
      // chkCliente
      // 
      this.chkCliente.AutoSize = true;
      this.chkCliente.Checked = true;
      this.chkCliente.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkCliente.Location = new System.Drawing.Point(257, 42);
      this.chkCliente.Name = "chkCliente";
      this.chkCliente.Size = new System.Drawing.Size(58, 17);
      this.chkCliente.TabIndex = 5;
      this.chkCliente.Text = "Cliente";
      this.chkCliente.UseVisualStyleBackColor = true;
      // 
      // chkProveedor
      // 
      this.chkProveedor.AutoSize = true;
      this.chkProveedor.Location = new System.Drawing.Point(321, 42);
      this.chkProveedor.Name = "chkProveedor";
      this.chkProveedor.Size = new System.Drawing.Size(75, 17);
      this.chkProveedor.TabIndex = 6;
      this.chkProveedor.Text = "Proveedor";
      this.chkProveedor.UseVisualStyleBackColor = true;
      // 
      // txtGiro
      // 
      this.txtGiro.Location = new System.Drawing.Point(101, 106);
      this.txtGiro.MaxLength = 100;
      this.txtGiro.Name = "txtGiro";
      this.txtGiro.Size = new System.Drawing.Size(295, 20);
      this.txtGiro.TabIndex = 12;
      // 
      // lblTelefono
      // 
      this.lblTelefono.AutoSize = true;
      this.lblTelefono.Location = new System.Drawing.Point(9, 154);
      this.lblTelefono.Name = "lblTelefono";
      this.lblTelefono.Size = new System.Drawing.Size(49, 13);
      this.lblTelefono.TabIndex = 15;
      this.lblTelefono.Text = "Teléfono";
      // 
      // txtTelefono
      // 
      this.txtTelefono.Location = new System.Drawing.Point(101, 150);
      this.txtTelefono.MaxLength = 50;
      this.txtTelefono.Name = "txtTelefono";
      this.txtTelefono.Size = new System.Drawing.Size(157, 20);
      this.txtTelefono.TabIndex = 16;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(9, 132);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(88, 13);
      this.label2.TabIndex = 13;
      this.label2.Text = "Email facturación";
      this.tttPrincipal.SetToolTip(this.label2, "Email de facturación");
      // 
      // txtEmailFact
      // 
      this.txtEmailFact.Location = new System.Drawing.Point(101, 128);
      this.txtEmailFact.MaxLength = 150;
      this.txtEmailFact.Name = "txtEmailFact";
      this.txtEmailFact.Size = new System.Drawing.Size(295, 20);
      this.txtEmailFact.TabIndex = 14;
      // 
      // txtFecMod
      // 
      this.txtFecMod.Enabled = false;
      this.txtFecMod.Location = new System.Drawing.Point(282, 216);
      this.txtFecMod.MaxLength = 9;
      this.txtFecMod.Name = "txtFecMod";
      this.txtFecMod.ReadOnly = true;
      this.txtFecMod.Size = new System.Drawing.Size(114, 20);
      this.txtFecMod.TabIndex = 30;
      this.txtFecMod.TabStop = false;
      // 
      // lblEl
      // 
      this.lblEl.AutoSize = true;
      this.lblEl.Location = new System.Drawing.Point(243, 220);
      this.lblEl.Name = "lblEl";
      this.lblEl.Size = new System.Drawing.Size(15, 13);
      this.lblEl.TabIndex = 29;
      this.lblEl.Text = "el";
      // 
      // txtModificadoPor
      // 
      this.txtModificadoPor.Enabled = false;
      this.txtModificadoPor.Location = new System.Drawing.Point(101, 216);
      this.txtModificadoPor.MaxLength = 9;
      this.txtModificadoPor.Name = "txtModificadoPor";
      this.txtModificadoPor.ReadOnly = true;
      this.txtModificadoPor.Size = new System.Drawing.Size(124, 20);
      this.txtModificadoPor.TabIndex = 28;
      this.txtModificadoPor.TabStop = false;
      // 
      // lblModificadoPor
      // 
      this.lblModificadoPor.AutoSize = true;
      this.lblModificadoPor.Location = new System.Drawing.Point(9, 220);
      this.lblModificadoPor.Name = "lblModificadoPor";
      this.lblModificadoPor.Size = new System.Drawing.Size(77, 13);
      this.lblModificadoPor.TabIndex = 27;
      this.lblModificadoPor.Text = "Modificado por";
      // 
      // txtEstado
      // 
      this.txtEstado.Enabled = false;
      this.txtEstado.Location = new System.Drawing.Point(101, 194);
      this.txtEstado.MaxLength = 9;
      this.txtEstado.Name = "txtEstado";
      this.txtEstado.ReadOnly = true;
      this.txtEstado.Size = new System.Drawing.Size(124, 20);
      this.txtEstado.TabIndex = 26;
      this.txtEstado.TabStop = false;
      // 
      // lblEstado
      // 
      this.lblEstado.AutoSize = true;
      this.lblEstado.Location = new System.Drawing.Point(9, 198);
      this.lblEstado.Name = "lblEstado";
      this.lblEstado.Size = new System.Drawing.Size(40, 13);
      this.lblEstado.TabIndex = 25;
      this.lblEstado.Text = "Estado";
      // 
      // grpDatos
      // 
      this.grpDatos.Controls.Add(this.chkLoteObligatorio);
      this.grpDatos.Controls.Add(this.chkGiro);
      this.grpDatos.Controls.Add(this.label3);
      this.grpDatos.Controls.Add(this.nudDiasPago);
      this.grpDatos.Controls.Add(this.label1);
      this.grpDatos.Controls.Add(this.rdbSi);
      this.grpDatos.Controls.Add(this.lblModificadoPor);
      this.grpDatos.Controls.Add(this.txtFecMod);
      this.grpDatos.Controls.Add(this.lblEl);
      this.grpDatos.Controls.Add(this.rdbNo);
      this.grpDatos.Controls.Add(this.txtModificadoPor);
      this.grpDatos.Controls.Add(this.txtRut);
      this.grpDatos.Controls.Add(this.lblRut);
      this.grpDatos.Controls.Add(this.lblNombre);
      this.grpDatos.Controls.Add(this.lblEstado);
      this.grpDatos.Controls.Add(this.txtEstado);
      this.grpDatos.Controls.Add(this.txtNombre);
      this.grpDatos.Controls.Add(this.txtRazonSocial);
      this.grpDatos.Controls.Add(this.chkProveedor);
      this.grpDatos.Controls.Add(this.lblTelefono);
      this.grpDatos.Controls.Add(this.chkCliente);
      this.grpDatos.Controls.Add(this.txtTelefono);
      this.grpDatos.Controls.Add(this.label2);
      this.grpDatos.Controls.Add(this.txtEmailFact);
      this.grpDatos.Controls.Add(this.txtGiro);
      this.grpDatos.Controls.Add(this.lblRazon);
      this.grpDatos.Dock = System.Windows.Forms.DockStyle.Left;
      this.grpDatos.Location = new System.Drawing.Point(0, 0);
      this.grpDatos.Name = "grpDatos";
      this.grpDatos.Size = new System.Drawing.Size(407, 248);
      this.grpDatos.TabIndex = 0;
      this.grpDatos.TabStop = false;
      this.grpDatos.Text = "Datos generales";
      // 
      // chkGiro
      // 
      this.chkGiro.AutoSize = true;
      this.chkGiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chkGiro.Location = new System.Drawing.Point(9, 108);
      this.chkGiro.Name = "chkGiro";
      this.chkGiro.Size = new System.Drawing.Size(45, 17);
      this.chkGiro.TabIndex = 11;
      this.chkGiro.Text = "Giro";
      this.chkGiro.UseVisualStyleBackColor = true;
      this.chkGiro.CheckedChanged += new System.EventHandler(this.chkGiro_CheckedChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(9, 176);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(57, 13);
      this.label3.TabIndex = 23;
      this.label3.Text = "Días pago";
      // 
      // nudDiasPago
      // 
      this.nudDiasPago.Location = new System.Drawing.Point(101, 172);
      this.nudDiasPago.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.nudDiasPago.Name = "nudDiasPago";
      this.nudDiasPago.Size = new System.Drawing.Size(69, 20);
      this.nudDiasPago.TabIndex = 22;
      // 
      // splPrincipal
      // 
      this.splPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.splPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splPrincipal.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splPrincipal.Location = new System.Drawing.Point(0, 27);
      this.splPrincipal.Name = "splPrincipal";
      this.splPrincipal.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splPrincipal.Panel1
      // 
      this.splPrincipal.Panel1.Controls.Add(this.groupBox2);
      this.splPrincipal.Panel1.Controls.Add(this.grpDatos);
      // 
      // splPrincipal.Panel2
      // 
      this.splPrincipal.Panel2.Controls.Add(this.groupBox3);
      this.splPrincipal.Size = new System.Drawing.Size(1040, 512);
      this.splPrincipal.SplitterDistance = 252;
      this.splPrincipal.TabIndex = 84;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.dtgContactos);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox2.Location = new System.Drawing.Point(407, 0);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(629, 248);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Contactos";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.dtgDirecciones);
      this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox3.Location = new System.Drawing.Point(0, 0);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(1036, 252);
      this.groupBox3.TabIndex = 2;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Direcciones";
      // 
      // chkLoteObligatorio
      // 
      this.chkLoteObligatorio.AutoSize = true;
      this.chkLoteObligatorio.Location = new System.Drawing.Point(264, 152);
      this.chkLoteObligatorio.Name = "chkLoteObligatorio";
      this.chkLoteObligatorio.Size = new System.Drawing.Size(100, 17);
      this.chkLoteObligatorio.TabIndex = 31;
      this.chkLoteObligatorio.Text = "Lote Obligatorio";
      this.chkLoteObligatorio.UseVisualStyleBackColor = true;
      // 
      // CliProvAct
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.ClientSize = new System.Drawing.Size(1040, 561);
      this.Controls.Add(this.splPrincipal);
      this.Controls.Add(this.tlsPrincipal);
      this.EnterComoTab = true;
      this.KeyPreview = true;
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "CliProvAct";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Ingreso de clientes/proveedores";
      this.Load += new System.EventHandler(this.ClientesDatos_Load);
      this.Controls.SetChildIndex(this.tlsPrincipal, 0);
      this.Controls.SetChildIndex(this.splPrincipal, 0);
      this.tlsPrincipal.ResumeLayout(false);
      this.tlsPrincipal.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgDirecciones)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtgContactos)).EndInit();
      this.grpDatos.ResumeLayout(false);
      this.grpDatos.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudDiasPago)).EndInit();
      this.splPrincipal.Panel1.ResumeLayout(false);
      this.splPrincipal.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splPrincipal)).EndInit();
      this.splPrincipal.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip tlsPrincipal;
    private System.Windows.Forms.ToolStripButton tsbGuardar;
    private System.Windows.Forms.ToolStripButton tsbEliminar;
    private System.Windows.Forms.ToolStripButton tsbNuevo;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton tsbReporte;
    private System.Windows.Forms.ToolStripButton tsbRefrescar;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton tsbActivar;
    private System.Windows.Forms.TextBox txtEmailFact;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtTelefono;
    private System.Windows.Forms.Label lblTelefono;
    private System.Windows.Forms.TextBox txtGiro;
    private System.Windows.Forms.CheckBox chkProveedor;
    private System.Windows.Forms.CheckBox chkCliente;
    private System.Windows.Forms.TextBox txtRazonSocial;
    private System.Windows.Forms.Label lblRazon;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.Label lblNombre;
    private System.Windows.Forms.TextBox txtRut;
    private System.Windows.Forms.Label lblRut;
    private System.Windows.Forms.RadioButton rdbNo;
    private System.Windows.Forms.RadioButton rdbSi;
    private System.Windows.Forms.Label label1;
    private ITD.Win.Grilla dtgDirecciones;
    private ITD.Win.Grilla dtgContactos;
    private System.Windows.Forms.TextBox txtFecMod;
    private System.Windows.Forms.Label lblEl;
    private System.Windows.Forms.TextBox txtModificadoPor;
    private System.Windows.Forms.Label lblModificadoPor;
    private System.Windows.Forms.TextBox txtEstado;
    private System.Windows.Forms.Label lblEstado;
    private System.Windows.Forms.GroupBox grpDatos;
    private System.Windows.Forms.SplitContainer splPrincipal;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown nudDiasPago;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefonoC;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColCelular;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
    private System.Windows.Forms.DataGridViewCheckBoxColumn ColActivoC;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.CheckBox chkGiro;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreDireccion;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefono;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColDireccion;
    private System.Windows.Forms.DataGridViewComboBoxColumn ColRegion;
    private System.Windows.Forms.DataGridViewComboBoxColumn ColComuna;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColCiudad;
    private System.Windows.Forms.DataGridViewCheckBoxColumn ColActivo;
    private System.Windows.Forms.DataGridViewCheckBoxColumn ColPrincipal;
    private System.Windows.Forms.CheckBox chkLoteObligatorio;
  }
}
