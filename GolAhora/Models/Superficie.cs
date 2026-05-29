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
        public int Id_Superficie { get; set; }

        // Mapea el caso donde la API manda "id_superficie" (Lista completa)
        // Lo que recibe aquí, se lo guarda a la variable principal de arriba.
        [JsonPropertyName("id_superficie")]
        public int Id_Superficie_Fallback
        {
            get => Id_Superficie;
            set => Id_Superficie = value;
        }

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

        public override string ToString() => $"{Id_Superficie} - {Tipo_Superficie} - {Descripcion}";
    }
}