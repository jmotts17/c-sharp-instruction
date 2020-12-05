using ch12_pr2_WizardInventory.utils;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ch12_pr2_WizardInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output welcome message
            Console.WriteLine("The Wizard Inventory Game!");

            // Variable declaration
            String response;

            // Create array list for inventory
            ArrayList inventory = new ArrayList();
            inventory.Add("wooden staff");
            inventory.Add("wizard hat");
            inventory.Add("cloth shoes");

            do
            {
                // Output menu & prompt user
                CommandMenu();
                response = Console.ReadLine();

                // Call method based on user response
                switch(response)
                {
                    case "show":
                        ShowItems(inventory);
                        break;
                    case "grab":
                        GrabItem(inventory);
                        break;
                    case "edit":
                        EditItem(inventory);
                        break;
                    case "drop":
                        DropItem(inventory);
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Invalid menu selection");
                        break;
                }

            } while (!response.Equals("exit"));

            // Output ending message
            Console.WriteLine("\nBye");
        }

        public static void CommandMenu()
        {
            Console.WriteLine("\nCOMMAND MENU");
            Console.WriteLine("show - show all items");
            Console.WriteLine("grab - Grab an item");
            Console.WriteLine("edit - Edit an item");
            Console.WriteLine("drop - Drop an item");
            Console.WriteLine("exit - Exit program");
            Console.Write("\nCommand: ");
        }

        public static void ShowItems(ArrayList inventory)
        {
            int itemCount = 1;
            foreach (String i in inventory)
            {
                Console.WriteLine(itemCount + ". " + i);
                itemCount++;
            }
        }

        public static ArrayList GrabItem(ArrayList inventory)
        {
            if(inventory.Count == 4)
            {
                Console.WriteLine("You can't carry any more items. Drop something first");
                return inventory;
            } else
            {
                Console.Write("Name: ");
                String newItem = Console.ReadLine();
                inventory.Add(newItem);
                return inventory;
            }
        }

        public static ArrayList EditItem(ArrayList inventory)
        {
            int itemNum = MyConsole.GetInt("Number: ", 1, 4);
            int selection = itemNum;
            itemNum--;
            String updateItem = MyConsole.GetString("Updated name: ");
            inventory[itemNum] = updateItem;
            Console.WriteLine("Item number " + selection + " was updated.");
            return inventory;
        }

        public static ArrayList DropItem(ArrayList inventory)
        {
            if (inventory.Count != 0)
            {
                try
                {
                    int itemNum = MyConsole.GetInt("Number: ", 1, 4);
                    itemNum--;
                    Console.WriteLine(inventory[itemNum] + " was dropped.");
                    inventory.RemoveAt(itemNum);
                } catch (Exception e)
                {
                    Console.WriteLine("No item found.");
                }
            } else
            {
                Console.WriteLine("Inventory is empty. Please add items.");
            }
            return inventory;
        }
    }
}
