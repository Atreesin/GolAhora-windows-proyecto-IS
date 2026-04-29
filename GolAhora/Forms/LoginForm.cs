using GolAhora.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GolAhora.Forms
{
    public partial class LoginForm : Form
    {


        public LoginForm()
        {
            InitializeComponent();

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtEmail.Text;
            string contraseña = txtPassword.Text;

            using (HttpClient client = new HttpClient())
            {
                var values = new Dictionary<string, string>
            {
                { "email", usuario },
                { "password", contraseña }
            };

                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync("http://localhost/api/login", content);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    // Supongamos que la API devuelve directamente el token
                    SessionManager.SessionId = result;

                    // Abrir menú principal
                    MenuPrincipalForm menu = new MenuPrincipalForm();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click_1(object sender, EventArgs e)
        {
            string usuario = txtEmail.Text;
            string contraseña = txtPassword.Text;

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("plataform", "windows");
                var values = new Dictionary<string, string>
            {
                { "email", usuario },
                { "password", contraseña }
            };

                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync("http://localhost/api/login", content);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    // Supongamos que la API devuelve directamente el token
                    SessionManager.SessionId = result;

                    // Abrir menú principal
                    MenuPrincipalForm menu = new MenuPrincipalForm();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
        }
    }
}
