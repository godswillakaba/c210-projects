using System;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    public void AddGoal(Goal goal) => _goals.Add(goal);

    public void RecordGoal(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            int points = _goals[index].RecordEvent();
            _score += points;
            Console.WriteLine($"You earned {points} points!");
        }
    }


    public void ShowGoals()
    {
        for(int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{_goals[i].GetStatus()}");
        }
    }


    public void DisplayScore() => Console.WriteLine($"Total score: {_score}");

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach(Goal goal in _goals)
            writer.WriteLine(goal.Serialize());
        }
    }


    public void LoadGoals(string filename)
    {
        if(File.Exists(filename))
        {
            _goals.Clear();
            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);
            foreach(string line in lines.Skip(1))
            {
                string[] parts = line.Split('|');

                switch (parts[0])
                {
                    case "SimpleGoal": AddGoal(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])) {});

                    break;
                    case "EternalGoal": AddGoal(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));

                    break;
                    case "CheckListGoal":
                    var checklist = new CheckListGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[4]));

                    checklist.GetType().GetField("_currentCount", System.Reflection.BindingFlags.NonPublic | 
                    System.Reflection.BindingFlags.Instance).SetValue(checklist, int.Parse(parts[6]));

                    AddGoal(checklist);
                    break;
                }
            }
        }
    }
}