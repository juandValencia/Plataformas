using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerosPrimos = 1;
            int m = 2;
            int vandera = 0;
            int numerDeseado = 20;
            int n = 0;
            int x = 0;
            while (numerosPrimos<=numerDeseado-1) {
                m++;
                n = m;
                x = n - 1;
                vandera = 0;
                while (x>=2) {
                    if (n%x!=0) {
                        vandera++;
                    }
                    x--;
                }
                if (vandera==m-2) {
                    numerosPrimos++;
                   // Console.WriteLine(n);
                }
               // Console.WriteLine(numerosPrimos);
                if (numerosPrimos == numerDeseado) {
                    Console.WriteLine(m);
                    break;
                }
                
            }
            Console.ReadLine();



        }
    }
}
