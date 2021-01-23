using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Tüzel müşteri Müşteriden miras alır.
    class IndividualCustomer:Customer //Müşterideki tüm özellikler Tüzelde de var kabul eidlir.
    {
       
        public string CompanyName { get; set; } //Tüzel kişi
        public string TaxNo { get; set; }
    }
}
