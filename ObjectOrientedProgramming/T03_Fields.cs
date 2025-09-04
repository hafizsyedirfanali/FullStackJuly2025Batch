

namespace ObjectOrientedProgramming;
/// <summary>
/// Fields are global private variables available within the class.
/// It is used to store common data for that class,
/// It stores the reference of injected services through dependency injection (DI).
/// </summary>
public class T03_Fields
{
    private int i;//readable and writable
    private readonly string institutionName = "NASS";//direct assignement, at compile time
    
    private readonly string address;//assigned through constructor
    public T03_Fields()
    {
        address = "Nagpur";//assigned at runtime
    }

    private const float pi = 3.14f;

   
    public void Increment()
    {
        i++;
    }
    public void Decrement()
    {
        i--;
    }
}
