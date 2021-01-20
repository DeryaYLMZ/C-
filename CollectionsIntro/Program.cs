using System;
using System.Collections.Generic; //Koleksiyon sınıfı
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //array ler sınırlar içerisinde takılır. Dışına çıkamayız.
            //string[] isimler = new string[] { "Derya", "Deniz", "Tuba" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);

            //List<string> isimler2 = new List<string>(); //string listesi
            //isimler2.Add("Emir");
            List<string> isimler2 = new List<string> { "Derya", "Deniz", "Tuba" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Betül");
            Console.WriteLine(isimler2[3]);

            Console.ReadKey();
        }
        
    }
}
