using GolAhora.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Nodes;

namespace GolAhora.Services
{
    public class ApiService
    {
        private static readonly HttpClient _client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost/api/")
        };

        static ApiService()
        {
            _client.DefaultRequestHeaders.Add("plataform", "windows");
        }

        public async Task<string> LoginAsync(string email, string password)
        {
            var values = new Dictionary<string, string>
            {
                { "email", email },
                { "password", password }
            };
            var content = new FormUrlEncodedContent(values);
            HttpResponseMessage response;
            
            try
            {
                response = await _client.PostAsync("login", content);

            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("No se pudo establecer conexión con el servidor", "Error de conexión");
                return null;
            }
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                var error = JsonNode.Parse(errorContent);
                MessageBox.Show($"{error?["message"] ?? "Desconocido"}", "Error de Inicio de Sesión");
                return null;
            }
        }

        public async Task<string> GetUserDataAsync()
        {
            if (string.IsNullOrEmpty(SessionManager.SessionId))
            {
                MessageBox.Show("No se ha iniciado sesión", "Error");
                return null;
            }
            _client.DefaultRequestHeaders.Remove("Authorization");
            _client.DefaultRequestHeaders.Add("Authorization", SessionManager.SessionId);
            HttpResponseMessage response;
            try
            {
                response = await _client.GetAsync("user_Info/Full_Info");
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("No se pudo establecer conexión con el servidor", "Error de conexión");
                return null;
            }
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                var error = JsonNode.Parse(errorContent);
                MessageBox.Show($"{error?["message"] ?? "Desconocido"}", "Error al obtener datos del usuario");
                return null;
            }
        }

        }
}

