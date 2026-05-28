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
    public partial class ModificarAdministradorForm : Form
    {
        //variables globales
        private Administrador? admin;
        public ModificarAdministradorForm()
        {
            InitializeComponent();
        }

        public ModificarAdministradorForm(Administrador admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void ModificarAdministradorForm_Load(object sender, EventArgs e)
        {
            CargarCampos();
            this.ActiveControl = null;
        }

        private void CargarCampos()
        {
            if (admin is null) return;

            //llenar los campos con la información del admin
            txtUsername.Text = admin.Username;
            txtNombre.Text = admin.Nombre;
            txtApellido.Text = admin.Apellido;
            txtDni.Text = admin.Dni;
            txtNacionalidad.Text = admin.Nacionalidad;
            txtGenero.Text = admin.Genero;
            txtFechaNacimiento.Text = admin.Fecha_Nacimiento.ToShortDateString();
            txtEmail.Text = admin.Email;
            txtTelefono.Text = admin.Telefono;
            txtCalle.Text = admin.Direccion?.Calle;
            txtNumero.Text = admin.Direccion?.Numero;
            txtCodigoPostal.Text = admin.Direccion?.Cp;
            txtLocalidad.Text = admin.Direccion?.Localidad;
            txtCiudad.Text = admin.Direccion?.Ciudad;
            txtProvincia.Text = admin.Direccion?.Provincia;
            txtPais.Text = admin.Direccion?.Pais;
            txtClub.Text = admin.Club?.Nombre ?? "sin club";
            txtNivel.Text = admin.User_Level;
        }
        private void ModificarAdministradorForm_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null; //quita el foco de cualquier control para evitar que se vean los bordes de selección
        }

        //
        //botones
        //

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea cancelar la modificación del administrador?",
                "Confirmar cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes) this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea modificar los datos del administrador?",
                "Confirmar modificación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {

            }
        }
    }
}
