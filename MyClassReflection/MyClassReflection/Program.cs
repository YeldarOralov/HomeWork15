using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyClassReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person()
            {
                FullName = "Mark Jacobs",
                Age = 28,
                Height = 180,
                Weight = 77,
                Country = "USA"
            };

            var type = person.GetType();
            //Console.WriteLine(person.GetType().GetMembers());
            foreach (var attributes in type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
            {
                Console.WriteLine(attributes.GetValue(person));
            }
                    

            Console.Read();
        }
    }
}
