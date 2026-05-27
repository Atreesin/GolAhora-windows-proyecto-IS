using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class TipoDeCancha
    {
        //variables
        public int Id { get; set; }
        public string? Tipo_Cancha { get; set; }
        public int Duracion_Min { get; set; }
        public int Duracion_Max { get; set; }
        public float Ancho { get; set; }
        public float Largo { get; set; }
        public int Capacidad { get; set; }
        public string? Superficie { get; set; }
        public string? Descripcion_Superficie { get; set; }
        public string? Imagen_Url { get; set; }


        //constructors
        public TipoDeCancha() { }
        
        public TipoDeCancha(int id, string tipo_Cancha, int duracion_Min, int duracion_Max, float ancho, float largo, int capacidad, string superficie, string descripcion_Superficie, string imagen_Url)
        {
            Id = id;
            Tipo_Cancha = tipo_Cancha;
            Duracion_Min = duracion_Min;
            Duracion_Max = duracion_Max;
            Ancho = ancho;
            Largo = largo;
            Capacidad = capacidad;
            Superficie = superficie;
            Descripcion_Superficie = descripcion_Superficie;
            Imagen_Url = imagen_Url;
        }

        //methods


    }
}
