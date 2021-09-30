namespace APP {
  partial class CorreoSistema {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CorreoSistema));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.tlsPrincipal = new System.Windows.Forms.ToolStrip();
      this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbFiltrar = new System.Windows.Forms.ToolStripButton();
      this.tsbQuitarFiltro = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbMostrarFiltros = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.ddlReporte = new System.Windows.Forms.ToolStripComboBox();
      this.tsbReporte = new System.Windows.Forms.ToolStripButton();
      this.dtgPrincipal = new ITD.Win.Grilla(this.components);
      this.spcPrincipal = new System.Windows.Forms.SplitContainer();
      this.pnlPrincipal = new System.Windows.Forms.Panel();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tbpDatos = new System.Windows.Forms.TabPage();
      this.txtTexto = new System.Windows.Forms.TextBox();
      this.txtAsunto = new System.Windows.Forms.TextBox();
      this.txtNombre = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.tbpUsuarios = new System.Windows.Forms.TabPage();
      this.dtgDetalles = new ITD.Win.Grilla(this.components);
      this.colnombre_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colCopia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.colOculto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tlsPrincipal.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.spcPrincipal)).BeginInit();
      this.spcPrincipal.Panel1.SuspendLayout();
      this.spcPrincipal.Panel2.SuspendLayout();
      this.spcPrincipal.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tbpDatos.SuspendLayout();
      this.tbpUsuarios.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgDetalles)).BeginInit();
      this.SuspendLayout();
      // 
      // tlsPrincipal
      // 
      this.tlsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.toolStripSeparator5,
            this.tsbFiltrar,
            this.tsbQuitarFiltro,
            this.toolStripSeparator2,
            this.tsbMostrarFiltros,
            this.toolStripSeparator1,
            this.ddlReporte,
            this.tsbReporte});
      this.tlsPrincipal.Location = new System.Drawing.Point(0, 0);
      this.tlsPrincipal.Name = "tlsPrincipal";
      this.tlsPrincipal.Size = new System.Drawing.Size(717, 25);
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
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
      // 
      // tsbFiltrar
      // 
      this.tsbFiltrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbFiltrar.Image")));
      this.tsbFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbFiltrar.Name = "tsbFiltrar";
      this.tsbFiltrar.Size = new System.Drawing.Size(23, 22);
      this.tsbFiltrar.Text = "Filtrar";
      this.tsbFiltrar.Click += new System.EventHandler(this.tsbFiltrar_Click);
      // 
      // tsbQuitarFiltro
      // 
      this.tsbQuitarFiltro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbQuitarFiltro.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuitarFiltro.Image")));
      this.tsbQuitarFiltro.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbQuitarFiltro.Name = "tsbQuitarFiltro";
      this.tsbQuitarFiltro.Size = new System.Drawing.Size(23, 22);
      this.tsbQuitarFiltro.Text = "Quitar filtro";
      this.tsbQuitarFiltro.Click += new System.EventHandler(this.tsbQuitarFiltro_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // tsbMostrarFiltros
      // 
      this.tsbMostrarFiltros.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbMostrarFiltros.Image = ((System.Drawing.Image)(resources.GetObject("tsbMostrarFiltros.Image")));
      this.tsbMostrarFiltros.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbMostrarFiltros.Name = "tsbMostrarFiltros";
      this.tsbMostrarFiltros.Size = new System.Drawing.Size(23, 22);
      this.tsbMostrarFiltros.Text = "Ocultar filtros";
      this.tsbMostrarFiltros.Click += new System.EventHandler(this.tsbMostrarFiltros_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // ddlReporte
      // 
      this.ddlReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ddlReporte.Name = "ddlReporte";
      this.ddlReporte.Size = new System.Drawing.Size(170, 25);
      // 
      // tsbReporte
      // 
      this.tsbReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbReporte.Image = global::APP.Properties.Resources.Reporte;
      this.tsbReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbReporte.Name = "tsbReporte";
      this.tsbReporte.Size = new System.Drawing.Size(23, 22);
      this.tsbReporte.Text = "Reporte";
      this.tsbReporte.Click += new System.EventHandler(this.tsbReporte_Click);
      // 
      // dtgPrincipal
      // 
      this.dtgPrincipal.AllowUserToAddRows = false;
      this.dtgPrincipal.AllowUserToDeleteRows = false;
      this.dtgPrincipal.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dtgPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.dtgPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDescripcion});
      this.dtgPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgPrincipal.IdCopia = 0;
      this.dtgPrincipal.Location = new System.Drawing.Point(0, 109);
      this.dtgPrincipal.Name = "dtgPrincipal";
      this.dtgPrincipal.OpcionCopiarVisible = false;
      this.dtgPrincipal.OpcionEliminarVisible = false;
      this.dtgPrincipal.OpcionesActivas = 63;
      this.dtgPrincipal.OpcionesVisibles = 0;
      this.dtgPrincipal.OpcionInmovilizarVisible = false;
      this.dtgPrincipal.OpcionInsertarVisible = false;
      this.dtgPrincipal.OpcionOperacionVisible = false;
      this.dtgPrincipal.OpcionPegarVisible = false;
      this.dtgPrincipal.ReadOnly = true;
      this.dtgPrincipal.RefrescandoGrilla = false;
      this.dtgPrincipal.Size = new System.Drawing.Size(275, 330);
      this.dtgPrincipal.TabIndex = 67;
      this.dtgPrincipal.AntesCambioFila += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgPrincipal_AntesCambioFila);
      this.dtgPrincipal.DespuesCambioFila += new System.EventHandler<ITD.Win.FilaGrillaEventArg>(this.dtgPrincipal_DespuesCambioFila);
      // 
      // spcPrincipal
      // 
      this.spcPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.spcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.spcPrincipal.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.spcPrincipal.Location = new System.Drawing.Point(0, 25);
      this.spcPrincipal.Name = "spcPrincipal";
      // 
      // spcPrincipal.Panel1
      // 
      this.spcPrincipal.Panel1.Controls.Add(this.dtgPrincipal);
      this.spcPrincipal.Panel1.Controls.Add(this.pnlPrincipal);
      // 
      // spcPrincipal.Panel2
      // 
      this.spcPrincipal.Panel2.Controls.Add(this.tabControl1);
      this.spcPrincipal.Size = new System.Drawing.Size(717, 443);
      this.spcPrincipal.SplitterDistance = 279;
      this.spcPrincipal.TabIndex = 69;
      // 
      // pnlPrincipal
      // 
      this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
      this.pnlPrincipal.Name = "pnlPrincipal";
      this.pnlPrincipal.Size = new System.Drawing.Size(275, 109);
      this.pnlPrincipal.TabIndex = 6;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tbpDatos);
      this.tabControl1.Controls.Add(this.tbpUsuarios);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(430, 439);
      this.tabControl1.TabIndex = 71;
      // 
      // tbpDatos
      // 
      this.tbpDatos.Controls.Add(this.txtTexto);
      this.tbpDatos.Controls.Add(this.txtAsunto);
      this.tbpDatos.Controls.Add(this.txtNombre);
      this.tbpDatos.Controls.Add(this.label4);
      this.tbpDatos.Controls.Add(this.label2);
      this.tbpDatos.Controls.Add(this.label1);
      this.tbpDatos.Location = new System.Drawing.Point(4, 22);
      this.tbpDatos.Name = "tbpDatos";
      this.tbpDatos.Padding = new System.Windows.Forms.Padding(3);
      this.tbpDatos.Size = new System.Drawing.Size(422, 413);
      this.tbpDatos.TabIndex = 0;
      this.tbpDatos.Text = "Información";
      this.tbpDatos.UseVisualStyleBackColor = true;
      // 
      // txtTexto
      // 
      this.txtTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtTexto.Location = new System.Drawing.Point(72, 87);
      this.txtTexto.Multiline = true;
      this.txtTexto.Name = "txtTexto";
      this.txtTexto.Size = new System.Drawing.Size(336, 309);
      this.txtTexto.TabIndex = 3;
      // 
      // txtAsunto
      // 
      this.txtAsunto.Location = new System.Drawing.Point(72, 51);
      this.txtAsunto.Name = "txtAsunto";
      this.txtAsunto.Size = new System.Drawing.Size(336, 20);
      this.txtAsunto.TabIndex = 3;
      // 
      // txtNombre
      // 
      this.txtNombre.Location = new System.Drawing.Point(72, 11);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new System.Drawing.Size(336, 20);
      this.txtNombre.TabIndex = 3;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(19, 130);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(34, 13);
      this.label4.TabIndex = 2;
      this.label4.Text = "Texto";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(19, 61);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(40, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Asunto";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(19, 14);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nombre";
      // 
      // tbpUsuarios
      // 
      this.tbpUsuarios.Controls.Add(this.dtgDetalles);
      this.tbpUsuarios.Location = new System.Drawing.Point(4, 22);
      this.tbpUsuarios.Name = "tbpUsuarios";
      this.tbpUsuarios.Padding = new System.Windows.Forms.Padding(3);
      this.tbpUsuarios.Size = new System.Drawing.Size(422, 413);
      this.tbpUsuarios.TabIndex = 1;
      this.tbpUsuarios.Text = "Usuarios";
      this.tbpUsuarios.UseVisualStyleBackColor = true;
      // 
      // dtgDetalles
      // 
      this.dtgDetalles.AllowUserToAddRows = false;
      this.dtgDetalles.AllowUserToDeleteRows = false;
      this.dtgDetalles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dtgDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dtgDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colnombre_empleado,
            this.colCopia,
            this.colOculto});
      this.dtgDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgDetalles.IdCopia = 0;
      this.dtgDetalles.Location = new System.Drawing.Point(3, 3);
      this.dtgDetalles.Name = "dtgDetalles";
      this.dtgDetalles.OpcionEditarMasivoVisible = true;
      this.dtgDetalles.OpcionesActivas = 63;
      this.dtgDetalles.OpcionesVisibles = 127;
      this.dtgDetalles.RefrescandoGrilla = false;
      this.dtgDetalles.Size = new System.Drawing.Size(416, 407);
      this.dtgDetalles.TabIndex = 70;
      this.dtgDetalles.CambiaOperacionRapida += new System.EventHandler<ITD.Win.CambiaOperacionRapidaEvengArg>(this.dtgDetalles_CambiaOperacionRapida);
      this.dtgDetalles.AntesInsertar += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgDetalles_AntesInsertar);
      this.dtgDetalles.DespuesModificarFila += new System.EventHandler<ITD.Win.FilaEventArg>(this.dtgDetalles_DespuesModificarFila);
      this.dtgDetalles.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDetalles_CellValueChanged);
      this.dtgDetalles.CurrentCellDirtyStateChanged += new System.EventHandler(this.dtgDetalles_CurrentCellDirtyStateChanged);
      this.dtgDetalles.Enter += new System.EventHandler(this.dtgDetalles_Enter);
      // 
      // colnombre_empleado
      // 
      this.colnombre_empleado.DataPropertyName = "nombre_empleado";
      this.colnombre_empleado.HeaderText = "Usuario";
      this.colnombre_empleado.MaxInputLength = 80;
      this.colnombre_empleado.Name = "colnombre_empleado";
      this.colnombre_empleado.Width = 200;
      // 
      // colCopia
      // 
      this.colCopia.DataPropertyName = "Copia";
      this.colCopia.HeaderText = "Copia";
      this.colCopia.Name = "colCopia";
      this.colCopia.Width = 50;
      // 
      // colOculto
      // 
      this.colOculto.DataPropertyName = "Oculto";
      this.colOculto.HeaderText = "Oculto";
      this.colOculto.Name = "colOculto";
      this.colOculto.Width = 50;
      // 
      // ColDescripcion
      // 
      this.ColDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.ColDescripcion.DataPropertyName = "Descripcion";
      this.ColDescripcion.HeaderText = "Nombre";
      this.ColDescripcion.Name = "ColDescripcion";
      this.ColDescripcion.ReadOnly = true;
      // 
      // CorreoSistema
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(717, 490);
      this.Controls.Add(this.spcPrincipal);
      this.Controls.Add(this.tlsPrincipal);
      this.EnterComoTab = true;
      this.KeyPreview = true;
      this.Name = "CorreoSistema";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Correos de sistema";
      this.Load += new System.EventHandler(this.ConsultaActConDet_Load);
      this.Controls.SetChildIndex(this.tlsPrincipal, 0);
      this.Controls.SetChildIndex(this.spcPrincipal, 0);
      this.tlsPrincipal.ResumeLayout(false);
      this.tlsPrincipal.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).EndInit();
      this.spcPrincipal.Panel1.ResumeLayout(false);
      this.spcPrincipal.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.spcPrincipal)).EndInit();
      this.spcPrincipal.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tbpDatos.ResumeLayout(false);
      this.tbpDatos.PerformLayout();
      this.tbpUsuarios.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dtgDetalles)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip tlsPrincipal;
    private System.Windows.Forms.ToolStripButton tsbGuardar;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripComboBox ddlReporte;
    private System.Windows.Forms.ToolStripButton tsbReporte;
    private ITD.Win.Grilla dtgPrincipal;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.SplitContainer spcPrincipal;
    private System.Windows.Forms.Panel pnlPrincipal;
    private System.Windows.Forms.ToolStripButton tsbFiltrar;
    private System.Windows.Forms.ToolStripButton tsbQuitarFiltro;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton tsbMostrarFiltros;
    private ITD.Win.Grilla dtgDetalles;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tbpDatos;
    private System.Windows.Forms.TabPage tbpUsuarios;
    private System.Windows.Forms.TextBox txtTexto;
    private System.Windows.Forms.TextBox txtAsunto;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridViewTextBoxColumn colnombre_empleado;
    private System.Windows.Forms.DataGridViewCheckBoxColumn colCopia;
    private System.Windows.Forms.DataGridViewCheckBoxColumn colOculto;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
  }
}