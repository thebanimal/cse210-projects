using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();

        job2._jobTitle = "Front-End Developer";
        job2._company = "Apple";
        job2._startYear = 2018;
        job2._endYear = 2023;

        Resume myResume = new Resume();

        myResume._name = "Bryant Reed";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}