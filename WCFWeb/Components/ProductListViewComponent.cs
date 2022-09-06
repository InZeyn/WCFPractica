using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WCFLib.Models;
using WCFLib.Modules;
using WCFWeb.Models;

namespace WCFWeb.Components
{
	public class ProductListViewComponent : ViewComponent
	{
        private readonly ProductModule _module;

        public ProductListViewComponent(ProductModule context) => _module = context;

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var products = new List<ProductViewModel>();
            var items = await GetProductsAsync();
            foreach (var item in items)
            {
                products.Add(new ProductViewModel { Product = item });
            }
            return View(products);
        }
        private Task<List<Product>> GetProductsAsync()
        {
            return _module.GetProductsAsync();
        }
    }
}
