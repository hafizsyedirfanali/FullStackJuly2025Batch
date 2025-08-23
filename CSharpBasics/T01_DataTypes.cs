
namespace CSharpBasics;
/// <summary>
/// Data Types are of two types.
/// 1. Valued type -> stored in stack (Limited) FILO (Push and Pop)
/// 2. Referenced type -> stored in heap (Lot of space available)
/// </summary>
public class T01_DataTypes
{
    public static void Test()
    {
        //number are classified into integers (-100, 0, 200) and real (1.2, -100.33)
        //1. Integer - Decimal let no of bits be n (2^n)
        //default value of integer is 0
        //   0           0
        //   1           1
        //   2          10
        //   3          11
        //   4         100
        //   5         101
        //   6         110
        //   7         111
        //   8        1000
        //   9        1001
        //  10        1010

        //Integers are classified as
        //1. Byte  - 8 bits  - 1 byte  256 (signed -128 to 127) (unsigned 0 to 255)
        //2. Short - 16 bits - 2 bytes 65536 (signed -32768 to 32767) (unsigned 0 to 65535)
        //3. int   - 32 bits - 4 bytes 4294967296
        //4. long  - 64 bits - 8 bytes 18446744073709551616
        //5. big int- 128 bits-16 bytes ----
        // -10 -9 -8 -- ------ -1 0 1 2 3 ---------10- - - - -255
        byte bunsigned = 255;//pushed in stack
        sbyte bsigned = -128;//pushed in stack

        short ssigned = -32768;//pushed in stack
        ushort sunsigned = 65535;//pushed in stack

        uint intUnsigned = 4294967295;
        int intSigned = -2147483648;

        long l = 1;
        Int64 i64 = 1;
        ulong lu = 1;
        UInt64 ui64 = 1;

        Int128 b = 1;
        UInt128 ub = 1;


        //Real numbers (floating numbers) 1.1, 2.5, -1.4
        //default value of real number is 0.0
        float f = 1.1f; //4 Bytes (least accuracy)
        Single s = 1.1f;

        double d = 1.1d; //8 Bytes (average accuracy)
        Double d1 = 1.1d;

        decimal dm = 1.1m; //16 Bytes (highest accuracy)
        Decimal dm1 = 1.1m;//For amount/currency always use decimal

        bool bl = true;
        Boolean bl1 = true;//default value is false.i.e. 0

        char c = 'a';//ascii value 97, in bits 01100001
        //default value is '\0' i.e. 0

        string str = "hello";//string is a reference type, it is stored in heap memory.
        //integer(5), float(3), boolean, char, string (BASIC TYPES)
        //ADVANCE TYPES: 


    }//at the end of scope all the stack variables are popped automatically.
    public static void NullableValuedTypes()
    {
        byte? b = null;// Nullable type, can hold null value
        sbyte? bs = null; // Nullable type, can hold null value
        short? ss = null; // Nullable type, can hold null value
        ushort? sus = null; // Nullable type, can hold null value
        float? fNullable = null; // Nullable type, can hold null value
        bool? blNullable = null; // Nullable type, can hold null value
        char? cNullable = null; // Nullable type, can hold null value
    }
    public static void NullableReferenceTypes()
    {
        //in older versions, all reference types are nullable by default.
        //in newer versions, reference types are non-nullable by default.
        string s = null;//not showing error because it is maintaining compatibility with older versions of C#.
        string? s1 = null;
        //other reference types like class, interface, delegate, array, etc. are also nullable by default.
    }
}
