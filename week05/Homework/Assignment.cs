public class Assignment
{
    protected string _studentName;
    protected string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Common method
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
