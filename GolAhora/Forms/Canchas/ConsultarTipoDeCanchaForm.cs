using GolAhora.Models;
using GolAhora.Services;
using System;
using System.Windows.Forms;

namespace GolAhora.Forms
{
    public partial class ConsultarTipoDeCanchaForm : Form
    {
        //variables globales
        private TipoDeCancha? tipo;
        private ApiService apiService = new ApiService();

        //constructors
        public ConsultarTipoDeCanchaForm()
        {
            InitializeComponent();
        }
        public ConsultarTipoDeCanchaForm(TipoDeCancha tipo)
        {
            InitializeComponent();
            this.tipo= tipo;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void ConsultarTipoDeCanchaForm_Load(object sender, EventArgs e)
        {
            TipoDeCancha tipoCompleto = await apiService.GetTipoDeCanchaByIdAsync(tipo!.Id);

            if (tipo is not null)
            {
                txtTipo.Text = tipoCompleto.Tipo_Cancha;
                txtDuracionMinima.Text = $"{tipoCompleto.Duracion_Min} min";
                txtDuracionMaxima.Text = $"{tipoCompleto.Duracion_Max} min";
                txtCapacidad.Text = tipoCompleto.Capacidad.ToString();
                txtDimension.Text = $"{tipoCompleto.Ancho}m x {tipo.Largo}m";
                if (tipoCompleto.Superficie is not null) txtSuperficie.Text = tipoCompleto.Superficie.Tipo_Superficie;


                if (!string.IsNullOrWhiteSpace(tipo.Imagen_Url))
                {
                    try
                    {
                        string baseUrl = "https://golahora-proyecto-is.onrender.com/api";

                        pictureBoxImagen.LoadAsync(baseUrl + tipo.Imagen_Url);
                    }
                    catch (Exception)
                    {
                        pictureBoxImagen.Image = null;
                    }
                }
            }
        }
    }
}