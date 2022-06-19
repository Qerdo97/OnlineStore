using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Models
{
    public partial class OrderItem
    {
        [Display(Name = "Order id")]
        public int OrderId { get; set; }
        [Display(Name = "Item id")]
        public int ItemId { get; set; }
        [Display(Name = "Product id")]
        public int ProductId { get; set; }
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }
        [Display(Name = "Unit price")]
        public decimal ListPrice { get; set; }
        [Display(Name = "Discount")]
        public int Discount { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
