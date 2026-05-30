using GolAhora.Models;
using GolAhora.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GolAhora.Forms
{
    public partial class RegistrarClienteForm : Form
    {
        private readonly ApiService apiService = new ApiService();
        public RegistrarClienteForm()
        {
            InitializeComponent();
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            //validar campos antes de llamar a la api
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(cbNacionalidad.Text) ||
                string.IsNullOrWhiteSpace(cbGeneros.Text) ||
                string.IsNullOrWhiteSpace(txtFechaNacimiento.Text) ||
                string.IsNullOrWhiteSpace(txtCalle.Text) ||
                string.IsNullOrWhiteSpace(txtNumero.Text) ||
                string.IsNullOrWhiteSpace(txtCodigoPostal.Text) ||
                string.IsNullOrWhiteSpace(cbPais.Text) ||
                string.IsNullOrWhiteSpace(cbProvincia.Text) ||
                string.IsNullOrWhiteSpace(cbCiudad.Text) ||
                string.IsNullOrWhiteSpace(cbLocalidad.Text))
            {
                MessageBox.Show("Algunos campos están vacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime.TryParseExact(
                txtFechaNacimiento.Text,
                new string[] { "dd/MM/yyyy", "d/M/yyyy" },
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out DateTime fechaNacimiento);

            //confirmar antes de registrar cliente
            DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro que desea registrar el cliente?",
                    "Confirmar registro",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes) return;

            var cliente = new Cliente
            {
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Nacionalidad = cbNacionalidad.Text.Trim(),
                Dni = txtDni.Text.Trim(),
                Genero = cbGeneros.Text.Trim(),
                Fecha_Nacimiento = fechaNacimiento,
                Telefono = txtTelefono.Text.Trim(),
                Email = txtEmail.Text.Trim(),
            };

            btnRegistrar.Enabled = false;

            var resultado = await apiService.RegistrarClienteAsync(
                cliente,
                txtCalle.Text.Trim(),
                txtNumero.Text.Trim(),
                txtCodigoPostal.Text.Trim(),
                cbPais.Text.Trim(),
                cbProvincia.Text.Trim(),
                cbCiudad.Text.Trim(),
                cbLocalidad.Text.Trim()
            );
            btnRegistrar.Enabled = true;

            if (resultado != null)
            {
                MessageBox.Show("Cliente registrado correctamente.", "Éxito");
                this.Close();
            }
        }

        private async void RegistrarClienteForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null; //quita el foco de cualquier control para evitar que se vean los bordes de selección
            CargarElementos();
        }

        //
        //botones
        //

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea cancelar el registro del cliente?",
                "Confirmar cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes) this.Close();
        }

        /*carga de elementos*/

        private async void CargarElementos()
        {
            //cargar nacionalidades
            cbNacionalidad.Items.Clear();
            var paises = await apiService.GetPaisesAsync();
            cbNacionalidad.DataSource = System.Text.Json.JsonSerializer.Deserialize<List<string>>(paises);
            cbNacionalidad.SelectedIndex = -1;
            //cargar provincias
            cbProvincia.Items.Clear();
            var provincias = await apiService.GetProvinciasAsync();
            cbProvincia.DataSource = System.Text.Json.JsonSerializer.Deserialize<List<string>>(provincias);
            cbProvincia.SelectedIndex = -1;
            //cargar ciudades
            cbCiudad.Items.Clear();
            var ciudades = await apiService.GetCiudadesAsync();
            cbCiudad.DataSource = System.Text.Json.JsonSerializer.Deserialize<List<string>>(ciudades);
            cbCiudad.SelectedIndex = -1;
            //cargar localidades
            cbLocalidad.Items.Clear();
            var localidades = await apiService.GetLocalidadesAsync();
            cbLocalidad.DataSource = System.Text.Json.JsonSerializer.Deserialize<List<string>>(localidades);
            cbLocalidad.SelectedIndex = -1;
            //cargar generos
            cbGeneros.Items.Clear();
            var generos = await apiService.GetGenerosAsync();
            cbGeneros.DataSource = System.Text.Json.JsonSerializer.Deserialize<List<string>>(generos);
            cbGeneros.SelectedIndex = -1;
            //cargar paises
            cbPais.Items.Clear();
            cbPais.DataSource = System.Text.Json.JsonSerializer.Deserialize<List<string>>(paises);
            cbPais.SelectedIndex = -1;
        }
    }
}