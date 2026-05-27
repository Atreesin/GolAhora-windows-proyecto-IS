using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public abstract class Competencia
    {
        //variables
        public int? Id { get; set; }
        public string? Nombre { get; set; }
        public Profesional? Tutor { get; set; }
        public string Estado { get; set; } = "Programada"; // Programada, En Curso, Finalizada
        public DateTime? Fecha_Inicio { get; set; }
        public DateTime? Fecha_Fin { get; set; }
        public List<string> Equipos { get; protected set; } = new();

        //constructors
        public Competencia() { }
        public Competencia(int id, string nombre, Profesional tutor, DateTime fecha_Inicio, DateTime fecha_Fin)
        {
            Id = id;
            Nombre = nombre;
            Tutor = tutor;
            Fecha_Inicio = fecha_Inicio;
            Fecha_Fin = fecha_Fin;
        }
    }
}