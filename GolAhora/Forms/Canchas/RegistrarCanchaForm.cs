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
        public RegistrarCanchaForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var nombreCancha = txtNombreCancha.Text;

            MessageBox.Show(
                $"La cancha {nombreCancha} se registró correctamente",
                "Registro de Cancha",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            
            this.Close();
        }

        private void ValidarCampos(object sender, EventArgs e)
        {
            btnRegistrar.Enabled =
                !string.IsNullOrWhiteSpace(txtNombreCancha.Text)
                && cbTipoCancha.SelectedItem != null
                && cbHoraInicio.SelectedItem != null
                && cbHoraFin.SelectedItem != null;
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
    }
}
