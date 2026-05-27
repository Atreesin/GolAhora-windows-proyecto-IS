using GolAhora.Models;
using GolAhora.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GolAhora.Forms.UserControls
{
    public partial class ucLobby : UserControl
    {
        private ApiService _apiService = new ApiService();
        public ucLobby()
        {
            InitializeComponent();
        }

        private async void ucLobby_Load(object sender, EventArgs e)
        {
            try
            {
                string jsonResult = await _apiService.GetClubDataAsync();

                var options = new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var miClub = System.Text.Json.JsonSerializer.Deserialize<Club>(jsonResult, options);

                if (miClub != null)
                {
                    lblNombreClub.Text = miClub.Nombre ?? "Nombre no disponible";
                    lblCuitClub.Text = miClub.Cuit ?? "CUIT no disponible";
                    lblTelefonoClub.Text = miClub.Telefono ?? "Teléfono no disponible";
                    lblEmailClub.Text = miClub.Email ?? "Email no disponible";
                    lblCalleClub.Text = miClub.Calle ?? "Calle no disponible";
                    lblNumeroClub.Text = miClub.Numero ?? "Número no disponible";
                    lblCodigoPostalClub.Text = miClub.Codigo_Postal ?? "Código Postal no disponible";
                    lblLocalidadClub.Text = miClub.Localidad ?? "Localidad no disponible";
                    lblCiudadClub.Text = miClub.Ciudad ?? "Ciudad no disponible";
                    lblProvinciaClub.Text = miClub.Provincia ?? "Provincia no disponible";
                    lblPaisClub.Text = miClub.Pais ?? "País no disponible";
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show($"Error al procesar los datos del panel: {ex.Message}", "Error local"); 
            }
        }
    }
}
