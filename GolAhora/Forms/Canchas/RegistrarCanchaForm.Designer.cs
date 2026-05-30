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
            lblTipo = new Label();
            cbTipoCancha = new ComboBox();
            lblNuevoTipo = new Label();
            linkLblNuevoTipo = new LinkLabel();
            lblNombre = new Label();
            lblPlazo = new Label();
            nudPlazo = new NumericUpDown();
            nudPrecio = new NumericUpDown();
            lblPrecio = new Label();
            ((System.ComponentModel.ISupportInitialize)nudPlazo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 226);
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
            btnRegistrar.Location = new Point(297, 226);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtNombreCancha
            // 
            txtNombreCancha.Location = new Point(176, 22);
            txtNombreCancha.Name = "txtNombreCancha";
            txtNombreCancha.Size = new Size(186, 23);
            txtNombreCancha.TabIndex = 2;
            txtNombreCancha.TextChanged += txtNombreCancha_TextChanged;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.ImageAlign = ContentAlignment.BottomRight;
            lblTipo.Location = new Point(78, 150);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(92, 15);
            lblTipo.TabIndex = 5;
            lblTipo.Text = "Tipo de cancha:";
            // 
            // cbTipoCancha
            // 
            cbTipoCancha.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoCancha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbTipoCancha.FormattingEnabled = true;
            cbTipoCancha.Items.AddRange(new object[] { "Cancha de 5", "Cancha de 7", "Cancha de 11", "", "--Esto lo llena la api" });
            cbTipoCancha.Location = new Point(176, 147);
            cbTipoCancha.Name = "cbTipoCancha";
            cbTipoCancha.Size = new Size(186, 23);
            cbTipoCancha.TabIndex = 6;
            cbTipoCancha.SelectedIndexChanged += cbTipoCancha_SelectedIndexChanged;
            // 
            // lblNuevoTipo
            // 
            lblNuevoTipo.AutoSize = true;
            lblNuevoTipo.ForeColor = Color.SteelBlue;
            lblNuevoTipo.Location = new Point(15, 173);
            lblNuevoTipo.Name = "lblNuevoTipo";
            lblNuevoTipo.Size = new Size(259, 15);
            lblNuevoTipo.TabIndex = 8;
            lblNuevoTipo.Text = "¿Necesitas registrar un nuevo tipo de cancha?";
            // 
            // linkLblNuevoTipo
            // 
            linkLblNuevoTipo.AutoSize = true;
            linkLblNuevoTipo.Location = new Point(280, 173);
            linkLblNuevoTipo.Name = "linkLblNuevoTipo";
            linkLblNuevoTipo.Size = new Size(82, 15);
            linkLblNuevoTipo.TabIndex = 9;
            linkLblNuevoTipo.TabStop = true;
            linkLblNuevoTipo.Text = "Haz click aqui";
            linkLblNuevoTipo.LinkClicked += linkLblNuevoTipo_LinkClicked;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(114, 25);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // lblPlazo
            // 
            lblPlazo.AutoSize = true;
            lblPlazo.Location = new Point(24, 65);
            lblPlazo.Name = "lblPlazo";
            lblPlazo.Size = new Size(146, 15);
            lblPlazo.TabIndex = 15;
            lblPlazo.Text = "Plazo de cancelación (hs):";
            // 
            // nudPlazo
            // 
            nudPlazo.Location = new Point(176, 63);
            nudPlazo.Maximum = new decimal(new int[] { 8760, 0, 0, 0 });
            nudPlazo.Name = "nudPlazo";
            nudPlazo.Size = new Size(186, 23);
            nudPlazo.TabIndex = 16;
            // 
            // nudPrecio
            // 
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Location = new Point(176, 106);
            nudPrecio.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(186, 23);
            nudPrecio.TabIndex = 18;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(25, 108);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(145, 15);
            lblPrecio.TabIndex = 17;
            lblPrecio.Text = "Precio de reserva x hora:";
            // 
            // RegistrarCanchaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(384, 261);
            Controls.Add(nudPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(nudPlazo);
            Controls.Add(lblPlazo);
            Controls.Add(linkLblNuevoTipo);
            Controls.Add(lblNuevoTipo);
            Controls.Add(cbTipoCancha);
            Controls.Add(lblTipo);
            Controls.Add(lblNombre);
            Controls.Add(txtNombreCancha);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(400, 300);
            MinimumSize = new Size(400, 300);
            Name = "RegistrarCanchaForm";
            Text = "Gol Ahora - Registrar Cancha";
            Load += RegistrarCanchaForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudPlazo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnRegistrar;
        private TextBox txtNombreCancha;
        private Label lblTipo;
        private ComboBox cbTipoCancha;
        private Label lblNuevoTipo;
        private LinkLabel linkLblNuevoTipo;
        private Label lblNombre;
        private Label lblPlazo;
        private NumericUpDown nudPlazo;
        private NumericUpDown nudPrecio;
        private Label lblPrecio;
    }
}