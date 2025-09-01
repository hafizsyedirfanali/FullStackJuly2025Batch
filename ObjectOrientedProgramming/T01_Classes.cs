namespace ObjectOrientedProgramming;
/// <summary>
/// A class is a collection of class members like
/// 1. Properties
/// 2. Fields - Fields are private variables. Used to store local data.
/// 3. Constructors - Always present. If we don't define any constructor, a default constructor is provided by the compiler. if we define any constructor, default constructor is not provided.
/// 4. Methods - Behavior of the class
/// 5. Class - Reference type - will be stored in heap memory - Garbage Collector will clean up the memory (destructor will be called before cleaning up the memory)
/// 6. Struct - Value type - will be stored in stack memory - memory will be cleaned up automatically at the end of scope - no destructor
/// 7. Destructor - Always present - used to clean up the memory - cannot be called explicitly - called by Garbage Collector
/// </summary>
public class T01_Classes
{
    //A property is a data member used to store data. It is accessible outside the class.
    public string Name { get; set; }//pascal case

    //A field is a data member used to store data. It is not accessible outside the class.
    private int id;//camel case (global variable)

    //constructor
    public T01_Classes()//default constructor
    {
        
    }

    //method
    public void Display()//method name should be in pascal case
    {
        Console.WriteLine($"ID: {id}, Name: {Name}");
    }

    //a class
    public class AClass
    {
        //destructor
        ~AClass() //~ is a tilde symbol
        {
            //cleanup code
        }
    }

    //a struct
    public struct AStruct
    {
        //no destructor
    }

    //destructor
    ~T01_Classes()
    {
        //cleanup code
    }
}
