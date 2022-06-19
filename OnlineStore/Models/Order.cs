using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        [Display(Name = "Order id")]
        public int OrderId { get; set; }
        [Display(Name = "Customer id")]
        public int CustomerId { get; set; }
        [Display(Name = "Order status")]
        public string OrderStatus { get; set; } = null!;
        [Display(Name = "Shipped date")]
        public DateTime ShippedDate { get; set; }
        [Display(Name = "Store id")]
        public int StoreId { get; set; }
        [Display(Name = "Staff id")]
        public int StaffId { get; set; }
        [Display(Name = "Creation date")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Created by")]
        public string CreatedBy { get; set; } = null!;
        [Display(Name = "Last modification date")]
        public DateTime LastModifiedDate { get; set; }
        [Display(Name = "Last modified by")]
        public string LastModifiedBy { get; set; } = null!;

        public virtual Customer Customer { get; set; } = null!;
        public virtual staff Staff { get; set; } = null!;
        public virtual Store Store { get; set; } = null!;
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
