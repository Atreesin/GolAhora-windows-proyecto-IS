using GolAhora.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GolAhora.Forms
{
    public partial class ModificarClienteForm : Form
    {
        //variables globales
        public Cliente cliente;

        //constructors
        public ModificarClienteForm()
        {
            InitializeComponent();
        }

        public ModificarClienteForm(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void ModificarClienteForm_Load(object sender, EventArgs e)
        {
            CargarCampos();
            this.ActiveControl = null;
        }

        private void CargarCampos()
        {
            if (cliente is null) return;

            //llenar los campos con la información del cliente
            txtUsername.Text = cliente.Username;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtDni.Text = cliente.Dni;
            txtNacionalidad.Text = cliente.Nacionalidad;
            txtGenero.Text = cliente.Genero;
            txtFechaNacimiento.Text = cliente.Fecha_Nacimiento.ToShortDateString();
            txtEmail.Text = cliente.Email;
            txtTelefono.Text = cliente.Telefono;
            txtCalle.Text = cliente.Direccion?.Calle;
            txtNumero.Text = cliente.Direccion?.Numero;
            txtCodigoPostal.Text = cliente.Direccion?.Cp;
            txtLocalidad.Text = cliente.Direccion?.Localidad;
            txtCiudad.Text = cliente.Direccion?.Ciudad;
            txtProvincia.Text = cliente.Direccion?.Provincia;
            txtPais.Text = cliente.Direccion?.Pais;
            txtClub.Text = cliente.Club?.Nombre ?? "sin club";
            txtNivel.Text = cliente.User_Level;
        }

        private void ModificarClienteForm_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null; //quita el foco de cualquier control para evitar que se vean los bordes de selección
        }

        //
        //botones
        //

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea cancelar la modificación del cliente?",
                "Confirmar cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes) this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea modificar los datos del cliente?",
                "Confirmar modificación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {

            }
        }
    }
}
