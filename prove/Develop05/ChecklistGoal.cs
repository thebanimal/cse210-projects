public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public ChecklistGoal(string name, string description, string points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted = _amountCompleted + 1;

        if (_amountCompleted == _target)
        {
            Console.WriteLine("Congratulations! You completed your Checklist Goal!");
            Thread.Sleep(2000);
            Console.WriteLine($"You earned {_bonus} points!");
            return _bonus;
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            return int.Parse(_points);
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted < _target)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public override string GetDetailsString()
    {
        string complete;
        if (IsComplete() == true)
        {
            complete = "X";
        }
        else
        {
            complete = " ";
        }

        return $"[{complete}] {_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_amountCompleted},{_target}";
    }
}