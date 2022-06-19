using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        
        [Display(Name = "Category id")]
        public int CategoryId { get; set; }
        [Display(Name = "Category name")]
        public string CategoryName { get; set; } = null!;
        [Display(Name = "Creation date")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Created by")]
        public string CreatedBy { get; set; } = null!;
        [Display(Name = "Last modification date")]
        public DateTime LastModifiedDate { get; set; }
        [Display(Name = "Last modified by")]
        public string LastModifiedBy { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
