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
                string clubJson = await _apiService.GetClubDataAsync();
                string usuarioJson = await _apiService.GetUserDataAsync();

                var options = new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var miClub = System.Text.Json.JsonSerializer.Deserialize<Club>(clubJson, options);
                var miUsuario = System.Text.Json.JsonSerializer.Deserialize<Usuario>(usuarioJson, options);

                if (miClub is not null)
                {
                    lblNombreClub.Text = miClub.Nombre ?? "Nombre no disponible";
                    lblCuitClub.Text = miClub.Cuit ?? "CUIT no disponible";
                    lblTelefonoClub.Text = miClub.Telefono ?? "Teléfono no disponible";
                    lblEmailClub.Text = miClub.Email ?? "Email no disponible";
                    lblCalleClub.Text = miClub.Direccion?.Calle ?? "Calle no disponible";
                    lblNumeroClub.Text = miClub.Direccion?.Numero ?? "Número no disponible";
                    lblCodigoPostalClub.Text = miClub.Direccion?.Cp ?? "Código Postal no disponible";
                    lblLocalidadClub.Text = miClub.Direccion?.Localidad ?? "Localidad no disponible";
                    lblCiudadClub.Text = miClub.Direccion?.Ciudad ?? "Ciudad no disponible";
                    lblProvinciaClub.Text = miClub.Direccion?.Provincia ?? "Provincia no disponible";
                    lblPaisClub.Text = miClub.Direccion?.Pais ?? "País no disponible";
                }
                if (miUsuario is not null)
                {
                    lblNombreAdmin.Text = $"{miUsuario.Nombre} {miUsuario.Apellido}".Trim();
                    lblDniAdmin.Text = miUsuario.Dni ?? "DNI no disponible";
                    lblTelefonoAdmin.Text = miUsuario.Telefono ?? "Teléfono no disponible";
                    lblEmailAdmin.Text = miUsuario.Email ?? "Email no disponible";
                    lblFechaRegistroAdmin.Text = miUsuario.Fecha_Registro.ToShortDateString();
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show($"Error al procesar los datos del panel: {ex.Message}", "Error local"); 
            }
        }
    }
}
