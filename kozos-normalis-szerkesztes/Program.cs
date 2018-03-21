using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kozos_normalis_szerkesztes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Világ");
            balazsbence();
            megyerimarton();          
            nada();
            Console.ReadKey();
        }

        static void balazsbence()
        {
            Console.WriteLine("Balázs Bence");
        }

        static void megyerimarton()
        {
            Console.WriteLine("Megyeri Márton");            
        }

        static void nada()
        {
            Console.WriteLine("Dániel");
            szakzsolt();
            Console.ReadKey();
        }
        public static void szakzsolt()
        {
            Console.WriteLine("Szakmári Zsolt");
        }
    }
}
