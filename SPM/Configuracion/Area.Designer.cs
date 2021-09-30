namespace APP {
  partial class Area {
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
      this.tlsPrincipal = new System.Windows.Forms.ToolStrip();
      this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
      this.dtgPrincipal = new ITD.Win.Grilla(this.components);
      this.colnombre_areas = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tlsPrincipal.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
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
      this.tlsPrincipal.Size = new System.Drawing.Size(333, 25);
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
            this.colnombre_areas});
      this.dtgPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgPrincipal.IdCopia = 0;
      this.dtgPrincipal.Location = new System.Drawing.Point(0, 25);
      this.dtgPrincipal.Name = "dtgPrincipal";
      this.dtgPrincipal.OpcionesActivas = 63;
      this.dtgPrincipal.OpcionesVisibles = 15;
      this.dtgPrincipal.OpcionInmovilizarVisible = false;
      this.dtgPrincipal.OpcionOperacionVisible = false;
      this.dtgPrincipal.RefrescandoGrilla = false;
      this.dtgPrincipal.Size = new System.Drawing.Size(333, 281);
      this.dtgPrincipal.TabIndex = 5;
      this.dtgPrincipal.AntesInsertar += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgPrincipal_AntesInsertar);
      this.dtgPrincipal.DespuesModificarFila += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgPrincipal_DespuesModificarFila);
      this.dtgPrincipal.InformaCambios += new System.EventHandler<System.EventArgs>(this.dtgPrincipal_InformaCambios);
      this.dtgPrincipal.CurrentCellDirtyStateChanged += new System.EventHandler(this.dtgPrincipal_CurrentCellDirtyStateChanged);
      // 
      // colnombre_areas
      // 
      this.colnombre_areas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colnombre_areas.DataPropertyName = "nombre_areas";
      this.colnombre_areas.HeaderText = "Áreas";
      this.colnombre_areas.MaxInputLength = 50;
      this.colnombre_areas.Name = "colnombre_areas";
      // 
      // Area
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.ClientSize = new System.Drawing.Size(333, 328);
      this.Controls.Add(this.dtgPrincipal);
      this.Controls.Add(this.tlsPrincipal);
      this.EnterComoTab = true;
      this.KeyPreview = true;
      this.Name = "Area";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Área";
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
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_areas;
  }
}
