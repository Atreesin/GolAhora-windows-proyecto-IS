using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization; 

namespace GolAhora.Models
{
    public class Superficie
    {
        // 1. Mapea el caso donde la API manda "id" (Consulta individual)
        [JsonPropertyName("id")]
        public int Id{ get; set; }

        [JsonPropertyName("tipo_superficie")]
        public string? Tipo_Superficie { get; set; }

        [JsonPropertyName("tipo")]
        public string? TipoAux
        {
            set => Tipo_Superficie = value;
            get => Tipo_Superficie;
        }

        [JsonPropertyName("descripcion_superficie")]
        public string? Descripcion { get; set; }

        public Superficie() { }

        public Superficie(int id, string tipo_Superficie, string descripcion)
        {
            Id = id;
            Tipo_Superficie = tipo_Superficie;
            Descripcion = descripcion;
        }

        public override string ToString() => $"{Id} - {Tipo_Superficie} - {Descripcion}";
    }
}