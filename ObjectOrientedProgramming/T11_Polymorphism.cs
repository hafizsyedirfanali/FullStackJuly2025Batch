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
        // F1(10);
        TestPolymorphism();
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

    public void TestPolymorphism()
    {
        //A parent class instance can be constructed using the child class constructor.
        A a = new A(10);
        A a1 = new B(10);
        A a2 = new C(10);

        B b = new B();
        B b1 = new C();

        C c = new C();
    }

    public class A
    {
        public A()
        {
            
        }
        public A(int a)
        {
            
        }
    }
    public class B : A
    {
        public B() : base()
        {
            
        }
        public B(int a) : base(a)
        {
            
        }
    }
    public class C : B
    {
        public C()
        {
            
        }
        public C(int a) : base(a)
        {
            
        }
    }
}
