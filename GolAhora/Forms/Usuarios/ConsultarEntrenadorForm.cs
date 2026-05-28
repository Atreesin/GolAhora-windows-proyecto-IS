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
    public partial class ConsultarEntrenadorForm : Form
    {
        //variables globales
        public Entrenador? entrenador;

        //constructors
        public ConsultarEntrenadorForm()
        {
            InitializeComponent();
        }

        public ConsultarEntrenadorForm(Entrenador entrenador)
        {
            InitializeComponent();
            this.entrenador = entrenador;
        }

        private void ConsultarEntrenadorForm_Load(object sender, EventArgs e)
        {
            CargarCampos();
            BloquearCampos();
        }

        private void CargarCampos()
        {
            if (entrenador is null) return;

            //llenar los campos con la información del entrenador
            txtUsername.Text = entrenador.Username;
            txtNombre.Text = $"{entrenador.Apellido}, {entrenador.Nombre}";
            txtDni.Text = entrenador.Dni;
            txtNacionalidad.Text = entrenador.Nacionalidad;
            txtGenero.Text = entrenador.Genero;
            txtFechaNacimiento.Text = entrenador.Fecha_Nacimiento.ToShortDateString();
            txtEmail.Text = entrenador.Email;
            txtTelefono.Text = entrenador.Telefono;
            txtFechaRegistro.Text = entrenador.Fecha_Registro.ToShortDateString();
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
