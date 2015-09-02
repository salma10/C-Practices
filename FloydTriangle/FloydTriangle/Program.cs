using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloydTriangle
{
    class Program
    {
        int noOfLines, i, j, k, number;

        public void GetNoOfLines()
        {
            Console.WriteLine("Enter the number of lines: ");
            noOfLines = Convert.ToInt32(Console.ReadLine());
        }

        public void Result()
        {
            number = 1;
            for (i = 1; i <= noOfLines; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", number);
                    number++;
                }

                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {
            Program n = new Program();
            n.GetNoOfLines();
            n.Result();
            Console.ReadKey();
        }
    }
}
