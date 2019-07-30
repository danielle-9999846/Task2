using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter your 4 digit pin number: ");
            int pin = int.Parse(Console.ReadLine());

            if (pin > 9999 || pin < 1000)
                Console.Write("please enter your 4 digit pin number again: ");
            int pin2 = int.Parse(Console.ReadLine());
            if (pin == pin2)
                Console.WriteLine("Pin accepted");

            else
            {
                Console.WriteLine("there's an issue with your pin...");
            }
            
            
            else

             {
                Console.WriteLine("Pin accepted");
              }
            
        } 

            
        
    }
}
