public class ChecklistGoal : Goal
{
    public int _completed;
    public int _target;
    public int _bonus;

    public ChecklistGoal(string name, string desc, int points, int target, int bonus)
        : base(name, desc, points)
    {
        _completed = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _completed++;
        if (_completed == _target) return _points + _bonus;
        return _points;
    }

    public override bool IsComplete()
    {
        return _completed >= _target;
    }

    public override string GetDetailsString()
    {
        string mark = IsComplete() ? "[x]" : "[ ]";
        return $"{mark} {_shortName} ({_description}) Completed {_completed}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist|{_shortName}|{_description}|{_points}|{_completed}|{_target}|{_bonus}";
    }
}