using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Person
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return string.Join(", ", Name);
        }
    }

    class Call
    {
        public static void Main(string[] args)
        {
            var list = new List<Person> { new Person("Misha", 10), new Person("Ura", 20), new Person("Misha", 20) };
            var uniqueName = list.Select(n => n.Name).Distinct().ToArray();
            //var uniqueName = list.Where(p => p.Age < 18 ).Average(p => p.Age).Distinct(n => n.Name).ToArray().ToString();

            Console.WriteLine($"{uniqueName}");
        }
    }
}
