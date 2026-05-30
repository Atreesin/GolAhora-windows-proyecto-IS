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
    public partial class RegistrarCanchaForm : Form
    {
        private ApiService apiService = new ApiService();
        public RegistrarCanchaForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private async void RegistrarCanchaForm_Load(object sender, EventArgs e)
        {
            var tipos = await apiService.GetTiposDeCanchaAsync();

            if (tipos != null)
            {
                cbTipoCancha.DataSource = tipos;
                cbTipoCancha.DisplayMember = "Tipo_Cancha";
                cbTipoCancha.ValueMember = "Id";
                cbTipoCancha.SelectedIndex = -1;
            }
        }

        private void ValidarCampos(object sender, EventArgs e)
        {
            btnRegistrar.Enabled =
                !string.IsNullOrWhiteSpace(txtNombreCancha.Text)
                && cbTipoCancha.SelectedItem != null
                && nudPlazo.Value > 0
                && nudPrecio.Value > 0;
        }

        private void txtNombreCancha_TextChanged(object sender, EventArgs e) => ValidarCampos(sender, e);
        private void cbTipoCancha_SelectedIndexChanged(object sender, EventArgs e) => ValidarCampos(sender, e);
        private void cbHoraInicio_SelectedIndexChanged(object sender, EventArgs e) => ValidarCampos(sender, e);
        private void cbHoraFin_SelectedIndexChanged(object sender, EventArgs e) => ValidarCampos(sender, e);

        private void linkLblNuevoTipo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Abrir el formulario de registro de tipo de cancha
            RegistrarTipoCanchaForm newForm = new RegistrarTipoCanchaForm();
            newForm.ShowDialog();
        }


        //
        //botones
        //


        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombreCancha = txtNombreCancha.Text;
            int plazoCancelacion = (int)nudPlazo.Value * 60;
            decimal precio = nudPrecio.Value;
            int tipoCanchaId = cbTipoCancha.SelectedValue != null ? (int)cbTipoCancha.SelectedValue : 0;

            string result = await apiService.RegistrarCanchaAsync(nombreCancha, plazoCancelacion, precio, tipoCanchaId);

            if (result != null)
            {
                MessageBox.Show("Cancha registrada exitosamente");
                this.Close();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea cancelar el registro?",
                "Confirmar modificación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes) this.Close();
        }
    }
}
