namespace GolAhora.Forms
{
    partial class MenuPrincipalForm
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
            button1 = new Button();
            lblUsername = new Label();
            txtUsername = new Label();
            txtNombre = new Label();
            lblNombre = new Label();
            txtApellido = new Label();
            lblApellido = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(335, 195);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(15, 11);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(71, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.AutoSize = true;
            txtUsername.Location = new Point(84, 11);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(30, 15);
            txtUsername.TabIndex = 2;
            txtUsername.Text = "N/N";
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.Location = new Point(84, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(30, 15);
            txtNombre.TabIndex = 4;
            txtNombre.Text = "N/N";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(15, 41);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(60, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // txtApellido
            // 
            txtApellido.AutoSize = true;
            txtApellido.Location = new Point(84, 56);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(30, 15);
            txtApellido.TabIndex = 6;
            txtApellido.Text = "N/N";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(15, 56);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(63, 15);
            lblApellido.TabIndex = 5;
            lblApellido.Text = "Apellido:";
            // 
            // MenuPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "MenuPrincipalForm";
            Text = "MenuPrincipalForm";
            Load += MenuPrincipalForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblUsername;
        private Label txtUsername;
        private Label txtNombre;
        private Label lblNombre;
        private Label txtApellido;
        private Label lblApellido;
    }
}