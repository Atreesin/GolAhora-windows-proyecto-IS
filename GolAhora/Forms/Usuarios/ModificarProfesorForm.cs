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
    public partial class ModificarProfesorForm : Form
    {
        //variables globales
        private Profesor? profesor;
        public ModificarProfesorForm()
        {
            InitializeComponent();
        }
        public ModificarProfesorForm(Profesor profesor)
        {
            InitializeComponent();
            this.profesor = profesor;
        }

        private void ModificarProfesorForm_Load(object sender, EventArgs e)
        {
            CargarCampos();
            this.ActiveControl = null;
        }

        private void CargarCampos()
        {
            if (profesor is null) return;

            //llenar los campos con la información del profesor
            txtUsername.Text = profesor.Username;
            txtNombre.Text = profesor.Nombre;
            txtApellido.Text = profesor.Apellido;
            txtDni.Text = profesor.Dni;
            txtNacionalidad.Text = profesor.Nacionalidad;
            txtGenero.Text = profesor.Genero;
            txtFechaNacimiento.Text = profesor.Fecha_Nacimiento.ToShortDateString();
            txtEmail.Text = profesor.Email;
            txtTelefono.Text = profesor.Telefono;
            txtCalle.Text = profesor.Direccion?.Calle;
            txtNumero.Text = profesor.Direccion?.Numero;
            txtCodigoPostal.Text = profesor.Direccion?.Cp;
            txtLocalidad.Text = profesor.Direccion?.Localidad;
            txtCiudad.Text = profesor.Direccion?.Ciudad;
            txtProvincia.Text = profesor.Direccion?.Provincia;
            txtPais.Text = profesor.Direccion?.Pais;
            txtClub.Text = profesor.Club?.Nombre ?? "sin club";
            txtNivel.Text = profesor.User_Level;
        }

        private void ModificarProfesorForm_Click(object sender, EventArgs e)
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
               "¿Está seguro que desea modificar los datos del profesor?",
               "Confirmar modificación",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {

            }
        }
    }
}
