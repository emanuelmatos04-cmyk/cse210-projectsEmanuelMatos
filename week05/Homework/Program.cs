class Program
{
    static void Main(string[] args)
    {
        // Math assignment
        MathAssignment math = new MathAssignment("John Smith", "Fractions", "7.3", "3-10, 20-21");
        Console.WriteLine(math.GetSummary());          // John Smith - Fractions
        Console.WriteLine(math.GetHomeworkList());     // Section 7.3 Problems 3-10, 20-21

        // Writing assignment
        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writing.GetSummary());       // Mary Waters - European History
        Console.WriteLine(writing.GetWritingInformation()); // The Causes of World War II by Mary Waters
    }
}
