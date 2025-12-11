public class Running : Exercise
{
    private double _distance;

    public Running(double duration, double distance) : base(duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return Math.Round(_distance, 2);
    }

    public override double GetSpeed()
    {
        return Math.Round(_distance / _duration * 60, 2);
    }

    public override double GetPace()
    {
        return Math.Round(_duration / _distance);
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_duration} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}