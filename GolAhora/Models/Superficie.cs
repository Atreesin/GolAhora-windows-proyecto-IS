using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization; 

namespace GolAhora.Models
{
    public class Superficie
    {
        [JsonPropertyName("id_superficie")]
        public int Id_Superficie { get; set; }

        [JsonPropertyName("tipo_superficie")]
        public string? Tipo_Superficie { get; set; }

        [JsonPropertyName("descripcion_superficie")]
        public string? Descripcion { get; set; }

        public Superficie() { }

        public Superficie(int id_superficie, string tipo_Superficie, string descripcion)
        {
            Id_Superficie = id_superficie;
            Tipo_Superficie = tipo_Superficie;
            Descripcion = descripcion;
        }
    }
}