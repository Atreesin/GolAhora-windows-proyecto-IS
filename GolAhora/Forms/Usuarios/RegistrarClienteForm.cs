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
        private readonly ApiService _api = new ApiService();
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
                string.IsNullOrWhiteSpace(txtNacionalidad.Text) ||
                string.IsNullOrWhiteSpace(txtGenero.Text) ||
                string.IsNullOrWhiteSpace(txtFechaNacimiento.Text) ||
                string.IsNullOrWhiteSpace(txtCalle.Text) ||
                string.IsNullOrWhiteSpace(txtNumero.Text) ||
                string.IsNullOrWhiteSpace(txtCodigoPostal.Text) ||
                string.IsNullOrWhiteSpace(txtPais.Text) ||
                string.IsNullOrWhiteSpace(txtProvincia.Text) ||
                string.IsNullOrWhiteSpace(txtCiudad.Text) ||
                string.IsNullOrWhiteSpace(txtLocalidad.Text))
            {
                MessageBox.Show("Completa todos los campos obligatorios.", "Validación");
                return;
            }

            //validar que el formato de fecha de nacimiento tenga el formato correcto
            if (!DateTime.TryParseExact(
                txtFechaNacimiento.Text,
                new string[] { "dd/MM/yyyy", "d/M/yyyy" },
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out DateTime fechaNacimiento))
            {
                MessageBox.Show("Ingrese una fecha de nacimiento válida (dd/MM/yyyy).", "Validación");
                return;
            }

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
                Nacionalidad = txtNacionalidad.Text.Trim(),
                Dni = txtDni.Text.Trim(),
                Genero = txtGenero.Text.Trim(),
                Fecha_Nacimiento = fechaNacimiento,
                Telefono = txtTelefono.Text.Trim(),
                Email = txtEmail.Text.Trim(),
            };

            btnRegistrar.Enabled = false;

            var resultado = await _api.RegistrarClienteAsync(
                cliente,
                txtCalle.Text.Trim(),
                txtNumero.Text.Trim(),
                txtCodigoPostal.Text.Trim(),
                txtPais.Text.Trim(),
                txtProvincia.Text.Trim(),
                txtCiudad.Text.Trim(),
                txtLocalidad.Text.Trim()
            );
            btnRegistrar.Enabled = true;

            if (resultado != null)
            {
                MessageBox.Show("Cliente registrado correctamente.", "Éxito");
                this.Close();
            }
        }

        private void RegistrarClienteForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null; //quita el foco de cualquier control para evitar que se vean los bordes de selección

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
    }
}