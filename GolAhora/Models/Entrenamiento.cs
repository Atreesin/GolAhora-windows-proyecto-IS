using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Text;

namespace GolAhora.Models
{
    public class Entrenamiento
    {
        public int Id_Entrenamiento { get; set; }
        public int Capacidad_Max { get; set; }
        public int Id_Profesional { get; set; }
        public int Id_Estado_Capacitacion { get; set; }
        public int Id_Ocupacion { get; set; }
        public int Id_Club { get; set; }
        public int Id_Cancha { get; set; }
        public int Id_Cobro { get; set; }
        public List<int> AlumnosIds { get; set; }
        public string? Horario_Asignado { get; set; }

        public Entrenamiento() { }

        public Entrenamiento(int Id_Entrenamiento, int Capacidad_Max, int Id_Profesional, int Id_Estado_Capacitacion,
                             int Id_Ocupacion, int Id_Club, int Id_Cancha, int Id_Cobro, string Horario_Asignado)
        {
            this.Id_Entrenamiento = Id_Entrenamiento;
            this.Capacidad_Max = Capacidad_Max;
            this.Id_Profesional = Id_Profesional;
            this.Id_Estado_Capacitacion = Id_Estado_Capacitacion;
            this.Id_Ocupacion = Id_Ocupacion;
            this.Id_Club = Id_Club;
            this.Id_Cancha = Id_Cancha;
            this.Id_Cobro = Id_Cobro;
            this.Horario_Asignado = Horario_Asignado;
            this.AlumnosIds = new List<int>();
        }

    }
}