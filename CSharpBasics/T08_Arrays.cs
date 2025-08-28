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
        int[] arr4 = [1, 2, 3, 4, 5, 6, 7, 8, 9];//declaration, instantiation and initialization
    }

    public static void MultiDimensionalArray()
    {
        //It is of two types
        //1. Rectangular Array: Array of same size of arrays
        //Two dimensional array
        int[,] arr = new int[3, 4];//3 rows and 4 columns
        //index 0 -> [1,2,3,4]
        //index 1 -> [5,6,7,8]
        //index 2 -> [9,10,11,12]
        arr[0, 0] = 1;
        arr[0, 1] = 2;
        arr[0, 2] = 3;
        arr[0, 3] = 4;
        arr[1, 0] = 5;
        arr[1, 1] = 6;
        arr[1, 2] = 7;
        arr[1, 3] = 8;
        arr[2, 0] = 9;
        arr[2, 1] = 10;
        arr[2, 2] = 11;
        arr[2, 3] = 12;
        //reading data using for loop
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        //output
        //1 2 3 4
        //5 6 7 8
        //9 10 11 12

        //Three dimensional array
        //corelate with chapter:
        //there are two chapters, and in each chapter there are four topics
        //and in each topic there are two sub topics
        //Chapter 1: Topic 1.1: Sub topic 1.1.1, Sub topic 1.1.2
        int[,,] arr3D = new int[2, 4, 2];//2 rows, 4 columns and 2 depth
        //writing data
        arr3D[0, 0, 0] = 1;
        arr3D[0, 0, 1] = 2;
        arr3D[0, 1, 0] = 3;
        arr3D[0, 1, 1] = 4;
        arr3D[0, 2, 0] = 5;
        arr3D[0, 2, 1] = 6;
        arr3D[0, 3, 0] = 7;
        arr3D[0, 3, 1] = 8;
        arr3D[1, 0, 0] = 9;
        arr3D[1, 0, 1] = 10;
        arr3D[1, 1, 0] = 11;
        arr3D[1, 1, 1] = 12;
        arr3D[1, 2, 0] = 13;
        arr3D[1, 2, 1] = 14;
        arr3D[1, 3, 0] = 15;
        arr3D[1, 3, 1] = 16;
        //reading data using for loop
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Chapter {i}:");
            for (int j = 0; j < 4; j++)
            {
                Console.Write($" Topic {i}.{j}: ");
                for (int k = 0; k < 2; k++)
                {
                    Console.Write($" Sub topic {i}.{j}.{k}: {arr3D[i, j, k]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        //output
        //Chapter 0:
        // Topic 0.0:  Sub topic 0.0.0:
        // Topic 0.1:  Sub topic 0.1.0:
        // Topic 0.2:  Sub topic 0.2.0:
        // Topic 0.3:  Sub topic 0.3.0:
        // and so on...

        //2. Jagged Array: Array of different size of arrays
    }
}