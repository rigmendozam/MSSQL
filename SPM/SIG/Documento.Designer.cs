namespace APP {
  partial class Documento {
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.tlsPrincipal = new System.Windows.Forms.ToolStrip();
      this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
      this.dtgPrincipal = new ITD.Win.Grilla(this.components);
      this.ColDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColCargar = new System.Windows.Forms.DataGridViewImageColumn();
      this.ColVer = new System.Windows.Forms.DataGridViewImageColumn();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.dtgCategoria = new ITD.Win.Grilla(this.components);
      this.ColCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.splitContainer2 = new System.Windows.Forms.SplitContainer();
      this.dtgSubcategoria = new ITD.Win.Grilla(this.components);
      this.ColSubcategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tlsPrincipal.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgCategoria)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgSubcategoria)).BeginInit();
      this.SuspendLayout();
      // 
      // tlsPrincipal
      // 
      this.tlsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.toolStripSeparator1,
            this.tsbRefrescar});
      this.tlsPrincipal.Location = new System.Drawing.Point(0, 0);
      this.tlsPrincipal.Name = "tlsPrincipal";
      this.tlsPrincipal.Size = new System.Drawing.Size(961, 25);
      this.tlsPrincipal.TabIndex = 6;
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
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
      // dtgPrincipal
      // 
      this.dtgPrincipal.AllowUserToAddRows = false;
      this.dtgPrincipal.AllowUserToDeleteRows = false;
      this.dtgPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDocumento,
            this.ColVersion,
            this.ColCargar,
            this.ColVer});
      this.dtgPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgPrincipal.IdCopia = 0;
      this.dtgPrincipal.Location = new System.Drawing.Point(0, 0);
      this.dtgPrincipal.Name = "dtgPrincipal";
      this.dtgPrincipal.OpcionesActivas = 63;
      this.dtgPrincipal.OpcionesVisibles = 15;
      this.dtgPrincipal.OpcionInmovilizarVisible = false;
      this.dtgPrincipal.OpcionOperacionVisible = false;
      this.dtgPrincipal.RefrescandoGrilla = false;
      this.dtgPrincipal.Size = new System.Drawing.Size(432, 429);
      this.dtgPrincipal.TabIndex = 5;
      this.dtgPrincipal.AntesInsertar += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgPrincipal_AntesInsertar);
      this.dtgPrincipal.DespuesModificarFila += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgPrincipal_DespuesModificarFila);
      this.dtgPrincipal.InformaCambios += new System.EventHandler<System.EventArgs>(this.dtgPrincipal_InformaCambios);
      this.dtgPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_CellContentClick);
      this.dtgPrincipal.CurrentCellDirtyStateChanged += new System.EventHandler(this.dtgPrincipal_CurrentCellDirtyStateChanged);
      // 
      // ColDocumento
      // 
      this.ColDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.ColDocumento.DataPropertyName = "NombreDoc";
      this.ColDocumento.HeaderText = "Documento";
      this.ColDocumento.MaxInputLength = 150;
      this.ColDocumento.Name = "ColDocumento";
      // 
      // ColVersion
      // 
      this.ColVersion.DataPropertyName = "Version";
      this.ColVersion.HeaderText = "Versión";
      this.ColVersion.Name = "ColVersion";
      this.ColVersion.Width = 60;
      // 
      // ColCargar
      // 
      this.ColCargar.HeaderText = "Cargar";
      this.ColCargar.Image = global::APP.Properties.Resources.cargarDoc16x16;
      this.ColCargar.Name = "ColCargar";
      this.ColCargar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.ColCargar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.ColCargar.Width = 50;
      // 
      // ColVer
      // 
      this.ColVer.HeaderText = "Ver";
      this.ColVer.Image = global::APP.Properties.Resources.VistaPrevia;
      this.ColVer.Name = "ColVer";
      this.ColVer.Width = 40;
      // 
      // splitContainer1
      // 
      this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitContainer1.Location = new System.Drawing.Point(0, 25);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.dtgCategoria);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
      this.splitContainer1.Size = new System.Drawing.Size(961, 433);
      this.splitContainer1.SplitterDistance = 234;
      this.splitContainer1.TabIndex = 7;
      // 
      // dtgCategoria
      // 
      this.dtgCategoria.AllowUserToAddRows = false;
      this.dtgCategoria.AllowUserToDeleteRows = false;
      this.dtgCategoria.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dtgCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dtgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCategoria});
      this.dtgCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgCategoria.IdCopia = 0;
      this.dtgCategoria.Location = new System.Drawing.Point(0, 0);
      this.dtgCategoria.Name = "dtgCategoria";
      this.dtgCategoria.OpcionCopiarVisible = false;
      this.dtgCategoria.OpcionEliminarVisible = false;
      this.dtgCategoria.OpcionesActivas = 63;
      this.dtgCategoria.OpcionesVisibles = 48;
      this.dtgCategoria.OpcionInsertarVisible = false;
      this.dtgCategoria.OpcionPegarVisible = false;
      this.dtgCategoria.ReadOnly = true;
      this.dtgCategoria.RefrescandoGrilla = false;
      this.dtgCategoria.Size = new System.Drawing.Size(230, 429);
      this.dtgCategoria.TabIndex = 67;
      this.dtgCategoria.DespuesCambioFila += new System.EventHandler<ITD.Win.FilaGrillaEventArg>(this.dtgCategoria_DespuesCambioFila);
      // 
      // ColCategoria
      // 
      this.ColCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.ColCategoria.DataPropertyName = "Categoria";
      this.ColCategoria.HeaderText = "Catergoría";
      this.ColCategoria.Name = "ColCategoria";
      this.ColCategoria.ReadOnly = true;
      // 
      // splitContainer2
      // 
      this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitContainer2.Location = new System.Drawing.Point(0, 0);
      this.splitContainer2.Name = "splitContainer2";
      // 
      // splitContainer2.Panel1
      // 
      this.splitContainer2.Panel1.Controls.Add(this.dtgSubcategoria);
      // 
      // splitContainer2.Panel2
      // 
      this.splitContainer2.Panel2.Controls.Add(this.dtgPrincipal);
      this.splitContainer2.Size = new System.Drawing.Size(723, 433);
      this.splitContainer2.SplitterDistance = 283;
      this.splitContainer2.TabIndex = 8;
      // 
      // dtgSubcategoria
      // 
      this.dtgSubcategoria.AllowUserToAddRows = false;
      this.dtgSubcategoria.AllowUserToDeleteRows = false;
      this.dtgSubcategoria.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dtgSubcategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.dtgSubcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgSubcategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSubcategoria});
      this.dtgSubcategoria.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgSubcategoria.IdCopia = 0;
      this.dtgSubcategoria.Location = new System.Drawing.Point(0, 0);
      this.dtgSubcategoria.Name = "dtgSubcategoria";
      this.dtgSubcategoria.OpcionCopiarVisible = false;
      this.dtgSubcategoria.OpcionEliminarVisible = false;
      this.dtgSubcategoria.OpcionesActivas = 63;
      this.dtgSubcategoria.OpcionesVisibles = 48;
      this.dtgSubcategoria.OpcionInsertarVisible = false;
      this.dtgSubcategoria.OpcionPegarVisible = false;
      this.dtgSubcategoria.ReadOnly = true;
      this.dtgSubcategoria.RefrescandoGrilla = false;
      this.dtgSubcategoria.Size = new System.Drawing.Size(279, 429);
      this.dtgSubcategoria.TabIndex = 67;
      this.dtgSubcategoria.DespuesCambioFila += new System.EventHandler<ITD.Win.FilaGrillaEventArg>(this.dtgSubcategoria_DespuesCambioFila);
      // 
      // ColSubcategoria
      // 
      this.ColSubcategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.ColSubcategoria.DataPropertyName = "Subcategoria";
      this.ColSubcategoria.HeaderText = "Subcategoría";
      this.ColSubcategoria.Name = "ColSubcategoria";
      this.ColSubcategoria.ReadOnly = true;
      // 
      // Documento
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.ClientSize = new System.Drawing.Size(961, 480);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.tlsPrincipal);
      this.EnterComoTab = true;
      this.KeyPreview = true;
      this.Name = "Documento";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Gestor documental";
      this.Load += new System.EventHandler(this.GrillaAct_Load);
      this.Controls.SetChildIndex(this.tlsPrincipal, 0);
      this.Controls.SetChildIndex(this.splitContainer1, 0);
      this.tlsPrincipal.ResumeLayout(false);
      this.tlsPrincipal.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).EndInit();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dtgCategoria)).EndInit();
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
      this.splitContainer2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dtgSubcategoria)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private ITD.Win.Grilla dtgPrincipal;
    private System.Windows.Forms.ToolStrip tlsPrincipal;
    private System.Windows.Forms.ToolStripButton tsbGuardar;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton tsbRefrescar;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private ITD.Win.Grilla dtgCategoria;
    private ITD.Win.Grilla dtgSubcategoria;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColSubcategoria;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColDocumento;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColVersion;
    private System.Windows.Forms.DataGridViewImageColumn ColCargar;
    private System.Windows.Forms.DataGridViewImageColumn ColVer;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColCategoria;
  }
}
