using System;
using System.Collections.Generic;
using System.Text;
using WCFLib.Models;

namespace WCFLib.Services
{
    internal class ProductService
    {
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            for (int i = 10; i > 0; i--)
            {
                Product product = new Product
                {
                    ID = i,
                    Description = i.ToString(),
                    Name = i.ToString()
                };
                products.Add(product);
            }
            return products;
        }

        public static Product GetProductById(int id)
        {
            Product product = new Product
            {
                ID = id,
                Description = "Test",
                Name = "A product"
            };
            return product;
        }

        public void CreateProduct(Product product)
        {
        }

        public void DeleteProduct(int id)
        {
        }
    }
}
