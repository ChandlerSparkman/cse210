public class Goal
{
    public string _shortName;
    public string _description;
    public int _points;

    public Goal(string name, string desc, int points)
    {
        _shortName = name;
        _description = desc;
        _points = points;
    }

    public virtual int RecordEvent()
    {
        return _points;
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        string mark = IsComplete() ? "[x]" : "[ ]";
        return $"{mark} {_shortName} ({_description})";
    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }
}