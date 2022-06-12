namespace OnlineStore.Models
{
    public partial class Store
    {
        public Store()
        {
            Orders = new HashSet<Order>();
            Stocks = new HashSet<Stock>();
            staff = new HashSet<staff>();
        }

        public int StoreId { get; set; }
        public string StoreName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string ZipCode { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
        public virtual ICollection<staff> staff { get; set; }
    }
}
