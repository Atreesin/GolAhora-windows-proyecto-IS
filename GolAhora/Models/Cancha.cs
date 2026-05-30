using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Cancha
    {
        //variables
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Tipo_Cancha { get; set; }
        public int Tiempo_Cancelacion { get; set; }
        public string? Precio_Hora_Reserva { get; set; }
        public string? Ancho { get; set; }
        public string? Largo { get; set; }
        public int Capacidad { get; set; }
        public Superficie? Superficie { get; set; }
        public Club? Club { get; set; }

        //constructors
        public Cancha() { }
        public Cancha(int id, string? nombre, string? tipo_Cancha, int tiempo_cancelacion, string? precio_hora_reserva, string? ancho, string? largo, int capacidad, Superficie? superficie, Club? club)
        {
            Id = id;
            Nombre = nombre;
            Tipo_Cancha = tipo_Cancha;
            Tiempo_Cancelacion = tiempo_cancelacion;
            Precio_Hora_Reserva = precio_hora_reserva;
            Ancho = ancho;
            Largo = largo;
            Capacidad = capacidad;
            Superficie = superficie;
            Club = club;
        }

        public override string ToString() => 
            $"{Nombre}, Tipo: {Tipo_Cancha}, Dimensiones: {Ancho}x{Largo} m (capacidad: {Capacidad})";
    }
}
