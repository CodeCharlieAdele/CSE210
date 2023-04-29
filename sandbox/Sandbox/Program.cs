using System;



    static void Main(string[] args)
    {
        Journal         journal = new Journal();
        int             menuUserInput = 0;

        List<string>    menu = new List<string>
            {
                "Please select one of the following choices:",
                "1. Write",
                "2. Display Entries",
                "3. Load",
                "4. Save",
                "5. Quit",
                "What would you like to do?"
            };
    }

class Prompts
{
    static void Main(string[] args)
    {
        
        int promptIndex = rnd.Next(journalPrompts.Length);
        string[] journalPrompts = 
        {
            "Who was the most interesting person you saw today?",
            "What sparked curiosity in you today?",
            "Name two things that felt meaningful about today.",
            "What made you laugh today?",
            "What was the tastiest thing you ate today?",
            "If you could do anything you wanted right now, what would it be?",
            "What are three things you've felt grateful for today?" 
        };


        Console.WriteLine("   Today's prompt is:     {0}", journalPrompts[promptIndex]);
        
    }
}

class Entry
{

    string date, prompt, response;

    public Entry(string _date, string _prompt, string _response)
    {

        Entry e1 = new Entry();
        e1._date = DateTime.Now;
        e1._prompt = "";
        e1._response = Console.ReadLine;

        List<Entry> entries = new List<Entry>();
        entries.Add(e1);
    }

    public void DisplayEntry()
    {
        foreach (Entry e in entries)
        {
            Console.WriteLine(e);
        }
    }

    public string getEntryAsCSV()
    {
        return string.Format("{0}|{1}|{2}", date, prompt, response);
    }
}