using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3BasicsOfC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);
            Console.Write("What is your favorite day of week? ");
            int numDay = int.Parse(Console.ReadLine());
            var day = (DayOfWeek)numDay;
            Console.WriteLine(day);
            Console.ReadKey();
        }
    }
}
