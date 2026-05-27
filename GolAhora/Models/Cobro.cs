using System;

namespace GolAhora.Models
{
    public class Cobro
    {
        public int IdCobro { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string? Estado { get; set; }
        public string? MetodoPago { get; set; }

        public Cobro() { }

        public Cobro(int idCobro, double monto, DateTime fecha, string? estado, string? metodoPago)
        {
            IdCobro = idCobro;
            Monto = monto;
            Fecha = fecha;
            Estado = estado;
            MetodoPago = metodoPago;
        }
    }
}