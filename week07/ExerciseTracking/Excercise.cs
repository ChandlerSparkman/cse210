public class Exercise
{
    protected string _date;
    protected double _duration;

    public Exercise(double duration)
    {
        _date = DateTime.Today.ToLongDateString();
        _duration = duration;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return "";
    }
}