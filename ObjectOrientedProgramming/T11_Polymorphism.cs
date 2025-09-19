namespace ObjectOrientedProgramming;
/// <summary>
/// Polymorphism has two types
/// static (compile time) and dynamic (runtime)
/// Compile time polymorphism includes function overloading
/// Runtime polymorphism includes function overriding
/// </summary>
public class T11_Polymorphism
{
    public void Test()
    {
        F1(10);
    }
    ///Compile time polymorphism (overloading)
    ///
    public void F1() { }
    public void F1(int a) { }
    public void F1(int a, int b) { }
    public void F1(int a, int b, int c) { }

    ///Runtime polymorphism (overriding)
    ///

    public class ParentClass
    {
        public virtual void Print()//virtual functions are overridable
        {
            Console.WriteLine("hello from parent");
        }
    }
    public class ChildClass : ParentClass
    {
        public override void Print()
        {
            //base.Print();
            Console.WriteLine("Hello from child class");
        }
    }
}
