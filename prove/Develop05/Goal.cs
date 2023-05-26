
abstract class Goal
{
    private string goalName = "";
    private string goalDescription = "";
    private int goalPoints = 0;

    //public List<Entry> Entries;

    public Goal()
    {
        
    }
    public Goal(string _goalName, string _goalDescription, int _points)
    {
        goalName        = _goalName;
        goalDescription = _goalDescription;
        goalPoints      = _points;
    }

    public void DisplayGetGoalName()
    {
        Console.Write("What is the name of your goal? ");
        goalName = Console.ReadLine();
    }

    public void DisplayGetGoalDescription()
    {
        Console.Write("What is a short description of your goal? ");
        goalDescription = Console.ReadLine();
    }

    public void DisplayGetGoalPoints()
    {
        Console.Write("What is the amount of points associacted with this goal? ");
        goalPoints = int.Parse(Console.ReadLine());
    }

    public abstract string ToCVSRecord();

    public abstract void RecordEvent();
    
    public string getGoalName()
    {
        return goalName;
    }

    public string getGoalDescription()
    {
        return goalDescription;
    }
    public int getGoalPoints()
    {
       return goalPoints;
    }

    public override bool Equals(object obj)
    {
        Goal otherGoal = (Goal) obj;
        bool retValue = false;

        if (goalName == otherGoal.getGoalName() &&
            goalDescription == otherGoal.getGoalDescription())
        {
            retValue = true;
        }
        return retValue;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}