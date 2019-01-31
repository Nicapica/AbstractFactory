//Author: Nicholas Pica
//FileName: Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What brand of smart phone would you like to view?");
            Console.WriteLine(" Samsung");
            Console.WriteLine(" HTC");
            Console.WriteLine(" Nokia");
            Console.WriteLine("press 's' for 'Samsung', 'h' for 'HTC', and 'n' for 'Nokia'");
            string phone;
            phone = Console.ReadLine();

            if (phone == "s")
            {
                
            }
            
            else if (phone == "h")
            {
               
            }

            else if (phone == "n")
            {
               
            }

            else
            
            {
                Console.WriteLine("\nIncorrect answer please try again!");
            }
        }
    }
}
