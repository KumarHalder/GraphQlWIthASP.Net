using GraphQL.Types;
using GraphQlDotNet.Interface;
using GraphQlDotNet.Model;

namespace GraphQlDotNet.Types
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType(ISubMenu subMenuService)
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.ImageUrl);
            Field<SubMenuType>("submenu", resolve: context => subMenuService.GetSubMenuByMenuId(context.Source.Id));

            
            
        }
    }
}