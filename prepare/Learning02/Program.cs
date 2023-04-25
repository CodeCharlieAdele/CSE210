using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Amateur DJ";
        job1._company = "Jason Mendoza Inc.";
        job1._startYear = 2010;
        job1._endYear = 2016;

        Job job2 = new Job();
        job2._jobTitle = "Amateur Hip-Hop Dancer";
        job2._company = "Jason Mendoza Inc.";
        job2._startYear = 2017;
        job2._endYear = 2020;

        Resume myResume = new Resume();
        myResume._name = "Jake Jortles";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResumeDetails();
        myResume.Display();
    }
}