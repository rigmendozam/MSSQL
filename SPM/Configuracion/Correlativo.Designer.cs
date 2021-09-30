namespace APP {
  partial class Correlativo {
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Correlativo));
      this.tlsPrincipal = new System.Windows.Forms.ToolStrip();
      this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
      this.dtgPrincipal = new ITD.Win.Grilla(this.components);
      this.colid_prefijo_correlativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colnombre_correlativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colmodulo_correlativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colnumero_correlativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.spcPrincipal = new System.Windows.Forms.SplitContainer();
      this.dtgCAF = new ITD.Win.Grilla(this.components);
      this.ColDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColFechaSubida = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.tsbCargarCAF = new System.Windows.Forms.ToolStripButton();
      this.tlsPrincipal.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.spcPrincipal)).BeginInit();
      this.spcPrincipal.Panel1.SuspendLayout();
      this.spcPrincipal.Panel2.SuspendLayout();
      this.spcPrincipal.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgCAF)).BeginInit();
      this.toolStrip1.SuspendLayout();
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
      this.tlsPrincipal.Size = new System.Drawing.Size(775, 25);
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
            this.colid_prefijo_correlativo,
            this.colnombre_correlativo,
            this.colmodulo_correlativo,
            this.colnumero_correlativo});
      this.dtgPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgPrincipal.IdCopia = 0;
      this.dtgPrincipal.Location = new System.Drawing.Point(0, 0);
      this.dtgPrincipal.Name = "dtgPrincipal";
      this.dtgPrincipal.OpcionCopiarVisible = false;
      this.dtgPrincipal.OpcionEliminarVisible = false;
      this.dtgPrincipal.OpcionesActivas = 63;
      this.dtgPrincipal.OpcionesVisibles = 0;
      this.dtgPrincipal.OpcionInmovilizarVisible = false;
      this.dtgPrincipal.OpcionInsertarVisible = false;
      this.dtgPrincipal.OpcionOperacionVisible = false;
      this.dtgPrincipal.OpcionPegarVisible = false;
      this.dtgPrincipal.ReadOnly = true;
      this.dtgPrincipal.RefrescandoGrilla = false;
      this.dtgPrincipal.Size = new System.Drawing.Size(386, 283);
      this.dtgPrincipal.TabIndex = 5;
      this.dtgPrincipal.AntesInsertar += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgPrincipal_AntesInsertar);
      this.dtgPrincipal.DespuesModificarFila += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgPrincipal_DespuesModificarFila);
      this.dtgPrincipal.DespuesCambioFila += new System.EventHandler<ITD.Win.FilaGrillaEventArg>(this.dtgPrincipal_DespuesCambioFila);
      this.dtgPrincipal.InformaCambios += new System.EventHandler<System.EventArgs>(this.dtgPrincipal_InformaCambios);
      this.dtgPrincipal.CurrentCellDirtyStateChanged += new System.EventHandler(this.dtgPrincipal_CurrentCellDirtyStateChanged);
      // 
      // colid_prefijo_correlativo
      // 
      this.colid_prefijo_correlativo.DataPropertyName = "id_prefijo_correlativo";
      this.colid_prefijo_correlativo.HeaderText = "Prefijo";
      this.colid_prefijo_correlativo.MaxInputLength = 10;
      this.colid_prefijo_correlativo.Name = "colid_prefijo_correlativo";
      this.colid_prefijo_correlativo.ReadOnly = true;
      this.colid_prefijo_correlativo.Width = 60;
      // 
      // colnombre_correlativo
      // 
      this.colnombre_correlativo.DataPropertyName = "nombre_correlativo";
      this.colnombre_correlativo.HeaderText = "Nombre";
      this.colnombre_correlativo.MaxInputLength = 20;
      this.colnombre_correlativo.Name = "colnombre_correlativo";
      this.colnombre_correlativo.ReadOnly = true;
      // 
      // colmodulo_correlativo
      // 
      this.colmodulo_correlativo.DataPropertyName = "modulo_correlativo";
      this.colmodulo_correlativo.HeaderText = "Módulo";
      this.colmodulo_correlativo.MaxInputLength = 25;
      this.colmodulo_correlativo.Name = "colmodulo_correlativo";
      this.colmodulo_correlativo.ReadOnly = true;
      this.colmodulo_correlativo.Width = 80;
      // 
      // colnumero_correlativo
      // 
      this.colnumero_correlativo.DataPropertyName = "numero_correlativo";
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle1.Format = "#,##0.##";
      this.colnumero_correlativo.DefaultCellStyle = dataGridViewCellStyle1;
      this.colnumero_correlativo.HeaderText = "Número";
      this.colnumero_correlativo.Name = "colnumero_correlativo";
      this.colnumero_correlativo.ReadOnly = true;
      this.colnumero_correlativo.Width = 70;
      // 
      // spcPrincipal
      // 
      this.spcPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.spcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.spcPrincipal.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.spcPrincipal.Location = new System.Drawing.Point(0, 25);
      this.spcPrincipal.Name = "spcPrincipal";
      // 
      // spcPrincipal.Panel1
      // 
      this.spcPrincipal.Panel1.Controls.Add(this.dtgPrincipal);
      // 
      // spcPrincipal.Panel2
      // 
      this.spcPrincipal.Panel2.Controls.Add(this.dtgCAF);
      this.spcPrincipal.Panel2.Controls.Add(this.toolStrip1);
      this.spcPrincipal.Size = new System.Drawing.Size(775, 287);
      this.spcPrincipal.SplitterDistance = 390;
      this.spcPrincipal.TabIndex = 7;
      // 
      // dtgCAF
      // 
      this.dtgCAF.AllowUserToAddRows = false;
      this.dtgCAF.AllowUserToDeleteRows = false;
      this.dtgCAF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgCAF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDesde,
            this.ColHasta,
            this.ColFechaSubida});
      this.dtgCAF.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgCAF.IdCopia = 0;
      this.dtgCAF.Location = new System.Drawing.Point(0, 25);
      this.dtgCAF.Name = "dtgCAF";
      this.dtgCAF.OpcionCopiarVisible = false;
      this.dtgCAF.OpcionEliminarVisible = false;
      this.dtgCAF.OpcionesActivas = 63;
      this.dtgCAF.OpcionesVisibles = 0;
      this.dtgCAF.OpcionInmovilizarVisible = false;
      this.dtgCAF.OpcionInsertarVisible = false;
      this.dtgCAF.OpcionOperacionVisible = false;
      this.dtgCAF.OpcionPegarVisible = false;
      this.dtgCAF.ReadOnly = true;
      this.dtgCAF.RefrescandoGrilla = false;
      this.dtgCAF.Size = new System.Drawing.Size(377, 258);
      this.dtgCAF.TabIndex = 8;
      // 
      // ColDesde
      // 
      this.ColDesde.DataPropertyName = "Desde";
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle2.Format = "#,##0";
      this.ColDesde.DefaultCellStyle = dataGridViewCellStyle2;
      this.ColDesde.HeaderText = "Desde";
      this.ColDesde.Name = "ColDesde";
      this.ColDesde.ReadOnly = true;
      // 
      // ColHasta
      // 
      this.ColHasta.DataPropertyName = "Hasta";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle3.Format = "#,##0";
      this.ColHasta.DefaultCellStyle = dataGridViewCellStyle3;
      this.ColHasta.HeaderText = "Hasta";
      this.ColHasta.Name = "ColHasta";
      this.ColHasta.ReadOnly = true;
      // 
      // ColFechaSubida
      // 
      this.ColFechaSubida.DataPropertyName = "FechaCAF";
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle4.Format = "d";
      this.ColFechaSubida.DefaultCellStyle = dataGridViewCellStyle4;
      this.ColFechaSubida.HeaderText = "Fecha";
      this.ColFechaSubida.Name = "ColFechaSubida";
      this.ColFechaSubida.ReadOnly = true;
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCargarCAF});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(377, 25);
      this.toolStrip1.TabIndex = 7;
      // 
      // tsbCargarCAF
      // 
      this.tsbCargarCAF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tsbCargarCAF.Image = ((System.Drawing.Image)(resources.GetObject("tsbCargarCAF.Image")));
      this.tsbCargarCAF.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbCargarCAF.Name = "tsbCargarCAF";
      this.tsbCargarCAF.Size = new System.Drawing.Size(63, 22);
      this.tsbCargarCAF.Text = "Subir CAF";
      this.tsbCargarCAF.Click += new System.EventHandler(this.tsbCargarCAF_Click);
      // 
      // Correlativo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.ClientSize = new System.Drawing.Size(775, 334);
      this.Controls.Add(this.spcPrincipal);
      this.Controls.Add(this.tlsPrincipal);
      this.EnterComoTab = true;
      this.KeyPreview = true;
      this.Name = "Correlativo";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Correlativos";
      this.Load += new System.EventHandler(this.GrillaAct_Load);
      this.Controls.SetChildIndex(this.tlsPrincipal, 0);
      this.Controls.SetChildIndex(this.spcPrincipal, 0);
      this.tlsPrincipal.ResumeLayout(false);
      this.tlsPrincipal.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).EndInit();
      this.spcPrincipal.Panel1.ResumeLayout(false);
      this.spcPrincipal.Panel2.ResumeLayout(false);
      this.spcPrincipal.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.spcPrincipal)).EndInit();
      this.spcPrincipal.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dtgCAF)).EndInit();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private ITD.Win.Grilla dtgPrincipal;
    private System.Windows.Forms.ToolStrip tlsPrincipal;
    private System.Windows.Forms.ToolStripButton tsbGuardar;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton tsbRefrescar;
    private System.Windows.Forms.DataGridViewTextBoxColumn colid_prefijo_correlativo;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_correlativo;
    private System.Windows.Forms.DataGridViewTextBoxColumn colmodulo_correlativo;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnumero_correlativo;
    private System.Windows.Forms.SplitContainer spcPrincipal;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton tsbCargarCAF;
    private ITD.Win.Grilla dtgCAF;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColDesde;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColHasta;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaSubida;
  }
}
