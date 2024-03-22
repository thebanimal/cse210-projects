using System.Security.Cryptography;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, List<string> prompts, List<string> questions) : base(name, description)
    {
        _prompts = prompts;
        _questions = questions;
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
    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int randomNumber = rand.Next(0, _questions.Count);
        return _questions[randomNumber];
    }
    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();

        Console.WriteLine($"> {question}");
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        DisplayPrompt();
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in: ");
        ShowCountdown(5);
        Console.Clear();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(10);
        }

        Console.WriteLine("");
        DisplayEndingMessage();
    }
}