namespace ObjectOrientedProgramming;
/// <summary>
/// A method is a member of a class that defines a behavior of the class.
/// </summary>
public class T05_Methods
{
    public void Test()//Test is a method name - should be in Pascal case
    {
        //Test holds the memory address of the method, it is like a pointer to the method
        Console.WriteLine("Hello from Test method in T05_Method class");
    }

    //parameterless method that returns nothing (void)
    public void Display()//Display is a method name - should be in Pascal case
    {
        Console.WriteLine("Hello from Display method in T05_Method class");
    }
    //parameterless method that returns int
    public int GetNumber()//GetNumber is a method name - should be in Pascal case
    {
        return Random.Shared.Next(1, 100);//returns a random number between 1 and 100
    }
    //single parameter method that does not return anything (void)
    public void PrintMessage(string message)//PrintMessage is a method name - should be in Pascal case
    {
        Console.WriteLine($"Message: {message}");
    }
    //single int parameter method that returns int
    public int Square(int number)//Square is a method name - should be in Pascal case
    {
        return number * number;
    }
    //two int parameters method that returns int
    public int Add(int a, int b)//Add is a method name - should be in Pascal case
    {
        return a + b;
    }

    //Method Overloading - same method name with different parameters (type or number of parameters)
    public int Add(int a, int b, int c)//Add is a method name - should be in Pascal case
    {
        return a + b + c;
    }
    //two double parameters method that returns double
    public double Add(double a, double b)//Add is a method name - should be in Pascal case
    {
        return a + b;
    }
    //two string parameters method that returns string
    public string Add(string a, string b)//Add is a method name - should be in Pascal case
    {
        return a + b;//string concatenation
    }
    public void TestOverloading()
    {
        Console.WriteLine(Add(10, 20));//calls Add(int, int)
        Console.WriteLine(Add(10, 20, 30));//calls Add(int, int, int)
        Console.WriteLine(Add(10.5, 20.5));//calls Add(double, double)
        Console.WriteLine(Add("Hello ", "World"));//calls Add(string, string)
    }
}
