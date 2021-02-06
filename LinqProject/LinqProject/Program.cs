using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Bilgisayar"},
                new Category{CategoryId=2,CategoryName="Telefon"},
            };

            List<Product> products = new List<Product>
            {
                 new Product{ProductId=1,CategoryId=1,ProductName="Casper",QuantityPerUnit="32 gb ram",UnitPrice=10000,UnitsInStock=5},
                 new Product{ProductId=2,CategoryId=1,ProductName="Asus",QuantityPerUnit="16 gb ram",UnitPrice=8000,UnitsInStock=3},
                 new Product{ProductId=3,CategoryId=1,ProductName="Acer",QuantityPerUnit="128 gb ram",UnitPrice=6000,UnitsInStock=2},
                 new Product{ProductId=4,CategoryId=2,ProductName="Huawei",QuantityPerUnit="16 gb ram",UnitPrice=5000,UnitsInStock=15},
                 new Product{ProductId=5,CategoryId=2,ProductName="Samsung",QuantityPerUnit="64 gb ram",UnitPrice=3000,UnitsInStock=0},
            };

            Console.WriteLine("----------Algoritmik---------\n");
            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("----------Linq--------------\n");

            var result = products.Where(p => p.UnitPrice > 6000 && p.UnitsInStock >3); //result = Product array -- Sorgunun sonucunu döndürüyoruz burada

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("-----Algoritmik Fonksiyon-------\n");
            GetProducts(products);
            Console.WriteLine("-----Linq Fonksiyon-------\n");
            GetProductsLinq(products);
            Console.ReadLine();
        }

        

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if(product.UnitPrice>6000 && product.UnitsInStock >3)
                {
                    Console.WriteLine(product.ProductName);
                    filteredProducts.Add(product);
                }
                
            }
            return filteredProducts;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 6000 && p.UnitsInStock > 3).ToList(); //Linq kullaıyorsak yukarıdaki gibi yeni bir liste oluşturup ona atmamıza gerek yok.
                                                                                           //Burada yrni bir liste oluşturulması sağlanıyor ve koşulu sağlayan değerler o listeye atılıyor.
        }
        
        
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
