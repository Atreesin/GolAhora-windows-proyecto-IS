using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Torneo : Competencia
    {
        //contructor
        public Torneo() { }
        public Torneo(int id, string nombre, Profesional tutor, DateTime fecha_Inicio, DateTime fecha_Fin)
            : base(id, nombre, tutor,fecha_Inicio, fecha_Fin) { }

        //cuadro: cada ronda tiene una lista de partidos, cada partido tiene dos equipos y un resultado
        private List<List<(string EquipoA, string EquipoB)>> cuadro = new();
        private int rondaActual = 0;

        //genera cuadro inicial
        public void GenerarCuadro(List<string> equipos)
        {
            if (equipos.Count < 2)
            {
                throw new ArgumentException("Se necesitan al menos 2 equipos.");
            }
            cuadro.Clear();
            rondaActual = 0;

            //arma enfrentamientos de la primera ronda: 1vs2, 3vs4, etc.
            var ronda = new List<(string, string)>();
            for (int i = 0; i < equipos.Count - 1; i += 2)
            {
                ronda.Add((equipos[i], equipos[i + 1]));
            }
            cuadro.Add(ronda);
        }
        //avanza siguiente ronda
        public void AvanzarRonda(List<string> ganadores)
        {
            if (ganadores.Count < 2)
            {
                throw new ArgumentException("Se necesitan al menos 2 ganadores para continuar.");
            }
            rondaActual++;
            var nuevaRonda = new List<(string, string)>();
            for (int i = 0; i < ganadores.Count - 1; i += 2)
            {
                nuevaRonda.Add((ganadores[i], ganadores[i + 1]));
            }
            cuadro.Add(nuevaRonda);
        }
        //devuelve los enfrentamientos de la ronda actual
        public List<(string EquipoA, string EquipoB)> ObtenerEnfrentamientosRondaActual()
        {
            if (cuadro.Count == 0)
            {
                throw new InvalidOperationException("El cuadro no fue generado de momento.");
            }
            return cuadro[rondaActual];
        }
    }
}