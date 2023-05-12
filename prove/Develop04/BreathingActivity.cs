
public class BreathingActivity : Activity
{
    public BreathingActivity(string _activityName, string _activityDesctiption, int _activityTime) : base(_activityName, _activityDesctiption, _activityTime)
    {
       // _activityName = "Breathing Activity";
       // _activityDesctiption = "This activity will help you relax by walking you through breathing in and out slowly. CLear your mind and focus on your breathing.";

    }

    public void BreatheIn()
    {
        Console.Write($"\nBreathe in...");
        Countdown();
    }

    public void BreatheOut()
    {
        Console.Write($"\nBreathe out...");
        Countdown();
    }

    public void RunBreathing()
    {
        StartingMessage();
        DateTime endTime = ActivityLength();
        while (startTime < endTime)
        {
            BreatheIn();
            startTime = DateTime.Now;
            BreatheOut();
            startTime = DateTime.Now;
        }
        EndingMessage();
    }

}