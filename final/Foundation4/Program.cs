using System;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running();
        run._setDate("2025-07-11");
        run._setMinutes(30);
        run._setDistance(5.0);

        Cycling cycle = new Cycling();
        cycle._setDate("2025-07-12");
        cycle._setMinutes(45);
        cycle._setSpeed(20.0);

        Swimming swim = new Swimming();
        swim._setDate("2025-07-13");
        swim._setMinutes(60);
        swim._setLaps(40);

        List<Activity> activities = new List<Activity> { run, cycle, swim };

        foreach (Activity act in activities)
        {
            Console.WriteLine(act._getSummary());
        }
    }
}