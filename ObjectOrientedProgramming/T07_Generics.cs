using static ObjectOrientedProgramming.T07_Generics;

namespace ObjectOrientedProgramming;
/// <summary>
/// Generics is a method in .net that generalizes the class, method, etc
/// </summary>
public class T07_Generics
{
    public delegate void AGenericDelegate<T>(T arg);
    public delegate void AGenericDelegate<T1,T2>(T1 arg1, T2 arg2);
    public delegate void AGenericDelegate<T1,T2,T3>(T1 arg1, T2 arg2,T3 arg3);
    public delegate T4 AGenericDelegate<T1,T2,T3, T4>(T1 arg1, T2 arg2,T3 arg3);
    public void Test()
    {
        var obj = new AClass<int>();
        obj.MyProperty = 1;

        var obj1 = new AClass<string>();
        obj1.MyProperty = "Hello";

        var obj2 = new AnotherClass<int, float, string>();
        var obj3 = new AnotherClass<int,float>();

        var obj4 = new AClass1();
        obj4.AFunction<int,float>(10,20f);
        obj4.AFunction(10,20f);//valid

        AGenericDelegate<int> d1 = F1;
        AGenericDelegate<string> d2 = F2;
        AGenericDelegate<int,int> d3 = F3;

    }
    public void F1(int a) { }
    public void F2(string a) { }
    public void F3(int a, int b) { }
    public class AClass<T>
    {
        public T MyProperty { get; set; }
    }
    public class AnotherClass<T1, T2, T3>
    {
        public T1 MyProperty1 { get; set; }
        public T2 MyProperty2 { get; set; }
        public T3 MyProperty3 { get; set; }
    }
    public class AnotherClass<T2, T3>
    {
        public T2 MyProperty2 { get; set; }
        public T3 MyProperty3 { get; set; }
        public void AFunction(T2 arg1, T3 arg2)
        {

        }
    }
    public class AClass1
    {
        public void AFunction<T1, T2>(T1 arg, T2 arg1)
        {

        }
    }
}
