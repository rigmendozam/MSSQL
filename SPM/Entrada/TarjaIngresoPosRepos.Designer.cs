namespace APP {
  partial class TarjaIngresoPosRepos {
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
      this.ddlBodega = new System.Windows.Forms.ComboBox();
      this.ddlRack = new System.Windows.Forms.ComboBox();
      this.ddlPosicion = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnAceptar
      // 
      this.btnAceptar.Location = new System.Drawing.Point(68, 106);
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
      this.btnCancelar.Location = new System.Drawing.Point(215, 106);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(75, 23);
      this.btnCancelar.TabIndex = 1;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      // 
      // ddlBodega
      // 
      this.ddlBodega.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlBodega.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlBodega.DisplayMember = "Bodega";
      this.ddlBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlBodega.FormattingEnabled = true;
      this.ddlBodega.Location = new System.Drawing.Point(78, 12);
      this.ddlBodega.Name = "ddlBodega";
      this.ddlBodega.Size = new System.Drawing.Size(200, 21);
      this.ddlBodega.TabIndex = 2;
      this.ddlBodega.ValueMember = "Id";
      this.ddlBodega.SelectedIndexChanged += new System.EventHandler(this.ddlBodega_SelectedIndexChanged);
      // 
      // ddlRack
      // 
      this.ddlRack.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlRack.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlRack.DisplayMember = "Nombre";
      this.ddlRack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlRack.FormattingEnabled = true;
      this.ddlRack.Location = new System.Drawing.Point(78, 39);
      this.ddlRack.Name = "ddlRack";
      this.ddlRack.Size = new System.Drawing.Size(200, 21);
      this.ddlRack.TabIndex = 3;
      this.ddlRack.ValueMember = "Id";
      this.ddlRack.SelectedIndexChanged += new System.EventHandler(this.ddlRack_SelectedIndexChanged);
      // 
      // ddlPosicion
      // 
      this.ddlPosicion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlPosicion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlPosicion.DisplayMember = "Nombre";
      this.ddlPosicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlPosicion.FormattingEnabled = true;
      this.ddlPosicion.Location = new System.Drawing.Point(78, 66);
      this.ddlPosicion.Name = "ddlPosicion";
      this.ddlPosicion.Size = new System.Drawing.Size(200, 21);
      this.ddlPosicion.TabIndex = 4;
      this.ddlPosicion.ValueMember = "Id";
      this.ddlPosicion.SelectedIndexChanged += new System.EventHandler(this.ddlPosicion_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(14, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "Bodega";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(14, 43);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(33, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Rack";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(14, 70);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(47, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Posición";
      // 
      // TarjaIngresoPosRepos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.CancelButton = this.btnCancelar;
      this.ClientSize = new System.Drawing.Size(322, 156);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.ddlPosicion);
      this.Controls.Add(this.ddlRack);
      this.Controls.Add(this.ddlBodega);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.btnAceptar);
      this.EnterComoTab = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.GuardaPersistencia = false;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "TarjaIngresoPosRepos";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Reposicionar";
      this.Load += new System.EventHandler(this.FormularioPopUp_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnAceptar;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.ComboBox ddlBodega;
    private System.Windows.Forms.ComboBox ddlRack;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    public System.Windows.Forms.ComboBox ddlPosicion;
  }
}
