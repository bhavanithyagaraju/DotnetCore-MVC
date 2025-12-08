using AutoMapper;
using DotnetCore_MVC.DTOs;
using DotnetCore_MVC.Models;
using DotnetCore_MVC.UnitOfWork;

namespace DotnetCore_MVC.Services
{
    public class OrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public OrderService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<OrderDto>> GetOrdersWithCustomers()
        {
            var orders = await _unitOfWork.Orders.GetOrdersWithCustomers();
            return orders.Select(order => new OrderDto
            {
                OrderId = order.OrderId,
                OrderRef = order.OrderRef,
                CustomerId = Convert.ToInt32(order.CustomerId),
                ProductId = Convert.ToInt32(order.ProductId),
                CustomerName = order.Customer!.CustomerName
            });
        }

        public async Task AddOrder(OrderDto dto)
        {
            Order order = _mapper.Map<OrderDto, Order>(dto);
            await _unitOfWork.Orders.Add(order);
            await _unitOfWork.Save();
        }
    }
}
