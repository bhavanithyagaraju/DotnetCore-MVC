using AutoMapper;
using DotnetCore_MVC.DTOs;
using DotnetCore_MVC.Models;
using DotnetCore_MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCore_MVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly IMapper _mapper;
        private readonly OrderService _orderService;
        public OrderController(IMapper mapper, OrderService orderService)
        {
            _mapper = mapper;
            _orderService = orderService;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<OrderDto> ordersDto = await _orderService.GetOrdersWithCustomers();
            var result = _mapper.Map<List<OrderDto>, List<OrderVM>>(ordersDto.ToList());
            return View(result);
        }

        public async Task<IActionResult> AddOrder(OrderDto dto) 
        {
            await _orderService.AddOrder(dto);
            return Ok("Order Created Successfully!");
        }
    }
}
