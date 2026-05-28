using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Cancha
    {
        //variables
        public int Id { get; set; }
        public TipoDeCancha? Tipo_Cancha { get; set; }
        public Club? Club { get; set; }
        public string? Imagen_Url { get; set; }

        //constructors
        public Cancha() { }
        public Cancha(int id, TipoDeCancha? tipo_Cancha, Club? club, string imagen_Url)
        {
            Id = id;
            Tipo_Cancha = tipo_Cancha;
            Club = club;
            Imagen_Url = imagen_Url;
        }

        //methods
        public override string ToString() => 
            $"Cancha: {Id}, Tipo: {Tipo_Cancha?.Tipo_Cancha ?? "-"}, Dimensiones: {Tipo_Cancha?.Ancho}x{Tipo_Cancha?.Largo} m (capacidad: {Tipo_Cancha?.Capacidad.ToString() ??  "-"})";
    }
}
