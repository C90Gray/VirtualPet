using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Virtual Pet! \n\nTo begin you will choose a pet.");
            Console.WriteLine("\n\nWhich pet would you like to adopt?");
            Console.WriteLine("For Larry the Lion, please enter 1");
            Console.WriteLine("For Melvin the Monkey, please enter 2");
            Console.WriteLine("For Cletus the Camel, please enter 3");
            int name = int.Parse(Console.ReadLine());
            string petName;
            switch (name)
            {
                case 1:
                    petName = "LarryLion"; 
                    Console.WriteLine("You picked Larry the Lion! He's a wild beast... and I ain't lion...");
                    Console.WriteLine("");
                    break;
                case 2:
                    petName = "MelvinMonkey";
                    Console.WriteLine("You picked Melvin the Monkey! You're bananas!");
                    Console.WriteLine("");
                    break;
                case 3:
                    petName = "CletusCamel";
                    Console.WriteLine("You picked Cletus the Camel! Don't ever dessert him.");
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("You stink at following directions. Please close the program and try again.");
                    break;
                    
            }

            
        }
    }
}
