using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Asistencia
    {
        private int _id;
        private string _estado;

        // CONSTRUCTOR
        public Asistencia(int id, string estado)
        {
            this._id = id;
            this._estado = estado;
        }

        // PROPIEDADES
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
    }
}
