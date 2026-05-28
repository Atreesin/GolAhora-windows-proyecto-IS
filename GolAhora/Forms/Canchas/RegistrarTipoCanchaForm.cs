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
            var jsonSuperficies = await apiService.GetSuperficiesAsync();

            if (!string.IsNullOrWhiteSpace(jsonSuperficies))
            {
                var opciones = new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var listaSuperficies = System.Text.Json.JsonSerializer.Deserialize<List<Superficie>>(jsonSuperficies, opciones);

                cb_superficies.DataSource = listaSuperficies;

                cb_superficies.DisplayMember = "Tipo_Superficie";
                cb_superficies.ValueMember = "Id";
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnImagenSeleccionar_Click(object sender, EventArgs e)
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

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTipoCancha.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del tipo de cancha.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cb_superficies.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione una superficie válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tipo_cancha = txtTipoCancha.Text;
            int duracion_min = (int)numDuracionMin.Value;
            int duracion_max = (int)numDuracionMax.Value;
            decimal ancho = numAncho.Value;
            decimal largo = numLargo.Value;
            int capacidad = (int)numCapacidad.Value;
            int superficie_id = cb_superficies.SelectedValue != null ? (int)cb_superficies.SelectedValue : 0;
            string imagen = txtRutaImagen.Text;

            btnRegistrar.Enabled = false; // Deshabilitar el botón para evitar múltiples clics
            string result = await apiService.RegistrarTipoCanchaAsync(tipo_cancha, duracion_min, duracion_max, ancho, largo, capacidad, imagen, superficie_id);
            btnRegistrar.Enabled = true; // Rehabilitar el botón después de la operación

            if (result != null)
            {
                MessageBox.Show("Tipo de cancha registrado exitosamente");
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea cancelar el registro?",
                "Confirmar modificación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes) this.Close();
        }
    }
}
