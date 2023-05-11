
public class ListingActivity : Activity
{

    public ListingActivity(string _activityName, string _activityDesctiption, int _activityTime) : base(_activityName, _activityDesctiption, _activityTime)
    {
        //_activityName = "Listing Activity";
       // _activityDesctiption = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    List <string> userListing = new List<string>{};

    List <string> listingPrompt = new List<string>
    {
        "Who are people that you appreciate?",
        "What are some personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"

    };

    public void RandomListingPrompt() 
    {
        Random rand = new Random();
        int index = rand.Next(listingPrompt.Count);
        string listPrompt = listingPrompt[index];
        Console.WriteLine($"\n{listPrompt}");
    }
    public void UserList()
    {
        Console.Write(">");
        string input = Console.ReadLine();
        userListing.Add(input);
    }

    public void RunListing()
    {
        StartingMessage();
        RandomListingPrompt();
        Countdown();
        while (DateTime.Now < ActivityLength(activityTime))
        {
            UserList();
        }
        Console.WriteLine($"You listed {userListing.Count} things.");
        EndingMessage();
    }


}