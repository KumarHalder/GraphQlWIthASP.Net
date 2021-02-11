using System.Collections.Generic;
using System.Linq;
using GraphQlDotNet.Data;
using GraphQlDotNet.Interface;
using GraphQlDotNet.Model;

namespace GraphQlDotNet.Services
{
    public class MenuService : IMenu
    {
        private readonly GraphQlDbContext _dbContext;

        public MenuService(GraphQlDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Menu> GetMenu()
        {
             return _dbContext.Menus.ToList();
        }

        public Menu AddMenu(Menu menu)
        {
            _dbContext.Menus.Add(menu);
            _dbContext.SaveChanges();
            return menu;
        }
    }
}