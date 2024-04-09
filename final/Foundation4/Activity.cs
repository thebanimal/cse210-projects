public abstract class Activity
{
    protected string _type;
    private string _date;
    protected int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public abstract double GetDistance();
    public virtual double GetSpeed()
    {
        return (GetDistance() / _length) * 60;
    }
    public double GetPace()
    {
        return _length / GetDistance();
    }
    public string GetSummary()
    {
        return $"{_date} {_type} ({_length} min)- Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}