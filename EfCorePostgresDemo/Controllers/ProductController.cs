using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfCorePostgresDemo.Service;

namespace EfCorePostgresDemo.Controllers
{
    public class ProductController
    {
        private readonly ProductService _productService;
        public ProductController()
        {
            _productService = new ProductService();
        }

        public void CreateProduct(string productName , string sku, decimal regularPrice, decimal discountPrice, int quantity,string shortDescription,string productDescription,decimal productWeihgt, string productNote,bool published ,DateTime createdAt , DateTime updatedAt , int createdBy , int updatedBy)
        {
            _productService.RegisterProduct(productName , sku , regularPrice , discountPrice , quantity , shortDescription , productDescription , productWeihgt , productNote , published , createdAt , updatedAt , createdBy , updatedBy);
        }

        public void ListProduct()
        {
            _productService.ShowAllProducts();
        }
    }
}