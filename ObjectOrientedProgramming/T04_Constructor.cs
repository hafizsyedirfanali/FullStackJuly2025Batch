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
/// whereas a function executes only when it is called.
/// </summary>
public class T04_Constructor
{
    public void Test()
    {
        //Creating a blueprint of the class
        RashonKit kit1 = new RashonKit();//new keyword is followed by constructor
        //new keyword calls/invoke the constructor
        kit1.Rice = 2;
        RashonKit.StaticProperty = 1;
        RashonKit kit2 = new RashonKit();
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
