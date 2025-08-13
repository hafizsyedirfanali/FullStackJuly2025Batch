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
        Explicit();
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

    }
}
