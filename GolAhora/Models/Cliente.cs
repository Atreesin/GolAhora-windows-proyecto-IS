using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Cliente : Usuario
    {
        //variables
        public List<ReservaCancha> ListaDeReservas { get; set; } = new();

        //constructors
        public Cliente() { }
        public Cliente(int id, string username, string nombre, string apellido, string nacionalidad, string dni, 
            string genero, DateTime fecha_Nacimiento, string telefono, string email, string password, 
            string user_Level, DateTime fecha_Registro, string club)
            : base(id, username, nombre, apellido, nacionalidad, dni, genero, fecha_Nacimiento, telefono, 
                  email, user_Level, fecha_Registro, club)
        {
        }
    }
}