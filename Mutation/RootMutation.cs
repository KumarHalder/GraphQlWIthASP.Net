using GraphQL.Types;
using GraphQlDotNet.Mutation;

namespace GraphQlDotNet.Query
{
    public class RootMutation : ObjectGraphType
    {
        public RootMutation()
        {
            Field<MenuMutation>("menuMutation", resolve: context => new { });
            Field<SubmenuMutation>("submenuMutation", resolve: context => new { });
            Field<ReservationMutation>("reservationMutation", resolve: context => new { });
        }
    }
}