using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        [Display(Name = "Customer id")]
        public int CustomerId { get; set; }
        [Display(Name = "First name")]
        public string FirstName { get; set; } = null!;
        [Display(Name = "Last name")]
        public string LastName { get; set; } = null!;
        [Display(Name = "Phone number")]
        public string Phone { get; set; } = null!;
        [Display(Name = "Email address")]
        public string Email { get; set; } = null!;
        [Display(Name = "Street")]
        public string Street { get; set; } = null!;
        [Display(Name = "City")]
        public string City { get; set; } = null!;
        [Display(Name = "State")]
        public string State { get; set; } = null!;
        [Display(Name = "Zip code")]
        public string ZipCode { get; set; } = null!;
        [Display(Name = "Creation date")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Created by")]
        public string CreatedBy { get; set; } = null!;
        [Display(Name = "Last modification date")]
        public DateTime LastModifiedDate { get; set; }
        [Display(Name = "Last modified by")]
        public string LastModifiedBy { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
