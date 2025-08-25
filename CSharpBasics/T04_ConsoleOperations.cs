namespace CSharpBasics;

public class T04_ConsoleOperations
{
    public static void Test()
    {
        TestWrite();
    }
    public static void TestReadLine()
    {
        //get a number input from user.
        //convert that into an int
        //print it in console.
        Console.WriteLine("Enter any text.");
        string? input = Console.ReadLine();
        Console.WriteLine($"You entered {input} and {input}");
        //in JS ->   `my name is ${name}, age is ${age}`
    }
    public static void TestReadKey()
    {
        Console.WriteLine("Enter any key to continue");
        ConsoleKeyInfo keyInput = Console.ReadKey();
        
        Console.WriteLine("");
        Console.WriteLine($"You entered {keyInput.KeyChar}");
    }
    public static void TestRead()
    {
        Console.WriteLine("Enter any text");
        int input = Console.Read();//it returns the ascii value of the first character entered
        Console.WriteLine($"You entered {input}");
    }
    public static void TestWriteLine()
    {
        //its shortcut key snippet cw tab
        Console.WriteLine("Hello world");//it prints and adds a new line character \n
        Console.WriteLine("Hello world");
    }
    public static void TestWrite()
    {
        Console.Write("Hello");//it prints and does not add new line character.
        Console.Write(" ");
        Console.Write("World");
    }
}
