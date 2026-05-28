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
    public partial class ConsultarProfesorForm : Form
    {
        //variables globales
        public Profesor? profesor;

        //constructors
        public ConsultarProfesorForm()
        {
            InitializeComponent();
        }

        public ConsultarProfesorForm(Profesor profesor)
        {
            InitializeComponent();
            this.profesor = profesor;
        }

        private void ConsultarProfesorForm_Load(object sender, EventArgs e)
        {
            CargarCampos();
            BloquearCampos();
        }

        private void CargarCampos()
        {
            if (profesor is null) return;

            //llenar los campos con la información del profesor
            txtUsername.Text = profesor.Username;
            txtNombre.Text = $"{profesor.Apellido}, {profesor.Nombre}";
            txtDni.Text = profesor.Dni;
            txtNacionalidad.Text = profesor.Nacionalidad;
            txtGenero.Text = profesor.Genero;
            txtFechaNacimiento.Text = profesor.Fecha_Nacimiento.ToShortDateString();
            txtEmail.Text = profesor.Email;
            txtTelefono.Text = profesor.Telefono;
            txtFechaRegistro.Text = profesor.Fecha_Registro.ToShortDateString();
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
