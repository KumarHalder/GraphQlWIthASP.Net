using System.Collections.Generic;
using GraphQlDotNet.Model;

namespace GraphQlDotNet.Interface
{
    public interface IMenu
    {
        List<Menu> GetMenu();
        Menu AddMenu(Menu menu);

    }
}