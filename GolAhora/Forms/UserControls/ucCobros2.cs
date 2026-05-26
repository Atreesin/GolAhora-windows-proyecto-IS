using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GolAhora.Forms.UserControls
{
    public partial class ucCobros2 : UserControl
    {
        public ucCobros2()
        {
            InitializeComponent();
        }

        private void listBoxCobros_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool cobroSeleccionado = (listBoxCobros.SelectedIndex >= 0);

            btnConsultar.Enabled = cobroSeleccionado;
            btnImprimir.Enabled = cobroSeleccionado;
            btnModificar.Enabled = cobroSeleccionado;
            btnCancelar.Enabled = cobroSeleccionado;
        }

        private void listBoxCobros_MouseDown(object sender, MouseEventArgs e)
        {
            int index = listBoxCobros.IndexFromPoint(e.Location);
            if (index == -1) listBoxCobros.ClearSelected();
        }

        private void ucCobros2_Click(object sender, EventArgs e)
        {
            //limpiamos selección de la lista
            listBoxCobros.ClearSelected();
        }

        /*Botones del panel*/
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //limpiamos selección de la lista
            listBoxCobros.ClearSelected();

            Form newForm = new RegistrarCobroForm();
            newForm.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            Form newForm = new ConsultarCobroForm();
            newForm.ShowDialog();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                 $"La impresión de los datos del cobro <<xxx>> está en proceso...",
                 "Imprimir datos de cobro",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            Form newForm = new ModificarCobroForm();
            newForm.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"¿Seguro que deseas cancelar el cobro <<xxx>>?",
                "Confirmar cancelación de cobro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }
    }
}
