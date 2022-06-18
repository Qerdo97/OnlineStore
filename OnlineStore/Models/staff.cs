using System;
using System.Collections.Generic;

namespace OnlineStore.Models
{
    public partial class staff
    {
        public staff()
        {
            InverseManager = new HashSet<staff>();
            Orders = new HashSet<Order>();
        }

        public int StaffId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public bool IsActive { get; set; }
        public int StoreId { get; set; }
        public int? ManagerId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; } = null!;

        public virtual staff? Manager { get; set; }
        public virtual Store Store { get; set; } = null!;
        public virtual ICollection<staff> InverseManager { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
