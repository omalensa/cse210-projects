using System;

public abstract class Activity
{
    private string _date;
    private int _length;  // in minutes

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetLength()
    {
        return _length;
    }

    // These methods will be overridden by child classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_length} min)- " +
               $"Distance {GetDistance():0.##} miles, " +
               $"Speed {GetSpeed():0.##} mph, " +
               $"Pace: {GetPace():0.##} min per mile";
    }
}