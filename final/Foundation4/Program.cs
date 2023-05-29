using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

            activities.Add(new RunningActivity(new DateTime(2023, 04, 27), 15, 1));
            activities.Add(new CyclingActivity(new DateTime(2023, 05, 01), 60, 15));
            activities.Add(new SwimmingActivity(new DateTime(2023, 05, 03), 45, 25));

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
    }
}