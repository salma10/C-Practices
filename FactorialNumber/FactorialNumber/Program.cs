using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class NumberManipulator
    {
        int num;
        public int GetNumber()
        {
            Console.WriteLine("Enter the number : ");
            num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        public int factorial(int num)
        {
            /* local variable declaration */
            int result;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }

        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            //calling the factorial method
            int num = n.GetNumber();
            Console.WriteLine("Factorial of the number is : {0}", n.factorial(num));
            Console.ReadLine();
        }
    }
}
