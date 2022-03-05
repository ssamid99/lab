using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            person Person1 = new person("qwe", "qqq", 16);
            Console.WriteLine(Person1.Info());
            Doctor doctor1 = new Doctor("qwe", "qqq", 16, "field");
            Console.WriteLine(doctor1.Info());
            Engenering enginer1 = new Engenering("qwe", "qqq", 16, "field", "12KG,street");
            Console.WriteLine(enginer1.Info());
        }
    }
}
