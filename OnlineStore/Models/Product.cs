using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderItems = new HashSet<OrderItem>();
            Stocks = new HashSet<Stock>();
        }

        [Display(Name = "Product id")]
        public int ProductId { get; set; }
        [Display(Name = "Product name")]
        public string ProductName { get; set; } = null!;
        [Display(Name = "Brand id")]
        public int BrandId { get; set; }
        [Display(Name = "Category id")]
        public int CategoryId { get; set; }
        [Display(Name = "Unit price")]
        public decimal ListPrice { get; set; }
        [Display(Name = "Creation date")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Created by")]
        public string CreatedBy { get; set; } = null!;
        [Display(Name = "Last modification date")]
        public DateTime LastModifiedDate { get; set; }
        [Display(Name = "Last modified by")]
        public string LastModifiedBy { get; set; } = null!;

        public virtual Brand Brand { get; set; } = null!;
        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
