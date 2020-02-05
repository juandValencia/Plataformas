using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un texto");
            String texto;
            texto = Console.ReadLine();
            int a=Int32.Parse(texto);
            int b;
            Console.Write(a);
            while (a > 0) {
                b = a % 10;

                a = a / 10;

                Console.Write(b);
            }
            Console.Read();

        }
    }
}
