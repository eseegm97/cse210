using System;

public class MindfulnessActivity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void SetDuration(int seconds)
    {
        _duration = seconds;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the " + _name + ".");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How many seconds would you like for this session? ");
        int seconds = int.Parse(Console.ReadLine());
        SetDuration(seconds);

        Console.WriteLine("Get ready to begin...");
        PauseWithSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        PauseWithSpinner(2);
        Console.WriteLine("You have completed the " + _name + " for " + _duration + " seconds.");
        PauseWithSpinner(3);
    }

    public void PauseWithSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < end)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(250);
            Console.Write("\b");
            i = (i + 1) % spinner.Length;
        }
    }

    public void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public virtual void Run()
    {
        
    }
}