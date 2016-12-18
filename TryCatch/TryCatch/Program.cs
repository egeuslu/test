using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    int[] array = new int[4];
            //    Console.WriteLine(array[5]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{

            //    Console.WriteLine("Hata Olustu! " + ex.Message);
            //}
            //try
            //{
            //    int sayi;
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(" HATA OLUSTU!  " + ex.Message);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(" HATA OLUSTU!  " + ex.Message);
            //}
            // try
            // {
            //     int sayi;
            //     sayi = int.Parse(Console.ReadLine());
            // }
            // catch (OverflowException ex)
            // {
            //     Console.WriteLine(ex.Message);                
            // }
            // catch (FormatException ex)
            // {
            //     Console.WriteLine(ex.Message);
            // }
            //finally
            // {
            //     Console.WriteLine("Final kısmı çalıştı");
            // }
            //int i;
            //bool state = false;
            //while (!state)
            //{

            //    state = Int32.TryParse(Console.ReadLine(), out i);
            //    if (state == false)
            //    {
            //        Console.WriteLine("Hatali bir giriş yaptiniz");
            //    }
            //}
            try
            {
                throw new FormatException();
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.Message);
                
            }

            Console.ReadKey();
        }
    }
}
