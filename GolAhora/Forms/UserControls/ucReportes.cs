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
    public partial class ucReportes : UserControl
    {
        public ucReportes()
        {
            InitializeComponent();
        }

        //
        //Busqueda en la lista
        //
        private void ValidarCamposBusqueda(object sender, EventArgs e)
        {
            btnBuscar.Enabled = !string.IsNullOrWhiteSpace(txtBusqueda.Text)
                && (cbFiltrado.SelectedItem != null);
        }


        private void cbFiltrado_SelectedIndexChanged(object sender, EventArgs e) => ValidarCamposBusqueda(sender, e);

        private void txtBusqueda_TextChanged(object sender, EventArgs e) => ValidarCamposBusqueda(sender, e);


        /*Botón de búsqueda*/
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
        //
        //
        //

        //
        //Botones del panel
        //

        private void btnCanchas_Click(object sender, EventArgs e)
        {
            //limpiamos selección de la lista
            listBoxReportes.ClearSelected();

            MessageBox.Show(
                "El reporte de tipos de cancha del club se encuentra en proceso...",
                "Reporte de tipos de cancha",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            //limpiamos selección de la lista
            listBoxReportes.ClearSelected();

            MessageBox.Show(
                "El reporte de ingresos del club se encuentra en proceso...",
                "Reporte de tipos de cancha",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            //limpiamos selección de la lista
            listBoxReportes.ClearSelected();

            MessageBox.Show(
                "El reporte de reservas de cancha en el club se encuentra en proceso...",
                "Reporte de tipos de cancha",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnAsistenciaClase_Click(object sender, EventArgs e)
        {
            //limpiamos selección de la lista
            listBoxReportes.ClearSelected();

            MessageBox.Show(
                "El reporte de asistencias a clases se encuentra en proceso...",
                "Reporte de tipos de cancha",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnAsistenciaEntrenamiento_Click(object sender, EventArgs e)
        {
            //limpiamos selección de la lista
            listBoxReportes.ClearSelected();

            MessageBox.Show(
                "El reporte de asistencias a entrenamientos se encuentra en proceso...",
                "Reporte de tipos de cancha",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }


        //
        //
        //

    }
}
