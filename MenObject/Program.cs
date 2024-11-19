using MenObject;

Person person1 = new Person()
{
    FirstName = "Цой",
    LastName = "Виктор",
    MiddleName = "Робертович",
    Birthday = DateTime.Parse("1962/06/21")
};

Console.WriteLine(person1);