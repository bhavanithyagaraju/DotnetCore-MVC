
namespace DotnetCore_MVC.Models
{
    //models - entities
    public class Customer 
    {
        public int CustomerId  { get; set; }
        public string CustomerName  { get; set; } = string.Empty;
        public string Email  { get; set; } = string.Empty;
        public string Password  { get; set; } = string.Empty;
        public int CreatedId  { get; set; }
        public DateTime CreatedDate  { get; set; }
        public int? UpdatedId  { get; set; }
        public DateTime? UpdatedDate  { get; set; }

        public ICollection<Order> Orders { get; set; } = [];
    }
}
