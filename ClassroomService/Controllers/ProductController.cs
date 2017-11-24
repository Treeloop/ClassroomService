using System;
using System.Collections.Generic;
using System.Linq;
using ClassroomService.Data;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomService.Controllers
{
    [Route("api")]
    public class ProductController : Controller
    {
        [HttpGet("reset")]
        public void Reset()
        {
            Repository.Reset();
        }

        // GET products
        [HttpGet("products")]
        public IEnumerable<Product> Get()
        {
            return Repository.Products;
        }

        // GET product/5
        [HttpGet("product/{id}")]
        public IActionResult Get(int id)
        {
            var product = Repository.Products.SingleOrDefault(p => p.Id == id);
            if (product == null) return NotFound();

            return new ObjectResult(product);
        }

        // POST product
        [HttpPost("product")]
        public IActionResult Post([FromBody]Product product)
        {
            if (product == null)
            {
                return BadRequest();
            }
            product.Id = Repository.NextProductID;
            Repository.Products.Add(product);

            return CreatedAtAction("Get", new { id = product.Id }, product);
        }

        // PUT product/5
        [HttpPut("product/{id}")]
        public IActionResult Put(int id, [FromBody]Product product)
        {
            if (product == null || product.Id != id)
            {
                return BadRequest();
            }
            var existing = Repository.Products.SingleOrDefault(p => p.Id == id);
            if (existing == null)
            {
                return NotFound();
            }
            Repository.Products.Remove(existing);
            Repository.Products.Add(product);

            return new NoContentResult();
        }

        // DELETE product/5
        [HttpDelete("product/{id}")]
        public IActionResult Delete(int id)
        {
            var product = Repository.Products.SingleOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            Repository.Products.Remove(product);
            return new NoContentResult();
        }
    }
}
