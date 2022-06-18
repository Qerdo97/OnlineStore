﻿using System;
using System.Collections.Generic;

namespace OnlineStore.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string OrderStatus { get; set; } = null!;
        public DateTime ShippedDate { get; set; }
        public int StoreId { get; set; }
        public int StaffId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; } = null!;

        public virtual Customer Customer { get; set; } = null!;
        public virtual staff Staff { get; set; } = null!;
        public virtual Store Store { get; set; } = null!;
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
