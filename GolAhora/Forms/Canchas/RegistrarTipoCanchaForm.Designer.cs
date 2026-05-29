namespace GolAhora.Forms
{
    partial class RegistrarTipoCanchaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarTipoCanchaForm));
            btnRegistrar = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnCancelar = new Button();
            gbDatos = new GroupBox();
            pictureBoxImagen = new PictureBox();
            btnImagenSeleccionar = new Button();
            txtRutaImagen = new TextBox();
            numCapacidad = new NumericUpDown();
            lblSuperficie = new Label();
            lblImagen = new Label();
            lblCapacidad = new Label();
            lblLargo = new Label();
            lblAncho = new Label();
            lblDuracionMax = new Label();
            lblDuracionMin = new Label();
            lblTipoCancha = new Label();
            numLargo = new NumericUpDown();
            numAncho = new NumericUpDown();
            numDuracionMax = new NumericUpDown();
            numDuracionMin = new NumericUpDown();
            txtTipoCancha = new TextBox();
            cb_superficies = new ComboBox();
            gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCapacidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLargo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAncho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDuracionMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDuracionMin).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(577, 376);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 376);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // gbDatos
            // 
            gbDatos.Controls.Add(pictureBoxImagen);
            gbDatos.Controls.Add(btnImagenSeleccionar);
            gbDatos.Controls.Add(txtRutaImagen);
            gbDatos.Controls.Add(numCapacidad);
            gbDatos.Controls.Add(lblSuperficie);
            gbDatos.Controls.Add(lblImagen);
            gbDatos.Controls.Add(lblCapacidad);
            gbDatos.Controls.Add(lblLargo);
            gbDatos.Controls.Add(lblAncho);
            gbDatos.Controls.Add(lblDuracionMax);
            gbDatos.Controls.Add(lblDuracionMin);
            gbDatos.Controls.Add(lblTipoCancha);
            gbDatos.Controls.Add(numLargo);
            gbDatos.Controls.Add(numAncho);
            gbDatos.Controls.Add(numDuracionMax);
            gbDatos.Controls.Add(numDuracionMin);
            gbDatos.Controls.Add(txtTipoCancha);
            gbDatos.Controls.Add(cb_superficies);
            gbDatos.Location = new Point(12, 12);
            gbDatos.Name = "gbDatos";
            gbDatos.Padding = new Padding(10, 10, 10, 20);
            gbDatos.Size = new Size(640, 335);
            gbDatos.TabIndex = 20;
            gbDatos.TabStop = false;
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxImagen.Location = new Point(288, 34);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(327, 232);
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagen.TabIndex = 36;
            pictureBoxImagen.TabStop = false;
            // 
            // btnImagenSeleccionar
            // 
            btnImagenSeleccionar.Location = new Point(288, 289);
            btnImagenSeleccionar.Name = "btnImagenSeleccionar";
            btnImagenSeleccionar.Size = new Size(79, 23);
            btnImagenSeleccionar.TabIndex = 35;
            btnImagenSeleccionar.Text = "Seleccionar";
            btnImagenSeleccionar.UseVisualStyleBackColor = true;
            btnImagenSeleccionar.Click += btnImagenSeleccionar_Click;
            // 
            // txtRutaImagen
            // 
            txtRutaImagen.Location = new Point(143, 289);
            txtRutaImagen.Name = "txtRutaImagen";
            txtRutaImagen.Size = new Size(121, 23);
            txtRutaImagen.TabIndex = 34;
            // 
            // numCapacidad
            // 
            numCapacidad.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numCapacidad.Location = new Point(143, 218);
            numCapacidad.Maximum = new decimal(new int[] { 22, 0, 0, 0 });
            numCapacidad.Name = "numCapacidad";
            numCapacidad.Size = new Size(120, 23);
            numCapacidad.TabIndex = 33;
            // 
            // lblSuperficie
            // 
            lblSuperficie.AutoSize = true;
            lblSuperficie.Location = new Point(70, 257);
            lblSuperficie.Name = "lblSuperficie";
            lblSuperficie.Size = new Size(67, 15);
            lblSuperficie.TabIndex = 32;
            lblSuperficie.Text = "Superficie:";
            // 
            // lblImagen
            // 
            lblImagen.AutoSize = true;
            lblImagen.Location = new Point(85, 292);
            lblImagen.Name = "lblImagen";
            lblImagen.Size = new Size(52, 15);
            lblImagen.TabIndex = 31;
            lblImagen.Text = "Imagen:";
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Location = new Point(72, 220);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(65, 15);
            lblCapacidad.TabIndex = 30;
            lblCapacidad.Text = "Capacidad:";
            // 
            // lblLargo
            // 
            lblLargo.AutoSize = true;
            lblLargo.Location = new Point(64, 184);
            lblLargo.Name = "lblLargo";
            lblLargo.Size = new Size(73, 15);
            lblLargo.TabIndex = 29;
            lblLargo.Text = "Largo (mts):";
            // 
            // lblAncho
            // 
            lblAncho.AutoSize = true;
            lblAncho.Location = new Point(60, 147);
            lblAncho.Name = "lblAncho";
            lblAncho.Size = new Size(77, 15);
            lblAncho.TabIndex = 28;
            lblAncho.Text = "Ancho (mts):";
            // 
            // lblDuracionMax
            // 
            lblDuracionMax.AutoSize = true;
            lblDuracionMax.Location = new Point(8, 109);
            lblDuracionMax.Name = "lblDuracionMax";
            lblDuracionMax.Size = new Size(129, 15);
            lblDuracionMax.TabIndex = 27;
            lblDuracionMax.Text = "Duración máxima (m):";
            // 
            // lblDuracionMin
            // 
            lblDuracionMin.AutoSize = true;
            lblDuracionMin.Location = new Point(11, 72);
            lblDuracionMin.Name = "lblDuracionMin";
            lblDuracionMin.Size = new Size(126, 15);
            lblDuracionMin.TabIndex = 26;
            lblDuracionMin.Text = "Duración mínima (m):";
            // 
            // lblTipoCancha
            // 
            lblTipoCancha.AutoSize = true;
            lblTipoCancha.Location = new Point(45, 37);
            lblTipoCancha.Name = "lblTipoCancha";
            lblTipoCancha.Size = new Size(92, 15);
            lblTipoCancha.TabIndex = 25;
            lblTipoCancha.Text = "Tipo de cancha:";
            // 
            // numLargo
            // 
            numLargo.DecimalPlaces = 2;
            numLargo.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numLargo.Location = new Point(143, 182);
            numLargo.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numLargo.Name = "numLargo";
            numLargo.Size = new Size(120, 23);
            numLargo.TabIndex = 24;
            // 
            // numAncho
            // 
            numAncho.DecimalPlaces = 2;
            numAncho.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numAncho.Location = new Point(143, 145);
            numAncho.Maximum = new decimal(new int[] { 85, 0, 0, 0 });
            numAncho.Name = "numAncho";
            numAncho.Size = new Size(120, 23);
            numAncho.TabIndex = 23;
            // 
            // numDuracionMax
            // 
            numDuracionMax.Location = new Point(143, 107);
            numDuracionMax.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            numDuracionMax.Name = "numDuracionMax";
            numDuracionMax.Size = new Size(120, 23);
            numDuracionMax.TabIndex = 22;
            // 
            // numDuracionMin
            // 
            numDuracionMin.Location = new Point(143, 70);
            numDuracionMin.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            numDuracionMin.Name = "numDuracionMin";
            numDuracionMin.Size = new Size(120, 23);
            numDuracionMin.TabIndex = 21;
            // 
            // txtTipoCancha
            // 
            txtTipoCancha.Location = new Point(143, 34);
            txtTipoCancha.Name = "txtTipoCancha";
            txtTipoCancha.Size = new Size(120, 23);
            txtTipoCancha.TabIndex = 20;
            // 
            // cb_superficies
            // 
            cb_superficies.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_superficies.FormattingEnabled = true;
            cb_superficies.Location = new Point(143, 254);
            cb_superficies.Name = "cb_superficies";
            cb_superficies.Size = new Size(121, 23);
            cb_superficies.TabIndex = 19;
            // 
            // RegistrarTipoCanchaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(664, 411);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(gbDatos);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistrarTipoCanchaForm";
            Text = "Gol Ahora - Registrar tipo de cancha";
            Load += RegistrarTipoCanchaForm_Load;
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCapacidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLargo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAncho).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDuracionMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDuracionMin).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnRegistrar;
        private OpenFileDialog openFileDialog1;
        private Button btnCancelar;
        private GroupBox gbDatos;
        private PictureBox pictureBoxImagen;
        private Button btnImagenSeleccionar;
        private TextBox txtRutaImagen;
        private NumericUpDown numCapacidad;
        private Label lblSuperficie;
        private Label lblImagen;
        private Label lblCapacidad;
        private Label lblLargo;
        private Label lblAncho;
        private Label lblDuracionMax;
        private Label lblDuracionMin;
        private Label lblTipoCancha;
        private NumericUpDown numLargo;
        private NumericUpDown numAncho;
        private NumericUpDown numDuracionMax;
        private NumericUpDown numDuracionMin;
        private TextBox txtTipoCancha;
        private ComboBox cb_superficies;
    }
}