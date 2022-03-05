using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Engenering:Doctor
    {
        public string Adress { get; set; }
        public Engenering(string name, string surname, int age, string field, string adress):base(name,surname,age,field)
        {
            this.Adress = adress;
        }
        public virtual string Info()
        {
            return $"{Name} {Surname} {Age} {Field} {Adress}";
        }
    }
}
