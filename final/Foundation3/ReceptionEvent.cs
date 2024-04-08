public class ReceptionEvent : Event
{
    private string _email;

    public ReceptionEvent(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public override void CreateFullDetails()
    {
        Console.WriteLine(_title);
        Console.WriteLine("Reception");
        Console.WriteLine(_description);
        Console.WriteLine($"{_date} at {_time}");
        Console.WriteLine(_address.GetAddress());
        Console.WriteLine($"RSVP at {_email}");

    }
    public override void CreateShortDetails()
    {
        Console.WriteLine(_title);
        Console.WriteLine($"Reception on {_date}");
    }
}