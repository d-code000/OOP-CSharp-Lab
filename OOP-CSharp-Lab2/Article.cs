namespace OOP_CSharp_Lab2;

public class Article: OOP_CSharp_Lab1.Article, IRateAndCopy
{
    /*
     * Ключевое слово [new] в данном контексте используется для скрытия унаследованного атрибута Author
     * и предоставления нового атрибута с тем же именем, но с другим типом
     */
    
    // new and override https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords
    public new Person Author
    {
        // Переопределение Author с новым типом OOP_CSharp_Lab2.Person
        get => (Person)base.Author;
        set => base.Author = value;
    }
    
    public new double Rating
    {
        get => base.Rating;
    }
    
    // Конструкторы не наследуются, поэтому определяем их явно
    public Article(Person person, string name, double rating) : base(person, name, rating){}
    public Article() : base(){}
    
    public virtual object DeepCopy()
    {
        Article copy = new Article((Person)Author.DeepCopy(), Name, Rating);
        return copy;
    }
    
    
}