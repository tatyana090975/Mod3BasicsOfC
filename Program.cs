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
            string MyName;
            MyName = "Jane";
            Console.WriteLine(MyName);
            MyName = "Alan";
            Console.WriteLine(MyName);
            Console.WriteLine("Jane\n\tПривет мир\n\tМне 27 лет\n\tMy name is\n Jane");
            Console.WriteLine('\u0040');
            Console.WriteLine('\x23');
            Console.ReadKey();
        }
    }
}
