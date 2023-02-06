using System;

public abstract class Filename
{
    protected string _filename;
    private string _message;

    public Filename()
    {
        _filename = "newSave.txt";
        _message = "What is the name of the file? ";
    }
    public Filename(string filename, string message)
    {
        _filename = filename;
        _message = message;
    }
    public void GetSetFileName()
    {
        Console.Write(_message);
        _filename = Console.ReadLine();

    }
    public abstract void DoToFile(Player player);
}