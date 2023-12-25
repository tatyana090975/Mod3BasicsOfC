using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3BasicsOfC
{
    internal class Program
    {
        public enum DaysOfWeek : int
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
        static void Main(string[] args)
        {
            var Day = (DaysOfWeek)4;
            Console.WriteLine(Day.ToString());
            Console.ReadKey();
        }
    }
}
