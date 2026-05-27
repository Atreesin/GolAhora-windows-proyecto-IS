using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Administrador :  Usuario
    {
        
        //constructors
        public Administrador() { }
        public Administrador(int id, string username, string nombre, string apellido, string nacionalidad, 
            string dni, string genero, DateTime fecha_Nacimiento, string telefono, string email, 
            string user_Level, DateTime fecha_Registro, string club) 
            : base(id, username, nombre, apellido, nacionalidad, dni, genero, fecha_Nacimiento, telefono, 
                  email, user_Level, fecha_Registro, club)
        {
        }

       
        
    }
}
