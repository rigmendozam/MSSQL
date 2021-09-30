namespace APP {
  partial class Planta {
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
      this.tlsPrincipal = new System.Windows.Forms.ToolStrip();
      this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
      this.dtgPrincipal = new ITD.Win.Grilla(this.components);
      this.colnombre_planta = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.coldire_planta = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colid_comu = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.colid_ciud = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.ColCapacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColCapacidadMont = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colactivo_planta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
      this.tlsPrincipal.Size = new System.Drawing.Size(890, 25);
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
            this.coldire_planta,
            this.colid_comu,
            this.colid_ciud,
            this.ColCapacidad,
            this.ColCapacidadMont,
            this.colactivo_planta});
      this.dtgPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgPrincipal.IdCopia = 0;
      this.dtgPrincipal.Location = new System.Drawing.Point(0, 25);
      this.dtgPrincipal.Name = "dtgPrincipal";
      this.dtgPrincipal.OpcionCopiarVisible = false;
      this.dtgPrincipal.OpcionEliminarVisible = false;
      this.dtgPrincipal.OpcionesActivas = 63;
      this.dtgPrincipal.OpcionesVisibles = 0;
      this.dtgPrincipal.OpcionInmovilizarVisible = false;
      this.dtgPrincipal.OpcionInsertarVisible = false;
      this.dtgPrincipal.OpcionOperacionVisible = false;
      this.dtgPrincipal.OpcionPegarVisible = false;
      this.dtgPrincipal.RefrescandoGrilla = false;
      this.dtgPrincipal.Size = new System.Drawing.Size(890, 281);
      this.dtgPrincipal.TabIndex = 5;
      this.dtgPrincipal.AntesInsertar += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgPrincipal_AntesInsertar);
      this.dtgPrincipal.DespuesModificarFila += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgPrincipal_DespuesModificarFila);
      this.dtgPrincipal.InformaCambios += new System.EventHandler<System.EventArgs>(this.dtgPrincipal_InformaCambios);
      this.dtgPrincipal.CurrentCellDirtyStateChanged += new System.EventHandler(this.dtgPrincipal_CurrentCellDirtyStateChanged);
      // 
      // colnombre_planta
      // 
      this.colnombre_planta.DataPropertyName = "nombre_planta";
      this.colnombre_planta.HeaderText = "Planta";
      this.colnombre_planta.MaxInputLength = 20;
      this.colnombre_planta.Name = "colnombre_planta";
      this.colnombre_planta.Width = 150;
      // 
      // coldire_planta
      // 
      this.coldire_planta.DataPropertyName = "dire_planta";
      this.coldire_planta.HeaderText = "Dirección";
      this.coldire_planta.MaxInputLength = 50;
      this.coldire_planta.Name = "coldire_planta";
      this.coldire_planta.Width = 150;
      // 
      // colid_comu
      // 
      this.colid_comu.DataPropertyName = "id_comu";
      this.colid_comu.DisplayStyleForCurrentCellOnly = true;
      this.colid_comu.HeaderText = "Comuna";
      this.colid_comu.Name = "colid_comu";
      // 
      // colid_ciud
      // 
      this.colid_ciud.DataPropertyName = "id_ciud";
      this.colid_ciud.DisplayStyleForCurrentCellOnly = true;
      this.colid_ciud.HeaderText = "Ciudad";
      this.colid_ciud.Name = "colid_ciud";
      this.colid_ciud.Width = 80;
      // 
      // ColCapacidad
      // 
      this.ColCapacidad.DataPropertyName = "Capacidad";
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle2.Format = "#,##0";
      this.ColCapacidad.DefaultCellStyle = dataGridViewCellStyle2;
      this.ColCapacidad.HeaderText = "Pallet Desp";
      this.ColCapacidad.Name = "ColCapacidad";
      this.ColCapacidad.ToolTipText = "Capacidad de pallets despacho";
      // 
      // ColCapacidadMont
      // 
      this.ColCapacidadMont.DataPropertyName = "CapacidadMont";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle3.Format = "#,##0";
      this.ColCapacidadMont.DefaultCellStyle = dataGridViewCellStyle3;
      this.ColCapacidadMont.HeaderText = "Pallet Desp. Mont";
      this.ColCapacidadMont.Name = "ColCapacidadMont";
      // 
      // colactivo_planta
      // 
      this.colactivo_planta.DataPropertyName = "activo_planta";
      this.colactivo_planta.HeaderText = "Activo";
      this.colactivo_planta.Name = "colactivo_planta";
      this.colactivo_planta.Width = 50;
      // 
      // Planta
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.ClientSize = new System.Drawing.Size(890, 328);
      this.Controls.Add(this.dtgPrincipal);
      this.Controls.Add(this.tlsPrincipal);
      this.EnterComoTab = true;
      this.KeyPreview = true;
      this.Name = "Planta";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Plantas";
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
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_planta;
    private System.Windows.Forms.DataGridViewTextBoxColumn coldire_planta;
    private System.Windows.Forms.DataGridViewComboBoxColumn colid_comu;
    private System.Windows.Forms.DataGridViewComboBoxColumn colid_ciud;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColCapacidad;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColCapacidadMont;
    private System.Windows.Forms.DataGridViewCheckBoxColumn colactivo_planta;
  }
}
