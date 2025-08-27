namespace CSharpBasics;
/// <summary>
/// An Array is a collection of similar type of data.
/// it is of referenced type. it is stored in heap memory.
/// Arrays are classified into two types
/// 1. Single dimensional array
/// 2. Multi dimensional array
/// </summary>
public class T08_Arrays
{
    public static void Test()
    {

    }
    public static void SingleDimensionalArray()
    {
        //Data will be in this format, where all the data 
        // will be in contiguous memory location
        //first data will have index 0
        //1. if size of array is not known
        int[] arr; //declaration
                   //after knowing the size
        arr = new int[5];//instantiation
        //2. if size of data is known (5) and data is not known
        int[] arr1 = new int[5];//declaration and instantiation
        //writing data
        arr1[0] = 1;
        arr1[1] = 2;
        arr1[2] = 3;
        arr1[3] = 4;
        arr1[4] = 5;
        //arr1[5] = 5;//IndexOutOfRangeException
        //3. if data is known
        int[] arr2 = new int[] { 1, 2, 3, 4, 5, 6 };//declaration, instantiation and initialization

        //reading data using for loop
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.WriteLine(arr2[i]);
        }
        //reading data using foreach loop
        foreach (var i in arr2)
        {
            Console.WriteLine(i);
        }

        //shortcut to declare, instantiate and initialize
        int[] arr3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };//declaration, instantiation and initialization
        int[] arr4 = [1,2,3,4,5,6,7,8,9];//declaration, instantiation and initialization
    }
}