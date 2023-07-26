using Microsoft.AspNetCore.Mvc;

namespace Catalog_MSS.Controllers
{
    [ApiController]
    [Route("api/catalog")]
    public class CatalogController : ControllerBase
    {
        private List<Product> productCatalog = new List<Product>
        {
            new Product { Id = 1, Name = "�������� Samsung Galaxy S21", Price = 799.99, Description = "�������� Samsung Galaxy S21 � ������� 6.2 �����, ����������� Exynos 2100 � 128 �� ���������� ������." },
            new Product { Id = 2, Name = "������� Lenovo ThinkPad X1 Carbon", Price = 1299.00, Description = "������� Lenovo ThinkPad X1 Carbon � 14-�������� �������, ����������� Intel Core i7 � 16 �� ����������� ������." },
            new Product { Id = 3, Name = "��������� LG OLED55CXPUA", Price = 1599.99, Description = "��������� LG OLED55CXPUA � ���������� 55 ������, ���������� 4K ���������� � Smart TV ������������." },
            new Product { Id = 4, Name = "����������� Sony Alpha A7 III", Price = 1999.00, Description = "����������� Sony Alpha A7 III � �������� 24.2 ��, ���������� ������������� ����������� � 4K ������������." },
            new Product { Id = 5, Name = "�������� Bose QuietComfort 35 II", Price = 249.99, Description = "������������ �������� Bose QuietComfort 35 II � �������� ��������������� � �� 20 ����� ������ �� ������������." },
        };

        [HttpGet]
        [Route("products")]
        public IEnumerable<Product> GetProducts()
        {
            return productCatalog;
        }
    }
}