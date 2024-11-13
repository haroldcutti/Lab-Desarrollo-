using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Semana11LAB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana11LAB.Controllers
{
    [Route("api / [controller] / [action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly InvoiceContext _context;

        public ProductsController(InvoiceContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        [HttpPost]
        public void Insert(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
                return NotFound();

            product.Activo = false; 
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}