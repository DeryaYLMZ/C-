using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        // Gerçek - Tüzel müşteri verisi girdiğimizi düşünelim.
        static void Main(string[] args)
        {
            CoorporateCustomer customer1 = new CoorporateCustomer(); //Gerçek Müşteri nesnesi
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "Derya";
            customer1.Surname = "Yılmaz";
            customer1.TcNo = "12345";

            IndividualCustomer customer2 = new IndividualCustomer(); //Tüzel Müşteri nesnesi
            customer2.Id = 2;
            customer2.CustomerNo = "2346";
            customer2.CompanyName = "Yılmazlar Nakliyat Şirketi";
            customer2.TaxNo = "123698752";

            //Müşteri Class ı hem gerçek hem de tüzel müşterinin referansını tutabiliyor demektir.
            Customer customer3 = new CoorporateCustomer(); 
            Customer customer4 = new IndividualCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
