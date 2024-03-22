public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {}

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(6);
            Console.WriteLine("");
            Console.Write("Now breathe out... ");
            ShowCountdown(4);
            Console.WriteLine("");
            Console.WriteLine("");
        }

        DisplayEndingMessage();
    }
}