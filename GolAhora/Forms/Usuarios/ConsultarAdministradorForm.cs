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
    public partial class ConsultarAdministradorForm : Form
    {
        //variables globales
        public Administrador? admin;

        //constructors
        public ConsultarAdministradorForm()
        {
            InitializeComponent();
        }

        public ConsultarAdministradorForm(Administrador admin)
        {
            InitializeComponent();
            this.admin = admin;
        }


        private void ConsultarAdministradorForm_Load(object sender, EventArgs e)
        {
            CargarCampos();
            BloquearCampos();
        }

        private void CargarCampos()
        {
            if (admin is null) return;

            //llenar los campos con la información del admin
            txtUsername.Text = admin.Username;
            txtNombre.Text = $"{admin.Apellido}, {admin.Nombre}";
            txtDni.Text = admin.Dni;
            txtNacionalidad.Text = admin.Nacionalidad;
            txtGenero.Text = admin.Genero;
            txtFechaNacimiento.Text = admin.Fecha_Nacimiento.ToShortDateString();
            txtEmail.Text = admin.Email;
            txtTelefono.Text = admin.Telefono;
            txtFechaRegistro.Text = admin.Fecha_Registro.ToShortDateString();
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
        private void BloquearCampos()
        {
            txtUsername.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtDni.ReadOnly = true;
            txtNacionalidad.ReadOnly = true;
            txtGenero.ReadOnly = true;
            txtFechaNacimiento.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtTelefono.ReadOnly = true;
            txtFechaRegistro.ReadOnly = true;
            txtCalle.ReadOnly = true;
            txtNumero.ReadOnly = true;
            txtCodigoPostal.ReadOnly = true;
            txtLocalidad.ReadOnly = true;
            txtCiudad.ReadOnly = true;
            txtProvincia.ReadOnly = true;
            txtPais.ReadOnly = true;
            txtClub.ReadOnly = true;
            txtNivel.ReadOnly = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
