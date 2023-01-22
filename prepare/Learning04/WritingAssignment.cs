using System;

public class WritingAssignment : Assignment
{
    protected string _title;

    public WritingAssignment() : base()
    {
        _title = "No Title";
    }
    public WritingAssignment(string name, string topic, string title) : base(name,topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return ($"{_studentName} - {_topic}: {_title} by {_studentName}");
    }
}