using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Superficie
    {
        //variables
        public int Id { get; set; }
        public string? Tipo_Superficie { get; set; }
        public string? Descripcion { get; set; }

        //constructors
        public Superficie() { }
        public Superficie(int id, string tipo_Superficie, string descripcion)
        {
            Id = id;
            Tipo_Superficie = tipo_Superficie;
            Descripcion = descripcion;
        }
    }
}
