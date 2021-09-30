namespace APP {
  partial class MantencionDetCons {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantencionDetCons));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.menuItem = new System.Windows.Forms.ToolStrip();
      this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
      this.tsbModificar = new System.Windows.Forms.ToolStripButton();
      this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbFiltrar = new System.Windows.Forms.ToolStripButton();
      this.tsbQuitarFiltro = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbMostrarFiltros = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.ddlReporte = new System.Windows.Forms.ToolStripComboBox();
      this.tsbReporte = new System.Windows.Forms.ToolStripButton();
      this.pnlPrincipal = new System.Windows.Forms.Panel();
      this.txtUsuarioMod = new System.Windows.Forms.TextBox();
      this.ddlUsuarioMod = new System.Windows.Forms.ComboBox();
      this.chkUsuarioMod = new System.Windows.Forms.CheckBox();
      this.txtUsuario = new System.Windows.Forms.TextBox();
      this.ddlUsuario = new System.Windows.Forms.ComboBox();
      this.chkUsuario = new System.Windows.Forms.CheckBox();
      this.txtActividad = new System.Windows.Forms.TextBox();
      this.ddlActividad = new System.Windows.Forms.ComboBox();
      this.chkAcividad = new System.Windows.Forms.CheckBox();
      this.txtNumero = new System.Windows.Forms.TextBox();
      this.ddlNumero = new System.Windows.Forms.ComboBox();
      this.chkNumero = new System.Windows.Forms.CheckBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
      this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
      this.chkFechaHasta = new System.Windows.Forms.CheckBox();
      this.chkFechaDesde = new System.Windows.Forms.CheckBox();
      this.ddlFechaHasta = new System.Windows.Forms.ComboBox();
      this.ddlFechaDesde = new System.Windows.Forms.ComboBox();
      this.ddlPlanta = new System.Windows.Forms.ComboBox();
      this.chkPlanta = new System.Windows.Forms.CheckBox();
      this.lstEstado = new System.Windows.Forms.ListBox();
      this.chkEstado = new System.Windows.Forms.CheckBox();
      this.ddlEstado = new System.Windows.Forms.ComboBox();
      this.dtgPrincipal = new ITD.Win.Grilla(this.components);
      this.ColNombrePlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colNombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colFechaCrea = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colFechaMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColUsuarioMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dtgTotal = new ITD.Win.GrillaTotal();
      this.menuItem.SuspendLayout();
      this.pnlPrincipal.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
      this.SuspendLayout();
      // 
      // menuItem
      // 
      this.menuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbModificar,
            this.tsbEliminar,
            this.toolStripSeparator1,
            this.tsbFiltrar,
            this.tsbQuitarFiltro,
            this.toolStripSeparator3,
            this.tsbMostrarFiltros,
            this.toolStripSeparator2,
            this.ddlReporte,
            this.tsbReporte});
      this.menuItem.Location = new System.Drawing.Point(0, 0);
      this.menuItem.Name = "menuItem";
      this.menuItem.Size = new System.Drawing.Size(1104, 25);
      this.menuItem.TabIndex = 6;
      this.menuItem.Text = "toolStrip1";
      // 
      // tsbNuevo
      // 
      this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbNuevo.Image = global::APP.Properties.Resources.Nuevo;
      this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbNuevo.Name = "tsbNuevo";
      this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
      this.tsbNuevo.Text = "Nuevo";
      this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
      // 
      // tsbModificar
      // 
      this.tsbModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbModificar.Image = global::APP.Properties.Resources.modificar;
      this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbModificar.Name = "tsbModificar";
      this.tsbModificar.Size = new System.Drawing.Size(23, 22);
      this.tsbModificar.Text = "Modificar";
      this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
      // 
      // tsbEliminar
      // 
      this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbEliminar.Image = global::APP.Properties.Resources.Cancelar;
      this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbEliminar.Name = "tsbEliminar";
      this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
      this.tsbEliminar.Text = "Eliminar";
      this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // tsbFiltrar
      // 
      this.tsbFiltrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbFiltrar.Image")));
      this.tsbFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbFiltrar.Name = "tsbFiltrar";
      this.tsbFiltrar.Size = new System.Drawing.Size(23, 22);
      this.tsbFiltrar.Text = "Filtrar";
      this.tsbFiltrar.Click += new System.EventHandler(this.tsbFiltrar_Click);
      // 
      // tsbQuitarFiltro
      // 
      this.tsbQuitarFiltro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbQuitarFiltro.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuitarFiltro.Image")));
      this.tsbQuitarFiltro.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbQuitarFiltro.Name = "tsbQuitarFiltro";
      this.tsbQuitarFiltro.Size = new System.Drawing.Size(23, 22);
      this.tsbQuitarFiltro.Text = "Quitar filtro";
      this.tsbQuitarFiltro.Click += new System.EventHandler(this.tsbQuitarFiltro_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
      // 
      // tsbMostrarFiltros
      // 
      this.tsbMostrarFiltros.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbMostrarFiltros.Image = ((System.Drawing.Image)(resources.GetObject("tsbMostrarFiltros.Image")));
      this.tsbMostrarFiltros.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbMostrarFiltros.Name = "tsbMostrarFiltros";
      this.tsbMostrarFiltros.Size = new System.Drawing.Size(23, 22);
      this.tsbMostrarFiltros.Text = "Ocultar filtros";
      this.tsbMostrarFiltros.Click += new System.EventHandler(this.tsbMostrarFiltros_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // ddlReporte
      // 
      this.ddlReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlReporte.Items.AddRange(new object[] {
            "Listado",
            "Guía de recepción"});
      this.ddlReporte.Name = "ddlReporte";
      this.ddlReporte.Size = new System.Drawing.Size(121, 25);
      // 
      // tsbReporte
      // 
      this.tsbReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbReporte.Image = ((System.Drawing.Image)(resources.GetObject("tsbReporte.Image")));
      this.tsbReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbReporte.Name = "tsbReporte";
      this.tsbReporte.Size = new System.Drawing.Size(23, 22);
      this.tsbReporte.Text = "Reporte";
      this.tsbReporte.Click += new System.EventHandler(this.tsbReporte_Click);
      // 
      // pnlPrincipal
      // 
      this.pnlPrincipal.AutoScroll = true;
      this.pnlPrincipal.Controls.Add(this.txtUsuarioMod);
      this.pnlPrincipal.Controls.Add(this.ddlUsuarioMod);
      this.pnlPrincipal.Controls.Add(this.chkUsuarioMod);
      this.pnlPrincipal.Controls.Add(this.txtUsuario);
      this.pnlPrincipal.Controls.Add(this.ddlUsuario);
      this.pnlPrincipal.Controls.Add(this.chkUsuario);
      this.pnlPrincipal.Controls.Add(this.txtActividad);
      this.pnlPrincipal.Controls.Add(this.ddlActividad);
      this.pnlPrincipal.Controls.Add(this.chkAcividad);
      this.pnlPrincipal.Controls.Add(this.txtNumero);
      this.pnlPrincipal.Controls.Add(this.ddlNumero);
      this.pnlPrincipal.Controls.Add(this.chkNumero);
      this.pnlPrincipal.Controls.Add(this.groupBox1);
      this.pnlPrincipal.Controls.Add(this.ddlPlanta);
      this.pnlPrincipal.Controls.Add(this.chkPlanta);
      this.pnlPrincipal.Controls.Add(this.lstEstado);
      this.pnlPrincipal.Controls.Add(this.chkEstado);
      this.pnlPrincipal.Controls.Add(this.ddlEstado);
      this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlPrincipal.Location = new System.Drawing.Point(0, 25);
      this.pnlPrincipal.Name = "pnlPrincipal";
      this.pnlPrincipal.Size = new System.Drawing.Size(1104, 180);
      this.pnlPrincipal.TabIndex = 7;
      // 
      // txtUsuarioMod
      // 
      this.txtUsuarioMod.Location = new System.Drawing.Point(143, 116);
      this.txtUsuarioMod.Name = "txtUsuarioMod";
      this.txtUsuarioMod.Size = new System.Drawing.Size(154, 20);
      this.txtUsuarioMod.TabIndex = 102;
      // 
      // ddlUsuarioMod
      // 
      this.ddlUsuarioMod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlUsuarioMod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlUsuarioMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlUsuarioMod.FormattingEnabled = true;
      this.ddlUsuarioMod.Location = new System.Drawing.Point(98, 115);
      this.ddlUsuarioMod.Name = "ddlUsuarioMod";
      this.ddlUsuarioMod.Size = new System.Drawing.Size(40, 21);
      this.ddlUsuarioMod.TabIndex = 101;
      // 
      // chkUsuarioMod
      // 
      this.chkUsuarioMod.AutoSize = true;
      this.chkUsuarioMod.Location = new System.Drawing.Point(12, 117);
      this.chkUsuarioMod.Name = "chkUsuarioMod";
      this.chkUsuarioMod.Size = new System.Drawing.Size(83, 17);
      this.chkUsuarioMod.TabIndex = 100;
      this.chkUsuarioMod.Text = "UsuarioMod";
      this.chkUsuarioMod.UseVisualStyleBackColor = true;
      // 
      // txtUsuario
      // 
      this.txtUsuario.Location = new System.Drawing.Point(143, 92);
      this.txtUsuario.Name = "txtUsuario";
      this.txtUsuario.Size = new System.Drawing.Size(154, 20);
      this.txtUsuario.TabIndex = 99;
      // 
      // ddlUsuario
      // 
      this.ddlUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlUsuario.FormattingEnabled = true;
      this.ddlUsuario.Location = new System.Drawing.Point(98, 91);
      this.ddlUsuario.Name = "ddlUsuario";
      this.ddlUsuario.Size = new System.Drawing.Size(40, 21);
      this.ddlUsuario.TabIndex = 98;
      // 
      // chkUsuario
      // 
      this.chkUsuario.AutoSize = true;
      this.chkUsuario.Location = new System.Drawing.Point(12, 93);
      this.chkUsuario.Name = "chkUsuario";
      this.chkUsuario.Size = new System.Drawing.Size(62, 17);
      this.chkUsuario.TabIndex = 97;
      this.chkUsuario.Text = "Usuario";
      this.chkUsuario.UseVisualStyleBackColor = true;
      // 
      // txtActividad
      // 
      this.txtActividad.Location = new System.Drawing.Point(143, 68);
      this.txtActividad.Name = "txtActividad";
      this.txtActividad.Size = new System.Drawing.Size(154, 20);
      this.txtActividad.TabIndex = 96;
      // 
      // ddlActividad
      // 
      this.ddlActividad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlActividad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlActividad.FormattingEnabled = true;
      this.ddlActividad.Location = new System.Drawing.Point(98, 67);
      this.ddlActividad.Name = "ddlActividad";
      this.ddlActividad.Size = new System.Drawing.Size(40, 21);
      this.ddlActividad.TabIndex = 95;
      // 
      // chkAcividad
      // 
      this.chkAcividad.AutoSize = true;
      this.chkAcividad.Location = new System.Drawing.Point(12, 69);
      this.chkAcividad.Name = "chkAcividad";
      this.chkAcividad.Size = new System.Drawing.Size(70, 17);
      this.chkAcividad.TabIndex = 94;
      this.chkAcividad.Text = "Actividad";
      this.chkAcividad.UseVisualStyleBackColor = true;
      // 
      // txtNumero
      // 
      this.txtNumero.Location = new System.Drawing.Point(143, 44);
      this.txtNumero.Name = "txtNumero";
      this.txtNumero.Size = new System.Drawing.Size(154, 20);
      this.txtNumero.TabIndex = 93;
      // 
      // ddlNumero
      // 
      this.ddlNumero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlNumero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlNumero.FormattingEnabled = true;
      this.ddlNumero.Location = new System.Drawing.Point(98, 43);
      this.ddlNumero.Name = "ddlNumero";
      this.ddlNumero.Size = new System.Drawing.Size(40, 21);
      this.ddlNumero.TabIndex = 92;
      // 
      // chkNumero
      // 
      this.chkNumero.AutoSize = true;
      this.chkNumero.Location = new System.Drawing.Point(12, 45);
      this.chkNumero.Name = "chkNumero";
      this.chkNumero.Size = new System.Drawing.Size(63, 17);
      this.chkNumero.TabIndex = 91;
      this.chkNumero.Text = "Numero";
      this.chkNumero.UseVisualStyleBackColor = true;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.dtpFechaHasta);
      this.groupBox1.Controls.Add(this.dtpFechaDesde);
      this.groupBox1.Controls.Add(this.chkFechaHasta);
      this.groupBox1.Controls.Add(this.chkFechaDesde);
      this.groupBox1.Controls.Add(this.ddlFechaHasta);
      this.groupBox1.Controls.Add(this.ddlFechaDesde);
      this.groupBox1.Location = new System.Drawing.Point(336, 19);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(246, 65);
      this.groupBox1.TabIndex = 90;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Fecha";
      // 
      // dtpFechaHasta
      // 
      this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpFechaHasta.Location = new System.Drawing.Point(132, 37);
      this.dtpFechaHasta.Name = "dtpFechaHasta";
      this.dtpFechaHasta.Size = new System.Drawing.Size(96, 20);
      this.dtpFechaHasta.TabIndex = 6;
      // 
      // dtpFechaDesde
      // 
      this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpFechaDesde.Location = new System.Drawing.Point(131, 13);
      this.dtpFechaDesde.Name = "dtpFechaDesde";
      this.dtpFechaDesde.Size = new System.Drawing.Size(96, 20);
      this.dtpFechaDesde.TabIndex = 3;
      // 
      // chkFechaHasta
      // 
      this.chkFechaHasta.AutoSize = true;
      this.chkFechaHasta.Location = new System.Drawing.Point(3, 39);
      this.chkFechaHasta.Name = "chkFechaHasta";
      this.chkFechaHasta.Size = new System.Drawing.Size(54, 17);
      this.chkFechaHasta.TabIndex = 4;
      this.chkFechaHasta.Text = "Hasta";
      this.chkFechaHasta.UseVisualStyleBackColor = true;
      // 
      // chkFechaDesde
      // 
      this.chkFechaDesde.AutoSize = true;
      this.chkFechaDesde.Location = new System.Drawing.Point(3, 17);
      this.chkFechaDesde.Name = "chkFechaDesde";
      this.chkFechaDesde.Size = new System.Drawing.Size(57, 17);
      this.chkFechaDesde.TabIndex = 1;
      this.chkFechaDesde.Text = "Desde";
      this.chkFechaDesde.UseVisualStyleBackColor = true;
      // 
      // ddlFechaHasta
      // 
      this.ddlFechaHasta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlFechaHasta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlFechaHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlFechaHasta.FormattingEnabled = true;
      this.ddlFechaHasta.Location = new System.Drawing.Point(86, 37);
      this.ddlFechaHasta.Name = "ddlFechaHasta";
      this.ddlFechaHasta.Size = new System.Drawing.Size(40, 21);
      this.ddlFechaHasta.TabIndex = 5;
      // 
      // ddlFechaDesde
      // 
      this.ddlFechaDesde.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlFechaDesde.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlFechaDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlFechaDesde.FormattingEnabled = true;
      this.ddlFechaDesde.Location = new System.Drawing.Point(86, 12);
      this.ddlFechaDesde.Name = "ddlFechaDesde";
      this.ddlFechaDesde.Size = new System.Drawing.Size(40, 21);
      this.ddlFechaDesde.TabIndex = 2;
      // 
      // ddlPlanta
      // 
      this.ddlPlanta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlPlanta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlPlanta.DisplayMember = "Planta";
      this.ddlPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlPlanta.FormattingEnabled = true;
      this.ddlPlanta.Location = new System.Drawing.Point(98, 19);
      this.ddlPlanta.Name = "ddlPlanta";
      this.ddlPlanta.Size = new System.Drawing.Size(199, 21);
      this.ddlPlanta.TabIndex = 82;
      this.ddlPlanta.ValueMember = "Id";
      // 
      // chkPlanta
      // 
      this.chkPlanta.AutoSize = true;
      this.chkPlanta.Location = new System.Drawing.Point(12, 21);
      this.chkPlanta.Name = "chkPlanta";
      this.chkPlanta.Size = new System.Drawing.Size(56, 17);
      this.chkPlanta.TabIndex = 81;
      this.chkPlanta.Text = "Planta";
      this.chkPlanta.UseVisualStyleBackColor = true;
      // 
      // lstEstado
      // 
      this.lstEstado.DisplayMember = "Estado";
      this.lstEstado.FormattingEnabled = true;
      this.lstEstado.Location = new System.Drawing.Point(621, 43);
      this.lstEstado.Name = "lstEstado";
      this.lstEstado.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.lstEstado.Size = new System.Drawing.Size(118, 43);
      this.lstEstado.TabIndex = 71;
      this.lstEstado.ValueMember = "Id";
      // 
      // chkEstado
      // 
      this.chkEstado.AutoSize = true;
      this.chkEstado.Location = new System.Drawing.Point(621, 19);
      this.chkEstado.Name = "chkEstado";
      this.chkEstado.Size = new System.Drawing.Size(59, 17);
      this.chkEstado.TabIndex = 69;
      this.chkEstado.Text = "Estado";
      this.chkEstado.UseVisualStyleBackColor = true;
      // 
      // ddlEstado
      // 
      this.ddlEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlEstado.FormattingEnabled = true;
      this.ddlEstado.Location = new System.Drawing.Point(694, 16);
      this.ddlEstado.Name = "ddlEstado";
      this.ddlEstado.Size = new System.Drawing.Size(40, 21);
      this.ddlEstado.TabIndex = 70;
      // 
      // dtgPrincipal
      // 
      this.dtgPrincipal.AllowUserToAddRows = false;
      this.dtgPrincipal.AllowUserToDeleteRows = false;
      this.dtgPrincipal.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dtgPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.dtgPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombrePlanta,
            this.colNumero,
            this.colFecha,
            this.colEstado,
            this.colActividad,
            this.colObservacion,
            this.colNombreEmpleado,
            this.colFechaCrea,
            this.colFechaMod,
            this.ColUsuarioMod});
      this.dtgPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgPrincipal.IdCopia = 0;
      this.dtgPrincipal.Location = new System.Drawing.Point(0, 229);
      this.dtgPrincipal.Name = "dtgPrincipal";
      this.dtgPrincipal.OpcionCopiarVisible = false;
      this.dtgPrincipal.OpcionEliminarVisible = false;
      this.dtgPrincipal.OpcionesActivas = 63;
      this.dtgPrincipal.OpcionesVisibles = 48;
      this.dtgPrincipal.OpcionInsertarVisible = false;
      this.dtgPrincipal.OpcionPegarVisible = false;
      this.dtgPrincipal.ReadOnly = true;
      this.dtgPrincipal.RefrescandoGrilla = false;
      this.dtgPrincipal.Size = new System.Drawing.Size(1104, 242);
      this.dtgPrincipal.TabIndex = 66;
      this.dtgPrincipal.CambiaOperacionRapida += new System.EventHandler<ITD.Win.CambiaOperacionRapidaEvengArg>(this.dtgPrincipal_CambiaOperacionRapida);
      this.dtgPrincipal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_CellDoubleClick);
      this.dtgPrincipal.Sorted += new System.EventHandler(this.dtgPrincipal_Sorted);
      // 
      // ColNombrePlanta
      // 
      this.ColNombrePlanta.DataPropertyName = "nombre_planta";
      this.ColNombrePlanta.HeaderText = "Planta";
      this.ColNombrePlanta.Name = "ColNombrePlanta";
      this.ColNombrePlanta.ReadOnly = true;
      // 
      // colNumero
      // 
      this.colNumero.DataPropertyName = "Numero";
      this.colNumero.HeaderText = "Numero";
      this.colNumero.Name = "colNumero";
      this.colNumero.ReadOnly = true;
      this.colNumero.Width = 70;
      // 
      // colFecha
      // 
      this.colFecha.DataPropertyName = "Fecha";
      this.colFecha.HeaderText = "Fecha";
      this.colFecha.Name = "colFecha";
      this.colFecha.ReadOnly = true;
      // 
      // colEstado
      // 
      this.colEstado.DataPropertyName = "Estado";
      this.colEstado.HeaderText = "Estado";
      this.colEstado.Name = "colEstado";
      this.colEstado.ReadOnly = true;
      // 
      // colActividad
      // 
      this.colActividad.DataPropertyName = "Actividad";
      this.colActividad.HeaderText = "Actividad";
      this.colActividad.Name = "colActividad";
      this.colActividad.ReadOnly = true;
      this.colActividad.Width = 130;
      // 
      // colObservacion
      // 
      this.colObservacion.DataPropertyName = "Observacion";
      this.colObservacion.HeaderText = "Observacion";
      this.colObservacion.Name = "colObservacion";
      this.colObservacion.ReadOnly = true;
      this.colObservacion.Width = 150;
      // 
      // colNombreEmpleado
      // 
      this.colNombreEmpleado.DataPropertyName = "nombre_empleado";
      this.colNombreEmpleado.HeaderText = "Usuario";
      this.colNombreEmpleado.Name = "colNombreEmpleado";
      this.colNombreEmpleado.ReadOnly = true;
      // 
      // colFechaCrea
      // 
      this.colFechaCrea.DataPropertyName = "FechaCrea";
      this.colFechaCrea.HeaderText = "FechaCrea";
      this.colFechaCrea.Name = "colFechaCrea";
      this.colFechaCrea.ReadOnly = true;
      // 
      // colFechaMod
      // 
      this.colFechaMod.DataPropertyName = "FechaMod";
      this.colFechaMod.HeaderText = "Fecha Modificacion";
      this.colFechaMod.Name = "colFechaMod";
      this.colFechaMod.ReadOnly = true;
      // 
      // ColUsuarioMod
      // 
      this.ColUsuarioMod.DataPropertyName = "UsuarioMod";
      this.ColUsuarioMod.HeaderText = "UsuarioMod";
      this.ColUsuarioMod.Name = "ColUsuarioMod";
      this.ColUsuarioMod.ReadOnly = true;
      // 
      // dtgTotal
      // 
      this.dtgTotal.AutoCalculado = false;
      this.dtgTotal.Dock = System.Windows.Forms.DockStyle.Top;
      this.dtgTotal.Grilla = null;
      this.dtgTotal.Location = new System.Drawing.Point(0, 205);
      this.dtgTotal.Name = "dtgTotal";
      this.dtgTotal.Size = new System.Drawing.Size(1104, 24);
      this.dtgTotal.TabIndex = 67;
      // 
      // MantencionDetCons
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1104, 493);
      this.Controls.Add(this.dtgPrincipal);
      this.Controls.Add(this.dtgTotal);
      this.Controls.Add(this.pnlPrincipal);
      this.Controls.Add(this.menuItem);
      this.EnterComoTab = true;
      this.KeyPreview = true;
      this.Name = "MantencionDetCons";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Mantención Consulta Detallada";
      this.Load += new System.EventHandler(this.ConsultaPaginada_Load);
      this.Controls.SetChildIndex(this.menuItem, 0);
      this.Controls.SetChildIndex(this.pnlPrincipal, 0);
      this.Controls.SetChildIndex(this.dtgTotal, 0);
      this.Controls.SetChildIndex(this.dtgPrincipal, 0);
      this.menuItem.ResumeLayout(false);
      this.menuItem.PerformLayout();
      this.pnlPrincipal.ResumeLayout(false);
      this.pnlPrincipal.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip menuItem;
    private System.Windows.Forms.ToolStripButton tsbNuevo;
    private System.Windows.Forms.ToolStripButton tsbModificar;
    private System.Windows.Forms.ToolStripButton tsbEliminar;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton tsbFiltrar;
    private System.Windows.Forms.ToolStripButton tsbQuitarFiltro;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripButton tsbMostrarFiltros;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripComboBox ddlReporte;
    private System.Windows.Forms.ToolStripButton tsbReporte;
    private System.Windows.Forms.Panel pnlPrincipal;
    private ITD.Win.Grilla dtgPrincipal;
    private System.Windows.Forms.ComboBox ddlPlanta;
    private System.Windows.Forms.CheckBox chkPlanta;
    private System.Windows.Forms.ListBox lstEstado;
    private System.Windows.Forms.CheckBox chkEstado;
    private System.Windows.Forms.ComboBox ddlEstado;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DateTimePicker dtpFechaHasta;
    private System.Windows.Forms.DateTimePicker dtpFechaDesde;
    private System.Windows.Forms.CheckBox chkFechaHasta;
    private System.Windows.Forms.CheckBox chkFechaDesde;
    private System.Windows.Forms.ComboBox ddlFechaHasta;
    private System.Windows.Forms.ComboBox ddlFechaDesde;
    private ITD.Win.GrillaTotal dtgTotal;
    private System.Windows.Forms.TextBox txtUsuarioMod;
    private System.Windows.Forms.ComboBox ddlUsuarioMod;
    private System.Windows.Forms.CheckBox chkUsuarioMod;
    private System.Windows.Forms.TextBox txtUsuario;
    private System.Windows.Forms.ComboBox ddlUsuario;
    private System.Windows.Forms.CheckBox chkUsuario;
    private System.Windows.Forms.TextBox txtActividad;
    private System.Windows.Forms.ComboBox ddlActividad;
    private System.Windows.Forms.CheckBox chkAcividad;
    private System.Windows.Forms.TextBox txtNumero;
    private System.Windows.Forms.ComboBox ddlNumero;
    private System.Windows.Forms.CheckBox chkNumero;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColNombrePlanta;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
    private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
    private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    private System.Windows.Forms.DataGridViewTextBoxColumn colActividad;
    private System.Windows.Forms.DataGridViewTextBoxColumn colObservacion;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNombreEmpleado;
    private System.Windows.Forms.DataGridViewTextBoxColumn colFechaCrea;
    private System.Windows.Forms.DataGridViewTextBoxColumn colFechaMod;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColUsuarioMod;
  }
}

