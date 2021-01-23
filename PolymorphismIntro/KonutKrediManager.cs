using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class KonutKrediManager : ICreditManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Konut Kredisi Ödeme planı hesaplandı");
        }

        public void Yap()
        {
            throw new NotImplementedException();
        }
    }
}
