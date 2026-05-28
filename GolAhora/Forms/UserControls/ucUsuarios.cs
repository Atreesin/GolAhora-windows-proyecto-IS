using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GolAhora.Models;
using GolAhora.Services;

namespace GolAhora.Forms.UserControls
{
    public partial class ucUsuarios : UserControl
    {
        //variables
        private ApiService apiService = new ApiService();

        private List<Cliente> clientes = new();
        private List<Profesor> profesores = new();
        private List<Entrenador> entrenadores = new();
        private List<Administrador> administradores = new();
        private List<Usuario> usuarios= new();

        //constructor
        public ucUsuarios()
        {
            InitializeComponent();
        }


        /*Carga del control de usuarios*/
        private async void ucUsuarios_Load(object sender, EventArgs e)
        {
            clientes = await apiService.GetClientsAsync();
            profesores = await apiService.GetTeachersAsync();
            entrenadores = await apiService.GetTrainersAsync();
            //administradores = await apiService.GetAdminsAsync();
            usuarios = await apiService.GetUsersAsync();

            if (clientes is not null)
            {
                listBoxClientes.DataSource = clientes;
                listBoxClientes.SelectedIndex = -1;
            }
            if (profesores is not null)
            {
                listBoxProfesores.DataSource = profesores;
                listBoxProfesores.SelectedIndex = -1;
            }
            if (entrenadores is not null)
            {
                listBoxEntrenadores.DataSource = entrenadores;
                listBoxEntrenadores.SelectedIndex = -1;
            }
            if (administradores is not null)
            {
                listBoxAdministradores.DataSource = administradores;
                listBoxAdministradores.SelectedIndex = -1;
            }
            if (usuarios is not null)
            {
                listBoxUsuarios.DataSource = usuarios;
                listBoxUsuarios.SelectedIndex = -1;
            }

            
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

        //
        //Botones del panel
        //

        /*Botones de la pestaña clientes*/
        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            //limpiamos selección de las lista
            CleanSelected();

            Form newForm = new RegistrarClienteForm();
            newForm.ShowDialog();
        }

        private async void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedIndex >= 0 && listBoxClientes.SelectedItem is Cliente clienteResumido)
            {
                btnConsultarCliente.Enabled = false;
                Cliente clienteCompleto = await apiService.GetClientByIdAsync(clienteResumido.Id_Usuario);
                btnConsultarCliente.Enabled = true;

                if (clienteCompleto is not null)
                {
                    Form newForm = new ConsultarClienteForm(clienteCompleto);
                    newForm.ShowDialog();

                    CleanSelected();
                }
            }
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

        private async void btnConsultarProfesor_Click(object sender, EventArgs e)
        {
            if (listBoxProfesores.SelectedIndex >= 0 && listBoxProfesores.SelectedItem is Profesor profeResumido)
            {
                btnConsultarProfesor.Enabled = false;
                Profesor profeCompleto = (Profesor)await apiService.GetUserByIdAsync(profeResumido.Id_Usuario);
                btnConsultarProfesor.Enabled = true;

                if (profeCompleto is not null)
                {
                    Form newForm = new ConsultarProfesorForm(profeCompleto);
                    newForm.ShowDialog();

                    CleanSelected();
                }
            }
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

        private async void btnConsultarEntrenador_Click(object sender, EventArgs e)
        {
            if (listBoxEntrenadores.SelectedIndex >= 0 && listBoxEntrenadores.SelectedItem is Entrenador entrenadorResumido)
            {
                btnConsultarEntrenador.Enabled = false;
                Entrenador entrenadorCompleto = (Entrenador)await apiService.GetUserByIdAsync(entrenadorResumido.Id_Usuario);
                btnConsultarEntrenador.Enabled = true;

                if (entrenadorCompleto is not null)
                {
                    Form newForm = new ConsultarEntrenadorForm(entrenadorCompleto);
                    newForm.ShowDialog();

                    CleanSelected();
                }
            }
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

        private async void btnConsultarAdmin_Click(object sender, EventArgs e)
        {
            if (listBoxAdministradores.SelectedIndex >= 0 && listBoxAdministradores.SelectedItem is Administrador adminResumido)
            {
                btnConsultarAdmin.Enabled = false;
                Administrador adminCompleto = (Administrador)await apiService.GetUserByIdAsync(adminResumido.Id_Usuario);
                btnConsultarAdmin.Enabled = true;

                if (adminCompleto is not null)
                {
                    Form newForm = new ConsultarAdministradorForm(adminCompleto);
                    newForm.ShowDialog();

                    CleanSelected();
                }
            }
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
