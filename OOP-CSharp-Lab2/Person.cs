namespace OOP_CSharp_Lab2;

public class Person: OOP_CSharp_Lab1.Person
{
    
    public override bool Equals(object? obj)
    {
        // [?] - m. b. null 
        // [Person person] - деконструкция: переменной person присваивается значение obj, приведённое к типу Person
        
        if (obj == null || (obj is not Person person))
            return false;
        return (
            FirstName == person.FirstName &&
            LastName == person.LastName &&
            DateBirth == person.DateBirth
            );
    }

    public static bool operator ==(Person? left, Person? right)
    {
        if (ReferenceEquals(left, right)) return true;
        if (left is null || right is null) return false;
        return left.Equals(right);
    }

    public static bool operator !=(Person? left, Person? right)
    {
        return !(left == right);
    }
    
    public override int GetHashCode()
    {
        // https://learn.microsoft.com/ru-ru/dotnet/api/system.object.gethashcode?view=net-8.0
        return HashCode.Combine(FirstName, LastName, DateBirth);
    }

    public virtual object DeepCopy()
    {
        var copy = new Person()
        {
            FirstName = new string(FirstName),
            LastName = new string(LastName),
            DateBirth = DateBirth
        };
        return copy;
    }
}


