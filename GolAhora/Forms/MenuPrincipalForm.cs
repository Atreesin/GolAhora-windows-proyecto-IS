using GolAhora.Services;
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
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // inicializar los modelos de datos (proxi de los datos reales)
            // los datos se van a cargar desde la base de datos, pero por ahora se pueden cargar con datos de prueba
            // club 

            // canchas

            // usuarios

            //

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ApiService apiService = new ApiService();
            var result = await apiService.GetUserDataAsync();
            MessageBox.Show(result ?? "No se pudo obtener los datos del usuario");

        }

        private async void MenuPrincipalForm_Load(object sender, EventArgs e)
        {
            ApiService apiService = new ApiService();
            var result = await apiService.GetUserDataAsync();
            var info = JsonNode.Parse(result);
            txtUsername.Text = ($"{info?["username"] ?? "Desconocido"}");
            MessageBox.Show(result ?? "No se pudo obtener los datos del usuario");
        }

    }
}
