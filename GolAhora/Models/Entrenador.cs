using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Entrenador : Profesional
    {
        private List<Entrenamiento> entrenamientos;
        //constructors
        public Entrenador() { }
        public Entrenador(int id_usuario, string username, string nombre, string apellido, string dni, string nacionalidad,
            string genero, DateTime fecha_Nacimiento, string email, string telefono, DateTime fecha_Registro,
            Direccion direccion, Club club, string user_Level, Certificacion certificacion)
            : base(id_usuario, username, nombre, apellido, dni, nacionalidad, genero, fecha_Nacimiento, email, telefono,
                  fecha_Registro, direccion, club, user_Level, certificacion)
        {
            this.entrenamientos = new List<Entrenamiento>();
        }

        public List<Entrenamiento> getEntrenamientos() { return this.entrenamientos; }

        //Agrega un entrenamiento a la lista de entrenamientos del entrenador
        public void agregarEntrenamiento(Entrenamiento entrenamiento)
        {
            this.entrenamientos.Add(entrenamiento);
        }

        //Busca un entrenamiento por su id, si no lo encuentra devuelve null
        public Entrenamiento obtenerEntrenamientoPorId(int id)
        {
            Entrenamiento aux = null;
            foreach (Entrenamiento entrenamiento in this.entrenamientos)
            {
                if (entrenamiento.Id== id)
                {
                    aux = entrenamiento;
                }
            }
            return aux;
        }

        //Elimina un entrenamiento de la lista de entrenamientos del entrenador
        public void eliminarEntrenamiento(Entrenamiento entrenamiento)
        {
            this.entrenamientos.Remove(entrenamiento);
        }

    }
}
