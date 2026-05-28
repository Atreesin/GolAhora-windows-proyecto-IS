using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public abstract class Profesional : Usuario
    {
        //variables
        public Certificacion? Certificacion { get; set; }

        //constructors
        public Profesional() { }
        public Profesional(int id_usuario, string username, string nombre, string apellido, string email)
        {
            Id_Usuario = id_usuario;
            Username = username;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
        }
        public Profesional(int id_usuario, string username, string nombre, string apellido, string dni, string nacionalidad,
            string genero, DateTime fecha_Nacimiento, string email, string telefono, DateTime fecha_Registro,
            Direccion direccion, Club club, string user_Level, Certificacion certificacion)
            : base(id_usuario, username, nombre, apellido, dni, nacionalidad, genero, fecha_Nacimiento, email, telefono,
                  fecha_Registro, direccion, club, user_Level)
        {
            Certificacion = certificacion;
        }
    }
}
