
namespace DotnetCore_MVC.DTOs
{
    public class OrderDto
    {        
        public int OrderId { get; set; }
        public string OrderRef { get; set; } = string.Empty;
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = string.Empty; // join
    }
}
