using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        DateTime schedule = new DateTime(2023, 07, 06, 12, 00, 00);
        Address location = new Address("123 Florida Way", "Florida", "USA", "34787");
        events.Add(new LectureEvent("How to Have the Best Retirement in Florida", "Learn the secrets you can unlock in Florida with YouTube sensation 'The Old Retired Guy'!", schedule, schedule, location, "The Old Retired Guy", 400));

        events.Add(new OutdoorEvent("How to Attract Retired Shawtys", "Learn to have game, even at 65+", schedule, schedule, location, "Expect a hurricane, or sun."));

        events.Add(new ReceptionEvent("PitBull Comes to Town", "Florida native PitBull is back in town!", schedule, schedule, location, "SeeThePit@Bull.email.com"));

        foreach (Event e in events)
        {
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Standard Details\n~~~~~~~~~~~~~~~~\n{e.GetStandardDetails()}\n");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Full Details\n~~~~~~~~~~~~\n{e.GetFullDetails()}\n");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Short Description\n~~~~~~~~~~~~~~~~~\n{e.GetShortDetails()}\n");
            Console.WriteLine("\n");
        }
    }
}