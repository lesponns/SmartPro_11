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
            string message;

            Console.Write("Metin giriniz: ");
            message = Console.ReadLine();
            
            Console.Clear();
            Console.Write("Repeat: ");
            repeater = int.Parse(Console.ReadLine());

            Console.Clear();
            for (int i = 1; i <= repeater; i++) { 
                Console.WriteLine(i+". "+message); 
            }
            Console.ReadKey();
        }
    }
}
