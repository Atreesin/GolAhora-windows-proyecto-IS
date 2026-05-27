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
    public ucCanchas()
    {
        InitializeComponent();
    }

    //
    //Busqueda en la lista
    //
    private void ValidarCamposBusqueda(object sender, EventArgs e)
    {
        btnBuscar.Enabled = !string.IsNullOrWhiteSpace(txtBusqueda.Text)
            && (cbFiltrado.SelectedItem != null || cbEstados.SelectedItem != null);
    }

    private void cbEstados_SelectedIndexChanged(object sender, EventArgs e) => ValidarCamposBusqueda(sender, e);

    private void cbFiltrar_SelectedIndexChanged(object sender, EventArgs e) => ValidarCamposBusqueda(sender, e);

    private void txtBusqueda_TextChanged(object sender, EventArgs e) => ValidarCamposBusqueda(sender, e);

    
    /*Botón de búsqueda*/
    private void btnBuscar_Click(object sender, EventArgs e)
    {

    }

    //
    //
    //

    private void tcCanchas_Click(object sender, EventArgs e)
    {
        //limpiamos selección de las lista
        listBoxCanchas.ClearSelected();
        listBoxTiposCancha.ClearSelected();

        bool pestañaCanchas = (tcCanchas.SelectedIndex == 0);

        cbEstados.Enabled = pestañaCanchas;
        cbFiltrado.Enabled = pestañaCanchas;
        txtBusqueda.Enabled = pestañaCanchas;
        btnBuscar.Enabled = pestañaCanchas;

        if (!pestañaCanchas) txtBusqueda.Text = string.Empty;
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

        RegistroTipoDeCanchaForm newForm = new RegistroTipoDeCanchaForm();
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
