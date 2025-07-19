using System;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running();
        run.SetDate("2025-07-11");
        run.SetMinutes(30);
        run.SetDistance(5.0);

        Cycling cycle = new Cycling();
        cycle.SetDate("2025-07-12");
        cycle.SetMinutes(45);
        cycle.SetSpeed(20.0);

        Swimming swim = new Swimming();
        swim.SetDate("2025-07-13");
        swim.SetMinutes(60);
        swim.SetLaps(40);

        List<Activity> activities = new List<Activity> { run, cycle, swim };

        foreach (Activity act in activities)
        {
            Console.WriteLine(act.GetSummary());
        }
    }
}