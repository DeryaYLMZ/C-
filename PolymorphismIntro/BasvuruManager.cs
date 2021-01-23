using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class BasvuruManager
    {
        //Method Injection 
        //BaşvuruYap methoduna hangi krediyi gönderirsem ondaki method çalışacak
        public void BasvuruYap(ICreditManager creditManager, ILoggerService loggerService) //Parametre olarak kredimi gönderiyorum
        {
           //Başvuran bilgilerini değerlendir
            creditManager.Hesapla();
            loggerService.Log();
        }
        //Müşterinin hesaplanmasını istediği kredilerin hesaplarını yapıyorum
        public void KrediOnBilgilendirmeYap(List<ICreditManager> credits) //Parametre olarak kredi dizisini gönderiyorum.
        {
            foreach (var credi in credits)
            {
                credi.Hesapla();
            }
        }
    }
}
