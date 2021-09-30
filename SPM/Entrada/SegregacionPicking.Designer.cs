namespace APP {
  partial class SegPicking {
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      this.tlsPrincipal = new System.Windows.Forms.ToolStrip();
      this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
      this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
      this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.ddlReporte = new System.Windows.Forms.ToolStripComboBox();
      this.txtCodigo = new System.Windows.Forms.TextBox();
      this.txtDescripcion = new System.Windows.Forms.TextBox();
      this.txtTarja = new System.Windows.Forms.TextBox();
      this.txtLote = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.txtOC = new System.Windows.Forms.TextBox();
      this.txtCantidad = new System.Windows.Forms.TextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.dtgSegPicking = new ITD.Win.Grilla(this.components);
      this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.txtVenceLote = new System.Windows.Forms.TextBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.tlsPrincipal.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgSegPicking)).BeginInit();
      this.SuspendLayout();
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
            this.ddlReporte});
      this.tlsPrincipal.Location = new System.Drawing.Point(0, 0);
      this.tlsPrincipal.Name = "tlsPrincipal";
      this.tlsPrincipal.Size = new System.Drawing.Size(667, 27);
      this.tlsPrincipal.TabIndex = 0;
      // 
      // tsbNuevo
      // 
      this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbNuevo.Image = global::APP.Properties.Resources.Nuevo;
      this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbNuevo.Name = "tsbNuevo";
      this.tsbNuevo.Size = new System.Drawing.Size(24, 24);
      this.tsbNuevo.Text = "Nuevo";
      // 
      // tsbGuardar
      // 
      this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbGuardar.Image = global::APP.Properties.Resources.grabar;
      this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbGuardar.Name = "tsbGuardar";
      this.tsbGuardar.Size = new System.Drawing.Size(24, 24);
      this.tsbGuardar.Text = "Guardar";
      // 
      // tsbEliminar
      // 
      this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbEliminar.Image = global::APP.Properties.Resources.Cancelar;
      this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbEliminar.Name = "tsbEliminar";
      this.tsbEliminar.Size = new System.Drawing.Size(24, 24);
      this.tsbEliminar.Text = "Eliminar";
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
            "Picking List",
            "Picking OT"});
      this.ddlReporte.Name = "ddlReporte";
      this.ddlReporte.Size = new System.Drawing.Size(170, 27);
      // 
      // txtCodigo
      // 
      this.txtCodigo.Location = new System.Drawing.Point(96, 42);
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.Size = new System.Drawing.Size(79, 20);
      this.txtCodigo.TabIndex = 2;
      // 
      // txtDescripcion
      // 
      this.txtDescripcion.Location = new System.Drawing.Point(96, 65);
      this.txtDescripcion.Name = "txtDescripcion";
      this.txtDescripcion.Size = new System.Drawing.Size(205, 20);
      this.txtDescripcion.TabIndex = 4;
      // 
      // txtTarja
      // 
      this.txtTarja.Location = new System.Drawing.Point(96, 88);
      this.txtTarja.Name = "txtTarja";
      this.txtTarja.Size = new System.Drawing.Size(79, 20);
      this.txtTarja.TabIndex = 6;
      // 
      // txtLote
      // 
      this.txtLote.Location = new System.Drawing.Point(421, 42);
      this.txtLote.Name = "txtLote";
      this.txtLote.Size = new System.Drawing.Size(103, 20);
      this.txtLote.TabIndex = 10;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(22, 45);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(40, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Codigo";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(347, 45);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(28, 13);
      this.label2.TabIndex = 9;
      this.label2.Text = "Lote";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(22, 91);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(31, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Tarja";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(22, 68);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(63, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Descripción";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(347, 69);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(62, 13);
      this.label5.TabIndex = 11;
      this.label5.Text = "Vence Lote";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(22, 114);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(22, 13);
      this.label9.TabIndex = 19;
      this.label9.Text = "OC";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(347, 93);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(49, 13);
      this.label11.TabIndex = 17;
      this.label11.Text = "Cantidad";
      // 
      // txtOC
      // 
      this.txtOC.Location = new System.Drawing.Point(96, 111);
      this.txtOC.Name = "txtOC";
      this.txtOC.Size = new System.Drawing.Size(119, 20);
      this.txtOC.TabIndex = 20;
      // 
      // txtCantidad
      // 
      this.txtCantidad.Location = new System.Drawing.Point(421, 90);
      this.txtCantidad.Name = "txtCantidad";
      this.txtCantidad.Size = new System.Drawing.Size(103, 20);
      this.txtCantidad.TabIndex = 18;
      // 
      // panel1
      // 
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel1.Controls.Add(this.dtgSegPicking);
      this.panel1.Location = new System.Drawing.Point(25, 170);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(377, 172);
      this.panel1.TabIndex = 24;
      // 
      // dtgSegPicking
      // 
      this.dtgSegPicking.AllowUserToAddRows = false;
      this.dtgSegPicking.AllowUserToDeleteRows = false;
      this.dtgSegPicking.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dtgSegPicking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.dtgSegPicking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8});
      this.dtgSegPicking.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgSegPicking.IdCopia = 0;
      this.dtgSegPicking.Location = new System.Drawing.Point(0, 0);
      this.dtgSegPicking.Name = "dtgSegPicking";
      this.dtgSegPicking.OpcionCopiarVisible = false;
      this.dtgSegPicking.OpcionEliminarVisible = false;
      this.dtgSegPicking.OpcionesActivas = 63;
      this.dtgSegPicking.OpcionesVisibles = 48;
      this.dtgSegPicking.OpcionInsertarVisible = false;
      this.dtgSegPicking.OpcionPegarVisible = false;
      this.dtgSegPicking.RefrescandoGrilla = false;
      this.dtgSegPicking.Size = new System.Drawing.Size(373, 168);
      this.dtgSegPicking.TabIndex = 24;
      // 
      // dataGridViewTextBoxColumn8
      // 
      this.dataGridViewTextBoxColumn8.DataPropertyName = "cant_detPick";
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle4.Format = "#,##0";
      this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle4;
      this.dataGridViewTextBoxColumn8.HeaderText = "Cantidad";
      this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
      this.dataGridViewTextBoxColumn8.Width = 120;
      // 
      // txtVenceLote
      // 
      this.txtVenceLote.Location = new System.Drawing.Point(421, 66);
      this.txtVenceLote.Name = "txtVenceLote";
      this.txtVenceLote.Size = new System.Drawing.Size(128, 20);
      this.txtVenceLote.TabIndex = 25;
      // 
      // panel2
      // 
      this.panel2.BackgroundImage = global::APP.Properties.Resources.Captura1;
      this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.panel2.Location = new System.Drawing.Point(421, 172);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(225, 168);
      this.panel2.TabIndex = 26;
      // 
      // SegPicking
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.ClientSize = new System.Drawing.Size(667, 362);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.txtVenceLote);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.txtOC);
      this.Controls.Add(this.txtCantidad);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtLote);
      this.Controls.Add(this.txtTarja);
      this.Controls.Add(this.txtDescripcion);
      this.Controls.Add(this.txtCodigo);
      this.Controls.Add(this.tlsPrincipal);
      this.EnterComoTab = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.GuardaPersistencia = false;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SegPicking";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Segregacion Picking";
      this.Load += new System.EventHandler(this.FormularioPopUp_Load);
      this.tlsPrincipal.ResumeLayout(false);
      this.tlsPrincipal.PerformLayout();
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dtgSegPicking)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.ToolStrip tlsPrincipal;
    private System.Windows.Forms.ToolStripButton tsbNuevo;
    private System.Windows.Forms.ToolStripButton tsbGuardar;
    private System.Windows.Forms.ToolStripButton tsbEliminar;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripButton tsbRefrescar;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripComboBox ddlReporte;
    private System.Windows.Forms.TextBox txtCodigo;
    private System.Windows.Forms.TextBox txtDescripcion;
    private System.Windows.Forms.TextBox txtTarja;
    private System.Windows.Forms.TextBox txtLote;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox txtOC;
    private System.Windows.Forms.TextBox txtCantidad;
    private System.Windows.Forms.Panel panel1;
    private ITD.Win.Grilla dtgSegPicking;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private System.Windows.Forms.TextBox txtVenceLote;
    private System.Windows.Forms.Panel panel2;
  }
}
