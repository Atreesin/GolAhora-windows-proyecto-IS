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
        public string? Nacionalidad { get; set; }
        public string? Dni { get; set; }
        public string? Genero { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public string? User_Level { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public string? Club { get; set; }

        //Constructors
        public Usuario() { }
        public Usuario(int id, string username, string nombre, string apellido, string nacionalidad,
                        string dni, string genero, DateTime fecha_Nacimiento, string telefono, string email, 
                        string user_Level, DateTime fecha_Registro, string club)
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
            Club = club;
        }

        //methods
        public override string ToString() => $"{Nombre?.ToLower()} {Apellido?.ToLower()} [dni: {Dni}] - rol: {User_Level?.ToLower()} - email: {Email?.ToLower()}";
    }
}
