using System;

public class SimpleGoal : Goals
{
    public SimpleGoal(string goalName, string goalDescription, int goalPoints, string goalFinished): base(goalName,goalDescription,goalPoints,goalFinished)
    {

    }
    public override string GetGoalDetails()
    {
        return ($"[{_goalFinished}] {_goalName} ({_goalDescription})");
    }
}