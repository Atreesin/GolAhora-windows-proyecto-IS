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

        // * * * * * * * * * * OBTENER RESERVAS * * * * * * * * * *

        //devuelve una reserva específica del cliente, null si no existe
        public ReservaCancha? ObtenerReservaPorId(int idReserva)
        {
            foreach (var reserva in ListaDeReservas)
            {
                if (reserva.Id== idReserva)
                {
                    return reserva;
                }
            }
            return null; // No se encontró la reserva con el ID especificado
        }

        //devuelve todas las reservas de una cancha específica
        public List<ReservaCancha> ObtenerReservasPorCancha(int idCancha)
        {
            var reservasCancha = new List<ReservaCancha>();
            foreach (var reserva in ListaDeReservas)
            {
                if (reserva.CanchaID == idCancha)
                {
                    reservasCancha.Add(reserva);
                }
            }
            return reservasCancha; // puede estar vacía
        }

        //devuelve todas las reservas de un día específico
        public List<ReservaCancha> ObtenerReservasPorDia(DateTime dia)
        {
            var reservasDia = new List<ReservaCancha>();
            foreach (var reserva in ListaDeReservas)
            {
                if (reserva.Dia.Date == dia.Date)
                {
                    reservasDia.Add(reserva);
                }
            }
            return reservasDia; // puede estar vacía>
        }

        // * * * * * * * * * * AGREGAR RESERVAS * * * * * * * * * *

        //agregar una reserva a la lista del cliente
        public void AgregarReserva(ReservaCancha reserva)
        {
            if (reserva is null)
            {
                throw new ArgumentNullException(nameof(reserva), "La reserva no puede ser nula.");
            }
            //evitar agregar reservas duplicadas (mismo ID)
            if (ListaDeReservas.Any(r => r.Id== reserva.Id))
            {
                throw new InvalidOperationException($"Ya existe una reserva con el ID {reserva.Id}.");
            }

            //evitar agregar reservas con superposición de horarios (misma cancha, día y hora)
            bool superposicion = ListaDeReservas.Any(r =>
            r.CanchaID == reserva.CanchaID &&
            r.Dia.Date == reserva.Dia.Date &&
            r.HoraInicio == reserva.HoraInicio);
            if (superposicion)
            {
                throw new InvalidOperationException("Ya existe una reserva en esa cancha para ese horario.");
            }
            ListaDeReservas.Add(reserva);
        }

        // * * * * * * * * * * QUITAR RESERVAS * * * * * * * * * *

        //quitar una reserva de la lista del cliente por ID
        public bool QuitarReserva(int idReserva)
        {
            var reserva = ObtenerReservaPorId(idReserva);
            if (reserva == null)
            {
                throw new InvalidOperationException($"No se encontró una reserva con el ID {idReserva}.");
            }
            return ListaDeReservas.Remove(reserva);
        }

        //quitar una reserva pasando el objeto
        public bool QuitarReserva(ReservaCancha reserva)
        {
            if (reserva == null)
            {
                throw new ArgumentNullException(nameof(reserva), "La reserva no puede ser nula.");
            }
            if (!ListaDeReservas.Contains(reserva))
            {
                throw new InvalidOperationException("La reserva no se encuentra en la lista del cliente.");
            }
            return ListaDeReservas.Remove(reserva);
        }

        // * * * * * * * * * * VERIFICAR RESERVAS * * * * * * * * * *

        //indica si el cliente tiene al menos una reserva
        public bool TieneReservas()
        {
            return ListaDeReservas.Count > 0;

        }
        //indica si el cliente tiene reserva en una cancha y día específicos
        public bool TieneReservaEnCanchaYDia(int idCancha, DateTime dia)
        {
            return ListaDeReservas.Any(r =>
            r.CanchaID == idCancha &&
            r.Dia.Date == dia.Date);
        }

        public override string ToString()
        {
            return $"{base.ToString()} | Reservas: {ListaDeReservas.Count}";
        }
    }
}