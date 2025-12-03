using DotnetCore_MVC.Repository;

namespace DotnetCore_MVC.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }
        IOrderRepository Orders{ get; }
        Task<int> Save();
    }
}
