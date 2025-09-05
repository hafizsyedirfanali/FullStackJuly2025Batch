namespace ObjectOrientedProgramming;
/// <summary>
/// Constructor brings the class (all the members of class)
/// into the RAM (Heap memory)
/// in other words, constructor creates class instance, 
/// or object, or reference variable or pointer
/// 
/// new keyword calls or invoke the constructor.
/// 
/// constructor can do anything that a function can do.
/// constructor executes the instructions just after 
/// the instantiation 
/// whereas a function executes whenever it is called.
/// 
/// Constructor overloading creates multiple constructors with different signatures/definition.
/// This creates multiple ways/options to instantiate the class.
/// We will learn more about this in encapsulation section.
/// </summary>
public class T04_Constructor
{
    public void Test()
    {
        var obj1 = new ConstructorOverloading();
        var obj2 = new ConstructorOverloading(10);
        var obj3 = new ConstructorOverloading("Hello");
        var obj4 = new ConstructorOverloading(10, "Hello");
        var obj5 = new ConstructorOverloading("Hello", 10);
    }
    public class ConstructorOverloading
    {
        private int? a;
        private string? s;
        public ConstructorOverloading()//parameterless constructor or default constructor
        {
            Console.WriteLine("Default Constructor");
        }
        public ConstructorOverloading(int a)
        {
            this.a = a;
            Console.WriteLine("Parameterized Constructor with int parameter");
        }
        public ConstructorOverloading(string s)
        {
            this.s = s;
            Console.WriteLine("Parameterized Constructor with string parameter");
        }
        public ConstructorOverloading(int a, string s)
        {
            this.a = a;
            this.s = s;
            Console.WriteLine("Parameterized Constructor with int and string parameters");
        }
        public ConstructorOverloading(string s, int a)
        {
            this.a = a;
            this.s = s;
            Console.WriteLine("Parameterized Constructor with string and int parameters");
        }
    }
    public void ClassObjectInitialization()
    {
        //Creating a blueprint of the class
        RashonKit kit1 = new RashonKit();//new keyword is followed by constructor
        //new keyword calls/invoke the constructor
        kit1.Rice = 2;
        kit1.Oil = 2;
        kit1.Wheat = 2;
        kit1.Pulse = 2;
        kit1.Salt = 2;


        RashonKit.StaticProperty = 1;
        
        RashonKit kit2 = new ();

        var kit3 = new RashonKit();

        var kit4 = new RashonKit()
        {
            Oil = 5,
            Rice = 5,
            Wheat = 5,
            Pulse = 5,
            Salt = 5
        };
    }
    public class RashonKit
    {
        public RashonKit()
        {
            Console.WriteLine("Hello");
        }
        public void Print()
        {
            Console.WriteLine("Hello");
        }
        public static int StaticProperty { get; set; }
        public int Oil { get; set; } = 1;
        public int Rice { get; set; } = 1;
        public int Wheat { get; set; } = 1;
        public int Pulse { get; set; } = 1;
        public int Salt { get; set; } = 1;
    }
}
