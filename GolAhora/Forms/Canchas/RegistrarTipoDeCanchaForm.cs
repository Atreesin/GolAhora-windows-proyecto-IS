using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GolAhora.Forms
{
    public partial class RegistroTipoDeCanchaForm : Form
    {
        public RegistroTipoDeCanchaForm()
        {
            InitializeComponent();
        }

        private void ValidarCampos(object sender, EventArgs e)
        {
            btnRegistrar.Enabled =
                !string.IsNullOrWhiteSpace(txtNombreTipo.Text)
                && nudLongHorizontal.Value > 0
                && nudLongVertical.Value > 0
                && cbDuracionReserva.SelectedItem != null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var nombreCancha = txtNombreTipo.Text;
            MessageBox.Show($"El tipo de cancha <<{nombreCancha}>> se registró correctamente", "Registro de Cancha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
