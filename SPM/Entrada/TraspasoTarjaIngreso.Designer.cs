namespace APP {
  partial class TraspasoTarjaIngreso {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraspasoTarjaIngreso));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.pnlPrincipal = new System.Windows.Forms.Panel();
      this.txtNumero = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtObservaciones = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.ddlDestino = new System.Windows.Forms.ComboBox();
      this.ddlOrigen = new System.Windows.Forms.ComboBox();
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
      this.tsbValidar = new System.Windows.Forms.ToolStripButton();
      this.tsbAnular = new System.Windows.Forms.ToolStripButton();
      this.dtgPrincipal = new ITD.Win.Grilla(this.components);
      this.grillaTotal1 = new ITD.Win.GrillaTotal();
      this.colNumTarja = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colcodigo_ptt = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colnombre_ptt = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pnlPrincipal.SuspendLayout();
      this.tlsPrincipal.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlPrincipal
      // 
      this.pnlPrincipal.Controls.Add(this.txtNumero);
      this.pnlPrincipal.Controls.Add(this.label5);
      this.pnlPrincipal.Controls.Add(this.txtObservaciones);
      this.pnlPrincipal.Controls.Add(this.label3);
      this.pnlPrincipal.Controls.Add(this.ddlDestino);
      this.pnlPrincipal.Controls.Add(this.ddlOrigen);
      this.pnlPrincipal.Controls.Add(this.label2);
      this.pnlPrincipal.Controls.Add(this.label1);
      this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlPrincipal.Location = new System.Drawing.Point(0, 25);
      this.pnlPrincipal.Name = "pnlPrincipal";
      this.pnlPrincipal.Size = new System.Drawing.Size(657, 205);
      this.pnlPrincipal.TabIndex = 5;
      // 
      // txtNumero
      // 
      this.txtNumero.Location = new System.Drawing.Point(89, 19);
      this.txtNumero.Name = "txtNumero";
      this.txtNumero.ReadOnly = true;
      this.txtNumero.Size = new System.Drawing.Size(100, 20);
      this.txtNumero.TabIndex = 37;
      this.txtNumero.TabStop = false;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(16, 23);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(44, 13);
      this.label5.TabIndex = 38;
      this.label5.Text = "Número";
      // 
      // txtObservaciones
      // 
      this.txtObservaciones.Location = new System.Drawing.Point(89, 99);
      this.txtObservaciones.Multiline = true;
      this.txtObservaciones.Name = "txtObservaciones";
      this.txtObservaciones.Size = new System.Drawing.Size(324, 80);
      this.txtObservaciones.TabIndex = 36;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(16, 114);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(67, 13);
      this.label3.TabIndex = 35;
      this.label3.Text = "Observación";
      // 
      // ddlDestino
      // 
      this.ddlDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlDestino.DisplayMember = "Planta";
      this.ddlDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlDestino.FormattingEnabled = true;
      this.ddlDestino.Location = new System.Drawing.Point(89, 72);
      this.ddlDestino.Name = "ddlDestino";
      this.ddlDestino.Size = new System.Drawing.Size(324, 21);
      this.ddlDestino.TabIndex = 33;
      this.ddlDestino.ValueMember = "Id";
      // 
      // ddlOrigen
      // 
      this.ddlOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlOrigen.DisplayMember = "Planta";
      this.ddlOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlOrigen.FormattingEnabled = true;
      this.ddlOrigen.Location = new System.Drawing.Point(89, 45);
      this.ddlOrigen.Name = "ddlOrigen";
      this.ddlOrigen.Size = new System.Drawing.Size(324, 21);
      this.ddlOrigen.TabIndex = 34;
      this.ddlOrigen.ValueMember = "Id";
      this.ddlOrigen.SelectedIndexChanged += new System.EventHandler(this.ddlOrigen_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(16, 76);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(43, 13);
      this.label2.TabIndex = 31;
      this.label2.Text = "Destino";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(16, 49);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 32;
      this.label1.Text = "Origen";
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
            this.tsbValidar,
            this.tsbAnular});
      this.tlsPrincipal.Location = new System.Drawing.Point(0, 0);
      this.tlsPrincipal.Name = "tlsPrincipal";
      this.tlsPrincipal.Size = new System.Drawing.Size(657, 25);
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
      // tsbValidar
      // 
      this.tsbValidar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tsbValidar.Image = ((System.Drawing.Image)(resources.GetObject("tsbValidar.Image")));
      this.tsbValidar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbValidar.Name = "tsbValidar";
      this.tsbValidar.Size = new System.Drawing.Size(46, 22);
      this.tsbValidar.Text = "Validar";
      this.tsbValidar.Click += new System.EventHandler(this.tsbValidar_Click);
      // 
      // tsbAnular
      // 
      this.tsbAnular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tsbAnular.Image = ((System.Drawing.Image)(resources.GetObject("tsbAnular.Image")));
      this.tsbAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbAnular.Name = "tsbAnular";
      this.tsbAnular.Size = new System.Drawing.Size(46, 22);
      this.tsbAnular.Text = "Anular";
      this.tsbAnular.Click += new System.EventHandler(this.tsbAnular_Click);
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
            this.colNumTarja,
            this.colNombre,
            this.colcodigo_ptt,
            this.colnombre_ptt,
            this.colCantidad});
      this.dtgPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgPrincipal.IdCopia = 0;
      this.dtgPrincipal.Location = new System.Drawing.Point(0, 254);
      this.dtgPrincipal.Name = "dtgPrincipal";
      this.dtgPrincipal.OpcionEditarMasivoVisible = true;
      this.dtgPrincipal.OpcionesActivas = 63;
      this.dtgPrincipal.OpcionesVisibles = 127;
      this.dtgPrincipal.RefrescandoGrilla = false;
      this.dtgPrincipal.Size = new System.Drawing.Size(657, 214);
      this.dtgPrincipal.TabIndex = 67;
      this.dtgPrincipal.CambiaOperacionRapida += new System.EventHandler<ITD.Win.CambiaOperacionRapidaEvengArg>(this.dtgPrincipal_CambiaOperacionRapida);
      this.dtgPrincipal.AntesInsertar += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgPrincipal_AntesInsertar);
      this.dtgPrincipal.DespuesModificarFila += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgPrincipal_DespuesModificarFila);
      this.dtgPrincipal.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_CellValueChanged);
      this.dtgPrincipal.CurrentCellDirtyStateChanged += new System.EventHandler(this.dtgPrincipal_CurrentCellDirtyStateChanged);
      this.dtgPrincipal.Enter += new System.EventHandler(this.dtgPrincipal_Enter);
      this.dtgPrincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgPrincipal_KeyDown);
      // 
      // grillaTotal1
      // 
      this.grillaTotal1.AutoCalculado = false;
      this.grillaTotal1.Dock = System.Windows.Forms.DockStyle.Top;
      this.grillaTotal1.Grilla = null;
      this.grillaTotal1.Location = new System.Drawing.Point(0, 230);
      this.grillaTotal1.Name = "grillaTotal1";
      this.grillaTotal1.Size = new System.Drawing.Size(657, 24);
      this.grillaTotal1.TabIndex = 68;
      // 
      // colNumTarja
      // 
      this.colNumTarja.DataPropertyName = "id_taring";
      this.colNumTarja.HeaderText = "Tarja";
      this.colNumTarja.MaxInputLength = 30;
      this.colNumTarja.Name = "colNumTarja";
      // 
      // colNombre
      // 
      this.colNombre.DataPropertyName = "Nombre";
      this.colNombre.HeaderText = "Cliente";
      this.colNombre.MaxInputLength = 100;
      this.colNombre.Name = "colNombre";
      this.colNombre.ReadOnly = true;
      this.colNombre.Width = 150;
      // 
      // colcodigo_ptt
      // 
      this.colcodigo_ptt.DataPropertyName = "id_insumo";
      this.colcodigo_ptt.HeaderText = "Código";
      this.colcodigo_ptt.MaxInputLength = 20;
      this.colcodigo_ptt.Name = "colcodigo_ptt";
      this.colcodigo_ptt.ReadOnly = true;
      // 
      // colnombre_ptt
      // 
      this.colnombre_ptt.DataPropertyName = "nombre_insumo";
      this.colnombre_ptt.HeaderText = "Descripción";
      this.colnombre_ptt.MaxInputLength = 100;
      this.colnombre_ptt.Name = "colnombre_ptt";
      this.colnombre_ptt.ReadOnly = true;
      this.colnombre_ptt.Width = 150;
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
      this.colCantidad.Width = 60;
      // 
      // TraspasoTarjaIngreso
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(657, 490);
      this.Controls.Add(this.dtgPrincipal);
      this.Controls.Add(this.grillaTotal1);
      this.Controls.Add(this.pnlPrincipal);
      this.Controls.Add(this.tlsPrincipal);
      this.EnterComoTab = true;
      this.KeyPreview = true;
      this.Name = "TraspasoTarjaIngreso";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Traspaso de tarjas de ingreso";
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
    private System.Windows.Forms.TextBox txtObservaciones;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox ddlDestino;
    private System.Windows.Forms.ComboBox ddlOrigen;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ToolStripButton tsbValidar;
    private System.Windows.Forms.ToolStripButton tsbAnular;
    private System.Windows.Forms.TextBox txtNumero;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNumTarja;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
    private System.Windows.Forms.DataGridViewTextBoxColumn colcodigo_ptt;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_ptt;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
  }
}