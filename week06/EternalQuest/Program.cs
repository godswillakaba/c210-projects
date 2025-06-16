using System;

// For creativity I added;
// Gamification ideas: [∞] for eternal, checklist show progress like Completed 3/5
// Extendable serialization for future goal types
// Option to save / load using files
// Points feedfack after each recorded event

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool running = true;
        while(running) 
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Events");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");

            Console.Write("Please choose an option:  ");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1" : Console.WriteLine("Goal Types: 1=Simple, 2=Eternal, 3=Checklist");
                string type = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Descripion: ");
                string desc = Console.ReadLine();
                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (type =="1")
                {
                    manager.AddGoal(new SimpleGoal(name, desc, points));
                }

                else if (type =="2")
                {
                    manager.AddGoal(new EternalGoal(name, desc, points));
                }

                else if (type =="3")
                {
                    Console.Write("Target Count:  ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("Bonus Points:  ");
                    int bonus = int.Parse(Console.ReadLine());

                    manager.AddGoal(new CheckListGoal(name, desc, points, target, bonus));
                }

                break;

                case "2" : manager.ShowGoals();
                break;

                case "3" : 
                Console.Write("Which goal did you accomplish?");
                int index = int.Parse(Console.ReadLine()) -1;
                manager.RecordGoal(index);

                break;

                case "4" : manager.DisplayScore();
                break;

                case "5" : Console.Write("Please enter file name to save:  ");
                manager.SaveGoals(Console.ReadLine());
                break;

                case "6" : Console.Write("Filename to load:  ");
                manager.LoadGoals(Console.ReadLine());
                break;

                case "7" : running = false;
                break;
            }
        }
    }
}