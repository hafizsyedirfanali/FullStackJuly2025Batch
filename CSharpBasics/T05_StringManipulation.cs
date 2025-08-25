namespace CSharpBasics;
/// <summary>
/// These are different methods of working with string.
/// 1. Split - it is used to break the sentence into fragments in an array.
/// 2. Trimming = it is used to remove extra characters like space at the beginning and end, new line character, tab space, etc.
/// 3. Substring = it is used to take a part of sentence/string
/// 4. IndexOf = it is used to get the index of a character
/// 5. ToUpper/ToLower - to Upper and lower cases
/// 6. Equals = used for comparision
/// </summary>
public class T05_StringManipulation
{
    public static void Test()
    {
        Equals();
    }
    public static void Split()
    {
        string str = "This is a book";
        string[] fragments = str.Split(' ');
        string para = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?";
        string[] sentences = para.Split('.');
        
    }
    public static void Trim()
    {
        string str = " This is a book. ";
        string trimmed = str.Trim();
    }
    public static void IndexOf()
    {
        string str = "This is the pen. This is a book.";
        int indexOfa = str.IndexOf('a');
        string subString = str.Substring(indexOfa, 6);
    }
    public static void Substring()
    {
        string str = "This is the pen. This is a book.";
        string subString = str.Substring(8, 6);
    }
    public static void UpperLowerCase()
    {
        string str = "This is the pen. This is a book.";
        string upper = str.ToUpper();
        string lower = upper.ToLower();
        //it is used in comparasion without case.
        //case insensitive comparsion.
    }
    public static void Equals()
    {
        string emailStored = "A@A.com";
        string emailEntered = "a@a.com";
        bool isEqual = emailEntered.ToUpper() == emailStored.ToUpper();
        bool isEqual1 = emailStored.Equals(emailEntered,StringComparison.OrdinalIgnoreCase);
    }
}
