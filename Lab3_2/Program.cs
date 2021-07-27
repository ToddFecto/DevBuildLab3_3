using System;
using System.Collections.Generic;

namespace Lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary of cars
            // Keys are strings representing VIN number
            // Values are strings representing. make and Model (e.g. "Chevy Trax" or "Honda Civic")
            // CRUD = Create, Read, Update, Delete
            
                Dictionary<string, string> items = new Dictionary<string, string>();
                items["TurkeySub"] = "5.99";
                items["ItalianSub"] = "7.99";
                items["ChickenSub"] = "6.99";
                items["SteakSub"] = "8.99";
                items["TunaSub"] = "7.50";

            Dictionary<string, string> actions = new Dictionary<string, string>();
                actions["AddItem   "] = "A";
                actions["RemoveItem"] = "R";
                actions["ChangeItem"] = "C";
                actions["Quit      "] = "Q";

                    Console.WriteLine("Here are our menu items and their prices:");
                foreach (var pair in items)
                {
                    Console.WriteLine($"{pair.Key} \t ${pair.Value}");
                }

                    Console.WriteLine("\nPlease choose an option from our system menu:");
                foreach (var pair in actions)
                {
                    Console.WriteLine($"To {pair.Key} press\t'{pair.Value}'");
                }
                    Console.Write("\nEnter choice: ");
                    string choice = Console.ReadLine();

                if (choice == "A" || choice == "a")
                {
                    //Console.WriteLine("You entered A");
                    Console.WriteLine("\nYou chose to add a new menu item.");
                    Console.Write("Enter the menu item name: ");
                    string food = Console.ReadLine();
                    Console.Write("Enter the item price: ");
                    string price = Console.ReadLine();
                    items[food] = price;

                    Console.WriteLine("\nHere are our menu items and their prices:");
                    foreach (var pair in items)
                    {
                        Console.WriteLine($"{pair.Key} \t ${pair.Value}");
                    }

                }
                else if (choice == "R" || choice == "r")
                {
                    //Console.WriteLine("You entered R");
                    Console.WriteLine("\nYou chose to remove a menu item.");
                    Console.Write("Enter the menu item to remove: ");
                    string Remfood = Console.ReadLine();
                    items.Remove(Remfood);

                    Console.WriteLine("\nHere is our updated menu items and their prices:");
                    foreach (var pair in items)
                    {
                        Console.WriteLine($"{pair.Key} \t ${pair.Value}");
                    }
                }
                else if (choice == "C" || choice == "c")
                {
                    Console.WriteLine("You entered C");
                }
                else if (choice == "Q" || choice == "q")
                {
                    Console.WriteLine("You entered Q");
                }
                else
                {
                    Console.WriteLine("You entered something else");
                }
                /*
                Console.WriteLine("\nHere are all the VINS");
                foreach (var pair in cars)
                {
                    Console.WriteLine(pair.Key);
                }

                //Let's delete the Honda Civic
                cars.Remove("OJFKGHT5");

                while (true)
                {
                    Console.WriteLine("\nLet's add a new car");
                    Console.Write("Enter the VIN: ");
                    string vin = Console.ReadLine();
                    Console.Write("Enter the Make and Model: ");
                    string mm = Console.ReadLine();
                    cars[vin] = mm;

                    Console.WriteLine("\nHere are the make and model of the cars");
                    foreach (var pair in cars)
                    {
                        Console.WriteLine($"{pair.Key} is a {pair.Value}");
                    }*/
            }
    }
}
