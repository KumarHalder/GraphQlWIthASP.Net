using GraphQL.Types;
using GraphQlDotNet.Model;

namespace GraphQlDotNet.Types
{
    public  class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(p => p.Id);
            Field(p => p.Name);
            Field(p => p.Price);

        }
    }
}