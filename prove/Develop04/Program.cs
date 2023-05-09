using System;

class Program
{
    static void Main(string[] args)
    {
        int menuUserinput = 0;
        
        List<string> menu = new List<string>
        {
        "Please select one of the following choices:",
        "1. Breathing Activity",
        "2. Reflection Activity",
        "3. Listing Activity",
        "4. Quit",
        "What would you like to do today?"
        };

     while (menuUserinput != 4)
        {
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }

            try
            {
                menuUserinput = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (menuUserinput)
            {
                case 1:
                    Console.WriteLine("working 1");
                    break;

                case 2:
                    Console.WriteLine("working 2");
                    break;

                case 3:
                    Console.WriteLine("working 3");
                    break;

                case 4:
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }
}