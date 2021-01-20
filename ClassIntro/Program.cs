using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  //Class yapısını anlama
namespace ClassIntro
{
    class Program
    {
        //String tutmak yerine class tuttum. Sadece istediğim kadar veri tanımlayabiliyorum.
        static void Main(string[] args)
        {
            //Kurs1 e ait özellikler
            Kurs kurs1 = new Kurs();  //Kurs artık benim veri tipim
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Derya Yılmaz";
            kurs1.IzlenmeOrani = 90;

            //Kurs2 ye ait özellikler
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.Egitmen = "Betül Yılmaz";
            kurs2.IzlenmeOrani = 60;

            //Kur3 e ait özellikler
            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Egitmen = "Emir Yılmaz";
            kurs3.IzlenmeOrani = 90;

            //Kurs4 e ait özellikler
            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "React";
            kurs4.Egitmen = "Tahir Yılmaz";
            kurs4.IzlenmeOrani = 90;

           //Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };
            foreach (Kurs kurs in kurslar) //Hangi veritipinde ise öyle yazıyorsun.
            {
                Console.WriteLine(kurs.KursAdi + ":" +kurs.Egitmen);
            }

            Console.ReadKey();        }
    }

    //Kendi veri tipini yazıyormuşsun gibi düşün
    // İçerisinde istediğim özellikleri tanımlıyorum ve değişken gibi ağırıyorum
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
    
}
