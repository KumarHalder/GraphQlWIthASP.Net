using System.Collections.Generic;
using GraphQlDotNet.Model;

namespace GraphQlDotNet.Interface
{
    public interface ISubMenu
    {
        List<SubMenu> GetSubMenus();
        SubMenu GetSubMenuByMenuId(int menuId);
        SubMenu AddSubMenu(SubMenu subMenu);
    }
}