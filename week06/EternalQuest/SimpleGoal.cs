using System;

public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _completed = false;
    }

    public override int RecordEvent()
    {
        if(!_completed)
        {
            _completed = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _completed;
    public override string GetStatus() => $"[{(_completed ? "X" : "")}] {_name}";
    public override string Serialize() =>$"SimpleGoal |{_name}| {_description}| {_points}| {_completed}";
}