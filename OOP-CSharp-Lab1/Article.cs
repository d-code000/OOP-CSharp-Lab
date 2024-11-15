namespace OOP_CSharp_Lab;

public class Article
{
    public Person Author { get; set; }
    public string Name { get; set; }
    public double Rating { get; set; }

    public Article(Person author, string name, double rating)
    {
        Author = author;
        Name = name;
        Rating = rating;
    }

    public Article()
    {
        Author = new Person();
        Name = "Name";
        Rating = 0;
    }

    public override string ToString()
    {
        return $"Author: {Author}, " +
               $"Name: {Name}, " +
               $"Rating: {Rating:F2}";
    }
}