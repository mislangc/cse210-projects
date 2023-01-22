using System;

public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignment() : base()
    {
        _textBookSection = "None";
        _problems = "None";
    }
    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic)
    {
        _textBookSection = section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return ($"{_studentName} - {_topic}: Section {_textBookSection} Problem {_problems}");
    }
}