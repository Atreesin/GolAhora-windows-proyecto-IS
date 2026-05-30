using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace GolAhora.Models
{
    public class TipoDeCancha
    {
        //variables
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("tipo_cancha")]
        public string? Tipo_Cancha { get; set; }
        public int Duracion_Min { get; set; }
        public int Duracion_Max { get; set; }
        public string? Ancho { get; set; }
        public string? Largo { get; set; }
        public int Capacidad { get; set; }
        public Superficie? Superficie { get; set; }
        public string? Imagen_Url { get; set; }


        //constructors
        public TipoDeCancha() { }
        public TipoDeCancha(int id, string tipo_cancha, int duracion_Min, int duracion_Max, string ancho, string largo, int capacidad, Superficie superficie, string imagen_Url)
        {
            Id = id;
            Tipo_Cancha = tipo_cancha;
            Duracion_Min = duracion_Min;
            Duracion_Max = duracion_Max;
            Ancho = ancho;
            Largo = largo;
            Capacidad = capacidad;
            Superficie = superficie;
            Imagen_Url = imagen_Url;
        }

        //methods

        public override string ToString() =>
            $"Tipo: {Tipo_Cancha}, Dimensiones: {Ancho}x{Largo} m, Capacidad: {Capacidad}, Superficie: {Superficie}";
    }
}
