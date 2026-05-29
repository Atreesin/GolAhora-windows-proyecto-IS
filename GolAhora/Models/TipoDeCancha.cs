using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class TipoDeCancha
    {
        //variables
        public int Id { get; set; }
        public string? Tipo { get; set; }
        public int Duracion_Min { get; set; }
        public int Duracion_Max { get; set; }
        public string? Ancho { get; set; }
        public string? Largo { get; set; }
        public int Capacidad { get; set; }
        public Superficie? Superficie { get; set; }
        public string? Imagen_Url { get; set; }


        //constructors
        public TipoDeCancha() { }
        public TipoDeCancha(int id, string tipo, int duracion_Min, int duracion_Max, string ancho, string largo, int capacidad, Superficie superficie, string imagen_Url)
        {
            Id = id;
            Tipo = tipo;
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
            $"Tipo: {Tipo}, Dimensiones: {Ancho}x{Largo} m, Capacidad: {Capacidad}, Superficie: {Superficie}";
    }
}
