using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Product
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json;

    namespace WindowsFormsApp1.Model
    {
        public class ProductJsonRepository : IProductRepository
        {
            public readonly string JsonPath;
            public List<Product> products;

            public ProductJsonRepository(string filename)
            {
                JsonPath = Path.Combine(Path.GetTempPath(), filename);
                if (!File.Exists(JsonPath))
                {
                    CreateProductJsonStub();
                }

                LoadFromFile();
            }
            public void CreateProductJsonStub()
            {

                Provide provide1 = new Provide("ООО 'Первый поставщик'", "ул. Центральная, 1", "Иванов И.И.", "123-45-67", "Сбербанк", "1234567890", "7701234567");
                Provide provide2 = new Provide("ЗАО 'Второй поставщик'", "просп. Мира, 10", "Петров П.П.", "987-65-43", "ВТБ", "0987654321", "7702345678");
                Provide provide3 = new Provide("ООО 'Третий поставщик'", "ул. Советская, 15", "Сидоров С.С.", "555-12-34", "Альфа-Банк", "5432109876", "7703456789");






                List<Product> Products = new List<Product>
                {
                new Product("Мука пшеничная", "кг", "15.0", "100.5",provide1),
                new Product("Сахар-песок", "кг", "10.0", "50.0",provide2),
                new Product("Масло подсолнечное", "л", "20.0", "30.0",provide3),
                new Product("Рис круглозерный", "кг", "12.5", "40.0",provide1)
                };
                
                SaveProductList(Products);
            }

            public void SaveProductList(List<Product> products)
            {
                var json = JsonSerializer.Serialize(products, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(JsonPath, json);
            }

            public void LoadFromFile()
            {
                var json = File.ReadAllText(JsonPath);
                products = JsonSerializer.Deserialize<List<Product>>(json);
            }

            public IEnumerable<Product> GetAllProducts()
            {
                return products;
            }
            public Product GetProduct(int id)
            {
                return products[id];
            }
            public void AddProduct(Product product)
            {
                products.Add(product);
                SaveProductList(products);
            }
            public void SaveProduct(int id, Product product)
            {
                products[id] = product;
                SaveProductList(products);
            }

            public void UpdateProduct(int id, Product updatedProducts)
            {

                if (id >= 0)
                {
                    products[id] = updatedProducts;
                    SaveProductList(products);
                }
                else
                {
                    throw new ArgumentException("Продукт не найден.");
                }

            }

            public void DeleteProduct(int id)
            {
                var note = products[id];
                if (note != null)
                {
                    products.Remove(note);
                    SaveProductList(products);
                }
                else
                {
                    throw new ArgumentException("Продукт не найден.");
                }

            }
        }
    }

}
