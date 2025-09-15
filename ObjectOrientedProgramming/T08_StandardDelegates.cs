namespace ObjectOrientedProgramming;
/// <summary>
/// We have three standard delegates
/// 1. Action Delegate
/// 2. Func Delegate
/// 3. Predicate Delegate
/// </summary>
public class T08_StandardDelegates
{
    public void TestPredicateDelegate()
    {
        //its name continues and its work is done be Func
        Predicate<int> p1 = F5; //points to a function that accepts one int parameter and returns bool
        Func<int, bool> f1 = F5;
    }
    public bool F5(int a) { return true; }
    public void TestFuncDelegate()
    {
        Func<string> f1 = F3;
        Func<string, string> f2 = F4;

    }
    public string F3() { return string.Empty; }
    public string F4(string s) { return s.ToUpper(); }


    public void TestActionDelegate()
    {
        Action<int> a1 = F1;
        Action<int, int> a2 = F2;

    }
    public void F1(int a) { }
    public void F2(int a, int b) { }

    //Lambda Functions
    public void TestLambdaFunctions()
    {
        Action<int> a1 = (a) => { Console.WriteLine(a); };
        var a2 = (int a) => { Console.WriteLine(a); };
        Action<int> a3 = (a) => Console.WriteLine(a);
        Action<int> a4 = a => Console.WriteLine(a);
        Action<int> a5 = Console.WriteLine;//valid simple form
        a1(10); a1.Invoke(10);

        Func<string, string> f1 = a => { return a.ToUpper(); };
        Func<string, string> f2 = a => a.ToUpper();
        Func<int,int,int> f3 = (a,b) => { return a + b; };
        Func<int,int,int> f4 = (a,b) => a + b;

        Predicate<int> p1 = a => a > 10;
        var result = p1(11);

        Action<int> a = delegate (int a) { Console.WriteLine(a); };
        Func<int, int, int> f = delegate (int a, int b) { return a + b; };
        Predicate<int> p = delegate(int a) {  return a > 10; };
    }

    public void LambdaFunctionAsCallback()
    {
        Comparasion(1, 2, out bool result, (a, b) => a > b);
        Comparasion(1, 2, out result, (a, b) => { return a > b; });
    }

    public void Comparasion(in int a, in int b, out bool result, Func<int,int,bool> predicate)
    {
        result = predicate.Invoke(a, b);
    }
}
