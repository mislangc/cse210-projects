using System;

public class EternalGoal : Goals
{
    public EternalGoal(string goalName, string goalDescription, int goalPoints, string goalFinished): base(goalName,goalDescription,goalPoints,goalFinished)
    {

    }
    public override string GetGoalDetails()
    {
        return ($"[-] {_goalName} ({_goalDescription})");
    }
}