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
            administradores = await apiService.GetAdminsAsync();
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

        private List<T> FiltrarLista<T>(List<T> listaOriginal, string filtro, string valorBuscado) where T : Usuario
        {
            switch (filtro)
            {
                case "Dni":
                    return listaOriginal.Where(u => u.Dni != null && u.Dni.ToLower().Contains(valorBuscado)).ToList();

                case "Nombre":
                    return listaOriginal.Where(u =>
                        (u.Nombre != null && u.Nombre.ToLower().Contains(valorBuscado)) ||
                        (u.Apellido != null && u.Apellido.ToLower().Contains(valorBuscado))
                    ).ToList();

                case "Email":
                    return listaOriginal.Where(u => u.Email != null && u.Email.ToLower().Contains(valorBuscado)).ToList();

                default:
                    return listaOriginal;
            }
        }

        private void ValidarCamposBusqueda(object sender, EventArgs e)
        {
            btnBuscar.Enabled = !string.IsNullOrWhiteSpace(txtBusqueda.Text)
                && (cbFiltrado.SelectedItem != null);
        }


        private void cbFiltrado_SelectedIndexChanged(object sender, EventArgs e) => ValidarCamposBusqueda(sender, e);

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            ValidarCamposBusqueda(sender, e);

            // Si el texto está vacío, restauramos la lista de la pestaña activa
            if (string.IsNullOrWhiteSpace(txtBusqueda.Text))
            {
                switch (tcUsuarios.SelectedIndex)
                {
                    case 0:
                        listBoxClientes.DataSource = null;
                        listBoxClientes.DataSource = clientes;
                        listBoxClientes.SelectedIndex = -1;
                        break;
                    case 1:
                        listBoxProfesores.DataSource = null;
                        listBoxProfesores.DataSource = profesores;
                        listBoxProfesores.SelectedIndex = -1;
                        break;
                    case 2:
                        listBoxEntrenadores.DataSource = null;
                        listBoxEntrenadores.DataSource = entrenadores;
                        listBoxEntrenadores.SelectedIndex = -1;
                        break;
                    case 3:
                        listBoxAdministradores.DataSource = null;
                        listBoxAdministradores.DataSource = administradores;
                        listBoxAdministradores.SelectedIndex = -1;
                        break;
                    case 4:
                        listBoxUsuarios.DataSource = null;
                        listBoxUsuarios.DataSource = usuarios;
                        listBoxUsuarios.SelectedIndex = -1;
                        break;
                }
            }
        }

        /*Botón de búsqueda*/
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string valorBuscado = txtBusqueda.Text.Trim().ToLower();
            string filtroSeleccionado = cbFiltrado.SelectedItem.ToString();

            switch (tcUsuarios.SelectedIndex)
            {
                case 0: 
                    listBoxClientes.DataSource = null;
                    listBoxClientes.DataSource = FiltrarLista(clientes, filtroSeleccionado, valorBuscado);
                    listBoxClientes.SelectedIndex = -1;
                    break;

                case 1:
                    listBoxProfesores.DataSource = null;
                    listBoxProfesores.DataSource = FiltrarLista(profesores, filtroSeleccionado, valorBuscado);
                    listBoxProfesores.SelectedIndex = -1;
                    break;

                case 2:
                    listBoxEntrenadores.DataSource = null;
                    listBoxEntrenadores.DataSource = FiltrarLista(entrenadores, filtroSeleccionado, valorBuscado);
                    listBoxEntrenadores.SelectedIndex = -1;
                    break;

                case 3:
                    listBoxAdministradores.DataSource = null;
                    listBoxAdministradores.DataSource = FiltrarLista(administradores, filtroSeleccionado, valorBuscado);
                    listBoxAdministradores.SelectedIndex = -1;
                    break;
                case 4:
                    listBoxUsuarios.DataSource = null;
                    listBoxUsuarios.DataSource = FiltrarLista(usuarios, filtroSeleccionado, valorBuscado);
                    listBoxUsuarios.SelectedIndex = -1;
                    break;
            }
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
                Cliente clienteCompleto = await apiService.GetClientByIdAsync(clienteResumido.Id);
                btnConsultarCliente.Enabled = true;

                if (clienteCompleto is not null)
                {
                    Form newForm = new ConsultarClienteForm(clienteCompleto);
                    newForm.ShowDialog();
                }
            }
        }

        private async void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedIndex >= 0 && listBoxClientes.SelectedItem is Cliente clienteResumido)
            {
                btnModificarCliente.Enabled = false;
                Cliente clienteCompleto = await apiService.GetClientByIdAsync(clienteResumido.Id);
                btnModificarCliente.Enabled = true;

                if (clienteCompleto is not null)
                {
                    Form newForm = new ModificarClienteForm(clienteCompleto);
                    newForm.ShowDialog();
                }
            }
        }

        private void btnImprimirCliente_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedItem is Cliente c)
            {
                MessageBox.Show(
                    $"La impresión de los datos del cliente {c.Nombre} {c.Apellido} (dni: {c.Dni}) se encuentra en proceso...",
                    "Imprimir datos de cliente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnBajaCliente_Click(object sender, EventArgs e)
        {
            if(listBoxClientes.SelectedItem is Cliente c)
            {
                MessageBox.Show(
                    $"¿Seguro que deseas dar de baja del sistema al cliente {c.Nombre} {c.Apellido} (dni: {c.Dni})?",
                    "Confirmar baja de cliente",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            }
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
                Profesor profeCompleto = await apiService.GetTeacherByIdAsync(profeResumido.Id);
                btnConsultarProfesor.Enabled = true;

                if (profeCompleto is not null)
                {
                    Form newForm = new ConsultarProfesorForm(profeCompleto);
                    newForm.ShowDialog();
                }
            }
        }

        private async void btnModificarProfesor_Click(object sender, EventArgs e)
        {
            if (listBoxProfesores.SelectedIndex >= 0 && listBoxProfesores.SelectedItem is Profesor profeResumido)
            {
                btnModificarProfesor.Enabled = false;
                Profesor profeCompleto = await apiService.GetTeacherByIdAsync(profeResumido.Id);
                btnModificarProfesor.Enabled = true;

                if (profeCompleto is not null)
                {
                    Form newForm = new ModificarProfesorForm(profeCompleto);
                    newForm.ShowDialog();
                }
            }
        }

        private void btnImprimirProfesor_Click(object sender, EventArgs e)
        {
            if (listBoxProfesores.SelectedItem is Profesor p)
            {
                MessageBox.Show(
                    $"La impresión de los datos del profesor {p.Nombre} {p.Apellido} (dni: {p.Dni}) se encuentra en proceso...",
                    "Imprimir datos de profesor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnBajaProfesor_Click(object sender, EventArgs e)
        {
            if (listBoxProfesores.SelectedItem is Profesor p)
            {
                MessageBox.Show(
                    $"¿Seguro que deseas dar de baja del sistema al profesor {p.Nombre} {p.Apellido} (dni: {p.Dni})?",
                    "Confirmar baja de profesor",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            }
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
                Entrenador entrenadorCompleto = await apiService.GetTrainerByIdAsync(entrenadorResumido.Id);
                btnConsultarEntrenador.Enabled = true;

                if (entrenadorCompleto is not null)
                {
                    Form newForm = new ConsultarEntrenadorForm(entrenadorCompleto);
                    newForm.ShowDialog();
                }
            }
        }

        private async void btnModificarEntrenador_Click(object sender, EventArgs e)
        {
            if (listBoxEntrenadores.SelectedIndex >= 0 && listBoxEntrenadores.SelectedItem is Entrenador entrenadorResumido)
            {
                btnModificarEntrenador.Enabled = false;
                Entrenador entrenadorCompleto = await apiService.GetTrainerByIdAsync(entrenadorResumido.Id);
                btnModificarEntrenador.Enabled = true;

                if (entrenadorCompleto is not null)
                {
                    Form newForm = new ModificarEntrenadorForm(entrenadorCompleto);
                    newForm.ShowDialog();
                }
            }
        }

        private void btnImprimirEntrenador_Click(object sender, EventArgs e)
        {
            if (listBoxEntrenadores.SelectedItem is Entrenador en)
            {
                MessageBox.Show(
                    $"La impresión de los datos del entrenador {en.Nombre} {en.Apellido} (dni: {en.Dni}) se encuentra en proceso...",
                    "Imprimir datos de entrenador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnBajaEntrenador_Click(object sender, EventArgs e)
        {
            if (listBoxEntrenadores.SelectedItem is Entrenador en)
            {
                MessageBox.Show(
                    $"¿Seguro que deseas dar de baja del sistema al entrenador {en.Nombre} {en.Apellido} (dni: {en.Dni})?",
                    "Confirmar baja de entrenador",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            }
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
                Administrador adminCompleto = await apiService.GetAdminByIdAsync(adminResumido.Id);
                btnConsultarAdmin.Enabled = true;

                if (adminCompleto is not null)
                {
                    Form newForm = new ConsultarAdministradorForm(adminCompleto);
                    newForm.ShowDialog();
                }
            }
        }

        private async void btnModificarAdmin_Click(object sender, EventArgs e)
        {
            if (listBoxAdministradores.SelectedIndex >= 0 && listBoxAdministradores.SelectedItem is Administrador adminResumido)
            {
                btnModificarAdmin.Enabled = false;
                Administrador adminCompleto = await apiService.GetAdminByIdAsync(adminResumido.Id);
                btnModificarAdmin.Enabled = true;

                if (adminCompleto is not null)
                {
                    Form newForm = new ModificarAdministradorForm(adminCompleto);
                    newForm.ShowDialog();
                }
            }
        }

        private void btnImprimirAdmin_Click(object sender, EventArgs e)
        {
            if (listBoxAdministradores.SelectedItem is Administrador a)
            {
                MessageBox.Show(
                    $"La impresión de los datos del administrador {a.Nombre} {a.Apellido} (dni: {a.Dni}) se encuentra en proceso...",
                    "Imprimir datos de administrador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnBajaAdmin_Click(object sender, EventArgs e)
        {
            if (listBoxAdministradores.SelectedItem is Administrador a)
            {
                MessageBox.Show(
                    $"¿Seguro que deseas dar de baja del sistema al administrador {a.Nombre} {a.Apellido} (dni: {a.Dni})?",
                    "Confirmar baja de administrador",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            }
        }
    }
}
