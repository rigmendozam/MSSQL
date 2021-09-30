namespace APP {
  partial class RecepcionCons {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecepcionCons));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
      this.txtOCProv = new System.Windows.Forms.TextBox();
      this.txtOC = new System.Windows.Forms.TextBox();
      this.ddlOCProv = new System.Windows.Forms.ComboBox();
      this.ddlOC = new System.Windows.Forms.ComboBox();
      this.chkOCProv = new System.Windows.Forms.CheckBox();
      this.chkOC = new System.Windows.Forms.CheckBox();
      this.txtNumDoc = new System.Windows.Forms.TextBox();
      this.ddlNumDoc = new System.Windows.Forms.ComboBox();
      this.chkNumDoc = new System.Windows.Forms.CheckBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
      this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
      this.chkFechaHasta = new System.Windows.Forms.CheckBox();
      this.chkFechaDesde = new System.Windows.Forms.CheckBox();
      this.ddlFechaHasta = new System.Windows.Forms.ComboBox();
      this.ddlFechaDesde = new System.Windows.Forms.ComboBox();
      this.lstEstado = new System.Windows.Forms.ListBox();
      this.chkEstado = new System.Windows.Forms.CheckBox();
      this.ddlEstado = new System.Windows.Forms.ComboBox();
      this.txtNumero = new System.Windows.Forms.TextBox();
      this.ddlNumero = new System.Windows.Forms.ComboBox();
      this.chkNumero = new System.Windows.Forms.CheckBox();
      this.txtCliente = new System.Windows.Forms.TextBox();
      this.ddlPlanta = new System.Windows.Forms.ComboBox();
      this.ddlCliente = new System.Windows.Forms.ComboBox();
      this.chkPlanta = new System.Windows.Forms.CheckBox();
      this.chkCliente = new System.Windows.Forms.CheckBox();
      this.dtgPrincipal = new ITD.Win.Grilla(this.components);
      this.colnombre_planta = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colFechaIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colNumeroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colnombre_tipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colnombre_clie = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColUltimaFechaRegistrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
      this.menuItem.Size = new System.Drawing.Size(1012, 25);
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
            "Informe de utilidad de ingreso"});
      this.ddlReporte.Name = "ddlReporte";
      this.ddlReporte.Size = new System.Drawing.Size(250, 25);
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
      this.pnlPrincipal.Controls.Add(this.txtOCProv);
      this.pnlPrincipal.Controls.Add(this.txtOC);
      this.pnlPrincipal.Controls.Add(this.ddlOCProv);
      this.pnlPrincipal.Controls.Add(this.ddlOC);
      this.pnlPrincipal.Controls.Add(this.chkOCProv);
      this.pnlPrincipal.Controls.Add(this.chkOC);
      this.pnlPrincipal.Controls.Add(this.txtNumDoc);
      this.pnlPrincipal.Controls.Add(this.ddlNumDoc);
      this.pnlPrincipal.Controls.Add(this.chkNumDoc);
      this.pnlPrincipal.Controls.Add(this.groupBox1);
      this.pnlPrincipal.Controls.Add(this.lstEstado);
      this.pnlPrincipal.Controls.Add(this.chkEstado);
      this.pnlPrincipal.Controls.Add(this.ddlEstado);
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
      this.pnlPrincipal.Size = new System.Drawing.Size(1012, 143);
      this.pnlPrincipal.TabIndex = 7;
      // 
      // txtOCProv
      // 
      this.txtOCProv.Location = new System.Drawing.Point(399, 36);
      this.txtOCProv.Name = "txtOCProv";
      this.txtOCProv.Size = new System.Drawing.Size(155, 20);
      this.txtOCProv.TabIndex = 13;
      // 
      // txtOC
      // 
      this.txtOC.Location = new System.Drawing.Point(399, 13);
      this.txtOC.Name = "txtOC";
      this.txtOC.Size = new System.Drawing.Size(155, 20);
      this.txtOC.TabIndex = 13;
      // 
      // ddlOCProv
      // 
      this.ddlOCProv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlOCProv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlOCProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlOCProv.FormattingEnabled = true;
      this.ddlOCProv.Location = new System.Drawing.Point(354, 36);
      this.ddlOCProv.Name = "ddlOCProv";
      this.ddlOCProv.Size = new System.Drawing.Size(40, 21);
      this.ddlOCProv.TabIndex = 12;
      // 
      // ddlOC
      // 
      this.ddlOC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlOC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlOC.FormattingEnabled = true;
      this.ddlOC.Location = new System.Drawing.Point(354, 13);
      this.ddlOC.Name = "ddlOC";
      this.ddlOC.Size = new System.Drawing.Size(40, 21);
      this.ddlOC.TabIndex = 12;
      // 
      // chkOCProv
      // 
      this.chkOCProv.AutoSize = true;
      this.chkOCProv.Location = new System.Drawing.Point(286, 38);
      this.chkOCProv.Name = "chkOCProv";
      this.chkOCProv.Size = new System.Drawing.Size(66, 17);
      this.chkOCProv.TabIndex = 11;
      this.chkOCProv.Text = "OC Prov";
      this.chkOCProv.UseVisualStyleBackColor = true;
      // 
      // chkOC
      // 
      this.chkOC.AutoSize = true;
      this.chkOC.Location = new System.Drawing.Point(286, 15);
      this.chkOC.Name = "chkOC";
      this.chkOC.Size = new System.Drawing.Size(41, 17);
      this.chkOC.TabIndex = 11;
      this.chkOC.Text = "OC";
      this.chkOC.UseVisualStyleBackColor = true;
      // 
      // txtNumDoc
      // 
      this.txtNumDoc.Location = new System.Drawing.Point(125, 82);
      this.txtNumDoc.Name = "txtNumDoc";
      this.txtNumDoc.Size = new System.Drawing.Size(155, 20);
      this.txtNumDoc.TabIndex = 10;
      // 
      // ddlNumDoc
      // 
      this.ddlNumDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlNumDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlNumDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlNumDoc.FormattingEnabled = true;
      this.ddlNumDoc.Location = new System.Drawing.Point(80, 82);
      this.ddlNumDoc.Name = "ddlNumDoc";
      this.ddlNumDoc.Size = new System.Drawing.Size(40, 21);
      this.ddlNumDoc.TabIndex = 9;
      // 
      // chkNumDoc
      // 
      this.chkNumDoc.AutoSize = true;
      this.chkNumDoc.Location = new System.Drawing.Point(12, 84);
      this.chkNumDoc.Name = "chkNumDoc";
      this.chkNumDoc.Size = new System.Drawing.Size(61, 17);
      this.chkNumDoc.TabIndex = 8;
      this.chkNumDoc.Text = "N° Doc";
      this.chkNumDoc.UseVisualStyleBackColor = true;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.dtpFechaHasta);
      this.groupBox1.Controls.Add(this.dtpFechaDesde);
      this.groupBox1.Controls.Add(this.chkFechaHasta);
      this.groupBox1.Controls.Add(this.chkFechaDesde);
      this.groupBox1.Controls.Add(this.ddlFechaHasta);
      this.groupBox1.Controls.Add(this.ddlFechaDesde);
      this.groupBox1.Location = new System.Drawing.Point(579, 13);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(193, 65);
      this.groupBox1.TabIndex = 14;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Fecha";
      // 
      // dtpFechaHasta
      // 
      this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpFechaHasta.Location = new System.Drawing.Point(106, 37);
      this.dtpFechaHasta.Name = "dtpFechaHasta";
      this.dtpFechaHasta.Size = new System.Drawing.Size(84, 20);
      this.dtpFechaHasta.TabIndex = 6;
      // 
      // dtpFechaDesde
      // 
      this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpFechaDesde.Location = new System.Drawing.Point(106, 15);
      this.dtpFechaDesde.Name = "dtpFechaDesde";
      this.dtpFechaDesde.Size = new System.Drawing.Size(84, 20);
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
      this.ddlFechaHasta.Location = new System.Drawing.Point(60, 37);
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
      this.ddlFechaDesde.Location = new System.Drawing.Point(60, 15);
      this.ddlFechaDesde.Name = "ddlFechaDesde";
      this.ddlFechaDesde.Size = new System.Drawing.Size(40, 21);
      this.ddlFechaDesde.TabIndex = 2;
      // 
      // lstEstado
      // 
      this.lstEstado.DisplayMember = "Estado";
      this.lstEstado.FormattingEnabled = true;
      this.lstEstado.Location = new System.Drawing.Point(788, 37);
      this.lstEstado.Name = "lstEstado";
      this.lstEstado.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.lstEstado.Size = new System.Drawing.Size(118, 69);
      this.lstEstado.TabIndex = 17;
      this.lstEstado.ValueMember = "Id";
      // 
      // chkEstado
      // 
      this.chkEstado.AutoSize = true;
      this.chkEstado.Location = new System.Drawing.Point(788, 13);
      this.chkEstado.Name = "chkEstado";
      this.chkEstado.Size = new System.Drawing.Size(59, 17);
      this.chkEstado.TabIndex = 15;
      this.chkEstado.Text = "Estado";
      this.chkEstado.UseVisualStyleBackColor = true;
      // 
      // ddlEstado
      // 
      this.ddlEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlEstado.FormattingEnabled = true;
      this.ddlEstado.Location = new System.Drawing.Point(855, 11);
      this.ddlEstado.Name = "ddlEstado";
      this.ddlEstado.Size = new System.Drawing.Size(40, 21);
      this.ddlEstado.TabIndex = 16;
      // 
      // txtNumero
      // 
      this.txtNumero.Location = new System.Drawing.Point(125, 59);
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
      this.ddlNumero.Location = new System.Drawing.Point(80, 59);
      this.ddlNumero.Name = "ddlNumero";
      this.ddlNumero.Size = new System.Drawing.Size(40, 21);
      this.ddlNumero.TabIndex = 6;
      // 
      // chkNumero
      // 
      this.chkNumero.AutoSize = true;
      this.chkNumero.Location = new System.Drawing.Point(12, 61);
      this.chkNumero.Name = "chkNumero";
      this.chkNumero.Size = new System.Drawing.Size(63, 17);
      this.chkNumero.TabIndex = 5;
      this.chkNumero.Text = "Número";
      this.chkNumero.UseVisualStyleBackColor = true;
      // 
      // txtCliente
      // 
      this.txtCliente.Location = new System.Drawing.Point(125, 36);
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
      this.ddlPlanta.Location = new System.Drawing.Point(80, 13);
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
      this.ddlCliente.Location = new System.Drawing.Point(80, 36);
      this.ddlCliente.Name = "ddlCliente";
      this.ddlCliente.Size = new System.Drawing.Size(40, 21);
      this.ddlCliente.TabIndex = 3;
      // 
      // chkPlanta
      // 
      this.chkPlanta.AutoSize = true;
      this.chkPlanta.Location = new System.Drawing.Point(12, 15);
      this.chkPlanta.Name = "chkPlanta";
      this.chkPlanta.Size = new System.Drawing.Size(56, 17);
      this.chkPlanta.TabIndex = 0;
      this.chkPlanta.Text = "Planta";
      this.chkPlanta.UseVisualStyleBackColor = true;
      // 
      // chkCliente
      // 
      this.chkCliente.AutoSize = true;
      this.chkCliente.Location = new System.Drawing.Point(12, 38);
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
            this.ColNumero,
            this.colFechaIng,
            this.colNumeroDoc,
            this.colnombre_tipoDoc,
            this.colnombre_clie,
            this.ColProveedor,
            this.colEstado,
            this.ColUltimaFechaRegistrada});
      this.dtgPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgPrincipal.IdCopia = 0;
      this.dtgPrincipal.Location = new System.Drawing.Point(0, 192);
      this.dtgPrincipal.Name = "dtgPrincipal";
      this.dtgPrincipal.OpcionCopiarVisible = false;
      this.dtgPrincipal.OpcionEliminarVisible = false;
      this.dtgPrincipal.OpcionesActivas = 63;
      this.dtgPrincipal.OpcionesVisibles = 48;
      this.dtgPrincipal.OpcionInsertarVisible = false;
      this.dtgPrincipal.OpcionPegarVisible = false;
      this.dtgPrincipal.ReadOnly = true;
      this.dtgPrincipal.RefrescandoGrilla = false;
      this.dtgPrincipal.Size = new System.Drawing.Size(1012, 279);
      this.dtgPrincipal.TabIndex = 66;
      this.dtgPrincipal.CambiaOperacionRapida += new System.EventHandler<ITD.Win.CambiaOperacionRapidaEvengArg>(this.dtgPrincipal_CambiaOperacionRapida);
      this.dtgPrincipal.DespuesCambioFila += new System.EventHandler<ITD.Win.FilaGrillaEventArg>(this.dtgPrincipal_DespuesCambioFila);
      this.dtgPrincipal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_CellDoubleClick);
      this.dtgPrincipal.Sorted += new System.EventHandler(this.dtgPrincipal_Sorted);
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
      // ColNumero
      // 
      this.ColNumero.DataPropertyName = "Numero";
      this.ColNumero.HeaderText = "Número";
      this.ColNumero.Name = "ColNumero";
      this.ColNumero.ReadOnly = true;
      this.ColNumero.Width = 70;
      // 
      // colFechaIng
      // 
      this.colFechaIng.DataPropertyName = "FechaIng";
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle2.Format = "d";
      this.colFechaIng.DefaultCellStyle = dataGridViewCellStyle2;
      this.colFechaIng.HeaderText = "Fecha";
      this.colFechaIng.Name = "colFechaIng";
      this.colFechaIng.ReadOnly = true;
      this.colFechaIng.Width = 75;
      // 
      // colNumeroDoc
      // 
      this.colNumeroDoc.DataPropertyName = "NumeroDoc";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle3.Format = "#,##0.##";
      this.colNumeroDoc.DefaultCellStyle = dataGridViewCellStyle3;
      this.colNumeroDoc.HeaderText = "Num. Doc.";
      this.colNumeroDoc.Name = "colNumeroDoc";
      this.colNumeroDoc.ReadOnly = true;
      this.colNumeroDoc.ToolTipText = "Número del documento ingresado";
      this.colNumeroDoc.Width = 80;
      // 
      // colnombre_tipoDoc
      // 
      this.colnombre_tipoDoc.DataPropertyName = "nombre_tipoDoc";
      this.colnombre_tipoDoc.HeaderText = "Tipo doc";
      this.colnombre_tipoDoc.MaxInputLength = 20;
      this.colnombre_tipoDoc.Name = "colnombre_tipoDoc";
      this.colnombre_tipoDoc.ReadOnly = true;
      this.colnombre_tipoDoc.Width = 120;
      // 
      // colnombre_clie
      // 
      this.colnombre_clie.DataPropertyName = "nombre_clie";
      this.colnombre_clie.HeaderText = "Cliente";
      this.colnombre_clie.MaxInputLength = 50;
      this.colnombre_clie.Name = "colnombre_clie";
      this.colnombre_clie.ReadOnly = true;
      this.colnombre_clie.Width = 250;
      // 
      // ColProveedor
      // 
      this.ColProveedor.DataPropertyName = "nombre_Prove";
      this.ColProveedor.HeaderText = "Proveedor";
      this.ColProveedor.Name = "ColProveedor";
      this.ColProveedor.ReadOnly = true;
      this.ColProveedor.Width = 150;
      // 
      // colEstado
      // 
      this.colEstado.DataPropertyName = "Estado";
      this.colEstado.HeaderText = "Estado";
      this.colEstado.MaxInputLength = 20;
      this.colEstado.Name = "colEstado";
      this.colEstado.ReadOnly = true;
      // 
      // ColUltimaFechaRegistrada
      // 
      this.ColUltimaFechaRegistrada.DataPropertyName = "FechaMod";
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle4.Format = "g";
      this.ColUltimaFechaRegistrada.DefaultCellStyle = dataGridViewCellStyle4;
      this.ColUltimaFechaRegistrada.HeaderText = "Ult. Fecha";
      this.ColUltimaFechaRegistrada.Name = "ColUltimaFechaRegistrada";
      this.ColUltimaFechaRegistrada.ReadOnly = true;
      this.ColUltimaFechaRegistrada.ToolTipText = "Última fecha de modificación";
      // 
      // dtgTotal
      // 
      this.dtgTotal.AutoCalculado = false;
      this.dtgTotal.Dock = System.Windows.Forms.DockStyle.Top;
      this.dtgTotal.Grilla = null;
      this.dtgTotal.Location = new System.Drawing.Point(0, 168);
      this.dtgTotal.Name = "dtgTotal";
      this.dtgTotal.Size = new System.Drawing.Size(1012, 24);
      this.dtgTotal.TabIndex = 67;
      // 
      // RecepcionCons
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1012, 493);
      this.Controls.Add(this.dtgPrincipal);
      this.Controls.Add(this.dtgTotal);
      this.Controls.Add(this.pnlPrincipal);
      this.Controls.Add(this.menuItem);
      this.EnterComoTab = true;
      this.KeyPreview = true;
      this.Name = "RecepcionCons";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Consulta de recepciones";
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
    private ITD.Win.GrillaTotal dtgTotal;
    private System.Windows.Forms.TextBox txtNumDoc;
    private System.Windows.Forms.ComboBox ddlNumDoc;
    private System.Windows.Forms.CheckBox chkNumDoc;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DateTimePicker dtpFechaHasta;
    private System.Windows.Forms.DateTimePicker dtpFechaDesde;
    private System.Windows.Forms.CheckBox chkFechaHasta;
    private System.Windows.Forms.CheckBox chkFechaDesde;
    private System.Windows.Forms.ComboBox ddlFechaHasta;
    private System.Windows.Forms.ComboBox ddlFechaDesde;
    private System.Windows.Forms.ListBox lstEstado;
    private System.Windows.Forms.CheckBox chkEstado;
    private System.Windows.Forms.ComboBox ddlEstado;
    private System.Windows.Forms.TextBox txtNumero;
    private System.Windows.Forms.ComboBox ddlNumero;
    private System.Windows.Forms.CheckBox chkNumero;
    private System.Windows.Forms.TextBox txtCliente;
    private System.Windows.Forms.ComboBox ddlPlanta;
    private System.Windows.Forms.ComboBox ddlCliente;
    private System.Windows.Forms.CheckBox chkPlanta;
    private System.Windows.Forms.CheckBox chkCliente;
    private System.Windows.Forms.TextBox txtOC;
    private System.Windows.Forms.ComboBox ddlOC;
    private System.Windows.Forms.CheckBox chkOC;
    private System.Windows.Forms.TextBox txtOCProv;
    private System.Windows.Forms.ComboBox ddlOCProv;
    private System.Windows.Forms.CheckBox chkOCProv;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_planta;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColNumero;
    private System.Windows.Forms.DataGridViewTextBoxColumn colFechaIng;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroDoc;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_tipoDoc;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_clie;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColProveedor;
    private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColUltimaFechaRegistrada;
  }
}

