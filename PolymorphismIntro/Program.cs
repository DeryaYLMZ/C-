using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
          ICreditManager ıhtiyacKrediManager = new IhtiyacKrediManager();     
          ICreditManager tasitKrediManager = new TasitKrediManager();
          ICreditManager konutKrediManager = new KonutKrediManager();
          //ILoggerService databaseloggerService = new DataBaseLoggerService();
          //ILoggerService fileloggerService = new FileLoggerService(); 

         BasvuruManager basvuruManager = new BasvuruManager();
         basvuruManager.BasvuruYap(tasitKrediManager, new DataBaseLoggerService());


          List<ICreditManager> credits = new List<ICreditManager>() { ıhtiyacKrediManager, tasitKrediManager };
          //basvuruManager.KrediOnBilgilendirmeYap(credits);
            











            Console.Read();
        }
    }
}
