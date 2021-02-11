using GraphQL;
using GraphQL.Types;
using GraphQlDotNet.Interface;
using GraphQlDotNet.Model;
using GraphQlDotNet.Types;

namespace GraphQlDotNet.Mutation
{
    public class SubmenuMutation : ObjectGraphType
    {
        public SubmenuMutation(ISubMenu subMenuService)
        {
            Field<SubMenuType>("createSubmenu",
                arguments: new QueryArguments(new QueryArgument<SubmenuInputType> {Name = "subMenu"}),
                resolve: context => subMenuService.AddSubMenu(context.GetArgument<SubMenu>("subMenu")));
        }
    }
}