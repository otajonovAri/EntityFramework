using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfCorePostgresDemo.Models;
using EfCorePostgresDemo.Repositories;

namespace EfCorePostgresDemo.Service
{
    public class ProductService
    {
        private readonly ProductRepository productRepository;
        public ProductService()
        {
            productRepository = new ProductRepository();
        }

        public void RegisterProduct(string productName , string sku, decimal regularPrice, decimal discountPrice, int quantity,string shortDescription,string productDescription,decimal productWeihgt, string productNote,bool published ,DateTime createdAt , DateTime updatedAt , int createdBy , int updatedBy)
        {
            var product = new Product{
                ProductName = productName,
                SKU = sku,
                RegularPrice = regularPrice,
                DiscountPrice = discountPrice,
                Quantity = quantity,
                ShortDescription = shortDescription,
                ProductDescription = productDescription,
                ProductWeight = productWeihgt,
                ProductNote = productNote,
                Published = published,
                CreatedAt = createdAt,
                UpdatedAt = updatedAt,
                CreatedBy = createdBy,
                UpdatedBy = updatedBy
            };
            productRepository.AddProduct(product);
            System.Console.WriteLine($"Product Added: {product.ProductName}");
        }

        public void ShowAllProducts()
        {
            var product = productRepository.GetAllProducts();
            System.Console.WriteLine("Product in Database: ");
            foreach(var item in product)
                System.Console.WriteLine($"Producat Id: {item.ProductID} - Product name: {item.ProductName} - Product Quantity: {item.Quantity}");
        }
    }
}