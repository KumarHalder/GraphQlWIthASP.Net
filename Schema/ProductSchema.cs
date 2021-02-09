using GraphQlDotNet.Mutation;
using GraphQlDotNet.Query;
using GraphQlDotNet.Types;

namespace GraphQlDotNet.Schema
{
    public class ProductSchema : GraphQL.Types.Schema
    {
        public ProductSchema(ProductQuery productQuery, ProductMutation productMutation)
        {
            Query = productQuery;
            Mutation = productMutation;
        }
        
    }
}