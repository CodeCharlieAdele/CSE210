using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your GPA: ");
        string userGpa = Console.ReadLine();
        int gpa = int.Parse(userGpa);

        string letterGrade = ("");

        if (gpa >= 90)
        {
            letterGrade = "A";
        }
        else if (gpa >= 80)
        {
            letterGrade = "B";
        }
        else if (gpa >= 70)
        {
            letterGrade = "C";
        }
        else if (gpa >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        if (gpa >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed :( ");
        }

        Console.WriteLine($"Your grade is {letterGrade}");
    }
}