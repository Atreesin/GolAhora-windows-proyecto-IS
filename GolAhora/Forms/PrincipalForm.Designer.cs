using GolAhora.Forms;
using GolAhora.Forms.UserControls;

namespace GolAhora.Forms
{
    partial class PrincipalForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            panelContenedor = new Panel();
            topMenu = new ToolStrip();
            btnAyuda = new ToolStripDropDownButton();
            sobreNosotrosToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            lateralMenu = new ToolStrip();
            btnUsuarios = new ToolStripButton();
            btnReservas = new ToolStripButton();
            btnDescuentos = new ToolStripButton();
            btnCanchas = new ToolStripButton();
            btnCapacitaciones = new ToolStripButton();
            btnCompetencias = new ToolStripButton();
            btnCobros = new ToolStripButton();
            btnRecibos = new ToolStripButton();
            btnReportes = new ToolStripButton();
            statusStrip = new StatusStrip();
            imageListLateralMenu = new ImageList(components);
            topMenu.SuspendLayout();
            lateralMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BorderStyle = BorderStyle.Fixed3D;
            panelContenedor.Location = new Point(151, 44);
            panelContenedor.Margin = new Padding(4, 3, 4, 3);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(723, 421);
            panelContenedor.TabIndex = 1;
            // 
            // topMenu
            // 
            topMenu.AutoSize = false;
            topMenu.BackColor = SystemColors.ActiveCaption;
            topMenu.Dock = DockStyle.None;
            topMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            topMenu.GripStyle = ToolStripGripStyle.Hidden;
            topMenu.Items.AddRange(new ToolStripItem[] { btnAyuda });
            topMenu.Location = new Point(0, 0);
            topMenu.Name = "topMenu";
            topMenu.RenderMode = ToolStripRenderMode.System;
            topMenu.Size = new Size(874, 31);
            topMenu.TabIndex = 5;
            topMenu.Text = "Panel de herramientas";
            // 
            // btnAyuda
            // 
            btnAyuda.Alignment = ToolStripItemAlignment.Right;
            btnAyuda.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAyuda.DropDownItems.AddRange(new ToolStripItem[] { sobreNosotrosToolStripMenuItem, toolStripMenuItem2 });
            btnAyuda.Image = (Image)resources.GetObject("btnAyuda.Image");
            btnAyuda.ImageTransparentColor = Color.Magenta;
            btnAyuda.Name = "btnAyuda";
            btnAyuda.RightToLeft = RightToLeft.Yes;
            btnAyuda.RightToLeftAutoMirrorImage = true;
            btnAyuda.Size = new Size(54, 28);
            btnAyuda.Text = "Ayuda";
            // 
            // sobreNosotrosToolStripMenuItem
            // 
            sobreNosotrosToolStripMenuItem.Name = "sobreNosotrosToolStripMenuItem";
            sobreNosotrosToolStripMenuItem.RightToLeft = RightToLeft.No;
            sobreNosotrosToolStripMenuItem.Size = new Size(180, 22);
            sobreNosotrosToolStripMenuItem.Text = "Sobre nosotros";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.RightToLeft = RightToLeft.No;
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "Ir a nuestra web";
            // 
            // lateralMenu
            // 
            lateralMenu.AutoSize = false;
            lateralMenu.BackColor = SystemColors.ActiveCaption;
            lateralMenu.Dock = DockStyle.None;
            lateralMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lateralMenu.GripMargin = new Padding(2, 2, 2, 5);
            lateralMenu.GripStyle = ToolStripGripStyle.Hidden;
            lateralMenu.Items.AddRange(new ToolStripItem[] { btnUsuarios, btnReservas, btnDescuentos, btnCanchas, btnCapacitaciones, btnCompetencias, btnCobros, btnRecibos, btnReportes });
            lateralMenu.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            lateralMenu.Location = new Point(9, 44);
            lateralMenu.Name = "lateralMenu";
            lateralMenu.RenderMode = ToolStripRenderMode.System;
            lateralMenu.RightToLeft = RightToLeft.No;
            lateralMenu.Size = new Size(134, 421);
            lateralMenu.TabIndex = 6;
            lateralMenu.Text = "Menú lateral";
            // 
            // btnUsuarios
            // 
            btnUsuarios.AutoSize = false;
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.ImageTransparentColor = Color.Magenta;
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(125, 35);
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnReservas
            // 
            btnReservas.AutoSize = false;
            btnReservas.Image = (Image)resources.GetObject("btnReservas.Image");
            btnReservas.ImageAlign = ContentAlignment.MiddleLeft;
            btnReservas.ImageTransparentColor = Color.Magenta;
            btnReservas.Name = "btnReservas";
            btnReservas.Size = new Size(125, 35);
            btnReservas.Text = " Reservas";
            btnReservas.Click += btnReservas_Click;
            // 
            // btnDescuentos
            // 
            btnDescuentos.AutoSize = false;
            btnDescuentos.Image = (Image)resources.GetObject("btnDescuentos.Image");
            btnDescuentos.ImageAlign = ContentAlignment.MiddleLeft;
            btnDescuentos.ImageTransparentColor = Color.Magenta;
            btnDescuentos.Name = "btnDescuentos";
            btnDescuentos.Size = new Size(125, 35);
            btnDescuentos.Text = "Descuentos";
            btnDescuentos.Click += btnDescuentos_Click;
            // 
            // btnCanchas
            // 
            btnCanchas.AutoSize = false;
            btnCanchas.Image = (Image)resources.GetObject("btnCanchas.Image");
            btnCanchas.ImageAlign = ContentAlignment.MiddleLeft;
            btnCanchas.ImageTransparentColor = Color.Magenta;
            btnCanchas.Name = "btnCanchas";
            btnCanchas.Size = new Size(125, 35);
            btnCanchas.Text = "Canchas";
            btnCanchas.Click += btnCanchas_Click;
            // 
            // btnCapacitaciones
            // 
            btnCapacitaciones.AutoSize = false;
            btnCapacitaciones.Image = (Image)resources.GetObject("btnCapacitaciones.Image");
            btnCapacitaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnCapacitaciones.ImageTransparentColor = Color.Magenta;
            btnCapacitaciones.Name = "btnCapacitaciones";
            btnCapacitaciones.Size = new Size(125, 35);
            btnCapacitaciones.Text = "Capacitaciones";
            btnCapacitaciones.Click += btnCapacitaciones_Click;
            // 
            // btnCompetencias
            // 
            btnCompetencias.AutoSize = false;
            btnCompetencias.Image = (Image)resources.GetObject("btnCompetencias.Image");
            btnCompetencias.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompetencias.ImageTransparentColor = Color.Magenta;
            btnCompetencias.Name = "btnCompetencias";
            btnCompetencias.Size = new Size(125, 35);
            btnCompetencias.Text = "Competencias";
            btnCompetencias.Click += btnCompetencias_Click;
            // 
            // btnCobros
            // 
            btnCobros.AutoSize = false;
            btnCobros.Image = (Image)resources.GetObject("btnCobros.Image");
            btnCobros.ImageAlign = ContentAlignment.MiddleLeft;
            btnCobros.ImageTransparentColor = Color.Magenta;
            btnCobros.Name = "btnCobros";
            btnCobros.Size = new Size(125, 35);
            btnCobros.Text = "Cobros";
            btnCobros.Click += btnCobros_Click;
            // 
            // btnRecibos
            // 
            btnRecibos.AutoSize = false;
            btnRecibos.Image = (Image)resources.GetObject("btnRecibos.Image");
            btnRecibos.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecibos.ImageTransparentColor = Color.Magenta;
            btnRecibos.Name = "btnRecibos";
            btnRecibos.Size = new Size(125, 35);
            btnRecibos.Text = "Recibos";
            btnRecibos.Click += btnRecibos_Click;
            // 
            // btnReportes
            // 
            btnReportes.AutoSize = false;
            btnReportes.Image = (Image)resources.GetObject("btnReportes.Image");
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.ImageTransparentColor = Color.Magenta;
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(125, 35);
            btnReportes.Text = "Reportes";
            btnReportes.Click += btnReportes_Click;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = SystemColors.ActiveCaption;
            statusStrip.Location = new Point(0, 479);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(899, 22);
            statusStrip.TabIndex = 7;
            // 
            // imageListLateralMenu
            // 
            imageListLateralMenu.ColorDepth = ColorDepth.Depth8Bit;
            imageListLateralMenu.ImageStream = (ImageListStreamer)resources.GetObject("imageListLateralMenu.ImageStream");
            imageListLateralMenu.TransparentColor = Color.Transparent;
            imageListLateralMenu.Images.SetKeyName(0, "home.png");
            imageListLateralMenu.Images.SetKeyName(1, "next.png");
            imageListLateralMenu.Images.SetKeyName(2, "back-button.png");
            // 
            // PrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(899, 501);
            Controls.Add(statusStrip);
            Controls.Add(lateralMenu);
            Controls.Add(topMenu);
            Controls.Add(panelContenedor);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(915, 540);
            MinimumSize = new Size(915, 540);
            Name = "PrincipalForm";
            Text = "Gol Ahora - Panel Principal";
            FormClosing += PrincipalForm_FormClosing;
            FormClosed += PrincipalForm_FormClosed;
            topMenu.ResumeLayout(false);
            topMenu.PerformLayout();
            lateralMenu.ResumeLayout(false);
            lateralMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.ToolStrip topMenu;
        private System.Windows.Forms.ToolStrip lateralMenu;
        private System.Windows.Forms.ToolStripButton btnReservas;
        private System.Windows.Forms.ToolStripButton btnCanchas;
        private System.Windows.Forms.ToolStripButton btnUsuarios;
        private System.Windows.Forms.ToolStripButton btnCapacitaciones;
        private System.Windows.Forms.ToolStripButton btnCompetencias;
        private System.Windows.Forms.ToolStripButton btnDescuentos;
        private System.Windows.Forms.ToolStripDropDownButton btnAyuda;
        private System.Windows.Forms.ToolStripMenuItem sobreNosotrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ImageList imageListLateralMenu;
        private System.Windows.Forms.ToolStripButton btnCobros;
        private System.Windows.Forms.ToolStripButton btnRecibos;
        private System.Windows.Forms.ToolStripButton btnReportes;
    }
}

