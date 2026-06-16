public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int length, int laps) 
        : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // 50 meters per lap → convert to miles
        return (_laps * 50) / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        // Speed in mph
        return (GetDistance() / GetLength()) * 60;
    }

    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }
}