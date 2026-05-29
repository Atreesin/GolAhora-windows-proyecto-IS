using System;

namespace GolAhora.Models
{
    public class ReservaCancha
    {
        public int Id { get; set; }
        public int CanchaID { get; set; }
        public DateTime Dia { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime Duracion { get; set; }

        public ReservaCancha() { }

        public ReservaCancha(int id, int canchaID, DateTime dia, DateTime horaInicio, DateTime duracion)
        {
            Id= id;
            CanchaID = canchaID;
            Dia = dia;
            HoraInicio = horaInicio;
            Duracion = duracion;
        }
    }
}