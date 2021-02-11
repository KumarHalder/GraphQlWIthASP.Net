using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json.Serialization;
using GraphQlDotNet.Data;
using GraphQlDotNet.Interface;
using GraphQlDotNet.Model;
using Newtonsoft.Json;

namespace GraphQlDotNet.Services
{
    public class SubMenuService : ISubMenu
    {
        private readonly GraphQlDbContext _dbContext;

        public SubMenuService(GraphQlDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<SubMenu> GetSubMenus()
        {
            return _dbContext.SubMenus.ToList();
        }

        public SubMenu GetSubMenuByMenuId(int id)
        {
            var item = _dbContext.SubMenus.FirstOrDefault(x=>x.MenuId == id);
            return item;
           
        }

        public SubMenu AddSubMenu(SubMenu subMenu)
        {
            _dbContext.SubMenus.Add(subMenu);
            _dbContext.SaveChanges();
            return subMenu;
        }
    }
}