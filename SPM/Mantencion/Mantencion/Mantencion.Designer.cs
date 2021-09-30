namespace APP {
  partial class Mantencion {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantencion));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
      this.ddlEstadoMant = new System.Windows.Forms.ComboBox();
      this.txtUsuario = new System.Windows.Forms.TextBox();
      this.chkUsuario = new System.Windows.Forms.CheckBox();
      this.txtNumero = new System.Windows.Forms.TextBox();
      this.ddlNumero = new System.Windows.Forms.ComboBox();
      this.chkNumero = new System.Windows.Forms.CheckBox();
      this.ddlPlantaOrigen = new System.Windows.Forms.ComboBox();
      this.chkPlantaOrigen = new System.Windows.Forms.CheckBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
      this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
      this.chkFechaHasta = new System.Windows.Forms.CheckBox();
      this.chkFechaDesde = new System.Windows.Forms.CheckBox();
      this.ddlFechaHasta = new System.Windows.Forms.ComboBox();
      this.ddlFechaDesde = new System.Windows.Forms.ComboBox();
      this.lstEstado = new System.Windows.Forms.ListBox();
      this.chkEstado = new System.Windows.Forms.CheckBox();
      this.dtgPrincipal = new ITD.Win.Grilla(this.components);
      this.ColPlantaMant = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColNumMant = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColEstadoMant = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColFechaMant = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColObsMant = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColUsuarioMant = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
      this.menuItem.Size = new System.Drawing.Size(892, 25);
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
      this.pnlPrincipal.Controls.Add(this.ddlEstadoMant);
      this.pnlPrincipal.Controls.Add(this.txtUsuario);
      this.pnlPrincipal.Controls.Add(this.chkUsuario);
      this.pnlPrincipal.Controls.Add(this.txtNumero);
      this.pnlPrincipal.Controls.Add(this.ddlNumero);
      this.pnlPrincipal.Controls.Add(this.chkNumero);
      this.pnlPrincipal.Controls.Add(this.ddlPlantaOrigen);
      this.pnlPrincipal.Controls.Add(this.chkPlantaOrigen);
      this.pnlPrincipal.Controls.Add(this.groupBox1);
      this.pnlPrincipal.Controls.Add(this.lstEstado);
      this.pnlPrincipal.Controls.Add(this.chkEstado);
      this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlPrincipal.Location = new System.Drawing.Point(0, 25);
      this.pnlPrincipal.Name = "pnlPrincipal";
      this.pnlPrincipal.Size = new System.Drawing.Size(892, 119);
      this.pnlPrincipal.TabIndex = 7;
      // 
      // ddlEstadoMant
      // 
      this.ddlEstadoMant.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlEstadoMant.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlEstadoMant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlEstadoMant.FormattingEnabled = true;
      this.ddlEstadoMant.Location = new System.Drawing.Point(602, 13);
      this.ddlEstadoMant.Name = "ddlEstadoMant";
      this.ddlEstadoMant.Size = new System.Drawing.Size(57, 21);
      this.ddlEstadoMant.TabIndex = 23;
      // 
      // txtUsuario
      // 
      this.txtUsuario.Location = new System.Drawing.Point(108, 41);
      this.txtUsuario.Name = "txtUsuario";
      this.txtUsuario.Size = new System.Drawing.Size(200, 20);
      this.txtUsuario.TabIndex = 4;
      // 
      // chkUsuario
      // 
      this.chkUsuario.AutoSize = true;
      this.chkUsuario.Location = new System.Drawing.Point(10, 43);
      this.chkUsuario.Name = "chkUsuario";
      this.chkUsuario.Size = new System.Drawing.Size(62, 17);
      this.chkUsuario.TabIndex = 3;
      this.chkUsuario.Text = "Usuario";
      this.chkUsuario.UseVisualStyleBackColor = true;
      // 
      // txtNumero
      // 
      this.txtNumero.Location = new System.Drawing.Point(154, 16);
      this.txtNumero.Name = "txtNumero";
      this.txtNumero.Size = new System.Drawing.Size(154, 20);
      this.txtNumero.TabIndex = 2;
      // 
      // ddlNumero
      // 
      this.ddlNumero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlNumero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlNumero.FormattingEnabled = true;
      this.ddlNumero.Location = new System.Drawing.Point(108, 16);
      this.ddlNumero.Name = "ddlNumero";
      this.ddlNumero.Size = new System.Drawing.Size(40, 21);
      this.ddlNumero.TabIndex = 1;
      // 
      // chkNumero
      // 
      this.chkNumero.AutoSize = true;
      this.chkNumero.Location = new System.Drawing.Point(10, 19);
      this.chkNumero.Name = "chkNumero";
      this.chkNumero.Size = new System.Drawing.Size(63, 17);
      this.chkNumero.TabIndex = 0;
      this.chkNumero.Text = "Número";
      this.chkNumero.UseVisualStyleBackColor = true;
      // 
      // ddlPlantaOrigen
      // 
      this.ddlPlantaOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlPlantaOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlPlantaOrigen.DisplayMember = "Planta";
      this.ddlPlantaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlPlantaOrigen.FormattingEnabled = true;
      this.ddlPlantaOrigen.Location = new System.Drawing.Point(108, 66);
      this.ddlPlantaOrigen.Name = "ddlPlantaOrigen";
      this.ddlPlantaOrigen.Size = new System.Drawing.Size(200, 21);
      this.ddlPlantaOrigen.TabIndex = 6;
      this.ddlPlantaOrigen.ValueMember = "Id";
      // 
      // chkPlantaOrigen
      // 
      this.chkPlantaOrigen.AutoSize = true;
      this.chkPlantaOrigen.Location = new System.Drawing.Point(10, 67);
      this.chkPlantaOrigen.Name = "chkPlantaOrigen";
      this.chkPlantaOrigen.Size = new System.Drawing.Size(56, 17);
      this.chkPlantaOrigen.TabIndex = 5;
      this.chkPlantaOrigen.Text = "Planta";
      this.chkPlantaOrigen.UseVisualStyleBackColor = true;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.dtpFechaHasta);
      this.groupBox1.Controls.Add(this.dtpFechaDesde);
      this.groupBox1.Controls.Add(this.chkFechaHasta);
      this.groupBox1.Controls.Add(this.chkFechaDesde);
      this.groupBox1.Controls.Add(this.ddlFechaHasta);
      this.groupBox1.Controls.Add(this.ddlFechaDesde);
      this.groupBox1.Location = new System.Drawing.Point(328, 16);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(193, 65);
      this.groupBox1.TabIndex = 7;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Filtro fecha";
      // 
      // dtpFechaHasta
      // 
      this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpFechaHasta.Location = new System.Drawing.Point(109, 39);
      this.dtpFechaHasta.Name = "dtpFechaHasta";
      this.dtpFechaHasta.Size = new System.Drawing.Size(84, 20);
      this.dtpFechaHasta.TabIndex = 5;
      // 
      // dtpFechaDesde
      // 
      this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpFechaDesde.Location = new System.Drawing.Point(109, 17);
      this.dtpFechaDesde.Name = "dtpFechaDesde";
      this.dtpFechaDesde.Size = new System.Drawing.Size(84, 20);
      this.dtpFechaDesde.TabIndex = 2;
      // 
      // chkFechaHasta
      // 
      this.chkFechaHasta.AutoSize = true;
      this.chkFechaHasta.Location = new System.Drawing.Point(6, 41);
      this.chkFechaHasta.Name = "chkFechaHasta";
      this.chkFechaHasta.Size = new System.Drawing.Size(54, 17);
      this.chkFechaHasta.TabIndex = 3;
      this.chkFechaHasta.Text = "Hasta";
      this.chkFechaHasta.UseVisualStyleBackColor = true;
      // 
      // chkFechaDesde
      // 
      this.chkFechaDesde.AutoSize = true;
      this.chkFechaDesde.Location = new System.Drawing.Point(6, 19);
      this.chkFechaDesde.Name = "chkFechaDesde";
      this.chkFechaDesde.Size = new System.Drawing.Size(57, 17);
      this.chkFechaDesde.TabIndex = 0;
      this.chkFechaDesde.Text = "Desde";
      this.chkFechaDesde.UseVisualStyleBackColor = true;
      // 
      // ddlFechaHasta
      // 
      this.ddlFechaHasta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlFechaHasta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlFechaHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlFechaHasta.FormattingEnabled = true;
      this.ddlFechaHasta.Location = new System.Drawing.Point(63, 39);
      this.ddlFechaHasta.Name = "ddlFechaHasta";
      this.ddlFechaHasta.Size = new System.Drawing.Size(40, 21);
      this.ddlFechaHasta.TabIndex = 4;
      // 
      // ddlFechaDesde
      // 
      this.ddlFechaDesde.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlFechaDesde.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlFechaDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlFechaDesde.FormattingEnabled = true;
      this.ddlFechaDesde.Location = new System.Drawing.Point(63, 17);
      this.ddlFechaDesde.Name = "ddlFechaDesde";
      this.ddlFechaDesde.Size = new System.Drawing.Size(40, 21);
      this.ddlFechaDesde.TabIndex = 1;
      // 
      // lstEstado
      // 
      this.lstEstado.DisplayMember = "Estado";
      this.lstEstado.FormattingEnabled = true;
      this.lstEstado.Location = new System.Drawing.Point(541, 42);
      this.lstEstado.Name = "lstEstado";
      this.lstEstado.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.lstEstado.Size = new System.Drawing.Size(118, 43);
      this.lstEstado.TabIndex = 10;
      this.lstEstado.ValueMember = "Id";
      // 
      // chkEstado
      // 
      this.chkEstado.AutoSize = true;
      this.chkEstado.Location = new System.Drawing.Point(543, 15);
      this.chkEstado.Name = "chkEstado";
      this.chkEstado.Size = new System.Drawing.Size(59, 17);
      this.chkEstado.TabIndex = 8;
      this.chkEstado.Text = "Estado";
      this.chkEstado.UseVisualStyleBackColor = true;
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
            this.ColPlantaMant,
            this.ColNumMant,
            this.ColEstadoMant,
            this.ColFechaMant,
            this.ColObsMant,
            this.ColUsuarioMant});
      this.dtgPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgPrincipal.IdCopia = 0;
      this.dtgPrincipal.Location = new System.Drawing.Point(0, 168);
      this.dtgPrincipal.Name = "dtgPrincipal";
      this.dtgPrincipal.OpcionCopiarVisible = false;
      this.dtgPrincipal.OpcionEliminarVisible = false;
      this.dtgPrincipal.OpcionesActivas = 63;
      this.dtgPrincipal.OpcionesVisibles = 48;
      this.dtgPrincipal.OpcionInsertarVisible = false;
      this.dtgPrincipal.OpcionPegarVisible = false;
      this.dtgPrincipal.ReadOnly = true;
      this.dtgPrincipal.RefrescandoGrilla = false;
      this.dtgPrincipal.Size = new System.Drawing.Size(892, 303);
      this.dtgPrincipal.TabIndex = 66;
      this.dtgPrincipal.CambiaOperacionRapida += new System.EventHandler<ITD.Win.CambiaOperacionRapidaEvengArg>(this.dtgPrincipal_CambiaOperacionRapida);
      this.dtgPrincipal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_CellDoubleClick);
      this.dtgPrincipal.Sorted += new System.EventHandler(this.dtgPrincipal_Sorted);
      // 
      // ColPlantaMant
      // 
      this.ColPlantaMant.DataPropertyName = "nombre_PLanta";
      this.ColPlantaMant.HeaderText = "Planta";
      this.ColPlantaMant.Name = "ColPlantaMant";
      this.ColPlantaMant.ReadOnly = true;
      this.ColPlantaMant.Width = 150;
      // 
      // ColNumMant
      // 
      this.ColNumMant.DataPropertyName = "Numero";
      this.ColNumMant.HeaderText = "Numero";
      this.ColNumMant.Name = "ColNumMant";
      this.ColNumMant.ReadOnly = true;
      // 
      // ColEstadoMant
      // 
      this.ColEstadoMant.DataPropertyName = "Estado";
      this.ColEstadoMant.HeaderText = "Estado";
      this.ColEstadoMant.Name = "ColEstadoMant";
      this.ColEstadoMant.ReadOnly = true;
      this.ColEstadoMant.Width = 150;
      // 
      // ColFechaMant
      // 
      this.ColFechaMant.DataPropertyName = "Fecha";
      this.ColFechaMant.HeaderText = "Fecha";
      this.ColFechaMant.Name = "ColFechaMant";
      this.ColFechaMant.ReadOnly = true;
      // 
      // ColObsMant
      // 
      this.ColObsMant.DataPropertyName = "Observacion";
      this.ColObsMant.HeaderText = "Observación";
      this.ColObsMant.Name = "ColObsMant";
      this.ColObsMant.ReadOnly = true;
      this.ColObsMant.Width = 200;
      // 
      // ColUsuarioMant
      // 
      this.ColUsuarioMant.DataPropertyName = "nombre_empleado";
      this.ColUsuarioMant.HeaderText = "Usuario";
      this.ColUsuarioMant.Name = "ColUsuarioMant";
      this.ColUsuarioMant.ReadOnly = true;
      this.ColUsuarioMant.Width = 150;
      // 
      // dtgTotal
      // 
      this.dtgTotal.AutoCalculado = false;
      this.dtgTotal.Dock = System.Windows.Forms.DockStyle.Top;
      this.dtgTotal.Grilla = null;
      this.dtgTotal.Location = new System.Drawing.Point(0, 144);
      this.dtgTotal.Name = "dtgTotal";
      this.dtgTotal.Size = new System.Drawing.Size(892, 24);
      this.dtgTotal.TabIndex = 67;
      // 
      // Mantencion
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(892, 493);
      this.Controls.Add(this.dtgPrincipal);
      this.Controls.Add(this.dtgTotal);
      this.Controls.Add(this.pnlPrincipal);
      this.Controls.Add(this.menuItem);
      this.EnterComoTab = true;
      this.KeyPreview = true;
      this.Name = "Mantencion";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Mantención";
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
    private System.Windows.Forms.ListBox lstEstado;
    private System.Windows.Forms.CheckBox chkEstado;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DateTimePicker dtpFechaHasta;
    private System.Windows.Forms.DateTimePicker dtpFechaDesde;
    private System.Windows.Forms.CheckBox chkFechaHasta;
    private System.Windows.Forms.CheckBox chkFechaDesde;
    private System.Windows.Forms.ComboBox ddlFechaHasta;
    private System.Windows.Forms.ComboBox ddlFechaDesde;
    private ITD.Win.GrillaTotal dtgTotal;
    private System.Windows.Forms.ComboBox ddlPlantaOrigen;
    private System.Windows.Forms.CheckBox chkPlantaOrigen;
    private System.Windows.Forms.TextBox txtNumero;
    private System.Windows.Forms.ComboBox ddlNumero;
    private System.Windows.Forms.CheckBox chkNumero;
    private System.Windows.Forms.TextBox txtUsuario;
    private System.Windows.Forms.CheckBox chkUsuario;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColPlantaMant;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColNumMant;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColEstadoMant;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaMant;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColObsMant;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColUsuarioMant;
    private System.Windows.Forms.ComboBox ddlEstadoMant;
  }
}

