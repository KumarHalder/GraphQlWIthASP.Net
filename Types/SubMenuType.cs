using GraphQL.Types;
using GraphQlDotNet.Model;

namespace GraphQlDotNet.Types
{
    public class SubMenuType : ObjectGraphType<SubMenu>
    {
        public SubMenuType()
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.Description);
            Field(m => m.price);
            Field(m => m.MenuId);
            Field(m => m.ImageUrl);
            
            
        }
    }
}