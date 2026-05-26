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
    public partial class ucCapacitaciones : UserControl
    {
        public ucCapacitaciones()
        {
            InitializeComponent();
        }

        private void listBoxClases_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool claseSeleccionada = (listBoxClases.SelectedIndex >= 0);

            btnConsultarClase.Enabled = claseSeleccionada;
            btnModificarClase.Enabled = claseSeleccionada;
            btnInscribirAlumnoClase.Enabled = claseSeleccionada;
            btnAsistenciaClase.Enabled = claseSeleccionada;
            btnReporteAsistenciaClase.Enabled = claseSeleccionada;
            btnBajaAlumnoClase.Enabled = claseSeleccionada;
        }

        private void listBoxEntrenamientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool entrenamientoSeleccionado = (listBoxEntrenamientos.SelectedIndex >= 0);

            btnConsultarEntrenamiento.Enabled = entrenamientoSeleccionado;
            btnModificarEntrenamiento.Enabled = entrenamientoSeleccionado;
            btnInscribirAlumnoEntrenamiento.Enabled = entrenamientoSeleccionado;
            btnAsistenciaEntrenamiento.Enabled = entrenamientoSeleccionado;
            btnReporteAsistenciaEntrenamiento.Enabled = entrenamientoSeleccionado;
            btnBajaAlumnoEntrenamiento.Enabled = entrenamientoSeleccionado;
        }


        private void listBoxEntrenamientos_MouseDown(object sender, MouseEventArgs e)
        {
            int index = listBoxEntrenamientos.IndexFromPoint(e.Location);
            if (index == -1) listBoxEntrenamientos.ClearSelected();
        }

        private void listBoxClases_MouseDown(object sender, MouseEventArgs e)
        {
            int index = listBoxClases.IndexFromPoint(e.Location);
            if (index == -1) listBoxClases.ClearSelected();
        }
        private void tcCapacitaciones_Click(object sender, EventArgs e)
        {
            //limpiamos selección de las lista
            listBoxClases.ClearSelected();
            listBoxEntrenamientos.ClearSelected();
        }

        private void ucCapacitaciones_Click(object sender, EventArgs e)
        {
            //limpiamos selección de las lista
            listBoxClases.ClearSelected();
            listBoxEntrenamientos.ClearSelected();
        }


        /*Botones del panel*/
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }


        /*Botones de la pestaña clases*/
        private void btnRegistrarClase_Click(object sender, EventArgs e)
        {
            //limpiamos selección de las lista
            listBoxClases.ClearSelected();

            Form newForm = new RegistrarClaseForm();
            newForm.ShowDialog();
        }

        private void btnConsultarClase_Click(object sender, EventArgs e)
        {
            Form newForm = new ConsultarClaseForm();
            newForm.ShowDialog();
        }

        private void btnModificarClase_Click(object sender, EventArgs e)
        {
            Form newForm = new ModificarClaseForm();
            newForm.ShowDialog();
        }

        private void btnInscribirAlumnoClase_Click(object sender, EventArgs e)
        {
            Form newForm = new InscribirAlumnoClaseForm();
            newForm.ShowDialog();
        }

        private void btnAsistenciaClase_Click(object sender, EventArgs e)
        {
            Form newForm = new RegistrarAsistenciaClaseForm();
            newForm.ShowDialog();
        }

        private void btnReporteAsistenciaClase_Click(object sender, EventArgs e)
        {
            Form newForm = new ReporteAsistenciaClaseForm();
            newForm.ShowDialog();
        }

        private void btnBajaAlumnoClase_Click(object sender, EventArgs e)
        {
            Form newForm = new BajaAlumnoClaseForm();
            newForm.ShowDialog();
        }


        /*Botones de la pestaña entrenamientos*/
        private void btnRegistrarEntrenamiento_Click(object sender, EventArgs e)
        {
            //limpiamos selección de las lista
            listBoxEntrenamientos.ClearSelected();

            Form newForm = new RegistrarEntrenamientoForm();
            newForm.ShowDialog();
        }
        private void btnConsultarEntrenamiento_Click(object sender, EventArgs e)
        {
            Form newForm = new ConsultarEntrenamientoForm();
            newForm.ShowDialog();
        }

        private void btnModificarEntrenamiento_Click(object sender, EventArgs e)
        {
            Form newForm = new ModificarEntrenamientoForm();
            newForm.ShowDialog();
        }

        private void btnInscribirAlumnoEntrenamiento_Click(object sender, EventArgs e)
        {
            Form newForm = new InscribirAlumnoEntrenamientoForm();
            newForm.ShowDialog();
        }

        private void btnAsistenciaEntrenamiento_Click(object sender, EventArgs e)
        {
            Form newForm = new RegistrarAsistenciaEntrenamientoForm();
            newForm.ShowDialog();
        }

        private void btnReporteAsistenciaEntrenamiento_Click(object sender, EventArgs e)
        {
            Form newForm = new ReporteAsistenciaEntrenamientoForm();
            newForm.ShowDialog();
        }

        private void btnBajaAlumnoEntrenamiento_Click(object sender, EventArgs e)
        {
            Form newForm = new BajaAlumnoEntrenamientoForm();
            newForm.ShowDialog();
        }
    }
}
