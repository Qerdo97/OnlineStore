namespace OnlineStore.ViewModels
{
    public class DisplayProductsViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public decimal ListPrice { get; set; }
    }
}