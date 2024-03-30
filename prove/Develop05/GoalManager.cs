using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = [];
        _score = 0;
    }

    public void Start()
    {
        int menuChoice;
        do
        {
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            menuChoice = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (menuChoice == 1)
            {
                CreateGoal();
            }
            else if (menuChoice == 2)
            {
                ListGoalDetails();
            }
            else if (menuChoice == 3)
            {
                SaveGoals();
            }
            else if (menuChoice == 4)
            {
                LoadGoals();
            }
            else if (menuChoice == 5)
            {
                RecordEvent();
            }
        } while (menuChoice != 6);
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of Goal would you like to create? ");
        int goalChoice = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        if (goalChoice == 1)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            Console.Clear();

            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (goalChoice == 2)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            Console.Clear();

            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (goalChoice == 3)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            Console.Clear();

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        
    }
    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetName());
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
        Console.WriteLine("");
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_score}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.Clear();
        Console.WriteLine($"Your goals have been saved to {fileName}");
        Console.WriteLine("");
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string[] allLines = System.IO.File.ReadAllLines(fileName);

        _score = int.Parse(allLines[0]);
        string[] lines = allLines.Skip(1).ToArray();

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");

            string goalType = parts[0];
            string data = parts[1];

            string[] components = data.Split(",");

            if (goalType == "SimpleGoal")
            {
                string name = components[0];
                string description = components[1];
                string points = components[2];
                bool isComplete = bool.Parse(components[3]);
                    _goals.Add(new SimpleGoal(name, description, points, isComplete));

            }
            else if (goalType == "EternalGoal")
            {
                string name = components[0];
                string description = components[1];
                string points = components[2];
                _goals.Add(new EternalGoal(name, description, points));
            }
            else
            {
                string name = components[0];
                string description = components[1];
                string points = components[2];
                int bonus = int.Parse(components[3]);
                int amountCompleted = int.Parse(components[4]);
                int target = int.Parse(components[5]);
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus, amountCompleted));
            }
        }
        Console.Clear();
        Console.WriteLine($"Goals have been loaded from {fileName}");
        Console.WriteLine("");
    }
    public void RecordEvent()
    {
        int i = 0;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            i++;
            Console.WriteLine($"{i}. {goal.GetName()}");
        }
        Console.Write("Which goal did you accomplish? ");
        int completeGoal = int.Parse(Console.ReadLine());
        Console.Clear();

        _score = _score + _goals[completeGoal - 1].RecordEvent();

        Console.WriteLine($"You now have {_score} points!");
        Console.WriteLine("");
        ShowSpinner(5);
        Console.Clear();
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(175);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
}