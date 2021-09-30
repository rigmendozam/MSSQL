namespace APP {
  partial class RecepcionVerOS {
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      this.dtgPrincipal = new ITD.Win.Grilla(this.components);
      this.colId_OC = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColFechaCrea = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colid_ptt = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colcodigo_ptt = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colnombre_ptt = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColFichaSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colLlegadaProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colEntregaProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColEstadoDet = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColFechaUltProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colcant_detOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
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
            this.colId_OC,
            this.colEstado,
            this.ColFechaCrea,
            this.colid_ptt,
            this.colcodigo_ptt,
            this.colnombre_ptt,
            this.colOC,
            this.ColFichaSub,
            this.colLlegadaProd,
            this.colEntregaProd,
            this.ColEstadoDet,
            this.ColFechaUltProd,
            this.colcant_detOC});
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
      this.dtgPrincipal.Size = new System.Drawing.Size(1471, 306);
      this.dtgPrincipal.TabIndex = 67;
      // 
      // colId_OC
      // 
      this.colId_OC.DataPropertyName = "Id_OC";
      this.colId_OC.HeaderText = "Número";
      this.colId_OC.MaxInputLength = 20;
      this.colId_OC.Name = "colId_OC";
      this.colId_OC.ReadOnly = true;
      this.colId_OC.Width = 80;
      // 
      // colEstado
      // 
      this.colEstado.DataPropertyName = "Estado";
      this.colEstado.HeaderText = "Estado";
      this.colEstado.MaxInputLength = 30;
      this.colEstado.Name = "colEstado";
      this.colEstado.ReadOnly = true;
      this.colEstado.Width = 80;
      // 
      // ColFechaCrea
      // 
      this.ColFechaCrea.DataPropertyName = "FechaHora";
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle2.Format = "g";
      this.ColFechaCrea.DefaultCellStyle = dataGridViewCellStyle2;
      this.ColFechaCrea.HeaderText = "Fecha Crea";
      this.ColFechaCrea.Name = "ColFechaCrea";
      this.ColFechaCrea.ReadOnly = true;
      this.ColFechaCrea.ToolTipText = "Fecha de creación";
      // 
      // colid_ptt
      // 
      this.colid_ptt.DataPropertyName = "id_ptt";
      this.colid_ptt.HeaderText = "PTT";
      this.colid_ptt.Name = "colid_ptt";
      this.colid_ptt.ReadOnly = true;
      this.colid_ptt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.colid_ptt.Width = 80;
      // 
      // colcodigo_ptt
      // 
      this.colcodigo_ptt.DataPropertyName = "codigo_ptt";
      this.colcodigo_ptt.HeaderText = "Código";
      this.colcodigo_ptt.MaxInputLength = 20;
      this.colcodigo_ptt.Name = "colcodigo_ptt";
      this.colcodigo_ptt.ReadOnly = true;
      this.colcodigo_ptt.Width = 120;
      // 
      // colnombre_ptt
      // 
      this.colnombre_ptt.DataPropertyName = "nombre_ptt";
      this.colnombre_ptt.HeaderText = "Descripción";
      this.colnombre_ptt.MaxInputLength = 50;
      this.colnombre_ptt.Name = "colnombre_ptt";
      this.colnombre_ptt.ReadOnly = true;
      this.colnombre_ptt.Width = 200;
      // 
      // colOC
      // 
      this.colOC.DataPropertyName = "OC";
      this.colOC.HeaderText = "OC";
      this.colOC.Name = "colOC";
      this.colOC.ReadOnly = true;
      this.colOC.Width = 80;
      // 
      // ColFichaSub
      // 
      this.ColFichaSub.DataPropertyName = "FichaSub";
      this.ColFichaSub.HeaderText = "Ficha Sub";
      this.ColFichaSub.Name = "ColFichaSub";
      this.ColFichaSub.ReadOnly = true;
      this.ColFichaSub.Width = 70;
      // 
      // colLlegadaProd
      // 
      this.colLlegadaProd.DataPropertyName = "LlegadaProd";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle3.Format = "d";
      this.colLlegadaProd.DefaultCellStyle = dataGridViewCellStyle3;
      this.colLlegadaProd.HeaderText = "Desde";
      this.colLlegadaProd.Name = "colLlegadaProd";
      this.colLlegadaProd.ReadOnly = true;
      // 
      // colEntregaProd
      // 
      this.colEntregaProd.DataPropertyName = "EntregaProd";
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle4.Format = "d";
      this.colEntregaProd.DefaultCellStyle = dataGridViewCellStyle4;
      this.colEntregaProd.HeaderText = "Hasta";
      this.colEntregaProd.Name = "colEntregaProd";
      this.colEntregaProd.ReadOnly = true;
      // 
      // ColEstadoDet
      // 
      this.ColEstadoDet.DataPropertyName = "EstadoDet";
      this.ColEstadoDet.HeaderText = "Estado";
      this.ColEstadoDet.Name = "ColEstadoDet";
      this.ColEstadoDet.ReadOnly = true;
      this.ColEstadoDet.Width = 80;
      // 
      // ColFechaUltProd
      // 
      this.ColFechaUltProd.DataPropertyName = "UltimaFecha";
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle5.Format = "d";
      this.ColFechaUltProd.DefaultCellStyle = dataGridViewCellStyle5;
      this.ColFechaUltProd.HeaderText = "Ult. Prod";
      this.ColFechaUltProd.Name = "ColFechaUltProd";
      this.ColFechaUltProd.ReadOnly = true;
      this.ColFechaUltProd.ToolTipText = "Fecha última produccion";
      this.ColFechaUltProd.Width = 75;
      // 
      // colcant_detOC
      // 
      this.colcant_detOC.DataPropertyName = "cant_detOC";
      dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle6.Format = "#,##0.##";
      this.colcant_detOC.DefaultCellStyle = dataGridViewCellStyle6;
      this.colcant_detOC.HeaderText = "Cantidad";
      this.colcant_detOC.Name = "colcant_detOC";
      this.colcant_detOC.ReadOnly = true;
      this.colcant_detOC.Width = 70;
      // 
      // RecepcionVerOS
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.ClientSize = new System.Drawing.Size(1471, 328);
      this.Controls.Add(this.dtgPrincipal);
      this.EnterComoTab = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.GuardaPersistencia = false;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "RecepcionVerOS";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Órdenes de servicio";
      this.Load += new System.EventHandler(this.FormularioPopUp_Load);
      this.Controls.SetChildIndex(this.dtgPrincipal, 0);
      ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private ITD.Win.Grilla dtgPrincipal;
    private System.Windows.Forms.DataGridViewTextBoxColumn colId_OC;
    private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaCrea;
    private System.Windows.Forms.DataGridViewTextBoxColumn colid_ptt;
    private System.Windows.Forms.DataGridViewTextBoxColumn colcodigo_ptt;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_ptt;
    private System.Windows.Forms.DataGridViewTextBoxColumn colOC;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColFichaSub;
    private System.Windows.Forms.DataGridViewTextBoxColumn colLlegadaProd;
    private System.Windows.Forms.DataGridViewTextBoxColumn colEntregaProd;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColEstadoDet;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaUltProd;
    private System.Windows.Forms.DataGridViewTextBoxColumn colcant_detOC;
  }
}
