using GraphQlDotNet.Model;
using Microsoft.EntityFrameworkCore;

namespace GraphQlDotNet.Data
{
    public class GraphQlDbContext : DbContext
    {
        public GraphQlDbContext(DbContextOptions<GraphQlDbContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}