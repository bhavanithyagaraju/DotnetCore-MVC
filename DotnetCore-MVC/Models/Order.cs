namespace DotnetCore_MVC.Models
{
    //models - entities
    public class Order
    {
        public int OrderId { get; set; }
        public string Product { get; set; } = string.Empty;
        public decimal Amount { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
