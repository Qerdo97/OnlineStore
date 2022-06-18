using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Models;
using OnlineStore.ViewModels;

namespace OnlineStore.ViewComponents
{
    public class DisplayProductsViewComponents : ViewComponent
    {

        private readonly OnlineStoreContext _context;

        public DisplayProductsViewComponents(OnlineStoreContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var products = await _context.Products
                .ToListAsync();
            var productsviewmodel = new List<DisplayProductsViewModel>();
            foreach (var product in products)
            {
                productsviewmodel.Add(new DisplayProductsViewModel
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    ListPrice = product.ListPrice,
                });
            }
            return View(productsviewmodel);
        }
    }
}