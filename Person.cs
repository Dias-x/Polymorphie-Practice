namespace Praxis_Polymorphismus;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    //Methode Polymorhie
    public void Greet()
    {
        Console.WriteLine($"{FirstName} {LastName}: Hallo");
    }

    //Überladene Methode Polymorphie
    public void Greet(Person personToGreet)
    {
        Console.WriteLine($"{FirstName} {LastName} sagt: Hallo {personToGreet.FirstName} {personToGreet.LastName}");
    }
}