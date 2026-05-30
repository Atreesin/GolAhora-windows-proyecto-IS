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
            label1 = new Label();
            txtCalle = new MaskedTextBox();
            txtNumero = new MaskedTextBox();
            cbPais = new ComboBox();
            cbProvincia = new ComboBox();
            txtCodigoPostal = new MaskedTextBox();
            cbCiudad = new ComboBox();
            cbLocalidad = new ComboBox();
            txtTelefono = new MaskedTextBox();
            txtEmail = new MaskedTextBox();
            txtFechaNacimiento = new MaskedTextBox();
            cbGeneros = new ComboBox();
            txtDni = new MaskedTextBox();
            cbNacionalidad = new ComboBox();
            txtApellido = new MaskedTextBox();
            txtNombre = new MaskedTextBox();
            lblApellido = new Label();
            lblDni = new Label();
            lblTelefono = new Label();
            lblEmail = new Label();
            lblFechaNacimiento = new Label();
            lblGenero = new Label();
            lblNacionalidad = new Label();
            lblNombre = new Label();
            gbDatos.SuspendLayout();
            SuspendLayout();
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(365, 172);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(31, 15);
            lblPais.TabIndex = 61;
            lblPais.Text = "Pais:";
            // 
            // lblProvincia
            // 
            lblProvincia.AutoSize = true;
            lblProvincia.Location = new Point(335, 141);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new Size(61, 15);
            lblProvincia.TabIndex = 60;
            lblProvincia.Text = "Provincia:";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(349, 82);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(47, 15);
            lblCiudad.TabIndex = 59;
            lblCiudad.Text = "Ciudad:";
            // 
            // lblLocalidad
            // 
            lblLocalidad.AutoSize = true;
            lblLocalidad.Location = new Point(335, 53);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(61, 15);
            lblLocalidad.TabIndex = 58;
            lblLocalidad.Text = "Localidad:";
            // 
            // lblCodigoPostal
            // 
            lblCodigoPostal.AutoSize = true;
            lblCodigoPostal.Location = new Point(312, 112);
            lblCodigoPostal.Name = "lblCodigoPostal";
            lblCodigoPostal.Size = new Size(84, 15);
            lblCodigoPostal.TabIndex = 57;
            lblCodigoPostal.Text = "Codigo postal:";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(340, 202);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(56, 15);
            lblNumero.TabIndex = 56;
            lblNumero.Text = "Numero:";
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Location = new Point(360, 230);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(36, 15);
            lblCalle.TabIndex = 55;
            lblCalle.Text = "Calle:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(487, 316);
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
            gbDatos.Controls.Add(label1);
            gbDatos.Controls.Add(txtCalle);
            gbDatos.Controls.Add(txtNumero);
            gbDatos.Controls.Add(cbPais);
            gbDatos.Controls.Add(cbProvincia);
            gbDatos.Controls.Add(txtCodigoPostal);
            gbDatos.Controls.Add(cbCiudad);
            gbDatos.Controls.Add(cbLocalidad);
            gbDatos.Controls.Add(txtTelefono);
            gbDatos.Controls.Add(txtEmail);
            gbDatos.Controls.Add(txtFechaNacimiento);
            gbDatos.Controls.Add(cbGeneros);
            gbDatos.Controls.Add(txtDni);
            gbDatos.Controls.Add(cbNacionalidad);
            gbDatos.Controls.Add(txtApellido);
            gbDatos.Controls.Add(txtNombre);
            gbDatos.Controls.Add(lblApellido);
            gbDatos.Controls.Add(lblDni);
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
            gbDatos.Controls.Add(lblNombre);
            gbDatos.Location = new Point(12, 12);
            gbDatos.Name = "gbDatos";
            gbDatos.Padding = new Padding(10);
            gbDatos.Size = new Size(550, 290);
            gbDatos.TabIndex = 10;
            gbDatos.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 21);
            label1.Name = "label1";
            label1.Size = new Size(179, 15);
            label1.TabIndex = 112;
            label1.Text = "Datos de residencia del cliente:";
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(398, 227);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(121, 23);
            txtCalle.TabIndex = 111;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(398, 197);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(121, 23);
            txtNumero.TabIndex = 110;
            // 
            // cbPais
            // 
            cbPais.FormattingEnabled = true;
            cbPais.Location = new Point(398, 167);
            cbPais.Name = "cbPais";
            cbPais.Size = new Size(121, 23);
            cbPais.TabIndex = 109;
            // 
            // cbProvincia
            // 
            cbProvincia.FormattingEnabled = true;
            cbProvincia.Location = new Point(398, 137);
            cbProvincia.Name = "cbProvincia";
            cbProvincia.Size = new Size(121, 23);
            cbProvincia.TabIndex = 108;
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Location = new Point(398, 108);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(121, 23);
            txtCodigoPostal.TabIndex = 107;
            // 
            // cbCiudad
            // 
            cbCiudad.FormattingEnabled = true;
            cbCiudad.Location = new Point(398, 78);
            cbCiudad.Name = "cbCiudad";
            cbCiudad.Size = new Size(121, 23);
            cbCiudad.TabIndex = 106;
            // 
            // cbLocalidad
            // 
            cbLocalidad.FormattingEnabled = true;
            cbLocalidad.Location = new Point(398, 49);
            cbLocalidad.Name = "cbLocalidad";
            cbLocalidad.Size = new Size(121, 23);
            cbLocalidad.TabIndex = 105;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(156, 226);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(121, 23);
            txtTelefono.TabIndex = 104;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(156, 197);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(121, 23);
            txtEmail.TabIndex = 103;
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new Point(156, 168);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(121, 23);
            txtFechaNacimiento.TabIndex = 102;
            // 
            // cbGeneros
            // 
            cbGeneros.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGeneros.FormattingEnabled = true;
            cbGeneros.Location = new Point(156, 138);
            cbGeneros.Name = "cbGeneros";
            cbGeneros.Size = new Size(121, 23);
            cbGeneros.TabIndex = 101;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(156, 108);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(121, 23);
            txtDni.TabIndex = 100;
            // 
            // cbNacionalidad
            // 
            cbNacionalidad.FormattingEnabled = true;
            cbNacionalidad.Location = new Point(156, 79);
            cbNacionalidad.Name = "cbNacionalidad";
            cbNacionalidad.Size = new Size(121, 23);
            cbNacionalidad.TabIndex = 99;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(156, 49);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(121, 23);
            txtApellido.TabIndex = 98;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(156, 20);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(121, 23);
            txtNombre.TabIndex = 97;
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
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(121, 112);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(29, 15);
            lblDni.TabIndex = 48;
            lblDni.Text = "Dni:";
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
            lblFechaNacimiento.Location = new Point(26, 171);
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
            lblNacionalidad.Location = new Point(70, 82);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new Size(80, 15);
            lblNacionalidad.TabIndex = 49;
            lblNacionalidad.Text = "Nacionalidad:";
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
            ClientSize = new Size(574, 351);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            Controls.Add(gbDatos);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(590, 390);
            MinimumSize = new Size(590, 390);
            Name = "RegistrarClienteForm";
            Text = "Gol Ahora - Registrar cliente";
            Load += RegistrarClienteForm_Load;
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
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
        private Label lblApellido;
        private Label lblTelefono;
        private Label lblEmail;
        private Label lblFechaNacimiento;
        private Label lblGenero;
        private Label lblNacionalidad;
        private Label lblDni;
        private Label lblNombre;
        private MaskedTextBox txtDni;
        private ComboBox cbNacionalidad;
        private MaskedTextBox txtApellido;
        private MaskedTextBox txtNombre;
        private MaskedTextBox txtEmail;
        private MaskedTextBox txtFechaNacimiento;
        private ComboBox cbGeneros;
        private MaskedTextBox txtTelefono;
        private MaskedTextBox txtCalle;
        private MaskedTextBox txtNumero;
        private ComboBox cbPais;
        private ComboBox cbProvincia;
        private MaskedTextBox txtCodigoPostal;
        private ComboBox cbCiudad;
        private ComboBox cbLocalidad;
        private Label label1;
    }
}