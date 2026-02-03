public record Person
{
    public string Name { get; init; } = string.Empty;
    public int Age { get; init; }
}

public class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person { Name = "Alice", Age = 30 };
       var data=person with { Age = 31 ,Name="Akshay"};
        System.Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        Console.WriteLine($"Name: {data.Name}, Age: {data.Age}");
    }
}