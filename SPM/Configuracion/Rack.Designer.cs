namespace APP {
  partial class Rack {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rack));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      this.tlsPrincipal = new System.Windows.Forms.ToolStrip();
      this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
      this.tsbGenerarPosicion = new System.Windows.Forms.ToolStripButton();
      this.dtgPrincipal = new ITD.Win.Grilla(this.components);
      this.colid_planta = new ITD.Win.DataGridViewComboBoxFiltroColumn();
      this.colid_bodega = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.ColTipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.ColModo = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.colnombre_rack = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colfilas_rack = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColLetraInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colcolu_rack = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colposiciones_rack = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColGenerado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tlsPrincipal.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
      this.SuspendLayout();
      // 
      // tlsPrincipal
      // 
      this.tlsPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.tlsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.toolStripSeparator1,
            this.tsbRefrescar,
            this.tsbGenerarPosicion});
      this.tlsPrincipal.Location = new System.Drawing.Point(0, 0);
      this.tlsPrincipal.Name = "tlsPrincipal";
      this.tlsPrincipal.Size = new System.Drawing.Size(802, 27);
      this.tlsPrincipal.TabIndex = 6;
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
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
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
      // tsbGenerarPosicion
      // 
      this.tsbGenerarPosicion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tsbGenerarPosicion.Image = ((System.Drawing.Image)(resources.GetObject("tsbGenerarPosicion.Image")));
      this.tsbGenerarPosicion.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbGenerarPosicion.Name = "tsbGenerarPosicion";
      this.tsbGenerarPosicion.Size = new System.Drawing.Size(111, 24);
      this.tsbGenerarPosicion.Text = "Generar Posiciones";
      this.tsbGenerarPosicion.Click += new System.EventHandler(this.tsbGenerarPosicion_Click);
      // 
      // dtgPrincipal
      // 
      this.dtgPrincipal.AllowUserToAddRows = false;
      this.dtgPrincipal.AllowUserToDeleteRows = false;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dtgPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dtgPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colid_planta,
            this.colid_bodega,
            this.ColTipo,
            this.ColModo,
            this.colnombre_rack,
            this.colfilas_rack,
            this.ColLetraInicial,
            this.colcolu_rack,
            this.colposiciones_rack,
            this.ColGenerado});
      this.dtgPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgPrincipal.IdCopia = 0;
      this.dtgPrincipal.Location = new System.Drawing.Point(0, 27);
      this.dtgPrincipal.Name = "dtgPrincipal";
      this.dtgPrincipal.OpcionEditarMasivoVisible = true;
      this.dtgPrincipal.OpcionesActivas = 63;
      this.dtgPrincipal.OpcionesVisibles = 79;
      this.dtgPrincipal.OpcionInmovilizarVisible = false;
      this.dtgPrincipal.OpcionOperacionVisible = false;
      this.dtgPrincipal.RefrescandoGrilla = false;
      this.dtgPrincipal.Size = new System.Drawing.Size(802, 279);
      this.dtgPrincipal.TabIndex = 5;
      this.dtgPrincipal.AntesInsertar += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgPrincipal_AntesInsertar);
      this.dtgPrincipal.DespuesModificarFila += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgPrincipal_DespuesModificarFila);
      this.dtgPrincipal.DespuesCambioFila += new System.EventHandler<ITD.Win.FilaGrillaEventArg>(this.dtgPrincipal_DespuesCambioFila);
      this.dtgPrincipal.InformaCambios += new System.EventHandler<System.EventArgs>(this.dtgPrincipal_InformaCambios);
      this.dtgPrincipal.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_CellValueChanged);
      this.dtgPrincipal.CurrentCellDirtyStateChanged += new System.EventHandler(this.dtgPrincipal_CurrentCellDirtyStateChanged);
      this.dtgPrincipal.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgPrincipal_DataBindingComplete);
      // 
      // colid_planta
      // 
      this.colid_planta.DataPropertyName = "id_planta";
      this.colid_planta.FiltroHabilitado = true;
      this.colid_planta.HeaderText = "Planta";
      this.colid_planta.Name = "colid_planta";
      this.colid_planta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.colid_planta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.colid_planta.Width = 150;
      // 
      // colid_bodega
      // 
      this.colid_bodega.DataPropertyName = "id_bodega";
      this.colid_bodega.DisplayStyleForCurrentCellOnly = true;
      this.colid_bodega.HeaderText = "Bodega";
      this.colid_bodega.Name = "colid_bodega";
      // 
      // ColTipo
      // 
      this.ColTipo.DataPropertyName = "IdTipo";
      this.ColTipo.DisplayStyleForCurrentCellOnly = true;
      this.ColTipo.HeaderText = "Tipo";
      this.ColTipo.Name = "ColTipo";
      this.ColTipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.ColTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.ColTipo.ToolTipText = "Tipo de ubicación";
      // 
      // ColModo
      // 
      this.ColModo.DataPropertyName = "IdModo";
      this.ColModo.DisplayStyleForCurrentCellOnly = true;
      this.ColModo.HeaderText = "Modo";
      this.ColModo.Name = "ColModo";
      this.ColModo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.ColModo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.ColModo.Width = 120;
      // 
      // colnombre_rack
      // 
      this.colnombre_rack.DataPropertyName = "nombre_rack";
      this.colnombre_rack.HeaderText = "Nombre";
      this.colnombre_rack.MaxInputLength = 20;
      this.colnombre_rack.Name = "colnombre_rack";
      // 
      // colfilas_rack
      // 
      this.colfilas_rack.DataPropertyName = "filas_rack";
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle2.Format = "#,##0.##";
      this.colfilas_rack.DefaultCellStyle = dataGridViewCellStyle2;
      this.colfilas_rack.HeaderText = "Filas";
      this.colfilas_rack.Name = "colfilas_rack";
      this.colfilas_rack.Width = 70;
      // 
      // ColLetraInicial
      // 
      this.ColLetraInicial.DataPropertyName = "FilaValorInicial";
      this.ColLetraInicial.HeaderText = "Valor Inicial";
      this.ColLetraInicial.MaxInputLength = 1;
      this.ColLetraInicial.Name = "ColLetraInicial";
      // 
      // colcolu_rack
      // 
      this.colcolu_rack.DataPropertyName = "colu_rack";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle3.Format = "#,##0.##";
      this.colcolu_rack.DefaultCellStyle = dataGridViewCellStyle3;
      this.colcolu_rack.HeaderText = "Columnas";
      this.colcolu_rack.Name = "colcolu_rack";
      this.colcolu_rack.Width = 80;
      // 
      // colposiciones_rack
      // 
      this.colposiciones_rack.DataPropertyName = "posiciones_rack";
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle4.Format = "#,##0.##";
      this.colposiciones_rack.DefaultCellStyle = dataGridViewCellStyle4;
      this.colposiciones_rack.HeaderText = "Posiciones";
      this.colposiciones_rack.Name = "colposiciones_rack";
      this.colposiciones_rack.ReadOnly = true;
      this.colposiciones_rack.Width = 90;
      // 
      // ColGenerado
      // 
      this.ColGenerado.DataPropertyName = "Generado";
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle5.Format = "Si;Si;No";
      this.ColGenerado.DefaultCellStyle = dataGridViewCellStyle5;
      this.ColGenerado.HeaderText = "Generado";
      this.ColGenerado.Name = "ColGenerado";
      this.ColGenerado.ReadOnly = true;
      this.ColGenerado.Width = 80;
      // 
      // Rack
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.ClientSize = new System.Drawing.Size(802, 328);
      this.Controls.Add(this.dtgPrincipal);
      this.Controls.Add(this.tlsPrincipal);
      this.EnterComoTab = true;
      this.KeyPreview = true;
      this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.Name = "Rack";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Ubicación";
      this.Load += new System.EventHandler(this.GrillaAct_Load);
      this.Controls.SetChildIndex(this.tlsPrincipal, 0);
      this.Controls.SetChildIndex(this.dtgPrincipal, 0);
      this.tlsPrincipal.ResumeLayout(false);
      this.tlsPrincipal.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private ITD.Win.Grilla dtgPrincipal;
    private System.Windows.Forms.ToolStrip tlsPrincipal;
    private System.Windows.Forms.ToolStripButton tsbGuardar;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton tsbRefrescar;
    private System.Windows.Forms.ToolStripButton tsbGenerarPosicion;
    private ITD.Win.DataGridViewComboBoxFiltroColumn colid_planta;
    private System.Windows.Forms.DataGridViewComboBoxColumn colid_bodega;
    private System.Windows.Forms.DataGridViewComboBoxColumn ColTipo;
    private System.Windows.Forms.DataGridViewComboBoxColumn ColModo;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_rack;
    private System.Windows.Forms.DataGridViewTextBoxColumn colfilas_rack;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColLetraInicial;
    private System.Windows.Forms.DataGridViewTextBoxColumn colcolu_rack;
    private System.Windows.Forms.DataGridViewTextBoxColumn colposiciones_rack;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColGenerado;
  }
}
