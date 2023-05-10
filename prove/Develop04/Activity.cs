
public class Activity
{
    private string activityName;
    private string activityDescription;
    private int activityTime;

    public Activity(string _activityName, string _activityDesctiption, int _activityTime)
    {
        activityName        = _activityName;
        activityDescription = _activityDesctiption;
        activityTime        = _activityTime;
    }

    public void StartingMessage()
    {
        Console.WriteLine($"Welcome to the {activityName}.");
        Console.WriteLine($"{activityDescription}");
        
        Console.Write("How long, in seconds, would you like for your session to last?");
        string userInput = Console.ReadLine();
        activityTime = int.Parse(userInput);
        
        Console.WriteLine($"\nThank you, your activity will start soon");
        LoadingDots();

    }

    public void EndingMessage()
    {
        Console.WriteLine("Well done!");
        LoadingDots();
        Console.WriteLine($"You have completed another {activityTime} of the {activityName}.");
        LoadingDots();
    }

    public DateTime ActivityTime()
    {
        int seconds = activityTime;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        return endTime;
    }

    public void Spinner()
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        int i = 0;

        while (DateTime.Now < ActivityTime())
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void Countdown()
    {
        while (DateTime.Now < ActivityTime())
        {
            for (int i = 8; i > 0; i--)
            {
                Console.Write("i");
                Thread.Sleep(1000);
                Console.Write("\b \b");

                //might still need something after some testing
            }
        }
    }

    public void LoadingDots()
    {
        for (int i = 5; i > 0; i--)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
    }

   // public string DisplayStartingMessage()
   // {
   //     string startingMessage = StartingMessage();
   //     return startingMessage;
   // }

   // public string DisplayEndingMessage()
   // {
   //     string endingMessage = EndingMessage();
   //     return endingMessage;
   // }
}