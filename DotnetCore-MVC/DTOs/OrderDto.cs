namespace DotnetCore_MVC.DTOs
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public string Product { get; set; }
        public decimal Amount { get; set; }
        public string CustomerName { get; set; }  // join
    }
}
