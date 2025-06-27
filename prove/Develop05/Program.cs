using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        int choice;

        do
        {
            Console.WriteLine("\n--- Eternal Quest ---");
            Console.WriteLine($"Score: {manager.GetScore()}");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Goal Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: CreateGoal(manager); break;
                case 2: Console.WriteLine(manager.ShowGoals()); break;
                case 3:
                    Console.WriteLine(manager.ShowGoals());
                    Console.Write("Enter goal number to record: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(index);
                    break;
                case 4: manager.Save(); break;
                case 5: manager.Load(); break;
            }
        } while (choice != 6);
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            manager.AddGoal(new SimpleGoal(title, desc, points));
        }
        else if (type == 2)
        {
            manager.AddGoal(new EternalGoal(title, desc, points));
        }
        else if (type == 3)
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            manager.AddGoal(new ChecklistGoal(title, desc, points, target, bonus));
        }

        Console.WriteLine("Goal created!");
    }
}