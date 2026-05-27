namespace GolAhora.Forms.UserControls;

partial class ucCanchas
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCanchas));
        cbFiltrado = new ComboBox();
        tcCanchas = new TabControl();
        tabCanchas = new TabPage();
        scCanchas = new SplitContainer();
        listBoxCanchas = new ListBox();
        lateralMenuTorneos = new ToolStrip();
        toolStripSeparator7 = new ToolStripSeparator();
        btnRegistrarCancha = new ToolStripButton();
        toolStripSeparator8 = new ToolStripSeparator();
        btnConsultarCancha = new ToolStripButton();
        toolStripSeparator9 = new ToolStripSeparator();
        btnModificarCancha = new ToolStripButton();
        toolStripSeparator10 = new ToolStripSeparator();
        btnBloquearCancha = new ToolStripButton();
        toolStripSeparator11 = new ToolStripSeparator();
        btnBajaCancha = new ToolStripButton();
        toolStripSeparator12 = new ToolStripSeparator();
        tabTiposCancha = new TabPage();
        scTipos = new SplitContainer();
        listBoxTiposCancha = new ListBox();
        lateralMenuTipos = new ToolStrip();
        toolStripSeparator1 = new ToolStripSeparator();
        btnRegistrarTipo = new ToolStripButton();
        toolStripSeparator2 = new ToolStripSeparator();
        btnReporteTipos = new ToolStripButton();
        toolStripSeparator3 = new ToolStripSeparator();
        btnConsultarTipo = new ToolStripButton();
        toolStripSeparator4 = new ToolStripSeparator();
        btnModificarTipo = new ToolStripButton();
        toolStripSeparator5 = new ToolStripSeparator();
        btnEliminarTipo = new ToolStripButton();
        toolStripSeparator6 = new ToolStripSeparator();
        cbEstados = new ComboBox();
        txtBusqueda = new TextBox();
        lblFiltrado = new Label();
        btnBuscar = new Button();
        tcCanchas.SuspendLayout();
        tabCanchas.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)scCanchas).BeginInit();
        scCanchas.Panel1.SuspendLayout();
        scCanchas.Panel2.SuspendLayout();
        scCanchas.SuspendLayout();
        lateralMenuTorneos.SuspendLayout();
        tabTiposCancha.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)scTipos).BeginInit();
        scTipos.Panel1.SuspendLayout();
        scTipos.Panel2.SuspendLayout();
        scTipos.SuspendLayout();
        lateralMenuTipos.SuspendLayout();
        SuspendLayout();
        // 
        // cbFiltrado
        // 
        cbFiltrado.DropDownStyle = ComboBoxStyle.DropDownList;
        cbFiltrado.FormattingEnabled = true;
        cbFiltrado.Items.AddRange(new object[] { "ID", "Nombre", "Tipo" });
        cbFiltrado.Location = new Point(337, 6);
        cbFiltrado.Margin = new Padding(4, 3, 4, 3);
        cbFiltrado.Name = "cbFiltrado";
        cbFiltrado.Size = new Size(100, 23);
        cbFiltrado.TabIndex = 14;
        cbFiltrado.SelectedIndexChanged += cbFiltrar_SelectedIndexChanged;
        // 
        // tcCanchas
        // 
        tcCanchas.Controls.Add(tabCanchas);
        tcCanchas.Controls.Add(tabTiposCancha);
        tcCanchas.Location = new Point(-4, 60);
        tcCanchas.Margin = new Padding(4, 3, 4, 3);
        tcCanchas.Name = "tcCanchas";
        tcCanchas.SelectedIndex = 0;
        tcCanchas.Size = new Size(731, 365);
        tcCanchas.TabIndex = 11;
        tcCanchas.Click += tcCanchas_Click;
        // 
        // tabCanchas
        // 
        tabCanchas.BackColor = SystemColors.ActiveCaption;
        tabCanchas.Controls.Add(scCanchas);
        tabCanchas.Location = new Point(4, 24);
        tabCanchas.Margin = new Padding(4, 3, 4, 3);
        tabCanchas.Name = "tabCanchas";
        tabCanchas.Padding = new Padding(4, 3, 4, 3);
        tabCanchas.Size = new Size(723, 337);
        tabCanchas.TabIndex = 2;
        tabCanchas.Text = "Canchas";
        // 
        // scCanchas
        // 
        scCanchas.Dock = DockStyle.Fill;
        scCanchas.Location = new Point(4, 3);
        scCanchas.Margin = new Padding(4, 3, 4, 3);
        scCanchas.Name = "scCanchas";
        // 
        // scCanchas.Panel1
        // 
        scCanchas.Panel1.Controls.Add(listBoxCanchas);
        scCanchas.Panel1.Padding = new Padding(10, 10, 10, 20);
        // 
        // scCanchas.Panel2
        // 
        scCanchas.Panel2.BackColor = Color.Transparent;
        scCanchas.Panel2.Controls.Add(lateralMenuTorneos);
        scCanchas.Panel2.Padding = new Padding(10, 10, 10, 20);
        scCanchas.Size = new Size(715, 331);
        scCanchas.SplitterDistance = 462;
        scCanchas.SplitterWidth = 5;
        scCanchas.TabIndex = 5;
        // 
        // listBoxCanchas
        // 
        listBoxCanchas.BackColor = SystemColors.ActiveCaption;
        listBoxCanchas.BorderStyle = BorderStyle.FixedSingle;
        listBoxCanchas.Dock = DockStyle.Fill;
        listBoxCanchas.FormattingEnabled = true;
        listBoxCanchas.Location = new Point(10, 10);
        listBoxCanchas.Name = "listBoxCanchas";
        listBoxCanchas.Size = new Size(442, 301);
        listBoxCanchas.TabIndex = 1;
        listBoxCanchas.SelectedIndexChanged += listBoxCanchas_SelectedIndexChanged;
        listBoxCanchas.MouseDown += listBoxCanchas_MouseDown;
        // 
        // lateralMenuTorneos
        // 
        lateralMenuTorneos.AutoSize = false;
        lateralMenuTorneos.BackColor = SystemColors.ActiveCaption;
        lateralMenuTorneos.Dock = DockStyle.None;
        lateralMenuTorneos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lateralMenuTorneos.GripMargin = new Padding(2, 2, 2, 5);
        lateralMenuTorneos.GripStyle = ToolStripGripStyle.Hidden;
        lateralMenuTorneos.Items.AddRange(new ToolStripItem[] { toolStripSeparator7, btnRegistrarCancha, toolStripSeparator8, btnConsultarCancha, toolStripSeparator9, btnModificarCancha, toolStripSeparator10, btnBloquearCancha, toolStripSeparator11, btnBajaCancha, toolStripSeparator12 });
        lateralMenuTorneos.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
        lateralMenuTorneos.Location = new Point(10, 10);
        lateralMenuTorneos.Name = "lateralMenuTorneos";
        lateralMenuTorneos.RenderMode = ToolStripRenderMode.System;
        lateralMenuTorneos.RightToLeft = RightToLeft.No;
        lateralMenuTorneos.Size = new Size(229, 350);
        lateralMenuTorneos.TabIndex = 26;
        lateralMenuTorneos.Text = "Menú lateral";
        // 
        // toolStripSeparator7
        // 
        toolStripSeparator7.Name = "toolStripSeparator7";
        toolStripSeparator7.Size = new Size(227, 6);
        // 
        // btnRegistrarCancha
        // 
        btnRegistrarCancha.AutoSize = false;
        btnRegistrarCancha.DisplayStyle = ToolStripItemDisplayStyle.Text;
        btnRegistrarCancha.Image = (Image)resources.GetObject("btnRegistrarCancha.Image");
        btnRegistrarCancha.ImageTransparentColor = Color.Magenta;
        btnRegistrarCancha.Name = "btnRegistrarCancha";
        btnRegistrarCancha.Size = new Size(227, 48);
        btnRegistrarCancha.Text = "Nueva cancha";
        btnRegistrarCancha.Click += btnRegistrarCancha_Click;
        // 
        // toolStripSeparator8
        // 
        toolStripSeparator8.Name = "toolStripSeparator8";
        toolStripSeparator8.Size = new Size(227, 6);
        // 
        // btnConsultarCancha
        // 
        btnConsultarCancha.AutoSize = false;
        btnConsultarCancha.DisplayStyle = ToolStripItemDisplayStyle.Text;
        btnConsultarCancha.Enabled = false;
        btnConsultarCancha.Image = (Image)resources.GetObject("btnConsultarCancha.Image");
        btnConsultarCancha.ImageTransparentColor = Color.Magenta;
        btnConsultarCancha.Name = "btnConsultarCancha";
        btnConsultarCancha.Size = new Size(227, 48);
        btnConsultarCancha.Text = "Consultar propiedades";
        btnConsultarCancha.Click += btnConsultarCancha_Click;
        // 
        // toolStripSeparator9
        // 
        toolStripSeparator9.Name = "toolStripSeparator9";
        toolStripSeparator9.Size = new Size(227, 6);
        // 
        // btnModificarCancha
        // 
        btnModificarCancha.AutoSize = false;
        btnModificarCancha.DisplayStyle = ToolStripItemDisplayStyle.Text;
        btnModificarCancha.Enabled = false;
        btnModificarCancha.Image = (Image)resources.GetObject("btnModificarCancha.Image");
        btnModificarCancha.ImageTransparentColor = Color.Magenta;
        btnModificarCancha.Name = "btnModificarCancha";
        btnModificarCancha.Size = new Size(227, 48);
        btnModificarCancha.Text = "Modificar cancha";
        btnModificarCancha.Click += btnModificarCancha_Click;
        // 
        // toolStripSeparator10
        // 
        toolStripSeparator10.Name = "toolStripSeparator10";
        toolStripSeparator10.Size = new Size(227, 6);
        // 
        // btnBloquearCancha
        // 
        btnBloquearCancha.AutoSize = false;
        btnBloquearCancha.DisplayStyle = ToolStripItemDisplayStyle.Text;
        btnBloquearCancha.Enabled = false;
        btnBloquearCancha.Image = (Image)resources.GetObject("btnBloquearCancha.Image");
        btnBloquearCancha.ImageTransparentColor = Color.Magenta;
        btnBloquearCancha.Name = "btnBloquearCancha";
        btnBloquearCancha.Size = new Size(227, 48);
        btnBloquearCancha.Text = "Bloquear cancha";
        btnBloquearCancha.Click += btnBloquearCancha_Click;
        // 
        // toolStripSeparator11
        // 
        toolStripSeparator11.Name = "toolStripSeparator11";
        toolStripSeparator11.Size = new Size(227, 6);
        // 
        // btnBajaCancha
        // 
        btnBajaCancha.AutoSize = false;
        btnBajaCancha.DisplayStyle = ToolStripItemDisplayStyle.Text;
        btnBajaCancha.Enabled = false;
        btnBajaCancha.Image = (Image)resources.GetObject("btnBajaCancha.Image");
        btnBajaCancha.ImageTransparentColor = Color.Magenta;
        btnBajaCancha.Name = "btnBajaCancha";
        btnBajaCancha.Size = new Size(227, 48);
        btnBajaCancha.Text = "Dar de baja cancha";
        btnBajaCancha.Click += btnBajaCancha_Click;
        // 
        // toolStripSeparator12
        // 
        toolStripSeparator12.Name = "toolStripSeparator12";
        toolStripSeparator12.Size = new Size(227, 6);
        // 
        // tabTiposCancha
        // 
        tabTiposCancha.BackColor = SystemColors.ActiveCaption;
        tabTiposCancha.Controls.Add(scTipos);
        tabTiposCancha.Location = new Point(4, 24);
        tabTiposCancha.Margin = new Padding(4, 3, 4, 3);
        tabTiposCancha.Name = "tabTiposCancha";
        tabTiposCancha.Padding = new Padding(4, 3, 4, 3);
        tabTiposCancha.Size = new Size(723, 337);
        tabTiposCancha.TabIndex = 3;
        tabTiposCancha.Text = "Tipos de cancha";
        // 
        // scTipos
        // 
        scTipos.Dock = DockStyle.Fill;
        scTipos.Location = new Point(4, 3);
        scTipos.Margin = new Padding(4, 3, 4, 3);
        scTipos.Name = "scTipos";
        // 
        // scTipos.Panel1
        // 
        scTipos.Panel1.Controls.Add(listBoxTiposCancha);
        scTipos.Panel1.Padding = new Padding(10, 10, 10, 20);
        // 
        // scTipos.Panel2
        // 
        scTipos.Panel2.BackColor = Color.Transparent;
        scTipos.Panel2.Controls.Add(lateralMenuTipos);
        scTipos.Size = new Size(715, 331);
        scTipos.SplitterDistance = 462;
        scTipos.SplitterWidth = 5;
        scTipos.TabIndex = 4;
        // 
        // listBoxTiposCancha
        // 
        listBoxTiposCancha.BackColor = SystemColors.ActiveCaption;
        listBoxTiposCancha.BorderStyle = BorderStyle.FixedSingle;
        listBoxTiposCancha.Dock = DockStyle.Fill;
        listBoxTiposCancha.FormattingEnabled = true;
        listBoxTiposCancha.Location = new Point(10, 10);
        listBoxTiposCancha.Name = "listBoxTiposCancha";
        listBoxTiposCancha.Size = new Size(442, 301);
        listBoxTiposCancha.TabIndex = 1;
        listBoxTiposCancha.SelectedIndexChanged += listBoxTiposCancha_SelectedIndexChanged;
        listBoxTiposCancha.MouseDown += listBoxTiposCancha_MouseDown;
        // 
        // lateralMenuTipos
        // 
        lateralMenuTipos.AutoSize = false;
        lateralMenuTipos.BackColor = SystemColors.ActiveCaption;
        lateralMenuTipos.Dock = DockStyle.None;
        lateralMenuTipos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lateralMenuTipos.GripMargin = new Padding(2, 2, 2, 5);
        lateralMenuTipos.GripStyle = ToolStripGripStyle.Hidden;
        lateralMenuTipos.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, btnRegistrarTipo, toolStripSeparator2, btnReporteTipos, toolStripSeparator3, btnConsultarTipo, toolStripSeparator4, btnModificarTipo, toolStripSeparator5, btnEliminarTipo, toolStripSeparator6 });
        lateralMenuTipos.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
        lateralMenuTipos.Location = new Point(10, 10);
        lateralMenuTipos.Name = "lateralMenuTipos";
        lateralMenuTipos.RenderMode = ToolStripRenderMode.System;
        lateralMenuTipos.RightToLeft = RightToLeft.No;
        lateralMenuTipos.Size = new Size(229, 350);
        lateralMenuTipos.TabIndex = 27;
        lateralMenuTipos.Text = "Menú lateral";
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(227, 6);
        // 
        // btnRegistrarTipo
        // 
        btnRegistrarTipo.AutoSize = false;
        btnRegistrarTipo.DisplayStyle = ToolStripItemDisplayStyle.Text;
        btnRegistrarTipo.Image = (Image)resources.GetObject("btnRegistrarTipo.Image");
        btnRegistrarTipo.ImageTransparentColor = Color.Magenta;
        btnRegistrarTipo.Name = "btnRegistrarTipo";
        btnRegistrarTipo.Size = new Size(227, 48);
        btnRegistrarTipo.Text = "Nuevo tipo de cancha";
        btnRegistrarTipo.Click += btnRegistrarTipo_Click;
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new Size(227, 6);
        // 
        // btnReporteTipos
        // 
        btnReporteTipos.AutoSize = false;
        btnReporteTipos.DisplayStyle = ToolStripItemDisplayStyle.Text;
        btnReporteTipos.Image = (Image)resources.GetObject("btnReporteTipos.Image");
        btnReporteTipos.ImageTransparentColor = Color.Magenta;
        btnReporteTipos.Name = "btnReporteTipos";
        btnReporteTipos.Size = new Size(227, 48);
        btnReporteTipos.Text = "Generar reporte de tipos de cancha";
        btnReporteTipos.Click += btnReporteTipos_Click;
        // 
        // toolStripSeparator3
        // 
        toolStripSeparator3.Name = "toolStripSeparator3";
        toolStripSeparator3.Size = new Size(227, 6);
        // 
        // btnConsultarTipo
        // 
        btnConsultarTipo.AutoSize = false;
        btnConsultarTipo.DisplayStyle = ToolStripItemDisplayStyle.Text;
        btnConsultarTipo.Enabled = false;
        btnConsultarTipo.Image = (Image)resources.GetObject("btnConsultarTipo.Image");
        btnConsultarTipo.ImageTransparentColor = Color.Magenta;
        btnConsultarTipo.Name = "btnConsultarTipo";
        btnConsultarTipo.Size = new Size(227, 48);
        btnConsultarTipo.Text = "Consultar propiedades";
        btnConsultarTipo.Click += btnConsultarTipo_Click;
        // 
        // toolStripSeparator4
        // 
        toolStripSeparator4.Name = "toolStripSeparator4";
        toolStripSeparator4.Size = new Size(227, 6);
        // 
        // btnModificarTipo
        // 
        btnModificarTipo.AutoSize = false;
        btnModificarTipo.DisplayStyle = ToolStripItemDisplayStyle.Text;
        btnModificarTipo.Enabled = false;
        btnModificarTipo.Image = (Image)resources.GetObject("btnModificarTipo.Image");
        btnModificarTipo.ImageTransparentColor = Color.Magenta;
        btnModificarTipo.Name = "btnModificarTipo";
        btnModificarTipo.Size = new Size(227, 48);
        btnModificarTipo.Text = "Modificar propiedades";
        btnModificarTipo.Click += btnModificarTipo_Click;
        // 
        // toolStripSeparator5
        // 
        toolStripSeparator5.Name = "toolStripSeparator5";
        toolStripSeparator5.Size = new Size(227, 6);
        // 
        // btnEliminarTipo
        // 
        btnEliminarTipo.AutoSize = false;
        btnEliminarTipo.DisplayStyle = ToolStripItemDisplayStyle.Text;
        btnEliminarTipo.Enabled = false;
        btnEliminarTipo.Image = (Image)resources.GetObject("btnEliminarTipo.Image");
        btnEliminarTipo.ImageTransparentColor = Color.Magenta;
        btnEliminarTipo.Name = "btnEliminarTipo";
        btnEliminarTipo.Size = new Size(227, 48);
        btnEliminarTipo.Text = "Eliminar tipo de cancha";
        btnEliminarTipo.Click += btnEliminarTipo_Click;
        // 
        // toolStripSeparator6
        // 
        toolStripSeparator6.Name = "toolStripSeparator6";
        toolStripSeparator6.Size = new Size(227, 6);
        // 
        // cbEstados
        // 
        cbEstados.DropDownStyle = ComboBoxStyle.DropDownList;
        cbEstados.FormattingEnabled = true;
        cbEstados.Items.AddRange(new object[] { "Activas", "Bloqueadas", "Todas" });
        cbEstados.Location = new Point(229, 6);
        cbEstados.Margin = new Padding(4, 3, 4, 3);
        cbEstados.Name = "cbEstados";
        cbEstados.Size = new Size(100, 23);
        cbEstados.TabIndex = 15;
        cbEstados.SelectedIndexChanged += cbEstados_SelectedIndexChanged;
        // 
        // txtBusqueda
        // 
        txtBusqueda.Location = new Point(444, 6);
        txtBusqueda.Name = "txtBusqueda";
        txtBusqueda.Size = new Size(174, 23);
        txtBusqueda.TabIndex = 16;
        txtBusqueda.TextChanged += txtBusqueda_TextChanged;
        // 
        // lblFiltrado
        // 
        lblFiltrado.AutoSize = true;
        lblFiltrado.Location = new Point(157, 10);
        lblFiltrado.Name = "lblFiltrado";
        lblFiltrado.Size = new Size(65, 15);
        lblFiltrado.TabIndex = 17;
        lblFiltrado.Text = "Filtrar por:";
        // 
        // btnBuscar
        // 
        btnBuscar.Enabled = false;
        btnBuscar.Location = new Point(624, 6);
        btnBuscar.Name = "btnBuscar";
        btnBuscar.Size = new Size(75, 23);
        btnBuscar.TabIndex = 35;
        btnBuscar.Text = "Buscar";
        btnBuscar.UseVisualStyleBackColor = true;
        // 
        // ucCanchas
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        Controls.Add(btnBuscar);
        Controls.Add(lblFiltrado);
        Controls.Add(txtBusqueda);
        Controls.Add(cbEstados);
        Controls.Add(cbFiltrado);
        Controls.Add(tcCanchas);
        Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Margin = new Padding(4, 3, 4, 3);
        Name = "ucCanchas";
        Size = new Size(723, 421);
        Click += ucCanchas_Click;
        tcCanchas.ResumeLayout(false);
        tabCanchas.ResumeLayout(false);
        scCanchas.Panel1.ResumeLayout(false);
        scCanchas.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)scCanchas).EndInit();
        scCanchas.ResumeLayout(false);
        lateralMenuTorneos.ResumeLayout(false);
        lateralMenuTorneos.PerformLayout();
        tabTiposCancha.ResumeLayout(false);
        scTipos.Panel1.ResumeLayout(false);
        scTipos.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)scTipos).EndInit();
        scTipos.ResumeLayout(false);
        lateralMenuTipos.ResumeLayout(false);
        lateralMenuTipos.PerformLayout();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cbFiltrado;
    private System.Windows.Forms.TabControl tcCanchas;
    private System.Windows.Forms.TabPage tabCanchas;
    private System.Windows.Forms.TabPage tabTiposCancha;
    private System.Windows.Forms.SplitContainer scTipos;
    private System.Windows.Forms.SplitContainer scCanchas;
    private ComboBox cbEstados;
    private ListBox listBoxCanchas;
    private ListBox listBoxTiposCancha;
    private TextBox txtBusqueda;
    private Label lblFiltrado;
    private ToolStrip lateralMenuTorneos;
    private ToolStripSeparator toolStripSeparator7;
    private ToolStripButton btnRegistrarCancha;
    private ToolStripSeparator toolStripSeparator8;
    private ToolStripButton btnConsultarCancha;
    private ToolStripSeparator toolStripSeparator9;
    private ToolStripButton btnModificarCancha;
    private ToolStripSeparator toolStripSeparator10;
    private ToolStripButton btnBloquearCancha;
    private ToolStripSeparator toolStripSeparator11;
    private ToolStripButton btnBajaCancha;
    private ToolStripSeparator toolStripSeparator12;
    private ToolStrip lateralMenuTipos;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripButton btnRegistrarTipo;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripButton btnReporteTipos;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripButton btnConsultarTipo;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripButton btnModificarTipo;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStripButton btnEliminarTipo;
    private ToolStripSeparator toolStripSeparator6;
    private Button btnBuscar;
}
