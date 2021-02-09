using GraphQL;
using GraphQL.Types;
using GraphQlDotNet.Interface;
using GraphQlDotNet.Model;
using GraphQlDotNet.Types;

namespace GraphQlDotNet.Mutation
{
    public class ProductMutation : ObjectGraphType
    {
        public ProductMutation(IProduct productService)
        {
            Field<ProductType>("createProduct",
                arguments: new QueryArguments(new QueryArgument<ProductInputType>{Name = "product"}),
                resolve: context => productService.AddProduct(context.GetArgument<Product>("product")));
            Field<ProductType>("updateProduct",
                arguments: new QueryArguments(new QueryArgument<IntGraphType>{Name = "id"},new QueryArgument<ProductInputType>{Name = "product"}),
                resolve: context => productService.UpdateProduct(context.GetArgument<int>("id"),context.GetArgument<Product>("product")));
            Field<StringGraphType>("deleteProduct",
                arguments: new QueryArguments(new QueryArgument<IntGraphType>{Name = "id"}),
                resolve: context =>
                {
                    var productId = context.GetArgument<int>("id");
                    productService.DeleteProduct(productId);
                    return productId + "deleted!";

                });
        }
    }
}