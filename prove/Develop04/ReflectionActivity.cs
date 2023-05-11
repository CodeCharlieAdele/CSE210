
public class ReflectionActivity : Activity
{

        public ReflectionActivity(string _activityName, string _activityDesctiption, int _activityTime) : base(_activityName, _activityDesctiption, _activityTime)
    {
        //_activityName = "Reflection Activity";
        //_activityDesctiption = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    }
    
    List <string> reflectionPrompt = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };

    List <string> Questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    public void RandomRelfectionPrompt() 
    {
        Random rand = new Random();
        int index = rand.Next(reflectionPrompt.Count);
        string prompt = reflectionPrompt[index];
        Console.WriteLine($"{prompt}");
    }
    public void RandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(Questions.Count);
        string question = Questions[index];
        Console.WriteLine($"\n{question}");
    }

    public void RunReflection()
    {
        StartingMessage();
        RandomRelfectionPrompt();
        while (DateTime.Now < ActivityLength(activityTime))
        {
            Spinner();
            RandomQuestion();
        }
        EndingMessage();
    }

}