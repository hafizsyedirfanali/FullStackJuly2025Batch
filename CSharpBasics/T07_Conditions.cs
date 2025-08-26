namespace CSharpBasics;
/// <summary>
/// Conditions in C#
/// if, if-else, if-else-if, switch-case, ternary operator
/// </summary>
public class T07_Conditions
{
    public static void Test()
    {

    }
    public static void ElseIfLadder()
    {
        int per = -5;
        if (per < 0)
        {
            Console.WriteLine("INVALID INPUT");
        }
        else if (per < 35)
        {
            Console.WriteLine("FAIL");
        }
        else if (per < 50)
        {
            Console.WriteLine("PASS");
        }
        else if (per < 60)
        {
            Console.WriteLine("SECOND CLASS");
        }
        else if (per < 75)
        {
            Console.WriteLine("FIRST CLASS");
        }
        else if (per <= 100)
        {
            Console.WriteLine("DISTINCTION");
        }
        else
        {
            Console.WriteLine("INVALID INPUT");
        }

    }
    public static void IfElseCondition()
    {
        int num1 = 10;
        int num2 = 50;
        if (num1 > num2)
        {
            Console.WriteLine("Num 1 is greater");
        }
        else
        {
            Console.WriteLine("Num 2 is greater");
        }
    }
    public static void SwitchCase(){
        int option = 0;
        switch(option){
            case 1:
            Console.WriteLine("Case 1");
            break;
            case 2:
            Console.WriteLine("Case 2");
            break;
            case 3:
            Console.WriteLine("Case 3");
            break;
            case 4:
            Console.WriteLine("Case 4");
            break;
            default:
            Console.WriteLine("Invalid option");
            break;
        }
    }

    public static void Ternary(){
        int num1 = 10;
        int num2 = 2;
        string result = num1 > num2 ? "Num1 is greater":"Num2 is greater";

        Console.WriteLine(result);
    }
}