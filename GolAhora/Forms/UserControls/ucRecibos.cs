using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GolAhora.Forms.UserControls
{
    public partial class ucRecibos : UserControl
    {
        public ucRecibos()
        {
            InitializeComponent();
        }

        private void listBoxRecibos_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool reciboSeleccionado = (listBoxRecibos.SelectedIndex >= 0);

            btnConsultar.Enabled = reciboSeleccionado;
            btnImprimir.Enabled = reciboSeleccionado;
            btnModificar.Enabled = reciboSeleccionado;
            btnEliminar.Enabled = reciboSeleccionado;
        }

        private void listBoxRecibos_MouseDown(object sender, MouseEventArgs e)
        {
            int index = listBoxRecibos.IndexFromPoint(e.Location);
            if (index == -1) listBoxRecibos.ClearSelected();
        }

        private void ucRecibos_Click(object sender, EventArgs e)
        {
            //limpiamos selección de la lista
            listBoxRecibos.ClearSelected();
        }


        /*Botones del panel*/
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //limpiamos selección de la lista
            listBoxRecibos.ClearSelected();

            Form newForm = new RegistrarReciboForm();
            newForm.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            Form newForm = new ConsultarReciboForm();
            newForm.ShowDialog();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"La impresión de los datos del recibo <<xxx>> está en proceso...",
                "Imprimir datos de recibo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            Form newForm = new ModificarReciboForm();
            newForm.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"¿Seguro que deseas eliminar el recibo <<xxx>>?",
                "Confirmar eliminación de recibo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }
    }
}
