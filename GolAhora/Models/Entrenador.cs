using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Entrenador : Profesional
    {
        //constructors
        public Entrenador() { }
        public Entrenador(int id, string username, string nombre, string apellido, int nacionalidad,
                        string dni, string genero, DateTime fecha_Nacimiento, string telefono, string email,
                        int user_Level, DateTime fecha_Registro, Certificacion certificacion)
            : base(id, username, nombre, apellido, nacionalidad, dni, genero, fecha_Nacimiento,
                  telefono, email, user_Level, fecha_Registro, certificacion)
        {
            CertificacionObjeto = certificacion;
        }
    }
}
