using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal(new PromptGen());
        int menuUserinput = 0;

        List<string> menu = new List<string>
        {
        "Please select one of the following choices:",
        "1. Write in the journal",
        "2. Display your journal entries",
        "3. Load a saved journal file",
        "4. Save to a file",
        "5. Quit",
        "What would you like to do today?"
        };

     while (menuUserinput != 5)
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
                    journal.CreateJournalEntry();
                    break;

                case 2:
                    journal.DisplayJournalEntries();
                    break;

                case 3:
                    journal.LoadFromCsv();
                    break;

                case 4:
                    journal.SaveToCsv();
                    break;

                case 5:
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}