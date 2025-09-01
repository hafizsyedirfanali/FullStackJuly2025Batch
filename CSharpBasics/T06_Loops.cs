namespace CSharpBasics;

public class T06_Loops
{
    public static void Test()
    {
        WhileLoop();
        // ForLoop();
        // DoWhileLoop();
        // ForeachLoop();
    }
    
     public static void ForEachLoop(){
        int[] array = new int[] {1,2,3,4,5,6,7};//size = 7
        foreach(var i in array){
            Console.WriteLine("Array Foreach - "+i);
        }
    }
    public static void ForLoop(){
        for(int i = 0; i < 10; i++){
            Console.WriteLine("ForLoop - "+i);
        }
        int[] array =new int[]  {1,2,3,4,5,6,7};//size = 7
        for(int i = 0; i < 7; i++){
            Console.WriteLine("Array For Loop - "+i);
        }
    }
    public static void DoWhileLoop(){
        int i = 0;
        do
        {
            Console.WriteLine("DoWhile - "+i);
            i++;
        }while(i < 10);
    }
    public static void WhileLoop()
    {
        int i = 0;
        while (i < 10)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}