using GraphQL;
using GraphQL.Types;
using GraphQlDotNet.Interface;
using GraphQlDotNet.Model;
using GraphQlDotNet.Types;

namespace GraphQlDotNet.Mutation
{
    public class MenuMutation : ObjectGraphType
    {
        public MenuMutation(IMenu menuService)
        {
            Field<MenuType>("createMenu",
                arguments: new QueryArguments(new QueryArgument<MenuInputType> {Name = "menu"}),
                resolve: context => menuService.AddMenu(context.GetArgument<Menu>("menu")));
        }
    }
}