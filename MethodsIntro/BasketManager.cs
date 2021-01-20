using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsIntro
{
    class BasketManager  //Manager gibi isimlendirmeler  genelde operasyon tutar.
    {
        //naming convention -- Yazım Kuralı Methodlar genelde büyük harfle başlar
        //syntax
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete Eklendi :" + urun.Name);
          
        }

        public void EkleAlternatif(string Name, string Explanation, double Fiyat)
        {
            Console.WriteLine("Sepete Eklendi." +Name);
        }
        
    }
}
