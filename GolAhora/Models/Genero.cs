using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Genero
    {
        private int id;
        private string name;

        public Genero(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}