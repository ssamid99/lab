using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public person(string Name, string Surname)
        {
            Console.WriteLine("person born");
        }
        public person(string name, string surname, int age): this(name, surname)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
       
        public virtual string Info()
        {
            return $"{Name} {Surname} {Age}";
        }
    }
}
