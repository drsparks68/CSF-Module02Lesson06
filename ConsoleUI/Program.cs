using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            string quitORnot = "";



            do
            {
                Console.WriteLine("Hello! Please enter your name:");
                string fName = Console.ReadLine();
                if (fName.To = "")
                Console.WriteLine($"Hello {fName}!  Please type exit at the prompt to quit. Type anything else to run again.");
                quitORnot = Console.ReadLine();
            } (quitORnot.ToLower("exit"));
             
            Console.ReadKey();
        }
    }
}
