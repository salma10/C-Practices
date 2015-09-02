using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
        int number;
        public void ReadNumber() 
        {
            number = Convert.ToInt32(Console.ReadLine());
        }
        public void Result()
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is an Even number");
            }
            else
            {
                Console.WriteLine("The number is an Odd number");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program foundnumber = new Program();
            foundnumber.ReadNumber();
            foundnumber.Result();
        }
    }
}
