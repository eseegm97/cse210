using System;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void Run()
    {
        DisplayStartingMessage();

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            PauseWithCountdown(3);
            elapsed += 3;

            if (elapsed >= _duration) break;

            Console.Write("Now breathe out...");
            PauseWithCountdown(3);
            elapsed += 3;
        }

        DisplayEndingMessage();
    }
}