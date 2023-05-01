using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    public List<Entry> Entries;
    public PromptGen PromptGen;

    public Journal(PromptGen promptGen)
    {
        Entries = new List<Entry>();
        PromptGen = promptGen;
        
    }

   public void DisplayJournalEntries() 
   
{
    int count = 0;
    if (Entries.Count == 0) 
    {
        Console.WriteLine($"\nSorry, no entries were found.");
    }
    else
    {
        
        foreach (Entry entry in Entries)
        {
            Console.WriteLine($"Entry #{++count}:"); 
            entry.DisplayEntry(); 
        }
        Console.WriteLine($"\nYour total entries are: {Entries.Count}\n"); 
    }
}

    public void CreateJournalEntry()
    {
        DateTime currentDate = DateTime.Now.Date;
        string prompt = PromptGen.ChoosePrompt();

        Console.WriteLine($"{prompt}");
        string response = Console.ReadLine();

        Entry entry = new Entry(currentDate.ToString("MM/dd/yyyy"), prompt, response);
        Entries.Add(entry);

        Console.WriteLine($"\nYour entry has been added to the journal.");
    }

    public int SaveToCsv()
        {
            if (Entries.Count == 0)
            {
                Console.WriteLine($"\nNo entries to save.");
                return 0;
            }
            else
            {
                Console.WriteLine($"\nPlease enter a filename to save the journal:");
                string filename = Console.ReadLine();
                System.IO.StreamWriter file = new System.IO.StreamWriter(filename);
                foreach (Entry entry in Entries)
                {
                    file.WriteLine(entry.GetEntryAsCsv());
                }
                file.Close();
                Console.WriteLine($"\nJournal saved to {filename}.");
                return 1;
            }
        }

     public void LoadFromCsv()
        {
            Console.WriteLine($"\nPlease enter a filename to load the journal:");
            string filename = Console.ReadLine();
            System.IO.StreamReader file = new System.IO.StreamReader(filename);
            string line;
            Entries.Clear(); 
            while ((line = file.ReadLine()) != null)
            {
                string[] values = line.Split('|');
                if (values.Length == 3)
                {
                    Entry entry = new Entry(values[0], values[1], values[2]);
                    Entries.Add(entry);
                }
            }
            file.Close();
            Console.WriteLine($"\nJournal loaded from {filename}.");
        }
    }
