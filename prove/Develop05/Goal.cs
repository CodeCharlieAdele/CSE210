
abstract class Goal
{
    private string _goalName;
    private string _goalDescription;
    private int _shownGoalPoints;
    private int _pointsTracker;

    //public List<Entry> Entries;
    List<string>goals = new List<string>();

    public Goal(string _goalName, string _goalDescription, int _shownGoalPoints, int _pointsTracker)
    {

    }


    public string GetPoints(int shownGoalPoints)
    {
       return $"You have {shownGoalPoints} points!";
    }

    public void SetPoints()
    {
        int shownGoalPoints = _shownGoalPoints;
    }

    public void DisplayGoals()
    {
        foreach (string goal in goals)
            {
                Console.WriteLine(goal);
            }
    }

    public int SaveGoals()
    {
        Console.WriteLine($"\nPlease enter a filename to save your goals to:");
            string filename = Console.ReadLine();
            System.IO.StreamWriter file = new System.IO.StreamWriter(filename);
            foreach (string goal in goals)
            {
                file.WriteLine(goal);
            }
            file.Close();
            Console.WriteLine($"\nGoals saved to {filename}.");
            return 1;
    }
    //fix this, I think I may need to make a new class for handling saving? Go over journal program and the fix the 
    //loading and saving, something is up with how i've labeled the goals list and I also need to check how im inputing
    //the data from the list to the file,a dn then out of the file.
    public void LoadGoals()
    {
        Console.WriteLine($"\nPlease enter a filename to load your goals from:");
            string filename = Console.ReadLine();
            System.IO.StreamReader file = new System.IO.StreamReader(filename);
            string line;
            goals.Clear(); 
            while ((line = file.ReadLine()) != null)
            {
                string[] values = line.Split('|');
                if (values.Length == 3)
                {
                    string goal = new Goal(values[0], values[1], values[2]);
                    goals.Add(goal);
                }
            }
            file.Close();
            Console.WriteLine($"\nGoals loaded from {filename}.");
    }
    //does RecordEvents need to be absract?
    public void RecordEvents()
    {
        string userGoal = Console.ReadLine();
        string newGoal = userGoal;
        goals.Add(newGoal);
    }

    public void DeleteGoal()
    {
        
    }

    public abstract string SetGoalValues();
}