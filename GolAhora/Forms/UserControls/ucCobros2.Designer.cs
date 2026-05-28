namespace GolAhora.Forms.UserControls
{
    partial class ucCobros2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCobros2));
            txtBusqueda = new TextBox();
            scCobros = new SplitContainer();
            listBoxCobros = new ListBox();
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
            btnCancelar = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            btnBuscar = new Button();
            lblFiltro = new Label();
            cbFiltrado = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)scCobros).BeginInit();
            scCobros.Panel1.SuspendLayout();
            scCobros.Panel2.SuspendLayout();
            scCobros.SuspendLayout();
            lateralMenu.SuspendLayout();
            SuspendLayout();
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(444, 6);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(174, 23);
            txtBusqueda.TabIndex = 31;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // scCobros
            // 
            scCobros.Location = new Point(4, 87);
            scCobros.Name = "scCobros";
            // 
            // scCobros.Panel1
            // 
            scCobros.Panel1.Controls.Add(listBoxCobros);
            scCobros.Panel1.Padding = new Padding(10, 10, 10, 20);
            // 
            // scCobros.Panel2
            // 
            scCobros.Panel2.Controls.Add(lateralMenu);
            scCobros.Panel2.Padding = new Padding(10, 10, 10, 20);
            scCobros.Size = new Size(715, 331);
            scCobros.SplitterDistance = 458;
            scCobros.TabIndex = 30;
            // 
            // listBoxCobros
            // 
            listBoxCobros.BackColor = SystemColors.ActiveCaption;
            listBoxCobros.BorderStyle = BorderStyle.FixedSingle;
            listBoxCobros.Dock = DockStyle.Fill;
            listBoxCobros.FormattingEnabled = true;
            listBoxCobros.Location = new Point(10, 10);
            listBoxCobros.Name = "listBoxCobros";
            listBoxCobros.Size = new Size(438, 301);
            listBoxCobros.TabIndex = 21;
            listBoxCobros.SelectedIndexChanged += listBoxCobros_SelectedIndexChanged;
            listBoxCobros.MouseDown += listBoxCobros_MouseDown;
            // 
            // lateralMenu
            // 
            lateralMenu.AutoSize = false;
            lateralMenu.BackColor = SystemColors.ActiveCaption;
            lateralMenu.Dock = DockStyle.None;
            lateralMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lateralMenu.GripMargin = new Padding(2, 2, 2, 5);
            lateralMenu.GripStyle = ToolStripGripStyle.Hidden;
            lateralMenu.Items.AddRange(new ToolStripItem[] { toolStripSeparator4, btnRegistrar, toolStripSeparator1, btnConsultar, toolStripSeparator5, btnImprimir, toolStripSeparator2, btnModificar, toolStripSeparator3, btnCancelar, toolStripSeparator6 });
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
            btnRegistrar.Text = "Nuevo cobro";
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
            btnConsultar.Text = "Consultar cobro";
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
            btnImprimir.Text = "Imprimir cobro";
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
            btnModificar.Text = "Modificar cobro";
            btnModificar.Click += btnModificar_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(231, 6);
            // 
            // btnCancelar
            // 
            btnCancelar.AccessibleRole = AccessibleRole.Alert;
            btnCancelar.AutoSize = false;
            btnCancelar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCancelar.Enabled = false;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageTransparentColor = Color.Magenta;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(231, 48);
            btnCancelar.Text = "Cancelar cobro";
            btnCancelar.Click += btnCancelar_Click;
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
            btnBuscar.TabIndex = 29;
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
            lblFiltro.TabIndex = 28;
            lblFiltro.Text = "Filtrar por:";
            // 
            // cbFiltrado
            // 
            cbFiltrado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltrado.FormattingEnabled = true;
            cbFiltrado.Items.AddRange(new object[] { "Usuario", "Cancha", "Clase", "Entrenamiento" });
            cbFiltrado.Location = new Point(302, 6);
            cbFiltrado.Margin = new Padding(4, 3, 4, 3);
            cbFiltrado.Name = "cbFiltrado";
            cbFiltrado.Size = new Size(135, 23);
            cbFiltrado.TabIndex = 27;
            cbFiltrado.SelectedIndexChanged += cbFiltrado_SelectedIndexChanged;
            // 
            // ucCobros2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(txtBusqueda);
            Controls.Add(scCobros);
            Controls.Add(btnBuscar);
            Controls.Add(lblFiltro);
            Controls.Add(cbFiltrado);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "ucCobros2";
            Size = new Size(723, 421);
            Click += ucCobros2_Click;
            scCobros.Panel1.ResumeLayout(false);
            scCobros.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scCobros).EndInit();
            scCobros.ResumeLayout(false);
            lateralMenu.ResumeLayout(false);
            lateralMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBusqueda;
        private SplitContainer scCobros;
        private ListBox listBoxCobros;
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
        private Button btnBuscar;
        private Label lblFiltro;
        private ComboBox cbFiltrado;
        private ToolStripButton btnCancelar;
        private ToolStripSeparator toolStripSeparator6;
    }
}
