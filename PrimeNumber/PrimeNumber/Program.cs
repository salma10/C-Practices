using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        int firstNumber, lastNumber, number, i, j;

        public void GetRange()
        {
            Console.WriteLine("Enter your first range: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your last range: ");
            lastNumber = Convert.ToInt32(Console.ReadLine());
        }

        public void Result()
        {
            for (i = firstNumber; i <= lastNumber; i++)
            {
                if (i == 2)
                {
                    Console.WriteLine("Number: {0}", i);
                }
                number = Convert.ToInt32(Math.Sqrt(i));
                for (j = 2; j <= number; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                    if (j == number)
                    {
                        Console.WriteLine("Number: {0}", i);
                    }
                }
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program n = new Program();
            n.GetRange();
            n.Result();
        }
    }
}
