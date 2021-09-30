namespace APP {
  partial class SegregarCons {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SegregarCons));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
      this.txtTarja = new System.Windows.Forms.TextBox();
      this.ddlTarja = new System.Windows.Forms.ComboBox();
      this.chkTarja = new System.Windows.Forms.CheckBox();
      this.lstEstado = new System.Windows.Forms.ListBox();
      this.chkEstado = new System.Windows.Forms.CheckBox();
      this.ddlEstado = new System.Windows.Forms.ComboBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.dtpFechaCreaHasta = new System.Windows.Forms.DateTimePicker();
      this.dtpFechaCreaDesde = new System.Windows.Forms.DateTimePicker();
      this.chkFechaCreaHasta = new System.Windows.Forms.CheckBox();
      this.chkFechaCreaDesde = new System.Windows.Forms.CheckBox();
      this.ddlFechaCreaHasta = new System.Windows.Forms.ComboBox();
      this.ddlFechaCreaDesde = new System.Windows.Forms.ComboBox();
      this.txtCodigo = new System.Windows.Forms.TextBox();
      this.ddlCodigo = new System.Windows.Forms.ComboBox();
      this.chkCodigo = new System.Windows.Forms.CheckBox();
      this.txtNombrePTT = new System.Windows.Forms.TextBox();
      this.ddlNombrePTT = new System.Windows.Forms.ComboBox();
      this.chkNombrePTT = new System.Windows.Forms.CheckBox();
      this.txtNumero = new System.Windows.Forms.TextBox();
      this.ddlNumero = new System.Windows.Forms.ComboBox();
      this.chkNumero = new System.Windows.Forms.CheckBox();
      this.txtCliente = new System.Windows.Forms.TextBox();
      this.ddlPlanta = new System.Windows.Forms.ComboBox();
      this.ddlCliente = new System.Windows.Forms.ComboBox();
      this.chkPlanta = new System.Windows.Forms.CheckBox();
      this.chkCliente = new System.Windows.Forms.CheckBox();
      this.dtgPrincipal = new ITD.Win.Grilla(this.components);
      this.dtgTotal = new ITD.Win.GrillaTotal();
      this.colnombre_planta = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colnombre_clie = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colFechaCrea = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColUsuarioCrea = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColFechaMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColUsuarioMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.menuItem.SuspendLayout();
      this.pnlPrincipal.SuspendLayout();
      this.groupBox2.SuspendLayout();
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
      this.menuItem.Size = new System.Drawing.Size(1257, 25);
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
      this.pnlPrincipal.Controls.Add(this.txtTarja);
      this.pnlPrincipal.Controls.Add(this.ddlTarja);
      this.pnlPrincipal.Controls.Add(this.chkTarja);
      this.pnlPrincipal.Controls.Add(this.lstEstado);
      this.pnlPrincipal.Controls.Add(this.chkEstado);
      this.pnlPrincipal.Controls.Add(this.ddlEstado);
      this.pnlPrincipal.Controls.Add(this.groupBox2);
      this.pnlPrincipal.Controls.Add(this.txtCodigo);
      this.pnlPrincipal.Controls.Add(this.ddlCodigo);
      this.pnlPrincipal.Controls.Add(this.chkCodigo);
      this.pnlPrincipal.Controls.Add(this.txtNombrePTT);
      this.pnlPrincipal.Controls.Add(this.ddlNombrePTT);
      this.pnlPrincipal.Controls.Add(this.chkNombrePTT);
      this.pnlPrincipal.Controls.Add(this.txtNumero);
      this.pnlPrincipal.Controls.Add(this.ddlNumero);
      this.pnlPrincipal.Controls.Add(this.chkNumero);
      this.pnlPrincipal.Controls.Add(this.txtCliente);
      this.pnlPrincipal.Controls.Add(this.ddlPlanta);
      this.pnlPrincipal.Controls.Add(this.ddlCliente);
      this.pnlPrincipal.Controls.Add(this.chkPlanta);
      this.pnlPrincipal.Controls.Add(this.chkCliente);
      this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlPrincipal.Location = new System.Drawing.Point(0, 25);
      this.pnlPrincipal.Name = "pnlPrincipal";
      this.pnlPrincipal.Size = new System.Drawing.Size(1257, 129);
      this.pnlPrincipal.TabIndex = 7;
      // 
      // txtTarja
      // 
      this.txtTarja.Location = new System.Drawing.Point(435, 62);
      this.txtTarja.Name = "txtTarja";
      this.txtTarja.Size = new System.Drawing.Size(155, 20);
      this.txtTarja.TabIndex = 16;
      // 
      // ddlTarja
      // 
      this.ddlTarja.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlTarja.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlTarja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlTarja.FormattingEnabled = true;
      this.ddlTarja.Location = new System.Drawing.Point(390, 61);
      this.ddlTarja.Name = "ddlTarja";
      this.ddlTarja.Size = new System.Drawing.Size(40, 21);
      this.ddlTarja.TabIndex = 15;
      // 
      // chkTarja
      // 
      this.chkTarja.AutoSize = true;
      this.chkTarja.Location = new System.Drawing.Point(304, 62);
      this.chkTarja.Name = "chkTarja";
      this.chkTarja.Size = new System.Drawing.Size(82, 17);
      this.chkTarja.TabIndex = 14;
      this.chkTarja.Text = "Tarja origen";
      this.chkTarja.UseVisualStyleBackColor = true;
      // 
      // lstEstado
      // 
      this.lstEstado.DisplayMember = "Estado";
      this.lstEstado.FormattingEnabled = true;
      this.lstEstado.Location = new System.Drawing.Point(806, 31);
      this.lstEstado.Name = "lstEstado";
      this.lstEstado.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.lstEstado.Size = new System.Drawing.Size(118, 69);
      this.lstEstado.TabIndex = 20;
      this.lstEstado.ValueMember = "Id";
      // 
      // chkEstado
      // 
      this.chkEstado.AutoSize = true;
      this.chkEstado.Location = new System.Drawing.Point(806, 7);
      this.chkEstado.Name = "chkEstado";
      this.chkEstado.Size = new System.Drawing.Size(59, 17);
      this.chkEstado.TabIndex = 18;
      this.chkEstado.Text = "Estado";
      this.chkEstado.UseVisualStyleBackColor = true;
      // 
      // ddlEstado
      // 
      this.ddlEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlEstado.FormattingEnabled = true;
      this.ddlEstado.Location = new System.Drawing.Point(873, 5);
      this.ddlEstado.Name = "ddlEstado";
      this.ddlEstado.Size = new System.Drawing.Size(40, 21);
      this.ddlEstado.TabIndex = 19;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.dtpFechaCreaHasta);
      this.groupBox2.Controls.Add(this.dtpFechaCreaDesde);
      this.groupBox2.Controls.Add(this.chkFechaCreaHasta);
      this.groupBox2.Controls.Add(this.chkFechaCreaDesde);
      this.groupBox2.Controls.Add(this.ddlFechaCreaHasta);
      this.groupBox2.Controls.Add(this.ddlFechaCreaDesde);
      this.groupBox2.Location = new System.Drawing.Point(596, 14);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(193, 65);
      this.groupBox2.TabIndex = 17;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Fecha creado";
      // 
      // dtpFechaCreaHasta
      // 
      this.dtpFechaCreaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpFechaCreaHasta.Location = new System.Drawing.Point(106, 37);
      this.dtpFechaCreaHasta.Name = "dtpFechaCreaHasta";
      this.dtpFechaCreaHasta.Size = new System.Drawing.Size(84, 20);
      this.dtpFechaCreaHasta.TabIndex = 6;
      // 
      // dtpFechaCreaDesde
      // 
      this.dtpFechaCreaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpFechaCreaDesde.Location = new System.Drawing.Point(106, 15);
      this.dtpFechaCreaDesde.Name = "dtpFechaCreaDesde";
      this.dtpFechaCreaDesde.Size = new System.Drawing.Size(84, 20);
      this.dtpFechaCreaDesde.TabIndex = 3;
      // 
      // chkFechaCreaHasta
      // 
      this.chkFechaCreaHasta.AutoSize = true;
      this.chkFechaCreaHasta.Location = new System.Drawing.Point(3, 39);
      this.chkFechaCreaHasta.Name = "chkFechaCreaHasta";
      this.chkFechaCreaHasta.Size = new System.Drawing.Size(54, 17);
      this.chkFechaCreaHasta.TabIndex = 4;
      this.chkFechaCreaHasta.Text = "Hasta";
      this.chkFechaCreaHasta.UseVisualStyleBackColor = true;
      // 
      // chkFechaCreaDesde
      // 
      this.chkFechaCreaDesde.AutoSize = true;
      this.chkFechaCreaDesde.Location = new System.Drawing.Point(3, 17);
      this.chkFechaCreaDesde.Name = "chkFechaCreaDesde";
      this.chkFechaCreaDesde.Size = new System.Drawing.Size(57, 17);
      this.chkFechaCreaDesde.TabIndex = 1;
      this.chkFechaCreaDesde.Text = "Desde";
      this.chkFechaCreaDesde.UseVisualStyleBackColor = true;
      // 
      // ddlFechaCreaHasta
      // 
      this.ddlFechaCreaHasta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlFechaCreaHasta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlFechaCreaHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlFechaCreaHasta.FormattingEnabled = true;
      this.ddlFechaCreaHasta.Location = new System.Drawing.Point(60, 37);
      this.ddlFechaCreaHasta.Name = "ddlFechaCreaHasta";
      this.ddlFechaCreaHasta.Size = new System.Drawing.Size(40, 21);
      this.ddlFechaCreaHasta.TabIndex = 5;
      // 
      // ddlFechaCreaDesde
      // 
      this.ddlFechaCreaDesde.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlFechaCreaDesde.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlFechaCreaDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlFechaCreaDesde.FormattingEnabled = true;
      this.ddlFechaCreaDesde.Location = new System.Drawing.Point(60, 15);
      this.ddlFechaCreaDesde.Name = "ddlFechaCreaDesde";
      this.ddlFechaCreaDesde.Size = new System.Drawing.Size(40, 21);
      this.ddlFechaCreaDesde.TabIndex = 2;
      // 
      // txtCodigo
      // 
      this.txtCodigo.Location = new System.Drawing.Point(435, 15);
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.Size = new System.Drawing.Size(155, 20);
      this.txtCodigo.TabIndex = 10;
      // 
      // ddlCodigo
      // 
      this.ddlCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlCodigo.FormattingEnabled = true;
      this.ddlCodigo.Location = new System.Drawing.Point(390, 15);
      this.ddlCodigo.Name = "ddlCodigo";
      this.ddlCodigo.Size = new System.Drawing.Size(40, 21);
      this.ddlCodigo.TabIndex = 9;
      // 
      // chkCodigo
      // 
      this.chkCodigo.AutoSize = true;
      this.chkCodigo.Location = new System.Drawing.Point(304, 17);
      this.chkCodigo.Name = "chkCodigo";
      this.chkCodigo.Size = new System.Drawing.Size(59, 17);
      this.chkCodigo.TabIndex = 8;
      this.chkCodigo.Text = "Código";
      this.chkCodigo.UseVisualStyleBackColor = true;
      // 
      // txtNombrePTT
      // 
      this.txtNombrePTT.Location = new System.Drawing.Point(435, 38);
      this.txtNombrePTT.Name = "txtNombrePTT";
      this.txtNombrePTT.Size = new System.Drawing.Size(155, 20);
      this.txtNombrePTT.TabIndex = 13;
      // 
      // ddlNombrePTT
      // 
      this.ddlNombrePTT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlNombrePTT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlNombrePTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlNombrePTT.FormattingEnabled = true;
      this.ddlNombrePTT.Location = new System.Drawing.Point(390, 38);
      this.ddlNombrePTT.Name = "ddlNombrePTT";
      this.ddlNombrePTT.Size = new System.Drawing.Size(40, 21);
      this.ddlNombrePTT.TabIndex = 12;
      // 
      // chkNombrePTT
      // 
      this.chkNombrePTT.AutoSize = true;
      this.chkNombrePTT.Location = new System.Drawing.Point(304, 40);
      this.chkNombrePTT.Name = "chkNombrePTT";
      this.chkNombrePTT.Size = new System.Drawing.Size(82, 17);
      this.chkNombrePTT.TabIndex = 11;
      this.chkNombrePTT.Text = "Descripción";
      this.chkNombrePTT.UseVisualStyleBackColor = true;
      // 
      // txtNumero
      // 
      this.txtNumero.Location = new System.Drawing.Point(143, 62);
      this.txtNumero.Name = "txtNumero";
      this.txtNumero.Size = new System.Drawing.Size(155, 20);
      this.txtNumero.TabIndex = 7;
      // 
      // ddlNumero
      // 
      this.ddlNumero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlNumero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlNumero.FormattingEnabled = true;
      this.ddlNumero.Location = new System.Drawing.Point(98, 61);
      this.ddlNumero.Name = "ddlNumero";
      this.ddlNumero.Size = new System.Drawing.Size(40, 21);
      this.ddlNumero.TabIndex = 6;
      // 
      // chkNumero
      // 
      this.chkNumero.AutoSize = true;
      this.chkNumero.Location = new System.Drawing.Point(12, 62);
      this.chkNumero.Name = "chkNumero";
      this.chkNumero.Size = new System.Drawing.Size(63, 17);
      this.chkNumero.TabIndex = 5;
      this.chkNumero.Text = "Número";
      this.chkNumero.UseVisualStyleBackColor = true;
      // 
      // txtCliente
      // 
      this.txtCliente.Location = new System.Drawing.Point(143, 38);
      this.txtCliente.Name = "txtCliente";
      this.txtCliente.Size = new System.Drawing.Size(155, 20);
      this.txtCliente.TabIndex = 4;
      // 
      // ddlPlanta
      // 
      this.ddlPlanta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlPlanta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlPlanta.DisplayMember = "Planta";
      this.ddlPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlPlanta.FormattingEnabled = true;
      this.ddlPlanta.Location = new System.Drawing.Point(98, 15);
      this.ddlPlanta.Name = "ddlPlanta";
      this.ddlPlanta.Size = new System.Drawing.Size(200, 21);
      this.ddlPlanta.TabIndex = 1;
      this.ddlPlanta.ValueMember = "Id";
      // 
      // ddlCliente
      // 
      this.ddlCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlCliente.FormattingEnabled = true;
      this.ddlCliente.Location = new System.Drawing.Point(98, 38);
      this.ddlCliente.Name = "ddlCliente";
      this.ddlCliente.Size = new System.Drawing.Size(40, 21);
      this.ddlCliente.TabIndex = 3;
      // 
      // chkPlanta
      // 
      this.chkPlanta.AutoSize = true;
      this.chkPlanta.Location = new System.Drawing.Point(12, 17);
      this.chkPlanta.Name = "chkPlanta";
      this.chkPlanta.Size = new System.Drawing.Size(56, 17);
      this.chkPlanta.TabIndex = 0;
      this.chkPlanta.Text = "Planta";
      this.chkPlanta.UseVisualStyleBackColor = true;
      // 
      // chkCliente
      // 
      this.chkCliente.AutoSize = true;
      this.chkCliente.Location = new System.Drawing.Point(12, 40);
      this.chkCliente.Name = "chkCliente";
      this.chkCliente.Size = new System.Drawing.Size(58, 17);
      this.chkCliente.TabIndex = 2;
      this.chkCliente.Text = "Cliente";
      this.chkCliente.UseVisualStyleBackColor = true;
      // 
      // dtgPrincipal
      // 
      this.dtgPrincipal.AllowUserToAddRows = false;
      this.dtgPrincipal.AllowUserToDeleteRows = false;
      this.dtgPrincipal.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dtgPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dtgPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colnombre_planta,
            this.colNumero,
            this.colnombre_clie,
            this.colEstado,
            this.colFechaCrea,
            this.ColUsuarioCrea,
            this.ColFechaMod,
            this.ColUsuarioMod,
            this.ColObservacion});
      this.dtgPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgPrincipal.IdCopia = 0;
      this.dtgPrincipal.Location = new System.Drawing.Point(0, 178);
      this.dtgPrincipal.Name = "dtgPrincipal";
      this.dtgPrincipal.OpcionCopiarVisible = false;
      this.dtgPrincipal.OpcionEliminarVisible = false;
      this.dtgPrincipal.OpcionesActivas = 63;
      this.dtgPrincipal.OpcionesVisibles = 48;
      this.dtgPrincipal.OpcionInsertarVisible = false;
      this.dtgPrincipal.OpcionPegarVisible = false;
      this.dtgPrincipal.ReadOnly = true;
      this.dtgPrincipal.RefrescandoGrilla = false;
      this.dtgPrincipal.Size = new System.Drawing.Size(1257, 293);
      this.dtgPrincipal.TabIndex = 66;
      this.dtgPrincipal.CambiaOperacionRapida += new System.EventHandler<ITD.Win.CambiaOperacionRapidaEvengArg>(this.dtgPrincipal_CambiaOperacionRapida);
      this.dtgPrincipal.DespuesCambioFila += new System.EventHandler<ITD.Win.FilaGrillaEventArg>(this.dtgPrincipal_DespuesCambioFila);
      this.dtgPrincipal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_CellDoubleClick);
      this.dtgPrincipal.Sorted += new System.EventHandler(this.dtgPrincipal_Sorted);
      // 
      // dtgTotal
      // 
      this.dtgTotal.AutoCalculado = false;
      this.dtgTotal.Dock = System.Windows.Forms.DockStyle.Top;
      this.dtgTotal.Grilla = null;
      this.dtgTotal.Location = new System.Drawing.Point(0, 154);
      this.dtgTotal.Name = "dtgTotal";
      this.dtgTotal.Size = new System.Drawing.Size(1257, 24);
      this.dtgTotal.TabIndex = 67;
      // 
      // colnombre_planta
      // 
      this.colnombre_planta.DataPropertyName = "nombre_planta";
      this.colnombre_planta.HeaderText = "Planta";
      this.colnombre_planta.MaxInputLength = 20;
      this.colnombre_planta.Name = "colnombre_planta";
      this.colnombre_planta.ReadOnly = true;
      this.colnombre_planta.Width = 150;
      // 
      // colNumero
      // 
      this.colNumero.DataPropertyName = "Numero";
      this.colNumero.HeaderText = "Numero";
      this.colNumero.Name = "colNumero";
      this.colNumero.ReadOnly = true;
      this.colNumero.Width = 80;
      // 
      // colnombre_clie
      // 
      this.colnombre_clie.DataPropertyName = "nombre_clie";
      this.colnombre_clie.HeaderText = "Cliente";
      this.colnombre_clie.MaxInputLength = 50;
      this.colnombre_clie.Name = "colnombre_clie";
      this.colnombre_clie.ReadOnly = true;
      this.colnombre_clie.Width = 200;
      // 
      // colEstado
      // 
      this.colEstado.DataPropertyName = "Estado";
      this.colEstado.HeaderText = "Estado";
      this.colEstado.MaxInputLength = 50;
      this.colEstado.Name = "colEstado";
      this.colEstado.ReadOnly = true;
      // 
      // colFechaCrea
      // 
      this.colFechaCrea.DataPropertyName = "FechaCrea";
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle2.Format = "g";
      this.colFechaCrea.DefaultCellStyle = dataGridViewCellStyle2;
      this.colFechaCrea.HeaderText = "Fecha Crea";
      this.colFechaCrea.Name = "colFechaCrea";
      this.colFechaCrea.ReadOnly = true;
      this.colFechaCrea.ToolTipText = "Fecha creación";
      // 
      // ColUsuarioCrea
      // 
      this.ColUsuarioCrea.DataPropertyName = "Creador";
      this.ColUsuarioCrea.HeaderText = "Usuario Crea";
      this.ColUsuarioCrea.Name = "ColUsuarioCrea";
      this.ColUsuarioCrea.ReadOnly = true;
      this.ColUsuarioCrea.Width = 130;
      // 
      // ColFechaMod
      // 
      this.ColFechaMod.DataPropertyName = "FechaMod";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle3.Format = "g";
      this.ColFechaMod.DefaultCellStyle = dataGridViewCellStyle3;
      this.ColFechaMod.HeaderText = "Fecha Mod";
      this.ColFechaMod.Name = "ColFechaMod";
      this.ColFechaMod.ReadOnly = true;
      // 
      // ColUsuarioMod
      // 
      this.ColUsuarioMod.DataPropertyName = "Modificador";
      this.ColUsuarioMod.HeaderText = "Usuario Mod";
      this.ColUsuarioMod.Name = "ColUsuarioMod";
      this.ColUsuarioMod.ReadOnly = true;
      this.ColUsuarioMod.Width = 130;
      // 
      // ColObservacion
      // 
      this.ColObservacion.HeaderText = "Observación";
      this.ColObservacion.Name = "ColObservacion";
      this.ColObservacion.ReadOnly = true;
      this.ColObservacion.Width = 200;
      // 
      // SegregarCons
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1257, 493);
      this.Controls.Add(this.dtgPrincipal);
      this.Controls.Add(this.dtgTotal);
      this.Controls.Add(this.pnlPrincipal);
      this.Controls.Add(this.menuItem);
      this.EnterComoTab = true;
      this.KeyPreview = true;
      this.Name = "SegregarCons";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Consulta de segregaciones";
      this.Load += new System.EventHandler(this.ConsultaPaginada_Load);
      this.Controls.SetChildIndex(this.menuItem, 0);
      this.Controls.SetChildIndex(this.pnlPrincipal, 0);
      this.Controls.SetChildIndex(this.dtgTotal, 0);
      this.Controls.SetChildIndex(this.dtgPrincipal, 0);
      this.menuItem.ResumeLayout(false);
      this.menuItem.PerformLayout();
      this.pnlPrincipal.ResumeLayout(false);
      this.pnlPrincipal.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
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
    private ITD.Win.GrillaTotal dtgTotal;
    private System.Windows.Forms.TextBox txtNumero;
    private System.Windows.Forms.ComboBox ddlNumero;
    private System.Windows.Forms.CheckBox chkNumero;
    private System.Windows.Forms.TextBox txtCliente;
    private System.Windows.Forms.ComboBox ddlPlanta;
    private System.Windows.Forms.ComboBox ddlCliente;
    private System.Windows.Forms.CheckBox chkPlanta;
    private System.Windows.Forms.CheckBox chkCliente;
    private System.Windows.Forms.TextBox txtCodigo;
    private System.Windows.Forms.ComboBox ddlCodigo;
    private System.Windows.Forms.CheckBox chkCodigo;
    private System.Windows.Forms.TextBox txtNombrePTT;
    private System.Windows.Forms.ComboBox ddlNombrePTT;
    private System.Windows.Forms.CheckBox chkNombrePTT;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.DateTimePicker dtpFechaCreaHasta;
    private System.Windows.Forms.DateTimePicker dtpFechaCreaDesde;
    private System.Windows.Forms.CheckBox chkFechaCreaHasta;
    private System.Windows.Forms.CheckBox chkFechaCreaDesde;
    private System.Windows.Forms.ComboBox ddlFechaCreaHasta;
    private System.Windows.Forms.ComboBox ddlFechaCreaDesde;
    private System.Windows.Forms.ListBox lstEstado;
    private System.Windows.Forms.CheckBox chkEstado;
    private System.Windows.Forms.ComboBox ddlEstado;
    private System.Windows.Forms.TextBox txtTarja;
    private System.Windows.Forms.ComboBox ddlTarja;
    private System.Windows.Forms.CheckBox chkTarja;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_planta;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_clie;
    private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    private System.Windows.Forms.DataGridViewTextBoxColumn colFechaCrea;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColUsuarioCrea;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaMod;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColUsuarioMod;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColObservacion;
  }
}

