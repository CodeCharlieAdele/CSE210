
class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }    public Entry(string chosenPrompt, string response, DateTime date)
    {
        Prompt = chosenPrompt;
        Response = response;
        Date = date;
    }
}