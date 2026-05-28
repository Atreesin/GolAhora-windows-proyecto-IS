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
            gbInfoClub = new GroupBox();
            lblEmailClub = new Label();
            lblTitEmail = new Label();
            lblPaisClub = new Label();
            lblTitPais = new Label();
            lblProvinciaClub = new Label();
            lblTitProvincia = new Label();
            lblCiudadClub = new Label();
            lblTitLocalidad = new Label();
            lblLocalidadClub = new Label();
            lblTitCiudad = new Label();
            lblCodigoPostalClub = new Label();
            lblTitCodigoPostal = new Label();
            lblNumeroClub = new Label();
            lblTitNumero = new Label();
            lblCalleClub = new Label();
            lblTitCalle = new Label();
            lblTelefonoClub = new Label();
            lblTitTelefono = new Label();
            lblCuitClub = new Label();
            lblTitCuit = new Label();
            lblNombreClub = new Label();
            lblTitNombre = new Label();
            scAdmin = new SplitContainer();
            iconLabel = new Label();
            iconImageList = new ImageList(components);
            gbInfoAdmin = new GroupBox();
            lblFechaRegistroAdmin = new Label();
            lblTitFechaRegistroAdmin = new Label();
            lblEmailAdmin = new Label();
            lblTitEmailAdmin = new Label();
            lblTelefonoAdmin = new Label();
            lblTitTelefonoAdmin = new Label();
            lblDniAdmin = new Label();
            lblTitDniAdmin = new Label();
            lblNombreAdmin = new Label();
            lblTitNombreAdmin = new Label();
            ((System.ComponentModel.ISupportInitialize)scInicioPanel).BeginInit();
            scInicioPanel.Panel1.SuspendLayout();
            scInicioPanel.Panel2.SuspendLayout();
            scInicioPanel.SuspendLayout();
            gbInfoClub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scAdmin).BeginInit();
            scAdmin.Panel1.SuspendLayout();
            scAdmin.Panel2.SuspendLayout();
            scAdmin.SuspendLayout();
            gbInfoAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // scInicioPanel
            // 
            scInicioPanel.BorderStyle = BorderStyle.FixedSingle;
            scInicioPanel.Dock = DockStyle.Fill;
            scInicioPanel.Location = new Point(10, 10);
            scInicioPanel.Name = "scInicioPanel";
            // 
            // scInicioPanel.Panel1
            // 
            scInicioPanel.Panel1.Controls.Add(gbInfoClub);
            scInicioPanel.Panel1.Padding = new Padding(10, 20, 10, 20);
            // 
            // scInicioPanel.Panel2
            // 
            scInicioPanel.Panel2.Controls.Add(scAdmin);
            scInicioPanel.Size = new Size(703, 401);
            scInicioPanel.SplitterDistance = 347;
            scInicioPanel.SplitterWidth = 10;
            scInicioPanel.TabIndex = 1;
            scInicioPanel.TabStop = false;
            // 
            // gbInfoClub
            // 
            gbInfoClub.BackColor = SystemColors.ActiveCaption;
            gbInfoClub.Controls.Add(lblEmailClub);
            gbInfoClub.Controls.Add(lblTitEmail);
            gbInfoClub.Controls.Add(lblPaisClub);
            gbInfoClub.Controls.Add(lblTitPais);
            gbInfoClub.Controls.Add(lblProvinciaClub);
            gbInfoClub.Controls.Add(lblTitProvincia);
            gbInfoClub.Controls.Add(lblCiudadClub);
            gbInfoClub.Controls.Add(lblTitLocalidad);
            gbInfoClub.Controls.Add(lblLocalidadClub);
            gbInfoClub.Controls.Add(lblTitCiudad);
            gbInfoClub.Controls.Add(lblCodigoPostalClub);
            gbInfoClub.Controls.Add(lblTitCodigoPostal);
            gbInfoClub.Controls.Add(lblNumeroClub);
            gbInfoClub.Controls.Add(lblTitNumero);
            gbInfoClub.Controls.Add(lblCalleClub);
            gbInfoClub.Controls.Add(lblTitCalle);
            gbInfoClub.Controls.Add(lblTelefonoClub);
            gbInfoClub.Controls.Add(lblTitTelefono);
            gbInfoClub.Controls.Add(lblCuitClub);
            gbInfoClub.Controls.Add(lblTitCuit);
            gbInfoClub.Controls.Add(lblNombreClub);
            gbInfoClub.Controls.Add(lblTitNombre);
            gbInfoClub.Dock = DockStyle.Fill;
            gbInfoClub.Location = new Point(10, 20);
            gbInfoClub.Name = "gbInfoClub";
            gbInfoClub.Size = new Size(325, 359);
            gbInfoClub.TabIndex = 0;
            gbInfoClub.TabStop = false;
            gbInfoClub.Text = "Información del club";
            // 
            // lblEmailClub
            // 
            lblEmailClub.AutoSize = true;
            lblEmailClub.Location = new Point(134, 116);
            lblEmailClub.Name = "lblEmailClub";
            lblEmailClub.Size = new Size(12, 15);
            lblEmailClub.TabIndex = 21;
            lblEmailClub.Text = "-";
            // 
            // lblTitEmail
            // 
            lblTitEmail.AutoSize = true;
            lblTitEmail.Location = new Point(21, 116);
            lblTitEmail.Name = "lblTitEmail";
            lblTitEmail.Size = new Size(39, 15);
            lblTitEmail.TabIndex = 20;
            lblTitEmail.Text = "Email:";
            // 
            // lblPaisClub
            // 
            lblPaisClub.AutoSize = true;
            lblPaisClub.Location = new Point(134, 314);
            lblPaisClub.Name = "lblPaisClub";
            lblPaisClub.Size = new Size(12, 15);
            lblPaisClub.TabIndex = 19;
            lblPaisClub.Text = "-";
            // 
            // lblTitPais
            // 
            lblTitPais.AutoSize = true;
            lblTitPais.Location = new Point(21, 314);
            lblTitPais.Name = "lblTitPais";
            lblTitPais.Size = new Size(31, 15);
            lblTitPais.TabIndex = 18;
            lblTitPais.Text = "Pais:";
            // 
            // lblProvinciaClub
            // 
            lblProvinciaClub.AutoSize = true;
            lblProvinciaClub.Location = new Point(134, 285);
            lblProvinciaClub.Name = "lblProvinciaClub";
            lblProvinciaClub.Size = new Size(12, 15);
            lblProvinciaClub.TabIndex = 17;
            lblProvinciaClub.Text = "-";
            // 
            // lblTitProvincia
            // 
            lblTitProvincia.AutoSize = true;
            lblTitProvincia.Location = new Point(21, 285);
            lblTitProvincia.Name = "lblTitProvincia";
            lblTitProvincia.Size = new Size(61, 15);
            lblTitProvincia.TabIndex = 16;
            lblTitProvincia.Text = "Provincia:";
            // 
            // lblCiudadClub
            // 
            lblCiudadClub.AutoSize = true;
            lblCiudadClub.Location = new Point(134, 257);
            lblCiudadClub.Name = "lblCiudadClub";
            lblCiudadClub.Size = new Size(12, 15);
            lblCiudadClub.TabIndex = 15;
            lblCiudadClub.Text = "-";
            // 
            // lblTitLocalidad
            // 
            lblTitLocalidad.AutoSize = true;
            lblTitLocalidad.Location = new Point(21, 232);
            lblTitLocalidad.Name = "lblTitLocalidad";
            lblTitLocalidad.Size = new Size(61, 15);
            lblTitLocalidad.TabIndex = 14;
            lblTitLocalidad.Text = "Localidad:";
            // 
            // lblLocalidadClub
            // 
            lblLocalidadClub.AutoSize = true;
            lblLocalidadClub.Location = new Point(134, 232);
            lblLocalidadClub.Name = "lblLocalidadClub";
            lblLocalidadClub.Size = new Size(12, 15);
            lblLocalidadClub.TabIndex = 13;
            lblLocalidadClub.Text = "-";
            // 
            // lblTitCiudad
            // 
            lblTitCiudad.AutoSize = true;
            lblTitCiudad.Location = new Point(21, 257);
            lblTitCiudad.Name = "lblTitCiudad";
            lblTitCiudad.Size = new Size(47, 15);
            lblTitCiudad.TabIndex = 12;
            lblTitCiudad.Text = "Ciudad:";
            // 
            // lblCodigoPostalClub
            // 
            lblCodigoPostalClub.AutoSize = true;
            lblCodigoPostalClub.Location = new Point(134, 200);
            lblCodigoPostalClub.Name = "lblCodigoPostalClub";
            lblCodigoPostalClub.Size = new Size(12, 15);
            lblCodigoPostalClub.TabIndex = 11;
            lblCodigoPostalClub.Text = "-";
            // 
            // lblTitCodigoPostal
            // 
            lblTitCodigoPostal.AutoSize = true;
            lblTitCodigoPostal.Location = new Point(21, 200);
            lblTitCodigoPostal.Name = "lblTitCodigoPostal";
            lblTitCodigoPostal.Size = new Size(84, 15);
            lblTitCodigoPostal.TabIndex = 10;
            lblTitCodigoPostal.Text = "Código postal:";
            // 
            // lblNumeroClub
            // 
            lblNumeroClub.AutoSize = true;
            lblNumeroClub.Location = new Point(134, 173);
            lblNumeroClub.Name = "lblNumeroClub";
            lblNumeroClub.Size = new Size(12, 15);
            lblNumeroClub.TabIndex = 9;
            lblNumeroClub.Text = "-";
            // 
            // lblTitNumero
            // 
            lblTitNumero.AutoSize = true;
            lblTitNumero.Location = new Point(21, 173);
            lblTitNumero.Name = "lblTitNumero";
            lblTitNumero.Size = new Size(56, 15);
            lblTitNumero.TabIndex = 8;
            lblTitNumero.Text = "Numero:";
            // 
            // lblCalleClub
            // 
            lblCalleClub.AutoSize = true;
            lblCalleClub.Location = new Point(134, 145);
            lblCalleClub.Name = "lblCalleClub";
            lblCalleClub.Size = new Size(12, 15);
            lblCalleClub.TabIndex = 7;
            lblCalleClub.Text = "-";
            // 
            // lblTitCalle
            // 
            lblTitCalle.AutoSize = true;
            lblTitCalle.Location = new Point(21, 145);
            lblTitCalle.Name = "lblTitCalle";
            lblTitCalle.Size = new Size(36, 15);
            lblTitCalle.TabIndex = 6;
            lblTitCalle.Text = "Calle:";
            // 
            // lblTelefonoClub
            // 
            lblTelefonoClub.AutoSize = true;
            lblTelefonoClub.Location = new Point(134, 89);
            lblTelefonoClub.Name = "lblTelefonoClub";
            lblTelefonoClub.Size = new Size(12, 15);
            lblTelefonoClub.TabIndex = 5;
            lblTelefonoClub.Text = "-";
            // 
            // lblTitTelefono
            // 
            lblTitTelefono.AutoSize = true;
            lblTitTelefono.Location = new Point(21, 89);
            lblTitTelefono.Name = "lblTitTelefono";
            lblTitTelefono.Size = new Size(59, 15);
            lblTitTelefono.TabIndex = 4;
            lblTitTelefono.Text = "Telefono:";
            // 
            // lblCuitClub
            // 
            lblCuitClub.AutoSize = true;
            lblCuitClub.Location = new Point(134, 63);
            lblCuitClub.Name = "lblCuitClub";
            lblCuitClub.Size = new Size(12, 15);
            lblCuitClub.TabIndex = 3;
            lblCuitClub.Text = "-";
            // 
            // lblTitCuit
            // 
            lblTitCuit.AutoSize = true;
            lblTitCuit.Location = new Point(21, 63);
            lblTitCuit.Name = "lblTitCuit";
            lblTitCuit.Size = new Size(37, 15);
            lblTitCuit.TabIndex = 2;
            lblTitCuit.Text = "CUIT:";
            // 
            // lblNombreClub
            // 
            lblNombreClub.AutoSize = true;
            lblNombreClub.Location = new Point(134, 37);
            lblNombreClub.Name = "lblNombreClub";
            lblNombreClub.Size = new Size(12, 15);
            lblNombreClub.TabIndex = 1;
            lblNombreClub.Text = "-";
            // 
            // lblTitNombre
            // 
            lblTitNombre.AutoSize = true;
            lblTitNombre.Location = new Point(21, 37);
            lblTitNombre.Name = "lblTitNombre";
            lblTitNombre.Size = new Size(56, 15);
            lblTitNombre.TabIndex = 0;
            lblTitNombre.Text = "Nombre:";
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
            scAdmin.Panel2.Controls.Add(gbInfoAdmin);
            scAdmin.Panel2.Padding = new Padding(10, 10, 10, 20);
            scAdmin.Panel2.RightToLeft = RightToLeft.No;
            scAdmin.RightToLeft = RightToLeft.No;
            scAdmin.Size = new Size(344, 399);
            scAdmin.SplitterDistance = 183;
            scAdmin.TabIndex = 0;
            scAdmin.TabStop = false;
            // 
            // iconLabel
            // 
            iconLabel.Dock = DockStyle.Fill;
            iconLabel.ImageIndex = 0;
            iconLabel.ImageList = iconImageList;
            iconLabel.Location = new Point(10, 20);
            iconLabel.Name = "iconLabel";
            iconLabel.Size = new Size(324, 153);
            iconLabel.TabIndex = 0;
            // 
            // iconImageList
            // 
            iconImageList.ColorDepth = ColorDepth.Depth32Bit;
            iconImageList.ImageStream = (ImageListStreamer)resources.GetObject("iconImageList.ImageStream");
            iconImageList.TransparentColor = Color.Transparent;
            iconImageList.Images.SetKeyName(0, "icon.png");
            // 
            // gbInfoAdmin
            // 
            gbInfoAdmin.Controls.Add(lblFechaRegistroAdmin);
            gbInfoAdmin.Controls.Add(lblTitFechaRegistroAdmin);
            gbInfoAdmin.Controls.Add(lblEmailAdmin);
            gbInfoAdmin.Controls.Add(lblTitEmailAdmin);
            gbInfoAdmin.Controls.Add(lblTelefonoAdmin);
            gbInfoAdmin.Controls.Add(lblTitTelefonoAdmin);
            gbInfoAdmin.Controls.Add(lblDniAdmin);
            gbInfoAdmin.Controls.Add(lblTitDniAdmin);
            gbInfoAdmin.Controls.Add(lblNombreAdmin);
            gbInfoAdmin.Controls.Add(lblTitNombreAdmin);
            gbInfoAdmin.Dock = DockStyle.Fill;
            gbInfoAdmin.Location = new Point(10, 10);
            gbInfoAdmin.Name = "gbInfoAdmin";
            gbInfoAdmin.Size = new Size(324, 182);
            gbInfoAdmin.TabIndex = 1;
            gbInfoAdmin.TabStop = false;
            gbInfoAdmin.Text = "Información del administrador";
            // 
            // lblFechaRegistroAdmin
            // 
            lblFechaRegistroAdmin.AutoSize = true;
            lblFechaRegistroAdmin.Location = new Point(141, 145);
            lblFechaRegistroAdmin.Name = "lblFechaRegistroAdmin";
            lblFechaRegistroAdmin.Size = new Size(12, 15);
            lblFechaRegistroAdmin.TabIndex = 25;
            lblFechaRegistroAdmin.Text = "-";
            // 
            // lblTitFechaRegistroAdmin
            // 
            lblTitFechaRegistroAdmin.AutoSize = true;
            lblTitFechaRegistroAdmin.Location = new Point(15, 145);
            lblTitFechaRegistroAdmin.Name = "lblTitFechaRegistroAdmin";
            lblTitFechaRegistroAdmin.Size = new Size(105, 15);
            lblTitFechaRegistroAdmin.TabIndex = 24;
            lblTitFechaRegistroAdmin.Text = "fecha de registro:";
            // 
            // lblEmailAdmin
            // 
            lblEmailAdmin.AutoSize = true;
            lblEmailAdmin.Location = new Point(141, 116);
            lblEmailAdmin.Name = "lblEmailAdmin";
            lblEmailAdmin.Size = new Size(12, 15);
            lblEmailAdmin.TabIndex = 23;
            lblEmailAdmin.Text = "-";
            // 
            // lblTitEmailAdmin
            // 
            lblTitEmailAdmin.AutoSize = true;
            lblTitEmailAdmin.Location = new Point(15, 116);
            lblTitEmailAdmin.Name = "lblTitEmailAdmin";
            lblTitEmailAdmin.Size = new Size(39, 15);
            lblTitEmailAdmin.TabIndex = 22;
            lblTitEmailAdmin.Text = "Email:";
            // 
            // lblTelefonoAdmin
            // 
            lblTelefonoAdmin.AutoSize = true;
            lblTelefonoAdmin.Location = new Point(141, 90);
            lblTelefonoAdmin.Name = "lblTelefonoAdmin";
            lblTelefonoAdmin.Size = new Size(12, 15);
            lblTelefonoAdmin.TabIndex = 11;
            lblTelefonoAdmin.Text = "-";
            // 
            // lblTitTelefonoAdmin
            // 
            lblTitTelefonoAdmin.AutoSize = true;
            lblTitTelefonoAdmin.Location = new Point(15, 90);
            lblTitTelefonoAdmin.Name = "lblTitTelefonoAdmin";
            lblTitTelefonoAdmin.Size = new Size(59, 15);
            lblTitTelefonoAdmin.TabIndex = 10;
            lblTitTelefonoAdmin.Text = "Telefono:";
            // 
            // lblDniAdmin
            // 
            lblDniAdmin.AutoSize = true;
            lblDniAdmin.Location = new Point(141, 64);
            lblDniAdmin.Name = "lblDniAdmin";
            lblDniAdmin.Size = new Size(12, 15);
            lblDniAdmin.TabIndex = 9;
            lblDniAdmin.Text = "-";
            // 
            // lblTitDniAdmin
            // 
            lblTitDniAdmin.AutoSize = true;
            lblTitDniAdmin.Location = new Point(15, 64);
            lblTitDniAdmin.Name = "lblTitDniAdmin";
            lblTitDniAdmin.Size = new Size(32, 15);
            lblTitDniAdmin.TabIndex = 8;
            lblTitDniAdmin.Text = "DNI:";
            // 
            // lblNombreAdmin
            // 
            lblNombreAdmin.AutoSize = true;
            lblNombreAdmin.Location = new Point(141, 38);
            lblNombreAdmin.Name = "lblNombreAdmin";
            lblNombreAdmin.Size = new Size(12, 15);
            lblNombreAdmin.TabIndex = 7;
            lblNombreAdmin.Text = "-";
            // 
            // lblTitNombreAdmin
            // 
            lblTitNombreAdmin.AutoSize = true;
            lblTitNombreAdmin.Location = new Point(15, 38);
            lblTitNombreAdmin.Name = "lblTitNombreAdmin";
            lblTitNombreAdmin.Size = new Size(56, 15);
            lblTitNombreAdmin.TabIndex = 6;
            lblTitNombreAdmin.Text = "Nombre:";
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
            Load += ucLobby_Load;
            scInicioPanel.Panel1.ResumeLayout(false);
            scInicioPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scInicioPanel).EndInit();
            scInicioPanel.ResumeLayout(false);
            gbInfoClub.ResumeLayout(false);
            gbInfoClub.PerformLayout();
            scAdmin.Panel1.ResumeLayout(false);
            scAdmin.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scAdmin).EndInit();
            scAdmin.ResumeLayout(false);
            gbInfoAdmin.ResumeLayout(false);
            gbInfoAdmin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer scInicioPanel;
        private SplitContainer scAdmin;
        private ImageList iconImageList;
        private Label iconLabel;
        private GroupBox gbInfoClub;
        private Label lblNumeroClub;
        private Label lblTitNumero;
        private Label lblCalleClub;
        private Label lblTitCalle;
        private Label lblTelefonoClub;
        private Label lblTitTelefono;
        private Label lblCuitClub;
        private Label lblTitCuit;
        private Label lblNombreClub;
        private Label lblTitNombre;
        private Label lblPaisClub;
        private Label lblTitPais;
        private Label lblProvinciaClub;
        private Label lblTitProvincia;
        private Label lblCiudadClub;
        private Label lblTitLocalidad;
        private Label lblLocalidadClub;
        private Label lblTitCiudad;
        private Label lblCodigoPostalClub;
        private Label lblTitCodigoPostal;
        private GroupBox gbInfoAdmin;
        private Label lblTelefonoAdmin;
        private Label lblTitTelefonoAdmin;
        private Label lblDniAdmin;
        private Label lblTitDniAdmin;
        private Label lblNombreAdmin;
        private Label lblTitNombreAdmin;
        private Label lblEmailClub;
        private Label lblTitEmail;
        private Label lblEmailAdmin;
        private Label lblTitEmailAdmin;
        private Label lblFechaRegistroAdmin;
        private Label lblTitFechaRegistroAdmin;
    }
}
