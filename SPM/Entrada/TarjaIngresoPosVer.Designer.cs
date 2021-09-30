namespace APP {
  partial class TarjaIngresoPosVer {
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      this.dtgPrincipal = new ITD.Win.Grilla(this.components);
      this.colnombre_planta = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colid_taring = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colid_insumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colnombre_insumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colfecha_ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colcant_taring = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.collote_tarIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colvenceLote_tarIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colnombre_estadoTarja = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cmsReposicionar = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.tsmReposicionar = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
      this.cmsReposicionar.SuspendLayout();
      this.SuspendLayout();
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
            this.colid_taring,
            this.colid_insumo,
            this.colnombre_insumo,
            this.ColCliente,
            this.colfecha_ingreso,
            this.colcant_taring,
            this.ColSaldo,
            this.ColOC,
            this.collote_tarIng,
            this.colvenceLote_tarIng,
            this.colnombre_estadoTarja});
      this.dtgPrincipal.ContextMenuStrip = this.cmsReposicionar;
      this.dtgPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgPrincipal.IdCopia = 0;
      this.dtgPrincipal.Location = new System.Drawing.Point(0, 0);
      this.dtgPrincipal.Name = "dtgPrincipal";
      this.dtgPrincipal.OpcionCopiarVisible = false;
      this.dtgPrincipal.OpcionEliminarVisible = false;
      this.dtgPrincipal.OpcionesActivas = 63;
      this.dtgPrincipal.OpcionesVisibles = 48;
      this.dtgPrincipal.OpcionInsertarVisible = false;
      this.dtgPrincipal.OpcionPegarVisible = false;
      this.dtgPrincipal.ReadOnly = true;
      this.dtgPrincipal.RefrescandoGrilla = false;
      this.dtgPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dtgPrincipal.Size = new System.Drawing.Size(1608, 288);
      this.dtgPrincipal.TabIndex = 68;
      this.dtgPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_CellContentClick);
      // 
      // colnombre_planta
      // 
      this.colnombre_planta.DataPropertyName = "nombre_planta";
      this.colnombre_planta.HeaderText = "Planta";
      this.colnombre_planta.MaxInputLength = 20;
      this.colnombre_planta.Name = "colnombre_planta";
      this.colnombre_planta.ReadOnly = true;
      this.colnombre_planta.Width = 150;
      // 
      // colid_taring
      // 
      this.colid_taring.DataPropertyName = "id_taring";
      this.colid_taring.HeaderText = "Tarja";
      this.colid_taring.Name = "colid_taring";
      this.colid_taring.ReadOnly = true;
      this.colid_taring.Width = 70;
      // 
      // colid_insumo
      // 
      this.colid_insumo.DataPropertyName = "id_insumo";
      this.colid_insumo.HeaderText = "Código";
      this.colid_insumo.MaxInputLength = 20;
      this.colid_insumo.Name = "colid_insumo";
      this.colid_insumo.ReadOnly = true;
      // 
      // colnombre_insumo
      // 
      this.colnombre_insumo.DataPropertyName = "nombre_insumo";
      this.colnombre_insumo.HeaderText = "Insumo";
      this.colnombre_insumo.MaxInputLength = 50;
      this.colnombre_insumo.Name = "colnombre_insumo";
      this.colnombre_insumo.ReadOnly = true;
      this.colnombre_insumo.Width = 250;
      // 
      // ColCliente
      // 
      this.ColCliente.DataPropertyName = "nombre_clie";
      this.ColCliente.HeaderText = "Cliente";
      this.ColCliente.Name = "ColCliente";
      this.ColCliente.ReadOnly = true;
      this.ColCliente.Width = 200;
      // 
      // colfecha_ingreso
      // 
      this.colfecha_ingreso.DataPropertyName = "fecha_ingreso";
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle2.Format = "d";
      this.colfecha_ingreso.DefaultCellStyle = dataGridViewCellStyle2;
      this.colfecha_ingreso.HeaderText = "Fecha ingreso";
      this.colfecha_ingreso.Name = "colfecha_ingreso";
      this.colfecha_ingreso.ReadOnly = true;
      // 
      // colcant_taring
      // 
      this.colcant_taring.DataPropertyName = "cant_taring";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle3.Format = "#,##0.##";
      this.colcant_taring.DefaultCellStyle = dataGridViewCellStyle3;
      this.colcant_taring.HeaderText = "Cantidad";
      this.colcant_taring.Name = "colcant_taring";
      this.colcant_taring.ReadOnly = true;
      this.colcant_taring.Width = 70;
      // 
      // ColSaldo
      // 
      this.ColSaldo.DataPropertyName = "saldo_taring";
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle4.Format = "#,##0";
      this.ColSaldo.DefaultCellStyle = dataGridViewCellStyle4;
      this.ColSaldo.HeaderText = "Saldo";
      this.ColSaldo.Name = "ColSaldo";
      this.ColSaldo.ReadOnly = true;
      this.ColSaldo.Width = 70;
      // 
      // ColOC
      // 
      this.ColOC.DataPropertyName = "OC";
      this.ColOC.HeaderText = "OC";
      this.ColOC.Name = "ColOC";
      this.ColOC.ReadOnly = true;
      this.ColOC.Width = 90;
      // 
      // collote_tarIng
      // 
      this.collote_tarIng.DataPropertyName = "lote_tarIng";
      this.collote_tarIng.HeaderText = "Lote";
      this.collote_tarIng.MaxInputLength = 25;
      this.collote_tarIng.Name = "collote_tarIng";
      this.collote_tarIng.ReadOnly = true;
      this.collote_tarIng.Width = 80;
      // 
      // colvenceLote_tarIng
      // 
      this.colvenceLote_tarIng.DataPropertyName = "venceLote_tarIng";
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle5.Format = "d";
      this.colvenceLote_tarIng.DefaultCellStyle = dataGridViewCellStyle5;
      this.colvenceLote_tarIng.HeaderText = "Fecha Vcto";
      this.colvenceLote_tarIng.Name = "colvenceLote_tarIng";
      this.colvenceLote_tarIng.ReadOnly = true;
      this.colvenceLote_tarIng.Width = 80;
      // 
      // colnombre_estadoTarja
      // 
      this.colnombre_estadoTarja.DataPropertyName = "nombre_estadoTarja";
      this.colnombre_estadoTarja.HeaderText = "Estado";
      this.colnombre_estadoTarja.MaxInputLength = 20;
      this.colnombre_estadoTarja.Name = "colnombre_estadoTarja";
      this.colnombre_estadoTarja.ReadOnly = true;
      // 
      // cmsReposicionar
      // 
      this.cmsReposicionar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmReposicionar});
      this.cmsReposicionar.Name = "cmsReposicionar";
      this.cmsReposicionar.Size = new System.Drawing.Size(153, 48);
      // 
      // tsmReposicionar
      // 
      this.tsmReposicionar.Name = "tsmReposicionar";
      this.tsmReposicionar.Size = new System.Drawing.Size(152, 22);
      this.tsmReposicionar.Text = "Reposicionar";
      this.tsmReposicionar.Click += new System.EventHandler(this.tsmReposicionar_Click);
      // 
      // TarjaIngresoPosVer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1608, 310);
      this.Controls.Add(this.dtgPrincipal);
      this.EnterComoTab = true;
      this.GuardaPersistencia = false;
      this.KeyPreview = true;
      this.Margin = new System.Windows.Forms.Padding(5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "TarjaIngresoPosVer";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Tarjas de bodega en posición";
      this.Load += new System.EventHandler(this.Consulta_Load);
      this.Controls.SetChildIndex(this.dtgPrincipal, 0);
      ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).EndInit();
      this.cmsReposicionar.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private ITD.Win.Grilla dtgPrincipal;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_planta;
    private System.Windows.Forms.DataGridViewTextBoxColumn colid_taring;
    private System.Windows.Forms.DataGridViewTextBoxColumn colid_insumo;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_insumo;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColCliente;
    private System.Windows.Forms.DataGridViewTextBoxColumn colfecha_ingreso;
    private System.Windows.Forms.DataGridViewTextBoxColumn colcant_taring;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColSaldo;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColOC;
    private System.Windows.Forms.DataGridViewTextBoxColumn collote_tarIng;
    private System.Windows.Forms.DataGridViewTextBoxColumn colvenceLote_tarIng;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_estadoTarja;
    private System.Windows.Forms.ContextMenuStrip cmsReposicionar;
    private System.Windows.Forms.ToolStripMenuItem tsmReposicionar;
  }
}

