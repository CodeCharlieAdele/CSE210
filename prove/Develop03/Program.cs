using System;

class Program
{
    static void Main(string[] args)
    {
        Reference scriptureReference = new Reference("Ether", "12", "27");
        Scripture scripture = new Scripture(scriptureReference, "And if men come unto me I will show unto them their weakness. " +
        "I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; " + 
        "for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");

        string userInput = "";

        while (userInput != "quit" || scripture.HasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine();
            
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            Console.ReadLine();
            scripture.RemoveWords();
        }
        

        Console.WriteLine(scripture.GetScripture());
        Console.WriteLine("Hopefully you memorized the scripture!");
    }
}