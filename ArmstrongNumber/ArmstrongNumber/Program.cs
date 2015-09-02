using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    class Program
    {
        int number, total;

        public bool IsArmstrongNumber(int num)
        {
            int currentDigit;
            number = num;
            total = 0;
            while (number >= 10)
            {
                currentDigit = number % 10;
                total = total + (currentDigit * currentDigit * currentDigit);
                number = number / 10;
            }
            total = total + (number * number * number);
            if (total == num)
            {
                return true;
            }
            else {

                return false;
            }

        }
        static void Main(string[] args)
        {
            int num;
            Program n = new Program();
            Console.WriteLine("Enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (n.IsArmstrongNumber(num))
            {
                Console.WriteLine("The number is an Armstrong number");
            }
            else {
                Console.WriteLine("The number is not an Armstrong number");                
            }

            Console.ReadKey();
        }
    }
}
