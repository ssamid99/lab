using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        
        //static void Main(string[] args)
        //{


        //    //int oldreqem;
        //    //Outt(out oldreqem);
        //    //Console.WriteLine(oldreqem);
        //}
        //public static void Reff(ref int reqem)
        //{
        //    bool succ = int.TryParse(Console.ReadLine(), out reqem);
        //    if (succ)
        //    {
        //        reqem++;
        //        Console.WriteLine(reqem);
        //    }
        //}

        //static void Outt(out int deyer)
        //{
        //    ERROR1:
        //    try
        //    {
        //        string user = Console.ReadLine();
        //        int convert = int.Parse(user);
        //        deyer = convert;
        //    }
        //    catch(Exception)
        //    {
        //        goto ERROR1;
        //    }
        //}

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("daxil et");
            string value1 = Console.ReadLine();
            double value = Convert.ToDouble(value1);

            //Console.WriteLine(value.ToString("C"));
            //Console.WriteLine(value.ToString("C3"));
            Console.WriteLine($"CURRENT CULTURE: {CultureInfo.CurrentCulture.Name}");
            Console.WriteLine(value);
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("de-DE");

            Console.WriteLine($"Current culture: {CultureInfo.CurrentCulture.Name}");
            Console.WriteLine(value);
            Console.WriteLine($"{value:c}");


            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("az-Latn-AZ");

            Console.WriteLine($"Current culture: {CultureInfo.CurrentCulture.Name}");

            Console.WriteLine($"{value:c}");
            
        }

    }
}
