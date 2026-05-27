namespace GolAhora.Forms.UserControls
{
    partial class ucUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucUsuarios));
            cbFiltrado = new ComboBox();
            txtBusqueda = new TextBox();
            btnBuscar = new Button();
            lblFiltro = new Label();
            tabAdministradores = new TabPage();
            scAdministradores = new SplitContainer();
            listBoxAdministradores = new ListBox();
            lateralMenuAdmins = new ToolStrip();
            toolStripSeparator19 = new ToolStripSeparator();
            btnRegistrarAdmin = new ToolStripButton();
            toolStripSeparator20 = new ToolStripSeparator();
            btnConsultarAdmin = new ToolStripButton();
            toolStripSeparator21 = new ToolStripSeparator();
            btnModificarAdmin = new ToolStripButton();
            toolStripSeparator22 = new ToolStripSeparator();
            btnImprimirAdmin = new ToolStripButton();
            toolStripSeparator23 = new ToolStripSeparator();
            btnBajaAdmin = new ToolStripButton();
            toolStripSeparator24 = new ToolStripSeparator();
            tabEntrenadores = new TabPage();
            scEntrenadores = new SplitContainer();
            listBoxEntrenadores = new ListBox();
            lateralMenuEntrenadores = new ToolStrip();
            toolStripSeparator13 = new ToolStripSeparator();
            btnRegistrarEntrenador = new ToolStripButton();
            toolStripSeparator14 = new ToolStripSeparator();
            btnConsultarEntrenador = new ToolStripButton();
            toolStripSeparator15 = new ToolStripSeparator();
            btnModificarEntrenador = new ToolStripButton();
            toolStripSeparator16 = new ToolStripSeparator();
            btnImprimirEntrenador = new ToolStripButton();
            toolStripSeparator17 = new ToolStripSeparator();
            btnBajaEntrenador = new ToolStripButton();
            toolStripSeparator18 = new ToolStripSeparator();
            tabProfesores = new TabPage();
            scProfesores = new SplitContainer();
            listBoxProfesores = new ListBox();
            lateralMenuProfesores = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            btnRegistrarProfesor = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnConsultarProfesor = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnModificarProfesor = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btnImprimirProfesor = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            btnBajaProfesor = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            tabClientes = new TabPage();
            scClientes = new SplitContainer();
            listBoxClientes = new ListBox();
            lateralMenuTorneos = new ToolStrip();
            toolStripSeparator7 = new ToolStripSeparator();
            btnRegistrarCliente = new ToolStripButton();
            toolStripSeparator8 = new ToolStripSeparator();
            btnConsultarCliente = new ToolStripButton();
            toolStripSeparator9 = new ToolStripSeparator();
            btnModificarCliente = new ToolStripButton();
            toolStripSeparator10 = new ToolStripSeparator();
            btnImprimirCliente = new ToolStripButton();
            toolStripSeparator11 = new ToolStripSeparator();
            btnBajaCliente = new ToolStripButton();
            toolStripSeparator12 = new ToolStripSeparator();
            tcUsuarios = new TabControl();
            tabTodos = new TabPage();
            panelUsuarios = new Panel();
            listBoxUsuarios = new ListBox();
            tabAdministradores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scAdministradores).BeginInit();
            scAdministradores.Panel1.SuspendLayout();
            scAdministradores.Panel2.SuspendLayout();
            scAdministradores.SuspendLayout();
            lateralMenuAdmins.SuspendLayout();
            tabEntrenadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scEntrenadores).BeginInit();
            scEntrenadores.Panel1.SuspendLayout();
            scEntrenadores.Panel2.SuspendLayout();
            scEntrenadores.SuspendLayout();
            lateralMenuEntrenadores.SuspendLayout();
            tabProfesores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scProfesores).BeginInit();
            scProfesores.Panel1.SuspendLayout();
            scProfesores.Panel2.SuspendLayout();
            scProfesores.SuspendLayout();
            lateralMenuProfesores.SuspendLayout();
            tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scClientes).BeginInit();
            scClientes.Panel1.SuspendLayout();
            scClientes.Panel2.SuspendLayout();
            scClientes.SuspendLayout();
            lateralMenuTorneos.SuspendLayout();
            tcUsuarios.SuspendLayout();
            tabTodos.SuspendLayout();
            panelUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // cbFiltrado
            // 
            cbFiltrado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltrado.FormattingEnabled = true;
            cbFiltrado.Items.AddRange(new object[] { "dni", "Nombre", "Email" });
            cbFiltrado.Location = new Point(334, 6);
            cbFiltrado.Margin = new Padding(4, 3, 4, 3);
            cbFiltrado.Name = "cbFiltrado";
            cbFiltrado.Size = new Size(103, 23);
            cbFiltrado.TabIndex = 6;
            cbFiltrado.SelectedIndexChanged += cbFiltrado_SelectedIndexChanged;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(444, 6);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(174, 23);
            txtBusqueda.TabIndex = 7;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
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
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(261, 10);
            lblFiltro.Margin = new Padding(4, 0, 4, 0);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(65, 15);
            lblFiltro.TabIndex = 36;
            lblFiltro.Text = "Filtrar por:";
            // 
            // tabAdministradores
            // 
            tabAdministradores.BackColor = SystemColors.ActiveCaption;
            tabAdministradores.Controls.Add(scAdministradores);
            tabAdministradores.Location = new Point(4, 24);
            tabAdministradores.Name = "tabAdministradores";
            tabAdministradores.Padding = new Padding(3);
            tabAdministradores.Size = new Size(723, 337);
            tabAdministradores.TabIndex = 4;
            tabAdministradores.Text = "Administradores";
            // 
            // scAdministradores
            // 
            scAdministradores.BackColor = SystemColors.ActiveCaption;
            scAdministradores.Dock = DockStyle.Fill;
            scAdministradores.Location = new Point(3, 3);
            scAdministradores.Margin = new Padding(4, 3, 4, 3);
            scAdministradores.Name = "scAdministradores";
            // 
            // scAdministradores.Panel1
            // 
            scAdministradores.Panel1.Controls.Add(listBoxAdministradores);
            scAdministradores.Panel1.Padding = new Padding(10, 10, 10, 20);
            // 
            // scAdministradores.Panel2
            // 
            scAdministradores.Panel2.Controls.Add(lateralMenuAdmins);
            scAdministradores.Panel2.Padding = new Padding(10, 10, 10, 20);
            scAdministradores.Size = new Size(717, 331);
            scAdministradores.SplitterDistance = 463;
            scAdministradores.SplitterWidth = 5;
            scAdministradores.TabIndex = 3;
            // 
            // listBoxAdministradores
            // 
            listBoxAdministradores.BackColor = SystemColors.ActiveCaption;
            listBoxAdministradores.BorderStyle = BorderStyle.FixedSingle;
            listBoxAdministradores.Dock = DockStyle.Fill;
            listBoxAdministradores.FormattingEnabled = true;
            listBoxAdministradores.Location = new Point(10, 10);
            listBoxAdministradores.Name = "listBoxAdministradores";
            listBoxAdministradores.Size = new Size(443, 301);
            listBoxAdministradores.TabIndex = 1;
            listBoxAdministradores.SelectedIndexChanged += listBoxAdministradores_SelectedIndexChanged;
            listBoxAdministradores.MouseDown += listBoxAdministradores_MouseDown;
            // 
            // lateralMenuAdmins
            // 
            lateralMenuAdmins.AutoSize = false;
            lateralMenuAdmins.BackColor = SystemColors.ActiveCaption;
            lateralMenuAdmins.Dock = DockStyle.None;
            lateralMenuAdmins.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lateralMenuAdmins.GripMargin = new Padding(2, 2, 2, 5);
            lateralMenuAdmins.GripStyle = ToolStripGripStyle.Hidden;
            lateralMenuAdmins.Items.AddRange(new ToolStripItem[] { toolStripSeparator19, btnRegistrarAdmin, toolStripSeparator20, btnConsultarAdmin, toolStripSeparator21, btnModificarAdmin, toolStripSeparator22, btnImprimirAdmin, toolStripSeparator23, btnBajaAdmin, toolStripSeparator24 });
            lateralMenuAdmins.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            lateralMenuAdmins.Location = new Point(10, 10);
            lateralMenuAdmins.Name = "lateralMenuAdmins";
            lateralMenuAdmins.RenderMode = ToolStripRenderMode.System;
            lateralMenuAdmins.RightToLeft = RightToLeft.No;
            lateralMenuAdmins.Size = new Size(229, 350);
            lateralMenuAdmins.TabIndex = 28;
            lateralMenuAdmins.Text = "Menú lateral";
            // 
            // toolStripSeparator19
            // 
            toolStripSeparator19.Name = "toolStripSeparator19";
            toolStripSeparator19.Size = new Size(227, 6);
            // 
            // btnRegistrarAdmin
            // 
            btnRegistrarAdmin.AutoSize = false;
            btnRegistrarAdmin.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnRegistrarAdmin.Image = (Image)resources.GetObject("btnRegistrarAdmin.Image");
            btnRegistrarAdmin.ImageTransparentColor = Color.Magenta;
            btnRegistrarAdmin.Name = "btnRegistrarAdmin";
            btnRegistrarAdmin.Size = new Size(227, 48);
            btnRegistrarAdmin.Text = "Registrar administrador";
            btnRegistrarAdmin.Click += btnRegistrarAdmin_Click;
            // 
            // toolStripSeparator20
            // 
            toolStripSeparator20.Name = "toolStripSeparator20";
            toolStripSeparator20.Size = new Size(227, 6);
            // 
            // btnConsultarAdmin
            // 
            btnConsultarAdmin.AutoSize = false;
            btnConsultarAdmin.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnConsultarAdmin.Enabled = false;
            btnConsultarAdmin.Image = (Image)resources.GetObject("btnConsultarAdmin.Image");
            btnConsultarAdmin.ImageTransparentColor = Color.Magenta;
            btnConsultarAdmin.Name = "btnConsultarAdmin";
            btnConsultarAdmin.Size = new Size(227, 48);
            btnConsultarAdmin.Text = "Consultar administrador";
            btnConsultarAdmin.Click += btnConsultarAdmin_Click;
            // 
            // toolStripSeparator21
            // 
            toolStripSeparator21.Name = "toolStripSeparator21";
            toolStripSeparator21.Size = new Size(227, 6);
            // 
            // btnModificarAdmin
            // 
            btnModificarAdmin.AutoSize = false;
            btnModificarAdmin.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnModificarAdmin.Enabled = false;
            btnModificarAdmin.Image = (Image)resources.GetObject("btnModificarAdmin.Image");
            btnModificarAdmin.ImageTransparentColor = Color.Magenta;
            btnModificarAdmin.Name = "btnModificarAdmin";
            btnModificarAdmin.Size = new Size(227, 48);
            btnModificarAdmin.Text = "Modificar administrador";
            btnModificarAdmin.Click += btnModificarAdmin_Click;
            // 
            // toolStripSeparator22
            // 
            toolStripSeparator22.Name = "toolStripSeparator22";
            toolStripSeparator22.Size = new Size(227, 6);
            // 
            // btnImprimirAdmin
            // 
            btnImprimirAdmin.AutoSize = false;
            btnImprimirAdmin.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnImprimirAdmin.Enabled = false;
            btnImprimirAdmin.Image = (Image)resources.GetObject("btnImprimirAdmin.Image");
            btnImprimirAdmin.ImageTransparentColor = Color.Magenta;
            btnImprimirAdmin.Name = "btnImprimirAdmin";
            btnImprimirAdmin.Size = new Size(227, 48);
            btnImprimirAdmin.Text = "Imprimir datos de administrador";
            btnImprimirAdmin.Click += btnImprimirAdmin_Click;
            // 
            // toolStripSeparator23
            // 
            toolStripSeparator23.Name = "toolStripSeparator23";
            toolStripSeparator23.Size = new Size(227, 6);
            // 
            // btnBajaAdmin
            // 
            btnBajaAdmin.AutoSize = false;
            btnBajaAdmin.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnBajaAdmin.Enabled = false;
            btnBajaAdmin.Image = (Image)resources.GetObject("btnBajaAdmin.Image");
            btnBajaAdmin.ImageTransparentColor = Color.Magenta;
            btnBajaAdmin.Name = "btnBajaAdmin";
            btnBajaAdmin.Size = new Size(227, 48);
            btnBajaAdmin.Text = "Dar de baja administrador";
            btnBajaAdmin.Click += btnBajaAdmin_Click;
            // 
            // toolStripSeparator24
            // 
            toolStripSeparator24.Name = "toolStripSeparator24";
            toolStripSeparator24.Size = new Size(227, 6);
            // 
            // tabEntrenadores
            // 
            tabEntrenadores.BackColor = SystemColors.ActiveCaption;
            tabEntrenadores.Controls.Add(scEntrenadores);
            tabEntrenadores.Location = new Point(4, 24);
            tabEntrenadores.Margin = new Padding(4, 3, 4, 3);
            tabEntrenadores.Name = "tabEntrenadores";
            tabEntrenadores.Padding = new Padding(4, 3, 4, 3);
            tabEntrenadores.Size = new Size(723, 337);
            tabEntrenadores.TabIndex = 2;
            tabEntrenadores.Text = "Entrenadores";
            // 
            // scEntrenadores
            // 
            scEntrenadores.BackColor = SystemColors.ActiveCaption;
            scEntrenadores.Dock = DockStyle.Fill;
            scEntrenadores.Location = new Point(4, 3);
            scEntrenadores.Margin = new Padding(4, 3, 4, 3);
            scEntrenadores.Name = "scEntrenadores";
            // 
            // scEntrenadores.Panel1
            // 
            scEntrenadores.Panel1.Controls.Add(listBoxEntrenadores);
            scEntrenadores.Panel1.Padding = new Padding(10, 10, 10, 20);
            // 
            // scEntrenadores.Panel2
            // 
            scEntrenadores.Panel2.Controls.Add(lateralMenuEntrenadores);
            scEntrenadores.Panel2.Padding = new Padding(10, 10, 10, 20);
            scEntrenadores.Size = new Size(715, 331);
            scEntrenadores.SplitterDistance = 462;
            scEntrenadores.SplitterWidth = 5;
            scEntrenadores.TabIndex = 2;
            // 
            // listBoxEntrenadores
            // 
            listBoxEntrenadores.BackColor = SystemColors.ActiveCaption;
            listBoxEntrenadores.BorderStyle = BorderStyle.FixedSingle;
            listBoxEntrenadores.Dock = DockStyle.Fill;
            listBoxEntrenadores.FormattingEnabled = true;
            listBoxEntrenadores.Location = new Point(10, 10);
            listBoxEntrenadores.Name = "listBoxEntrenadores";
            listBoxEntrenadores.Size = new Size(442, 301);
            listBoxEntrenadores.TabIndex = 1;
            listBoxEntrenadores.SelectedIndexChanged += listBoxEntrenadores_SelectedIndexChanged;
            listBoxEntrenadores.MouseDown += listBoxEntrenadores_MouseDown;
            // 
            // lateralMenuEntrenadores
            // 
            lateralMenuEntrenadores.AutoSize = false;
            lateralMenuEntrenadores.BackColor = SystemColors.ActiveCaption;
            lateralMenuEntrenadores.Dock = DockStyle.None;
            lateralMenuEntrenadores.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lateralMenuEntrenadores.GripMargin = new Padding(2, 2, 2, 5);
            lateralMenuEntrenadores.GripStyle = ToolStripGripStyle.Hidden;
            lateralMenuEntrenadores.Items.AddRange(new ToolStripItem[] { toolStripSeparator13, btnRegistrarEntrenador, toolStripSeparator14, btnConsultarEntrenador, toolStripSeparator15, btnModificarEntrenador, toolStripSeparator16, btnImprimirEntrenador, toolStripSeparator17, btnBajaEntrenador, toolStripSeparator18 });
            lateralMenuEntrenadores.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            lateralMenuEntrenadores.Location = new Point(10, 10);
            lateralMenuEntrenadores.Name = "lateralMenuEntrenadores";
            lateralMenuEntrenadores.RenderMode = ToolStripRenderMode.System;
            lateralMenuEntrenadores.RightToLeft = RightToLeft.No;
            lateralMenuEntrenadores.Size = new Size(229, 350);
            lateralMenuEntrenadores.TabIndex = 28;
            lateralMenuEntrenadores.Text = "Menú lateral";
            // 
            // toolStripSeparator13
            // 
            toolStripSeparator13.Name = "toolStripSeparator13";
            toolStripSeparator13.Size = new Size(227, 6);
            // 
            // btnRegistrarEntrenador
            // 
            btnRegistrarEntrenador.AutoSize = false;
            btnRegistrarEntrenador.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnRegistrarEntrenador.Image = (Image)resources.GetObject("btnRegistrarEntrenador.Image");
            btnRegistrarEntrenador.ImageTransparentColor = Color.Magenta;
            btnRegistrarEntrenador.Name = "btnRegistrarEntrenador";
            btnRegistrarEntrenador.Size = new Size(227, 48);
            btnRegistrarEntrenador.Text = "Registrar entrenador";
            btnRegistrarEntrenador.Click += btnRegistrarEntrenador_Click;
            // 
            // toolStripSeparator14
            // 
            toolStripSeparator14.Name = "toolStripSeparator14";
            toolStripSeparator14.Size = new Size(227, 6);
            // 
            // btnConsultarEntrenador
            // 
            btnConsultarEntrenador.AutoSize = false;
            btnConsultarEntrenador.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnConsultarEntrenador.Enabled = false;
            btnConsultarEntrenador.Image = (Image)resources.GetObject("btnConsultarEntrenador.Image");
            btnConsultarEntrenador.ImageTransparentColor = Color.Magenta;
            btnConsultarEntrenador.Name = "btnConsultarEntrenador";
            btnConsultarEntrenador.Size = new Size(227, 48);
            btnConsultarEntrenador.Text = "Consultar entrenador";
            btnConsultarEntrenador.Click += btnConsultarEntrenador_Click;
            // 
            // toolStripSeparator15
            // 
            toolStripSeparator15.Name = "toolStripSeparator15";
            toolStripSeparator15.Size = new Size(227, 6);
            // 
            // btnModificarEntrenador
            // 
            btnModificarEntrenador.AutoSize = false;
            btnModificarEntrenador.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnModificarEntrenador.Enabled = false;
            btnModificarEntrenador.Image = (Image)resources.GetObject("btnModificarEntrenador.Image");
            btnModificarEntrenador.ImageTransparentColor = Color.Magenta;
            btnModificarEntrenador.Name = "btnModificarEntrenador";
            btnModificarEntrenador.Size = new Size(227, 48);
            btnModificarEntrenador.Text = "Modificar entrenador";
            btnModificarEntrenador.Click += btnModificarEntrenador_Click;
            // 
            // toolStripSeparator16
            // 
            toolStripSeparator16.Name = "toolStripSeparator16";
            toolStripSeparator16.Size = new Size(227, 6);
            // 
            // btnImprimirEntrenador
            // 
            btnImprimirEntrenador.AutoSize = false;
            btnImprimirEntrenador.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnImprimirEntrenador.Enabled = false;
            btnImprimirEntrenador.Image = (Image)resources.GetObject("btnImprimirEntrenador.Image");
            btnImprimirEntrenador.ImageTransparentColor = Color.Magenta;
            btnImprimirEntrenador.Name = "btnImprimirEntrenador";
            btnImprimirEntrenador.Size = new Size(227, 48);
            btnImprimirEntrenador.Text = "Imprimir datos de entrenador";
            btnImprimirEntrenador.Click += btnImprimirEntrenador_Click;
            // 
            // toolStripSeparator17
            // 
            toolStripSeparator17.Name = "toolStripSeparator17";
            toolStripSeparator17.Size = new Size(227, 6);
            // 
            // btnBajaEntrenador
            // 
            btnBajaEntrenador.AutoSize = false;
            btnBajaEntrenador.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnBajaEntrenador.Enabled = false;
            btnBajaEntrenador.Image = (Image)resources.GetObject("btnBajaEntrenador.Image");
            btnBajaEntrenador.ImageTransparentColor = Color.Magenta;
            btnBajaEntrenador.Name = "btnBajaEntrenador";
            btnBajaEntrenador.Size = new Size(227, 48);
            btnBajaEntrenador.Text = "Dar de baja entrenador";
            btnBajaEntrenador.Click += btnBajaEntrenador_Click;
            // 
            // toolStripSeparator18
            // 
            toolStripSeparator18.Name = "toolStripSeparator18";
            toolStripSeparator18.Size = new Size(227, 6);
            // 
            // tabProfesores
            // 
            tabProfesores.BackColor = SystemColors.ActiveCaption;
            tabProfesores.Controls.Add(scProfesores);
            tabProfesores.Location = new Point(4, 24);
            tabProfesores.Margin = new Padding(4, 3, 4, 3);
            tabProfesores.Name = "tabProfesores";
            tabProfesores.Padding = new Padding(4, 3, 4, 3);
            tabProfesores.Size = new Size(723, 337);
            tabProfesores.TabIndex = 1;
            tabProfesores.Text = "Profesores";
            // 
            // scProfesores
            // 
            scProfesores.Dock = DockStyle.Fill;
            scProfesores.Location = new Point(4, 3);
            scProfesores.Margin = new Padding(4, 3, 4, 3);
            scProfesores.Name = "scProfesores";
            // 
            // scProfesores.Panel1
            // 
            scProfesores.Panel1.Controls.Add(listBoxProfesores);
            scProfesores.Panel1.Padding = new Padding(10, 10, 10, 20);
            // 
            // scProfesores.Panel2
            // 
            scProfesores.Panel2.BackColor = Color.Transparent;
            scProfesores.Panel2.Controls.Add(lateralMenuProfesores);
            scProfesores.Panel2.Padding = new Padding(10, 10, 10, 20);
            scProfesores.Size = new Size(715, 331);
            scProfesores.SplitterDistance = 462;
            scProfesores.SplitterWidth = 5;
            scProfesores.TabIndex = 4;
            // 
            // listBoxProfesores
            // 
            listBoxProfesores.BackColor = SystemColors.ActiveCaption;
            listBoxProfesores.BorderStyle = BorderStyle.FixedSingle;
            listBoxProfesores.Dock = DockStyle.Fill;
            listBoxProfesores.FormattingEnabled = true;
            listBoxProfesores.Location = new Point(10, 10);
            listBoxProfesores.Name = "listBoxProfesores";
            listBoxProfesores.Size = new Size(442, 301);
            listBoxProfesores.TabIndex = 1;
            listBoxProfesores.SelectedIndexChanged += listBoxProfesores_SelectedIndexChanged;
            listBoxProfesores.MouseDown += listBoxProfesores_MouseDown;
            // 
            // lateralMenuProfesores
            // 
            lateralMenuProfesores.AutoSize = false;
            lateralMenuProfesores.BackColor = SystemColors.ActiveCaption;
            lateralMenuProfesores.Dock = DockStyle.None;
            lateralMenuProfesores.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lateralMenuProfesores.GripMargin = new Padding(2, 2, 2, 5);
            lateralMenuProfesores.GripStyle = ToolStripGripStyle.Hidden;
            lateralMenuProfesores.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, btnRegistrarProfesor, toolStripSeparator2, btnConsultarProfesor, toolStripSeparator3, btnModificarProfesor, toolStripSeparator4, btnImprimirProfesor, toolStripSeparator5, btnBajaProfesor, toolStripSeparator6 });
            lateralMenuProfesores.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            lateralMenuProfesores.Location = new Point(10, 10);
            lateralMenuProfesores.Name = "lateralMenuProfesores";
            lateralMenuProfesores.RenderMode = ToolStripRenderMode.System;
            lateralMenuProfesores.RightToLeft = RightToLeft.No;
            lateralMenuProfesores.Size = new Size(229, 350);
            lateralMenuProfesores.TabIndex = 28;
            lateralMenuProfesores.Text = "Menú lateral";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(227, 6);
            // 
            // btnRegistrarProfesor
            // 
            btnRegistrarProfesor.AutoSize = false;
            btnRegistrarProfesor.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnRegistrarProfesor.Image = (Image)resources.GetObject("btnRegistrarProfesor.Image");
            btnRegistrarProfesor.ImageTransparentColor = Color.Magenta;
            btnRegistrarProfesor.Name = "btnRegistrarProfesor";
            btnRegistrarProfesor.Size = new Size(227, 48);
            btnRegistrarProfesor.Text = "Registrar profesor";
            btnRegistrarProfesor.Click += btnRegistrarProfesor_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(227, 6);
            // 
            // btnConsultarProfesor
            // 
            btnConsultarProfesor.AutoSize = false;
            btnConsultarProfesor.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnConsultarProfesor.Enabled = false;
            btnConsultarProfesor.Image = (Image)resources.GetObject("btnConsultarProfesor.Image");
            btnConsultarProfesor.ImageTransparentColor = Color.Magenta;
            btnConsultarProfesor.Name = "btnConsultarProfesor";
            btnConsultarProfesor.Size = new Size(227, 48);
            btnConsultarProfesor.Text = "Consultar profesor";
            btnConsultarProfesor.Click += btnConsultarProfesor_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(227, 6);
            // 
            // btnModificarProfesor
            // 
            btnModificarProfesor.AutoSize = false;
            btnModificarProfesor.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnModificarProfesor.Enabled = false;
            btnModificarProfesor.Image = (Image)resources.GetObject("btnModificarProfesor.Image");
            btnModificarProfesor.ImageTransparentColor = Color.Magenta;
            btnModificarProfesor.Name = "btnModificarProfesor";
            btnModificarProfesor.Size = new Size(227, 48);
            btnModificarProfesor.Text = "Modificar profesor";
            btnModificarProfesor.Click += btnModificarProfesor_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(227, 6);
            // 
            // btnImprimirProfesor
            // 
            btnImprimirProfesor.AutoSize = false;
            btnImprimirProfesor.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnImprimirProfesor.Enabled = false;
            btnImprimirProfesor.Image = (Image)resources.GetObject("btnImprimirProfesor.Image");
            btnImprimirProfesor.ImageTransparentColor = Color.Magenta;
            btnImprimirProfesor.Name = "btnImprimirProfesor";
            btnImprimirProfesor.Size = new Size(227, 48);
            btnImprimirProfesor.Text = "Imprimir datos de profesor";
            btnImprimirProfesor.Click += btnImprimirProfesor_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(227, 6);
            // 
            // btnBajaProfesor
            // 
            btnBajaProfesor.AutoSize = false;
            btnBajaProfesor.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnBajaProfesor.Enabled = false;
            btnBajaProfesor.Image = (Image)resources.GetObject("btnBajaProfesor.Image");
            btnBajaProfesor.ImageTransparentColor = Color.Magenta;
            btnBajaProfesor.Name = "btnBajaProfesor";
            btnBajaProfesor.Size = new Size(227, 48);
            btnBajaProfesor.Text = "Dar de baja profesor";
            btnBajaProfesor.Click += btnBajaProfesor_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(227, 6);
            // 
            // tabClientes
            // 
            tabClientes.BackColor = SystemColors.ActiveCaption;
            tabClientes.Controls.Add(scClientes);
            tabClientes.Location = new Point(4, 24);
            tabClientes.Margin = new Padding(4, 3, 4, 3);
            tabClientes.Name = "tabClientes";
            tabClientes.Padding = new Padding(4, 3, 4, 3);
            tabClientes.Size = new Size(723, 337);
            tabClientes.TabIndex = 0;
            tabClientes.Text = "Clientes";
            // 
            // scClientes
            // 
            scClientes.Dock = DockStyle.Fill;
            scClientes.Location = new Point(4, 3);
            scClientes.Margin = new Padding(4, 3, 4, 3);
            scClientes.Name = "scClientes";
            // 
            // scClientes.Panel1
            // 
            scClientes.Panel1.Controls.Add(listBoxClientes);
            scClientes.Panel1.Padding = new Padding(10, 10, 10, 20);
            // 
            // scClientes.Panel2
            // 
            scClientes.Panel2.BackColor = Color.Transparent;
            scClientes.Panel2.Controls.Add(lateralMenuTorneos);
            scClientes.Panel2.Padding = new Padding(10);
            scClientes.Size = new Size(715, 331);
            scClientes.SplitterDistance = 462;
            scClientes.SplitterWidth = 5;
            scClientes.TabIndex = 3;
            // 
            // listBoxClientes
            // 
            listBoxClientes.BackColor = SystemColors.ActiveCaption;
            listBoxClientes.BorderStyle = BorderStyle.FixedSingle;
            listBoxClientes.Dock = DockStyle.Fill;
            listBoxClientes.FormattingEnabled = true;
            listBoxClientes.Location = new Point(10, 10);
            listBoxClientes.Name = "listBoxClientes";
            listBoxClientes.Size = new Size(442, 301);
            listBoxClientes.TabIndex = 2;
            listBoxClientes.SelectedIndexChanged += listBoxClientes_SelectedIndexChanged;
            listBoxClientes.MouseDown += listBoxClientes_MouseDown;
            // 
            // lateralMenuTorneos
            // 
            lateralMenuTorneos.AutoSize = false;
            lateralMenuTorneos.BackColor = SystemColors.ActiveCaption;
            lateralMenuTorneos.Dock = DockStyle.None;
            lateralMenuTorneos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lateralMenuTorneos.GripMargin = new Padding(2, 2, 2, 5);
            lateralMenuTorneos.GripStyle = ToolStripGripStyle.Hidden;
            lateralMenuTorneos.Items.AddRange(new ToolStripItem[] { toolStripSeparator7, btnRegistrarCliente, toolStripSeparator8, btnConsultarCliente, toolStripSeparator9, btnModificarCliente, toolStripSeparator10, btnImprimirCliente, toolStripSeparator11, btnBajaCliente, toolStripSeparator12 });
            lateralMenuTorneos.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            lateralMenuTorneos.Location = new Point(10, 10);
            lateralMenuTorneos.Name = "lateralMenuTorneos";
            lateralMenuTorneos.RenderMode = ToolStripRenderMode.System;
            lateralMenuTorneos.RightToLeft = RightToLeft.No;
            lateralMenuTorneos.Size = new Size(229, 350);
            lateralMenuTorneos.TabIndex = 27;
            lateralMenuTorneos.Text = "Menú lateral";
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(227, 6);
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.AutoSize = false;
            btnRegistrarCliente.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnRegistrarCliente.Image = (Image)resources.GetObject("btnRegistrarCliente.Image");
            btnRegistrarCliente.ImageTransparentColor = Color.Magenta;
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(227, 48);
            btnRegistrarCliente.Text = "Registrar cliente";
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(227, 6);
            // 
            // btnConsultarCliente
            // 
            btnConsultarCliente.AutoSize = false;
            btnConsultarCliente.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnConsultarCliente.Enabled = false;
            btnConsultarCliente.Image = (Image)resources.GetObject("btnConsultarCliente.Image");
            btnConsultarCliente.ImageTransparentColor = Color.Magenta;
            btnConsultarCliente.Name = "btnConsultarCliente";
            btnConsultarCliente.Size = new Size(227, 48);
            btnConsultarCliente.Text = "Consultar cliente";
            btnConsultarCliente.Click += btnConsultarCliente_Click;
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(227, 6);
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.AutoSize = false;
            btnModificarCliente.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnModificarCliente.Enabled = false;
            btnModificarCliente.Image = (Image)resources.GetObject("btnModificarCliente.Image");
            btnModificarCliente.ImageTransparentColor = Color.Magenta;
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(227, 48);
            btnModificarCliente.Text = "Modificar cliente";
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new Size(227, 6);
            // 
            // btnImprimirCliente
            // 
            btnImprimirCliente.AutoSize = false;
            btnImprimirCliente.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnImprimirCliente.Enabled = false;
            btnImprimirCliente.Image = (Image)resources.GetObject("btnImprimirCliente.Image");
            btnImprimirCliente.ImageTransparentColor = Color.Magenta;
            btnImprimirCliente.Name = "btnImprimirCliente";
            btnImprimirCliente.Size = new Size(227, 48);
            btnImprimirCliente.Text = "Imprimir datos de cliente";
            btnImprimirCliente.Click += btnImprimirCliente_Click;
            // 
            // toolStripSeparator11
            // 
            toolStripSeparator11.Name = "toolStripSeparator11";
            toolStripSeparator11.Size = new Size(227, 6);
            // 
            // btnBajaCliente
            // 
            btnBajaCliente.AutoSize = false;
            btnBajaCliente.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnBajaCliente.Enabled = false;
            btnBajaCliente.Image = (Image)resources.GetObject("btnBajaCliente.Image");
            btnBajaCliente.ImageTransparentColor = Color.Magenta;
            btnBajaCliente.Name = "btnBajaCliente";
            btnBajaCliente.Size = new Size(227, 48);
            btnBajaCliente.Text = "Dar de baja cliente";
            btnBajaCliente.Click += btnBajaCliente_Click;
            // 
            // toolStripSeparator12
            // 
            toolStripSeparator12.Name = "toolStripSeparator12";
            toolStripSeparator12.Size = new Size(227, 6);
            // 
            // tcUsuarios
            // 
            tcUsuarios.Controls.Add(tabClientes);
            tcUsuarios.Controls.Add(tabProfesores);
            tcUsuarios.Controls.Add(tabEntrenadores);
            tcUsuarios.Controls.Add(tabAdministradores);
            tcUsuarios.Controls.Add(tabTodos);
            tcUsuarios.Location = new Point(-4, 60);
            tcUsuarios.Margin = new Padding(4, 3, 4, 3);
            tcUsuarios.Name = "tcUsuarios";
            tcUsuarios.SelectedIndex = 0;
            tcUsuarios.Size = new Size(731, 365);
            tcUsuarios.TabIndex = 0;
            tcUsuarios.Click += tcUsuarios_Click;
            // 
            // tabTodos
            // 
            tabTodos.BackColor = SystemColors.ActiveCaption;
            tabTodos.Controls.Add(panelUsuarios);
            tabTodos.Location = new Point(4, 24);
            tabTodos.Name = "tabTodos";
            tabTodos.Padding = new Padding(3);
            tabTodos.Size = new Size(723, 337);
            tabTodos.TabIndex = 5;
            tabTodos.Text = "Todos";
            // 
            // panelUsuarios
            // 
            panelUsuarios.Controls.Add(listBoxUsuarios);
            panelUsuarios.Location = new Point(4, 4);
            panelUsuarios.Name = "panelUsuarios";
            panelUsuarios.Padding = new Padding(10, 10, 10, 20);
            panelUsuarios.Size = new Size(714, 328);
            panelUsuarios.TabIndex = 1;
            // 
            // listBoxUsuarios
            // 
            listBoxUsuarios.BackColor = SystemColors.ActiveCaption;
            listBoxUsuarios.BorderStyle = BorderStyle.FixedSingle;
            listBoxUsuarios.Dock = DockStyle.Fill;
            listBoxUsuarios.FormattingEnabled = true;
            listBoxUsuarios.Location = new Point(10, 10);
            listBoxUsuarios.Name = "listBoxUsuarios";
            listBoxUsuarios.Size = new Size(694, 298);
            listBoxUsuarios.TabIndex = 4;
            // 
            // ucUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(lblFiltro);
            Controls.Add(btnBuscar);
            Controls.Add(txtBusqueda);
            Controls.Add(cbFiltrado);
            Controls.Add(tcUsuarios);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ucUsuarios";
            Size = new Size(723, 421);
            Load += ucUsuarios_Load;
            Click += ucUsuarios_Click;
            tabAdministradores.ResumeLayout(false);
            scAdministradores.Panel1.ResumeLayout(false);
            scAdministradores.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scAdministradores).EndInit();
            scAdministradores.ResumeLayout(false);
            lateralMenuAdmins.ResumeLayout(false);
            lateralMenuAdmins.PerformLayout();
            tabEntrenadores.ResumeLayout(false);
            scEntrenadores.Panel1.ResumeLayout(false);
            scEntrenadores.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scEntrenadores).EndInit();
            scEntrenadores.ResumeLayout(false);
            lateralMenuEntrenadores.ResumeLayout(false);
            lateralMenuEntrenadores.PerformLayout();
            tabProfesores.ResumeLayout(false);
            scProfesores.Panel1.ResumeLayout(false);
            scProfesores.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scProfesores).EndInit();
            scProfesores.ResumeLayout(false);
            lateralMenuProfesores.ResumeLayout(false);
            lateralMenuProfesores.PerformLayout();
            tabClientes.ResumeLayout(false);
            scClientes.Panel1.ResumeLayout(false);
            scClientes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scClientes).EndInit();
            scClientes.ResumeLayout(false);
            lateralMenuTorneos.ResumeLayout(false);
            lateralMenuTorneos.PerformLayout();
            tcUsuarios.ResumeLayout(false);
            tabTodos.ResumeLayout(false);
            panelUsuarios.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbFiltrado;
        private DataGridView dgvTodos;
        private TextBox txtBusqueda;
        private Button btnBuscar;
        private Label lblFiltro;
        private TabPage tabAdministradores;
        private SplitContainer scAdministradores;
        private ListBox listBoxAdministradores;
        private ToolStrip lateralMenuAdmins;
        private ToolStripSeparator toolStripSeparator19;
        private ToolStripButton btnRegistrarAdmin;
        private ToolStripSeparator toolStripSeparator20;
        private ToolStripButton btnConsultarAdmin;
        private ToolStripSeparator toolStripSeparator21;
        private ToolStripButton btnModificarAdmin;
        private ToolStripSeparator toolStripSeparator22;
        private ToolStripButton btnImprimirAdmin;
        private ToolStripSeparator toolStripSeparator23;
        private ToolStripButton btnBajaAdmin;
        private ToolStripSeparator toolStripSeparator24;
        private TabPage tabEntrenadores;
        private SplitContainer scEntrenadores;
        private ListBox listBoxEntrenadores;
        private ToolStrip lateralMenuEntrenadores;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripButton btnRegistrarEntrenador;
        private ToolStripSeparator toolStripSeparator14;
        private ToolStripButton btnConsultarEntrenador;
        private ToolStripSeparator toolStripSeparator15;
        private ToolStripButton btnModificarEntrenador;
        private ToolStripSeparator toolStripSeparator16;
        private ToolStripButton btnImprimirEntrenador;
        private ToolStripSeparator toolStripSeparator17;
        private ToolStripButton btnBajaEntrenador;
        private ToolStripSeparator toolStripSeparator18;
        private TabPage tabProfesores;
        private SplitContainer scProfesores;
        private ListBox listBoxProfesores;
        private ToolStrip lateralMenuProfesores;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnRegistrarProfesor;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnConsultarProfesor;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnModificarProfesor;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnImprimirProfesor;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton btnBajaProfesor;
        private ToolStripSeparator toolStripSeparator6;
        private TabPage tabClientes;
        private SplitContainer scClientes;
        private ListBox listBoxClientes;
        private ToolStrip lateralMenuTorneos;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton btnRegistrarCliente;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton btnConsultarCliente;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripButton btnModificarCliente;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripButton btnImprimirCliente;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripButton btnBajaCliente;
        private ToolStripSeparator toolStripSeparator12;
        private TabControl tcUsuarios;
        private TabPage tabTodos;
        private Panel panelUsuarios;
        private ListBox listBoxUsuarios;
    }
}
