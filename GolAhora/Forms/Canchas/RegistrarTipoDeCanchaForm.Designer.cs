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
            label1 = new Label();
            cbDuracionReserva = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudLongVertical).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLongHorizontal).BeginInit();
            SuspendLayout();
            // 
            // nudLongVertical
            // 
            nudLongVertical.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudLongVertical.Location = new Point(196, 65);
            nudLongVertical.Name = "nudLongVertical";
            nudLongVertical.Size = new Size(186, 23);
            nudLongVertical.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 67);
            label4.Name = "label4";
            label4.Size = new Size(153, 15);
            label4.TabIndex = 30;
            label4.Text = "Longitud en vertical (mts):";
            // 
            // lblNombreTipo
            // 
            lblNombreTipo.AutoSize = true;
            lblNombreTipo.Location = new Point(12, 27);
            lblNombreTipo.Name = "lblNombreTipo";
            lblNombreTipo.Size = new Size(159, 15);
            lblNombreTipo.TabIndex = 20;
            lblNombreTipo.Text = "Nombre del tipo de cancha:";
            // 
            // txtNombreTipo
            // 
            txtNombreTipo.Location = new Point(196, 19);
            txtNombreTipo.Name = "txtNombreTipo";
            txtNombreTipo.Size = new Size(186, 23);
            txtNombreTipo.TabIndex = 19;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Location = new Point(307, 196);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 18;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(14, 196);
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
            nudLongHorizontal.Location = new Point(196, 106);
            nudLongHorizontal.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudLongHorizontal.Name = "nudLongHorizontal";
            nudLongHorizontal.Size = new Size(186, 23);
            nudLongHorizontal.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 108);
            label5.Name = "label5";
            label5.Size = new Size(167, 15);
            label5.TabIndex = 32;
            label5.Text = "Longitud en horizontal (mts):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 147);
            label1.Name = "label1";
            label1.Size = new Size(184, 15);
            label1.TabIndex = 34;
            label1.Text = "Duración máxima de la reserva: ";
            // 
            // cbDuracionReserva
            // 
            cbDuracionReserva.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDuracionReserva.FormattingEnabled = true;
            cbDuracionReserva.Items.AddRange(new object[] { "1 hora", "2 horas", "4 horas" });
            cbDuracionReserva.Location = new Point(196, 144);
            cbDuracionReserva.Name = "cbDuracionReserva";
            cbDuracionReserva.Size = new Size(186, 23);
            cbDuracionReserva.TabIndex = 35;
            // 
            // RegistroTipoDeCanchaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(394, 231);
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
            MaximumSize = new Size(410, 270);
            MinimumSize = new Size(410, 270);
            Name = "RegistroTipoDeCanchaForm";
            Text = "Gol Ahora - Registro de tipo de cancha";
            ((System.ComponentModel.ISupportInitialize)nudLongVertical).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLongHorizontal).EndInit();
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
        private Label label1;
        private ComboBox cbDuracionReserva;
    }
}