using GraphQL.Types;

namespace GraphQlDotNet.Types
{
    public class SubmenuInputType: InputObjectGraphType
    {
        public SubmenuInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("description");
            Field<FloatGraphType>("price");
            Field<StringGraphType>("imageUrl");
            Field<IntGraphType>("menuId");
            
        }
    }
}