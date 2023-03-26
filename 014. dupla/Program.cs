using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014.dupla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot és kiírom a dupláját! ");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(2 * szam);

            Console.ReadKey();
        }
    }
}
