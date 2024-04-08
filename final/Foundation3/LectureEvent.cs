public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void CreateFullDetails()
    {
        Console.WriteLine(_title);
        Console.WriteLine($"Lecture featuring {_speaker}");
        Console.WriteLine(_description);
        Console.WriteLine($"{_date} at {_time}");
        Console.WriteLine(_address.GetAddress());
        Console.WriteLine($"Capacity limited to {_capacity} people");

    }
    public override void CreateShortDetails()
    {
        Console.WriteLine(_title);
        Console.WriteLine($"Lecture on {_date}");
    }
}