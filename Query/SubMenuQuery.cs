using GraphQL;
using GraphQL.Types;
using GraphQlDotNet.Interface;
using GraphQlDotNet.Types;

namespace GraphQlDotNet.Query
{
    public class SubMenuQuery : ObjectGraphType
    {
        public SubMenuQuery(ISubMenu subMenuService)
        {
            Field<ListGraphType<SubMenuType>>("submenu", resolve: context => subMenuService.GetSubMenus());
            Field<SubMenuType>("subMenuById",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> {Name = "id"}),
                resolve: context => subMenuService.GetSubMenuByMenuId(context.GetArgument<int>("id")));
        }
    }
}