namespace OOP_CSharp_Lab1;

public class Person
{
    private string _firstName;
    private string _lastName;
    private DateTime _dateBirth;

    public Person(string firstName, string lastName, DateTime dateBirth)
    {
        _firstName = firstName;
        _lastName = lastName;
        _dateBirth = dateBirth;
    }

    public Person()
    {
        _firstName = "Имя";
        _lastName = "Фамилия";
        _dateBirth = DateTime.Now;
    }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public DateTime DateBirth
    {
        get { return _dateBirth; }
        set { _dateBirth = (value <= DateTime.Now) ? value : DateTime.Now; }
    }

    public int YearBirth
    {
        get { return _dateBirth.Year; }
        set { _dateBirth = value <= DateTime.Now.Year ? _dateBirth.AddYears(value - _dateBirth.Year) : DateTime.Now; }
    }

    public override string ToString()
    {
        return $"{_firstName} " +
               $"{_lastName}, " +
               $"date of birth: {_dateBirth}";
    }
    
    
}