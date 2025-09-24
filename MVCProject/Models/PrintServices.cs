namespace MVCProject.Models;

public class PrintServices
{
    public void PrintInNewLine(string message) => Console.WriteLine(message);
    public void PrintContinuous(string message) => Console.Write(message);
}
