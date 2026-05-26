namespace GolAhora.Forms
{
    partial class RegistrarReservaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarReservaForm));
            btnVolver = new Button();
            btnRealizar = new Button();
            btnPago = new Button();
            chbDescuento = new CheckBox();
            cbHorarios = new ComboBox();
            lblHorarios = new Label();
            dtpDiaReserva = new DateTimePicker();
            lblDiaReserva = new Label();
            cbCancha = new ComboBox();
            lblCancha = new Label();
            txtNombreUsuario = new TextBox();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(13, 342);
            btnVolver.Margin = new Padding(4, 3, 4, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(88, 27);
            btnVolver.TabIndex = 23;
            btnVolver.Text = "Cancelar";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnRealizar
            // 
            btnRealizar.Location = new Point(286, 342);
            btnRealizar.Margin = new Padding(4, 3, 4, 3);
            btnRealizar.Name = "btnRealizar";
            btnRealizar.Size = new Size(88, 27);
            btnRealizar.TabIndex = 22;
            btnRealizar.Text = "Realizar";
            btnRealizar.UseVisualStyleBackColor = true;
            btnRealizar.Click += btnRealizar_Click;
            // 
            // btnPago
            // 
            btnPago.Location = new Point(13, 253);
            btnPago.Margin = new Padding(4, 3, 4, 3);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(103, 27);
            btnPago.TabIndex = 21;
            btnPago.Text = "Registrar pago";
            btnPago.UseVisualStyleBackColor = true;
            btnPago.Click += btnPago_Click;
            // 
            // chbDescuento
            // 
            chbDescuento.AutoSize = true;
            chbDescuento.Location = new Point(141, 258);
            chbDescuento.Margin = new Padding(4, 3, 4, 3);
            chbDescuento.Name = "chbDescuento";
            chbDescuento.Size = new Size(125, 19);
            chbDescuento.TabIndex = 20;
            chbDescuento.Text = "Aplicar descuento";
            chbDescuento.UseVisualStyleBackColor = true;
            // 
            // cbHorarios
            // 
            cbHorarios.FormattingEnabled = true;
            cbHorarios.Items.AddRange(new object[] { "8:00", "18:00" });
            cbHorarios.Location = new Point(141, 193);
            cbHorarios.Margin = new Padding(4, 3, 4, 3);
            cbHorarios.Name = "cbHorarios";
            cbHorarios.Size = new Size(168, 23);
            cbHorarios.TabIndex = 19;
            // 
            // lblHorarios
            // 
            lblHorarios.AutoSize = true;
            lblHorarios.Location = new Point(9, 196);
            lblHorarios.Margin = new Padding(4, 0, 4, 0);
            lblHorarios.Name = "lblHorarios";
            lblHorarios.Size = new Size(124, 15);
            lblHorarios.TabIndex = 18;
            lblHorarios.Text = "Horarios disponibles: ";
            // 
            // dtpDiaReserva
            // 
            dtpDiaReserva.Format = DateTimePickerFormat.Short;
            dtpDiaReserva.Location = new Point(141, 134);
            dtpDiaReserva.Margin = new Padding(4, 3, 4, 3);
            dtpDiaReserva.Name = "dtpDiaReserva";
            dtpDiaReserva.Size = new Size(233, 23);
            dtpDiaReserva.TabIndex = 17;
            // 
            // lblDiaReserva
            // 
            lblDiaReserva.AutoSize = true;
            lblDiaReserva.Location = new Point(9, 142);
            lblDiaReserva.Margin = new Padding(4, 0, 4, 0);
            lblDiaReserva.Name = "lblDiaReserva";
            lblDiaReserva.Size = new Size(102, 15);
            lblDiaReserva.TabIndex = 16;
            lblDiaReserva.Text = "Dia de la reserva:";
            // 
            // cbCancha
            // 
            cbCancha.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCancha.FormattingEnabled = true;
            cbCancha.Items.AddRange(new object[] { "Cancha 1 - Fútbol 5 ", "Cancha 2 - Fútbol 7 " });
            cbCancha.Location = new Point(141, 73);
            cbCancha.Margin = new Padding(4, 3, 4, 3);
            cbCancha.Name = "cbCancha";
            cbCancha.Size = new Size(193, 23);
            cbCancha.TabIndex = 15;
            // 
            // lblCancha
            // 
            lblCancha.AutoSize = true;
            lblCancha.Location = new Point(9, 76);
            lblCancha.Margin = new Padding(4, 0, 4, 0);
            lblCancha.Name = "lblCancha";
            lblCancha.Size = new Size(98, 15);
            lblCancha.TabIndex = 14;
            lblCancha.Text = "Elija una cancha: ";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(141, 12);
            txtNombreUsuario.Margin = new Padding(4, 3, 4, 3);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(193, 23);
            txtNombreUsuario.TabIndex = 13;
            txtNombreUsuario.TextChanged += this.txtNombreUsuario_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(9, 15);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(101, 15);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "Nombre Usuario:";
            // 
            // RegistrarReservaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(384, 381);
            Controls.Add(btnVolver);
            Controls.Add(btnRealizar);
            Controls.Add(btnPago);
            Controls.Add(chbDescuento);
            Controls.Add(cbHorarios);
            Controls.Add(lblHorarios);
            Controls.Add(dtpDiaReserva);
            Controls.Add(lblDiaReserva);
            Controls.Add(cbCancha);
            Controls.Add(lblCancha);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblNombre);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(400, 420);
            MinimumSize = new Size(400, 420);
            Name = "RegistrarReservaForm";
            Text = "Gol Ahora - Registrar reserva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Button btnRealizar;
        private Button btnPago;
        private CheckBox chbDescuento;
        private ComboBox cbHorarios;
        private Label lblHorarios;
        private DateTimePicker dtpDiaReserva;
        private Label lblDiaReserva;
        private ComboBox cbCancha;
        private Label lblCancha;
        private TextBox txtNombreUsuario;
        private Label lblNombre;
    }
}