using GraphQL;
using GraphQL.Types;
using GraphQlDotNet.Interface;
using GraphQlDotNet.Model;
using GraphQlDotNet.Types;

namespace GraphQlDotNet.Mutation
{
    public class ReservationMutation : ObjectGraphType
    {
        public ReservationMutation(IReservation reservationService)
        {
            Field<ReservationType>("createReservation",
                arguments: new QueryArguments(new QueryArgument<ReservationInputType> {Name = "reservation"}),
                resolve: context => reservationService.AddReservation(context.GetArgument<Reservation>("reservation")));
        }
    }
}