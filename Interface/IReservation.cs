using System.Collections.Generic;
using GraphQlDotNet.Model;

namespace GraphQlDotNet.Interface
{
    public interface IReservation
    {
        List<Reservation> GetReservations();
        Reservation AddReservation(Reservation reservation);
    }
}