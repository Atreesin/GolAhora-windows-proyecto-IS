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
            cb_superficies = new ComboBox();
            btnAgregarTipoCancha = new Button();
            txtTipoCancha = new TextBox();
            numDuracionMin = new NumericUpDown();
            numDuracionMax = new NumericUpDown();
            numAncho = new NumericUpDown();
            numLargo = new NumericUpDown();
            lblTipoCancha = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            numCapacidad = new NumericUpDown();
            openFileDialog1 = new OpenFileDialog();
            txtRutaImagen = new TextBox();
            btnImagenSelect = new Button();
            pictureBoxImagen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numDuracionMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDuracionMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAncho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLargo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCapacidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            SuspendLayout();
            // 
            // cb_superficies
            // 
            cb_superficies.FormattingEnabled = true;
            cb_superficies.Location = new Point(123, 247);
            cb_superficies.Name = "cb_superficies";
            cb_superficies.Size = new Size(121, 23);
            cb_superficies.TabIndex = 0;
            cb_superficies.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnAgregarTipoCancha
            // 
            btnAgregarTipoCancha.Location = new Point(67, 336);
            btnAgregarTipoCancha.Name = "btnAgregarTipoCancha";
            btnAgregarTipoCancha.Size = new Size(176, 23);
            btnAgregarTipoCancha.TabIndex = 1;
            btnAgregarTipoCancha.Text = "Agregar Tipo de Cancha";
            btnAgregarTipoCancha.UseVisualStyleBackColor = true;
            btnAgregarTipoCancha.Click += btnAgregarTipoCancha_Click;
            // 
            // txtTipoCancha
            // 
            txtTipoCancha.Location = new Point(123, 75);
            txtTipoCancha.Name = "txtTipoCancha";
            txtTipoCancha.Size = new Size(120, 23);
            txtTipoCancha.TabIndex = 2;
            // 
            // numDuracionMin
            // 
            numDuracionMin.Location = new Point(123, 104);
            numDuracionMin.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            numDuracionMin.Name = "numDuracionMin";
            numDuracionMin.Size = new Size(120, 23);
            numDuracionMin.TabIndex = 3;
            // 
            // numDuracionMax
            // 
            numDuracionMax.Location = new Point(123, 133);
            numDuracionMax.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            numDuracionMax.Name = "numDuracionMax";
            numDuracionMax.Size = new Size(120, 23);
            numDuracionMax.TabIndex = 4;
            // 
            // numAncho
            // 
            numAncho.DecimalPlaces = 2;
            numAncho.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numAncho.Location = new Point(123, 160);
            numAncho.Maximum = new decimal(new int[] { 85, 0, 0, 0 });
            numAncho.Name = "numAncho";
            numAncho.Size = new Size(120, 23);
            numAncho.TabIndex = 5;
            // 
            // numLargo
            // 
            numLargo.DecimalPlaces = 2;
            numLargo.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numLargo.Location = new Point(123, 189);
            numLargo.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numLargo.Name = "numLargo";
            numLargo.Size = new Size(120, 23);
            numLargo.TabIndex = 6;
            // 
            // lblTipoCancha
            // 
            lblTipoCancha.AutoSize = true;
            lblTipoCancha.Location = new Point(21, 83);
            lblTipoCancha.Name = "lblTipoCancha";
            lblTipoCancha.Size = new Size(91, 15);
            lblTipoCancha.TabIndex = 7;
            lblTipoCancha.Text = "Tipo de cancha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 112);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 8;
            label2.Text = "Duración mínima:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 141);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 9;
            label3.Text = "Druación máxima:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 168);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 10;
            label4.Text = "Ancho:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 197);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 11;
            label5.Text = "Largo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 226);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 12;
            label6.Text = "Capacidad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 294);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 13;
            label7.Text = "Imagen:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 255);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 14;
            label8.Text = "Superficie:";
            // 
            // numCapacidad
            // 
            numCapacidad.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numCapacidad.Location = new Point(123, 218);
            numCapacidad.Maximum = new decimal(new int[] { 22, 0, 0, 0 });
            numCapacidad.Name = "numCapacidad";
            numCapacidad.Size = new Size(120, 23);
            numCapacidad.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // txtRutaImagen
            // 
            txtRutaImagen.Location = new Point(123, 286);
            txtRutaImagen.Name = "txtRutaImagen";
            txtRutaImagen.Size = new Size(121, 23);
            txtRutaImagen.TabIndex = 16;
            // 
            // btnImagenSelect
            // 
            btnImagenSelect.Location = new Point(250, 286);
            btnImagenSelect.Name = "btnImagenSelect";
            btnImagenSelect.Size = new Size(75, 23);
            btnImagenSelect.TabIndex = 17;
            btnImagenSelect.Text = "Seleccionar";
            btnImagenSelect.UseVisualStyleBackColor = true;
            btnImagenSelect.Click += btnImagenSelect_Click;
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.Location = new Point(373, 77);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(335, 232);
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagen.TabIndex = 18;
            pictureBoxImagen.TabStop = false;
            // 
            // RegistrarTipoCanchaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxImagen);
            Controls.Add(btnImagenSelect);
            Controls.Add(txtRutaImagen);
            Controls.Add(numCapacidad);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTipoCancha);
            Controls.Add(numLargo);
            Controls.Add(numAncho);
            Controls.Add(numDuracionMax);
            Controls.Add(numDuracionMin);
            Controls.Add(txtTipoCancha);
            Controls.Add(btnAgregarTipoCancha);
            Controls.Add(cb_superficies);
            Name = "RegistrarTipoCanchaForm";
            Text = "RegistrarTipoCanchaForm";
            Load += RegistrarTipoCanchaForm_Load;
            ((System.ComponentModel.ISupportInitialize)numDuracionMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDuracionMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAncho).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLargo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCapacidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_superficies;
        private Button btnAgregarTipoCancha;
        private TextBox txtTipoCancha;
        private NumericUpDown numDuracionMin;
        private NumericUpDown numDuracionMax;
        private NumericUpDown numAncho;
        private NumericUpDown numLargo;
        private Label lblTipoCancha;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private NumericUpDown numCapacidad;
        private OpenFileDialog openFileDialog1;
        private TextBox txtRutaImagen;
        private Button btnImagenSelect;
        private PictureBox pictureBoxImagen;
    }
}