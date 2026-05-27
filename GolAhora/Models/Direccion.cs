using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Direccion
    {
        private int id;
        private string calle;
        private string numero;
        private int codigoPostal;
        private int idLocalidad;

        public Direccion(int id, string calle, string numero, int idLocalidad)
        {
            this.id = id;
            this.calle = calle;
            this.numero = numero;
            this.idLocalidad = idLocalidad;
        }

        public int Id { get => id; set => id = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Numero { get => numero; set => numero = value; }
        public int CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        public int IdLocalidad { get => idLocalidad; set => idLocalidad = value; }

    }
}