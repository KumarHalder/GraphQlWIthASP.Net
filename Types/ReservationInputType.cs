using GraphQL.Types;

namespace GraphQlDotNet.Types
{
    public class ReservationInputType: InputObjectGraphType
    {
        public ReservationInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("phone");
            Field<FloatGraphType>("email");
            Field<StringGraphType>("date");
            Field<StringGraphType>("time");
            Field<IntGraphType>("totalPeople");
            
        }
    }
}