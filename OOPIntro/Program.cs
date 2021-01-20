using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id=2,CategoryId=5,UnitsInStock=5,
                ProductName ="Kalem",UnitPrice=10};

            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager(); //Stack - Heap gibi düşünelim
            productManager.Add(product1);
        }
    }
}
