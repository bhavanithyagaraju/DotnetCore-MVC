using DotnetCore_MVC.Models;

namespace DotnetCore_MVC.Repository
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<IEnumerable<Order>> GetOrdersWithCustomers();
    }
}
