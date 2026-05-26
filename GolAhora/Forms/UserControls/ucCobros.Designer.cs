namespace GolAhora.Forms.UserControls
{
    partial class ucCobros
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
            btnRegistrar = new Button();
            btnListar = new Button();
            label7 = new Label();
            label1 = new Label();
            lbCobros = new ListBox();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.ControlLight;
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegistrar.Location = new Point(612, 104);
            btnRegistrar.Margin = new Padding(4, 3, 4, 3);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(88, 27);
            btnRegistrar.TabIndex = 20;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRealizar_Click;
            // 
            // btnListar
            // 
            btnListar.BackColor = SystemColors.ControlLight;
            btnListar.Location = new Point(612, 288);
            btnListar.Margin = new Padding(4, 3, 4, 3);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(88, 27);
            btnListar.TabIndex = 21;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(468, 110);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 15);
            label7.TabIndex = 22;
            label7.Text = "Registrar Cobro :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(468, 294);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 23;
            label1.Text = "Registrar Recibo :";
            // 
            // lbCobros
            // 
            lbCobros.BackColor = SystemColors.ActiveCaption;
            lbCobros.BorderStyle = BorderStyle.FixedSingle;
            lbCobros.FormattingEnabled = true;
            lbCobros.Location = new Point(3, 92);
            lbCobros.Name = "lbCobros";
            lbCobros.Size = new Size(464, 317);
            lbCobros.TabIndex = 24;
            // 
            // ucCobros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(lbCobros);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(btnListar);
            Controls.Add(btnRegistrar);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ucCobros";
            Size = new Size(723, 421);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private ListBox lbCobros;
    }
}
