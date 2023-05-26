using System;

class Program
{
    static void Main(string[] args)
    {
        int menuUserinput = 0;
        int goalMenuInput = 0;
        
        List<string> menu = new List<string>
        {
        "Please select one of the following choices:",
        "1. Create New Goal",
        "2. Show Goals",
        "3. Save Goals",
        "4. Load Goals",
        "5. Record Goal Progress",
        "6. Quit Program",
        "What would you like to do today?"
        };

        List<string> goalMenu = new List<string>
        {
            "Please select one of the following choices:",
            "1. Simple Goal",
            "2. Constant Goal",
            "3. Multi-time Goal",
            "4. Go back to main menu"
        };

        AllGoals allGoals = new AllGoals();

        //Goal.getGoalPoints();

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
                    

                    while (goalMenuInput != 4)
                    {
                        foreach (string menuItem in goalMenu)
                        {
                            Console.WriteLine(menuItem);
                        }

                        try
                        {
                            goalMenuInput = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            continue;
                        }
                        Goal goal = null;
                        switch (goalMenuInput)
                        {
                            case 1:
                                goal = new SimpleGoal();
                                if (goal != null)
                                {
                                    allGoals.addGoal(goal);
                                }
                                break;

                            case 2:
                                goal = new ConstantGoal();
                                if (goal != null)
                                {
                                    allGoals.addGoal(goal);
                                }
                                break;

                            case 3:
                                goal = new ChecklistGoal();
                                if (goal != null)
                                {
                                    allGoals.addGoal(goal);
                                }
                                break;

                            case 4:
                                Console.WriteLine("Exiting program...");
                                break;
                        }
                    }
                    break;

                case 2:
                    allGoals.DisplayGoals();
                    break;

                case 3:
                    allGoals.SaveGoals();
                    break;

                case 4:
                   allGoals.LoadGoals();
                    break;
                
                case 5:
                    allGoals.DisplayGoalsRecordEvent();
                    break;

                case 6:
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
                    break;
            }
        }
    }
}
