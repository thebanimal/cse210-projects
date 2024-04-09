public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string date, int length, double speed) : base(date, length)
    {
        _type = "Cycling";
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (GetSpeed() / 60) * _length;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
}