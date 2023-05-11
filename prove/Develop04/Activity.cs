
public class Activity
{
    private string activityName;
    private string activityDescription;
    protected int activityTime;

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

    public DateTime ActivityLength(int activityTime)
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
        animationStrings.Add("|");
        animationStrings.Add("/");

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
    }

    public void Countdown()
    {
        for (int i = 6; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            //might still need something after some testing
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

}