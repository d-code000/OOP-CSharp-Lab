﻿namespace OOP_CSharp_Lab2;

public class Edition
{
    protected string Name;
    protected DateTime ReleaseDate;
    protected int Circulation;

    public Edition(string name, DateTime releaseDate, int circulation)
    {
        Name = name;
        ReleaseDate = releaseDate;
        Circulation = circulation;
    }

    public Edition()
    {
        Name = "Name:";
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
    
    public virtual Edition DeepCopy()
    {
        Edition copy = new Edition(
            new string(Name), 
            ReleaseDate, 
            Circulation
            );
        return copy;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || (obj is not Edition edition))
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