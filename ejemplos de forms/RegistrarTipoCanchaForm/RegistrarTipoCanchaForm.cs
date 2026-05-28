using GolAhora.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GolAhora.Models;

namespace GolAhora.Forms
{
    public partial class RegistrarTipoCanchaForm : Form
    {
        private ApiService apiService = new ApiService();
        public RegistrarTipoCanchaForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void RegistrarTipoCanchaForm_Load(object sender, EventArgs e)
        {
            cb_superficies.Items.Clear();
            var superficies = await apiService.GetSuperficiesAsync();
            cb_superficies.DataSource = System.Text.Json.JsonSerializer.Deserialize<List<Superficie>>(superficies);
            cb_superficies.DisplayMember = "tipo_superficie";
            cb_superficies.ValueMember = "id_superficie";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnImagenSelect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Seleccionar imagen de cancha";
                ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Mostrar la ruta en un TextBox
                    txtRutaImagen.Text = ofd.FileName;

                    // Opcional: mostrar la imagen en un PictureBox
                    pictureBoxImagen.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private async void btnAgregarTipoCancha_Click(object sender, EventArgs e)
        {
            string tipo_cancha = txtTipoCancha.Text;
            int duracion_min = (int)numDuracionMin.Value;
            int duracion_max = (int)numDuracionMax.Value;
            decimal ancho = numAncho.Value;
            decimal largo = numLargo.Value;
            int capacidad = (int)numCapacidad.Value;
            int superficie_id = cb_superficies.SelectedValue != null ? (int)cb_superficies.SelectedValue : 0;
            string imagen = txtRutaImagen.Text;

            string result = await apiService.RegistrarTipoCanchaAsync(tipo_cancha, duracion_min, duracion_max, ancho, largo, capacidad, imagen, superficie_id);
            if (result != null)
            {
                MessageBox.Show("Tipo de cancha registrado exitosamente");
                this.Close();
            }
        }
    }
}
