namespace APP {
  partial class Linea {
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
      this.tlsPrincipal = new System.Windows.Forms.ToolStrip();
      this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
      this.dtgPrincipal = new ITD.Win.Grilla(this.components);
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.ddlPlanta = new System.Windows.Forms.ComboBox();
      this.colnombre_planta = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colnombre_linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colactivo_linea = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.colOrdenLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colnombre_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colSupervisora = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tlsPrincipal.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
      this.panel1.SuspendLayout();
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
      this.tlsPrincipal.Size = new System.Drawing.Size(668, 25);
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
      this.dtgPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colnombre_planta,
            this.colnombre_linea,
            this.colactivo_linea,
            this.colOrdenLinea,
            this.colnombre_empleado,
            this.colSupervisora});
      this.dtgPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgPrincipal.IdCopia = 0;
      this.dtgPrincipal.Location = new System.Drawing.Point(0, 81);
      this.dtgPrincipal.Name = "dtgPrincipal";
      this.dtgPrincipal.OpcionEliminarVisible = false;
      this.dtgPrincipal.OpcionesActivas = 63;
      this.dtgPrincipal.OpcionesVisibles = 12;
      this.dtgPrincipal.OpcionInmovilizarVisible = false;
      this.dtgPrincipal.OpcionInsertarVisible = false;
      this.dtgPrincipal.OpcionOperacionVisible = false;
      this.dtgPrincipal.RefrescandoGrilla = false;
      this.dtgPrincipal.Size = new System.Drawing.Size(668, 225);
      this.dtgPrincipal.TabIndex = 5;
      this.dtgPrincipal.AntesInsertar += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgPrincipal_AntesInsertar);
      this.dtgPrincipal.DespuesModificarFila += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgPrincipal_DespuesModificarFila);
      this.dtgPrincipal.InformaCambios += new System.EventHandler<System.EventArgs>(this.dtgPrincipal_InformaCambios);
      this.dtgPrincipal.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_CellValueChanged);
      this.dtgPrincipal.CurrentCellDirtyStateChanged += new System.EventHandler(this.dtgPrincipal_CurrentCellDirtyStateChanged);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.ddlPlanta);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 25);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(668, 56);
      this.panel1.TabIndex = 7;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(75, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(37, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "Planta";
      // 
      // ddlPlanta
      // 
      this.ddlPlanta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.ddlPlanta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ddlPlanta.DisplayMember = "Planta";
      this.ddlPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlPlanta.FormattingEnabled = true;
      this.ddlPlanta.Location = new System.Drawing.Point(131, 13);
      this.ddlPlanta.Name = "ddlPlanta";
      this.ddlPlanta.Size = new System.Drawing.Size(226, 21);
      this.ddlPlanta.TabIndex = 5;
      this.ddlPlanta.ValueMember = "Id";
      this.ddlPlanta.SelectedIndexChanged += new System.EventHandler(this.ddlPlanta_SelectedIndexChanged);
      // 
      // colnombre_planta
      // 
      this.colnombre_planta.DataPropertyName = "nombre_planta";
      this.colnombre_planta.HeaderText = "Planta";
      this.colnombre_planta.MaxInputLength = 20;
      this.colnombre_planta.Name = "colnombre_planta";
      this.colnombre_planta.ReadOnly = true;
      this.colnombre_planta.Width = 80;
      // 
      // colnombre_linea
      // 
      this.colnombre_linea.DataPropertyName = "nombre_linea";
      this.colnombre_linea.HeaderText = "Línea";
      this.colnombre_linea.MaxInputLength = 20;
      this.colnombre_linea.Name = "colnombre_linea";
      this.colnombre_linea.ReadOnly = true;
      this.colnombre_linea.Width = 70;
      // 
      // colactivo_linea
      // 
      this.colactivo_linea.DataPropertyName = "activo_linea";
      this.colactivo_linea.HeaderText = "Activo";
      this.colactivo_linea.Name = "colactivo_linea";
      this.colactivo_linea.Width = 50;
      // 
      // colOrdenLinea
      // 
      this.colOrdenLinea.DataPropertyName = "OrdenLinea";
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle1.Format = "#,##0.##";
      this.colOrdenLinea.DefaultCellStyle = dataGridViewCellStyle1;
      this.colOrdenLinea.HeaderText = "Orden";
      this.colOrdenLinea.Name = "colOrdenLinea";
      this.colOrdenLinea.Width = 60;
      // 
      // colnombre_empleado
      // 
      this.colnombre_empleado.DataPropertyName = "nombre_empleado";
      this.colnombre_empleado.HeaderText = "Encargada";
      this.colnombre_empleado.MaxInputLength = 80;
      this.colnombre_empleado.Name = "colnombre_empleado";
      this.colnombre_empleado.Width = 150;
      // 
      // colSupervisora
      // 
      this.colSupervisora.DataPropertyName = "Supervisora";
      this.colSupervisora.HeaderText = "Supervisora";
      this.colSupervisora.MaxInputLength = 80;
      this.colSupervisora.Name = "colSupervisora";
      this.colSupervisora.Width = 150;
      // 
      // Linea
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.ClientSize = new System.Drawing.Size(668, 328);
      this.Controls.Add(this.dtgPrincipal);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.tlsPrincipal);
      this.EnterComoTab = true;
      this.KeyPreview = true;
      this.Name = "Linea";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Líneas";
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
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox ddlPlanta;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_planta;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_linea;
    private System.Windows.Forms.DataGridViewCheckBoxColumn colactivo_linea;
    private System.Windows.Forms.DataGridViewTextBoxColumn colOrdenLinea;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_empleado;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSupervisora;
  }
}
