using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ss = new int[0];
            while (true)
            {
                string m = Console.ReadLine();
                bool sd = int.TryParse(m, out int l);
                if (sd)
                {
                    Array.Resize(ref ss, ss.Length + 1);
                    ss[ss.Length - 1] = l;
                }
                else
                {
                    break;
                }
            }
            foreach( var item in ss)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
