namespace APP {
  partial class Posicion {
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
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbReporte = new System.Windows.Forms.ToolStripButton();
      this.dtgPrincipal = new ITD.Win.Grilla(this.components);
      this.colnombre_planta = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colnombre_clie = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colAlto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colAncho = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colProfundidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnLimpiarMasivo = new System.Windows.Forms.Button();
      this.btnAsignarMasivo = new System.Windows.Forms.Button();
      this.txtnombre_clie = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.txtFiltro = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.tlsPrincipal.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tlsPrincipal
      // 
      this.tlsPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.tlsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.toolStripSeparator1,
            this.tsbRefrescar,
            this.toolStripSeparator2,
            this.tsbReporte});
      this.tlsPrincipal.Location = new System.Drawing.Point(0, 0);
      this.tlsPrincipal.Name = "tlsPrincipal";
      this.tlsPrincipal.Size = new System.Drawing.Size(905, 27);
      this.tlsPrincipal.TabIndex = 6;
      // 
      // tsbGuardar
      // 
      this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbGuardar.Image = global::APP.Properties.Resources.grabar;
      this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbGuardar.Name = "tsbGuardar";
      this.tsbGuardar.Size = new System.Drawing.Size(24, 24);
      this.tsbGuardar.Text = "Guardar";
      this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
      // 
      // tsbRefrescar
      // 
      this.tsbRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbRefrescar.Image = global::APP.Properties.Resources.refrescar;
      this.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbRefrescar.Name = "tsbRefrescar";
      this.tsbRefrescar.Size = new System.Drawing.Size(24, 24);
      this.tsbRefrescar.Text = "Refrescar";
      this.tsbRefrescar.Click += new System.EventHandler(this.tsbRefrescar_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
      // 
      // tsbReporte
      // 
      this.tsbReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbReporte.Image = global::APP.Properties.Resources.Reporte;
      this.tsbReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbReporte.Name = "tsbReporte";
      this.tsbReporte.Size = new System.Drawing.Size(24, 24);
      this.tsbReporte.Text = "Reporte";
      this.tsbReporte.Click += new System.EventHandler(this.tsbReporte_Click);
      // 
      // dtgPrincipal
      // 
      this.dtgPrincipal.AllowUserToAddRows = false;
      this.dtgPrincipal.AllowUserToDeleteRows = false;
      this.dtgPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colnombre_planta,
            this.colNombre,
            this.colnombre_clie,
            this.colAlto,
            this.colAncho,
            this.colProfundidad,
            this.colEstado,
            this.ColActivo});
      this.dtgPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgPrincipal.IdCopia = 0;
      this.dtgPrincipal.Location = new System.Drawing.Point(0, 91);
      this.dtgPrincipal.Name = "dtgPrincipal";
      this.dtgPrincipal.OpcionCopiarVisible = false;
      this.dtgPrincipal.OpcionEditarMasivoVisible = true;
      this.dtgPrincipal.OpcionesActivas = 63;
      this.dtgPrincipal.OpcionesVisibles = 66;
      this.dtgPrincipal.OpcionInmovilizarVisible = false;
      this.dtgPrincipal.OpcionInsertarVisible = false;
      this.dtgPrincipal.OpcionOperacionVisible = false;
      this.dtgPrincipal.OpcionPegarVisible = false;
      this.dtgPrincipal.RefrescandoGrilla = false;
      this.dtgPrincipal.Size = new System.Drawing.Size(905, 215);
      this.dtgPrincipal.TabIndex = 5;
      this.dtgPrincipal.AntesInsertar += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgPrincipal_AntesInsertar);
      this.dtgPrincipal.DespuesModificarFila += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgPrincipal_DespuesModificarFila);
      this.dtgPrincipal.InformaCambios += new System.EventHandler<System.EventArgs>(this.dtgPrincipal_InformaCambios);
      this.dtgPrincipal.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_CellValueChanged);
      this.dtgPrincipal.CurrentCellDirtyStateChanged += new System.EventHandler(this.dtgPrincipal_CurrentCellDirtyStateChanged);
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
      // colNombre
      // 
      this.colNombre.DataPropertyName = "Nombre";
      this.colNombre.HeaderText = "Nombre";
      this.colNombre.MaxInputLength = 30;
      this.colNombre.Name = "colNombre";
      this.colNombre.Width = 150;
      // 
      // colnombre_clie
      // 
      this.colnombre_clie.DataPropertyName = "nombre_clie";
      this.colnombre_clie.HeaderText = "Cliente";
      this.colnombre_clie.MaxInputLength = 50;
      this.colnombre_clie.Name = "colnombre_clie";
      this.colnombre_clie.Width = 250;
      // 
      // colAlto
      // 
      this.colAlto.DataPropertyName = "Alto";
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle1.Format = "#,##0.##";
      this.colAlto.DefaultCellStyle = dataGridViewCellStyle1;
      this.colAlto.HeaderText = "Alto";
      this.colAlto.Name = "colAlto";
      this.colAlto.Width = 50;
      // 
      // colAncho
      // 
      this.colAncho.DataPropertyName = "Ancho";
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle2.Format = "#,##0.##";
      this.colAncho.DefaultCellStyle = dataGridViewCellStyle2;
      this.colAncho.HeaderText = "Ancho";
      this.colAncho.Name = "colAncho";
      this.colAncho.Width = 50;
      // 
      // colProfundidad
      // 
      this.colProfundidad.DataPropertyName = "Profundidad";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle3.Format = "#,##0.##";
      this.colProfundidad.DefaultCellStyle = dataGridViewCellStyle3;
      this.colProfundidad.HeaderText = "Profundidad";
      this.colProfundidad.Name = "colProfundidad";
      this.colProfundidad.Width = 90;
      // 
      // colEstado
      // 
      this.colEstado.DataPropertyName = "Estado";
      this.colEstado.HeaderText = "Estado";
      this.colEstado.MaxInputLength = 20;
      this.colEstado.Name = "colEstado";
      this.colEstado.ReadOnly = true;
      // 
      // ColActivo
      // 
      this.ColActivo.DataPropertyName = "Activo";
      this.ColActivo.HeaderText = "Activa";
      this.ColActivo.Name = "ColActivo";
      this.ColActivo.Width = 50;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnLimpiarMasivo);
      this.panel1.Controls.Add(this.btnAsignarMasivo);
      this.panel1.Controls.Add(this.txtnombre_clie);
      this.panel1.Controls.Add(this.label10);
      this.panel1.Controls.Add(this.txtFiltro);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 27);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(905, 64);
      this.panel1.TabIndex = 8;
      // 
      // btnLimpiarMasivo
      // 
      this.btnLimpiarMasivo.Location = new System.Drawing.Point(670, 34);
      this.btnLimpiarMasivo.Margin = new System.Windows.Forms.Padding(2);
      this.btnLimpiarMasivo.Name = "btnLimpiarMasivo";
      this.btnLimpiarMasivo.Size = new System.Drawing.Size(88, 21);
      this.btnLimpiarMasivo.TabIndex = 18;
      this.btnLimpiarMasivo.Text = "Limpiar masivo";
      this.btnLimpiarMasivo.UseVisualStyleBackColor = true;
      this.btnLimpiarMasivo.Click += new System.EventHandler(this.btnLimpiarMasivo_Click);
      // 
      // btnAsignarMasivo
      // 
      this.btnAsignarMasivo.Location = new System.Drawing.Point(571, 34);
      this.btnAsignarMasivo.Margin = new System.Windows.Forms.Padding(2);
      this.btnAsignarMasivo.Name = "btnAsignarMasivo";
      this.btnAsignarMasivo.Size = new System.Drawing.Size(88, 21);
      this.btnAsignarMasivo.TabIndex = 17;
      this.btnAsignarMasivo.Text = "Asignar masivo";
      this.btnAsignarMasivo.UseVisualStyleBackColor = true;
      this.btnAsignarMasivo.Click += new System.EventHandler(this.btnAsignarMasivo_Click);
      // 
      // txtnombre_clie
      // 
      this.txtnombre_clie.Location = new System.Drawing.Point(49, 36);
      this.txtnombre_clie.Name = "txtnombre_clie";
      this.txtnombre_clie.Size = new System.Drawing.Size(517, 20);
      this.txtnombre_clie.TabIndex = 15;
      this.txtnombre_clie.TextChanged += new System.EventHandler(this.txtnombre_clie_TextChanged);
      this.txtnombre_clie.Validated += new System.EventHandler(this.txtnombre_clie_Validated);
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(10, 38);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(39, 13);
      this.label10.TabIndex = 16;
      this.label10.Text = "Cliente";
      // 
      // txtFiltro
      // 
      this.txtFiltro.Location = new System.Drawing.Point(49, 9);
      this.txtFiltro.Name = "txtFiltro";
      this.txtFiltro.Size = new System.Drawing.Size(517, 20);
      this.txtFiltro.TabIndex = 1;
      this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(10, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(29, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Filtro";
      // 
      // Posicion
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.ClientSize = new System.Drawing.Size(905, 328);
      this.Controls.Add(this.dtgPrincipal);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.tlsPrincipal);
      this.EnterComoTab = true;
      this.KeyPreview = true;
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "Posicion";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Posiciones";
      this.Load += new System.EventHandler(this.GrillaAct_Load);
      this.Controls.SetChildIndex(this.tlsPrincipal, 0);
      this.Controls.SetChildIndex(this.panel1, 0);
      this.Controls.SetChildIndex(this.dtgPrincipal, 0);
      this.tlsPrincipal.ResumeLayout(false);
      this.tlsPrincipal.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private ITD.Win.Grilla dtgPrincipal;
    private System.Windows.Forms.ToolStrip tlsPrincipal;
    private System.Windows.Forms.ToolStripButton tsbGuardar;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton tsbRefrescar;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox txtFiltro;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_planta;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_clie;
    private System.Windows.Forms.DataGridViewTextBoxColumn colAlto;
    private System.Windows.Forms.DataGridViewTextBoxColumn colAncho;
    private System.Windows.Forms.DataGridViewTextBoxColumn colProfundidad;
    private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    private System.Windows.Forms.DataGridViewCheckBoxColumn ColActivo;
    private System.Windows.Forms.TextBox txtnombre_clie;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Button btnAsignarMasivo;
    private System.Windows.Forms.Button btnLimpiarMasivo;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton tsbReporte;
  }
}
