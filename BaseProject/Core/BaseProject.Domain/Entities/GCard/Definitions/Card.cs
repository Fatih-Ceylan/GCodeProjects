using Utilities.Core.UtilityDomain.Entities;

namespace BaseProject.Domain.Entities.GCard.Definitions
{
    public class Card:BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int TaxRate { get; set; } 
        public ICollection<OrderDetail> OrderDetails { get; set; } 
        public ICollection<Invoice> Invoices { get; set; } 
    }
}
