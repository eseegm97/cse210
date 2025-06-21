using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        bool running = true;

        while (running)
        {
            Console.Clear();
            menu.Display();
            int choice = menu.GetUserChoice();

            if (choice == 4)
            {
                Console.WriteLine("Thank you for using the Mindfulness App. Goodbye!");
                running = false;
            }
            else
            {
                Console.Clear();
                menu.StartSelectedActivity(choice);
                Console.WriteLine();
                Console.WriteLine("Press Enter to return to the main menu...");
                Console.ReadLine();
            }
        }
    }
}