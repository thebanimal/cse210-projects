public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, List<string> prompts) : base(name, description)
    {
        _prompts = prompts;
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int randomNumber = rand.Next(0, _prompts.Count);
        return _prompts[randomNumber];
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();

        Console.WriteLine($"--- {prompt} ---");
    }
    private List<string> responses = [];
    public List<string> GetListFromUser()
    {
        Console.Write("> ");
        string response = Console.ReadLine();
        responses.Add(response);
        return responses;
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        DisplayPrompt();
        Console.Write("You may begin in... ");
        ShowCountdown(5);
        Console.WriteLine("");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
           List<string> userList = GetListFromUser();
           _count = userList.Count;
        }

        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine("");
        DisplayEndingMessage();
    }
}