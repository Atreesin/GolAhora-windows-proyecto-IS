using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Ciudad
    {
        private int id;
        private string name;
        private int idProvincia;

        public Ciudad(int id, string name, int idProvincia)
        {
            this.id = id;
            this.name = name;
            this.idProvincia = idProvincia;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int IdProvincia { get => idProvincia ; set => idProvincia = value; }
    }
}