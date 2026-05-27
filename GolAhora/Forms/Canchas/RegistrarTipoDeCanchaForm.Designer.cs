using GolAhora.Properties;

namespace GolAhora.Forms
{
    partial class RegistroTipoDeCanchaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroTipoDeCanchaForm));
            nudLongVertical = new NumericUpDown();
            label4 = new Label();
            lblNombreTipo = new Label();
            txtNombreTipo = new TextBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            nudLongHorizontal = new NumericUpDown();
            label5 = new Label();
            cbDuracionReserva = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            openFileDialog1 = new OpenFileDialog();
            label6 = new Label();
            textBox1 = new TextBox();
            btnAddImagen = new Button();
            label1 = new Label();
            label7 = new Label();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudLongVertical).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLongHorizontal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // nudLongVertical
            // 
            nudLongVertical.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudLongVertical.Location = new Point(154, 61);
            nudLongVertical.Name = "nudLongVertical";
            nudLongVertical.Size = new Size(186, 23);
            nudLongVertical.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 63);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 30;
            label4.Text = "largo (mts):";
            // 
            // lblNombreTipo
            // 
            lblNombreTipo.AutoSize = true;
            lblNombreTipo.Location = new Point(47, 25);
            lblNombreTipo.Name = "lblNombreTipo";
            lblNombreTipo.Size = new Size(92, 15);
            lblNombreTipo.TabIndex = 20;
            lblNombreTipo.Text = "Tipo de cancha:";
            // 
            // txtNombreTipo
            // 
            txtNombreTipo.Location = new Point(154, 22);
            txtNombreTipo.Name = "txtNombreTipo";
            txtNombreTipo.Size = new Size(186, 23);
            txtNombreTipo.TabIndex = 19;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Location = new Point(347, 356);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 18;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 356);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // nudLongHorizontal
            // 
            nudLongHorizontal.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudLongHorizontal.Location = new Point(154, 101);
            nudLongHorizontal.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudLongHorizontal.Name = "nudLongHorizontal";
            nudLongHorizontal.Size = new Size(186, 23);
            nudLongHorizontal.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 103);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 32;
            label5.Text = "ancho (mts):";
            // 
            // cbDuracionReserva
            // 
            cbDuracionReserva.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDuracionReserva.FormattingEnabled = true;
            cbDuracionReserva.Items.AddRange(new object[] { "30 minutos", "1 hora", "2 horas", "3 horas", "4 horas" });
            cbDuracionReserva.Location = new Point(154, 304);
            cbDuracionReserva.Name = "cbDuracionReserva";
            cbDuracionReserva.Size = new Size(186, 23);
            cbDuracionReserva.TabIndex = 35;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "30 minutos", "1 hora", "2 horas", "3 horas", "4 horas" });
            comboBox1.Location = new Point(154, 263);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(186, 23);
            comboBox1.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 266);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 36;
            label2.Text = "Duración mínima:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown1.Location = new Point(154, 142);
            numericUpDown1.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(186, 23);
            numericUpDown1.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 144);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 38;
            label3.Text = "Capacidad:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 226);
            label6.Name = "label6";
            label6.Size = new Size(130, 15);
            label6.TabIndex = 40;
            label6.Text = "Img (config open file):";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 222);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 23);
            textBox1.TabIndex = 41;
            // 
            // btnAddImagen
            // 
            btnAddImagen.Cursor = Cursors.Hand;
            btnAddImagen.Location = new Point(355, 222);
            btnAddImagen.Name = "btnAddImagen";
            btnAddImagen.Size = new Size(44, 23);
            btnAddImagen.TabIndex = 42;
            btnAddImagen.Text = "Add";
            btnAddImagen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 307);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 34;
            label1.Text = "Duración máxima:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(72, 185);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 46;
            label7.Text = "Superficie:";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "--esto lo llena la api" });
            comboBox2.Location = new Point(154, 182);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(186, 23);
            comboBox2.TabIndex = 45;
            // 
            // RegistroTipoDeCanchaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(434, 391);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(btnAddImagen);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(cbDuracionReserva);
            Controls.Add(label1);
            Controls.Add(nudLongHorizontal);
            Controls.Add(label5);
            Controls.Add(nudLongVertical);
            Controls.Add(label4);
            Controls.Add(lblNombreTipo);
            Controls.Add(txtNombreTipo);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(450, 430);
            MinimumSize = new Size(450, 430);
            Name = "RegistroTipoDeCanchaForm";
            Text = "Gol Ahora - Registrar tipo de cancha";
            ((System.ComponentModel.ISupportInitialize)nudLongVertical).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLongHorizontal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudLongVertical;
        private Label label4;
        private Label lblNombreTipo;
        private TextBox txtNombreTipo;
        private Button btnRegistrar;
        private Button btnCancelar;
        private NumericUpDown nudLongHorizontal;
        private Label label5;
        private ComboBox cbDuracionReserva;
        private ComboBox comboBox1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private OpenFileDialog openFileDialog1;
        private Label label6;
        private TextBox textBox1;
        private Button btnAddImagen;
        private Label label1;
        private Label label7;
        private ComboBox comboBox2;
    }
}