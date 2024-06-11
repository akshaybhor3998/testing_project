public class Testing
{
    public static void Main(string[] args)
    {
        int[] data = { 1, 2, 3, 4, 5, 6,5 };
        Array.Sort(data,(x,y)=>y.CompareTo(x));
        foreach (var item in data)
        {
            Console.WriteLine(item + " ");
        }
    }
}