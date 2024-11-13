using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Semana11LAB.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana11LAB.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly InvoiceContext _context;

        public CustomersController(InvoiceContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        [HttpPost]
        public void Insert(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
                return NotFound();

            // Borrado lógico
            customer.Activo = false;
            _context.Entry(customer).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}