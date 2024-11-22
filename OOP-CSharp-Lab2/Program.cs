using System.Collections;

namespace OOP_CSharp_Lab2;

public class Program
{
    public static void Main()
    {
        // 1
        Console.WriteLine("1 ---");
        var edition1 = new Edition("Foo", new DateTime(2002, 2, 2), 100);
        var edition2 = new Edition("Foo", new DateTime(2002, 2, 2), 100);
        
        Console.Write("Проверка ссылок между парой объектов типа Edition: ");
        Console.WriteLine(ReferenceEquals(edition1, edition2) ? "Ссылки равны": "Ссылки отличаются");
        Console.WriteLine();
        
        // 2
        Console.WriteLine("2 ---");
        try
        {
            edition1.CirculationProperty = -12;
            Console.WriteLine("Изменение произошло без ошибок");
        }
        catch (FormatException exc)
        {
            Console.WriteLine($"Ошибка: {exc.Message}");
        }
        Console.WriteLine();
        
        // 3
        Console.WriteLine("3 ---");
        var magazine = new Magazine(
            "Foo", OOP_CSharp_Lab1.Frequency.Monthly,
            new DateTime(2300, 3, 8), 100000, 8);
        
        magazine.AddArticles(
            new Article(new Person(), "FooBoo", 4.8),
            new Article(new Person(), "BooFoo", 5),
            new Article(new Person(), "BooBoo", 7.8)
            );
        magazine.AddEditors(
            new Person("Foo", "Boo", new DateTime(2000, 4, 3)),
            new Person("Boo", "Foo", new DateTime(1, 1, 1))
            );
        Console.WriteLine(magazine);
        Console.WriteLine();
        
        // 4
        Console.WriteLine("4 ---");
        Console.WriteLine(magazine.Edition);
        Console.WriteLine();

        // 5
        Console.WriteLine("5 ---");
        var magazineCopy = (Magazine)magazine.DeepCopy();

        magazineCopy.AddEditors(
            new Person("Boo", "Boo", new DateTime(5, 6, 7))
            );

        magazineCopy.Article = new ArrayList();
        
        Console.WriteLine(magazine);
        Console.WriteLine(magazineCopy);
        Console.WriteLine();
        
        // 6
        Console.WriteLine("6 ---");
        foreach (var article in magazine[5])
        {
            Console.WriteLine(article);
        }
        Console.WriteLine();
        
        // 7
        Console.WriteLine("7 ---");
        foreach (var article in magazine["Foo"])
        {
            Console.WriteLine(article);
        }
        Console.WriteLine();
    }
}