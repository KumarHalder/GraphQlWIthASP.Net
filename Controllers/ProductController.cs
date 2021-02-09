using System.Collections;
using System.Collections.Generic;
using GraphQlDotNet.Interface;
using GraphQlDotNet.Model;
using Microsoft.AspNetCore.Mvc;

namespace GraphQlDotNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProduct _productService;

        public ProductController(IProduct product)
        {
            _productService = product;
        }
        
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.GetAllProducts();
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _productService.GetProductById(id);
        }

        [HttpPost]
        public Product AddProduct([FromBody] Product product)
        {
           return _productService.AddProduct(product);
        }
        [HttpPut("{id}")]
        public Product UpdateProduct(int id, [FromBody] Product product )
        {
            return _productService.UpdateProduct(id,product);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productService.DeleteProduct(id);
        }
    }
}