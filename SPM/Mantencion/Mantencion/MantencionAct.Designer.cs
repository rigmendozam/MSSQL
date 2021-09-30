namespace APP {
  partial class MantencionAct {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantencionAct));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.pnlPrincipal = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.txtNumero = new System.Windows.Forms.TextBox();
      this.dtpFechaEmisionMant = new System.Windows.Forms.DateTimePicker();
      this.lblFechaEmision = new System.Windows.Forms.Label();
      this.ddlPlantaOrigen = new System.Windows.Forms.ComboBox();
      this.txtObsMant = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
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
      this.dtgPrincipal = new ITD.Win.Grilla(this.components);
      this.colActividadMant = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.dtgParticipantes = new ITD.Win.Grilla(this.components);
      this.colParticipantesMant = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tsbRealizado = new System.Windows.Forms.ToolStripButton();
      this.pnlPrincipal.SuspendLayout();
      this.tlsPrincipal.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgParticipantes)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlPrincipal
      // 
      this.pnlPrincipal.Controls.Add(this.label2);
      this.pnlPrincipal.Controls.Add(this.txtNumero);
      this.pnlPrincipal.Controls.Add(this.dtpFechaEmisionMant);
      this.pnlPrincipal.Controls.Add(this.lblFechaEmision);
      this.pnlPrincipal.Controls.Add(this.ddlPlantaOrigen);
      this.pnlPrincipal.Controls.Add(this.txtObsMant);
      this.pnlPrincipal.Controls.Add(this.label3);
      this.pnlPrincipal.Controls.Add(this.label1);
      this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlPrincipal.Location = new System.Drawing.Point(0, 25);
      this.pnlPrincipal.Name = "pnlPrincipal";
      this.pnlPrincipal.Size = new System.Drawing.Size(775, 152);
      this.pnlPrincipal.TabIndex = 5;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(23, 50);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(44, 13);
      this.label2.TabIndex = 13;
      this.label2.Text = "Número";
      // 
      // txtNumero
      // 
      this.txtNumero.Location = new System.Drawing.Point(96, 46);
      this.txtNumero.Name = "txtNumero";
      this.txtNumero.ReadOnly = true;
      this.txtNumero.Size = new System.Drawing.Size(131, 20);
      this.txtNumero.TabIndex = 12;
      this.txtNumero.TabStop = false;
      // 
      // dtpFechaEmisionMant
      // 
      this.dtpFechaEmisionMant.Checked = false;
      this.dtpFechaEmisionMant.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpFechaEmisionMant.Location = new System.Drawing.Point(293, 46);
      this.dtpFechaEmisionMant.Name = "dtpFechaEmisionMant";
      this.dtpFechaEmisionMant.Size = new System.Drawing.Size(92, 20);
      this.dtpFechaEmisionMant.TabIndex = 11;
      // 
      // lblFechaEmision
      // 
      this.lblFechaEmision.AutoSize = true;
      this.lblFechaEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblFechaEmision.Location = new System.Drawing.Point(243, 50);
      this.lblFechaEmision.Name = "lblFechaEmision";
      this.lblFechaEmision.Size = new System.Drawing.Size(40, 13);
      this.lblFechaEmision.TabIndex = 10;
      this.lblFechaEmision.Text = "Fecha ";
      // 
      // ddlPlantaOrigen
      // 
      this.ddlPlantaOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlPlantaOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlPlantaOrigen.DisplayMember = "Planta";
      this.ddlPlantaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlPlantaOrigen.FormattingEnabled = true;
      this.ddlPlantaOrigen.Location = new System.Drawing.Point(96, 19);
      this.ddlPlantaOrigen.Name = "ddlPlantaOrigen";
      this.ddlPlantaOrigen.Size = new System.Drawing.Size(289, 21);
      this.ddlPlantaOrigen.TabIndex = 9;
      this.ddlPlantaOrigen.ValueMember = "Id";
      // 
      // txtObsMant
      // 
      this.txtObsMant.Location = new System.Drawing.Point(96, 72);
      this.txtObsMant.Multiline = true;
      this.txtObsMant.Name = "txtObsMant";
      this.txtObsMant.Size = new System.Drawing.Size(289, 57);
      this.txtObsMant.TabIndex = 8;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(23, 72);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(67, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Observación";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(23, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(37, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Planta";
      // 
      // tlsPrincipal
      // 
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
            this.tsbRealizado});
      this.tlsPrincipal.Location = new System.Drawing.Point(0, 0);
      this.tlsPrincipal.Name = "tlsPrincipal";
      this.tlsPrincipal.Size = new System.Drawing.Size(775, 25);
      this.tlsPrincipal.TabIndex = 6;
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
      // tsbGuardar
      // 
      this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbGuardar.Image = global::APP.Properties.Resources.grabar;
      this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbGuardar.Name = "tsbGuardar";
      this.tsbGuardar.Size = new System.Drawing.Size(23, 22);
      this.tsbGuardar.Text = "Guardar";
      this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
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
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
      // 
      // tsbRefrescar
      // 
      this.tsbRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbRefrescar.Image = global::APP.Properties.Resources.refrescar;
      this.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbRefrescar.Name = "tsbRefrescar";
      this.tsbRefrescar.Size = new System.Drawing.Size(23, 22);
      this.tsbRefrescar.Text = "Refrescar";
      this.tsbRefrescar.Click += new System.EventHandler(this.tsbRefrescar_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // ddlReporte
      // 
      this.ddlReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlReporte.Name = "ddlReporte";
      this.ddlReporte.Size = new System.Drawing.Size(170, 25);
      // 
      // tsbReporte
      // 
      this.tsbReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbReporte.Image = global::APP.Properties.Resources.Reporte;
      this.tsbReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbReporte.Name = "tsbReporte";
      this.tsbReporte.Size = new System.Drawing.Size(23, 22);
      this.tsbReporte.Text = "Reporte";
      this.tsbReporte.Click += new System.EventHandler(this.tsbReporte_Click);
      // 
      // tsbIniciar
      // 
      this.tsbIniciar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tsbIniciar.Image = ((System.Drawing.Image)(resources.GetObject("tsbIniciar.Image")));
      this.tsbIniciar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbIniciar.Name = "tsbIniciar";
      this.tsbIniciar.Size = new System.Drawing.Size(43, 22);
      this.tsbIniciar.Text = "Iniciar";
      this.tsbIniciar.Click += new System.EventHandler(this.tsbIniciar_Click);
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
            this.colActividadMant});
      this.dtgPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgPrincipal.IdCopia = 0;
      this.dtgPrincipal.Location = new System.Drawing.Point(0, 0);
      this.dtgPrincipal.Name = "dtgPrincipal";
      this.dtgPrincipal.OpcionEditarMasivoVisible = true;
      this.dtgPrincipal.OpcionesActivas = 63;
      this.dtgPrincipal.OpcionesVisibles = 127;
      this.dtgPrincipal.RefrescandoGrilla = false;
      this.dtgPrincipal.Size = new System.Drawing.Size(385, 209);
      this.dtgPrincipal.TabIndex = 67;
      this.dtgPrincipal.CambiaOperacionRapida += new System.EventHandler<ITD.Win.CambiaOperacionRapidaEvengArg>(this.dtgPrincipal_CambiaOperacionRapida);
      this.dtgPrincipal.AntesInsertar += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgPrincipal_AntesInsertar);
      this.dtgPrincipal.DespuesModificarFila += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgPrincipal_DespuesModificarFila);
      this.dtgPrincipal.CurrentCellDirtyStateChanged += new System.EventHandler(this.dtgPrincipal_CurrentCellDirtyStateChanged);
      this.dtgPrincipal.Enter += new System.EventHandler(this.dtgPrincipal_Enter);
      // 
      // colActividadMant
      // 
      this.colActividadMant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colActividadMant.DataPropertyName = "Actividad";
      this.colActividadMant.HeaderText = "Actividad";
      this.colActividadMant.Name = "colActividadMant";
      // 
      // splitContainer1
      // 
      this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitContainer1.Location = new System.Drawing.Point(0, 177);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.dtgPrincipal);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.dtgParticipantes);
      this.splitContainer1.Size = new System.Drawing.Size(775, 213);
      this.splitContainer1.SplitterDistance = 389;
      this.splitContainer1.TabIndex = 68;
      // 
      // dtgParticipantes
      // 
      this.dtgParticipantes.AllowUserToAddRows = false;
      this.dtgParticipantes.AllowUserToDeleteRows = false;
      this.dtgParticipantes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dtgParticipantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dtgParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgParticipantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colParticipantesMant});
      this.dtgParticipantes.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgParticipantes.IdCopia = 0;
      this.dtgParticipantes.Location = new System.Drawing.Point(0, 0);
      this.dtgParticipantes.Name = "dtgParticipantes";
      this.dtgParticipantes.OpcionEditarMasivoVisible = true;
      this.dtgParticipantes.OpcionesActivas = 63;
      this.dtgParticipantes.OpcionesVisibles = 127;
      this.dtgParticipantes.RefrescandoGrilla = false;
      this.dtgParticipantes.Size = new System.Drawing.Size(378, 209);
      this.dtgParticipantes.TabIndex = 68;
      this.dtgParticipantes.AntesInsertar += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgParticipantes_AntesInsertar);
      this.dtgParticipantes.DespuesModificarFila += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgParticipantes_DespuesModificarFila);
      this.dtgParticipantes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgParticipantes_CellValueChanged);
      this.dtgParticipantes.CurrentCellDirtyStateChanged += new System.EventHandler(this.dtgPrincipal_CurrentCellDirtyStateChanged);
      this.dtgParticipantes.Enter += new System.EventHandler(this.dtgPrincipal_Enter);
      this.dtgParticipantes.Validated += new System.EventHandler(this.dtgParticipantes_Validated);
      // 
      // colParticipantesMant
      // 
      this.colParticipantesMant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colParticipantesMant.DataPropertyName = "nombre_empleado";
      this.colParticipantesMant.HeaderText = "Participantes";
      this.colParticipantesMant.Name = "colParticipantesMant";
      // 
      // tsbRealizado
      // 
      this.tsbRealizado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tsbRealizado.Image = ((System.Drawing.Image)(resources.GetObject("tsbRealizado.Image")));
      this.tsbRealizado.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbRealizado.Name = "tsbRealizado";
      this.tsbRealizado.Size = new System.Drawing.Size(61, 22);
      this.tsbRealizado.Text = "Realizado";
      this.tsbRealizado.Click += new System.EventHandler(this.tsbRealizado_Click);
      // 
      // MantencionAct
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(775, 412);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.pnlPrincipal);
      this.Controls.Add(this.tlsPrincipal);
      this.EnterComoTab = true;
      this.KeyPreview = true;
      this.Name = "MantencionAct";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Mantención";
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
      ((System.ComponentModel.ISupportInitialize)(this.dtgParticipantes)).EndInit();
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
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.TextBox txtObsMant;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox ddlPlantaOrigen;
    private System.Windows.Forms.DateTimePicker dtpFechaEmisionMant;
    private System.Windows.Forms.Label lblFechaEmision;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtNumero;
    private System.Windows.Forms.DataGridViewTextBoxColumn colActividadMant;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private ITD.Win.Grilla dtgParticipantes;
    private System.Windows.Forms.DataGridViewTextBoxColumn colParticipantesMant;
    private System.Windows.Forms.ToolStripButton tsbIniciar;
    private System.Windows.Forms.ToolStripButton tsbRealizado;
  }
}