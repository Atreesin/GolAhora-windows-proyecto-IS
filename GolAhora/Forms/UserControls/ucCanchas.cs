using GolAhora.Models;
using GolAhora.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GolAhora.Forms.UserControls;

public partial class ucCanchas : UserControl
{
    //variables
    private ApiService apiService = new ApiService();

    private List<Cancha> canchas = new();
    private List<TipoDeCancha> tiposDeCancha = new();
    public ucCanchas()
    {
        InitializeComponent();
    }

    /*Carga del control de canchas*/
    private async void ucCanchas_Load(object sender, EventArgs e)
    {
        canchas = await apiService.GetCanchasAsync();
        tiposDeCancha = await apiService.GetTiposDeCanchaAsync();


        if (canchas is not null)
        {
            listBoxCanchas.DataSource = canchas;
            listBoxCanchas.SelectedIndex = -1;
        }
        if (tiposDeCancha is not null)
        {
            listBoxTiposCancha.DataSource = tiposDeCancha;
            listBoxTiposCancha.SelectedIndex = -1;
        }
    }

    //
    //Busqueda en la lista
    //

    private void cbEstados_SelectedIndexChanged(object sender, EventArgs e) => ValidarCamposBusqueda(sender, e);

    private void cbFiltrado_SelectedIndexChanged(object sender, EventArgs e) => ValidarCamposBusqueda(sender, e);

    private void txtBusqueda_TextChanged(object sender, EventArgs e)
    {
        ValidarCamposBusqueda(sender, e);

        // Si el texto está vacío, restauramos la lista original de la pestaña activa
        if (string.IsNullOrWhiteSpace(txtBusqueda.Text))
        {
            if (tcCanchas.SelectedIndex == 0)
            {
                listBoxCanchas.DataSource = null;
                listBoxCanchas.DataSource = canchas;
                listBoxCanchas.SelectedIndex = -1;
            }
            else if (tcCanchas.SelectedIndex == 1)
            {
                listBoxTiposCancha.DataSource = null;
                listBoxTiposCancha.DataSource = tiposDeCancha;
                listBoxTiposCancha.SelectedIndex = -1;
            }
        }
    }


    /*Botón de búsqueda*/
    private void btnBuscar_Click(object sender, EventArgs e)
    {
        string valorBuscado = txtBusqueda.Text.Trim().ToLower();

        if (cbFiltrado.SelectedItem == null) return;
        string? filtroSeleccionado = cbFiltrado.SelectedItem.ToString();

        /*pestaña canchas*/
        if (tcCanchas.SelectedIndex == 0)
        {
            // Empezamos con la lista completa
            var canchasFiltradas = canchas.AsQueryable();

            // 1. (Futuro) Filtro por estado
            /*
            if (cbEstados.SelectedItem != null && cbEstados.SelectedItem.ToString() != "Todas")
            {
                string estado = cbEstados.SelectedItem.ToString();
                // canchasFiltradas = canchasFiltradas.Where(c => c.Estado == estado);
            }
            */

            // 2. Filtro por texto
            switch (filtroSeleccionado)
            {
                case "ID":
                    canchasFiltradas = canchasFiltradas.Where(c => c.Id.ToString().Contains(valorBuscado));
                    break;
                case "Tipo":
                    canchasFiltradas = canchasFiltradas.Where(c => c.Tipo_Cancha != null &&
                                                                   c.Tipo_Cancha != null &&
                                                                   c.Tipo_Cancha.ToLower().Contains(valorBuscado));
                    break;
            }

            listBoxCanchas.DataSource = null;
            listBoxCanchas.DataSource = canchasFiltradas.ToList();
            listBoxCanchas.SelectedIndex = -1;
        }
        /*pestaña tipos de cancha*/
        else if (tcCanchas.SelectedIndex == 1)
        {
            var tiposFiltrados = tiposDeCancha.AsQueryable();

            switch (filtroSeleccionado)
            {
                case "ID":
                    tiposFiltrados = tiposFiltrados.Where(t => t.Id.ToString().Contains(valorBuscado));
                    break;
                case "Tipo":
                    tiposFiltrados = tiposFiltrados.Where(t => t.Tipo!= null && t.Tipo.ToLower().Contains(valorBuscado));
                    break;
            }

            listBoxTiposCancha.DataSource = null;
            listBoxTiposCancha.DataSource = tiposFiltrados.ToList();
            listBoxTiposCancha.SelectedIndex = -1;
        }
    }

    //
    //
    //

    private void tcCanchas_Click(object sender, EventArgs e)
    {
        // Limpiamos selección de las listas
        listBoxCanchas.ClearSelected();
        listBoxTiposCancha.ClearSelected();

        bool pestañaCanchas = (tcCanchas.SelectedIndex == 0);

        cbEstados.Enabled = pestañaCanchas;

        if (!pestañaCanchas) cbEstados.SelectedIndex = -1;
        ValidarCamposBusqueda(sender, e);
    }

    private void ValidarCamposBusqueda(object sender, EventArgs e)
    {
        bool tieneTexto = !string.IsNullOrWhiteSpace(txtBusqueda.Text);
        bool tieneFiltro = cbFiltrado.SelectedItem != null;

        // Si estamos en Canchas, exigimos que el cbEstados tenga algo. 
        // Si estamos en Tipos (Index 1), el estado siempre es válido porque no se usa.
        bool estadoValido = (tcCanchas.SelectedIndex == 1) || (cbEstados.SelectedItem != null);

        btnBuscar.Enabled = tieneTexto && tieneFiltro && estadoValido;
    }

    private void listBoxCanchas_SelectedIndexChanged(object sender, EventArgs e)
    {
        bool canchaSeleccionada = (listBoxCanchas.SelectedIndex >= 0);

        btnConsultarCancha.Enabled = canchaSeleccionada;
        btnBloquearCancha.Enabled = canchaSeleccionada;
        btnModificarCancha.Enabled = canchaSeleccionada;
        btnBajaCancha.Enabled = canchaSeleccionada;
    }

    private void listBoxTiposCancha_SelectedIndexChanged(object sender, EventArgs e)
    {
        bool tipoSeleccionado = (listBoxTiposCancha.SelectedIndex >= 0);

        btnConsultarTipo.Enabled = tipoSeleccionado;
        btnModificarTipo.Enabled = tipoSeleccionado;
        btnEliminarTipo.Enabled = tipoSeleccionado;
    }

    private void listBoxCanchas_MouseDown(object sender, MouseEventArgs e)
    {
        int index = listBoxCanchas.IndexFromPoint(e.Location);
        if (index == -1) listBoxCanchas.ClearSelected();
    }

    private void listBoxTiposCancha_MouseDown(object sender, MouseEventArgs e)
    {
        int index = listBoxTiposCancha.IndexFromPoint(e.Location);
        if (index == -1) listBoxTiposCancha.ClearSelected();
    }

    private void ucCanchas_Click(object sender, EventArgs e)
    {
        //limpiamos selección de la lista
        listBoxCanchas.ClearSelected();
        listBoxTiposCancha.ClearSelected();
    }

    //
    //Botones del panel
    //

    /*Botones de la pestaña canchas*/
    private void btnRegistrarCancha_Click(object sender, EventArgs e)
    {
        //limpiamos selección de la lista
        listBoxCanchas.ClearSelected();

        Form newForm = new RegistrarCanchaForm();
        newForm.ShowDialog();
    }

    private void btnConsultarCancha_Click(object sender, EventArgs e)
    {
        Form newForm = new ConsultarCanchaForm();
        newForm.ShowDialog();
    }

    private void btnModificarCancha_Click(object sender, EventArgs e)
    {
        Form newForm = new ModificarCanchaForm();
        newForm.ShowDialog();
    }

    private void btnBloquearCancha_Click(object sender, EventArgs e)
    {
        Form newForm = new BloquearCanchaForm();
        newForm.ShowDialog();
    }

    private void btnBajaCancha_Click(object sender, EventArgs e)
    {
        MessageBox.Show(
            $"¿Seguro que deseas dar de baja la cancha <<xxx>>?",
            "Confirmar baja de cancha",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
    }

    /*Botones de la pestaña tipos de cancha*/
    private void btnRegistrarTipo_Click(object sender, EventArgs e)
    {
        //limpiamos selección de la lista
        listBoxTiposCancha.ClearSelected();

        RegistrarTipoCanchaForm newForm = new RegistrarTipoCanchaForm();
        newForm.ShowDialog();
    }

    private void btnReporteTipos_Click(object sender, EventArgs e)
    {
        //limpiamos selección de la lista
        listBoxTiposCancha.ClearSelected();

        MessageBox.Show(
                "El reporte de tipos de cancha del club se encuentra en proceso...",
                "Reporte de tipos de cancha",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
    }

    private void btnConsultarTipo_Click(object sender, EventArgs e)
    {
        Form newForm = new ConsultarTipoDeCanchaForm();
        newForm.ShowDialog();
    }

    private void btnModificarTipo_Click(object sender, EventArgs e)
    {
        Form newForm = new ModificarTipoDeCanchaForm();
        newForm.ShowDialog();
    }

    private void btnEliminarTipo_Click(object sender, EventArgs e)
    {
        MessageBox.Show(
            $"¿Seguro que deseas eliminar el tipo de cancha <<xxx>>?",
            "Confirmar eliminación de tipo de cancha",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
    }
}
