using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Doctor:person
    {
        public string Field { get; set; }
       
        public Doctor(string name, string surname, int age, string field):base(name,surname,age)
        {
            Field = field;

        }
        public virtual string Info()
        {
           return $"{Name} {Surname} {Age} {Field}";
        }
    }
}
