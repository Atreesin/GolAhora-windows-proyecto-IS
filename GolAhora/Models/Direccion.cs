using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Direccion
    {
        public int Id {  get; set; }
        public string? Calle {  get; set; }
        public string? Numero { get; set; }
        public string? Cp { get; set; }
        public string? Localidad { get; set; }
        public string? Ciudad { get; set; }
        public string? Provincia { get; set; }
        public string? Pais { get; set; }

        //constructors
        public Direccion() { }
        public Direccion(string calle, string numero, string cp, string localidad, string ciudad, string provincia, string pais)
        {
            Calle = calle;
            Numero = numero;
            Cp = cp;
            Localidad = localidad;
            Ciudad = ciudad;
            Provincia = provincia;
            Pais = pais;
        }

    }
}