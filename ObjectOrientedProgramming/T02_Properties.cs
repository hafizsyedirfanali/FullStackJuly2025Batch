namespace ObjectOrientedProgramming;
/// <summary>
/// A Property is a data member. It has two functions, getter and setter
/// 
/// </summary>
public class T02_Properties
{
    private string myName;

    public string MyName
    {
        get { return myName; }
        set { myName = value.ToUpper() ; }
    }

    public string Name { get; set; }
    private int _Age;
    public int Age 
    { 
        get
        {
            return _Age;
        }
        set
        {
            if (value<=30 && value >= 20)
            {
                _Age = value;
            }           
        }
    }

    public int Count { get; } //Read only property
    //public int MyProperty {  set; }//impossible
    public int MyProperty { get; private set; }//can only be set from within the clas
    public void Test()
    {
        Name = "Hello";//this will be performed by setter function
        var name = Name;//this will be perfomed by getter function
        
    }
}
