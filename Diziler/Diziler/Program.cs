using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region array
            //int[] array = new int[3];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = i;
            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            #endregion
            #region ornek1
            //Console.Write("sinif mevcudu : ");
            //int mevcut = Convert.ToInt32(Console.ReadLine());
            //string[] ogrenciler = new string[mevcut];


            //for (int i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.WriteLine("{0}.ögrencinin ismini girin",i);
            //    ogrenciler[i] = Console.ReadLine();
            //}

            //Console.Clear();

            //Console.WriteLine("Öğrenciler Listesi\n");
            //foreach (var item in ogrenciler)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            Random random = new Random();
            int positif = 0, negatif = 0, sifir = 0;
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-100, 100);
            }
            foreach (var sayi in numbers)
            {
                Console.WriteLine(sayi);
            
            if ( sayi >0)

                {
                positif++;
                }
            else if (sayi < 0)

                {
                negatif++;
                }
            else

                {
                sifir++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("{0} tane positif var.", positif);
            Console.WriteLine("{0} tane negatif var.", negatif);
            Console.WriteLine("{0} tane sifir var.", sifir);

            Console.ReadKey();

        }
    }
}
