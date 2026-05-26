namespace GolAhora.Forms.UserControls
{
    partial class ucReservas
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
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            listBoxReservas = new ListBox();
            LblNuevaReserva = new Label();
            btnCrear = new Button();
            btnModificar = new Button();
            btnDarBaja = new Button();
            pnlAltaReserva = new Panel();
            btnVolver = new Button();
            btnFinalizar = new Button();
            btnPago = new Button();
            chbDescuento = new CheckBox();
            cmbHorarios = new ComboBox();
            lblHorarios = new Label();
            dtpDiaR = new DateTimePicker();
            lblDiaReserva = new Label();
            cbTipoCancha = new ComboBox();
            txtCanchas = new Label();
            txtnNombreUsu = new TextBox();
            lblNombre = new Label();
            lblFiltro = new Label();
            pnlAltaReserva.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Usuario", "Cancha" });
            comboBox2.Location = new Point(427, 3);
            comboBox2.Margin = new Padding(4, 3, 4, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(103, 23);
            comboBox2.TabIndex = 0;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(538, 3);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(98, 23);
            comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(644, 3);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(88, 27);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBoxReservas
            // 
            listBoxReservas.BackColor = SystemColors.ActiveCaption;
            listBoxReservas.BorderStyle = BorderStyle.FixedSingle;
            listBoxReservas.FormattingEnabled = true;
            listBoxReservas.Location = new Point(23, 47);
            listBoxReservas.Margin = new Padding(4, 3, 4, 3);
            listBoxReservas.Name = "listBoxReservas";
            listBoxReservas.Size = new Size(654, 272);
            listBoxReservas.TabIndex = 3;
            listBoxReservas.SelectedIndexChanged += listBoxReservas_SelectedIndexChanged;
            listBoxReservas.DoubleClick += listBoxReservas_DoubleClick;
            // 
            // LblNuevaReserva
            // 
            LblNuevaReserva.AutoSize = true;
            LblNuevaReserva.Location = new Point(91, 9);
            LblNuevaReserva.Margin = new Padding(4, 0, 4, 0);
            LblNuevaReserva.Name = "LblNuevaReserva";
            LblNuevaReserva.Size = new Size(94, 15);
            LblNuevaReserva.TabIndex = 4;
            LblNuevaReserva.Text = "Nueva Reserva:";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(187, 3);
            btnCrear.Margin = new Padding(4, 3, 4, 3);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 28);
            btnCrear.TabIndex = 5;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(24, 366);
            btnModificar.Margin = new Padding(4, 3, 4, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(88, 27);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Visible = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnDarBaja
            // 
            btnDarBaja.BackColor = Color.Red;
            btnDarBaja.Location = new Point(142, 366);
            btnDarBaja.Margin = new Padding(4, 3, 4, 3);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(168, 27);
            btnDarBaja.TabIndex = 7;
            btnDarBaja.Text = "Dar de baja(Reembolso)";
            btnDarBaja.UseVisualStyleBackColor = false;
            btnDarBaja.Visible = false;
            btnDarBaja.Click += btnDarBaja_Click;
            // 
            // pnlAltaReserva
            // 
            pnlAltaReserva.AutoScroll = true;
            pnlAltaReserva.BackColor = SystemColors.ActiveCaption;
            pnlAltaReserva.Controls.Add(btnVolver);
            pnlAltaReserva.Controls.Add(btnFinalizar);
            pnlAltaReserva.Controls.Add(btnPago);
            pnlAltaReserva.Controls.Add(chbDescuento);
            pnlAltaReserva.Controls.Add(cmbHorarios);
            pnlAltaReserva.Controls.Add(lblHorarios);
            pnlAltaReserva.Controls.Add(dtpDiaR);
            pnlAltaReserva.Controls.Add(lblDiaReserva);
            pnlAltaReserva.Controls.Add(cbTipoCancha);
            pnlAltaReserva.Controls.Add(txtCanchas);
            pnlAltaReserva.Controls.Add(txtnNombreUsu);
            pnlAltaReserva.Controls.Add(lblNombre);
            pnlAltaReserva.Location = new Point(0, 0);
            pnlAltaReserva.Margin = new Padding(4, 3, 4, 3);
            pnlAltaReserva.Name = "pnlAltaReserva";
            pnlAltaReserva.Size = new Size(748, 482);
            pnlAltaReserva.TabIndex = 8;
            pnlAltaReserva.Visible = false;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(103, 365);
            btnVolver.Margin = new Padding(4, 3, 4, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(88, 27);
            btnVolver.TabIndex = 11;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(265, 365);
            btnFinalizar.Margin = new Padding(4, 3, 4, 3);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(127, 27);
            btnFinalizar.TabIndex = 10;
            btnFinalizar.Text = "Finalizar Reserva";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnPago
            // 
            btnPago.Location = new Point(159, 314);
            btnPago.Margin = new Padding(4, 3, 4, 3);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(103, 27);
            btnPago.TabIndex = 9;
            btnPago.Text = "Registrar pago";
            btnPago.UseVisualStyleBackColor = true;
            btnPago.Click += btnPago_Click;
            // 
            // chbDescuento
            // 
            chbDescuento.AutoSize = true;
            chbDescuento.Location = new Point(159, 277);
            chbDescuento.Margin = new Padding(4, 3, 4, 3);
            chbDescuento.Name = "chbDescuento";
            chbDescuento.Size = new Size(125, 19);
            chbDescuento.TabIndex = 8;
            chbDescuento.Text = "Aplicar descuento";
            chbDescuento.UseVisualStyleBackColor = true;
            // 
            // cmbHorarios
            // 
            cmbHorarios.FormattingEnabled = true;
            cmbHorarios.Items.AddRange(new object[] { "8:00", "18:00" });
            cmbHorarios.Location = new Point(159, 224);
            cmbHorarios.Margin = new Padding(4, 3, 4, 3);
            cmbHorarios.Name = "cmbHorarios";
            cmbHorarios.Size = new Size(168, 23);
            cmbHorarios.TabIndex = 7;
            // 
            // lblHorarios
            // 
            lblHorarios.AutoSize = true;
            lblHorarios.Location = new Point(35, 227);
            lblHorarios.Margin = new Padding(4, 0, 4, 0);
            lblHorarios.Name = "lblHorarios";
            lblHorarios.Size = new Size(54, 15);
            lblHorarios.TabIndex = 6;
            lblHorarios.Text = "Horarios";
            // 
            // dtpDiaR
            // 
            dtpDiaR.Format = DateTimePickerFormat.Short;
            dtpDiaR.Location = new Point(159, 166);
            dtpDiaR.Margin = new Padding(4, 3, 4, 3);
            dtpDiaR.Name = "dtpDiaR";
            dtpDiaR.Size = new Size(233, 23);
            dtpDiaR.TabIndex = 5;
            // 
            // lblDiaReserva
            // 
            lblDiaReserva.AutoSize = true;
            lblDiaReserva.Location = new Point(35, 173);
            lblDiaReserva.Margin = new Padding(4, 0, 4, 0);
            lblDiaReserva.Name = "lblDiaReserva";
            lblDiaReserva.Size = new Size(76, 15);
            lblDiaReserva.TabIndex = 4;
            lblDiaReserva.Text = "Dia Reserva:";
            // 
            // cbTipoCancha
            // 
            cbTipoCancha.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoCancha.FormattingEnabled = true;
            cbTipoCancha.Items.AddRange(new object[] { "Cancha 1 - Fútbol 5 ", "Cancha 2 - Fútbol 7 " });
            cbTipoCancha.Location = new Point(159, 111);
            cbTipoCancha.Margin = new Padding(4, 3, 4, 3);
            cbTipoCancha.Name = "cbTipoCancha";
            cbTipoCancha.Size = new Size(193, 23);
            cbTipoCancha.TabIndex = 3;
            // 
            // txtCanchas
            // 
            txtCanchas.AutoSize = true;
            txtCanchas.Location = new Point(35, 114);
            txtCanchas.Margin = new Padding(4, 0, 4, 0);
            txtCanchas.Name = "txtCanchas";
            txtCanchas.Size = new Size(92, 15);
            txtCanchas.TabIndex = 2;
            txtCanchas.Text = "Tipo de cancha:";
            // 
            // txtnNombreUsu
            // 
            txtnNombreUsu.Location = new Point(159, 43);
            txtnNombreUsu.Margin = new Padding(4, 3, 4, 3);
            txtnNombreUsu.Name = "txtnNombreUsu";
            txtnNombreUsu.Size = new Size(193, 23);
            txtnNombreUsu.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(35, 46);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(101, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre Usuario:";
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(358, 7);
            lblFiltro.Margin = new Padding(4, 0, 4, 0);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(65, 15);
            lblFiltro.TabIndex = 9;
            lblFiltro.Text = "Filtrar por:";
            // 
            // ucReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(lblFiltro);
            Controls.Add(pnlAltaReserva);
            Controls.Add(btnDarBaja);
            Controls.Add(btnModificar);
            Controls.Add(btnCrear);
            Controls.Add(LblNuevaReserva);
            Controls.Add(listBoxReservas);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(comboBox2);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ucReservas";
            Size = new Size(748, 483);
            pnlAltaReserva.ResumeLayout(false);
            pnlAltaReserva.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxReservas;
        private System.Windows.Forms.Label LblNuevaReserva;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnDarBaja;
        private System.Windows.Forms.Panel pnlAltaReserva;
        private System.Windows.Forms.ComboBox cbTipoCancha;
        private System.Windows.Forms.Label txtCanchas;
        private System.Windows.Forms.TextBox txtnNombreUsu;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DateTimePicker dtpDiaR;
        private System.Windows.Forms.Label lblDiaReserva;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.CheckBox chbDescuento;
        private System.Windows.Forms.ComboBox cmbHorarios;
        private System.Windows.Forms.Label lblHorarios;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblFiltro;
    }
}
