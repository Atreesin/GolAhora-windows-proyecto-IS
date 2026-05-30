namespace GolAhora.Forms
{
    partial class RegistrarClienteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarClienteForm));
            txtPais = new MaskedTextBox();
            txtCiudad = new MaskedTextBox();
            txtLocalidad = new MaskedTextBox();
            txtCodigoPostal = new MaskedTextBox();
            txtNumero = new MaskedTextBox();
            txtCalle = new MaskedTextBox();
            txtProvincia = new MaskedTextBox();
            txtTelefono = new MaskedTextBox();
            lblPais = new Label();
            lblProvincia = new Label();
            lblCiudad = new Label();
            lblLocalidad = new Label();
            lblCodigoPostal = new Label();
            lblNumero = new Label();
            lblCalle = new Label();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            gbDatos = new GroupBox();
            txtApellido = new MaskedTextBox();
            lblApellido = new Label();
            txtEmail = new MaskedTextBox();
            txtGenero = new MaskedTextBox();
            txtNacionalidad = new MaskedTextBox();
            txtDni = new MaskedTextBox();
            txtNombre = new MaskedTextBox();
            txtFechaNacimiento = new MaskedTextBox();
            lblTelefono = new Label();
            lblEmail = new Label();
            lblFechaNacimiento = new Label();
            lblGenero = new Label();
            lblNacionalidad = new Label();
            lblDni = new Label();
            lblNombre = new Label();
            gbDatos.SuspendLayout();
            SuspendLayout();
            // 
            // txtPais
            // 
            txtPais.Location = new Point(388, 168);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(120, 23);
            txtPais.TabIndex = 79;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(388, 78);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(120, 23);
            txtCiudad.TabIndex = 78;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(388, 49);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(120, 23);
            txtLocalidad.TabIndex = 77;
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Location = new Point(388, 108);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(120, 23);
            txtCodigoPostal.TabIndex = 76;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(388, 21);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(120, 23);
            txtNumero.TabIndex = 75;
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(152, 255);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(120, 23);
            txtCalle.TabIndex = 74;
            // 
            // txtProvincia
            // 
            txtProvincia.Location = new Point(388, 137);
            txtProvincia.Name = "txtProvincia";
            txtProvincia.Size = new Size(120, 23);
            txtProvincia.TabIndex = 73;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(152, 226);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(120, 23);
            txtTelefono.TabIndex = 71;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(355, 171);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(31, 15);
            lblPais.TabIndex = 61;
            lblPais.Text = "Pais:";
            // 
            // lblProvincia
            // 
            lblProvincia.AutoSize = true;
            lblProvincia.Location = new Point(325, 140);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new Size(61, 15);
            lblProvincia.TabIndex = 60;
            lblProvincia.Text = "Provincia:";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(339, 81);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(47, 15);
            lblCiudad.TabIndex = 59;
            lblCiudad.Text = "Ciudad:";
            // 
            // lblLocalidad
            // 
            lblLocalidad.AutoSize = true;
            lblLocalidad.Location = new Point(325, 52);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(61, 15);
            lblLocalidad.TabIndex = 58;
            lblLocalidad.Text = "Localidad:";
            // 
            // lblCodigoPostal
            // 
            lblCodigoPostal.AutoSize = true;
            lblCodigoPostal.Location = new Point(302, 111);
            lblCodigoPostal.Name = "lblCodigoPostal";
            lblCodigoPostal.Size = new Size(84, 15);
            lblCodigoPostal.TabIndex = 57;
            lblCodigoPostal.Text = "Codigo postal:";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(330, 24);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(56, 15);
            lblNumero.TabIndex = 56;
            lblNumero.Text = "Numero:";
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Location = new Point(114, 258);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(36, 15);
            lblCalle.TabIndex = 55;
            lblCalle.Text = "Calle:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(467, 316);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 316);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // gbDatos
            // 
            gbDatos.Controls.Add(txtApellido);
            gbDatos.Controls.Add(lblApellido);
            gbDatos.Controls.Add(txtPais);
            gbDatos.Controls.Add(txtCiudad);
            gbDatos.Controls.Add(txtLocalidad);
            gbDatos.Controls.Add(txtCodigoPostal);
            gbDatos.Controls.Add(txtNumero);
            gbDatos.Controls.Add(txtCalle);
            gbDatos.Controls.Add(txtProvincia);
            gbDatos.Controls.Add(txtTelefono);
            gbDatos.Controls.Add(txtEmail);
            gbDatos.Controls.Add(txtGenero);
            gbDatos.Controls.Add(txtNacionalidad);
            gbDatos.Controls.Add(txtDni);
            gbDatos.Controls.Add(txtNombre);
            gbDatos.Controls.Add(txtFechaNacimiento);
            gbDatos.Controls.Add(lblPais);
            gbDatos.Controls.Add(lblProvincia);
            gbDatos.Controls.Add(lblCiudad);
            gbDatos.Controls.Add(lblLocalidad);
            gbDatos.Controls.Add(lblCodigoPostal);
            gbDatos.Controls.Add(lblNumero);
            gbDatos.Controls.Add(lblCalle);
            gbDatos.Controls.Add(lblTelefono);
            gbDatos.Controls.Add(lblEmail);
            gbDatos.Controls.Add(lblFechaNacimiento);
            gbDatos.Controls.Add(lblGenero);
            gbDatos.Controls.Add(lblNacionalidad);
            gbDatos.Controls.Add(lblDni);
            gbDatos.Controls.Add(lblNombre);
            gbDatos.Location = new Point(12, 12);
            gbDatos.Name = "gbDatos";
            gbDatos.Padding = new Padding(10);
            gbDatos.Size = new Size(530, 290);
            gbDatos.TabIndex = 10;
            gbDatos.TabStop = false;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(152, 49);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(120, 23);
            txtApellido.TabIndex = 83;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(95, 52);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(55, 15);
            lblApellido.TabIndex = 82;
            lblApellido.Text = "Apellido:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(152, 198);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(120, 23);
            txtEmail.TabIndex = 70;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(152, 138);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(120, 23);
            txtGenero.TabIndex = 69;
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Location = new Point(152, 167);
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.Size = new Size(120, 23);
            txtNacionalidad.TabIndex = 68;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(152, 78);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(120, 23);
            txtDni.TabIndex = 67;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(152, 21);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(120, 23);
            txtNombre.TabIndex = 66;
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new Point(152, 108);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(120, 23);
            txtFechaNacimiento.TabIndex = 64;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(34, 229);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(116, 15);
            lblTelefono.TabIndex = 53;
            lblTelefono.Text = "Numero telefónico:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(106, 201);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 52;
            lblEmail.Text = "E-Mail:";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(26, 111);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(124, 15);
            lblFechaNacimiento.TabIndex = 51;
            lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(98, 141);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(52, 15);
            lblGenero.TabIndex = 50;
            lblGenero.Text = "Genero:";
            // 
            // lblNacionalidad
            // 
            lblNacionalidad.AutoSize = true;
            lblNacionalidad.Location = new Point(70, 170);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new Size(80, 15);
            lblNacionalidad.TabIndex = 49;
            lblNacionalidad.Text = "Nacionalidad:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(121, 81);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(29, 15);
            lblDni.TabIndex = 48;
            lblDni.Text = "Dni:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(94, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 15);
            lblNombre.TabIndex = 46;
            lblNombre.Text = "Nombre:";
            // 
            // RegistrarClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(554, 351);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            Controls.Add(gbDatos);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(570, 390);
            MinimumSize = new Size(570, 390);
            Name = "RegistrarClienteForm";
            Text = "Gol Ahora - Registrar cliente";
            Load += RegistrarClienteForm_Load;
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaskedTextBox txtPais;
        private MaskedTextBox txtCiudad;
        private MaskedTextBox txtLocalidad;
        private MaskedTextBox txtCodigoPostal;
        private MaskedTextBox txtNumero;
        private MaskedTextBox txtCalle;
        private MaskedTextBox txtProvincia;
        private MaskedTextBox txtTelefono;
        private Label lblPais;
        private Label lblProvincia;
        private Label lblCiudad;
        private Label lblLocalidad;
        private Label lblCodigoPostal;
        private Label lblNumero;
        private Label lblCalle;
        private Button btnRegistrar;
        private Button btnCancelar;
        private GroupBox gbDatos;
        private MaskedTextBox txtApellido;
        private Label lblApellido;
        private MaskedTextBox txtEmail;
        private MaskedTextBox txtGenero;
        private MaskedTextBox txtNacionalidad;
        private MaskedTextBox txtDni;
        private MaskedTextBox txtNombre;
        private MaskedTextBox txtFechaNacimiento;
        private Label lblTelefono;
        private Label lblEmail;
        private Label lblFechaNacimiento;
        private Label lblGenero;
        private Label lblNacionalidad;
        private Label lblDni;
        private Label lblNombre;
    }
}