using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customers customer1 = new Customers();
            customer1.Adi = "Tahir";
            customer1.Soyadi = "Yılmaz";
            customer1.Mail = "tahirylmz@gmail.com";

            Customers customer2 = new Customers();
            customer2.Adi = "Süliye";
            customer2.Soyadi = "Yılmaz";
            customer2.Mail = "syilmaz@hotmail.com";
        }
    }
}
