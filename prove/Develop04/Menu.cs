using System;

public class Menu
{
    public void Display()
    {
        Console.WriteLine("Mindfulness App");
        Console.WriteLine("================");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine();
        Console.Write("Select an option (1-4): ");
    }

    public int GetUserChoice()
    {
        while (true)
        {
            string input = Console.ReadLine();

            int choice;
            bool isValid = int.TryParse(input, out choice);

            if (isValid && choice >= 1 && choice <= 4)
            {
                return choice;
            }
            else
            {
                Console.Write("Invalid input. Please enter a number between 1 and 4: ");
            }
        }
    }

    public void StartSelectedActivity(int choice)
    {
        MindfulnessActivity activity;

        if (choice == 1)
        {
            activity = new BreathingActivity();
        }
        else if (choice == 2)
        {
            activity = new ReflectionActivity();
        }
        else if (choice == 3)
        {
            activity = new ListingActivity();
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        activity.Run();
    }
}