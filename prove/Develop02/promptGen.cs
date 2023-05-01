using System;
public class PromptGen{
    public List<string> _questions;

    public PromptGen() 
    { 
        _questions = new List<string>() 
        {
            "Who was the most interesting person you saw today?", 
            "What sparked curiosity in you today?", 
            "Name two things that felt meaningful about today.", 
            "What made you laugh today?",
            "What was the tastiest thing you ate today?" 
        };
        
    }
    public string ChoosePrompt() 
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }
    
}