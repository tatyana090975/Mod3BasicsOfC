using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3BasicsOfC
{
    internal class Program
    {
        public enum Semafore : int
        {
            Red = 100, Yellow = 200, Green = 300
        }
        static void Main(string[] args)
        {
            var Day = (Semafore)200;
            Console.WriteLine(Day.ToString());
            Console.ReadKey();
        }
    }
}
