using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Entrenador : Profesional
    {
        //constructors
        public Entrenador() { }
        public Entrenador(int id_usuario, string username, string nombre, string apellido, string dni, string nacionalidad,
            string genero, DateTime fecha_Nacimiento, string email, string telefono, DateTime fecha_Registro,
            Direccion direccion, Club club, string user_Level, Certificacion certificacion)
            : base(id_usuario, username, nombre, apellido, dni, nacionalidad, genero, fecha_Nacimiento, email, telefono,
                  fecha_Registro, direccion, club, user_Level, certificacion)
        { }
    }
}