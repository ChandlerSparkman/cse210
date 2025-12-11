public class Swimming : Exercise
{
    private double _laps;

    public Swimming(double duration, double laps) : base(duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return Math.Round(_laps * 0.05, 2);
    }

    public override double GetSpeed()
    {
        return Math.Round(GetDistance() / _duration * 60, 2);
    }

    public override double GetPace()
    {
        return Math.Round(_duration / GetDistance());
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_duration} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}