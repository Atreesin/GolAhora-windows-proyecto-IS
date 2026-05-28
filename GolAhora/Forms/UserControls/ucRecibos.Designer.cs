namespace GolAhora.Forms.UserControls
{
    partial class ucRecibos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRecibos));
            txtBusqueda = new TextBox();
            scRecibos = new SplitContainer();
            listBoxRecibos = new ListBox();
            lateralMenu = new ToolStrip();
            toolStripSeparator4 = new ToolStripSeparator();
            btnRegistrar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnConsultar = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            btnImprimir = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnModificar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnEliminar = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            btnBuscar = new Button();
            lblFiltro = new Label();
            cbFiltrado = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)scRecibos).BeginInit();
            scRecibos.Panel1.SuspendLayout();
            scRecibos.Panel2.SuspendLayout();
            scRecibos.SuspendLayout();
            lateralMenu.SuspendLayout();
            SuspendLayout();
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(444, 6);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(174, 23);
            txtBusqueda.TabIndex = 36;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // scRecibos
            // 
            scRecibos.Location = new Point(4, 87);
            scRecibos.Name = "scRecibos";
            // 
            // scRecibos.Panel1
            // 
            scRecibos.Panel1.Controls.Add(listBoxRecibos);
            scRecibos.Panel1.Padding = new Padding(10, 10, 10, 20);
            // 
            // scRecibos.Panel2
            // 
            scRecibos.Panel2.Controls.Add(lateralMenu);
            scRecibos.Panel2.Padding = new Padding(10, 10, 10, 20);
            scRecibos.Size = new Size(715, 331);
            scRecibos.SplitterDistance = 458;
            scRecibos.TabIndex = 35;
            // 
            // listBoxRecibos
            // 
            listBoxRecibos.BackColor = SystemColors.ActiveCaption;
            listBoxRecibos.BorderStyle = BorderStyle.FixedSingle;
            listBoxRecibos.Dock = DockStyle.Fill;
            listBoxRecibos.FormattingEnabled = true;
            listBoxRecibos.Location = new Point(10, 10);
            listBoxRecibos.Name = "listBoxRecibos";
            listBoxRecibos.Size = new Size(438, 301);
            listBoxRecibos.TabIndex = 21;
            listBoxRecibos.SelectedIndexChanged += listBoxRecibos_SelectedIndexChanged;
            listBoxRecibos.MouseDown += listBoxRecibos_MouseDown;
            // 
            // lateralMenu
            // 
            lateralMenu.AutoSize = false;
            lateralMenu.BackColor = SystemColors.ActiveCaption;
            lateralMenu.Dock = DockStyle.None;
            lateralMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lateralMenu.GripMargin = new Padding(2, 2, 2, 5);
            lateralMenu.GripStyle = ToolStripGripStyle.Hidden;
            lateralMenu.Items.AddRange(new ToolStripItem[] { toolStripSeparator4, btnRegistrar, toolStripSeparator1, btnConsultar, toolStripSeparator5, btnImprimir, toolStripSeparator2, btnModificar, toolStripSeparator3, btnEliminar, toolStripSeparator6 });
            lateralMenu.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            lateralMenu.Location = new Point(10, 10);
            lateralMenu.Name = "lateralMenu";
            lateralMenu.RenderMode = ToolStripRenderMode.System;
            lateralMenu.RightToLeft = RightToLeft.No;
            lateralMenu.Size = new Size(233, 339);
            lateralMenu.TabIndex = 23;
            lateralMenu.Text = "Menú lateral";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(231, 6);
            // 
            // btnRegistrar
            // 
            btnRegistrar.AutoSize = false;
            btnRegistrar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnRegistrar.Image = (Image)resources.GetObject("btnRegistrar.Image");
            btnRegistrar.ImageTransparentColor = Color.Magenta;
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(231, 48);
            btnRegistrar.Text = "Nuevo Recibo";
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(231, 6);
            // 
            // btnConsultar
            // 
            btnConsultar.AutoSize = false;
            btnConsultar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnConsultar.Enabled = false;
            btnConsultar.Image = (Image)resources.GetObject("btnConsultar.Image");
            btnConsultar.ImageTransparentColor = Color.Magenta;
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(231, 48);
            btnConsultar.Text = "Consultar recibo";
            btnConsultar.Click += btnConsultar_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(231, 6);
            // 
            // btnImprimir
            // 
            btnImprimir.AutoSize = false;
            btnImprimir.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnImprimir.Enabled = false;
            btnImprimir.Image = (Image)resources.GetObject("btnImprimir.Image");
            btnImprimir.ImageTransparentColor = Color.Magenta;
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(231, 48);
            btnImprimir.Text = "Imprimir recibo";
            btnImprimir.Click += btnImprimir_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(231, 6);
            // 
            // btnModificar
            // 
            btnModificar.AutoSize = false;
            btnModificar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnModificar.Enabled = false;
            btnModificar.Image = (Image)resources.GetObject("btnModificar.Image");
            btnModificar.ImageTransparentColor = Color.Magenta;
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(231, 48);
            btnModificar.Text = "Modificar recibo";
            btnModificar.Click += btnModificar_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(231, 6);
            // 
            // btnEliminar
            // 
            btnEliminar.AccessibleRole = AccessibleRole.Alert;
            btnEliminar.AutoSize = false;
            btnEliminar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnEliminar.Enabled = false;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageTransparentColor = Color.Magenta;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(231, 48);
            btnEliminar.Text = "Eliminar Recibo";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(231, 6);
            // 
            // btnBuscar
            // 
            btnBuscar.Enabled = false;
            btnBuscar.Location = new Point(624, 6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 34;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(229, 9);
            lblFiltro.Margin = new Padding(4, 0, 4, 0);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(65, 15);
            lblFiltro.TabIndex = 33;
            lblFiltro.Text = "Filtrar por:";
            // 
            // cbFiltrado
            // 
            cbFiltrado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltrado.FormattingEnabled = true;
            cbFiltrado.Items.AddRange(new object[] { "Usuario", "Cancha" });
            cbFiltrado.Location = new Point(302, 6);
            cbFiltrado.Margin = new Padding(4, 3, 4, 3);
            cbFiltrado.Name = "cbFiltrado";
            cbFiltrado.Size = new Size(135, 23);
            cbFiltrado.TabIndex = 32;
            cbFiltrado.SelectedIndexChanged += cbFiltrado_SelectedIndexChanged;
            // 
            // ucRecibos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(txtBusqueda);
            Controls.Add(scRecibos);
            Controls.Add(btnBuscar);
            Controls.Add(lblFiltro);
            Controls.Add(cbFiltrado);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ucRecibos";
            Size = new Size(723, 421);
            Click += ucRecibos_Click;
            scRecibos.Panel1.ResumeLayout(false);
            scRecibos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scRecibos).EndInit();
            scRecibos.ResumeLayout(false);
            lateralMenu.ResumeLayout(false);
            lateralMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox txtBusqueda;
        private SplitContainer scRecibos;
        private ListBox listBoxRecibos;
        private ToolStrip lateralMenu;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnRegistrar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnConsultar;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton btnImprimir;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnModificar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnEliminar;
        private ToolStripSeparator toolStripSeparator6;
        private Button btnBuscar;
        private Label lblFiltro;
        private ComboBox cbFiltrado;
    }
}
