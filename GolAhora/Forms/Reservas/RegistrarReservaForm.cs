using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GolAhora.Forms
{
    public partial class RegistrarReservaForm : Form
    {
        public RegistrarReservaForm()
        {
            InitializeComponent();
        }


        /*Botones de formulario*/
        private void btnPago_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Cobro registrado de forma correcta en la caja del complejo.", 
                "Pago registrado", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);

            btnRealizar.Enabled = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "¡Reserva realizada exitosamente!", 
                "Éxito", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);

            this.Close();
        }

        /*Validación de campos*/
        private void ValidarCampos(object sender, EventArgs e)
        {
            btnRealizar.Enabled =
                !string.IsNullOrWhiteSpace(txtNombreUsuario.Text)
                && cbCancha.SelectedItem != null
                && dtpDiaReserva.Value.Date >= DateTime.Now.Date
                && cbHorarios.SelectedItem != null;
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e) => ValidarCampos(sender, e);
        private void cbCancha_SelectedIndexChanged(object sender, EventArgs e) => ValidarCampos(sender, e);
        private void dtpDiaReserva_ValueChanged(object sender, EventArgs e) => ValidarCampos(sender, e);
        private void cbHorarios_SelectedIndexChanged(object sender, EventArgs e) => ValidarCampos(sender, e);
    }
}
