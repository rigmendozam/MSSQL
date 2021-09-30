namespace APP {
  partial class PickingCambioProceso {
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
      this.btnAceptar = new System.Windows.Forms.Button();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.ddlLinea = new System.Windows.Forms.ComboBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.dtpFecha = new System.Windows.Forms.DateTimePicker();
      this.label6 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.txtid_picking = new System.Windows.Forms.TextBox();
      this.txtid_OT = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btnAceptar
      // 
      this.btnAceptar.Location = new System.Drawing.Point(80, 109);
      this.btnAceptar.Name = "btnAceptar";
      this.btnAceptar.Size = new System.Drawing.Size(75, 23);
      this.btnAceptar.TabIndex = 0;
      this.btnAceptar.Text = "Aceptar";
      this.btnAceptar.UseVisualStyleBackColor = true;
      this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
      // 
      // btnCancelar
      // 
      this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancelar.Location = new System.Drawing.Point(227, 109);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(75, 23);
      this.btnCancelar.TabIndex = 1;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      // 
      // ddlLinea
      // 
      this.ddlLinea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlLinea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlLinea.DisplayMember = "Nombre";
      this.ddlLinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlLinea.FormattingEnabled = true;
      this.ddlLinea.Location = new System.Drawing.Point(253, 48);
      this.ddlLinea.Name = "ddlLinea";
      this.ddlLinea.Size = new System.Drawing.Size(92, 21);
      this.ddlLinea.TabIndex = 41;
      this.ddlLinea.ValueMember = "Id";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(204, 52);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(35, 13);
      this.label7.TabIndex = 46;
      this.label7.Text = "Línea";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(24, 52);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(37, 13);
      this.label5.TabIndex = 45;
      this.label5.Text = "Fecha";
      // 
      // dtpFecha
      // 
      this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpFecha.Location = new System.Drawing.Point(81, 48);
      this.dtpFecha.Name = "dtpFecha";
      this.dtpFecha.Size = new System.Drawing.Size(120, 20);
      this.dtpFecha.TabIndex = 40;
      this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(24, 27);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(44, 13);
      this.label6.TabIndex = 43;
      this.label6.Text = "Número";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(204, 27);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(46, 13);
      this.label8.TabIndex = 42;
      this.label8.Text = "Proceso";
      // 
      // txtid_picking
      // 
      this.txtid_picking.Location = new System.Drawing.Point(81, 23);
      this.txtid_picking.Name = "txtid_picking";
      this.txtid_picking.ReadOnly = true;
      this.txtid_picking.Size = new System.Drawing.Size(120, 20);
      this.txtid_picking.TabIndex = 38;
      this.txtid_picking.TabStop = false;
      // 
      // txtid_OT
      // 
      this.txtid_OT.Location = new System.Drawing.Point(253, 23);
      this.txtid_OT.Name = "txtid_OT";
      this.txtid_OT.Size = new System.Drawing.Size(92, 20);
      this.txtid_OT.TabIndex = 39;
      this.txtid_OT.TabStop = false;
      this.txtid_OT.TextChanged += new System.EventHandler(this.txtid_OT_TextChanged);
      this.txtid_OT.Validated += new System.EventHandler(this.txtid_OT_Validated);
      // 
      // PickingCambioProceso
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.CancelButton = this.btnCancelar;
      this.ClientSize = new System.Drawing.Size(371, 155);
      this.Controls.Add(this.ddlLinea);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.dtpFecha);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.txtid_picking);
      this.Controls.Add(this.txtid_OT);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.btnAceptar);
      this.EnterComoTab = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.GuardaPersistencia = false;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "PickingCambioProceso";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Cambiar proceso";
      this.Load += new System.EventHandler(this.FormularioPopUp_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnAceptar;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.ComboBox ddlLinea;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.DateTimePicker dtpFecha;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txtid_picking;
    private System.Windows.Forms.TextBox txtid_OT;
  }
}
