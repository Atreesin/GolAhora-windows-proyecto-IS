using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Club
    {
        //variables
        public int? Id { get; set; }
        public string? Nombre { get; set; }
        public string? Cuit { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? Email { get; set; }
        public string? Calle { get; set; }
        public string? Numero { get; set; }
        public string? Codigo_Postal { get; set; }
        public string? Localidad { get; set; }
        public string? Ciudad { get; set; }
        public string? Provincia { get; set; }
        public string? Pais { get; set; }

        //constructor
        public Club() { }
        public Club(int id, string nombre, string cuit)
        {
            Id = id;
            Nombre = nombre;
            Cuit = cuit;
        }
        public Club(int id, string nombre, string cuit, string telefono, string direccion, string email, string dirCalle, string dirNumero, string codigoPostal, string localidad, string ciudad, string provincia, string pais)
        {
            Id = id;
            Nombre = nombre;
            Cuit = cuit;
            Telefono = telefono;
            Direccion = direccion;
            Email = email;
            Calle = dirCalle;
            Numero = dirNumero;
            Codigo_Postal = codigoPostal;
            Localidad = localidad;
            Ciudad = ciudad;
            Provincia = provincia;
            Pais = pais;
        }
    }
}
