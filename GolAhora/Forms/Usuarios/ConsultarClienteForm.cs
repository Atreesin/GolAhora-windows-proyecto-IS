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
    public partial class ConsultarClienteForm : Form
    {
        //variables globales
        public Cliente? cliente;

        //constructors
        public ConsultarClienteForm()
        {
            InitializeComponent();
        }

        public ConsultarClienteForm(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void ConsultarClienteForm_Load(object sender, EventArgs e)
        {
            CargarCampos();
            BloquearCampos();
        }

        private void CargarCampos()
        {
            if (cliente is null) return;

            //llenar los campos con la información del cliente
            txtUsername.Text = cliente.Username;
            txtNombre.Text = $"{cliente.Apellido}, {cliente.Nombre}";
            txtDni.Text = cliente.Dni;
            txtNacionalidad.Text = cliente.Nacionalidad;
            txtGenero.Text = cliente.Genero;
            txtFechaNacimiento.Text = cliente.Fecha_Nacimiento.ToShortDateString();
            txtEmail.Text = cliente.Email;
            txtTelefono.Text = cliente.Telefono;
            txtFechaRegistro.Text = cliente.Fecha_Registro.ToShortDateString();
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
    }
}
