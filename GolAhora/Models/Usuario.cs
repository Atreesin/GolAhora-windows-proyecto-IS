using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public string? Username { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Dni { get; set; }
        public string? Nacionalidad { get; set; }
        public string? Genero { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public Direccion? Direccion { get; set; }
        public Club? Club { get; set; }
        public string? User_Level { get; set; }

        //Constructors
        public Usuario() { }
        public Usuario(int id_usuario, string username, string nombre, string apellido, string dni, string nacionalidad, 
            string genero, DateTime fecha_Nacimiento, string email, string telefono, DateTime fecha_Registro, 
            Direccion direccion, Club club, string user_Level)
        {
            Id_Usuario = id_usuario;
            Username = username;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Nacionalidad = nacionalidad;
            Genero = genero;
            Fecha_Nacimiento = fecha_Nacimiento;
            Email = email;
            Telefono = telefono;
            Fecha_Registro = fecha_Registro;
            Direccion = direccion;
            Club = club;
            User_Level = user_Level;
        }

        //methods
        public override string ToString() => $"{Nombre?.ToLower()} {Apellido?.ToLower()} [dni: {Dni}] - rol: {User_Level?.ToLower()} - email: {Email?.ToLower()}";
    }
}
