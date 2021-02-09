using System.Collections.Generic;
using System.Linq;
using GraphQlDotNet.Data;
using GraphQlDotNet.Interface;
using GraphQlDotNet.Model;

namespace GraphQlDotNet.Services
{
    public class ProductService : IProduct
    {
        private GraphQlDbContext _dbContext;

        public ProductService(GraphQlDbContext graphQlDbContext)
        {
            _dbContext = graphQlDbContext;
        }
        public List<Product> GetAllProducts()
        {
            return _dbContext.Products.ToList();
        }

        public Product AddProduct(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return product;
        }

        public Product UpdateProduct(int id, Product product)
        {
            var productObj = _dbContext.Products.Find(id);
            productObj.Name = product.Name;
            productObj.Price = product.Price;
            _dbContext.SaveChanges();
            return product;
        }

        public void DeleteProduct(int id)
        {
            var product = _dbContext.Products.Find(id);
            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();
        }

        public Product GetProductById(int id)
        {
            return _dbContext.Products.Find(id);
        }
    }
}