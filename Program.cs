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
            Console.Write("Введите имя: ");
            var name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            var age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя {0} и вам {1} лет.", name, age);

            Console.Write("Введите день рождения: ");
            var birthdate = Console.ReadLine();

            Console.Write($"Ваш день рождения {birthdate}");

            Console.ReadKey();
        }
    }
}
