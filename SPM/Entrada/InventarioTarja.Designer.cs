namespace APP {
  partial class InventarioTarja {
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
      this.ddlPlanta = new System.Windows.Forms.ComboBox();
      this.label21 = new System.Windows.Forms.Label();
      this.txtnombre_clie = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.txtOC = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.ddlIdTipo = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtCodigo = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtDescripcion = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtLote = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.dtpVence = new System.Windows.Forms.DateTimePicker();
      this.label6 = new System.Windows.Forms.Label();
      this.nudCantidad = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
      this.SuspendLayout();
      // 
      // btnAceptar
      // 
      this.btnAceptar.Location = new System.Drawing.Point(95, 247);
      this.btnAceptar.Name = "btnAceptar";
      this.btnAceptar.Size = new System.Drawing.Size(75, 23);
      this.btnAceptar.TabIndex = 9;
      this.btnAceptar.Text = "Aceptar";
      this.btnAceptar.UseVisualStyleBackColor = true;
      this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
      // 
      // btnCancelar
      // 
      this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancelar.Location = new System.Drawing.Point(242, 247);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(75, 23);
      this.btnCancelar.TabIndex = 10;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      // 
      // ddlPlanta
      // 
      this.ddlPlanta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlPlanta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlPlanta.DisplayMember = "Planta";
      this.ddlPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlPlanta.Enabled = false;
      this.ddlPlanta.FormattingEnabled = true;
      this.ddlPlanta.Location = new System.Drawing.Point(78, 12);
      this.ddlPlanta.Name = "ddlPlanta";
      this.ddlPlanta.Size = new System.Drawing.Size(239, 21);
      this.ddlPlanta.TabIndex = 0;
      this.ddlPlanta.ValueMember = "Id";
      // 
      // label21
      // 
      this.label21.AutoSize = true;
      this.label21.Location = new System.Drawing.Point(16, 16);
      this.label21.Name = "label21";
      this.label21.Size = new System.Drawing.Size(37, 13);
      this.label21.TabIndex = 30;
      this.label21.Text = "Planta";
      // 
      // txtnombre_clie
      // 
      this.txtnombre_clie.Location = new System.Drawing.Point(78, 39);
      this.txtnombre_clie.Name = "txtnombre_clie";
      this.txtnombre_clie.ReadOnly = true;
      this.txtnombre_clie.Size = new System.Drawing.Size(347, 20);
      this.txtnombre_clie.TabIndex = 1;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(16, 43);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(39, 13);
      this.label10.TabIndex = 33;
      this.label10.Text = "Cliente";
      // 
      // txtOC
      // 
      this.txtOC.Location = new System.Drawing.Point(78, 144);
      this.txtOC.Name = "txtOC";
      this.txtOC.Size = new System.Drawing.Size(120, 20);
      this.txtOC.TabIndex = 5;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(16, 148);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(22, 13);
      this.label8.TabIndex = 35;
      this.label8.Text = "OC";
      // 
      // ddlIdTipo
      // 
      this.ddlIdTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlIdTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlIdTipo.DisplayMember = "Nombre";
      this.ddlIdTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlIdTipo.FormattingEnabled = true;
      this.ddlIdTipo.Location = new System.Drawing.Point(78, 65);
      this.ddlIdTipo.Name = "ddlIdTipo";
      this.ddlIdTipo.Size = new System.Drawing.Size(239, 21);
      this.ddlIdTipo.TabIndex = 2;
      this.ddlIdTipo.ValueMember = "Id";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(16, 69);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(28, 13);
      this.label1.TabIndex = 37;
      this.label1.Text = "Tipo";
      // 
      // txtCodigo
      // 
      this.txtCodigo.Location = new System.Drawing.Point(78, 92);
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.Size = new System.Drawing.Size(120, 20);
      this.txtCodigo.TabIndex = 3;
      this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
      this.txtCodigo.Validated += new System.EventHandler(this.txtCodigo_Validated);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(16, 96);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(40, 13);
      this.label2.TabIndex = 39;
      this.label2.Text = "Código";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(16, 122);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(63, 13);
      this.label3.TabIndex = 33;
      this.label3.Text = "Descripción";
      // 
      // txtDescripcion
      // 
      this.txtDescripcion.Location = new System.Drawing.Point(78, 118);
      this.txtDescripcion.Name = "txtDescripcion";
      this.txtDescripcion.ReadOnly = true;
      this.txtDescripcion.Size = new System.Drawing.Size(347, 20);
      this.txtDescripcion.TabIndex = 4;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(16, 174);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(28, 13);
      this.label4.TabIndex = 35;
      this.label4.Text = "Lote";
      // 
      // txtLote
      // 
      this.txtLote.Location = new System.Drawing.Point(78, 170);
      this.txtLote.Name = "txtLote";
      this.txtLote.Size = new System.Drawing.Size(120, 20);
      this.txtLote.TabIndex = 6;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(212, 174);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(38, 13);
      this.label5.TabIndex = 35;
      this.label5.Text = "Vence";
      // 
      // dtpVence
      // 
      this.dtpVence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpVence.Location = new System.Drawing.Point(256, 170);
      this.dtpVence.Name = "dtpVence";
      this.dtpVence.ShowCheckBox = true;
      this.dtpVence.Size = new System.Drawing.Size(113, 20);
      this.dtpVence.TabIndex = 7;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(16, 200);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(49, 13);
      this.label6.TabIndex = 41;
      this.label6.Text = "Cantidad";
      // 
      // nudCantidad
      // 
      this.nudCantidad.Location = new System.Drawing.Point(78, 196);
      this.nudCantidad.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
      this.nudCantidad.Name = "nudCantidad";
      this.nudCantidad.Size = new System.Drawing.Size(120, 20);
      this.nudCantidad.TabIndex = 8;
      // 
      // InventarioTarja
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.CancelButton = this.btnCancelar;
      this.ClientSize = new System.Drawing.Size(434, 282);
      this.Controls.Add(this.nudCantidad);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.dtpVence);
      this.Controls.Add(this.txtCodigo);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.ddlIdTipo);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtLote);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtOC);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.txtDescripcion);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtnombre_clie);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.ddlPlanta);
      this.Controls.Add(this.label21);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.btnAceptar);
      this.EnterComoTab = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.GuardaPersistencia = false;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "InventarioTarja";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Inventario Nueva Tarja";
      this.Load += new System.EventHandler(this.FormularioPopUp_Load);
      ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnAceptar;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.ComboBox ddlPlanta;
    private System.Windows.Forms.Label label21;
    private System.Windows.Forms.TextBox txtnombre_clie;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox txtOC;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.ComboBox ddlIdTipo;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtCodigo;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtDescripcion;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtLote;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.DateTimePicker dtpVence;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.NumericUpDown nudCantidad;
  }
}
