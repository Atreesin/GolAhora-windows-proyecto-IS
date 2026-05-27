using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Provincia
    {
        private int id;
        private string name;
        private int idPais;

        public Provincia(int id, string name, int idPais)
        {
            this.id = id;
            this.name = name;
            this.idPais = idPais;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int IdPais { get => idPais; set => idPais = value; }
    }
}