using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int Nacionalidad { get; set; }
        public string? Dni { get; set; }
        public string? Genero { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public int User_Level { get; set; }
        public DateTime Fecha_Registro { get; set; }

        //Constructors
        public Usuario() { }
        public Usuario(int id, string username, string nombre, string apellido, int nacionalidad,
                        string dni, string genero, DateTime fecha_Nacimiento, string telefono, string email, 
                        int user_Level, DateTime fecha_Registro)
        {
            Id = id;
            Username = username;
            Nombre = nombre;
            Apellido = apellido;
            Nacionalidad = nacionalidad;
            Dni = dni;
            Genero = genero;
            Fecha_Nacimiento = fecha_Nacimiento;
            Telefono = telefono;
            Email = email;
            User_Level = user_Level;
            Fecha_Registro = fecha_Registro;
        }
    }
}
