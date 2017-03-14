using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem
    {
        public int SumMultiples(int num)
        {
            int result = 0;
            for (int i = 0; i < num; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }
            return result;
        }
        public int EvenFibonacci(int num)
        {
            int result = 0;
            int fibonacci1 = 1;
            int fibonacci2 = 2;
            int temp = 0;
            while (fibonacci2 < num)
            {
                if (fibonacci2 % 2 == 0)
                {
                    result += fibonacci2;
                }
                temp = fibonacci1 + fibonacci2;
                fibonacci1 = fibonacci2;
                fibonacci2 = temp;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Problem problem = new Problem();
            int result = problem.EvenFibonacci(4000000);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
