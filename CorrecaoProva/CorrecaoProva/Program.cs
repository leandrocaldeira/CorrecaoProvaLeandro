using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrecaoProva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Maior(1, 2));
            Console.ReadKey();
        }
        static int Maior (int a, int b )
        {
            if (a > b)
            {
                return a;

            }
            else return b;
        }
        static bool Par (int num)
        {
            int resto = (num % 2 );
            
            if (resto ==0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
