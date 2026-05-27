namespace GolAhora.Forms
{
    partial class RegistrarCanchaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarCanchaForm));
            btnCancelar = new Button();
            btnRegistrar = new Button();
            txtNombreCancha = new TextBox();
            lblTipoCancha = new Label();
            cbTipoCancha = new ComboBox();
            label1 = new Label();
            lblNuevoTipo = new Label();
            linkLblNuevoTipo = new LinkLabel();
            cbHoraInicio = new ComboBox();
            lblNombreCancha = new Label();
            label2 = new Label();
            label3 = new Label();
            cbHoraFin = new ComboBox();
            label4 = new Label();
            nudCapacidad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 266);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Location = new Point(297, 266);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtNombreCancha
            // 
            txtNombreCancha.Location = new Point(173, 19);
            txtNombreCancha.Name = "txtNombreCancha";
            txtNombreCancha.Size = new Size(186, 23);
            txtNombreCancha.TabIndex = 2;
            txtNombreCancha.TextChanged += txtNombreCancha_TextChanged;
            // 
            // lblTipoCancha
            // 
            lblTipoCancha.AutoSize = true;
            lblTipoCancha.ImageAlign = ContentAlignment.BottomRight;
            lblTipoCancha.Location = new Point(75, 101);
            lblTipoCancha.Name = "lblTipoCancha";
            lblTipoCancha.Size = new Size(92, 15);
            lblTipoCancha.TabIndex = 5;
            lblTipoCancha.Text = "Tipo de cancha:";
            // 
            // cbTipoCancha
            // 
            cbTipoCancha.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoCancha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbTipoCancha.FormattingEnabled = true;
            cbTipoCancha.Items.AddRange(new object[] { "Cancha de 5", "Cancha de 7", "Cancha de 11", "", "--Esto lo llena la api" });
            cbTipoCancha.Location = new Point(173, 98);
            cbTipoCancha.Name = "cbTipoCancha";
            cbTipoCancha.Size = new Size(186, 23);
            cbTipoCancha.TabIndex = 6;
            cbTipoCancha.SelectedIndexChanged += cbTipoCancha_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 170);
            label1.Name = "label1";
            label1.Size = new Size(182, 15);
            label1.TabIndex = 7;
            label1.Text = "Rango de disponibilidad horaria:";
            // 
            // lblNuevoTipo
            // 
            lblNuevoTipo.AutoSize = true;
            lblNuevoTipo.ForeColor = Color.SteelBlue;
            lblNuevoTipo.Location = new Point(12, 124);
            lblNuevoTipo.Name = "lblNuevoTipo";
            lblNuevoTipo.Size = new Size(259, 15);
            lblNuevoTipo.TabIndex = 8;
            lblNuevoTipo.Text = "¿Necesitas registrar un nuevo tipo de cancha?";
            // 
            // linkLblNuevoTipo
            // 
            linkLblNuevoTipo.AutoSize = true;
            linkLblNuevoTipo.Location = new Point(277, 124);
            linkLblNuevoTipo.Name = "linkLblNuevoTipo";
            linkLblNuevoTipo.Size = new Size(82, 15);
            linkLblNuevoTipo.TabIndex = 9;
            linkLblNuevoTipo.TabStop = true;
            linkLblNuevoTipo.Text = "Haz click aqui";
            linkLblNuevoTipo.LinkClicked += linkLblNuevoTipo_LinkClicked;
            // 
            // cbHoraInicio
            // 
            cbHoraInicio.BackColor = SystemColors.Window;
            cbHoraInicio.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHoraInicio.FormattingEnabled = true;
            cbHoraInicio.Items.AddRange(new object[] { "06:00 AM", "07:00 AM", "08:00 AM", "09:00 AM", "10:00 AM", "11:00 AM", "12:00 AM", "01:00 PM", "02:00 PM", "03:00 PM", "04:00 PM", "05:00 PM", "06:00 PM", "07:00 PM", "08:00 PM", "09:00 PM", "10:00 PM", "11:00 PM", "12:00 PM", "01:00 AM", "02:00 AM" });
            cbHoraInicio.Location = new Point(259, 167);
            cbHoraInicio.Name = "cbHoraInicio";
            cbHoraInicio.Size = new Size(100, 23);
            cbHoraInicio.TabIndex = 10;
            cbHoraInicio.SelectedIndexChanged += cbHoraInicio_SelectedIndexChanged;
            // 
            // lblNombreCancha
            // 
            lblNombreCancha.AutoSize = true;
            lblNombreCancha.Location = new Point(111, 22);
            lblNombreCancha.Name = "lblNombreCancha";
            lblNombreCancha.Size = new Size(56, 15);
            lblNombreCancha.TabIndex = 3;
            lblNombreCancha.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 170);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 11;
            label2.Text = "Desde:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 211);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 12;
            label3.Text = "Hasta:";
            // 
            // cbHoraFin
            // 
            cbHoraFin.BackColor = SystemColors.Window;
            cbHoraFin.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHoraFin.FormattingEnabled = true;
            cbHoraFin.Items.AddRange(new object[] { "06:00 AM", "07:00 AM", "08:00 AM", "09:00 AM", "10:00 AM", "11:00 AM", "12:00 AM", "01:00 PM", "02:00 PM", "03:00 PM", "04:00 PM", "05:00 PM", "06:00 PM", "07:00 PM", "08:00 PM", "09:00 PM", "10:00 PM", "11:00 PM", "12:00 PM", "01:00 AM", "02:00 AM" });
            cbHoraFin.Location = new Point(259, 208);
            cbHoraFin.Name = "cbHoraFin";
            cbHoraFin.Size = new Size(100, 23);
            cbHoraFin.TabIndex = 13;
            cbHoraFin.SelectedIndexChanged += cbHoraFin_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 62);
            label4.Name = "label4";
            label4.Size = new Size(155, 15);
            label4.TabIndex = 15;
            label4.Text = "Plazo de cancelación (min):";
            // 
            // nudCapacidad
            // 
            nudCapacidad.Location = new Point(173, 60);
            nudCapacidad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudCapacidad.Name = "nudCapacidad";
            nudCapacidad.Size = new Size(186, 23);
            nudCapacidad.TabIndex = 16;
            // 
            // RegistrarCanchaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(384, 301);
            Controls.Add(nudCapacidad);
            Controls.Add(label4);
            Controls.Add(cbHoraFin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbHoraInicio);
            Controls.Add(linkLblNuevoTipo);
            Controls.Add(lblNuevoTipo);
            Controls.Add(label1);
            Controls.Add(cbTipoCancha);
            Controls.Add(lblTipoCancha);
            Controls.Add(lblNombreCancha);
            Controls.Add(txtNombreCancha);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(400, 340);
            MinimumSize = new Size(400, 340);
            Name = "RegistrarCanchaForm";
            Text = "Gol Ahora - Registrar Cancha";
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnRegistrar;
        private TextBox txtNombreCancha;
        private Label lblTipoCancha;
        private ComboBox cbTipoCancha;
        private Label label1;
        private Label lblNuevoTipo;
        private LinkLabel linkLblNuevoTipo;
        private ComboBox cbHoraInicio;
        private Label lblNombreCancha;
        private Label label2;
        private Label label3;
        private ComboBox cbHoraFin;
        private Label label4;
        private NumericUpDown nudCapacidad;
    }
}