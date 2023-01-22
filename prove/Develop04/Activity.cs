using System;

public class Activity
{
    protected string _activity;
    protected string _description;
    private int _duration;

    public Activity()
    {
        _activity = "No activity";
        _description = "No desctiption";
        _duration = 0;
    }
    public Activity(string activity, string desctiption, int duration)
    {
        _activity = activity;
        _description = desctiption;
        _duration = duration;
    }
    public string GetWelcomeMessage()
    {
        return ($"Welcome to the {_activity} activity.");
    }
    public string GetDescription()
    {
        return ($"{_description}");
    }
    public string GetDurationMessage()
    {
        return ("How long, in seconds, would you like for your session? ");
    }
    public string GetEndingMessage(int duration)
    {
        _duration = duration;
        return ($"You have completed another {_duration} seconds of the {_activity} activity.");
    }
    //Special Messages
    public string GetReadyMessage()
    {
        return ("Get Ready...");
    }
    public string GetWellDoneMessage()
    {
        return ("Well Done!!");
    }
    public string GetBeginMessage()
    {
        return ($"You may begin in: ");
    }
    //Pause Animations
    public void ShowSpinner(int countdown)
    {
        int count = 0;
        while (count != countdown)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            count += 1;
        }
    }
    public void ShowNumberCountdown(int countdown)
    {
        int count = 0;
        while (count != countdown)
        {
            Console.Write(countdown);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            countdown -= 1;
        }
    }


}