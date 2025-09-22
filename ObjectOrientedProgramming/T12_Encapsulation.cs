namespace ObjectOrientedProgramming;

/// <summary>
/// Encapsulation is the bundling/wrapping of data, 
/// along with the methods/behaviour/functions that operate on that data,
/// into a single unit called class.
/// for showing and hiding the data we have different access modifiers
/// 1. public - accessible from any assembly(project)
/// 2. private - only accessible from within the class itself
/// 3. internal - accessible from the home assembly only
/// 4. protected - accessible from the class and the inherited class
/// </summary>
public class T12_Encapsulation
{
    public void Test()
    {
        Encapsulation e = new Encapsulation();
        e.Age = 10;
        e.Name = "Hello";
        e.Print();
    }
    public class Encapsulation
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public void Print()
        {
            Console.WriteLine("Name:" + UpperCase(this.Name) + " and Age:" + this.Age);
        }
        private string UpperCase(string input)
        {
            return input.ToUpper();
        }
    }
    
}
