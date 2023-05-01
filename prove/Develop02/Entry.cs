
class Entry 
{
    public string prompt;
    public string response;
    private string date;

    public Entry(string _date, string _prompt, string _response) 
    {
        date = _date;
        this.prompt = _prompt;
        this.response = _response;
    }

    public void DisplayEntry() 
    {
        Console.WriteLine($"\n{date}: {prompt} \n{response} \n");
    }

    public string GetEntryAsCsv() 
    {
        return $"{date}|{prompt}|{response}";
    }
}