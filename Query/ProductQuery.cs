using System.Collections.Generic;
using GraphQL;
using GraphQL.Types;
using GraphQlDotNet.Interface;
using GraphQlDotNet.Types;

namespace GraphQlDotNet.Query
{
    public class ProductQuery : ObjectGraphType
    {
        public ProductQuery(IProduct productService)
        {
            Field<ListGraphType<ProductType>>("products",
                resolve: context => productService.GetAllProducts());
            Field<ProductType>("product",
                arguments: new QueryArguments(new QueryArgument<IntGraphType>{Name = "id"}),
                resolve: context => productService.GetProductById(context.GetArgument<int>("id")));

        }
    }
}