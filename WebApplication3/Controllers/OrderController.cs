using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly DbOrderContext _dbContext;

        public OrderController(DbOrderContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DbOrder>>> GetOrders()
        {
            if (_dbContext.Order == null)
            {
                return NotFound();
            }
            return await _dbContext.Order.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DbOrder>> GetOrderById(int id)
        {
            if (_dbContext.Order == null)
            {
                return NotFound();
            }

            var brand = await _dbContext.Order.FindAsync(id);

            if (brand == null)
            {
                return NotFound();
            }

            return brand;
        }

        [HttpPost]
        public async Task<ActionResult<DbOrder>> PostOrder(DbOrder order)
        {
            _dbContext.Order.Add(order);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOrders), new {id = order.id}, order);
        }
    }
}
