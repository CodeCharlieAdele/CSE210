using System;

class Program
{
    static void Main(string[] args)
    {
        //Goal goal = new Goal();
        
        
        
        int menuUserinput = 0;

        Goal.GetPoints();
        
        List<string> menu = new List<string>
        {
        "Please select one of the following choices:",
        "1. Create New Goal",
        "2. Show Goals",
        "3. Save Goals",
        "4. Load Goals",
        "5. Record Goal Progress",
        "6. Delete Goal From List",
        "7. Quit Program",
        "What would you like to do today?"
        };

     while (menuUserinput != 7)
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
                    Goal.SetGoalValues();
                    break;

                case 2:
                    Goal.DisplayGoals();
                    break;

                case 3:
                    Goal.SaveGoals();
                    break;

                case 4:
                    Goal.LoadGoals();
                    break;
                
                case 5:
                    Goal.RecordEvents();
                    break;

                case 6:
                    Goal.DeleteGoal();
                    break;

                case 7:
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                    break;
            }
        }
    }
}