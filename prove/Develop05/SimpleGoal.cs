
abstract class SimpleGoal : Goal
{
    private bool _isComplete;
    
    public SimpleGoal(string _goalName, string _goalDescription, int _shownGoalPoints, int _pointsTracker, bool _isComplete) : base(_goalName, _goalDescription, _shownGoalPoints, _pointsTracker)
    {

    }

    public void SimpleGoalSetter()
    {

    }
}