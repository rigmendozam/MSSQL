namespace APP {
  partial class Segregar {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Segregar));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.pnlPrincipal = new System.Windows.Forms.Panel();
      this.txtEstado = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtObservacion = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtNumero = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.txtnombre_clie = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.ddlIdPlanta = new System.Windows.Forms.ComboBox();
      this.label21 = new System.Windows.Forms.Label();
      this.tlsPrincipal = new System.Windows.Forms.ToolStrip();
      this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
      this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
      this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.ddlReporte = new System.Windows.Forms.ToolStripComboBox();
      this.tsbReporte = new System.Windows.Forms.ToolStripButton();
      this.tsbFinalizar = new System.Windows.Forms.ToolStripButton();
      this.dtgPrincipal = new ITD.Win.Grilla(this.components);
      this.grillaTotal1 = new ITD.Win.GrillaTotal();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.dtgTarjaIngreso = new ITD.Win.Grilla(this.components);
      this.colid_taring = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColId_Insumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colnombre_insumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.collote_tarIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colvenceLote_tarIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CoCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colLoteNuevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colVenceNuevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColOCNuevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colCantNuevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pnlPrincipal.SuspendLayout();
      this.tlsPrincipal.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgTarjaIngreso)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlPrincipal
      // 
      this.pnlPrincipal.Controls.Add(this.txtEstado);
      this.pnlPrincipal.Controls.Add(this.label2);
      this.pnlPrincipal.Controls.Add(this.txtObservacion);
      this.pnlPrincipal.Controls.Add(this.label4);
      this.pnlPrincipal.Controls.Add(this.txtNumero);
      this.pnlPrincipal.Controls.Add(this.label6);
      this.pnlPrincipal.Controls.Add(this.txtnombre_clie);
      this.pnlPrincipal.Controls.Add(this.label10);
      this.pnlPrincipal.Controls.Add(this.ddlIdPlanta);
      this.pnlPrincipal.Controls.Add(this.label21);
      this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlPrincipal.Location = new System.Drawing.Point(0, 27);
      this.pnlPrincipal.Name = "pnlPrincipal";
      this.pnlPrincipal.Size = new System.Drawing.Size(1046, 223);
      this.pnlPrincipal.TabIndex = 0;
      // 
      // txtEstado
      // 
      this.txtEstado.Location = new System.Drawing.Point(69, 85);
      this.txtEstado.Name = "txtEstado";
      this.txtEstado.ReadOnly = true;
      this.txtEstado.Size = new System.Drawing.Size(120, 20);
      this.txtEstado.TabIndex = 3;
      this.txtEstado.TabStop = false;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 89);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(40, 13);
      this.label2.TabIndex = 38;
      this.label2.Text = "Estado";
      // 
      // txtObservacion
      // 
      this.txtObservacion.Location = new System.Drawing.Point(69, 110);
      this.txtObservacion.Multiline = true;
      this.txtObservacion.Name = "txtObservacion";
      this.txtObservacion.Size = new System.Drawing.Size(473, 91);
      this.txtObservacion.TabIndex = 4;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 115);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(29, 13);
      this.label4.TabIndex = 39;
      this.label4.Text = "Obs.";
      this.tttPrincipal.SetToolTip(this.label4, "Observación");
      // 
      // txtNumero
      // 
      this.txtNumero.Location = new System.Drawing.Point(69, 35);
      this.txtNumero.Name = "txtNumero";
      this.txtNumero.ReadOnly = true;
      this.txtNumero.Size = new System.Drawing.Size(120, 20);
      this.txtNumero.TabIndex = 1;
      this.txtNumero.TabStop = false;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(12, 39);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(44, 13);
      this.label6.TabIndex = 35;
      this.label6.Text = "Número";
      // 
      // txtnombre_clie
      // 
      this.txtnombre_clie.Location = new System.Drawing.Point(69, 60);
      this.txtnombre_clie.Name = "txtnombre_clie";
      this.txtnombre_clie.Size = new System.Drawing.Size(473, 20);
      this.txtnombre_clie.TabIndex = 2;
      this.txtnombre_clie.TextChanged += new System.EventHandler(this.txtrut_clie_TextChanged);
      this.txtnombre_clie.Validated += new System.EventHandler(this.txtnombre_clie_Validated);
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(12, 64);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(39, 13);
      this.label10.TabIndex = 33;
      this.label10.Text = "Cliente";
      // 
      // ddlIdPlanta
      // 
      this.ddlIdPlanta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlIdPlanta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlIdPlanta.DisplayMember = "Planta";
      this.ddlIdPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlIdPlanta.FormattingEnabled = true;
      this.ddlIdPlanta.Location = new System.Drawing.Point(69, 9);
      this.ddlIdPlanta.Name = "ddlIdPlanta";
      this.ddlIdPlanta.Size = new System.Drawing.Size(239, 21);
      this.ddlIdPlanta.TabIndex = 0;
      this.ddlIdPlanta.ValueMember = "Id";
      // 
      // label21
      // 
      this.label21.AutoSize = true;
      this.label21.Location = new System.Drawing.Point(12, 13);
      this.label21.Name = "label21";
      this.label21.Size = new System.Drawing.Size(37, 13);
      this.label21.TabIndex = 30;
      this.label21.Text = "Planta";
      // 
      // tlsPrincipal
      // 
      this.tlsPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.tlsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar,
            this.tsbEliminar,
            this.toolStripSeparator5,
            this.tsbRefrescar,
            this.toolStripSeparator1,
            this.ddlReporte,
            this.tsbReporte,
            this.tsbFinalizar});
      this.tlsPrincipal.Location = new System.Drawing.Point(0, 0);
      this.tlsPrincipal.Name = "tlsPrincipal";
      this.tlsPrincipal.Size = new System.Drawing.Size(1046, 27);
      this.tlsPrincipal.TabIndex = 6;
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
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
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
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
      // 
      // ddlReporte
      // 
      this.ddlReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlReporte.Name = "ddlReporte";
      this.ddlReporte.Size = new System.Drawing.Size(170, 27);
      // 
      // tsbReporte
      // 
      this.tsbReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbReporte.Image = global::APP.Properties.Resources.Reporte;
      this.tsbReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbReporte.Name = "tsbReporte";
      this.tsbReporte.Size = new System.Drawing.Size(24, 24);
      this.tsbReporte.Text = "Reporte";
      this.tsbReporte.Click += new System.EventHandler(this.tsbReporte_Click);
      // 
      // tsbFinalizar
      // 
      this.tsbFinalizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tsbFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("tsbFinalizar.Image")));
      this.tsbFinalizar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbFinalizar.Name = "tsbFinalizar";
      this.tsbFinalizar.Size = new System.Drawing.Size(54, 24);
      this.tsbFinalizar.Text = "Finalizar";
      this.tsbFinalizar.Click += new System.EventHandler(this.tsbFinalizar_Click);
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
            this.CoCodigo,
            this.colLoteNuevo,
            this.colVenceNuevo,
            this.ColOCNuevo,
            this.colCantNuevo});
      this.dtgPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgPrincipal.IdCopia = 0;
      this.dtgPrincipal.Location = new System.Drawing.Point(0, 24);
      this.dtgPrincipal.Name = "dtgPrincipal";
      this.dtgPrincipal.OpcionEditarMasivoVisible = true;
      this.dtgPrincipal.OpcionesActivas = 63;
      this.dtgPrincipal.OpcionesVisibles = 127;
      this.dtgPrincipal.RefrescandoGrilla = false;
      this.dtgPrincipal.Size = new System.Drawing.Size(350, 190);
      this.dtgPrincipal.TabIndex = 67;
      this.dtgPrincipal.CambiaOperacionRapida += new System.EventHandler<ITD.Win.CambiaOperacionRapidaEvengArg>(this.dtgPrincipal_CambiaOperacionRapida);
      this.dtgPrincipal.AntesInsertar += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgPrincipal_AntesInsertar);
      this.dtgPrincipal.DespuesModificarFila += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgPrincipal_DespuesModificarFila);
      this.dtgPrincipal.CurrentCellDirtyStateChanged += new System.EventHandler(this.dtgPrincipal_CurrentCellDirtyStateChanged);
      this.dtgPrincipal.Enter += new System.EventHandler(this.dtgPrincipal_Enter);
      // 
      // grillaTotal1
      // 
      this.grillaTotal1.AutoCalculado = true;
      this.grillaTotal1.Dock = System.Windows.Forms.DockStyle.Top;
      this.grillaTotal1.Grilla = null;
      this.grillaTotal1.Location = new System.Drawing.Point(0, 0);
      this.grillaTotal1.Margin = new System.Windows.Forms.Padding(4);
      this.grillaTotal1.Name = "grillaTotal1";
      this.grillaTotal1.Size = new System.Drawing.Size(350, 24);
      this.grillaTotal1.TabIndex = 68;
      // 
      // splitContainer1
      // 
      this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 250);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.dtgTarjaIngreso);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.dtgPrincipal);
      this.splitContainer1.Panel2.Controls.Add(this.grillaTotal1);
      this.splitContainer1.Size = new System.Drawing.Size(1046, 218);
      this.splitContainer1.SplitterDistance = 688;
      this.splitContainer1.TabIndex = 1;
      // 
      // dtgTarjaIngreso
      // 
      this.dtgTarjaIngreso.AllowUserToAddRows = false;
      this.dtgTarjaIngreso.AllowUserToDeleteRows = false;
      this.dtgTarjaIngreso.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dtgTarjaIngreso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
      this.dtgTarjaIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgTarjaIngreso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colid_taring,
            this.ColId_Insumo,
            this.colnombre_insumo,
            this.colCantidad,
            this.collote_tarIng,
            this.colvenceLote_tarIng,
            this.ColOC});
      this.dtgTarjaIngreso.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgTarjaIngreso.IdCopia = 0;
      this.dtgTarjaIngreso.Location = new System.Drawing.Point(0, 0);
      this.dtgTarjaIngreso.Name = "dtgTarjaIngreso";
      this.dtgTarjaIngreso.OpcionEditarMasivoVisible = true;
      this.dtgTarjaIngreso.OpcionesActivas = 63;
      this.dtgTarjaIngreso.OpcionesVisibles = 127;
      this.dtgTarjaIngreso.RefrescandoGrilla = false;
      this.dtgTarjaIngreso.Size = new System.Drawing.Size(684, 214);
      this.dtgTarjaIngreso.TabIndex = 68;
      this.dtgTarjaIngreso.CambiaOperacionRapida += new System.EventHandler<ITD.Win.CambiaOperacionRapidaEvengArg>(this.dtgPrincipal_CambiaOperacionRapida);
      this.dtgTarjaIngreso.AntesInsertar += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgTarjaIngreso_AntesInsertar);
      this.dtgTarjaIngreso.DespuesCambioFila += new System.EventHandler<ITD.Win.FilaGrillaEventArg>(this.dtgTarjaIngreso_DespuesCambioFila);
      this.dtgTarjaIngreso.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTarjaIngreso_CellValueChanged);
      this.dtgTarjaIngreso.CurrentCellDirtyStateChanged += new System.EventHandler(this.dtgPrincipal_CurrentCellDirtyStateChanged);
      this.dtgTarjaIngreso.Enter += new System.EventHandler(this.dtgPrincipal_Enter);
      // 
      // colid_taring
      // 
      this.colid_taring.DataPropertyName = "id_taring";
      this.colid_taring.HeaderText = "Tarja";
      this.colid_taring.Name = "colid_taring";
      this.colid_taring.Width = 60;
      // 
      // ColId_Insumo
      // 
      this.ColId_Insumo.DataPropertyName = "id_insumo";
      this.ColId_Insumo.HeaderText = "Código";
      this.ColId_Insumo.Name = "ColId_Insumo";
      this.ColId_Insumo.Width = 80;
      // 
      // colnombre_insumo
      // 
      this.colnombre_insumo.DataPropertyName = "nombre_insumo";
      this.colnombre_insumo.HeaderText = "Prod / Ins";
      this.colnombre_insumo.MaxInputLength = 50;
      this.colnombre_insumo.Name = "colnombre_insumo";
      this.colnombre_insumo.ReadOnly = true;
      this.colnombre_insumo.ToolTipText = "Productos / Insumos";
      this.colnombre_insumo.Width = 150;
      // 
      // colCantidad
      // 
      this.colCantidad.DataPropertyName = "Cantidad";
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle5.Format = "#,##0.##";
      this.colCantidad.DefaultCellStyle = dataGridViewCellStyle5;
      this.colCantidad.HeaderText = "Cantidad";
      this.colCantidad.Name = "colCantidad";
      this.colCantidad.ReadOnly = true;
      // 
      // collote_tarIng
      // 
      this.collote_tarIng.DataPropertyName = "lote_tarIng";
      this.collote_tarIng.HeaderText = "Lote";
      this.collote_tarIng.MaxInputLength = 25;
      this.collote_tarIng.Name = "collote_tarIng";
      this.collote_tarIng.ReadOnly = true;
      this.collote_tarIng.Width = 70;
      // 
      // colvenceLote_tarIng
      // 
      this.colvenceLote_tarIng.DataPropertyName = "venceLote_tarIng";
      dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle6.Format = "d";
      this.colvenceLote_tarIng.DefaultCellStyle = dataGridViewCellStyle6;
      this.colvenceLote_tarIng.HeaderText = "Vence";
      this.colvenceLote_tarIng.Name = "colvenceLote_tarIng";
      this.colvenceLote_tarIng.ReadOnly = true;
      this.colvenceLote_tarIng.Width = 75;
      // 
      // ColOC
      // 
      this.ColOC.DataPropertyName = "OC";
      this.ColOC.HeaderText = "OC";
      this.ColOC.Name = "ColOC";
      this.ColOC.ReadOnly = true;
      this.ColOC.Width = 80;
      // 
      // CoCodigo
      // 
      this.CoCodigo.DataPropertyName = "Codigo";
      this.CoCodigo.HeaderText = "Código";
      this.CoCodigo.Name = "CoCodigo";
      this.CoCodigo.Visible = false;
      // 
      // colLoteNuevo
      // 
      this.colLoteNuevo.DataPropertyName = "LoteNuevo";
      this.colLoteNuevo.HeaderText = "Lote";
      this.colLoteNuevo.MaxInputLength = 25;
      this.colLoteNuevo.Name = "colLoteNuevo";
      this.colLoteNuevo.Visible = false;
      this.colLoteNuevo.Width = 60;
      // 
      // colVenceNuevo
      // 
      this.colVenceNuevo.DataPropertyName = "VenceNuevo";
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle2.Format = "d";
      this.colVenceNuevo.DefaultCellStyle = dataGridViewCellStyle2;
      this.colVenceNuevo.HeaderText = "Vence";
      this.colVenceNuevo.Name = "colVenceNuevo";
      this.colVenceNuevo.Visible = false;
      this.colVenceNuevo.Width = 75;
      // 
      // ColOCNuevo
      // 
      this.ColOCNuevo.DataPropertyName = "OCNuevo";
      this.ColOCNuevo.HeaderText = "OC";
      this.ColOCNuevo.Name = "ColOCNuevo";
      this.ColOCNuevo.Width = 80;
      // 
      // colCantNuevo
      // 
      this.colCantNuevo.DataPropertyName = "CantNuevo";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle3.Format = "#,##0.##";
      this.colCantNuevo.DefaultCellStyle = dataGridViewCellStyle3;
      this.colCantNuevo.HeaderText = "Cantidad";
      this.colCantNuevo.Name = "colCantNuevo";
      this.colCantNuevo.Width = 70;
      // 
      // Segregar
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1046, 490);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.pnlPrincipal);
      this.Controls.Add(this.tlsPrincipal);
      this.EnterComoTab = true;
      this.KeyPreview = true;
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "Segregar";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Segregar";
      this.Load += new System.EventHandler(this.ActualizacionGrilla_Load);
      this.Controls.SetChildIndex(this.tlsPrincipal, 0);
      this.Controls.SetChildIndex(this.pnlPrincipal, 0);
      this.Controls.SetChildIndex(this.splitContainer1, 0);
      this.pnlPrincipal.ResumeLayout(false);
      this.pnlPrincipal.PerformLayout();
      this.tlsPrincipal.ResumeLayout(false);
      this.tlsPrincipal.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).EndInit();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dtgTarjaIngreso)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel pnlPrincipal;
    private System.Windows.Forms.ToolStrip tlsPrincipal;
    private System.Windows.Forms.ToolStripButton tsbNuevo;
    private System.Windows.Forms.ToolStripButton tsbRefrescar;
    private System.Windows.Forms.ToolStripButton tsbGuardar;
    private System.Windows.Forms.ToolStripButton tsbEliminar;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripComboBox ddlReporte;
    private System.Windows.Forms.ToolStripButton tsbReporte;
    private ITD.Win.Grilla dtgPrincipal;
    private ITD.Win.GrillaTotal grillaTotal1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private ITD.Win.Grilla dtgTarjaIngreso;
    private System.Windows.Forms.ComboBox ddlIdPlanta;
    private System.Windows.Forms.Label label21;
    private System.Windows.Forms.TextBox txtnombre_clie;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox txtNumero;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtEstado;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtObservacion;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ToolStripButton tsbFinalizar;
    private System.Windows.Forms.DataGridViewTextBoxColumn colid_taring;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColId_Insumo;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_insumo;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
    private System.Windows.Forms.DataGridViewTextBoxColumn collote_tarIng;
    private System.Windows.Forms.DataGridViewTextBoxColumn colvenceLote_tarIng;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColOC;
    private System.Windows.Forms.DataGridViewTextBoxColumn CoCodigo;
    private System.Windows.Forms.DataGridViewTextBoxColumn colLoteNuevo;
    private System.Windows.Forms.DataGridViewTextBoxColumn colVenceNuevo;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColOCNuevo;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCantNuevo;
  }
}