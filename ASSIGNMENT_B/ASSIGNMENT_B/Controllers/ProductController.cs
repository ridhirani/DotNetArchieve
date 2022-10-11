using ASSIGNMENT_B.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASSIGNMENT_B.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        List<Product> prod = new List<Product>()
        {
            new Product() { ProductID = 1, Name = "Laptop", Quantity = 245, Price = 54000 },
            new Product() { ProductID = 2, Name = "Tablet", Quantity = 688, Price = 7770 },
            new Product() { ProductID = 3, Name = "Speaker", Quantity = 225, Price = 4000 },
            new Product() { ProductID = 4, Name = "Mouse", Quantity = 198, Price = 5000 },
            new Product() { ProductID = 5, Name = "Keyboard", Quantity = 217, Price = 5400 },
        };
        [HttpGet]
        public IActionResult GetProducts()
        {
            if (prod.Count == 0)
            {
                return NotFound("No List of Products Found");

            }
            return Ok(prod);
        }

        [HttpGet("GetProducts")]
        public IActionResult GetProducts(int id) 
        {
            var product = prod.SingleOrDefault(x => x.ProductID == id);
            if (product == null)
            {
                return NotFound(" Products Not Found");

            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            prod.Add(product);
            if (prod.Count == 0)
            {
                return NotFound(" No List Found");

            }
            return Ok(prod);
        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var product = prod.SingleOrDefault(x => x.ProductID == id);
            if (product == null)
            {
                return NotFound(" Product Not Found");

            }
            prod.Remove(product);
            if (prod.Count == 0)
            {
                return NotFound(" No List Found");

            }
            return Ok(prod);
        }


    }
}
