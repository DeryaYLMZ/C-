using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro
{
    class ProductManager
    {  //Encapsulation Product class içerisindeki özellikleri kümulatif göndermiş oluyorum.

        public void Add(Product product)
        {
           Console.WriteLine(product.ProductName + "ürünü eklendi.");
        }

        public void Update(Product product)
        {
           Console.WriteLine(product.ProductName + "ürünü güncellendi.");
        }

        
    }
}
