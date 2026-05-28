namespace GolAhora.Forms.UserControls
{
    partial class ucReportes
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
            cbFiltrado = new ComboBox();
            lateralMenu = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            btnCanchas = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnIngresos = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btnReservas = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnAsistenciaClase = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            btnAsistenciaEntrenamiento = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            listBoxReportes = new ListBox();
            scReportes = new SplitContainer();
            txtBusqueda = new TextBox();
            lblFiltro = new Label();
            btnBuscar = new Button();
            lateralMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scReportes).BeginInit();
            scReportes.Panel1.SuspendLayout();
            scReportes.Panel2.SuspendLayout();
            scReportes.SuspendLayout();
            SuspendLayout();
            // 
            // cbFiltrado
            // 
            cbFiltrado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltrado.FormattingEnabled = true;
            cbFiltrado.Items.AddRange(new object[] { "Todos los reportes", "Tipos de cancha", "Ingresos", "Reservas de cancha", "Asistencia a clases", "Asistencia a entrenamientos" });
            cbFiltrado.Location = new Point(249, 6);
            cbFiltrado.Margin = new Padding(4, 3, 4, 3);
            cbFiltrado.Name = "cbFiltrado";
            cbFiltrado.Size = new Size(188, 23);
            cbFiltrado.TabIndex = 22;
            cbFiltrado.SelectedIndexChanged += cbFiltrado_SelectedIndexChanged;
            // 
            // lateralMenu
            // 
            lateralMenu.AutoSize = false;
            lateralMenu.BackColor = SystemColors.ActiveCaption;
            lateralMenu.Dock = DockStyle.None;
            lateralMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lateralMenu.GripMargin = new Padding(2, 2, 2, 5);
            lateralMenu.GripStyle = ToolStripGripStyle.Hidden;
            lateralMenu.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, btnCanchas, toolStripSeparator2, btnIngresos, toolStripSeparator4, btnReservas, toolStripSeparator3, btnAsistenciaClase, toolStripSeparator5, btnAsistenciaEntrenamiento, toolStripSeparator6 });
            lateralMenu.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            lateralMenu.Location = new Point(1, 11);
            lateralMenu.Name = "lateralMenu";
            lateralMenu.RenderMode = ToolStripRenderMode.System;
            lateralMenu.RightToLeft = RightToLeft.No;
            lateralMenu.Size = new Size(279, 339);
            lateralMenu.TabIndex = 24;
            lateralMenu.Text = "Menú lateral";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(277, 6);
            // 
            // btnCanchas
            // 
            btnCanchas.AutoSize = false;
            btnCanchas.ImageAlign = ContentAlignment.MiddleLeft;
            btnCanchas.ImageTransparentColor = Color.Magenta;
            btnCanchas.Name = "btnCanchas";
            btnCanchas.Size = new Size(277, 48);
            btnCanchas.Text = "Generar reporte de tipos de cancha";
            btnCanchas.Click += btnCanchas_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(277, 6);
            // 
            // btnIngresos
            // 
            btnIngresos.AutoSize = false;
            btnIngresos.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresos.ImageTransparentColor = Color.Magenta;
            btnIngresos.Name = "btnIngresos";
            btnIngresos.Size = new Size(277, 48);
            btnIngresos.Text = "Generar reporte de ingresos";
            btnIngresos.Click += btnIngresos_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(277, 6);
            // 
            // btnReservas
            // 
            btnReservas.AutoSize = false;
            btnReservas.ImageAlign = ContentAlignment.MiddleLeft;
            btnReservas.ImageTransparentColor = Color.Magenta;
            btnReservas.Name = "btnReservas";
            btnReservas.Size = new Size(278, 49);
            btnReservas.Text = "Generar reportes de reservas de cancha";
            btnReservas.Click += btnReservas_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(277, 6);
            // 
            // btnAsistenciaClase
            // 
            btnAsistenciaClase.AutoSize = false;
            btnAsistenciaClase.ImageAlign = ContentAlignment.MiddleLeft;
            btnAsistenciaClase.ImageTransparentColor = Color.Magenta;
            btnAsistenciaClase.Name = "btnAsistenciaClase";
            btnAsistenciaClase.Size = new Size(278, 48);
            btnAsistenciaClase.Text = "Generar reporte de asistencias a clases";
            btnAsistenciaClase.Click += btnAsistenciaClase_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(277, 6);
            // 
            // btnAsistenciaEntrenamiento
            // 
            btnAsistenciaEntrenamiento.AutoSize = false;
            btnAsistenciaEntrenamiento.ImageAlign = ContentAlignment.MiddleLeft;
            btnAsistenciaEntrenamiento.ImageTransparentColor = Color.Magenta;
            btnAsistenciaEntrenamiento.Name = "btnAsistenciaEntrenamiento";
            btnAsistenciaEntrenamiento.Size = new Size(278, 48);
            btnAsistenciaEntrenamiento.Text = "Generar reporte de asistencias a entrenamientos";
            btnAsistenciaEntrenamiento.Click += btnAsistenciaEntrenamiento_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(277, 6);
            // 
            // listBoxReportes
            // 
            listBoxReportes.BackColor = SystemColors.ActiveCaption;
            listBoxReportes.BorderStyle = BorderStyle.FixedSingle;
            listBoxReportes.Dock = DockStyle.Fill;
            listBoxReportes.FormattingEnabled = true;
            listBoxReportes.Location = new Point(10, 10);
            listBoxReportes.Name = "listBoxReportes";
            listBoxReportes.Size = new Size(411, 301);
            listBoxReportes.TabIndex = 23;
            // 
            // scReportes
            // 
            scReportes.Location = new Point(4, 87);
            scReportes.Name = "scReportes";
            // 
            // scReportes.Panel1
            // 
            scReportes.Panel1.Controls.Add(listBoxReportes);
            scReportes.Panel1.Padding = new Padding(10, 10, 10, 20);
            // 
            // scReportes.Panel2
            // 
            scReportes.Panel2.Controls.Add(lateralMenu);
            scReportes.Panel2.Padding = new Padding(10, 10, 10, 20);
            scReportes.Size = new Size(715, 331);
            scReportes.SplitterDistance = 431;
            scReportes.TabIndex = 25;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(444, 6);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(174, 23);
            txtBusqueda.TabIndex = 26;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(176, 10);
            lblFiltro.Margin = new Padding(4, 0, 4, 0);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(65, 15);
            lblFiltro.TabIndex = 34;
            lblFiltro.Text = "Filtrar por:";
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
            btnBuscar.Click += btnBuscar_Click;
            // 
            // ucReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(btnBuscar);
            Controls.Add(lblFiltro);
            Controls.Add(txtBusqueda);
            Controls.Add(cbFiltrado);
            Controls.Add(scReportes);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ucReportes";
            Size = new Size(723, 421);
            lateralMenu.ResumeLayout(false);
            lateralMenu.PerformLayout();
            scReportes.Panel1.ResumeLayout(false);
            scReportes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scReportes).EndInit();
            scReportes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private ComboBox cbFiltrado;
        private ToolStrip lateralMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnCanchas;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnIngresos;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnReservas;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnAsistenciaClase;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton btnAsistenciaEntrenamiento;
        private ToolStripSeparator toolStripSeparator6;
        private ListBox listBoxReportes;
        private SplitContainer scReportes;
        private TextBox txtBusqueda;
        private Label lblFiltro;
        private Button btnBuscar;
    }
}
