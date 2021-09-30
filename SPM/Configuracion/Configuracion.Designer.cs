namespace APP {
  partial class Configuracion {
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
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.nudTiempoDashboard = new System.Windows.Forms.NumericUpDown();
      this.nudDiasLlegadaProducto = new System.Windows.Forms.NumericUpDown();
      this.nudDiasOSAEmpezar = new System.Windows.Forms.NumericUpDown();
      this.nudDiasOSATerminar = new System.Windows.Forms.NumericUpDown();
      this.nudDiasOSSinCerrar = new System.Windows.Forms.NumericUpDown();
      this.nudMinPickingProceso = new System.Windows.Forms.NumericUpDown();
      this.btnColorSoloLectura = new System.Windows.Forms.Button();
      this.label8 = new System.Windows.Forms.Label();
      this.nudValorCaja = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.nudTiempoDashboard)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudDiasLlegadaProducto)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudDiasOSAEmpezar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudDiasOSATerminar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudDiasOSSinCerrar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMinPickingProceso)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudValorCaja)).BeginInit();
      this.SuspendLayout();
      // 
      // btnAceptar
      // 
      this.btnAceptar.Location = new System.Drawing.Point(27, 218);
      this.btnAceptar.Name = "btnAceptar";
      this.btnAceptar.Size = new System.Drawing.Size(75, 24);
      this.btnAceptar.TabIndex = 8;
      this.btnAceptar.Text = "Aceptar";
      this.btnAceptar.UseVisualStyleBackColor = true;
      this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
      // 
      // btnCancelar
      // 
      this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancelar.Location = new System.Drawing.Point(174, 218);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(75, 24);
      this.btnCancelar.TabIndex = 9;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 15);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(99, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Minutos Dashboard";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(9, 37);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(132, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Días llegada de productos";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(9, 59);
      this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(100, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Días OS a empezar";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(9, 81);
      this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(145, 13);
      this.label4.TabIndex = 5;
      this.label4.Text = "% De aviso de termino de OC";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(9, 103);
      this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(94, 13);
      this.label5.TabIndex = 6;
      this.label5.Text = "Días OS sin cerrar";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(9, 125);
      this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(137, 13);
      this.label6.TabIndex = 7;
      this.label6.Text = "Minutos picking en proceso";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(9, 173);
      this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(122, 13);
      this.label7.TabIndex = 8;
      this.label7.Text = "Color celdas solo lectura";
      // 
      // nudTiempoDashboard
      // 
      this.nudTiempoDashboard.Location = new System.Drawing.Point(169, 11);
      this.nudTiempoDashboard.Margin = new System.Windows.Forms.Padding(2);
      this.nudTiempoDashboard.Name = "nudTiempoDashboard";
      this.nudTiempoDashboard.Size = new System.Drawing.Size(90, 20);
      this.nudTiempoDashboard.TabIndex = 0;
      this.nudTiempoDashboard.Enter += new System.EventHandler(this.Control_Enter);
      // 
      // nudDiasLlegadaProducto
      // 
      this.nudDiasLlegadaProducto.Location = new System.Drawing.Point(169, 33);
      this.nudDiasLlegadaProducto.Margin = new System.Windows.Forms.Padding(2);
      this.nudDiasLlegadaProducto.Name = "nudDiasLlegadaProducto";
      this.nudDiasLlegadaProducto.Size = new System.Drawing.Size(90, 20);
      this.nudDiasLlegadaProducto.TabIndex = 1;
      this.nudDiasLlegadaProducto.Enter += new System.EventHandler(this.Control_Enter);
      // 
      // nudDiasOSAEmpezar
      // 
      this.nudDiasOSAEmpezar.Location = new System.Drawing.Point(169, 55);
      this.nudDiasOSAEmpezar.Margin = new System.Windows.Forms.Padding(2);
      this.nudDiasOSAEmpezar.Name = "nudDiasOSAEmpezar";
      this.nudDiasOSAEmpezar.Size = new System.Drawing.Size(90, 20);
      this.nudDiasOSAEmpezar.TabIndex = 2;
      this.nudDiasOSAEmpezar.Enter += new System.EventHandler(this.Control_Enter);
      // 
      // nudDiasOSATerminar
      // 
      this.nudDiasOSATerminar.DecimalPlaces = 2;
      this.nudDiasOSATerminar.Location = new System.Drawing.Point(169, 77);
      this.nudDiasOSATerminar.Margin = new System.Windows.Forms.Padding(2);
      this.nudDiasOSATerminar.Name = "nudDiasOSATerminar";
      this.nudDiasOSATerminar.Size = new System.Drawing.Size(90, 20);
      this.nudDiasOSATerminar.TabIndex = 3;
      this.nudDiasOSATerminar.Enter += new System.EventHandler(this.Control_Enter);
      // 
      // nudDiasOSSinCerrar
      // 
      this.nudDiasOSSinCerrar.Location = new System.Drawing.Point(169, 99);
      this.nudDiasOSSinCerrar.Margin = new System.Windows.Forms.Padding(2);
      this.nudDiasOSSinCerrar.Name = "nudDiasOSSinCerrar";
      this.nudDiasOSSinCerrar.Size = new System.Drawing.Size(90, 20);
      this.nudDiasOSSinCerrar.TabIndex = 4;
      this.nudDiasOSSinCerrar.Enter += new System.EventHandler(this.Control_Enter);
      // 
      // nudMinPickingProceso
      // 
      this.nudMinPickingProceso.Location = new System.Drawing.Point(169, 121);
      this.nudMinPickingProceso.Margin = new System.Windows.Forms.Padding(2);
      this.nudMinPickingProceso.Name = "nudMinPickingProceso";
      this.nudMinPickingProceso.Size = new System.Drawing.Size(90, 20);
      this.nudMinPickingProceso.TabIndex = 5;
      this.nudMinPickingProceso.Enter += new System.EventHandler(this.Control_Enter);
      // 
      // btnColorSoloLectura
      // 
      this.btnColorSoloLectura.Location = new System.Drawing.Point(169, 165);
      this.btnColorSoloLectura.Margin = new System.Windows.Forms.Padding(2);
      this.btnColorSoloLectura.Name = "btnColorSoloLectura";
      this.btnColorSoloLectura.Size = new System.Drawing.Size(56, 28);
      this.btnColorSoloLectura.TabIndex = 7;
      this.btnColorSoloLectura.UseVisualStyleBackColor = true;
      this.btnColorSoloLectura.Click += new System.EventHandler(this.btnColorSoloLectura_Click);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(9, 147);
      this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(80, 13);
      this.label8.TabIndex = 7;
      this.label8.Text = "Valor de la caja";
      this.tttPrincipal.SetToolTip(this.label8, "Valor de la caja para san bernardo para calcular el costo de etiquetas");
      // 
      // nudValorCaja
      // 
      this.nudValorCaja.DecimalPlaces = 3;
      this.nudValorCaja.Location = new System.Drawing.Point(169, 143);
      this.nudValorCaja.Margin = new System.Windows.Forms.Padding(2);
      this.nudValorCaja.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
      this.nudValorCaja.Name = "nudValorCaja";
      this.nudValorCaja.Size = new System.Drawing.Size(90, 20);
      this.nudValorCaja.TabIndex = 6;
      this.nudValorCaja.Enter += new System.EventHandler(this.Control_Enter);
      // 
      // Configuracion
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.CancelButton = this.btnCancelar;
      this.ClientSize = new System.Drawing.Size(274, 274);
      this.Controls.Add(this.btnColorSoloLectura);
      this.Controls.Add(this.nudValorCaja);
      this.Controls.Add(this.nudMinPickingProceso);
      this.Controls.Add(this.nudDiasOSSinCerrar);
      this.Controls.Add(this.nudDiasOSATerminar);
      this.Controls.Add(this.nudDiasOSAEmpezar);
      this.Controls.Add(this.nudDiasLlegadaProducto);
      this.Controls.Add(this.nudTiempoDashboard);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.btnAceptar);
      this.EnterComoTab = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.GuardaPersistencia = false;
      this.KeyPreview = true;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Configuracion";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Configuración";
      this.Load += new System.EventHandler(this.FormularioPopUp_Load);
      ((System.ComponentModel.ISupportInitialize)(this.nudTiempoDashboard)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudDiasLlegadaProducto)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudDiasOSAEmpezar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudDiasOSATerminar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudDiasOSSinCerrar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMinPickingProceso)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudValorCaja)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnAceptar;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.NumericUpDown nudTiempoDashboard;
    private System.Windows.Forms.NumericUpDown nudDiasLlegadaProducto;
    private System.Windows.Forms.NumericUpDown nudDiasOSAEmpezar;
    private System.Windows.Forms.NumericUpDown nudDiasOSATerminar;
    private System.Windows.Forms.NumericUpDown nudDiasOSSinCerrar;
    private System.Windows.Forms.NumericUpDown nudMinPickingProceso;
    private System.Windows.Forms.Button btnColorSoloLectura;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.NumericUpDown nudValorCaja;
  }
}
