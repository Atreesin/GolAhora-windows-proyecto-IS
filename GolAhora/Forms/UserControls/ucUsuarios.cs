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
    public partial class ucUsuarios : UserControl
    {
        public ucUsuarios()
        {
            InitializeComponent();
        }

        private void listBoxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool usuarioSeleccionado = (listBoxUsuarios.SelectedIndex >= 0);

            //
            //
            //
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool clienteSeleccionado = (listBoxClientes.SelectedIndex >= 0);

            btnConsultarCliente.Enabled = clienteSeleccionado;
            btnModificarCliente.Enabled = clienteSeleccionado;
            btnImprimirCliente.Enabled = clienteSeleccionado;
            btnBajaCliente.Enabled = clienteSeleccionado;
        }

        private void listBoxProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool profesorSeleccionado = (listBoxProfesores.SelectedIndex >= 0);

            btnConsultarProfesor.Enabled = profesorSeleccionado;
            btnModificarProfesor.Enabled = profesorSeleccionado;
            btnImprimirProfesor.Enabled = profesorSeleccionado;
            btnBajaProfesor.Enabled = profesorSeleccionado;
        }

        private void listBoxEntrenadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool entrenadorSeleccionado = (listBoxEntrenadores.SelectedIndex >= 0);

            btnConsultarEntrenador.Enabled = entrenadorSeleccionado;
            btnModificarEntrenador.Enabled = entrenadorSeleccionado;
            btnImprimirEntrenador.Enabled = entrenadorSeleccionado;
            btnBajaEntrenador.Enabled = entrenadorSeleccionado;
        }

        private void listBoxAdministradores_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool adminSeleccionado = (listBoxAdministradores.SelectedIndex >= 0);

            btnConsultarAdmin.Enabled = adminSeleccionado;
            btnModificarAdmin.Enabled = adminSeleccionado;
            btnImprimirAdmin.Enabled = adminSeleccionado;
            btnBajaAdmin.Enabled = adminSeleccionado;
        }

        private void listBoxUsuarios_MouseDown(object sender, MouseEventArgs e)
        {
            int index = listBoxUsuarios.IndexFromPoint(e.Location);
            if (index == -1) listBoxUsuarios.ClearSelected();
        }

        private void listBoxClientes_MouseDown(object sender, MouseEventArgs e)
        {
            int index = listBoxClientes.IndexFromPoint(e.Location);
            if (index == -1) listBoxClientes.ClearSelected();
        }

        private void listBoxProfesores_MouseDown(object sender, MouseEventArgs e)
        {
            int index = listBoxProfesores.IndexFromPoint(e.Location);
            if (index == -1) listBoxProfesores.ClearSelected();
        }

        private void listBoxEntrenadores_MouseDown(object sender, MouseEventArgs e)
        {
            int index = listBoxEntrenadores.IndexFromPoint(e.Location);
            if (index == -1) listBoxEntrenadores.ClearSelected();
        }

        private void listBoxAdministradores_MouseDown(object sender, MouseEventArgs e)
        {
            int index = listBoxAdministradores.IndexFromPoint(e.Location);
            if (index == -1) listBoxAdministradores.ClearSelected();
        }

        private void ucUsuarios_Click(object sender, EventArgs e)
        {
            //limpiamos selección de las lista
            CleanSelected();

        }

        private void tcUsuarios_Click(object sender, EventArgs e)
        {
            //limpiamos selección de las lista
            CleanSelected();
        }

        private void CleanSelected()
        {
            listBoxUsuarios.ClearSelected();
            listBoxClientes.ClearSelected();
            listBoxProfesores.ClearSelected();
            listBoxEntrenadores.ClearSelected();
            listBoxAdministradores.ClearSelected();
        }

        /*Botones del panel*/
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
        /*Botones de la pestaña todos*/

        /*Botones de la pestaña clientes*/
         private void btnRegistrarCliente_Click(object sender, EventArgs e)
         {
             //limpiamos selección de las lista
             CleanSelected();

             Form newForm = new RegistrarClienteForm();
             newForm.ShowDialog();
         }

         private void btnConsultarCliente_Click(object sender, EventArgs e)
         {
             Form newForm = new ConsultarClienteForm();
             newForm.ShowDialog();
         }

         private void btnModificarCliente_Click(object sender, EventArgs e)
         {
             Form newForm = new ModificarClienteForm();
             newForm.ShowDialog();
         }

         private void btnImprimirCliente_Click(object sender, EventArgs e)
         {
             MessageBox.Show(
                 $"La impresión de los datos del cliente <<xxx>> está en proceso...",
                 "Imprimir datos de cliente",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
         }

         private void btnBajaCliente_Click(object sender, EventArgs e)
         {
             MessageBox.Show(
                 $"¿Seguro que deseas dar de baja del sistema al cliente <<xxx>>?",
                 "Confirmar baja de cliente",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);
         }
        

        /*Botones de la pestaña profesores*/
         private void btnRegistrarProfesor_Click(object sender, EventArgs e)
         {
             //limpiamos selección de las lista
             CleanSelected();

             Form newForm = new RegistrarProfesorForm();
             newForm.ShowDialog();
         }

         private void btnConsultarProfesor_Click(object sender, EventArgs e)
         {
             Form newForm = new ConsultarProfesorForm();
             newForm.ShowDialog();
         }

         private void btnModificarProfesor_Click(object sender, EventArgs e)
         {
             Form newForm = new ModificarProfesorForm();
             newForm.ShowDialog();
         }

         private void btnImprimirProfesor_Click(object sender, EventArgs e)
         {
             MessageBox.Show(
                 $"La impresión de los datos del profesor <<xxx>> está en proceso...",
                 "Imprimir datos de profesor",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
         }

         private void btnBajaProfesor_Click(object sender, EventArgs e)
         {
             MessageBox.Show(
                 $"¿Seguro que deseas dar de baja del sistema al profesor <<xxx>>?",
                 "Confirmar baja de profesor",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);
         }
         

        /*Botones de la pestaña entrenadores*/
        private void btnRegistrarEntrenador_Click(object sender, EventArgs e)
        {
            //limpiamos selección de las lista
            CleanSelected();

            Form newForm = new RegistrarEntrenadorForm();
            newForm.ShowDialog();
        }

        private void btnConsultarEntrenador_Click(object sender, EventArgs e)
        {
            Form newForm = new ConsultarEntrenadorForm();
            newForm.ShowDialog();
        }

        private void btnModificarEntrenador_Click(object sender, EventArgs e)
        {
            Form newForm = new ModificarEntrenadorForm();
            newForm.ShowDialog();
        }

        private void btnImprimirEntrenador_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"La impresión de los datos del entrenador <<xxx>> está en proceso...",
                "Imprimir datos de entrenador",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnBajaEntrenador_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"¿Seguro que deseas dar de baja del sistema al entrenador <<xxx>>?",
                "Confirmar baja de entrenador",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }

        
        /*Botones de la pestaña administradores*/
        private void btnRegistrarAdmin_Click(object sender, EventArgs e)
        {
            //limpiamos selección de las lista
            CleanSelected();

            Form newForm = new RegistrarAdministradorForm();
            newForm.ShowDialog();
        }

        private void btnConsultarAdmin_Click(object sender, EventArgs e)
        {
            Form newForm = new ConsultarAdministradorForm();
            newForm.ShowDialog();
        }

        private void btnModificarAdmin_Click(object sender, EventArgs e)
        {
            Form newForm = new ModificarAdministradorForm();
            newForm.ShowDialog();
        }

        private void btnImprimirAdmin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"La impresión de los datos del administrador <<xxx>> está en proceso...",
                "Imprimir datos de administrador",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnBajaAdmin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"¿Seguro que deseas dar de baja del sistema al administrador <<xxx>>?",
                "Confirmar baja de administrador",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }
    }
}
