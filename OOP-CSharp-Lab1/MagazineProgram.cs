namespace OOP_CSharp_Lab1;

public class MagazineProgram
{
    public static void Main()
    {
        // 1
        Console.WriteLine("\n");
        var magazine = new Magazine();
        Console.WriteLine(magazine);
        Console.WriteLine("\n");
        
        // 2
        Console.WriteLine(magazine[Frequency.Weekly]);
        Console.WriteLine(magazine[Frequency.Monthly]);
        Console.WriteLine(magazine[Frequency.Yearly]);
        Console.WriteLine("\n");
        
        // 3
        magazine.Name = "Greeny News";
        magazine.Frequency = Frequency.Monthly;
        magazine.ReleaseDate = DateTime.Parse("2021-12-08");
        magazine.Circulation = 2000;
        magazine.ListArticle = new List<Article>
        {
            new Article(
                author: new Person("Ero", "Ruf", DateTime.Parse("1977-05-13")),
                name: "Hoolywood",
                rating: 4.2
                ),
            new Article(
                author: new Person("Djef", "Rufus", DateTime.Parse("1981-08-17")),
                name: "Ho-ho-ho",
                rating: 3.8
            ),
            new Article(
                author: new Person("Aio", "Run", DateTime.Parse("1993-10-08")),
                name: "Civilization",
                rating: 8.1
            )
        };
        Console.WriteLine(magazine);
        Console.WriteLine("\n");
        
        // 4
        magazine.AddArticles(
            new Article(
                author: new Person("No", "Name", DateTime.Parse("2002-02-02")),
                name: "None",
                rating: 0
            ),
            new Article(
                author: new Person("Trufo", "rICO", DateTime.Parse("2008-12-28")),
                name: "Elesh",
                rating: 5.5
            ),
            new Article(
                author: new Person("tt-113", "", DateTime.Parse("1978-03-03")),
                name: "A8 and 2B",
                rating: 7.4
            ));
        Console.WriteLine(magazine);
    }
}