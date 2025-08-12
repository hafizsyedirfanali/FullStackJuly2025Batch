using System.Numerics;

namespace CSharpBasics;

public class T01_DataTypes
{
    public static void Test()
    {
        //number are classifed into integers (-100, 0, 200) and real (1.2, -100.33)
        //1. Integer - Decimal let no of bits be n (2^n)
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
        byte bunsigned = 255;
        sbyte bsigned = -128;

        short ssigned = -32768;
        ushort sunsigned = 65535;

        uint intUnsigned = 4294967295;
        int intSigned = -2147483648;

        long l = 1;
        Int64 i64 = 1;
        ulong lu = 1;

        Int128 b = 1;
        UInt128 ub = 1;
    }
}
