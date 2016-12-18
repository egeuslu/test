using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhilegithubtest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int sonuc = 0;
            do
            {
               
              a++;
              sonuc += a;

            } while ( a < 10 );

            Console.WriteLine(sonuc);

            Console.ReadKey();

        }
    }
}
