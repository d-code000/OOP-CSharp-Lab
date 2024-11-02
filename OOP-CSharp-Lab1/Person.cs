namespace OOP_CSharp_Lab;

public class Person
{
    private string firstName { get; set; }
    private string lastName { get; set; }
    private DateTime dateBirth { get; set; }

    public Person(string firstName, string lastName, DateTime dateBirth)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.dateBirth = dateBirth;
    }

    public Person()
    {
        firstName = "Имя";
        lastName = "Фамилия";
        dateBirth = DateTime.Now;
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public DateTime DateBirth
    {
        get { return dateBirth; }
        set { dateBirth = value; }
    }

    public int YearBirth
    {
        get { return dateBirth.Year; }
        set { dateBirth = dateBirth.AddYears(value); }
    }

    public override string ToString()
    {
        return base.ToString();
    }
    
    
}