public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // This method will be different for each type of goal
    public abstract void RecordEvent();

    // Returns whether the goal is complete
    public abstract bool IsComplete();

      public int GetPoints()
    {
        return _points;
    }

    // Returns a string to display the goal
    public virtual string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description})";
    }

    // Returns string for saving to file
    public abstract string GetStringRepresentation();
}