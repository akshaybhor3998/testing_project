// Need to generate Reverse String for Without reverse String function
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("please enter your string Value:");
        string original= Console.ReadLine();
        string reverseString = GenerateReverseString(original);
        Console.WriteLine("Original string : " + original);
        Console.WriteLine("reverseString string : " + reverseString);
    }
    static string GenerateReverseString(string input)
    {
        char[] charArray = new char[input.Length];
        int endIndex=input.Length-1;
        for(int startIndex =0; startIndex<=endIndex; startIndex++)
        {
            charArray[startIndex] = input[endIndex - startIndex];
        }
        return new string(charArray);
    }
}