using GraphQL.Types;
using GraphQlDotNet.Interface;
using GraphQlDotNet.Types;

namespace GraphQlDotNet.Query
{
    public class MenuQuery : ObjectGraphType
    {
        public MenuQuery(IMenu menuService)
        {
            Field<ListGraphType<MenuType>>("Menu", resolve: context => menuService.GetMenu());
        }
    }
}