using System;
using System.Collections.Generic;
using System.Text;

namespace GolAhora.Models
{
    public class Descuento
    {
        public int Id_Descuento { get; set; }
        public decimal Porcentaje_Descuento { get; set; }
        public string? Descripcion { get; set; }
        public bool Activo { get; set; }
        public int Id_Club { get; set; } // Relación con Club, si el descuento es específico para un club

        //constructor
        public Descuento()
        {
            Activo = false; // Por defecto, el descuento está desactivado - Según la BD
        }
        public Descuento(int id_descuento, string descripcion, bool activo, decimal porcentaje_Descuento, int id_Club)
        {
            Id_Descuento = id_descuento;
            Descripcion = descripcion;
            Activo = activo;
            Porcentaje_Descuento = porcentaje_Descuento;
            Id_Club = id_Club;
        }
        //valida que el descuento se pueda aplicar
        public bool ValidarDescuento()
        {
            if (!Activo)
            {
                throw new InvalidOperationException("El descuento no está activo.");
            }
            if (Porcentaje_Descuento <= 0 || Porcentaje_Descuento > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(Porcentaje_Descuento), "El porcentaje debe estar entre 0 y 100.");
            }
            if (Id_Club == null)
            {
                throw new InvalidOperationException("El descuento no tiene club asignado.");
            }
            return true; // Si pasa las validaciones, el descuento es válido
        }
        //aplica el descuento a un monto y devuelve el monto final
        public decimal AplicarDescuento(decimal montoOriginal)
        {
            ValidarDescuento(); // Asegura que el descuento es válido antes de aplicarlo
            if (montoOriginal < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(montoOriginal), "El monto no puede ser negativo.");
            }
            decimal montoDescuento = montoOriginal * (decimal)(Porcentaje_Descuento / 100);
            return montoOriginal - montoDescuento; // Devuelve el monto final después de aplicar el descuento
        }
    }
}