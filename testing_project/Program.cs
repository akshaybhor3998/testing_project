using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        for(int i =1; i <= 6; ++i)
        {
            for(int j =1; j <= i; ++j)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}