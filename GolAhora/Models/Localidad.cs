using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Localidad
    {
        private int id;
        private string name;
        private int idCiudad;

        public Localidad(int id, string name, int codigoPostal, int idCiudad)
        {
            this.id = id;
            this.name = name;
            this.idCiudad = idCiudad;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int IdCiudad { get => idCiudad; set => idCiudad = value; }

    }
}