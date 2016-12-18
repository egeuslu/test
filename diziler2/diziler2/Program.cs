using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler2
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<int> numbers = new List<int>();
            //numbers.Add(3);
            //numbers.Add(5);
            //numbers.AddRange(new int[] { 8, 10, 13, 15, 17});

            //numbers.RemoveAt(0); girilen index sirilir
            //numbers.Remove(10); girilen değer listeden silinir 1den fazla ise ilk değer silinir
            //numbers.RemoveRange(3, 2); aralık silinir
            //numbers.RemoveAll(i => i > 5);//5ten büyük elemanları siler

            //bool varmi = numbers.Contains(13);girilen değeri listede arar varsa true yoksa false döner

            //var result = numbers.Find(i => i > 5); //5ten büyük ilk itemi döner     
            //var result = numbers.FindAll(i => i > 5).ToList(); //5ten bütük tüm itemlar döner.
            //var result = numbers.FindAll(i => i > 5).Count(); // 5ten bütük elemanların sayısını döner 

            //numbers.Sort();
            //numbers.Reverse();
            //numbers.Clear();
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine("\n\t" + item);
            //}

            //List<char> alfabe = new List<char>();

            //for (char i = 'a'; i <= 'z'; i++)
            //{
            //    alfabe.Add(i);
            //}

            //alfabe.Reverse();

            //foreach (var item in alfabe)
            //{
            //    //Console.Write(item+" ");
            //}
            List<string> isimler = new List<string>();

            isimler.AddRange(new string[] { "özgür", "Ali", "Veli", "Vali" });

            isimler.Reverse();

            foreach (var item in isimler)
            {
               Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
