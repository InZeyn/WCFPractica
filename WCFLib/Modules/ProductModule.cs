using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WCFLib.Models;
using WCFLib.Services;

namespace WCFLib.Modules
{
    public class ProductModule
    {
        public Task<List<Product>> GetProductsAsync()
        {
            return ProductService.GetProducts();
        }

        public Product GetProductById(int id)
        {
            return ProductService.GetProductById(id);
        }

        public void CreateProduct(Product product)
        {
        }

        public void DeleteProduct(int id)
        {
        }
    }
}
