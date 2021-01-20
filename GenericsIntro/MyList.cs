using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro //Özel bir tip ile çalışacağım
{
    class MyList<T> //My List de T veri tipi ile çalışacağım yani List<String> gibi düşün string yerine T tipinde düşün
    {
        T[] items;  //T ye ben hangi veri tipini gönderirsem o gelir.

        //Bir class new lendiğinde çalışan bloktur.
        //Constuctor bir methoddur class ın  adı ile aynıdır.
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item) 
        {
            //Diziye ekleme yapacağım için bir dizi tanımlamam lazım !!!
            //Referans numarasının new lwdiğimde uçmaması için

            T[] tempArray = items; //Referanslarımı  artık geçici dizim tutuyor.
            items = new T[items.Length + 1]; //Dizimin eleman sayısını 1 arttırıyorum dinamik bir şekilde

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item; //Artık son gelen elemanımı en son ekliyorum dizime index-1
        }
    }
}
