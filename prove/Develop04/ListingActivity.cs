
public class ListingActivity
{

        List <string> listingPrompt = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"

    };

    public string RelfectionPrompt() 
    {
        Random rand = new Random();
        int index = rand.Next(listingPrompt.Count);
        return listingPrompt[index];
    }
    public void UserList()
    {
        Console.WriteLine("Please start listing:");
        Console.Write("1. ");
        
    }


}