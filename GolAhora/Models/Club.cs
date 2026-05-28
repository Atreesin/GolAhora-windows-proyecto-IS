using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Club
    {
        //variables
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Cuit { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public Direccion? Direccion { get; set; }

        //constructor
        public Club() { }
        public Club(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
        public Club(int id, string nombre, string cuit, string telefono, string email, Direccion direccion)
        {
            Id = id;
            Nombre = nombre;
            Cuit = cuit;
            Telefono = telefono;
            Email = email;
            Direccion = direccion;
        }

        //methods
        //
        //
        //
    }
}
