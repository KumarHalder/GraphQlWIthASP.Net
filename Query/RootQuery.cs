using GraphQL.Types;

namespace GraphQlDotNet.Query
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery()
        {
            Field<MenuQuery>("MenuQuery", resolve: context => new { });
            Field<SubMenuQuery>("SubMenuQuery", resolve: context => new { });
            Field<ReservationQuery>("ReservationQuery", resolve: context => new { });
        }
    }
}