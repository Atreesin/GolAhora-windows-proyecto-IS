using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GolAhora.Forms.UserControls
{
    public partial class ucReservas2 : UserControl
    {
        public ucReservas2()
        {
            InitializeComponent();
        }

        private void listBoxReservas_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool reservaSeleccionada = (listBoxReservas.SelectedIndex >= 0);

            btnConsultar.Enabled = reservaSeleccionada;
            btnModificar.Enabled = reservaSeleccionada;
            btnCancelar.Enabled = reservaSeleccionada;
        }

        private void listBoxReservas_MouseDown(object sender, MouseEventArgs e)
        {
            int index = listBoxReservas.IndexFromPoint(e.Location);
            if (index == -1) listBoxReservas.ClearSelected();
        }

        private void ucReservas2_Click(object sender, EventArgs e)
        {
            //limpiamos selección de la lista
            listBoxReservas.ClearSelected();
        }


        /*Botones del panel*/
        private void btnReservar_Click(object sender, EventArgs e)
        {
            //limpiamos selección de la lista
            listBoxReservas.ClearSelected();

            Form newForm = new RegistrarReservaForm();
            newForm.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Form newForm = new ConsultarReservaForm();
            newForm.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form newForm = new ModificarReservaForm();
            newForm.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (listBoxReservas.SelectedIndex != -1)
            {
                string reserva = listBoxReservas.SelectedItem.ToString();
                DialogResult res = MessageBox.Show(
                    $"¿Seguro que desea dar de baja la reserva:\n{reserva}?\n\n" +
                        "Se aplicará el reembolso automático correspondiente del club.", 
                    "Baja de Reserva", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    listBoxReservas.Items.Remove(listBoxReservas.SelectedItem);
                    MessageBox.Show(
                        "Reserva cancelada y reembolso emitido con éxito.", 
                        "Éxito", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                }
            }
        }
    }
}
