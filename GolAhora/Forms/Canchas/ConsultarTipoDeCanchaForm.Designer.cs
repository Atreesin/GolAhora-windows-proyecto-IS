namespace GolAhora.Forms
{
    partial class ConsultarTipoDeCanchaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarTipoDeCanchaForm));
            btnVolver = new Button();
            gbDatos = new GroupBox();
            pictureBoxImagen = new PictureBox();
            txtCapacidad = new MaskedTextBox();
            txtSuperficie = new MaskedTextBox();
            txtDimension = new MaskedTextBox();
            txtDuracionMaxima = new MaskedTextBox();
            txtDuracionMinima = new MaskedTextBox();
            txtTipo = new MaskedTextBox();
            lblEmail = new Label();
            lblFechaNacimiento = new Label();
            lblNacionalidad = new Label();
            lblDni = new Label();
            lblUsername = new Label();
            lblNombre = new Label();
            gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(497, 246);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // gbDatos
            // 
            gbDatos.Controls.Add(pictureBoxImagen);
            gbDatos.Controls.Add(txtCapacidad);
            gbDatos.Controls.Add(txtSuperficie);
            gbDatos.Controls.Add(txtDimension);
            gbDatos.Controls.Add(txtDuracionMaxima);
            gbDatos.Controls.Add(txtDuracionMinima);
            gbDatos.Controls.Add(txtTipo);
            gbDatos.Controls.Add(lblEmail);
            gbDatos.Controls.Add(lblFechaNacimiento);
            gbDatos.Controls.Add(lblNacionalidad);
            gbDatos.Controls.Add(lblDni);
            gbDatos.Controls.Add(lblUsername);
            gbDatos.Controls.Add(lblNombre);
            gbDatos.Location = new Point(12, 12);
            gbDatos.Name = "gbDatos";
            gbDatos.Padding = new Padding(10);
            gbDatos.Size = new Size(560, 218);
            gbDatos.TabIndex = 2;
            gbDatos.TabStop = false;
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxImagen.Location = new Point(274, 19);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(264, 175);
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagen.TabIndex = 72;
            pictureBoxImagen.TabStop = false;
            // 
            // txtCapacidad
            // 
            txtCapacidad.BackColor = SystemColors.ActiveCaption;
            txtCapacidad.BorderStyle = BorderStyle.None;
            txtCapacidad.Location = new Point(129, 115);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(130, 16);
            txtCapacidad.TabIndex = 71;
            // 
            // txtSuperficie
            // 
            txtSuperficie.BackColor = SystemColors.ActiveCaption;
            txtSuperficie.BorderStyle = BorderStyle.None;
            txtSuperficie.Location = new Point(129, 178);
            txtSuperficie.Name = "txtSuperficie";
            txtSuperficie.Size = new Size(130, 16);
            txtSuperficie.TabIndex = 70;
            // 
            // txtDimension
            // 
            txtDimension.BackColor = SystemColors.ActiveCaption;
            txtDimension.BorderStyle = BorderStyle.None;
            txtDimension.Location = new Point(129, 147);
            txtDimension.Name = "txtDimension";
            txtDimension.Size = new Size(130, 16);
            txtDimension.TabIndex = 68;
            // 
            // txtDuracionMaxima
            // 
            txtDuracionMaxima.BackColor = SystemColors.ActiveCaption;
            txtDuracionMaxima.BorderStyle = BorderStyle.None;
            txtDuracionMaxima.Location = new Point(129, 84);
            txtDuracionMaxima.Name = "txtDuracionMaxima";
            txtDuracionMaxima.Size = new Size(130, 16);
            txtDuracionMaxima.TabIndex = 67;
            // 
            // txtDuracionMinima
            // 
            txtDuracionMinima.BackColor = SystemColors.ActiveCaption;
            txtDuracionMinima.BorderStyle = BorderStyle.None;
            txtDuracionMinima.Location = new Point(129, 53);
            txtDuracionMinima.Name = "txtDuracionMinima";
            txtDuracionMinima.Size = new Size(130, 16);
            txtDuracionMinima.TabIndex = 66;
            // 
            // txtTipo
            // 
            txtTipo.BackColor = SystemColors.ActiveCaption;
            txtTipo.BorderStyle = BorderStyle.None;
            txtTipo.Location = new Point(129, 22);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(130, 16);
            txtTipo.TabIndex = 65;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(56, 178);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(67, 15);
            lblEmail.TabIndex = 52;
            lblEmail.Text = "Superficie:";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(58, 116);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(65, 15);
            lblFechaNacimiento.TabIndex = 51;
            lblFechaNacimiento.Text = "Capacidad:";
            // 
            // lblNacionalidad
            // 
            lblNacionalidad.AutoSize = true;
            lblNacionalidad.Location = new Point(49, 147);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new Size(74, 15);
            lblNacionalidad.TabIndex = 49;
            lblNacionalidad.Text = "Dimesiones:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(16, 85);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(107, 15);
            lblDni.TabIndex = 48;
            lblDni.Text = "Duración máxima:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(34, 23);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(89, 15);
            lblUsername.TabIndex = 47;
            lblUsername.Text = "Tipo (nombre):";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(19, 53);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(104, 15);
            lblNombre.TabIndex = 46;
            lblNombre.Text = "Duración mínima:";
            // 
            // ConsultarTipoDeCanchaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(584, 281);
            Controls.Add(btnVolver);
            Controls.Add(gbDatos);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(600, 320);
            MinimumSize = new Size(600, 320);
            Name = "ConsultarTipoDeCanchaForm";
            Text = "Gol Ahora - Consultar tipo de cancha";
            Load += ConsultarTipoDeCanchaForm_Load;
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private GroupBox gbDatos;
        private PictureBox pictureBoxImagen;
        private MaskedTextBox txtCapacidad;
        private MaskedTextBox txtSuperficie;
        private MaskedTextBox txtDimension;
        private MaskedTextBox txtDuracionMaxima;
        private MaskedTextBox txtDuracionMinima;
        private MaskedTextBox txtTipo;
        private Label lblEmail;
        private Label lblFechaNacimiento;
        private Label lblNacionalidad;
        private Label lblDni;
        private Label lblUsername;
        private Label lblNombre;
    }
}