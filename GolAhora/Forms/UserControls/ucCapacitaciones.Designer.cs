namespace GolAhora.Forms.UserControls
{
    partial class ucCapacitaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCapacitaciones));
            tcCapacitaciones = new TabControl();
            tabClases = new TabPage();
            scClases = new SplitContainer();
            listBoxClases = new ListBox();
            lateralMenuTorneos = new ToolStrip();
            toolStripSeparator7 = new ToolStripSeparator();
            btnRegistrarClase = new ToolStripButton();
            toolStripSeparator8 = new ToolStripSeparator();
            btnConsultarClase = new ToolStripButton();
            toolStripSeparator9 = new ToolStripSeparator();
            btnModificarClase = new ToolStripButton();
            toolStripSeparator10 = new ToolStripSeparator();
            btnInscribirAlumnoClase = new ToolStripButton();
            toolStripSeparator11 = new ToolStripSeparator();
            btnAsistenciaClase = new ToolStripButton();
            toolStripSeparator12 = new ToolStripSeparator();
            btnReporteAsistenciaClase = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnBajaAlumnoClase = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tabEntrenamientos = new TabPage();
            scEntrenamientos = new SplitContainer();
            listBoxEntrenamientos = new ListBox();
            toolStrip1 = new ToolStrip();
            toolStripSeparator3 = new ToolStripSeparator();
            btnRegistrarEntrenamiento = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btnConsultarEntrenamiento = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            btnModificarEntrenamiento = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            btnInscribirAlumnoEntrenamiento = new ToolStripButton();
            toolStripSeparator13 = new ToolStripSeparator();
            btnAsistenciaEntrenamiento = new ToolStripButton();
            toolStripSeparator14 = new ToolStripSeparator();
            btnReporteAsistenciaEntrenamiento = new ToolStripButton();
            toolStripSeparator15 = new ToolStripSeparator();
            btnBajaAlumnoEntrenamiento = new ToolStripButton();
            toolStripSeparator16 = new ToolStripSeparator();
            cbFiltrado = new ComboBox();
            cbEstado = new ComboBox();
            txtBusqueda = new TextBox();
            lblFiltrado = new Label();
            btnBuscar = new Button();
            tcCapacitaciones.SuspendLayout();
            tabClases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scClases).BeginInit();
            scClases.Panel1.SuspendLayout();
            scClases.Panel2.SuspendLayout();
            scClases.SuspendLayout();
            lateralMenuTorneos.SuspendLayout();
            tabEntrenamientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scEntrenamientos).BeginInit();
            scEntrenamientos.Panel1.SuspendLayout();
            scEntrenamientos.Panel2.SuspendLayout();
            scEntrenamientos.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tcCapacitaciones
            // 
            tcCapacitaciones.Controls.Add(tabClases);
            tcCapacitaciones.Controls.Add(tabEntrenamientos);
            tcCapacitaciones.Location = new Point(-4, 60);
            tcCapacitaciones.Margin = new Padding(4, 3, 4, 3);
            tcCapacitaciones.Name = "tcCapacitaciones";
            tcCapacitaciones.SelectedIndex = 0;
            tcCapacitaciones.Size = new Size(731, 365);
            tcCapacitaciones.TabIndex = 1;
            tcCapacitaciones.Click += tcCapacitaciones_Click;
            // 
            // tabClases
            // 
            tabClases.BackColor = SystemColors.ActiveCaption;
            tabClases.Controls.Add(scClases);
            tabClases.Location = new Point(4, 24);
            tabClases.Margin = new Padding(4, 3, 4, 3);
            tabClases.Name = "tabClases";
            tabClases.Padding = new Padding(4, 3, 4, 3);
            tabClases.Size = new Size(723, 337);
            tabClases.TabIndex = 0;
            tabClases.Text = "Clases";
            // 
            // scClases
            // 
            scClases.Dock = DockStyle.Fill;
            scClases.Location = new Point(4, 3);
            scClases.Margin = new Padding(4, 3, 4, 3);
            scClases.Name = "scClases";
            // 
            // scClases.Panel1
            // 
            scClases.Panel1.Controls.Add(listBoxClases);
            scClases.Panel1.Padding = new Padding(10, 10, 10, 20);
            // 
            // scClases.Panel2
            // 
            scClases.Panel2.Controls.Add(lateralMenuTorneos);
            scClases.Panel2.Padding = new Padding(10, 10, 10, 20);
            scClases.Size = new Size(715, 331);
            scClases.SplitterDistance = 462;
            scClases.SplitterWidth = 5;
            scClases.TabIndex = 8;
            // 
            // listBoxClases
            // 
            listBoxClases.BackColor = SystemColors.ActiveCaption;
            listBoxClases.BorderStyle = BorderStyle.FixedSingle;
            listBoxClases.Dock = DockStyle.Fill;
            listBoxClases.FormattingEnabled = true;
            listBoxClases.Items.AddRange(new object[] { "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual", "id: js08SnsM5s - tipo: clase - horario: lunes 15 hs - estado: actual" });
            listBoxClases.Location = new Point(10, 10);
            listBoxClases.Name = "listBoxClases";
            listBoxClases.Size = new Size(442, 301);
            listBoxClases.TabIndex = 0;
            listBoxClases.SelectedIndexChanged += listBoxClases_SelectedIndexChanged;
            listBoxClases.MouseDown += listBoxClases_MouseDown;
            // 
            // lateralMenuTorneos
            // 
            lateralMenuTorneos.AutoSize = false;
            lateralMenuTorneos.BackColor = SystemColors.ActiveCaption;
            lateralMenuTorneos.Dock = DockStyle.None;
            lateralMenuTorneos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lateralMenuTorneos.GripMargin = new Padding(2, 2, 2, 5);
            lateralMenuTorneos.GripStyle = ToolStripGripStyle.Hidden;
            lateralMenuTorneos.Items.AddRange(new ToolStripItem[] { toolStripSeparator7, btnRegistrarClase, toolStripSeparator8, btnConsultarClase, toolStripSeparator9, btnModificarClase, toolStripSeparator10, btnInscribirAlumnoClase, toolStripSeparator11, btnAsistenciaClase, toolStripSeparator12, btnReporteAsistenciaClase, toolStripSeparator1, btnBajaAlumnoClase, toolStripSeparator2 });
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
            // btnRegistrarClase
            // 
            btnRegistrarClase.AutoSize = false;
            btnRegistrarClase.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnRegistrarClase.Image = (Image)resources.GetObject("btnRegistrarClase.Image");
            btnRegistrarClase.ImageTransparentColor = Color.Magenta;
            btnRegistrarClase.Name = "btnRegistrarClase";
            btnRegistrarClase.Size = new Size(227, 32);
            btnRegistrarClase.Text = "Nueva clase";
            btnRegistrarClase.Click += btnRegistrarClase_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(227, 6);
            // 
            // btnConsultarClase
            // 
            btnConsultarClase.AutoSize = false;
            btnConsultarClase.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnConsultarClase.Enabled = false;
            btnConsultarClase.Image = (Image)resources.GetObject("btnConsultarClase.Image");
            btnConsultarClase.ImageTransparentColor = Color.Magenta;
            btnConsultarClase.Name = "btnConsultarClase";
            btnConsultarClase.Size = new Size(227, 32);
            btnConsultarClase.Text = "Consultar clase";
            btnConsultarClase.Click += btnConsultarClase_Click;
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(227, 6);
            // 
            // btnModificarClase
            // 
            btnModificarClase.AutoSize = false;
            btnModificarClase.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnModificarClase.Enabled = false;
            btnModificarClase.Image = (Image)resources.GetObject("btnModificarClase.Image");
            btnModificarClase.ImageTransparentColor = Color.Magenta;
            btnModificarClase.Name = "btnModificarClase";
            btnModificarClase.Size = new Size(227, 32);
            btnModificarClase.Text = "Modificar clase";
            btnModificarClase.Click += btnModificarClase_Click;
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new Size(227, 6);
            // 
            // btnInscribirAlumnoClase
            // 
            btnInscribirAlumnoClase.AutoSize = false;
            btnInscribirAlumnoClase.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnInscribirAlumnoClase.Enabled = false;
            btnInscribirAlumnoClase.Image = (Image)resources.GetObject("btnInscribirAlumnoClase.Image");
            btnInscribirAlumnoClase.ImageTransparentColor = Color.Magenta;
            btnInscribirAlumnoClase.Name = "btnInscribirAlumnoClase";
            btnInscribirAlumnoClase.Size = new Size(227, 32);
            btnInscribirAlumnoClase.Text = "Inscribir alumno a clase";
            btnInscribirAlumnoClase.Click += btnInscribirAlumnoClase_Click;
            // 
            // toolStripSeparator11
            // 
            toolStripSeparator11.Name = "toolStripSeparator11";
            toolStripSeparator11.Size = new Size(227, 6);
            // 
            // btnAsistenciaClase
            // 
            btnAsistenciaClase.AutoSize = false;
            btnAsistenciaClase.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAsistenciaClase.Enabled = false;
            btnAsistenciaClase.Image = (Image)resources.GetObject("btnAsistenciaClase.Image");
            btnAsistenciaClase.ImageTransparentColor = Color.Magenta;
            btnAsistenciaClase.Name = "btnAsistenciaClase";
            btnAsistenciaClase.Size = new Size(227, 32);
            btnAsistenciaClase.Text = "Registrar asistencia";
            btnAsistenciaClase.Click += btnAsistenciaClase_Click;
            // 
            // toolStripSeparator12
            // 
            toolStripSeparator12.Name = "toolStripSeparator12";
            toolStripSeparator12.Size = new Size(227, 6);
            // 
            // btnReporteAsistenciaClase
            // 
            btnReporteAsistenciaClase.AutoSize = false;
            btnReporteAsistenciaClase.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnReporteAsistenciaClase.Enabled = false;
            btnReporteAsistenciaClase.Image = (Image)resources.GetObject("btnReporteAsistenciaClase.Image");
            btnReporteAsistenciaClase.ImageTransparentColor = Color.Magenta;
            btnReporteAsistenciaClase.Name = "btnReporteAsistenciaClase";
            btnReporteAsistenciaClase.Size = new Size(227, 32);
            btnReporteAsistenciaClase.Text = "Generar reporte de asistencia";
            btnReporteAsistenciaClase.Click += btnReporteAsistenciaClase_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(227, 6);
            // 
            // btnBajaAlumnoClase
            // 
            btnBajaAlumnoClase.AutoSize = false;
            btnBajaAlumnoClase.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnBajaAlumnoClase.Enabled = false;
            btnBajaAlumnoClase.Image = (Image)resources.GetObject("btnBajaAlumnoClase.Image");
            btnBajaAlumnoClase.ImageTransparentColor = Color.Magenta;
            btnBajaAlumnoClase.Name = "btnBajaAlumnoClase";
            btnBajaAlumnoClase.Size = new Size(227, 32);
            btnBajaAlumnoClase.Text = "Dar de baja alumno";
            btnBajaAlumnoClase.Click += btnBajaAlumnoClase_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(227, 6);
            // 
            // tabEntrenamientos
            // 
            tabEntrenamientos.BackColor = SystemColors.ActiveCaption;
            tabEntrenamientos.Controls.Add(scEntrenamientos);
            tabEntrenamientos.Location = new Point(4, 24);
            tabEntrenamientos.Margin = new Padding(4, 3, 4, 3);
            tabEntrenamientos.Name = "tabEntrenamientos";
            tabEntrenamientos.Padding = new Padding(4, 3, 4, 3);
            tabEntrenamientos.Size = new Size(723, 337);
            tabEntrenamientos.TabIndex = 2;
            tabEntrenamientos.Text = "Entrenamientos";
            // 
            // scEntrenamientos
            // 
            scEntrenamientos.Dock = DockStyle.Fill;
            scEntrenamientos.Location = new Point(4, 3);
            scEntrenamientos.Margin = new Padding(4, 3, 4, 3);
            scEntrenamientos.Name = "scEntrenamientos";
            // 
            // scEntrenamientos.Panel1
            // 
            scEntrenamientos.Panel1.Controls.Add(listBoxEntrenamientos);
            scEntrenamientos.Panel1.Padding = new Padding(10, 10, 10, 20);
            // 
            // scEntrenamientos.Panel2
            // 
            scEntrenamientos.Panel2.Controls.Add(toolStrip1);
            scEntrenamientos.Panel2.Padding = new Padding(10, 10, 10, 20);
            scEntrenamientos.Size = new Size(715, 331);
            scEntrenamientos.SplitterDistance = 462;
            scEntrenamientos.SplitterWidth = 5;
            scEntrenamientos.TabIndex = 7;
            // 
            // listBoxEntrenamientos
            // 
            listBoxEntrenamientos.BackColor = SystemColors.ActiveCaption;
            listBoxEntrenamientos.BorderStyle = BorderStyle.FixedSingle;
            listBoxEntrenamientos.Dock = DockStyle.Fill;
            listBoxEntrenamientos.FormattingEnabled = true;
            listBoxEntrenamientos.Items.AddRange(new object[] { "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro", "id 5SZmoI7ma - tipo: entrenamiento - horario: jueves 9 hs - estado: futuro" });
            listBoxEntrenamientos.Location = new Point(10, 10);
            listBoxEntrenamientos.Name = "listBoxEntrenamientos";
            listBoxEntrenamientos.Size = new Size(442, 301);
            listBoxEntrenamientos.TabIndex = 1;
            listBoxEntrenamientos.SelectedIndexChanged += listBoxEntrenamientos_SelectedIndexChanged;
            listBoxEntrenamientos.MouseDown += listBoxEntrenamientos_MouseDown;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = SystemColors.ActiveCaption;
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStrip1.GripMargin = new Padding(2, 2, 2, 5);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator3, btnRegistrarEntrenamiento, toolStripSeparator4, btnConsultarEntrenamiento, toolStripSeparator5, btnModificarEntrenamiento, toolStripSeparator6, btnInscribirAlumnoEntrenamiento, toolStripSeparator13, btnAsistenciaEntrenamiento, toolStripSeparator14, btnReporteAsistenciaEntrenamiento, toolStripSeparator15, btnBajaAlumnoEntrenamiento, toolStripSeparator16 });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip1.Location = new Point(10, 10);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.RightToLeft = RightToLeft.No;
            toolStrip1.Size = new Size(229, 350);
            toolStrip1.TabIndex = 28;
            toolStrip1.Text = "Menú lateral";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(227, 6);
            // 
            // btnRegistrarEntrenamiento
            // 
            btnRegistrarEntrenamiento.AutoSize = false;
            btnRegistrarEntrenamiento.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnRegistrarEntrenamiento.Image = (Image)resources.GetObject("btnRegistrarEntrenamiento.Image");
            btnRegistrarEntrenamiento.ImageTransparentColor = Color.Magenta;
            btnRegistrarEntrenamiento.Name = "btnRegistrarEntrenamiento";
            btnRegistrarEntrenamiento.Size = new Size(227, 32);
            btnRegistrarEntrenamiento.Text = "Nueva clase";
            btnRegistrarEntrenamiento.Click += btnRegistrarEntrenamiento_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(227, 6);
            // 
            // btnConsultarEntrenamiento
            // 
            btnConsultarEntrenamiento.AutoSize = false;
            btnConsultarEntrenamiento.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnConsultarEntrenamiento.Enabled = false;
            btnConsultarEntrenamiento.Image = (Image)resources.GetObject("btnConsultarEntrenamiento.Image");
            btnConsultarEntrenamiento.ImageTransparentColor = Color.Magenta;
            btnConsultarEntrenamiento.Name = "btnConsultarEntrenamiento";
            btnConsultarEntrenamiento.Size = new Size(227, 32);
            btnConsultarEntrenamiento.Text = "Consultar clase";
            btnConsultarEntrenamiento.Click += btnConsultarEntrenamiento_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(227, 6);
            // 
            // btnModificarEntrenamiento
            // 
            btnModificarEntrenamiento.AutoSize = false;
            btnModificarEntrenamiento.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnModificarEntrenamiento.Enabled = false;
            btnModificarEntrenamiento.Image = (Image)resources.GetObject("btnModificarEntrenamiento.Image");
            btnModificarEntrenamiento.ImageTransparentColor = Color.Magenta;
            btnModificarEntrenamiento.Name = "btnModificarEntrenamiento";
            btnModificarEntrenamiento.Size = new Size(227, 32);
            btnModificarEntrenamiento.Text = "Modificar clase";
            btnModificarEntrenamiento.Click += btnModificarEntrenamiento_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(227, 6);
            // 
            // btnInscribirAlumnoEntrenamiento
            // 
            btnInscribirAlumnoEntrenamiento.AutoSize = false;
            btnInscribirAlumnoEntrenamiento.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnInscribirAlumnoEntrenamiento.Enabled = false;
            btnInscribirAlumnoEntrenamiento.Image = (Image)resources.GetObject("btnInscribirAlumnoEntrenamiento.Image");
            btnInscribirAlumnoEntrenamiento.ImageTransparentColor = Color.Magenta;
            btnInscribirAlumnoEntrenamiento.Name = "btnInscribirAlumnoEntrenamiento";
            btnInscribirAlumnoEntrenamiento.Size = new Size(227, 32);
            btnInscribirAlumnoEntrenamiento.Text = "Inscribir alumno a clase";
            btnInscribirAlumnoEntrenamiento.Click += btnInscribirAlumnoEntrenamiento_Click;
            // 
            // toolStripSeparator13
            // 
            toolStripSeparator13.Name = "toolStripSeparator13";
            toolStripSeparator13.Size = new Size(227, 6);
            // 
            // btnAsistenciaEntrenamiento
            // 
            btnAsistenciaEntrenamiento.AutoSize = false;
            btnAsistenciaEntrenamiento.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAsistenciaEntrenamiento.Enabled = false;
            btnAsistenciaEntrenamiento.Image = (Image)resources.GetObject("btnAsistenciaEntrenamiento.Image");
            btnAsistenciaEntrenamiento.ImageTransparentColor = Color.Magenta;
            btnAsistenciaEntrenamiento.Name = "btnAsistenciaEntrenamiento";
            btnAsistenciaEntrenamiento.Size = new Size(227, 32);
            btnAsistenciaEntrenamiento.Text = "Registrar asistencia";
            btnAsistenciaEntrenamiento.Click += btnAsistenciaEntrenamiento_Click;
            // 
            // toolStripSeparator14
            // 
            toolStripSeparator14.Name = "toolStripSeparator14";
            toolStripSeparator14.Size = new Size(227, 6);
            // 
            // btnReporteAsistenciaEntrenamiento
            // 
            btnReporteAsistenciaEntrenamiento.AutoSize = false;
            btnReporteAsistenciaEntrenamiento.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnReporteAsistenciaEntrenamiento.Enabled = false;
            btnReporteAsistenciaEntrenamiento.Image = (Image)resources.GetObject("btnReporteAsistenciaEntrenamiento.Image");
            btnReporteAsistenciaEntrenamiento.ImageTransparentColor = Color.Magenta;
            btnReporteAsistenciaEntrenamiento.Name = "btnReporteAsistenciaEntrenamiento";
            btnReporteAsistenciaEntrenamiento.Size = new Size(227, 32);
            btnReporteAsistenciaEntrenamiento.Text = "Generar reporte de asistencia";
            btnReporteAsistenciaEntrenamiento.Click += btnReporteAsistenciaEntrenamiento_Click;
            // 
            // toolStripSeparator15
            // 
            toolStripSeparator15.Name = "toolStripSeparator15";
            toolStripSeparator15.Size = new Size(227, 6);
            // 
            // btnBajaAlumnoEntrenamiento
            // 
            btnBajaAlumnoEntrenamiento.AutoSize = false;
            btnBajaAlumnoEntrenamiento.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnBajaAlumnoEntrenamiento.Enabled = false;
            btnBajaAlumnoEntrenamiento.Image = (Image)resources.GetObject("btnBajaAlumnoEntrenamiento.Image");
            btnBajaAlumnoEntrenamiento.ImageTransparentColor = Color.Magenta;
            btnBajaAlumnoEntrenamiento.Name = "btnBajaAlumnoEntrenamiento";
            btnBajaAlumnoEntrenamiento.Size = new Size(227, 32);
            btnBajaAlumnoEntrenamiento.Text = "Dar de baja alumno";
            btnBajaAlumnoEntrenamiento.Click += btnBajaAlumnoEntrenamiento_Click;
            // 
            // toolStripSeparator16
            // 
            toolStripSeparator16.Name = "toolStripSeparator16";
            toolStripSeparator16.Size = new Size(227, 6);
            // 
            // cbFiltrado
            // 
            cbFiltrado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltrado.FormattingEnabled = true;
            cbFiltrado.Items.AddRange(new object[] { "Profesor", "Alumno" });
            cbFiltrado.Location = new Point(339, 6);
            cbFiltrado.Margin = new Padding(4, 3, 4, 3);
            cbFiltrado.Name = "cbFiltrado";
            cbFiltrado.Size = new Size(98, 23);
            cbFiltrado.TabIndex = 10;
            // 
            // cbEstado
            // 
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "Todos", "Actuales", "Pasados", "Futuros" });
            cbEstado.Location = new Point(261, 6);
            cbEstado.Margin = new Padding(4, 3, 4, 3);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(70, 23);
            cbEstado.TabIndex = 11;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(444, 6);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(174, 23);
            txtBusqueda.TabIndex = 17;
            // 
            // lblFiltrado
            // 
            lblFiltrado.AutoSize = true;
            lblFiltrado.Location = new Point(189, 10);
            lblFiltrado.Name = "lblFiltrado";
            lblFiltrado.Size = new Size(65, 15);
            lblFiltrado.TabIndex = 18;
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
            // ucCapacitaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(btnBuscar);
            Controls.Add(lblFiltrado);
            Controls.Add(txtBusqueda);
            Controls.Add(cbEstado);
            Controls.Add(cbFiltrado);
            Controls.Add(tcCapacitaciones);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ucCapacitaciones";
            Size = new Size(723, 421);
            Click += ucCapacitaciones_Click;
            tcCapacitaciones.ResumeLayout(false);
            tabClases.ResumeLayout(false);
            scClases.Panel1.ResumeLayout(false);
            scClases.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scClases).EndInit();
            scClases.ResumeLayout(false);
            lateralMenuTorneos.ResumeLayout(false);
            lateralMenuTorneos.PerformLayout();
            tabEntrenamientos.ResumeLayout(false);
            scEntrenamientos.Panel1.ResumeLayout(false);
            scEntrenamientos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scEntrenamientos).EndInit();
            scEntrenamientos.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcCapacitaciones;
        private System.Windows.Forms.TabPage tabClases;
        private System.Windows.Forms.TabPage tabEntrenamientos;
        private System.Windows.Forms.ComboBox cbFiltrado;
        private System.Windows.Forms.SplitContainer scEntrenamientos;
        private SplitContainer scClases;
        private ComboBox cbEstado;
        private ListBox listBoxClases;
        private ListBox listBoxEntrenamientos;
        private TextBox txtBusqueda;
        private Label lblFiltrado;
        private ToolStrip lateralMenuTorneos;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton btnRegistrarClase;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton btnConsultarClase;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripButton btnModificarClase;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripButton btnInscribirAlumnoClase;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripButton btnAsistenciaClase;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripButton btnReporteAsistenciaClase;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnBajaAlumnoClase;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnRegistrarEntrenamiento;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnConsultarEntrenamiento;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton btnModificarEntrenamiento;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton btnInscribirAlumnoEntrenamiento;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripButton btnAsistenciaEntrenamiento;
        private ToolStripSeparator toolStripSeparator14;
        private ToolStripButton btnReporteAsistenciaEntrenamiento;
        private ToolStripSeparator toolStripSeparator15;
        private ToolStripButton btnBajaAlumnoEntrenamiento;
        private ToolStripSeparator toolStripSeparator16;
        private Button btnBuscar;
    }
}
