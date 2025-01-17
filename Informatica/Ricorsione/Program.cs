using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ricorsione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(power(n,m));
            Console.ReadKey();
        }

        private static int power(int n, int m)
        {
            if (m == 0)
            {
                return 1;
            }

            return n * power(n, m - 1);
        }

        private static int fibonacci(int n)
        {
            if (n <= 2)
            {
                return 1;
            }

            return (fibonacci(n - 1) + fibonacci(n-2));
        }

        private static int ricorsivaFatt(int n)
        {
            if(n == 0 || n == 1)
            {
                return 1;
            }

            return ricorsivaFatt(n*ricorsivaFatt(n-1));
        }

        private static int moltiplicazione(int a,int b)
        {
            if (a == 0)
            {
                return 0;
            }

            return b + moltiplicazione(b , a - 1);
        }
    }
}
