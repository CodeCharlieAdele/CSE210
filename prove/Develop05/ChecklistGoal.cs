
class ChecklistGoal : Goal
{
    
    private const int goalType = 3;
    private int completionPoints = 0;
    private int goalTracker = 0;
    private int goalLength = 0;
    
    private bool goalComplete;
    
    public ChecklistGoal()
    {
        goalComplete = false;
        DisplayGetGoalName();
        DisplayGetGoalDescription();
        DisplayGetGoalPoints();
        DisplayGetGoalLength();
        //bonuspoints
    }
    public ChecklistGoal(string _goalName, string _goalDescription, int _points, bool _goalComplete) 
    : base(_goalName, _goalDescription, _points)
    {
        goalComplete = _goalComplete;
    }

    public void DisplayGetGoalLength()
    {
        Console.Write("How many times do you need to do this task before it's completed?");
        goalLength = int.Parse(Console.ReadLine());
    }

   // public void GoalLengthChecker()
   // {
   // 
   // }

   //public override string SetGoalValues()
   //{
   //    throw new NotImplementedException();
   //}

    public override string ToCVSRecord()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4}", goalType, getGoalName(), getGoalDescription(), getGoalPoints(), goalComplete);
    }

    public override string ToString()
    {
        return string.Format("[{0}] {1} ({2})", ((goalComplete == false) ? " " : "X"), getGoalName(), getGoalDescription());
    }

    public override void RecordEvent()
    {
        goalTracker ++;

        if (goalTracker == goalLength)
        {
            Console.WriteLine($"Congratulations! You've completed the goal! You have earned {getGoalPoints} points!");
            goalComplete = true;
        }
    }
}