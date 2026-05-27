using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Certificacion
    {
        //variables
        public int Id {  get; set; }
        public bool Tipo_Certificacion { get; set; } // true: nacional, false: internacional (o la lógica que uses)
        public string? Matricula { get; set; }
        public DateTime Fecha_Caducidad { get; set; }
        public string? Link_Archivo { get; set; }

        //constructors
        public Certificacion() { }
        public Certificacion(int id, bool tipo_Certificacion, string? matricula, DateTime fecha_Caducidad, string? link_Archivo)
        {
            Id = id;
            Tipo_Certificacion = tipo_Certificacion;
            Matricula = matricula;
            Fecha_Caducidad = fecha_Caducidad;
            Link_Archivo = link_Archivo;
        }
    }
}

