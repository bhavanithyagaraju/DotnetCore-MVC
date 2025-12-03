using DotnetCore_MVC.Data;
using DotnetCore_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetCore_MVC.Repository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        private readonly AppDbContext _context;
        public OrderRepository(AppDbContext context) : base(context) {
            _context = context;
        }

        public async Task<IEnumerable<Order>> GetOrdersWithCustomers()
        {
            return await _context.Orders.Include(order => order.Customer).ToListAsync();
        }
    }
}
