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
    public partial class ucCompetencias : UserControl
    {
        public ucCompetencias()
        {
            InitializeComponent();
        }
        
        //
        //Busqueda en la lista
        //
        private void ValidarCamposBusqueda(object sender, EventArgs e)
        {
            btnBuscar.Enabled = !string.IsNullOrWhiteSpace(txtBusqueda.Text)
                && (cbFiltrado.SelectedItem != null && cbEstados.SelectedItem != null);
        }

        private void cbEstados_SelectedIndexChanged(object sender, EventArgs e) => ValidarCamposBusqueda(sender, e);

        private void cbFiltrado_SelectedIndexChanged(object sender, EventArgs e) => ValidarCamposBusqueda(sender, e);
        
        private void txtBusqueda_TextChanged(object sender, EventArgs e) => ValidarCamposBusqueda(sender, e);


        /*Botón de búsqueda*/
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        //
        //
        //


        private void listBoxLigas_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool ligaSeleccionada = (listBoxLigas.SelectedIndex >= 0);

            btnInscribirEquipoLiga.Enabled = ligaSeleccionada;
            btnConfigurarLiga.Enabled = ligaSeleccionada;
            btnRegistrarResultadosLiga.Enabled = ligaSeleccionada;
            btnBajaLiga.Enabled = ligaSeleccionada;
        }

        private void listBoxTorneos_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool torneoSeleccionado = (listBoxTorneos.SelectedIndex >= 0);

            btnInscribirEquipoTorneo.Enabled = torneoSeleccionado;
            btnConfigurarTorneo.Enabled = torneoSeleccionado;
            btnRegistrarResultadosTorneo.Enabled = torneoSeleccionado;
            btnBajaTorneo.Enabled = torneoSeleccionado;
        }

        private void listBoxLigas_MouseDown(object sender, MouseEventArgs e)
        {
            int index = listBoxLigas.IndexFromPoint(e.Location);
            if (index == -1) listBoxLigas.ClearSelected();
        }

        private void listBoxTorneos_MouseDown(object sender, MouseEventArgs e)
        {
            int index = listBoxTorneos.IndexFromPoint(e.Location);
            if (index == -1) listBoxTorneos.ClearSelected();
        }

        private void tcCompetencias_Click(object sender, EventArgs e)
        {
            //limpiamos selección de las lista
            listBoxLigas.ClearSelected();
            listBoxTorneos.ClearSelected();
        }

        private void ucCompetencias_Click(object sender, EventArgs e)
        {
            //limpiamos selección de las lista
            listBoxLigas.ClearSelected();
            listBoxTorneos.ClearSelected();
        }

        //
        //Botones del panel
        //

        /*Botones de la pestaña ligas*/

        private void btnRegistrarLiga_Click(object sender, EventArgs e)
        {
            //limpiar selección de la lista
            listBoxLigas.ClearSelected();

            Form newForm = new RegistrarLigaForm();
            newForm.ShowDialog();
        }

        private void btnInscribirEquipoLiga_Click(object sender, EventArgs e)
        {
            Form newForm = new InscribirEquipoLigaForm();
            newForm.ShowDialog();
        }

        private void btnConfigurarLiga_Click(object sender, EventArgs e)
        {
            Form newForm = new ConfigurarLigaForm();
            newForm.ShowDialog();
        }

        private void btnRegistrarResultadosLiga_Click(object sender, EventArgs e)
        {
            Form newForm = new RegistrarResultadosLigaForm();
            newForm.ShowDialog();
        }

        private void btnBajaLiga_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            $"¿Seguro que deseas dar de baja la liga <<xxx>>?",
            "Confirmar baja de liga",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
        }


        /*Botones de la pestaña torneos*/
        private void btnRegistrarTorneo_Click(object sender, EventArgs e)
        {
            //limpiar selección de la lista
            listBoxTorneos.ClearSelected();

            Form newForm = new RegistrarTorneoForm();
            newForm.ShowDialog();
        }

        private void btnInscribirEquipoTorneo_Click(object sender, EventArgs e)
        {
            Form newForm = new InscribirEquipoTorneoForm();
            newForm.ShowDialog();
        }

        private void btnConfigurarTorneo_Click(object sender, EventArgs e)
        {
            Form newForm = new ConfigurarTorneoForm();
            newForm.ShowDialog();
        }

        private void btnRegistrarResultadosTorneo_Click(object sender, EventArgs e)
        {
            Form newForm = new RegistrarResultadosTorneoForm();
            newForm.ShowDialog();
        }

        private void btnBajaTorneo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            $"¿Seguro que deseas dar de baja el torneo <<xxx>>?",
            "Confirmar baja de torneo",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
        }
    }
}
