namespace APP {
  partial class TraspasoTarjaIngresoCons {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraspasoTarjaIngresoCons));
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
      this.txtCliente = new System.Windows.Forms.TextBox();
      this.ddlCliente = new System.Windows.Forms.ComboBox();
      this.chkCliente = new System.Windows.Forms.CheckBox();
      this.txtTarja = new System.Windows.Forms.TextBox();
      this.txtProducto = new System.Windows.Forms.TextBox();
      this.ddlTarja = new System.Windows.Forms.ComboBox();
      this.ddlProducto = new System.Windows.Forms.ComboBox();
      this.chkTarja = new System.Windows.Forms.CheckBox();
      this.chkProducto = new System.Windows.Forms.CheckBox();
      this.txtCodProd = new System.Windows.Forms.TextBox();
      this.ddlCodProd = new System.Windows.Forms.ComboBox();
      this.chkCodProd = new System.Windows.Forms.CheckBox();
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
      this.lstEstado = new System.Windows.Forms.ListBox();
      this.chkEstado = new System.Windows.Forms.CheckBox();
      this.ddlEstado = new System.Windows.Forms.ComboBox();
      this.ddlPlantaDes = new System.Windows.Forms.ComboBox();
      this.chkPlantaDes = new System.Windows.Forms.CheckBox();
      this.ddlPlanta = new System.Windows.Forms.ComboBox();
      this.chkPlanta = new System.Windows.Forms.CheckBox();
      this.dtgPrincipal = new ITD.Win.Grilla(this.components);
      this.dtgTotal = new ITD.Win.GrillaTotal();
      this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColFechaCrea = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
      this.menuItem.Size = new System.Drawing.Size(1055, 25);
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
      this.pnlPrincipal.Controls.Add(this.txtCliente);
      this.pnlPrincipal.Controls.Add(this.ddlCliente);
      this.pnlPrincipal.Controls.Add(this.chkCliente);
      this.pnlPrincipal.Controls.Add(this.txtTarja);
      this.pnlPrincipal.Controls.Add(this.txtProducto);
      this.pnlPrincipal.Controls.Add(this.ddlTarja);
      this.pnlPrincipal.Controls.Add(this.ddlProducto);
      this.pnlPrincipal.Controls.Add(this.chkTarja);
      this.pnlPrincipal.Controls.Add(this.chkProducto);
      this.pnlPrincipal.Controls.Add(this.txtCodProd);
      this.pnlPrincipal.Controls.Add(this.ddlCodProd);
      this.pnlPrincipal.Controls.Add(this.chkCodProd);
      this.pnlPrincipal.Controls.Add(this.txtNumero);
      this.pnlPrincipal.Controls.Add(this.ddlNumero);
      this.pnlPrincipal.Controls.Add(this.chkNumero);
      this.pnlPrincipal.Controls.Add(this.groupBox1);
      this.pnlPrincipal.Controls.Add(this.lstEstado);
      this.pnlPrincipal.Controls.Add(this.chkEstado);
      this.pnlPrincipal.Controls.Add(this.ddlEstado);
      this.pnlPrincipal.Controls.Add(this.ddlPlantaDes);
      this.pnlPrincipal.Controls.Add(this.chkPlantaDes);
      this.pnlPrincipal.Controls.Add(this.ddlPlanta);
      this.pnlPrincipal.Controls.Add(this.chkPlanta);
      this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlPrincipal.Location = new System.Drawing.Point(0, 25);
      this.pnlPrincipal.Name = "pnlPrincipal";
      this.pnlPrincipal.Size = new System.Drawing.Size(1055, 135);
      this.pnlPrincipal.TabIndex = 0;
      // 
      // txtCliente
      // 
      this.txtCliente.Location = new System.Drawing.Point(128, 84);
      this.txtCliente.Name = "txtCliente";
      this.txtCliente.Size = new System.Drawing.Size(181, 20);
      this.txtCliente.TabIndex = 9;
      // 
      // ddlCliente
      // 
      this.ddlCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlCliente.FormattingEnabled = true;
      this.ddlCliente.Location = new System.Drawing.Point(83, 84);
      this.ddlCliente.Name = "ddlCliente";
      this.ddlCliente.Size = new System.Drawing.Size(40, 21);
      this.ddlCliente.TabIndex = 8;
      // 
      // chkCliente
      // 
      this.chkCliente.AutoSize = true;
      this.chkCliente.Location = new System.Drawing.Point(9, 86);
      this.chkCliente.Name = "chkCliente";
      this.chkCliente.Size = new System.Drawing.Size(58, 17);
      this.chkCliente.TabIndex = 7;
      this.chkCliente.Text = "Cliente";
      this.chkCliente.UseVisualStyleBackColor = true;
      // 
      // txtTarja
      // 
      this.txtTarja.Location = new System.Drawing.Point(452, 59);
      this.txtTarja.Name = "txtTarja";
      this.txtTarja.Size = new System.Drawing.Size(155, 20);
      this.txtTarja.TabIndex = 18;
      // 
      // txtProducto
      // 
      this.txtProducto.Location = new System.Drawing.Point(452, 34);
      this.txtProducto.Name = "txtProducto";
      this.txtProducto.Size = new System.Drawing.Size(155, 20);
      this.txtProducto.TabIndex = 15;
      // 
      // ddlTarja
      // 
      this.ddlTarja.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlTarja.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlTarja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlTarja.FormattingEnabled = true;
      this.ddlTarja.Location = new System.Drawing.Point(407, 59);
      this.ddlTarja.Name = "ddlTarja";
      this.ddlTarja.Size = new System.Drawing.Size(40, 21);
      this.ddlTarja.TabIndex = 17;
      // 
      // ddlProducto
      // 
      this.ddlProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlProducto.FormattingEnabled = true;
      this.ddlProducto.Location = new System.Drawing.Point(407, 34);
      this.ddlProducto.Name = "ddlProducto";
      this.ddlProducto.Size = new System.Drawing.Size(40, 21);
      this.ddlProducto.TabIndex = 14;
      // 
      // chkTarja
      // 
      this.chkTarja.AutoSize = true;
      this.chkTarja.Location = new System.Drawing.Point(325, 61);
      this.chkTarja.Name = "chkTarja";
      this.chkTarja.Size = new System.Drawing.Size(50, 17);
      this.chkTarja.TabIndex = 16;
      this.chkTarja.Text = "Tarja";
      this.chkTarja.UseVisualStyleBackColor = true;
      // 
      // chkProducto
      // 
      this.chkProducto.AutoSize = true;
      this.chkProducto.Location = new System.Drawing.Point(325, 36);
      this.chkProducto.Name = "chkProducto";
      this.chkProducto.Size = new System.Drawing.Size(82, 17);
      this.chkProducto.TabIndex = 13;
      this.chkProducto.Text = "Descripción";
      this.chkProducto.UseVisualStyleBackColor = true;
      // 
      // txtCodProd
      // 
      this.txtCodProd.Location = new System.Drawing.Point(452, 10);
      this.txtCodProd.Name = "txtCodProd";
      this.txtCodProd.Size = new System.Drawing.Size(155, 20);
      this.txtCodProd.TabIndex = 12;
      // 
      // ddlCodProd
      // 
      this.ddlCodProd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlCodProd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlCodProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlCodProd.FormattingEnabled = true;
      this.ddlCodProd.Location = new System.Drawing.Point(407, 10);
      this.ddlCodProd.Name = "ddlCodProd";
      this.ddlCodProd.Size = new System.Drawing.Size(40, 21);
      this.ddlCodProd.TabIndex = 11;
      // 
      // chkCodProd
      // 
      this.chkCodProd.AutoSize = true;
      this.chkCodProd.Location = new System.Drawing.Point(325, 12);
      this.chkCodProd.Name = "chkCodProd";
      this.chkCodProd.Size = new System.Drawing.Size(59, 17);
      this.chkCodProd.TabIndex = 10;
      this.chkCodProd.Text = "Código";
      this.tttPrincipal.SetToolTip(this.chkCodProd, "Código de producto");
      this.chkCodProd.UseVisualStyleBackColor = true;
      // 
      // txtNumero
      // 
      this.txtNumero.Location = new System.Drawing.Point(128, 10);
      this.txtNumero.Name = "txtNumero";
      this.txtNumero.Size = new System.Drawing.Size(181, 20);
      this.txtNumero.TabIndex = 2;
      // 
      // ddlNumero
      // 
      this.ddlNumero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlNumero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlNumero.FormattingEnabled = true;
      this.ddlNumero.Location = new System.Drawing.Point(83, 10);
      this.ddlNumero.Name = "ddlNumero";
      this.ddlNumero.Size = new System.Drawing.Size(40, 21);
      this.ddlNumero.TabIndex = 1;
      // 
      // chkNumero
      // 
      this.chkNumero.AutoSize = true;
      this.chkNumero.Location = new System.Drawing.Point(9, 12);
      this.chkNumero.Name = "chkNumero";
      this.chkNumero.Size = new System.Drawing.Size(63, 17);
      this.chkNumero.TabIndex = 0;
      this.chkNumero.Text = "Número";
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
      this.groupBox1.Location = new System.Drawing.Point(617, 13);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(193, 65);
      this.groupBox1.TabIndex = 19;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Fecha Creación";
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
      this.lstEstado.Location = new System.Drawing.Point(826, 37);
      this.lstEstado.Name = "lstEstado";
      this.lstEstado.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.lstEstado.Size = new System.Drawing.Size(118, 69);
      this.lstEstado.TabIndex = 22;
      this.lstEstado.ValueMember = "Id";
      // 
      // chkEstado
      // 
      this.chkEstado.AutoSize = true;
      this.chkEstado.Location = new System.Drawing.Point(826, 13);
      this.chkEstado.Name = "chkEstado";
      this.chkEstado.Size = new System.Drawing.Size(59, 17);
      this.chkEstado.TabIndex = 20;
      this.chkEstado.Text = "Estado";
      this.chkEstado.UseVisualStyleBackColor = true;
      // 
      // ddlEstado
      // 
      this.ddlEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlEstado.FormattingEnabled = true;
      this.ddlEstado.Location = new System.Drawing.Point(893, 11);
      this.ddlEstado.Name = "ddlEstado";
      this.ddlEstado.Size = new System.Drawing.Size(40, 21);
      this.ddlEstado.TabIndex = 21;
      // 
      // ddlPlantaDes
      // 
      this.ddlPlantaDes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlPlantaDes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlPlantaDes.DisplayMember = "Planta";
      this.ddlPlantaDes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlPlantaDes.FormattingEnabled = true;
      this.ddlPlantaDes.Location = new System.Drawing.Point(83, 59);
      this.ddlPlantaDes.Name = "ddlPlantaDes";
      this.ddlPlantaDes.Size = new System.Drawing.Size(226, 21);
      this.ddlPlantaDes.TabIndex = 6;
      this.ddlPlantaDes.ValueMember = "Id";
      // 
      // chkPlantaDes
      // 
      this.chkPlantaDes.AutoSize = true;
      this.chkPlantaDes.Location = new System.Drawing.Point(9, 61);
      this.chkPlantaDes.Name = "chkPlantaDes";
      this.chkPlantaDes.Size = new System.Drawing.Size(78, 17);
      this.chkPlantaDes.TabIndex = 5;
      this.chkPlantaDes.Text = "Planta Des";
      this.tttPrincipal.SetToolTip(this.chkPlantaDes, "Planta destino");
      this.chkPlantaDes.UseVisualStyleBackColor = true;
      // 
      // ddlPlanta
      // 
      this.ddlPlanta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlPlanta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlPlanta.DisplayMember = "Planta";
      this.ddlPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlPlanta.FormattingEnabled = true;
      this.ddlPlanta.Location = new System.Drawing.Point(83, 34);
      this.ddlPlanta.Name = "ddlPlanta";
      this.ddlPlanta.Size = new System.Drawing.Size(226, 21);
      this.ddlPlanta.TabIndex = 4;
      this.ddlPlanta.ValueMember = "Id";
      // 
      // chkPlanta
      // 
      this.chkPlanta.AutoSize = true;
      this.chkPlanta.Location = new System.Drawing.Point(9, 36);
      this.chkPlanta.Name = "chkPlanta";
      this.chkPlanta.Size = new System.Drawing.Size(70, 17);
      this.chkPlanta.TabIndex = 3;
      this.chkPlanta.Text = "Planta Or";
      this.tttPrincipal.SetToolTip(this.chkPlanta, "Planta Origen");
      this.chkPlanta.UseVisualStyleBackColor = true;
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
            this.colNumero,
            this.ColFechaCrea,
            this.colOrigen,
            this.colDestino,
            this.colEstado});
      this.dtgPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgPrincipal.IdCopia = 0;
      this.dtgPrincipal.Location = new System.Drawing.Point(0, 184);
      this.dtgPrincipal.Name = "dtgPrincipal";
      this.dtgPrincipal.OpcionCopiarVisible = false;
      this.dtgPrincipal.OpcionEliminarVisible = false;
      this.dtgPrincipal.OpcionesActivas = 63;
      this.dtgPrincipal.OpcionesVisibles = 48;
      this.dtgPrincipal.OpcionInsertarVisible = false;
      this.dtgPrincipal.OpcionPegarVisible = false;
      this.dtgPrincipal.ReadOnly = true;
      this.dtgPrincipal.RefrescandoGrilla = false;
      this.dtgPrincipal.Size = new System.Drawing.Size(1055, 287);
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
      this.dtgTotal.Location = new System.Drawing.Point(0, 160);
      this.dtgTotal.Name = "dtgTotal";
      this.dtgTotal.Size = new System.Drawing.Size(1055, 24);
      this.dtgTotal.TabIndex = 67;
      // 
      // colNumero
      // 
      this.colNumero.DataPropertyName = "Numero";
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle2.Format = "#,##0.##";
      this.colNumero.DefaultCellStyle = dataGridViewCellStyle2;
      this.colNumero.HeaderText = "Numero";
      this.colNumero.Name = "colNumero";
      this.colNumero.ReadOnly = true;
      this.colNumero.Width = 80;
      // 
      // ColFechaCrea
      // 
      this.ColFechaCrea.DataPropertyName = "FechaCrea";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle3.Format = "g";
      this.ColFechaCrea.DefaultCellStyle = dataGridViewCellStyle3;
      this.ColFechaCrea.HeaderText = "Fecha";
      this.ColFechaCrea.Name = "ColFechaCrea";
      this.ColFechaCrea.ReadOnly = true;
      // 
      // colOrigen
      // 
      this.colOrigen.DataPropertyName = "Origen";
      this.colOrigen.HeaderText = "Origen";
      this.colOrigen.MaxInputLength = 20;
      this.colOrigen.Name = "colOrigen";
      this.colOrigen.ReadOnly = true;
      this.colOrigen.Width = 120;
      // 
      // colDestino
      // 
      this.colDestino.DataPropertyName = "Destino";
      this.colDestino.HeaderText = "Destino";
      this.colDestino.MaxInputLength = 20;
      this.colDestino.Name = "colDestino";
      this.colDestino.ReadOnly = true;
      this.colDestino.Width = 120;
      // 
      // colEstado
      // 
      this.colEstado.DataPropertyName = "Estado";
      this.colEstado.HeaderText = "Estado";
      this.colEstado.MaxInputLength = 50;
      this.colEstado.Name = "colEstado";
      this.colEstado.ReadOnly = true;
      // 
      // TraspasoTarjaIngresoCons
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1055, 493);
      this.Controls.Add(this.dtgPrincipal);
      this.Controls.Add(this.dtgTotal);
      this.Controls.Add(this.pnlPrincipal);
      this.Controls.Add(this.menuItem);
      this.EnterComoTab = true;
      this.KeyPreview = true;
      this.Name = "TraspasoTarjaIngresoCons";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Consulta traspasos de tarja de ingreso";
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
    private System.Windows.Forms.ComboBox ddlPlantaDes;
    private System.Windows.Forms.CheckBox chkPlantaDes;
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
    private System.Windows.Forms.TextBox txtNumero;
    private System.Windows.Forms.ComboBox ddlNumero;
    private System.Windows.Forms.CheckBox chkNumero;
    private System.Windows.Forms.TextBox txtTarja;
    private System.Windows.Forms.TextBox txtProducto;
    private System.Windows.Forms.ComboBox ddlTarja;
    private System.Windows.Forms.ComboBox ddlProducto;
    private System.Windows.Forms.CheckBox chkTarja;
    private System.Windows.Forms.CheckBox chkProducto;
    private System.Windows.Forms.TextBox txtCodProd;
    private System.Windows.Forms.ComboBox ddlCodProd;
    private System.Windows.Forms.CheckBox chkCodProd;
    private System.Windows.Forms.TextBox txtCliente;
    private System.Windows.Forms.ComboBox ddlCliente;
    private System.Windows.Forms.CheckBox chkCliente;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaCrea;
    private System.Windows.Forms.DataGridViewTextBoxColumn colOrigen;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDestino;
    private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
  }
}

