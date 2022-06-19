using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Models
{
    public partial class Stock
    {
        [Display(Name = "Stock id")]
        public int StoreId { get; set; }
        [Display(Name = "Product id")]
        public int ProductId { get; set; }
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual Store Store { get; set; } = null!;
    }
}
