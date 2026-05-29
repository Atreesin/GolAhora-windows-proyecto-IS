using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GolAhora.Models
{
    public class Reporte
    {
        public int Id { get; set; }
        public byte Tipo_Reporte { get; set; } // Valor entre 0 y 3.
        public DateTime Fecha { get; set; }
        public string? Detalle { get; set; }
        public int Id_Club { get; set; } // Relación con Club, si el reporte es específico para un club

        //constructor
        public Reporte()
        {
            Fecha = DateTime.Now; // Por defecto, la fecha se establece al momento de crear el reporte
        }
        public Reporte(int id, byte tipo_reporte, string detalle, int id_club)
        {
            Id = id;
            Tipo_Reporte = tipo_reporte;
            Detalle = detalle;
            Id_Club = id_club;
            Fecha = DateTime.Now; // Establece la fecha al momento de crear el reporte
        }
        //valida que el reporte siga las reglas de BD antes de enviar a la API
        public bool ValidarReporte()
        {
            if (Tipo_Reporte > 3)
            {
                throw new ArgumentOutOfRangeException(nameof(Tipo_Reporte), "El tipo de reporte debe ser un valor entre 0 y 3.");
            }
            if (string.IsNullOrWhiteSpace(Detalle))
            {
                throw new InvalidOperationException("El detalle del reporte no puede estar vacío.");
            }
            if (Id_Club == null)
            {
                throw new InvalidOperationException("El reporte no tiene club asignado.");
            }
            return true; // Si pasa las validaciones, el reporte es válido
        }
    }
}