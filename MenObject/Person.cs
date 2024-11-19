namespace MenObject;

public class Person()
{
    private string _firstName;
    private string _lastName;
    private bool _gender;
    private DateTime _birthday;

    public string FirstName
    {
        get { return _firstName; }
        set { _lastName = value; }
    }

    public string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }

    public bool Gender => _gender;

    public int Age
    {
        get
        {
            bool isAlreadyCome = Birthday.AddYears(DateTime.Now.Year - Birthday.Year) < DateTime.Now;
            return DateTime.Now.Year - Birthday.Year - (isAlreadyCome ? 0 : 1);
        }
    }

    public DateTime Birthday
    {
        get => _birthday;
        set
        {
            if (value > DateTime.Now) _birthday = DateTime.Now;
            else if (value < DateTime.Now.AddYears(-130)) _birthday = DateTime.Now.AddYears(-130);
            else _birthday = value;
            
        }
    }

    public string MiddleName
    {
        get; set;
    }

    public override string ToString()
    {
        return $"{LastName} {FirstName} {MiddleName} Возраст: {Age}";
    }
}