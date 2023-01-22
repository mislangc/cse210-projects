using System;

public class Assignment 
{
    protected string _studentName;
    protected string _topic;

    public Assignment()
    {
        _studentName = "Anonymous Name";
        _topic = "Unknown";
    }
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
    public string GetSummary()
    {
        return ($"{_studentName} - {_topic}");
    }


}