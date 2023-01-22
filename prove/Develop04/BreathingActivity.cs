using System;

public class BreathingActivity : Activity
{
    private string _in;
    private string _out;

    public BreathingActivity(): base()
    {
        _in = "Breathe in...";
        _out = "Breathe out...";
        _activity = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

    }
    public string GetBreatheInMessage()
    {
        return ($"{_in}");
    }
    public string GetBreatheOutMessage()
    {
        return ($"{_out}");
    }
}
