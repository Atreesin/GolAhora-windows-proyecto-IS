using System;
using System.Collections.Generic;

namespace GolAhora.Models
{
    public class Clase
    {
        public int Id { get; set; }
        public int Id_Asistencia { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Profesional { get; set; }
        public int Id_Estado_Capacitaciones { get; set; }
        public int Id_Ocupacion { get; set; }
        public int Id_Club { get; set; }
        public int Id_Cancha { get; set; }
        public int Id_Cobro { get; set; }
        public int Capacidad_Maxima { get; set; }
        public string? Horario_Asignado { get; set; }
        public string? Estado { get; set; }
        public List<string> AlumnosIDs { get; set; } = new List<string>();

        public Clase() { }

        public Clase(int id, int id_Asistencia, int id_Usuario, int id_Profesional,
                     int id_Estado_Capacitaciones, int id_Ocupacion, int id_Club, int id_Cancha,
                     int id_Cobro, int capacidad_Maxima, string? horario_Asignado, string? estado,
                     List<string> alumnosIDs)
        {
            Id = id;
            Id_Asistencia = id_Asistencia;
            Id_Usuario = id_Usuario;
            Id_Profesional = id_Profesional;
            Id_Estado_Capacitaciones = id_Estado_Capacitaciones;
            Id_Ocupacion = id_Ocupacion;
            Id_Club = id_Club;
            Id_Cancha = id_Cancha;
            Id_Cobro = id_Cobro;
            Capacidad_Maxima = capacidad_Maxima;
            Horario_Asignado = horario_Asignado;
            Estado = estado;
            AlumnosIDs = alumnosIDs;
        }
    }
}