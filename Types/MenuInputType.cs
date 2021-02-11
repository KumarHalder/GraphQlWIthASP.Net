using GraphQL.Types;

namespace GraphQlDotNet.Types
{
    public class MenuInputType: InputObjectGraphType
    {
        public MenuInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("imageUrl");
            
        }
    }
}