using System;

public class Assignment
{
    private string _studenName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studenName = studentName;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studenName;
    }

    public string GetTopic()
    {
        return _topic;
    }
    public string GetSummary()
    {
        return $"{_studenName} - {_topic}";
    }
}