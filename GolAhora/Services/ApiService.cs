using GolAhora.Models;
using GolAhora.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using static System.Windows.Forms.DataFormats;

namespace GolAhora.Services
{
    public class ApiService
    {
        private static readonly HttpClient _client = new HttpClient
        {
            BaseAddress = new Uri("https://golahora-proyecto-is.onrender.com/api/")
        };

        static ApiService()
        {
            _client.DefaultRequestHeaders.Add("plataform", "windows");
        }

        //
        //methods
        //

        /*login*/
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

        /*club*/
        public async Task<string> GetClubDataAsync()
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
                response = await _client.GetAsync("clubes/club_id=1/full_info");
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
                MessageBox.Show($"{error?["message"] ?? "Desconocido"}", "Error al obtener datos del club");
                return null;
            }
        }

        //
        //usuarios
        //

        /*información del usuario logueado*/
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
        
        //
        //obtener usuario por id
        //

        public async Task<Usuario> GetUserByIdAsync(int id)
        {
            if (string.IsNullOrEmpty(SessionManager.SessionId)) return null;

            _client.DefaultRequestHeaders.Remove("Authorization");
            _client.DefaultRequestHeaders.Add("Authorization", SessionManager.SessionId);

            try
            {
                HttpResponseMessage response = await _client.GetAsync($"users/user_id={id}/full_info");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                    Usuario user = JsonSerializer.Deserialize<Usuario>(jsonString, opciones);
                    return user;
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el detalle del usuario.", "Error");
                    return null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexión al obtener el detalle.", "Error");
                return null;
            }
        }

        public async Task<Cliente> GetClientByIdAsync(int id)
        {
            if (string.IsNullOrEmpty(SessionManager.SessionId)) return null;

            _client.DefaultRequestHeaders.Remove("Authorization");
            _client.DefaultRequestHeaders.Add("Authorization", SessionManager.SessionId);

            try
            {
                HttpResponseMessage response = await _client.GetAsync($"users/user_id={id}/full_info");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                    Cliente customer = JsonSerializer.Deserialize<Cliente>(jsonString, opciones);
                    return customer;
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el detalle del cliente.", "Error");
                    return null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexión al obtener el detalle.", "Error");
                return null;
            }
        }

        public async Task<Profesor> GetTeacherByIdAsync(int id)
        {
            if (string.IsNullOrEmpty(SessionManager.SessionId)) return null;

            _client.DefaultRequestHeaders.Remove("Authorization");
            _client.DefaultRequestHeaders.Add("Authorization", SessionManager.SessionId);

            try
            {
                HttpResponseMessage response = await _client.GetAsync($"users/user_id={id}/full_info");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                    Profesor teacher = JsonSerializer.Deserialize<Profesor>(jsonString, opciones);
                    return teacher;
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el detalle del profesor.", "Error");
                    return null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexión al obtener el detalle.", "Error");
                return null;
            }
        }
        public async Task<Entrenador> GetTrainerByIdAsync(int id)
        {
            if (string.IsNullOrEmpty(SessionManager.SessionId)) return null;

            _client.DefaultRequestHeaders.Remove("Authorization");
            _client.DefaultRequestHeaders.Add("Authorization", SessionManager.SessionId);

            try
            {
                HttpResponseMessage response = await _client.GetAsync($"users/user_id={id}/full_info");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                    Entrenador trainer = JsonSerializer.Deserialize<Entrenador>(jsonString, opciones);
                    return trainer;
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el detalle del entrenador.", "Error");
                    return null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexión al obtener el detalle.", "Error");
                return null;
            }
        }

        public async Task<Administrador> GetAdminByIdAsync(int id)
        {
            if (string.IsNullOrEmpty(SessionManager.SessionId)) return null;

            _client.DefaultRequestHeaders.Remove("Authorization");
            _client.DefaultRequestHeaders.Add("Authorization", SessionManager.SessionId);

            try
            {
                HttpResponseMessage response = await _client.GetAsync($"users/user_id={id}/full_info");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                    Administrador admin = JsonSerializer.Deserialize<Administrador>(jsonString, opciones);
                    return admin;
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el detalle del administrador.", "Error");
                    return null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexión al obtener el detalle.", "Error");
                return null;
            }
        }

        //
        //listar usuarios
        //
        public async Task<List<Usuario>> GetUsersAsync()
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
                response = await _client.GetAsync("users");
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("No se pudo establecer conexión con el servidor", "Error de conexión");
                return null;
            }

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrWhiteSpace(jsonString)) return new List<Usuario>();

                var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(jsonString, opciones);
                return usuarios;
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                var error = JsonNode.Parse(errorContent);
                MessageBox.Show($"{error?["message"] ?? "Desconocido"}", "Error al obtener datos de usuarios");
                return null;
            }
        }

        public async Task<List<Cliente>> GetClientsAsync()
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
                response = await _client.GetAsync("clientes");
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("No se pudo establecer conexión con el servidor", "Error de conexión");
                return null;
            }

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrWhiteSpace(jsonString)) { return new List<Cliente>(); }

                var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                List<Cliente> clientes = JsonSerializer.Deserialize<List<Cliente>>(jsonString, opciones);
                return clientes;
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                var error = JsonNode.Parse(errorContent);
                MessageBox.Show($"{error?["message"] ?? "Desconocido"}", "Error al obtener datos de clientes");
                return null;
            }
        }

        public async Task<List<Entrenador>> GetTrainersAsync()
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
                response = await _client.GetAsync("entrenadores");
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("No se pudo establecer conexión con el servidor", "Error de conexión");
                return null;
            }

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrWhiteSpace(jsonString)) return new List<Entrenador>();

                var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                List<Entrenador> entrenadores = JsonSerializer.Deserialize<List<Entrenador>>(jsonString, opciones);
                return entrenadores;
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                var error = JsonNode.Parse(errorContent);
                MessageBox.Show($"{error?["message"] ?? "Desconocido"}", "Error al obtener datos de entrenadores");
                return null;
            }
        }

        public async Task<List<Profesor>> GetTeachersAsync()
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
                response = await _client.GetAsync("profesores");
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("No se pudo establecer conexión con el servidor", "Error de conexión");
                return null;
            }

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrWhiteSpace(jsonString)) return new List<Profesor>();

                var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                List<Profesor> profesores = JsonSerializer.Deserialize<List<Profesor>>(jsonString, opciones);
                return profesores;
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                var error = JsonNode.Parse(errorContent);
                MessageBox.Show($"{error?["message"] ?? "Desconocido"}", "Error al obtener datos de profesores");
                return null;
            }
        }

        /*public async Task<List<Administrador>> GetAdminsAsync()
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
                response = await _client.GetAsync("administradores");
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("No se pudo establecer conexión con el servidor", "Error de conexión");
                return null;
            }

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrWhiteSpace(jsonString)) return new List<Administrador>();

                var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                List<Administrador> admins = JsonSerializer.Deserialize<List<Administrador>>(jsonString, opciones);
                return admins;
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                var error = JsonNode.Parse(errorContent);
                MessageBox.Show($"{error?["message"] ?? "Desconocido"}", "Error al obtener datos de administradores");
                return null;
            }
        }*/

        //
        //canchas y tipos de cancha
        //

        /*listar canchas*/
        public async Task<List<Cancha>> GetCanchasAsync()
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
                response = await _client.GetAsync("canchas");
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("No se pudo establecer conexión con el servidor", "Error de conexión");
                return null;
            }

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrWhiteSpace(jsonString)) return new List<Cancha>();

                var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                List<Cancha> canchas = JsonSerializer.Deserialize<List<Cancha>>(jsonString, opciones);
                return canchas;
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                var error = JsonNode.Parse(errorContent);
                MessageBox.Show($"{error?["message"] ?? "Desconocido"}", "Error al obtener datos de canchas");
                return null;
            }
        }

        /*obtener cancha por id*/
        public async Task<Cancha> GetCanchaByIdAsync(int id)
        {
            if (string.IsNullOrEmpty(SessionManager.SessionId)) return null;

            _client.DefaultRequestHeaders.Remove("Authorization");
            _client.DefaultRequestHeaders.Add("Authorization", SessionManager.SessionId);

            try
            {
                HttpResponseMessage response = await _client.GetAsync($"canchas/cancha_id={id}");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                    Cancha cancha = JsonSerializer.Deserialize<Cancha>(jsonString, opciones);
                    return cancha;
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el detalle de la cancha.", "Error");
                    return null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexión al obtener el detalle.", "Error");
                return null;
            }
        }

        /*listar tipos de cancha*/
        public async Task<List<TipoDeCancha>> GetTiposDeCanchaAsync()
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
                response = await _client.GetAsync("tipos_cancha");
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("No se pudo establecer conexión con el servidor", "Error de conexión");
                return null;
            }

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrWhiteSpace(jsonString)) return new List<TipoDeCancha>();

                var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                List<TipoDeCancha> tipos= JsonSerializer.Deserialize<List<TipoDeCancha>>(jsonString, opciones);
                return tipos;
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                string mensajeMostrar = $"Error del servidor: {(int)response.StatusCode} {response.StatusCode}";

                if (!string.IsNullOrWhiteSpace(errorContent))
                {
                    try
                    {
                        var error = JsonNode.Parse(errorContent);
                        if (error?["message"] != null)
                        {
                            mensajeMostrar = error["message"].ToString();
                        }
                        else
                        {
                            mensajeMostrar = errorContent;
                        }
                    }
                    catch (System.Text.Json.JsonException)
                    {
                        mensajeMostrar = errorContent;
                    }
                }

                MessageBox.Show(mensajeMostrar, "Error al obtener tipos de cancha");
                return null;
            }
        }

        /*obtener tipo de cancha por id*/
        public async Task<TipoDeCancha> GetTipoDeCanchaByIdAsync(int id)
        {
            if (string.IsNullOrEmpty(SessionManager.SessionId)) return null;

            _client.DefaultRequestHeaders.Remove("Authorization");
            _client.DefaultRequestHeaders.Add("Authorization", SessionManager.SessionId);

            try
            {
                HttpResponseMessage response = await _client.GetAsync($"tipos_canchas/cancha_id={id}");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                    TipoDeCancha tipo= JsonSerializer.Deserialize<TipoDeCancha>(jsonString, opciones);
                    return tipo;
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el detalle del tipo de cancha.", "Error");
                    return null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexión al obtener el detalle.", "Error");
                return null;
            }
        }

        /*listar superficies*/
        public async Task<string> GetSuperficiesAsync()
        {
            if (string.IsNullOrEmpty(SessionManager.SessionId))
            {
                MessageBox.Show("No se ha iniciado sesión", "Error");
                return null;
            }
            HttpResponseMessage response;
            try
            {
                response = await _client.GetAsync("superficies");
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

        public async Task<string> RegistrarTipoCanchaAsync(string tipo_cancha, int duracion_min, int duracion_max, decimal ancho, decimal largo, int capacidad, string rutaImagen, int id_superficie)
        {
            _client.DefaultRequestHeaders.Remove("Authorization");
            _client.DefaultRequestHeaders.Add("Authorization", SessionManager.SessionId);
            HttpResponseMessage response;

            using (var formData = new MultipartFormDataContent())
            {
                formData.Add(new StringContent(tipo_cancha), "tipo_cancha");
                formData.Add(new StringContent(duracion_min.ToString()), "duracion_min");
                formData.Add(new StringContent(duracion_max.ToString()), "duracion_max");

                formData.Add(new StringContent(ancho.ToString(System.Globalization.CultureInfo.InvariantCulture)), "ancho");
                formData.Add(new StringContent(largo.ToString(System.Globalization.CultureInfo.InvariantCulture)), "largo");

                formData.Add(new StringContent(capacidad.ToString()), "capacidad");
                formData.Add(new StringContent(id_superficie.ToString()), "id_superficie");

                // Archivo (imagen)
                if (!string.IsNullOrEmpty(rutaImagen))
                {
                    var fileStream = System.IO.File.OpenRead(rutaImagen);
                    var streamContent = new StreamContent(fileStream);

                    string extension = System.IO.Path.GetExtension(rutaImagen).ToLower();
                    string mediaType = extension == ".png" ? "image/png" : "image/jpeg";

                    streamContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(mediaType);
                    formData.Add(streamContent, "imagen", System.IO.Path.GetFileName(rutaImagen));
                }

                try
                {
                    response = await _client.PostAsync("tipos_cancha/agregar", formData);
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
                    string mensajeMostrar = $"Error del servidor: {(int)response.StatusCode} {response.StatusCode}";

                    if (!string.IsNullOrWhiteSpace(errorContent))
                    {
                        try
                        {
                            var error = System.Text.Json.Nodes.JsonNode.Parse(errorContent);
                            if (error?["message"] != null)
                            {
                                mensajeMostrar = error["message"].ToString();
                            }
                            else
                            {
                                mensajeMostrar = errorContent;
                            }
                        }
                        catch (System.Text.Json.JsonException)
                        {
                            mensajeMostrar = errorContent;
                        }
                    }

                    MessageBox.Show(mensajeMostrar, "Error al registrar tipo de cancha");
                    return null;
                }
            }
        }
        //
        //
        //
    }
}

