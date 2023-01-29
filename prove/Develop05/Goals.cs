using System;

public abstract class Goals
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints;
    protected string _goalFinished = " ";

    public Goals(string goalName, string goalDescription, int goalPoints, string goalFinished)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
        _goalFinished = goalFinished;
    }
    public void SetGoalName()
    {   
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        _goalName = goalName;
    }
    public string GetGoalName()
    {
        return _goalName;
    }
    public void SetGoalDescription()
    {
         Console.Write("What is the short description of it? ");
        string goalDescription = Console.ReadLine();
        _goalDescription = goalDescription;
    }
    public string GetGoalDescription()
    {
        return _goalDescription;
    }
    
    public void SetGoalPoints()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        int goalPoints = int.Parse(Console.ReadLine());
        _goalPoints = goalPoints;
    }
    public int GetGoalPoints()
    {
        return _goalPoints;
    }
    public void SetGoalFinished(string goalFinished)
    {
        _goalFinished = goalFinished;
    }
    public string GetGoalFinished()
    {
        return _goalFinished;
    }
    public abstract string GetGoalDetails();
    public virtual int GetGoalHowManyTimes(){return 0;}
    public virtual int GetGoalHowManyTimesDone(){return 0;}
    public virtual int GetGoalBonusPoints(){return 0;}
    public virtual int AddGoalHowManyTimesDone(){return 0;}
}
