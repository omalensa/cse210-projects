public class Running : Activity
{
    private double _distance;   // in miles

    public Running(string date, int length, double distance) 
        : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        // Speed = (distance / minutes) * 60
        return (_distance / GetLength()) * 60;
    }

    public override double GetPace()
    {
        // Pace = minutes / distance
        return GetLength() / _distance;
    }
}