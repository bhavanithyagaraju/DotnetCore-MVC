using DotnetCore_MVC.Data;
using DotnetCore_MVC.Repository;

namespace DotnetCore_MVC.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;


        public ICustomerRepository Customers { get; private set; }
        public IOrderRepository Orders { get; private set; }

        public UnitOfWork(AppDbContext context, ICustomerRepository customers, IOrderRepository orders)
        {
            _context = context;
            Customers = customers;
            Orders = orders;
        }

        public async Task<int> Save() => await _context.SaveChangesAsync();
        public void Dispose() => _context.Dispose();
    }
}
