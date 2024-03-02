using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercent = int.Parse(userInput);
        
        string grade;

        if (gradePercent >= 90)
        {
            grade = "A";
        }
        else if (gradePercent >= 80)
        {
            grade = "B";
        }
        else if (gradePercent >= 70)
        {
            grade = "C";
        }
        else if (gradePercent >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        string message;

        if (gradePercent >= 70)
        {
            message = "You pass. Well done.";
        }
        else
        {
            message = "You fail. Keep trying.";
        }

        Console.WriteLine($"Your grade is {grade}. {message}");
    }
}