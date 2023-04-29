using System;
using System.Collections.Generic;
using System.IO;

//lass Journal
//
//   List<Entry> entries;
//
//   public Journal()
//   {
//       
//   }
//
//   public void DisplayJournalEntires()
//   {
//       foreach (Entry e in entries)
//       {
//           e.DisplayEntry();
//       }
//   }
//
//   public void CreateJournalEntry()
//   {
//       List<Entry
//   }
//
//   public void SaveToFile(List<Entry> entries)
//   {
//       Console.Write("Please enter new filename: ");
//       string newFile = Console.ReadLine();
//
//       Console.WriteLine("Saving to file...");
//       string filename = newFile + ".txt";
//
//       using (StreamWriter outputFile = new StreamWriter(filename))
//       {
//           foreach (Entry e in entries)
//           {
//               outputFile.WriteLine($"{_date}~~{_prompt}~~{_response}");
//           }
//       }
//
//       Console.WriteLine($"File saved as {filename}.");
//   }
//
//   public static List<Entry> LoadFromFile()
//   {
//       List<Entry> entries = new List<Entry>();
//       
//       return entries;
//   }
//