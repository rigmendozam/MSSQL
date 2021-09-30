namespace APP {
  partial class PickingMotivo {
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
      this.label1 = new System.Windows.Forms.Label();
      this.ddlMotivo = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtObs = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.ddlResponsable = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // btnAceptar
      // 
      this.btnAceptar.Location = new System.Drawing.Point(89, 109);
      this.btnAceptar.Name = "btnAceptar";
      this.btnAceptar.Size = new System.Drawing.Size(75, 23);
      this.btnAceptar.TabIndex = 3;
      this.btnAceptar.Text = "Aceptar";
      this.btnAceptar.UseVisualStyleBackColor = true;
      this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
      // 
      // btnCancelar
      // 
      this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancelar.Location = new System.Drawing.Point(236, 109);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(75, 23);
      this.btnCancelar.TabIndex = 4;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 20);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(39, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Motivo";
      // 
      // ddlMotivo
      // 
      this.ddlMotivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlMotivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlMotivo.DisplayMember = "Motivo";
      this.ddlMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlMotivo.FormattingEnabled = true;
      this.ddlMotivo.Location = new System.Drawing.Point(84, 16);
      this.ddlMotivo.Name = "ddlMotivo";
      this.ddlMotivo.Size = new System.Drawing.Size(287, 21);
      this.ddlMotivo.TabIndex = 0;
      this.ddlMotivo.ValueMember = "Id";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 80);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(67, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Observación";
      // 
      // txtObs
      // 
      this.txtObs.Location = new System.Drawing.Point(84, 70);
      this.txtObs.Multiline = true;
      this.txtObs.Name = "txtObs";
      this.txtObs.Size = new System.Drawing.Size(287, 33);
      this.txtObs.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 47);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(69, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Responsable";
      // 
      // ddlResponsable
      // 
      this.ddlResponsable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlResponsable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlResponsable.DisplayMember = "Responsable";
      this.ddlResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlResponsable.FormattingEnabled = true;
      this.ddlResponsable.Location = new System.Drawing.Point(84, 43);
      this.ddlResponsable.Name = "ddlResponsable";
      this.ddlResponsable.Size = new System.Drawing.Size(287, 21);
      this.ddlResponsable.TabIndex = 1;
      this.ddlResponsable.ValueMember = "Id";
      // 
      // PickingMotivo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.CancelButton = this.btnCancelar;
      this.ClientSize = new System.Drawing.Size(398, 164);
      this.Controls.Add(this.txtObs);
      this.Controls.Add(this.ddlResponsable);
      this.Controls.Add(this.ddlMotivo);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.btnAceptar);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.GuardaPersistencia = false;
      this.KeyPreview = true;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "PickingMotivo";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Motivo";
      this.Load += new System.EventHandler(this.FormularioPopUp_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnAceptar;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    public System.Windows.Forms.ComboBox ddlMotivo;
    public System.Windows.Forms.TextBox txtObs;
    private System.Windows.Forms.Label label3;
    public System.Windows.Forms.ComboBox ddlResponsable;
  }
}
