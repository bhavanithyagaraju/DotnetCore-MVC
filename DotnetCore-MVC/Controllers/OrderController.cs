using DotnetCore_MVC.DTOs;
using DotnetCore_MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCore_MVC.Controllers
{
    public class OrderController : Controller
    {
        /*
         [
          {
            "orderId": 1,
            "product": "Laptop",
            "amount": 60000,
            "customerName": "Bhavani"
          }
        ] 
         */
        private readonly OrderService _orderService;
        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }
        public async Task<IActionResult> GetAllOrders()
        {
            return Ok(await _orderService.GetOrdersWithCustomers());
        }

        public async Task<IActionResult> AddOrder(OrderDto dto) 
        {
            await _orderService.AddOrder(dto);
            return Ok("Order Created Successfully!");
        }
    }
}
