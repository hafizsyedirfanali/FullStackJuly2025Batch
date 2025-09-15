namespace ObjectOrientedProgramming;
/// <summary>
/// A delegate is a function pointer. 
/// It is used to handle call back function.
/// It helps in achieving single responsibility principle (SRP -> S of SOLID)
/// It helps in writing extensible and modular code
/// </summary>
public class T06_Delegates
{
    //definition of a delegate
    public delegate int ArithmaticDelegate(int i, int j);
    public delegate void PrintDelegate(string s);
    public void Test()
    {
        //Declaring a delegate
        ArithmaticDelegate d1 = Add;
        int result;
        result = Add(10, 20);//direct calling
        result = d1(10, 20);//calling through delegate
        result = d1.Invoke(10, 30);//calling through delegate using invoke method

        result = AddAndPrint(10, 20, Print);
        result = AddAndPrint(10, 20, s => Console.Write(s));
        result = AddAndPrint(10, 20, Console.Write);
        TestMultiDelegate();
    }
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int AddAndPrint(int a, int b, PrintDelegate callbackfunction)
    {
        var result = a + b;
        //Console.WriteLine(result.ToString();
        callbackfunction.Invoke(result.ToString());
        return result;
    }
    public void Print(string message)
    {
        Console.WriteLine("Info: "+message.ToUpper());
    }
    public void PrintV2(string message)
    {
        Console.WriteLine("Message: " + message.ToUpper());
    }

    //Multidelegate
    public delegate void MultiDelegate(string s);
    public void TestMultiDelegate()
    {
        MultiDelegate d1 = F1;
        d1 += F2;//Adding another function to delegate
        d1 += F3;//Adding another function to delegate
        d1 += F4;//Adding another function to delegate
        d1 -= F3;//Removing a function from delegate
        d1("Hello");
    }
    public void F1(string s) 
    {
        Console.WriteLine("From F1 " + s);
    }
    public void F2(string s)
    {
        Console.WriteLine("From F2 " + s);
    }
    public void F3(string s)
    {
        Console.WriteLine("From F3 " + s);
    }
    public void F4(string s)
    {
        Console.WriteLine("From F4 " + s);
    }
}
