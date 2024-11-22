namespace OOP_CSharp_Lab2;

public class Edition
{
    // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/accessibility-levels
    // Доступ ограничен содержащим классом или типами, производными от содержащего класса

    protected string Name;
    protected DateTime ReleaseDate;
    protected int Circulation;

    public Edition(string name, DateTime releaseDate, int circulation)
    {
        Name = name;
        ReleaseDateProperty = releaseDate;
        CirculationProperty = circulation;
    }

    public Edition()
    {
        Name = "Name";
        ReleaseDate = DateTime.Now;
        Circulation = 0;
    }

    public string NameProperty
    {
        get => Name;
        set => Name = value;
    }

    public DateTime ReleaseDateProperty
    {
        get => ReleaseDate;
        set
        {
            if (value > DateTime.Now)
                throw new FormatException("Дата релиза не может превосходить текущую");
            ReleaseDate = value;
        }
    }

    public int CirculationProperty
    {
        get => Circulation;
        set
        {
            if (value < 0)
                throw new FormatException("Тираж не может быть отрицательным");
            Circulation = value;
        }
    }

    // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords
    public virtual Edition DeepCopy() => new Edition(new string(Name), ReleaseDate, Circulation);

    public override bool Equals(object? obj)
    {
        if (obj is not Edition edition)
            return false;
        return (
            Name == edition.Name &&
            ReleaseDate == edition.ReleaseDate &&
            Circulation == edition.Circulation
        );
    }

    public static bool operator ==(Edition? left, Edition? right)
    {
        if (ReferenceEquals(left, right)) return true;
        if (left is null || right is null) return false;
        return left.Equals(right);
    }

    public static bool operator !=(Edition? left, Edition? right)
    {
        return !(left == right);
    }
    
    public override int GetHashCode()
    {
        // https://learn.microsoft.com/ru-ru/dotnet/api/system.object.gethashcode?view=net-8.0
        return HashCode.Combine(NameProperty, ReleaseDateProperty, CirculationProperty);
    }

    public override string ToString()
    {
        return $"{Name}: {ReleaseDate} ({Circulation})";
    }
}