using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. CLear your mind and focus on your breathing.", 0);
        ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
        ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);

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
                    breathingActivity.RunBreathing();
                    break;

                case 2:
                    reflectionActivity.RunReflection();
                    break;

                case 3:
                    listingActivity.RunListing();
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