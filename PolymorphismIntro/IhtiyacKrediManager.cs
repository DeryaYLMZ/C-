using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class IhtiyacKrediManager : ICreditManager
    {
        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme planı hesaplandı");
        }

        public void Yap()
        {
            throw new NotImplementedException();
        }
    }
}
