using GraphQL.Types;
using GraphQlDotNet.Interface;
using GraphQlDotNet.Types;

namespace GraphQlDotNet.Query
{
    public class ReservationQuery : ObjectGraphType
    {
        public ReservationQuery(IReservation reservationService)
        {
            Field<ListGraphType<ReservationType>>("Reservation",
                resolve: context => reservationService.GetReservations());
        }
    }
}