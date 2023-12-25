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
            const string MyName = "Татьяна";
            double MyAge = 48.5;
            bool MyPet = true;
            int MyFoot = 39;
            Console.WriteLine("Меня зовут {0}\nМне {1} лет\nЕсть ли у меня питомец? {2}\nУ меня {3} размер ноги", MyName, MyAge, MyPet, MyFoot);
            Console.ReadKey();
        }
    }
}
