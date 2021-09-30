namespace APP {
  partial class Inventario {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      this.pnlPrincipal = new System.Windows.Forms.Panel();
      this.txtMonitora = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.txtResponsable = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtCodDesc = new System.Windows.Forms.TextBox();
      this.ddlTipo = new System.Windows.Forms.ComboBox();
      this.label9 = new System.Windows.Forms.Label();
      this.ddlPlanta = new System.Windows.Forms.ComboBox();
      this.label21 = new System.Windows.Forms.Label();
      this.ddlIdBodega = new System.Windows.Forms.ComboBox();
      this.ddlIdRack = new System.Windows.Forms.ComboBox();
      this.dtpFecha = new System.Windows.Forms.DateTimePicker();
      this.txtObservacion = new System.Windows.Forms.TextBox();
      this.txtIdCliente = new System.Windows.Forms.TextBox();
      this.txtNombre = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.tlsPrincipal = new System.Windows.Forms.ToolStrip();
      this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
      this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
      this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.ddlReporte = new System.Windows.Forms.ToolStripComboBox();
      this.tsbReporte = new System.Windows.Forms.ToolStripButton();
      this.tsbIniciar = new System.Windows.Forms.ToolStripButton();
      this.tsbFinalizar = new System.Windows.Forms.ToolStripButton();
      this.tsbAprobar = new System.Windows.Forms.ToolStripButton();
      this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
      this.tsbAuditar = new System.Windows.Forms.ToolStripButton();
      this.dtgPrincipal = new ITD.Win.Grilla(this.components);
      this.colid_taring = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colIdPosicion = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colVence = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colIdPosicionNueva = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.ColNuevaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colMixto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.ColContador = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColFechaConteo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.grillaTotal1 = new ITD.Win.GrillaTotal();
      this.pnlPrincipal.SuspendLayout();
      this.tlsPrincipal.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlPrincipal
      // 
      this.pnlPrincipal.Controls.Add(this.txtMonitora);
      this.pnlPrincipal.Controls.Add(this.label10);
      this.pnlPrincipal.Controls.Add(this.txtResponsable);
      this.pnlPrincipal.Controls.Add(this.label5);
      this.pnlPrincipal.Controls.Add(this.txtCodDesc);
      this.pnlPrincipal.Controls.Add(this.ddlTipo);
      this.pnlPrincipal.Controls.Add(this.label9);
      this.pnlPrincipal.Controls.Add(this.ddlPlanta);
      this.pnlPrincipal.Controls.Add(this.label21);
      this.pnlPrincipal.Controls.Add(this.ddlIdBodega);
      this.pnlPrincipal.Controls.Add(this.ddlIdRack);
      this.pnlPrincipal.Controls.Add(this.dtpFecha);
      this.pnlPrincipal.Controls.Add(this.txtObservacion);
      this.pnlPrincipal.Controls.Add(this.txtIdCliente);
      this.pnlPrincipal.Controls.Add(this.txtNombre);
      this.pnlPrincipal.Controls.Add(this.label8);
      this.pnlPrincipal.Controls.Add(this.label7);
      this.pnlPrincipal.Controls.Add(this.label6);
      this.pnlPrincipal.Controls.Add(this.label4);
      this.pnlPrincipal.Controls.Add(this.label3);
      this.pnlPrincipal.Controls.Add(this.label2);
      this.pnlPrincipal.Controls.Add(this.label1);
      this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlPrincipal.Location = new System.Drawing.Point(0, 27);
      this.pnlPrincipal.Name = "pnlPrincipal";
      this.pnlPrincipal.Size = new System.Drawing.Size(1312, 177);
      this.pnlPrincipal.TabIndex = 0;
      // 
      // txtMonitora
      // 
      this.txtMonitora.Location = new System.Drawing.Point(845, 59);
      this.txtMonitora.Margin = new System.Windows.Forms.Padding(2);
      this.txtMonitora.Name = "txtMonitora";
      this.txtMonitora.Size = new System.Drawing.Size(282, 20);
      this.txtMonitora.TabIndex = 10;
      this.txtMonitora.TextChanged += new System.EventHandler(this.txtMonitora_TextChanged);
      this.txtMonitora.Validated += new System.EventHandler(this.txtMonitora_Validated);
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(774, 63);
      this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(48, 13);
      this.label10.TabIndex = 80;
      this.label10.Text = "Monitora";
      // 
      // txtResponsable
      // 
      this.txtResponsable.Location = new System.Drawing.Point(845, 33);
      this.txtResponsable.Margin = new System.Windows.Forms.Padding(2);
      this.txtResponsable.Name = "txtResponsable";
      this.txtResponsable.Size = new System.Drawing.Size(282, 20);
      this.txtResponsable.TabIndex = 9;
      this.txtResponsable.TextChanged += new System.EventHandler(this.txtResponsable_TextChanged);
      this.txtResponsable.Validated += new System.EventHandler(this.txtResponsable_Validated);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(774, 37);
      this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(69, 13);
      this.label5.TabIndex = 80;
      this.label5.Text = "Responsable";
      // 
      // txtCodDesc
      // 
      this.txtCodDesc.Location = new System.Drawing.Point(478, 59);
      this.txtCodDesc.Margin = new System.Windows.Forms.Padding(2);
      this.txtCodDesc.Name = "txtCodDesc";
      this.txtCodDesc.Size = new System.Drawing.Size(282, 20);
      this.txtCodDesc.TabIndex = 5;
      // 
      // ddlTipo
      // 
      this.ddlTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlTipo.DisplayMember = "Nombre";
      this.ddlTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlTipo.FormattingEnabled = true;
      this.ddlTipo.Location = new System.Drawing.Point(478, 85);
      this.ddlTipo.Name = "ddlTipo";
      this.ddlTipo.Size = new System.Drawing.Size(157, 21);
      this.ddlTipo.TabIndex = 6;
      this.ddlTipo.ValueMember = "Id";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(407, 89);
      this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(28, 13);
      this.label9.TabIndex = 78;
      this.label9.Text = "Tipo";
      // 
      // ddlPlanta
      // 
      this.ddlPlanta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlPlanta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlPlanta.DisplayMember = "Planta";
      this.ddlPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlPlanta.FormattingEnabled = true;
      this.ddlPlanta.Location = new System.Drawing.Point(91, 7);
      this.ddlPlanta.Name = "ddlPlanta";
      this.ddlPlanta.Size = new System.Drawing.Size(239, 21);
      this.ddlPlanta.TabIndex = 0;
      this.ddlPlanta.ValueMember = "Id";
      this.ddlPlanta.SelectedIndexChanged += new System.EventHandler(this.ddlPlanta_SelectedIndexChanged);
      // 
      // label21
      // 
      this.label21.AutoSize = true;
      this.label21.Location = new System.Drawing.Point(21, 11);
      this.label21.Name = "label21";
      this.label21.Size = new System.Drawing.Size(37, 13);
      this.label21.TabIndex = 76;
      this.label21.Text = "Planta";
      // 
      // ddlIdBodega
      // 
      this.ddlIdBodega.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlIdBodega.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlIdBodega.DisplayMember = "Bodega";
      this.ddlIdBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlIdBodega.FormattingEnabled = true;
      this.ddlIdBodega.Location = new System.Drawing.Point(478, 112);
      this.ddlIdBodega.Name = "ddlIdBodega";
      this.ddlIdBodega.Size = new System.Drawing.Size(157, 21);
      this.ddlIdBodega.TabIndex = 7;
      this.ddlIdBodega.ValueMember = "Id";
      this.ddlIdBodega.SelectedIndexChanged += new System.EventHandler(this.ddlIdBodega_SelectedIndexChanged);
      // 
      // ddlIdRack
      // 
      this.ddlIdRack.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlIdRack.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlIdRack.DisplayMember = "Nombre";
      this.ddlIdRack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlIdRack.FormattingEnabled = true;
      this.ddlIdRack.Location = new System.Drawing.Point(478, 139);
      this.ddlIdRack.Name = "ddlIdRack";
      this.ddlIdRack.Size = new System.Drawing.Size(157, 21);
      this.ddlIdRack.TabIndex = 8;
      this.ddlIdRack.ValueMember = "Id";
      // 
      // dtpFecha
      // 
      this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpFecha.Location = new System.Drawing.Point(91, 59);
      this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
      this.dtpFecha.Name = "dtpFecha";
      this.dtpFecha.Size = new System.Drawing.Size(92, 20);
      this.dtpFecha.TabIndex = 2;
      // 
      // txtObservacion
      // 
      this.txtObservacion.Location = new System.Drawing.Point(91, 82);
      this.txtObservacion.Margin = new System.Windows.Forms.Padding(2);
      this.txtObservacion.Multiline = true;
      this.txtObservacion.Name = "txtObservacion";
      this.txtObservacion.Size = new System.Drawing.Size(282, 80);
      this.txtObservacion.TabIndex = 3;
      // 
      // txtIdCliente
      // 
      this.txtIdCliente.Location = new System.Drawing.Point(478, 33);
      this.txtIdCliente.Margin = new System.Windows.Forms.Padding(2);
      this.txtIdCliente.Name = "txtIdCliente";
      this.txtIdCliente.Size = new System.Drawing.Size(282, 20);
      this.txtIdCliente.TabIndex = 4;
      this.txtIdCliente.TextChanged += new System.EventHandler(this.txtIdCliente_TextChanged);
      this.txtIdCliente.Validated += new System.EventHandler(this.txtIdCliente_Validated);
      // 
      // txtNombre
      // 
      this.txtNombre.Location = new System.Drawing.Point(91, 33);
      this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new System.Drawing.Size(282, 20);
      this.txtNombre.TabIndex = 1;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(407, 116);
      this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(44, 13);
      this.label8.TabIndex = 74;
      this.label8.Text = "Bodega";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(20, 89);
      this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(67, 13);
      this.label7.TabIndex = 74;
      this.label7.Text = "Observación";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(407, 143);
      this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(33, 13);
      this.label6.TabIndex = 74;
      this.label6.Text = "Rack";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(407, 63);
      this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(56, 13);
      this.label4.TabIndex = 72;
      this.label4.Text = "Cod/Desc";
      this.tttPrincipal.SetToolTip(this.label4, "Código o descripción");
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(407, 37);
      this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(39, 13);
      this.label3.TabIndex = 71;
      this.label3.Text = "Cliente";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(20, 63);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(37, 13);
      this.label2.TabIndex = 70;
      this.label2.Text = "Fecha";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(20, 37);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 69;
      this.label1.Text = "Nombre";
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
            this.tsbIniciar,
            this.tsbFinalizar,
            this.tsbAprobar,
            this.tsbCancelar,
            this.tsbAuditar});
      this.tlsPrincipal.Location = new System.Drawing.Point(0, 0);
      this.tlsPrincipal.Name = "tlsPrincipal";
      this.tlsPrincipal.Size = new System.Drawing.Size(1312, 27);
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
      this.ddlReporte.Items.AddRange(new object[] {
            "Detalle"});
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
      // tsbIniciar
      // 
      this.tsbIniciar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tsbIniciar.Image = ((System.Drawing.Image)(resources.GetObject("tsbIniciar.Image")));
      this.tsbIniciar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbIniciar.Name = "tsbIniciar";
      this.tsbIniciar.Size = new System.Drawing.Size(43, 24);
      this.tsbIniciar.Text = "Iniciar";
      this.tsbIniciar.Click += new System.EventHandler(this.tsbIniciar_Click);
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
      // tsbAprobar
      // 
      this.tsbAprobar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tsbAprobar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAprobar.Image")));
      this.tsbAprobar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbAprobar.Name = "tsbAprobar";
      this.tsbAprobar.Size = new System.Drawing.Size(54, 24);
      this.tsbAprobar.Text = "Aprobar";
      this.tsbAprobar.Click += new System.EventHandler(this.tsbAprobar_Click);
      // 
      // tsbCancelar
      // 
      this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
      this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbCancelar.Name = "tsbCancelar";
      this.tsbCancelar.Size = new System.Drawing.Size(57, 24);
      this.tsbCancelar.Text = "Cancelar";
      this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
      // 
      // tsbAuditar
      // 
      this.tsbAuditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tsbAuditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAuditar.Image")));
      this.tsbAuditar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbAuditar.Name = "tsbAuditar";
      this.tsbAuditar.Size = new System.Drawing.Size(50, 24);
      this.tsbAuditar.Text = "Auditar";
      this.tsbAuditar.Click += new System.EventHandler(this.tsbAuditar_Click);
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
            this.colid_taring,
            this.colIdPosicion,
            this.colCodigo,
            this.colDescripcion,
            this.colCantidad,
            this.colLote,
            this.colVence,
            this.colIdPosicionNueva,
            this.ColNuevaCantidad,
            this.colMixto,
            this.ColContador,
            this.ColFechaConteo});
      this.dtgPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgPrincipal.IdCopia = 0;
      this.dtgPrincipal.Location = new System.Drawing.Point(0, 228);
      this.dtgPrincipal.Name = "dtgPrincipal";
      this.dtgPrincipal.OpcionEditarMasivoVisible = true;
      this.dtgPrincipal.OpcionesActivas = 63;
      this.dtgPrincipal.OpcionesVisibles = 127;
      this.dtgPrincipal.RefrescandoGrilla = false;
      this.dtgPrincipal.Size = new System.Drawing.Size(1312, 281);
      this.dtgPrincipal.TabIndex = 2;
      this.dtgPrincipal.CambiaOperacionRapida += new System.EventHandler<ITD.Win.CambiaOperacionRapidaEvengArg>(this.dtgPrincipal_CambiaOperacionRapida);
      this.dtgPrincipal.AntesInsertar += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgPrincipal_AntesInsertar);
      this.dtgPrincipal.DespuesModificarFila += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgPrincipal_DespuesModificarFila);
      this.dtgPrincipal.DespuesCambioFila += new System.EventHandler<ITD.Win.FilaGrillaEventArg>(this.dtgPrincipal_DespuesCambioFila);
      this.dtgPrincipal.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_CellEnter);
      this.dtgPrincipal.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_CellValueChanged);
      this.dtgPrincipal.CurrentCellDirtyStateChanged += new System.EventHandler(this.dtgPrincipal_CurrentCellDirtyStateChanged);
      this.dtgPrincipal.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgPrincipal_DataBindingComplete);
      this.dtgPrincipal.Enter += new System.EventHandler(this.dtgPrincipal_Enter);
      // 
      // colid_taring
      // 
      this.colid_taring.DataPropertyName = "id_taring";
      this.colid_taring.HeaderText = "Tarja";
      this.colid_taring.Name = "colid_taring";
      this.colid_taring.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.colid_taring.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.colid_taring.Width = 80;
      // 
      // colIdPosicion
      // 
      this.colIdPosicion.DataPropertyName = "IdPosicion";
      this.colIdPosicion.DisplayStyleForCurrentCellOnly = true;
      this.colIdPosicion.HeaderText = "Posición";
      this.colIdPosicion.Name = "colIdPosicion";
      this.colIdPosicion.ReadOnly = true;
      this.colIdPosicion.Width = 150;
      // 
      // colCodigo
      // 
      this.colCodigo.DataPropertyName = "Codigo";
      this.colCodigo.HeaderText = "Codigo";
      this.colCodigo.MaxInputLength = 20;
      this.colCodigo.Name = "colCodigo";
      this.colCodigo.ReadOnly = true;
      this.colCodigo.Width = 80;
      // 
      // colDescripcion
      // 
      this.colDescripcion.DataPropertyName = "Descripcion";
      this.colDescripcion.HeaderText = "Descripcion";
      this.colDescripcion.MaxInputLength = 50;
      this.colDescripcion.Name = "colDescripcion";
      this.colDescripcion.ReadOnly = true;
      this.colDescripcion.Width = 200;
      // 
      // colCantidad
      // 
      this.colCantidad.DataPropertyName = "Cantidad";
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle2.Format = "#,##0.##";
      this.colCantidad.DefaultCellStyle = dataGridViewCellStyle2;
      this.colCantidad.HeaderText = "Cantidad";
      this.colCantidad.Name = "colCantidad";
      this.colCantidad.ReadOnly = true;
      this.colCantidad.Width = 70;
      // 
      // colLote
      // 
      this.colLote.DataPropertyName = "Lote";
      this.colLote.HeaderText = "Lote";
      this.colLote.MaxInputLength = 20;
      this.colLote.Name = "colLote";
      this.colLote.Width = 80;
      // 
      // colVence
      // 
      this.colVence.DataPropertyName = "Vence";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle3.Format = "d";
      this.colVence.DefaultCellStyle = dataGridViewCellStyle3;
      this.colVence.HeaderText = "Vence";
      this.colVence.Name = "colVence";
      this.colVence.Width = 75;
      // 
      // colIdPosicionNueva
      // 
      this.colIdPosicionNueva.DataPropertyName = "IdPosicionNueva";
      this.colIdPosicionNueva.DisplayStyleForCurrentCellOnly = true;
      this.colIdPosicionNueva.HeaderText = "Posición Nueva";
      this.colIdPosicionNueva.Name = "colIdPosicionNueva";
      this.colIdPosicionNueva.Width = 150;
      // 
      // ColNuevaCantidad
      // 
      this.ColNuevaCantidad.DataPropertyName = "CanitidadNueva";
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle4.Format = "#,##0";
      this.ColNuevaCantidad.DefaultCellStyle = dataGridViewCellStyle4;
      this.ColNuevaCantidad.HeaderText = "Cantidad";
      this.ColNuevaCantidad.Name = "ColNuevaCantidad";
      this.ColNuevaCantidad.Width = 70;
      // 
      // colMixto
      // 
      this.colMixto.DataPropertyName = "Mixto";
      this.colMixto.HeaderText = "Mixto";
      this.colMixto.Name = "colMixto";
      this.colMixto.Width = 50;
      // 
      // ColContador
      // 
      this.ColContador.DataPropertyName = "Contador";
      this.ColContador.HeaderText = "Contador";
      this.ColContador.Name = "ColContador";
      this.ColContador.Width = 150;
      // 
      // ColFechaConteo
      // 
      this.ColFechaConteo.DataPropertyName = "FechaConteo";
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle5.Format = "g";
      this.ColFechaConteo.DefaultCellStyle = dataGridViewCellStyle5;
      this.ColFechaConteo.HeaderText = "Fecha Conteo";
      this.ColFechaConteo.Name = "ColFechaConteo";
      // 
      // grillaTotal1
      // 
      this.grillaTotal1.AutoCalculado = false;
      this.grillaTotal1.Dock = System.Windows.Forms.DockStyle.Top;
      this.grillaTotal1.Grilla = null;
      this.grillaTotal1.Location = new System.Drawing.Point(0, 204);
      this.grillaTotal1.Margin = new System.Windows.Forms.Padding(4);
      this.grillaTotal1.Name = "grillaTotal1";
      this.grillaTotal1.Size = new System.Drawing.Size(1312, 24);
      this.grillaTotal1.TabIndex = 1;
      // 
      // Inventario
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1312, 531);
      this.Controls.Add(this.dtgPrincipal);
      this.Controls.Add(this.grillaTotal1);
      this.Controls.Add(this.pnlPrincipal);
      this.Controls.Add(this.tlsPrincipal);
      this.EnterComoTab = true;
      this.KeyPreview = true;
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "Inventario";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Inventario";
      this.Load += new System.EventHandler(this.ActualizacionGrilla_Load);
      this.Controls.SetChildIndex(this.tlsPrincipal, 0);
      this.Controls.SetChildIndex(this.pnlPrincipal, 0);
      this.Controls.SetChildIndex(this.grillaTotal1, 0);
      this.Controls.SetChildIndex(this.dtgPrincipal, 0);
      this.pnlPrincipal.ResumeLayout(false);
      this.pnlPrincipal.PerformLayout();
      this.tlsPrincipal.ResumeLayout(false);
      this.tlsPrincipal.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).EndInit();
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
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker dtpFecha;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.TextBox txtObservacion;
    private System.Windows.Forms.TextBox txtIdCliente;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.ComboBox ddlIdBodega;
    private System.Windows.Forms.ComboBox ddlIdRack;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.ToolStripButton tsbIniciar;
    private System.Windows.Forms.ToolStripButton tsbFinalizar;
    private System.Windows.Forms.ComboBox ddlPlanta;
    private System.Windows.Forms.Label label21;
    private System.Windows.Forms.ComboBox ddlTipo;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.ToolStripButton tsbAprobar;
    private System.Windows.Forms.TextBox txtCodDesc;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ToolStripButton tsbCancelar;
    private System.Windows.Forms.TextBox txtMonitora;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox txtResponsable;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.DataGridViewTextBoxColumn colid_taring;
    private System.Windows.Forms.DataGridViewComboBoxColumn colIdPosicion;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
    private System.Windows.Forms.DataGridViewTextBoxColumn colLote;
    private System.Windows.Forms.DataGridViewTextBoxColumn colVence;
    private System.Windows.Forms.DataGridViewComboBoxColumn colIdPosicionNueva;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColNuevaCantidad;
    private System.Windows.Forms.DataGridViewCheckBoxColumn colMixto;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColContador;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaConteo;
    private System.Windows.Forms.ToolStripButton tsbAuditar;
  }
}