using System.Collections.Generic;
using System.Linq;
using GraphQlDotNet.Data;
using GraphQlDotNet.Interface;
using GraphQlDotNet.Model;

namespace GraphQlDotNet.Services
{
    public class ReservationService : IReservation
    {
        private readonly GraphQlDbContext _dbContext;

        public ReservationService(GraphQlDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Reservation> GetReservations()
        {
            return _dbContext.Reservations.ToList();
        }

        public Reservation AddReservation(Reservation reservation)
        {
            _dbContext.Reservations.Add(reservation);
            _dbContext.SaveChanges();
            return reservation;
        }
    }
}