namespace CSharpBasics;
/// <summary>
/// Parsing in c# is classified in two types
/// 1. Implicit - automatic 
/// 2. Explicit - manual
/// </summary>
public class T02_Parsing
{
    public static void Test()
    {
        ExplicitUsingTryParse();
    }

    public static void Implicit()
    {
        byte b = 1;
        short s = b;//implicit from byte to short
        int i = s;
        long l = i;
        Int128 i128 = l;

        float f = i;
        double d = i;
        decimal dm = i;

        d = f;//float to double
        //d = dm;//decimal's precision > double
        //dm = d;//double's capacity > decimal

        char c = 'c';//ASCII of c is an integer
        //b = c;//byte is 256 and char are 128 and extended are 128
        //s = c;//reserved for future
        i = c;
        l = c;
        i128 = c;
    }
    public static void Explicit()
    {
        Int128 i128 = 1;
        long l = (long)i128;
        int i = (int)l;
        short s = (short)i;
        s = 32323;
        Console.WriteLine(s);
        byte b = (byte)s;
        Console.WriteLine(b);

        char ch = 'a';
        int i1 = ch;
        ch = (char)i1;//we take responsibility

        bool bl = true;//it will be a bit 1 (non zero)
        bl = false; //bit 0
    }

    public static void ExplicitUsingConvertClass()
    {
        string s = "1";
        int i = Convert.ToInt32(s);
        s = "true";
        bool bl = Convert.ToBoolean(s);
        s = "1.2";
        float f = Convert.ToSingle(s);
        s = "a";
        char c = Convert.ToChar(s);
    }
    public static void ExplicitUsingParse()
    {
        string s = "1";
        int i = int.Parse(s);
        s = "1.1";
        float f = float.Parse(s);
        s = "true";
        bool bl = bool.Parse(s);
        s = "a";
        char c = char.Parse(s);
    }
    public static void ExplicitUsingTryParse()
    {
        string s = "a1";
        bool isSucceeded = int.TryParse(s, out int i);
        if(isSucceeded == true)
        {
            Console.WriteLine("the converted value is "+i);
        }
        else
        {
            Console.WriteLine("Failed to convert the input value");
        }

        isSucceeded = bool.TryParse(s, out bool bl);
        isSucceeded = char.TryParse(s , out char c);
        isSucceeded = float.TryParse(s, out float f);
            
    }
}
