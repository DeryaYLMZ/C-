using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Entity Class
    //Customer class ını ebeveyn olarak düşünebiliriz.
    //Customer Class da olan tüm özelliklere bu class sahip olur.
    class CoorporateCustomer : Customer //Sen bir müşterisin diyoruz(İnheritance)
    {        
        public string TcNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}
