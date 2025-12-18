namespace DotnetCore_MVC.Models
{
    public class OrderVM
    {
        public int OrderId { get; set; }
        public string OrderRef { get; set; } = string.Empty;
        public int? ProductId { get; set; }
        public int? CustomerId { get; set; }
        public int CreatedId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}
