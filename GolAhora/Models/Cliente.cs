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
        public Cliente(int id, string username, string nombre, string apellido, string dni, string nacionalidad,
            string genero, DateTime fecha_Nacimiento, string email, string telefono, DateTime fecha_Registro,
            Direccion direccion, Club club, string user_Level)
            : base(id, username, nombre, apellido, dni, nacionalidad, genero, fecha_Nacimiento, email, telefono,
                  fecha_Registro, direccion, club, user_Level)
        { }
    }
}