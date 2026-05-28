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
    public partial class ModificarEntrenadorForm : Form
    {
        //variables globales
        private Entrenador? entrenador;

        //constructors
        public ModificarEntrenadorForm()
        {
            InitializeComponent();
        }
        public ModificarEntrenadorForm(Entrenador entrenador)
        {
            InitializeComponent();
            this.entrenador = entrenador;
        }

        private void ModificarEntrenadorForm_Load(object sender, EventArgs e)
        {
            CargarCampos();
            this.ActiveControl = null;
        }

        private void CargarCampos()
        {
            if (entrenador is null) return;

            //llenar los campos con la información del entrenador
            txtUsername.Text = entrenador.Username;
            txtNombre.Text = entrenador.Nombre;
            txtApellido.Text = entrenador.Apellido;
            txtDni.Text = entrenador.Dni;
            txtNacionalidad.Text = entrenador.Nacionalidad;
            txtGenero.Text = entrenador.Genero;
            txtFechaNacimiento.Text = entrenador.Fecha_Nacimiento.ToShortDateString();
            txtEmail.Text = entrenador.Email;
            txtTelefono.Text = entrenador.Telefono;
            txtCalle.Text = entrenador.Direccion?.Calle;
            txtNumero.Text = entrenador.Direccion?.Numero;
            txtCodigoPostal.Text = entrenador.Direccion?.Cp;
            txtLocalidad.Text = entrenador.Direccion?.Localidad;
            txtCiudad.Text = entrenador.Direccion?.Ciudad;
            txtProvincia.Text = entrenador.Direccion?.Provincia;
            txtPais.Text = entrenador.Direccion?.Pais;
            txtClub.Text = entrenador.Club?.Nombre ?? "sin club";
            txtNivel.Text = entrenador.User_Level;
        }

        private void ModificarEntrenadorForm_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null; //quita el foco de cualquier control para evitar que se vean los bordes de selección
        }

        //
        //botones
        //

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea cancelar la modificación del clienteistrador?",
                "Confirmar cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes) this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
               "¿Está seguro que desea modificar los datos del entrenador?",
               "Confirmar modificación",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {

            }
        }
    }
}
