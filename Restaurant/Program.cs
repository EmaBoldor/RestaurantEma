using System;
using System.Collections.Generic;

namespace RestaurantConsoleApp
{
    class Program
    {
        public static List<Product> list;
        static void Main(string[] args)
        {
            list = Menu.getMenuElements();

            Console.WriteLine("Do you want something?");

            string answer = Console.ReadLine();
            bool Out = true;

            do
            {
                if (!Out && answer != "yes") answer = Console.ReadLine();
                switch (answer)
                {
                    case "no":
                        Console.WriteLine("Ok! Goodbye !");
                        Out = true;
                        break;
                    case "yes":
                        Console.WriteLine("What do you want?");
                        Out = true;

                        break;
                    default:
                        Console.WriteLine("Please type 'yes' or 'no'");
                        Out = false;
                        break;
                }
            } while (!Out);


        }

        
    }
}
