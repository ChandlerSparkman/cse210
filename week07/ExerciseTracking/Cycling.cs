public class Cycling : Exercise
{
    private double _speed;

    public Cycling(double duration, double speed) : base(duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return Math.Round(_speed * (_duration / 60), 2);
    }

    public override double GetSpeed()
    {
        return Math.Round(_speed, 2);
    }

    public override double GetPace()
    {
        return Math.Round(_duration / GetDistance());
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_duration} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}