namespace GolAhora.Forms.UserControls
{
    partial class ucLobby
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLobby));
            scInicioPanel = new SplitContainer();
            lblClubInfo = new Label();
            scAdmin = new SplitContainer();
            iconLabel = new Label();
            iconImageList = new ImageList(components);
            lblAdminInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)scInicioPanel).BeginInit();
            scInicioPanel.Panel1.SuspendLayout();
            scInicioPanel.Panel2.SuspendLayout();
            scInicioPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scAdmin).BeginInit();
            scAdmin.Panel1.SuspendLayout();
            scAdmin.Panel2.SuspendLayout();
            scAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // scInicioPanel
            // 
            scInicioPanel.BorderStyle = BorderStyle.FixedSingle;
            scInicioPanel.Dock = DockStyle.Fill;
            scInicioPanel.IsSplitterFixed = true;
            scInicioPanel.Location = new Point(10, 10);
            scInicioPanel.Name = "scInicioPanel";
            // 
            // scInicioPanel.Panel1
            // 
            scInicioPanel.Panel1.Controls.Add(lblClubInfo);
            scInicioPanel.Panel1.Padding = new Padding(10, 20, 10, 20);
            // 
            // scInicioPanel.Panel2
            // 
            scInicioPanel.Panel2.Controls.Add(scAdmin);
            scInicioPanel.Size = new Size(703, 401);
            scInicioPanel.SplitterDistance = 422;
            scInicioPanel.SplitterWidth = 10;
            scInicioPanel.TabIndex = 1;
            scInicioPanel.TabStop = false;
            // 
            // lblClubInfo
            // 
            lblClubInfo.Dock = DockStyle.Fill;
            lblClubInfo.Location = new Point(10, 20);
            lblClubInfo.Name = "lblClubInfo";
            lblClubInfo.Size = new Size(400, 359);
            lblClubInfo.TabIndex = 1;
            lblClubInfo.Text = resources.GetString("lblClubInfo.Text");
            // 
            // scAdmin
            // 
            scAdmin.Dock = DockStyle.Fill;
            scAdmin.Location = new Point(0, 0);
            scAdmin.Name = "scAdmin";
            scAdmin.Orientation = Orientation.Horizontal;
            // 
            // scAdmin.Panel1
            // 
            scAdmin.Panel1.Controls.Add(iconLabel);
            scAdmin.Panel1.Padding = new Padding(10, 20, 10, 10);
            scAdmin.Panel1.RightToLeft = RightToLeft.No;
            // 
            // scAdmin.Panel2
            // 
            scAdmin.Panel2.Controls.Add(lblAdminInfo);
            scAdmin.Panel2.Padding = new Padding(10, 10, 10, 20);
            scAdmin.Panel2.RightToLeft = RightToLeft.No;
            scAdmin.RightToLeft = RightToLeft.No;
            scAdmin.Size = new Size(269, 399);
            scAdmin.SplitterDistance = 234;
            scAdmin.TabIndex = 0;
            scAdmin.TabStop = false;
            // 
            // iconLabel
            // 
            iconLabel.Dock = DockStyle.Fill;
            iconLabel.ImageAlign = ContentAlignment.BottomCenter;
            iconLabel.ImageIndex = 0;
            iconLabel.ImageList = iconImageList;
            iconLabel.Location = new Point(10, 20);
            iconLabel.Name = "iconLabel";
            iconLabel.Size = new Size(249, 204);
            iconLabel.TabIndex = 0;
            // 
            // iconImageList
            // 
            iconImageList.ColorDepth = ColorDepth.Depth32Bit;
            iconImageList.ImageStream = (ImageListStreamer)resources.GetObject("iconImageList.ImageStream");
            iconImageList.TransparentColor = Color.Transparent;
            iconImageList.Images.SetKeyName(0, "icon.png");
            // 
            // lblAdminInfo
            // 
            lblAdminInfo.Dock = DockStyle.Fill;
            lblAdminInfo.Location = new Point(10, 10);
            lblAdminInfo.Name = "lblAdminInfo";
            lblAdminInfo.Size = new Size(249, 131);
            lblAdminInfo.TabIndex = 0;
            lblAdminInfo.Text = resources.GetString("lblAdminInfo.Text");
            // 
            // ucLobby
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(scInicioPanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "ucLobby";
            Padding = new Padding(10);
            Size = new Size(723, 421);
            scInicioPanel.Panel1.ResumeLayout(false);
            scInicioPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scInicioPanel).EndInit();
            scInicioPanel.ResumeLayout(false);
            scAdmin.Panel1.ResumeLayout(false);
            scAdmin.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scAdmin).EndInit();
            scAdmin.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer scInicioPanel;
        private Label lblClubInfo;
        private SplitContainer scAdmin;
        private Label lblAdminInfo;
        private ImageList iconImageList;
        private Label iconLabel;
    }
}
