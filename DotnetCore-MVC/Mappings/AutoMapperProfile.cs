using AutoMapper;
using DotnetCore_MVC.DTOs;
using DotnetCore_MVC.Models;

namespace DotnetCore_MVC.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap();
        }        
    }
}
