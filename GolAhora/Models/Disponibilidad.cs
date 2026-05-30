using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Disponibilidad
    {
        public int ID { get; set; }
        public string Fecha { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }

        public Disponibilidad() { }

        public Disponibilidad(int id, string fecha, string horaInicio, string horaFin)
        {
            ID = id;
            Fecha = fecha;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
        }
    }
}
