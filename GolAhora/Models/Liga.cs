using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Liga : Competencia
    {
        //variables
        public int Puntos_Victoria { get; set; }
        public int Puntos_Empate { get; set; }

        //constructors
        public Liga() { }
        public Liga(int id, string nombre, Profesional tutor, DateTime fecha_Inicio, DateTime fecha_Fin)
            : base(id, nombre, tutor, fecha_Inicio, fecha_Fin)
        {
            Puntos_Victoria = 3; // Valor predeterminado para puntos por victoria
            Puntos_Empate = 1;   // Valor predeterminado para puntos por empate
        }

        public Liga(int id, string nombre, Profesional tutor, DateTime fecha_Inicio, DateTime fecha_Fin, int puntos_Victoria, int puntos_Empate)
            : base(id, nombre, tutor, fecha_Inicio, fecha_Fin)
        {
            Puntos_Victoria = puntos_Victoria;
            Puntos_Empate = puntos_Empate;
        }

        //tabla de posiciones: clave = nombre equipo, valor = puntos acumulados
        private Dictionary<string, int> tablaPosiciones = new Dictionary<string, int>();

        //calcular y acumular puntos de un equipo segun resultado
        public void CalcularPuntos(string equipo, string resultado)
        {
            if (!tablaPosiciones.ContainsKey(equipo))
            {
                tablaPosiciones[equipo] = 0; // Inicializar puntos para el equipo si no existe
            }
            switch (resultado.ToLower())
            {
                case "victoria":
                    tablaPosiciones[equipo] += Puntos_Victoria; // Sumar puntos por victoria
                    break;
                case "empate":
                    tablaPosiciones[equipo] += Puntos_Empate; // Sumar puntos por empate
                    break;
                case "derrota":
                    // No suma puntos
                    break;
                default:
                    throw new ArgumentException($"Resultado no válido: {resultado}");
            }
        }
        //tabla ordenada de mayor a menor
        public Dictionary<string, int> GenerarTablaPosiciones()
        {
            return tablaPosiciones.OrderByDescending(kv => kv.Value).ToDictionary(kv => kv.Key, kv => kv.Value);
        }
    }
}