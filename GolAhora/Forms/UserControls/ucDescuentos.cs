using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GolAhora.Forms.UserControls
{
    public partial class ucDescuentos : UserControl
    {
        public ucDescuentos()
        {
            InitializeComponent();
        }

        private void listBoxDescuentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool descuentoSeleccionado = (listBoxDescuentos.SelectedIndex >= 0);

            btnConsultar.Enabled = descuentoSeleccionado;
            btnModificar.Enabled = descuentoSeleccionado;
            btnEliminar.Enabled = descuentoSeleccionado;
        }

        private void listBoxDescuentos_MouseDown(object sender, MouseEventArgs e)
        {
            int index = listBoxDescuentos.IndexFromPoint(e.Location);
            if (index == -1) listBoxDescuentos.ClearSelected();
        }

        private void ucDescuentos_Click(object sender, EventArgs e)
        {
            //limpiamos selección de la lista
            listBoxDescuentos.ClearSelected();
        }


        /*Botones del panel*/
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //limpiamos selección de la lista
            listBoxDescuentos.ClearSelected();

            Form newForm = new RegistrarDescuentoForm();
            newForm.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Form newForm = new ConsultarDescuentoForm();
            newForm.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            Form newForm = new ModificarDescuentoForm();
            newForm.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "¿Está seguro que desea eliminar este descuento?", 
                "Confirmar eliminación", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
        }
    }
}
