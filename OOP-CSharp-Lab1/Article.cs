namespace OOP_CSharp_Lab;

public class Article
{
    public Person Author;
    public string Name;
    public double Rating;

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