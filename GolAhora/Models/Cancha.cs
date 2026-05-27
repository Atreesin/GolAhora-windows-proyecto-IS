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
        public int Tiempo_Cancelacion { get; set; }
        public decimal Precio_Hora_Reserva { get; set; }
        public string? Tipo_Cancha { get; set; }

        //constructors
        public Cancha() { }
        public Cancha(int id, string nombre, int tiempo_Cancelacion, decimal precio_Hora_Reserva, string tipo_Cancha)
        {
            Id = id;
            Nombre = nombre;
            Tiempo_Cancelacion = tiempo_Cancelacion;
            Precio_Hora_Reserva = precio_Hora_Reserva;
            Tipo_Cancha = tipo_Cancha;
        }

        //methods
    }
}
