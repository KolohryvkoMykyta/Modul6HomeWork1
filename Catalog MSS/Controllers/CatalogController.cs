using Microsoft.AspNetCore.Mvc;

namespace Catalog_MSS.Controllers
{
    [ApiController]
    [Route("api/catalog")]
    public class CatalogController : ControllerBase
    {
        private List<Product> productCatalog = new List<Product>
        {
            new Product { Id = 1, Name = "Смартфон Samsung Galaxy S21", Price = 799.99, Description = "Смартфон Samsung Galaxy S21 с экраном 6.2 дюйма, процессором Exynos 2100 и 128 ГБ встроенной памяти." },
            new Product { Id = 2, Name = "Ноутбук Lenovo ThinkPad X1 Carbon", Price = 1299.00, Description = "Ноутбук Lenovo ThinkPad X1 Carbon с 14-дюймовым экраном, процессором Intel Core i7 и 16 ГБ оперативной памяти." },
            new Product { Id = 3, Name = "Телевизор LG OLED55CXPUA", Price = 1599.99, Description = "Телевизор LG OLED55CXPUA с диагональю 55 дюймов, поддержкой 4K разрешения и Smart TV функционалом." },
            new Product { Id = 4, Name = "Фотоаппарат Sony Alpha A7 III", Price = 1999.00, Description = "Фотоаппарат Sony Alpha A7 III с матрицей 24.2 Мп, встроенной стабилизацией изображения и 4K видеозаписью." },
            new Product { Id = 5, Name = "Наушники Bose QuietComfort 35 II", Price = 249.99, Description = "Беспроводные наушники Bose QuietComfort 35 II с активным шумоподавлением и до 20 часов работы от аккумулятора." },
        };

        [HttpGet]
        [Route("products")]
        public IEnumerable<Product> GetProducts()
        {
            return productCatalog;
        }
    }
}