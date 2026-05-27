using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public abstract class Profesional : Usuario
    {
        //variables
        public Certificacion? CertificacionObjeto { get; set; }

        //constructors
        public Profesional() { }
        public Profesional(int id, string username, string nombre, string apellido, string email)
        {
            Id = id;
            Username = username;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
        }
        public Profesional(int id, string username, string nombre, string apellido, string nacionalidad,
                        string dni, string genero, DateTime fecha_Nacimiento, string telefono, string email,
                        string user_Level, DateTime fecha_Registro, string club, Certificacion certificacion)
            : base(id, username, nombre, apellido, nacionalidad, dni, genero, fecha_Nacimiento, telefono, email, user_Level, fecha_Registro, club)
        {
            CertificacionObjeto = certificacion;
        }
    }
}
