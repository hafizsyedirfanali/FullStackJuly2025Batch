namespace CSharpBasics;
/// <summary>
/// Its a type safe language.
/// In c# we have
/// 1. Arithmetic operators
/// 2. Equality or Comparison Operators
/// 3. Logical Operators
/// 4. Bitwise Operator
/// 5. Assignment Operators
/// 6. Ternary Operator
/// 7. Null conditional operator
/// 8. Null Coalescing operator
/// 9. Null Forgiving Operator
/// </summary>
public class T03_Operators
{
    public static void Test()
    {
        Bitwise();
    }
    public static void ArithmeticOperators()
    {
        int a = 10, b = 3;
        int addition = a + b;//the type of lhs will be same as the type of rhs
        int subtraction = a - b;
        int multiplication = a * b;
        int divisionQuotient = a / b;
        int divisionRemainder = a % b;
        int exponent = a ^ b;//a to the power b
    }
    public static void ComparisonOperator()
    {
        //result of comparison is always boolean
        int num1 = 10, num2 = 20;
        bool result;
        result = num1 == num2;//are num1 & num2 equal?
        result = num1 != num2;//are num1 & num2 unequal?
        result = num1 > num2;//is num1 greater than num2?
        result = num1 < num2;
        result = num1 >= num2;
        result = num1 <= num2;
    }
    public static void LogicalOperators()
    {
        //and   &&
        //or    ||
        //not   !
        //result of logical operation is always boolean
        //operands are always boolean
        bool operand1 = true, operand2 = false;
        bool result;
        result = operand1 && operand2;//AND operation - binary
        result = operand1 || operand2;//OR operation - binary
        result = !operand1;//NOT operation - unary
        if(10 > 7 || 5 < 10)
          //true  || true => true
        {

        }
    }

    public static void Bitwise()
    {
        //shift operation
        //2  -> 10 -> right shift -> 1 -> 1
        //2  -> 10 -> left shift -> 100 -> 4 -> left shift -> 1000 -> 8 
        int result = 3 << 1;

        //logical operation
        //and &
        //or |        
        //operands are integer
        int i = 2, j = 3;
        //2  -> 10
        //3  -> 11
        //and-> 10 (2)
        result = i & j;
        //2  -> 10
        //3  -> 11
        //or -> 11 (3)
        result = i | j;
        Console.WriteLine(result);
    }
    public static void AssignmentOperator()
    {
        int i = 10;//= is an assignment operator, it assigns value from rhs to lhs
        i += 1;//i = i + 1;
        i -= 1;//i = i - 1;
        i *= 1;//i = i * 1;
        i /= 1;//i = i / 1;
        i %= 1;//i = i % 1;
        i ^= 1;//i = i ^ 1;
        i <<= 1;//i = i << 1;
        i >>= 1;//i = i >> 1;
    }
    public static void TernaryOperator()
    {
        //it works similar to if and else
        int i = 10, j = 20;
        string result = i < j ? "Correct" : "Incorrect";
        char charResult = i < j ? 'y' : 'n';
        bool boolResult = i < j || 3 > 2 ? true : false;
        //never ever use nested ternary conditions. 
        //if you want to use complex conditions
        //then use if and else
    }
}
