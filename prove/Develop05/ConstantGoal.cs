
class ConstantGoal : Goal
{
    private const int goalType = 2;
    
    private bool goalComplete;
    
    public ConstantGoal()
    {
        goalComplete = false;
        DisplayGetGoalName();
        DisplayGetGoalDescription();
        DisplayGetGoalPoints();
    }
    public ConstantGoal(string _goalName, string _goalDescription, int _points, bool _goalComplete) 
    : base(_goalName, _goalDescription, _points)
    {
        goalComplete = _goalComplete;
    }
    
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
        Console.WriteLine(string.Format("Congratulations! you have earned {0}", getGoalPoints()));
        goalComplete = true;
    }
}