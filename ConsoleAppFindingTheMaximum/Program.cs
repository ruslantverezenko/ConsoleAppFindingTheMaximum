using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFindingTheMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ;)
            {
                FindingTheMaximum();
                Console.WriteLine("");
                Console.Write("Enter the numbers again?(yes or no): ");
                string userResponse = Console.ReadLine();
                if (userResponse == "yes" || userResponse == "Yes")
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
        static void FindingTheMaximum()
        {
            Console.Write("Enter an integer(for example 1801): ");
            int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter an integer(for example 1337): ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} more than {num2}");
            }

            else if(num2 > num1)
            {
                Console.WriteLine($"{num2} more than {num1}");
            }
            else
            {
                Console.WriteLine("the numbers are equal");
            }
        }
    }
}
