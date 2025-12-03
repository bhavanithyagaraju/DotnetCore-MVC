namespace DotnetCore_MVC.Models
{
    //models - entities
    public class Customer 
    {
        public int CustomerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public ICollection<Order> Orders { get; set; }
    }
}
