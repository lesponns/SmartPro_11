using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //i++ = i+1
            int repeater;

            Console.WriteLine("Kaç kez tekrarlansın?");
            Console.Write("==> ");
            repeater = int.Parse(Console.ReadLine());

            repeater++;
            for (int i = 1; i < repeater; i++)
            {
                Console.WriteLine(i+". Murat");
            }
            Console.ReadKey();
        }
    }
}
