using DotnetCore_MVC.Data;
using DotnetCore_MVC.Models;

namespace DotnetCore_MVC.Repository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        private readonly AppDbContext _context;
        public CustomerRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
