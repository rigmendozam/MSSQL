namespace APP {
  partial class InventarioCons {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarioCons));
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
      this.txtComponentes = new System.Windows.Forms.TextBox();
      this.ddlComponentes = new System.Windows.Forms.ComboBox();
      this.chkComponentes = new System.Windows.Forms.CheckBox();
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
      this.dtgTotal = new ITD.Win.GrillaTotal();
      this.colnombre_planta = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colnombre_clie = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colnombre_ptt = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colnombre_detPtt = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colnombre_rack = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColAuditor = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.txtAuditor = new System.Windows.Forms.TextBox();
      this.ddlAuditor = new System.Windows.Forms.ComboBox();
      this.chkAuditor = new System.Windows.Forms.CheckBox();
      this.txtResponsable = new System.Windows.Forms.TextBox();
      this.ddlResponsable = new System.Windows.Forms.ComboBox();
      this.chkResponsable = new System.Windows.Forms.CheckBox();
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
      this.menuItem.Size = new System.Drawing.Size(1460, 25);
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
      this.pnlPrincipal.Controls.Add(this.txtAuditor);
      this.pnlPrincipal.Controls.Add(this.ddlAuditor);
      this.pnlPrincipal.Controls.Add(this.chkAuditor);
      this.pnlPrincipal.Controls.Add(this.txtResponsable);
      this.pnlPrincipal.Controls.Add(this.ddlResponsable);
      this.pnlPrincipal.Controls.Add(this.chkResponsable);
      this.pnlPrincipal.Controls.Add(this.txtComponentes);
      this.pnlPrincipal.Controls.Add(this.ddlComponentes);
      this.pnlPrincipal.Controls.Add(this.chkComponentes);
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
      this.pnlPrincipal.Size = new System.Drawing.Size(1460, 136);
      this.pnlPrincipal.TabIndex = 7;
      // 
      // txtComponentes
      // 
      this.txtComponentes.Location = new System.Drawing.Point(143, 80);
      this.txtComponentes.Name = "txtComponentes";
      this.txtComponentes.Size = new System.Drawing.Size(155, 20);
      this.txtComponentes.TabIndex = 11;
      // 
      // ddlComponentes
      // 
      this.ddlComponentes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlComponentes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlComponentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlComponentes.FormattingEnabled = true;
      this.ddlComponentes.Location = new System.Drawing.Point(98, 80);
      this.ddlComponentes.Name = "ddlComponentes";
      this.ddlComponentes.Size = new System.Drawing.Size(40, 21);
      this.ddlComponentes.TabIndex = 10;
      // 
      // chkComponentes
      // 
      this.chkComponentes.AutoSize = true;
      this.chkComponentes.Location = new System.Drawing.Point(12, 82);
      this.chkComponentes.Name = "chkComponentes";
      this.chkComponentes.Size = new System.Drawing.Size(86, 17);
      this.chkComponentes.TabIndex = 9;
      this.chkComponentes.Text = "Componente";
      this.chkComponentes.UseVisualStyleBackColor = true;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.dtpFechaHasta);
      this.groupBox1.Controls.Add(this.dtpFechaDesde);
      this.groupBox1.Controls.Add(this.chkFechaHasta);
      this.groupBox1.Controls.Add(this.chkFechaDesde);
      this.groupBox1.Controls.Add(this.ddlFechaHasta);
      this.groupBox1.Controls.Add(this.ddlFechaDesde);
      this.groupBox1.Location = new System.Drawing.Point(606, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(193, 65);
      this.groupBox1.TabIndex = 18;
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
      this.lstEstado.Location = new System.Drawing.Point(815, 36);
      this.lstEstado.Name = "lstEstado";
      this.lstEstado.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.lstEstado.Size = new System.Drawing.Size(118, 69);
      this.lstEstado.TabIndex = 0;
      this.lstEstado.ValueMember = "Id";
      // 
      // chkEstado
      // 
      this.chkEstado.AutoSize = true;
      this.chkEstado.Location = new System.Drawing.Point(815, 12);
      this.chkEstado.Name = "chkEstado";
      this.chkEstado.Size = new System.Drawing.Size(59, 17);
      this.chkEstado.TabIndex = 19;
      this.chkEstado.Text = "Estado";
      this.chkEstado.UseVisualStyleBackColor = true;
      // 
      // ddlEstado
      // 
      this.ddlEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlEstado.FormattingEnabled = true;
      this.ddlEstado.Location = new System.Drawing.Point(882, 10);
      this.ddlEstado.Name = "ddlEstado";
      this.ddlEstado.Size = new System.Drawing.Size(40, 21);
      this.ddlEstado.TabIndex = 20;
      // 
      // txtNumero
      // 
      this.txtNumero.Location = new System.Drawing.Point(143, 57);
      this.txtNumero.Name = "txtNumero";
      this.txtNumero.Size = new System.Drawing.Size(155, 20);
      this.txtNumero.TabIndex = 8;
      // 
      // ddlNumero
      // 
      this.ddlNumero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlNumero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlNumero.FormattingEnabled = true;
      this.ddlNumero.Location = new System.Drawing.Point(98, 57);
      this.ddlNumero.Name = "ddlNumero";
      this.ddlNumero.Size = new System.Drawing.Size(40, 21);
      this.ddlNumero.TabIndex = 7;
      // 
      // chkNumero
      // 
      this.chkNumero.AutoSize = true;
      this.chkNumero.Location = new System.Drawing.Point(12, 59);
      this.chkNumero.Name = "chkNumero";
      this.chkNumero.Size = new System.Drawing.Size(50, 17);
      this.chkNumero.TabIndex = 6;
      this.chkNumero.Text = "Tarja";
      this.chkNumero.UseVisualStyleBackColor = true;
      // 
      // txtCliente
      // 
      this.txtCliente.Location = new System.Drawing.Point(143, 34);
      this.txtCliente.Name = "txtCliente";
      this.txtCliente.Size = new System.Drawing.Size(155, 20);
      this.txtCliente.TabIndex = 5;
      // 
      // ddlPlanta
      // 
      this.ddlPlanta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlPlanta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlPlanta.DisplayMember = "Planta";
      this.ddlPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlPlanta.FormattingEnabled = true;
      this.ddlPlanta.Location = new System.Drawing.Point(98, 11);
      this.ddlPlanta.Name = "ddlPlanta";
      this.ddlPlanta.Size = new System.Drawing.Size(200, 21);
      this.ddlPlanta.TabIndex = 2;
      this.ddlPlanta.ValueMember = "Id";
      // 
      // ddlCliente
      // 
      this.ddlCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlCliente.FormattingEnabled = true;
      this.ddlCliente.Location = new System.Drawing.Point(98, 34);
      this.ddlCliente.Name = "ddlCliente";
      this.ddlCliente.Size = new System.Drawing.Size(40, 21);
      this.ddlCliente.TabIndex = 4;
      // 
      // chkPlanta
      // 
      this.chkPlanta.AutoSize = true;
      this.chkPlanta.Location = new System.Drawing.Point(12, 13);
      this.chkPlanta.Name = "chkPlanta";
      this.chkPlanta.Size = new System.Drawing.Size(56, 17);
      this.chkPlanta.TabIndex = 1;
      this.chkPlanta.Text = "Planta";
      this.chkPlanta.UseVisualStyleBackColor = true;
      // 
      // chkCliente
      // 
      this.chkCliente.AutoSize = true;
      this.chkCliente.Location = new System.Drawing.Point(12, 36);
      this.chkCliente.Name = "chkCliente";
      this.chkCliente.Size = new System.Drawing.Size(58, 17);
      this.chkCliente.TabIndex = 3;
      this.chkCliente.Text = "Cliente";
      this.chkCliente.UseVisualStyleBackColor = true;
      // 
      // dtgPrincipal
      // 
      this.dtgPrincipal.AllowUserToAddRows = false;
      this.dtgPrincipal.AllowUserToDeleteRows = false;
      this.dtgPrincipal.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dtgPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.dtgPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colnombre_planta,
            this.colNombre,
            this.colFecha,
            this.colnombre_clie,
            this.colnombre_ptt,
            this.colnombre_detPtt,
            this.colEstado,
            this.colnombre_rack,
            this.ColResponsable,
            this.ColAuditor});
      this.dtgPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgPrincipal.IdCopia = 0;
      this.dtgPrincipal.Location = new System.Drawing.Point(0, 185);
      this.dtgPrincipal.Name = "dtgPrincipal";
      this.dtgPrincipal.OpcionCopiarVisible = false;
      this.dtgPrincipal.OpcionEliminarVisible = false;
      this.dtgPrincipal.OpcionesActivas = 63;
      this.dtgPrincipal.OpcionesVisibles = 48;
      this.dtgPrincipal.OpcionInsertarVisible = false;
      this.dtgPrincipal.OpcionPegarVisible = false;
      this.dtgPrincipal.ReadOnly = true;
      this.dtgPrincipal.RefrescandoGrilla = false;
      this.dtgPrincipal.Size = new System.Drawing.Size(1460, 286);
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
      this.dtgTotal.Location = new System.Drawing.Point(0, 161);
      this.dtgTotal.Margin = new System.Windows.Forms.Padding(4);
      this.dtgTotal.Name = "dtgTotal";
      this.dtgTotal.Size = new System.Drawing.Size(1460, 24);
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
      // colNombre
      // 
      this.colNombre.DataPropertyName = "Nombre";
      this.colNombre.HeaderText = "Nombre";
      this.colNombre.MaxInputLength = 150;
      this.colNombre.Name = "colNombre";
      this.colNombre.ReadOnly = true;
      this.colNombre.Width = 120;
      // 
      // colFecha
      // 
      this.colFecha.DataPropertyName = "Fecha";
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle4.Format = "d";
      this.colFecha.DefaultCellStyle = dataGridViewCellStyle4;
      this.colFecha.HeaderText = "Fecha";
      this.colFecha.Name = "colFecha";
      this.colFecha.ReadOnly = true;
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
      // colnombre_ptt
      // 
      this.colnombre_ptt.DataPropertyName = "nombre_ptt";
      this.colnombre_ptt.HeaderText = "PTT";
      this.colnombre_ptt.MaxInputLength = 50;
      this.colnombre_ptt.Name = "colnombre_ptt";
      this.colnombre_ptt.ReadOnly = true;
      this.colnombre_ptt.Width = 250;
      // 
      // colnombre_detPtt
      // 
      this.colnombre_detPtt.DataPropertyName = "nombre_detPtt";
      this.colnombre_detPtt.HeaderText = "Componente";
      this.colnombre_detPtt.MaxInputLength = 50;
      this.colnombre_detPtt.Name = "colnombre_detPtt";
      this.colnombre_detPtt.ReadOnly = true;
      this.colnombre_detPtt.Width = 120;
      // 
      // colEstado
      // 
      this.colEstado.DataPropertyName = "Estado";
      this.colEstado.HeaderText = "Estado";
      this.colEstado.MaxInputLength = 30;
      this.colEstado.Name = "colEstado";
      this.colEstado.ReadOnly = true;
      // 
      // colnombre_rack
      // 
      this.colnombre_rack.DataPropertyName = "nombre_rack";
      this.colnombre_rack.HeaderText = "Rack";
      this.colnombre_rack.MaxInputLength = 20;
      this.colnombre_rack.Name = "colnombre_rack";
      this.colnombre_rack.ReadOnly = true;
      // 
      // ColResponsable
      // 
      this.ColResponsable.DataPropertyName = "Responsable";
      this.ColResponsable.HeaderText = "Responsable";
      this.ColResponsable.Name = "ColResponsable";
      this.ColResponsable.ReadOnly = true;
      // 
      // ColAuditor
      // 
      this.ColAuditor.DataPropertyName = "Auditor";
      this.ColAuditor.HeaderText = "Auditor";
      this.ColAuditor.Name = "ColAuditor";
      this.ColAuditor.ReadOnly = true;
      // 
      // txtAuditor
      // 
      this.txtAuditor.Location = new System.Drawing.Point(435, 34);
      this.txtAuditor.Name = "txtAuditor";
      this.txtAuditor.Size = new System.Drawing.Size(155, 20);
      this.txtAuditor.TabIndex = 17;
      // 
      // ddlAuditor
      // 
      this.ddlAuditor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlAuditor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlAuditor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlAuditor.FormattingEnabled = true;
      this.ddlAuditor.Location = new System.Drawing.Point(390, 34);
      this.ddlAuditor.Name = "ddlAuditor";
      this.ddlAuditor.Size = new System.Drawing.Size(40, 21);
      this.ddlAuditor.TabIndex = 16;
      // 
      // chkAuditor
      // 
      this.chkAuditor.AutoSize = true;
      this.chkAuditor.Location = new System.Drawing.Point(304, 36);
      this.chkAuditor.Name = "chkAuditor";
      this.chkAuditor.Size = new System.Drawing.Size(59, 17);
      this.chkAuditor.TabIndex = 15;
      this.chkAuditor.Text = "Auditor";
      this.chkAuditor.UseVisualStyleBackColor = true;
      // 
      // txtResponsable
      // 
      this.txtResponsable.Location = new System.Drawing.Point(435, 11);
      this.txtResponsable.Name = "txtResponsable";
      this.txtResponsable.Size = new System.Drawing.Size(155, 20);
      this.txtResponsable.TabIndex = 14;
      // 
      // ddlResponsable
      // 
      this.ddlResponsable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlResponsable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlResponsable.FormattingEnabled = true;
      this.ddlResponsable.Location = new System.Drawing.Point(390, 11);
      this.ddlResponsable.Name = "ddlResponsable";
      this.ddlResponsable.Size = new System.Drawing.Size(40, 21);
      this.ddlResponsable.TabIndex = 13;
      // 
      // chkResponsable
      // 
      this.chkResponsable.AutoSize = true;
      this.chkResponsable.Location = new System.Drawing.Point(304, 13);
      this.chkResponsable.Name = "chkResponsable";
      this.chkResponsable.Size = new System.Drawing.Size(88, 17);
      this.chkResponsable.TabIndex = 12;
      this.chkResponsable.Text = "Responsable";
      this.chkResponsable.UseVisualStyleBackColor = true;
      // 
      // InventarioCons
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1460, 493);
      this.Controls.Add(this.dtgPrincipal);
      this.Controls.Add(this.dtgTotal);
      this.Controls.Add(this.pnlPrincipal);
      this.Controls.Add(this.menuItem);
      this.EnterComoTab = true;
      this.KeyPreview = true;
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "InventarioCons";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Consulta de inventarios";
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
    private System.Windows.Forms.TextBox txtCliente;
    private System.Windows.Forms.ComboBox ddlCliente;
    private System.Windows.Forms.CheckBox chkCliente;
    private System.Windows.Forms.TextBox txtNumero;
    private System.Windows.Forms.ComboBox ddlNumero;
    private System.Windows.Forms.CheckBox chkNumero;
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
    private System.Windows.Forms.TextBox txtComponentes;
    private System.Windows.Forms.ComboBox ddlComponentes;
    private System.Windows.Forms.CheckBox chkComponentes;
    private System.Windows.Forms.ComboBox ddlPlanta;
    private System.Windows.Forms.CheckBox chkPlanta;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_planta;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
    private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_clie;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_ptt;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_detPtt;
    private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_rack;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColResponsable;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColAuditor;
    private System.Windows.Forms.TextBox txtAuditor;
    private System.Windows.Forms.ComboBox ddlAuditor;
    private System.Windows.Forms.CheckBox chkAuditor;
    private System.Windows.Forms.TextBox txtResponsable;
    private System.Windows.Forms.ComboBox ddlResponsable;
    private System.Windows.Forms.CheckBox chkResponsable;
  }
}

