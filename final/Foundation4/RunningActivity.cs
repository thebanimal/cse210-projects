public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, int length, double distance) : base(date, length)
    {
        _type = "Running";
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
}