using System;
using System.IO;
using System.Collections.Generic;

namespace Journal
{

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\JournalEntries";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            List<Entry> entries = new List<Entry>();

            while (true)
            {
                Console.WriteLine("\nMenu:\n1. Add new a new journal entry\n2. Display journal entries\n3. Save journal to a file\n4. Load journal from a file\n5. Exit Journal");

                int choice = int.Parse(Console.ReadLine());

                string chosenPrompt = "";

                switch (choice)
                {
                    case 1:
                        Console.Write("Pick a prompt 1-5, or enter 6 for no prompt: ");
                        int promptChoice = int.Parse(Console.ReadLine());

                        if (promptChoice == 1)
                        {
                            chosenPrompt = "Who was the most interesting person you saw today?";
                            Console.WriteLine($"{chosenPrompt}");
                        }
                        else if (promptChoice == 2)
                        {
                            chosenPrompt = "What sparked curiosity in you today?";
                            Console.WriteLine($"{chosenPrompt}");
                        }
                        else if (promptChoice == 3)
                        {
                            chosenPrompt = "Name two things that felt meaningful about today.";
                            Console.WriteLine($"{chosenPrompt}");
                        }
                        else if (promptChoice == 4)
                        {
                            chosenPrompt = "What made you laugh today?";
                            Console.WriteLine($"{chosenPrompt}");
                        }
                        else if (promptChoice == 5)
                        {
                            chosenPrompt = "What was the tastiest thing you ate today?";
                            Console.WriteLine($"{chosenPrompt}");
                        }
                        else
                        {
                            Console.WriteLine("No prompts, just thoughts.");
                        }

                        Console.WriteLine("Thoughts:");
                        string response = Console.ReadLine();

                        Entry entry = new Entry(chosenPrompt, response, DateTime.Now);
                        entries.Add(entry);

                        Console.WriteLine("Your entry had been added.");
                        break;

                    case 2:
                        if (entries.Count == 0)
                        {
                            Console.WriteLine("No entries found.");
                            break;
                        }

                        Console.WriteLine($"You've made {entries.Count} entries so far. \n");

                        foreach (Entry e in entries)
                        {
                            Console.WriteLine($"Date: {e.Date}\nPrompt: {e.Prompt}\nResponse: {e.Response}\n");
                        }

                        break;

                    case 3:
                        Console.WriteLine("Enter a filename to save the journal to:");
                        string fileName = Console.ReadLine();

                        Console.WriteLine("Saving...");

                        string fullPath = Path.Combine(path, fileName);

                        using (StreamWriter writer = new StreamWriter(fullPath))
                        {
                            foreach (Entry e in entries)
                            {
                                writer.WriteLine($"Prompt: {e.Prompt}");
                                writer.WriteLine($"Response: {e.Response}");
                                writer.WriteLine($"Date: {e.Date}");
                            }
                        }

                        Console.WriteLine($"Your journal is saved to {fullPath}.");

                        break;

                    case 4:
                        Console.WriteLine("Enter a filename to load your journal:");
                        fileName = Console.ReadLine();

                        Console.WriteLine("Thanks, you're ready to write!");

                        fullPath = Path.Combine(path, fileName);

                        if (!File.Exists(fullPath))
                        {
                            Console.WriteLine($"Ope, file {fullPath} not found.");
                            break;
                        }

                        entries.Clear();

                        using (StreamReader reader = new StreamReader(fullPath))
                        {
                            while (!reader.EndOfStream)
                            {
                                string p = reader.ReadLine().Substring(8);
                                string r = reader.ReadLine().Substring(10);
                                DateTime d = DateTime.Parse(reader.ReadLine().Substring(6));

                                Entry e = new Entry(p, r, d);
                                entries.Add(e);
                            }
                        }

                        Console.WriteLine($"Journal loaded from {fullPath}");

                        break;

                    case 5:
                        Console.WriteLine("Exiting program.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}