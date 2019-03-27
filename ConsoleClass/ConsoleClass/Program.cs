using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(Console);
            foreach(var method in type.GetMethods())
            {
                Console.WriteLine($"{method}");
            }
            Console.Read();
        }
    }
}
