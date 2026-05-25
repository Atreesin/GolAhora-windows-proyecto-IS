using GolAhora.Services;
using GolAhora.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json.Nodes;
using System.Windows.Forms;

namespace GolAhora.Forms
{
    public partial class LoginForm : Form
    {

        ApiService apiService = new ApiService();
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click_1(object sender, EventArgs e)
        {
            string usuario = txtEmail.Text;
            string contraseña = txtPassword.Text;

            
            string result = await apiService.LoginAsync(usuario, contraseña);
            if (result != null)
            {
                
                SessionManager.SessionId = (JsonNode.Parse(result)?["token"] ?? "").ToString();

                //MessageBox.Show($"Inicio de sesión exitoso. ID de sesión: {SessionManager.SessionId}");
                
                MenuPrincipalForm menu = new MenuPrincipalForm();

                menu.FormClosed += (sender, e) =>
                {
                    txtEmail.Text = "";
                    txtPassword.Text = "";
                    SessionManager.SessionId = null;
                    int x = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;  // 50 px a la derecha
                    int y = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2; // 100 px abajo
                    this.Location = new Point(x, y);
                    this.Show();
                };

                menu.Show();
                this.Hide();


            }
            
        }
    }
}
