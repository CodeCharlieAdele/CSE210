using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Daveed Diggs", "American History");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Alan Turing", "Computing", "7", "11-18");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Anna Maria", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}