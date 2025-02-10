using EfCorePostgresDemo.Controllers;
using EfCorePostgresDemo.Data;
using EfCorePostgresDemo.Models;


var productController  = new ProductController();

productController.CreateProduct( "Gaming Laptop",
    "GL-2025-001",
    1500.99m,
    1299.99m,
    10,
    "High-performance gaming laptop with RGB keyboard",
    "This gaming laptop features a high-end GPU, fast SSD storage, and a 144Hz display, perfect for professional and casual gamers.",
    2.5m,
    "Limited stock available!",
    true,
    DateTime.UtcNow,
    DateTime.UtcNow,
    1,
    1);
productController.ListProduct();