namespace APP {
  partial class DesviacionPlanAccionCons {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesviacionPlanAccionCons));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.menuItem = new System.Windows.Forms.ToolStrip();
      this.tsbModificar = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbFiltrar = new System.Windows.Forms.ToolStripButton();
      this.tsbQuitarFiltro = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbMostrarFiltros = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.ddlReporte = new System.Windows.Forms.ToolStripComboBox();
      this.tsbReporte = new System.Windows.Forms.ToolStripButton();
      this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
      this.pnlPrincipal = new System.Windows.Forms.Panel();
      this.ddlSistema = new System.Windows.Forms.ComboBox();
      this.chkSistema = new System.Windows.Forms.CheckBox();
      this.ddlTipoHallazgo = new System.Windows.Forms.ComboBox();
      this.chkTipoHallazgo = new System.Windows.Forms.CheckBox();
      this.ddlArea = new System.Windows.Forms.ComboBox();
      this.chkArea = new System.Windows.Forms.CheckBox();
      this.ddlOrigen = new System.Windows.Forms.ComboBox();
      this.chkOrigen = new System.Windows.Forms.CheckBox();
      this.ddlPlanta = new System.Windows.Forms.ComboBox();
      this.chkPlanta = new System.Windows.Forms.CheckBox();
      this.txtSolicitante = new System.Windows.Forms.TextBox();
      this.txtNumero = new System.Windows.Forms.TextBox();
      this.chkSolicitante = new System.Windows.Forms.CheckBox();
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
      this.dtgPrincipal = new ITD.Win.Grilla(this.components);
      this.dtgTotal = new ITD.Win.GrillaTotal();
      this.colnombre_planta = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTipoHallazgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colProblema = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colnombre_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColCargar = new System.Windows.Forms.DataGridViewImageColumn();
      this.ColVer = new System.Windows.Forms.DataGridViewImageColumn();
      this.menuItem.SuspendLayout();
      this.pnlPrincipal.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
      this.SuspendLayout();
      // 
      // menuItem
      // 
      this.menuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbModificar,
            this.toolStripSeparator1,
            this.tsbFiltrar,
            this.tsbQuitarFiltro,
            this.toolStripSeparator3,
            this.tsbMostrarFiltros,
            this.toolStripSeparator2,
            this.ddlReporte,
            this.tsbReporte,
            this.tsbCerrar});
      this.menuItem.Location = new System.Drawing.Point(0, 0);
      this.menuItem.Name = "menuItem";
      this.menuItem.Size = new System.Drawing.Size(1375, 25);
      this.menuItem.TabIndex = 6;
      this.menuItem.Text = "toolStrip1";
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
      // tsbCerrar
      // 
      this.tsbCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tsbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCerrar.Image")));
      this.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbCerrar.Name = "tsbCerrar";
      this.tsbCerrar.Size = new System.Drawing.Size(43, 22);
      this.tsbCerrar.Text = "Cerrar";
      this.tsbCerrar.Click += new System.EventHandler(this.tsbCerrar_Click);
      // 
      // pnlPrincipal
      // 
      this.pnlPrincipal.AutoScroll = true;
      this.pnlPrincipal.Controls.Add(this.ddlSistema);
      this.pnlPrincipal.Controls.Add(this.chkSistema);
      this.pnlPrincipal.Controls.Add(this.ddlTipoHallazgo);
      this.pnlPrincipal.Controls.Add(this.chkTipoHallazgo);
      this.pnlPrincipal.Controls.Add(this.ddlArea);
      this.pnlPrincipal.Controls.Add(this.chkArea);
      this.pnlPrincipal.Controls.Add(this.ddlOrigen);
      this.pnlPrincipal.Controls.Add(this.chkOrigen);
      this.pnlPrincipal.Controls.Add(this.ddlPlanta);
      this.pnlPrincipal.Controls.Add(this.chkPlanta);
      this.pnlPrincipal.Controls.Add(this.txtSolicitante);
      this.pnlPrincipal.Controls.Add(this.txtNumero);
      this.pnlPrincipal.Controls.Add(this.chkSolicitante);
      this.pnlPrincipal.Controls.Add(this.ddlNumero);
      this.pnlPrincipal.Controls.Add(this.chkNumero);
      this.pnlPrincipal.Controls.Add(this.groupBox1);
      this.pnlPrincipal.Controls.Add(this.lstEstado);
      this.pnlPrincipal.Controls.Add(this.chkEstado);
      this.pnlPrincipal.Controls.Add(this.ddlEstado);
      this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlPrincipal.Location = new System.Drawing.Point(0, 25);
      this.pnlPrincipal.Name = "pnlPrincipal";
      this.pnlPrincipal.Size = new System.Drawing.Size(1375, 142);
      this.pnlPrincipal.TabIndex = 7;
      // 
      // ddlSistema
      // 
      this.ddlSistema.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlSistema.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlSistema.DisplayMember = "Sistema";
      this.ddlSistema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlSistema.FormattingEnabled = true;
      this.ddlSistema.Location = new System.Drawing.Point(101, 61);
      this.ddlSistema.Name = "ddlSistema";
      this.ddlSistema.Size = new System.Drawing.Size(200, 21);
      this.ddlSistema.TabIndex = 56;
      this.ddlSistema.ValueMember = "Id";
      // 
      // chkSistema
      // 
      this.chkSistema.AutoSize = true;
      this.chkSistema.Location = new System.Drawing.Point(12, 63);
      this.chkSistema.Name = "chkSistema";
      this.chkSistema.Size = new System.Drawing.Size(63, 17);
      this.chkSistema.TabIndex = 52;
      this.chkSistema.Text = "Sistema";
      this.chkSistema.UseVisualStyleBackColor = true;
      // 
      // ddlTipoHallazgo
      // 
      this.ddlTipoHallazgo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlTipoHallazgo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlTipoHallazgo.DisplayMember = "Tipo";
      this.ddlTipoHallazgo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlTipoHallazgo.FormattingEnabled = true;
      this.ddlTipoHallazgo.Location = new System.Drawing.Point(425, 61);
      this.ddlTipoHallazgo.Name = "ddlTipoHallazgo";
      this.ddlTipoHallazgo.Size = new System.Drawing.Size(200, 21);
      this.ddlTipoHallazgo.TabIndex = 55;
      this.ddlTipoHallazgo.ValueMember = "Id";
      // 
      // chkTipoHallazgo
      // 
      this.chkTipoHallazgo.AutoSize = true;
      this.chkTipoHallazgo.Location = new System.Drawing.Point(338, 63);
      this.chkTipoHallazgo.Name = "chkTipoHallazgo";
      this.chkTipoHallazgo.Size = new System.Drawing.Size(89, 17);
      this.chkTipoHallazgo.TabIndex = 51;
      this.chkTipoHallazgo.Text = "Tipo hallazgo";
      this.chkTipoHallazgo.UseVisualStyleBackColor = true;
      // 
      // ddlArea
      // 
      this.ddlArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlArea.DisplayMember = "Nombre";
      this.ddlArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlArea.FormattingEnabled = true;
      this.ddlArea.Location = new System.Drawing.Point(425, 36);
      this.ddlArea.Name = "ddlArea";
      this.ddlArea.Size = new System.Drawing.Size(200, 21);
      this.ddlArea.TabIndex = 54;
      this.ddlArea.ValueMember = "Id";
      // 
      // chkArea
      // 
      this.chkArea.AutoSize = true;
      this.chkArea.Location = new System.Drawing.Point(338, 38);
      this.chkArea.Name = "chkArea";
      this.chkArea.Size = new System.Drawing.Size(48, 17);
      this.chkArea.TabIndex = 50;
      this.chkArea.Text = "Área";
      this.chkArea.UseVisualStyleBackColor = true;
      // 
      // ddlOrigen
      // 
      this.ddlOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlOrigen.DisplayMember = "Origen";
      this.ddlOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlOrigen.FormattingEnabled = true;
      this.ddlOrigen.Location = new System.Drawing.Point(425, 12);
      this.ddlOrigen.Name = "ddlOrigen";
      this.ddlOrigen.Size = new System.Drawing.Size(200, 21);
      this.ddlOrigen.TabIndex = 53;
      this.ddlOrigen.ValueMember = "Id";
      // 
      // chkOrigen
      // 
      this.chkOrigen.AutoSize = true;
      this.chkOrigen.Location = new System.Drawing.Point(338, 14);
      this.chkOrigen.Name = "chkOrigen";
      this.chkOrigen.Size = new System.Drawing.Size(57, 17);
      this.chkOrigen.TabIndex = 49;
      this.chkOrigen.Text = "Origen";
      this.chkOrigen.UseVisualStyleBackColor = true;
      // 
      // ddlPlanta
      // 
      this.ddlPlanta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlPlanta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlPlanta.DisplayMember = "Planta";
      this.ddlPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlPlanta.FormattingEnabled = true;
      this.ddlPlanta.Location = new System.Drawing.Point(101, 36);
      this.ddlPlanta.Name = "ddlPlanta";
      this.ddlPlanta.Size = new System.Drawing.Size(226, 21);
      this.ddlPlanta.TabIndex = 48;
      this.ddlPlanta.ValueMember = "Id";
      // 
      // chkPlanta
      // 
      this.chkPlanta.AutoSize = true;
      this.chkPlanta.Location = new System.Drawing.Point(12, 38);
      this.chkPlanta.Name = "chkPlanta";
      this.chkPlanta.Size = new System.Drawing.Size(56, 17);
      this.chkPlanta.TabIndex = 47;
      this.chkPlanta.Text = "Planta";
      this.tttPrincipal.SetToolTip(this.chkPlanta, "Planta Origen");
      this.chkPlanta.UseVisualStyleBackColor = true;
      // 
      // txtSolicitante
      // 
      this.txtSolicitante.Location = new System.Drawing.Point(101, 86);
      this.txtSolicitante.Name = "txtSolicitante";
      this.txtSolicitante.Size = new System.Drawing.Size(226, 20);
      this.txtSolicitante.TabIndex = 46;
      // 
      // txtNumero
      // 
      this.txtNumero.Location = new System.Drawing.Point(146, 12);
      this.txtNumero.Name = "txtNumero";
      this.txtNumero.Size = new System.Drawing.Size(181, 20);
      this.txtNumero.TabIndex = 45;
      // 
      // chkSolicitante
      // 
      this.chkSolicitante.AutoSize = true;
      this.chkSolicitante.Location = new System.Drawing.Point(12, 88);
      this.chkSolicitante.Name = "chkSolicitante";
      this.chkSolicitante.Size = new System.Drawing.Size(88, 17);
      this.chkSolicitante.TabIndex = 43;
      this.chkSolicitante.Text = "Responsable";
      this.chkSolicitante.UseVisualStyleBackColor = true;
      // 
      // ddlNumero
      // 
      this.ddlNumero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlNumero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlNumero.FormattingEnabled = true;
      this.ddlNumero.Location = new System.Drawing.Point(101, 12);
      this.ddlNumero.Name = "ddlNumero";
      this.ddlNumero.Size = new System.Drawing.Size(40, 21);
      this.ddlNumero.TabIndex = 44;
      // 
      // chkNumero
      // 
      this.chkNumero.AutoSize = true;
      this.chkNumero.Location = new System.Drawing.Point(12, 14);
      this.chkNumero.Name = "chkNumero";
      this.chkNumero.Size = new System.Drawing.Size(63, 17);
      this.chkNumero.TabIndex = 42;
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
      this.groupBox1.Location = new System.Drawing.Point(631, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(193, 65);
      this.groupBox1.TabIndex = 38;
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
      this.lstEstado.Location = new System.Drawing.Point(840, 36);
      this.lstEstado.Name = "lstEstado";
      this.lstEstado.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.lstEstado.Size = new System.Drawing.Size(118, 69);
      this.lstEstado.TabIndex = 41;
      this.lstEstado.ValueMember = "Id";
      // 
      // chkEstado
      // 
      this.chkEstado.AutoSize = true;
      this.chkEstado.Location = new System.Drawing.Point(840, 12);
      this.chkEstado.Name = "chkEstado";
      this.chkEstado.Size = new System.Drawing.Size(59, 17);
      this.chkEstado.TabIndex = 39;
      this.chkEstado.Text = "Estado";
      this.chkEstado.UseVisualStyleBackColor = true;
      // 
      // ddlEstado
      // 
      this.ddlEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlEstado.FormattingEnabled = true;
      this.ddlEstado.Location = new System.Drawing.Point(907, 10);
      this.ddlEstado.Name = "ddlEstado";
      this.ddlEstado.Size = new System.Drawing.Size(40, 21);
      this.ddlEstado.TabIndex = 40;
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
            this.colOrigen,
            this.colArea,
            this.colTipoHallazgo,
            this.colSistema,
            this.colFecha,
            this.colProblema,
            this.colMedida,
            this.colnombre_empleado,
            this.colEstado,
            this.ColCargar,
            this.ColVer});
      this.dtgPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgPrincipal.IdCopia = 0;
      this.dtgPrincipal.Location = new System.Drawing.Point(0, 191);
      this.dtgPrincipal.Name = "dtgPrincipal";
      this.dtgPrincipal.OpcionCopiarVisible = false;
      this.dtgPrincipal.OpcionEliminarVisible = false;
      this.dtgPrincipal.OpcionesActivas = 63;
      this.dtgPrincipal.OpcionesVisibles = 48;
      this.dtgPrincipal.OpcionInsertarVisible = false;
      this.dtgPrincipal.OpcionPegarVisible = false;
      this.dtgPrincipal.ReadOnly = true;
      this.dtgPrincipal.RefrescandoGrilla = false;
      this.dtgPrincipal.Size = new System.Drawing.Size(1375, 280);
      this.dtgPrincipal.TabIndex = 66;
      this.dtgPrincipal.CambiaOperacionRapida += new System.EventHandler<ITD.Win.CambiaOperacionRapidaEvengArg>(this.dtgPrincipal_CambiaOperacionRapida);
      this.dtgPrincipal.DespuesCambioFila += new System.EventHandler<ITD.Win.FilaGrillaEventArg>(this.dtgPrincipal_DespuesCambioFila);
      this.dtgPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_CellContentClick);
      this.dtgPrincipal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_CellDoubleClick);
      this.dtgPrincipal.Sorted += new System.EventHandler(this.dtgPrincipal_Sorted);
      // 
      // dtgTotal
      // 
      this.dtgTotal.AutoCalculado = false;
      this.dtgTotal.Dock = System.Windows.Forms.DockStyle.Top;
      this.dtgTotal.Grilla = null;
      this.dtgTotal.Location = new System.Drawing.Point(0, 167);
      this.dtgTotal.Name = "dtgTotal";
      this.dtgTotal.Size = new System.Drawing.Size(1375, 24);
      this.dtgTotal.TabIndex = 67;
      // 
      // colnombre_planta
      // 
      this.colnombre_planta.DataPropertyName = "nombre_planta";
      this.colnombre_planta.HeaderText = "Planta";
      this.colnombre_planta.MaxInputLength = 20;
      this.colnombre_planta.Name = "colnombre_planta";
      this.colnombre_planta.ReadOnly = true;
      this.colnombre_planta.Width = 80;
      // 
      // ColNumero
      // 
      this.ColNumero.DataPropertyName = "Numero";
      this.ColNumero.HeaderText = "Número";
      this.ColNumero.Name = "ColNumero";
      this.ColNumero.ReadOnly = true;
      this.ColNumero.Width = 75;
      // 
      // colOrigen
      // 
      this.colOrigen.DataPropertyName = "Origen";
      this.colOrigen.HeaderText = "Origen";
      this.colOrigen.MaxInputLength = 50;
      this.colOrigen.Name = "colOrigen";
      this.colOrigen.ReadOnly = true;
      // 
      // colArea
      // 
      this.colArea.DataPropertyName = "Area";
      this.colArea.HeaderText = "Área";
      this.colArea.MaxInputLength = 50;
      this.colArea.Name = "colArea";
      this.colArea.ReadOnly = true;
      this.colArea.Width = 150;
      // 
      // colTipoHallazgo
      // 
      this.colTipoHallazgo.DataPropertyName = "TipoHallazgo";
      this.colTipoHallazgo.HeaderText = "Tipo Hallazgo";
      this.colTipoHallazgo.MaxInputLength = 50;
      this.colTipoHallazgo.Name = "colTipoHallazgo";
      this.colTipoHallazgo.ReadOnly = true;
      this.colTipoHallazgo.Width = 150;
      // 
      // colSistema
      // 
      this.colSistema.DataPropertyName = "Sistema";
      this.colSistema.HeaderText = "Sistema";
      this.colSistema.MaxInputLength = 50;
      this.colSistema.Name = "colSistema";
      this.colSistema.ReadOnly = true;
      this.colSistema.Width = 70;
      // 
      // colFecha
      // 
      this.colFecha.DataPropertyName = "Fecha";
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle2.Format = "d";
      this.colFecha.DefaultCellStyle = dataGridViewCellStyle2;
      this.colFecha.HeaderText = "Fecha";
      this.colFecha.Name = "colFecha";
      this.colFecha.ReadOnly = true;
      this.colFecha.Width = 75;
      // 
      // colProblema
      // 
      this.colProblema.DataPropertyName = "Problema";
      this.colProblema.HeaderText = "Problema";
      this.colProblema.MaxInputLength = 1500;
      this.colProblema.Name = "colProblema";
      this.colProblema.ReadOnly = true;
      this.colProblema.Width = 150;
      // 
      // colMedida
      // 
      this.colMedida.DataPropertyName = "Medida";
      this.colMedida.HeaderText = "Medida";
      this.colMedida.MaxInputLength = 1500;
      this.colMedida.Name = "colMedida";
      this.colMedida.ReadOnly = true;
      // 
      // colnombre_empleado
      // 
      this.colnombre_empleado.DataPropertyName = "nombre_empleado";
      this.colnombre_empleado.HeaderText = "Responsable";
      this.colnombre_empleado.MaxInputLength = 80;
      this.colnombre_empleado.Name = "colnombre_empleado";
      this.colnombre_empleado.ReadOnly = true;
      this.colnombre_empleado.Width = 150;
      // 
      // colEstado
      // 
      this.colEstado.DataPropertyName = "Estado";
      this.colEstado.HeaderText = "Estado";
      this.colEstado.MaxInputLength = 30;
      this.colEstado.Name = "colEstado";
      this.colEstado.ReadOnly = true;
      // 
      // ColCargar
      // 
      this.ColCargar.HeaderText = "Cargar";
      this.ColCargar.Image = global::APP.Properties.Resources.cargarDoc16x16;
      this.ColCargar.Name = "ColCargar";
      this.ColCargar.ReadOnly = true;
      this.ColCargar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.ColCargar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.ColCargar.Width = 50;
      // 
      // ColVer
      // 
      this.ColVer.HeaderText = "Ver";
      this.ColVer.Image = global::APP.Properties.Resources.VistaPrevia;
      this.ColVer.Name = "ColVer";
      this.ColVer.ReadOnly = true;
      this.ColVer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.ColVer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.ColVer.Width = 40;
      // 
      // DesviacionPlanAccionCons
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1375, 493);
      this.Controls.Add(this.dtgPrincipal);
      this.Controls.Add(this.dtgTotal);
      this.Controls.Add(this.pnlPrincipal);
      this.Controls.Add(this.menuItem);
      this.EnterComoTab = true;
      this.KeyPreview = true;
      this.Name = "DesviacionPlanAccionCons";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Consulta de planes de acción";
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
    private System.Windows.Forms.ToolStripButton tsbModificar;
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
    private System.Windows.Forms.ComboBox ddlSistema;
    private System.Windows.Forms.CheckBox chkSistema;
    private System.Windows.Forms.ComboBox ddlTipoHallazgo;
    private System.Windows.Forms.CheckBox chkTipoHallazgo;
    private System.Windows.Forms.ComboBox ddlArea;
    private System.Windows.Forms.CheckBox chkArea;
    private System.Windows.Forms.ComboBox ddlOrigen;
    private System.Windows.Forms.CheckBox chkOrigen;
    private System.Windows.Forms.ComboBox ddlPlanta;
    private System.Windows.Forms.CheckBox chkPlanta;
    private System.Windows.Forms.TextBox txtSolicitante;
    private System.Windows.Forms.TextBox txtNumero;
    private System.Windows.Forms.CheckBox chkSolicitante;
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
    private System.Windows.Forms.ToolStripButton tsbCerrar;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_planta;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColNumero;
    private System.Windows.Forms.DataGridViewTextBoxColumn colOrigen;
    private System.Windows.Forms.DataGridViewTextBoxColumn colArea;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTipoHallazgo;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSistema;
    private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
    private System.Windows.Forms.DataGridViewTextBoxColumn colProblema;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMedida;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_empleado;
    private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    private System.Windows.Forms.DataGridViewImageColumn ColCargar;
    private System.Windows.Forms.DataGridViewImageColumn ColVer;
  }
}

