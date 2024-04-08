public class OutdoorEvent : Event
{
    private string _weather;

    public OutdoorEvent(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override void CreateFullDetails()
    {
        Console.WriteLine(_title);
        Console.WriteLine("Outdoor Gathering");
        Console.WriteLine(_description);
        Console.WriteLine($"{_date} at {_time}");
        Console.WriteLine(_address.GetAddress());
        Console.WriteLine($"Weather will be {_weather}");

    }
    public override void CreateShortDetails()
    {
        Console.WriteLine(_title);
        Console.WriteLine($"Outdoor Gathering on {_date}");
    }
}