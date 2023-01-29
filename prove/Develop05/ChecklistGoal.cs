using System;

public class ChecklistGoal : Goals
{   
    private int _goalHowManyTimes;
    private int _goalBonusPoints;
    private int _goalHowManyTimesDone;
    public ChecklistGoal(string goalName, string goalDescription, int goalPoints, string goalFinished, int goalHowManyTimesDone, int goalHowManyTimes, int goalBonusPoints): base(goalName,goalDescription,goalPoints,goalFinished)
    {
        _goalHowManyTimes = goalHowManyTimes;
        _goalHowManyTimesDone = goalHowManyTimesDone;
        _goalBonusPoints = goalBonusPoints;
    }
    public override int GetGoalHowManyTimes()
    {
        return _goalHowManyTimes;
    }
    public override int GetGoalHowManyTimesDone()
    {
        return _goalHowManyTimesDone;
    }
    public override int GetGoalBonusPoints()
    {
        return _goalBonusPoints;
    }
    public override int AddGoalHowManyTimesDone()
    {
        return _goalHowManyTimesDone += 1;
    }
    public void SetGoalHowManyTimes()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int goalHowManyTimes = int.Parse(Console.ReadLine());
        _goalHowManyTimes = goalHowManyTimes;
    }
     public void SetGoalBonusPoints()
    {
        Console.Write("What is the bonus for accomplishing it that many times? ");
        int goalBonusPoints = int.Parse(Console.ReadLine());
        _goalBonusPoints = goalBonusPoints;
    }
    public override string GetGoalDetails()
    {
        return ($"[{_goalFinished}] {_goalName} ({_goalDescription}) - Currently completed: {_goalHowManyTimesDone}/{_goalHowManyTimes}");
    }
}