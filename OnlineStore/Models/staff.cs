using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Models
{
    public partial class staff
    {
        public staff()
        {
            InverseManager = new HashSet<staff>();
            Orders = new HashSet<Order>();
        }

        [Display(Name = "Staff id")]
        public int StaffId { get; set; }
        [Display(Name = "First name")]
        public string FirstName { get; set; } = null!;
        [Display(Name = "Last name")]
        public string LastName { get; set; } = null!;
        [Display(Name = "Email address")]
        public string Email { get; set; } = null!;
        [Display(Name = "Phone number")]
        public string Phone { get; set; } = null!;
        [Display(Name = "Is active?")]
        public bool IsActive { get; set; }
        [Display(Name = "Store id")]
        public int StoreId { get; set; }
        [Display(Name = "Manager id")]
        public int? ManagerId { get; set; }
        [Display(Name = "Creation date")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Created by")]
        public string CreatedBy { get; set; } = null!;
        [Display(Name = "Last modification date")]
        public DateTime LastModifiedDate { get; set; }
        [Display(Name = "Last modified by")]
        public string LastModifiedBy { get; set; } = null!;

        public virtual staff? Manager { get; set; }
        public virtual Store Store { get; set; } = null!;
        public virtual ICollection<staff> InverseManager { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
