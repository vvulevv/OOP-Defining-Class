using System;

class Persons
{
    static void Main()
    {
        Person gosho = new Person("Gosho", 10, "goshko_goshe@abv.bg");
        Console.WriteLine(gosho);
    }
}

public class Person
{
    private int age;
    private string name;
    private string email;

    public int Age
    {
        get { return this.age; }
        set
        {
            if ((age < 0) || (age > 100))
            {
                throw new ArgumentOutOfRangeException("The age should be in range [0..100]");
            }
            this.age = value;       
        }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public string Email
    {
        get { return this.email; }
        set
        {
            if (null != email && (email.Length == 0 || !email.Contains("@")))
            {
                throw new ArgumentNullException("You've entered invalid email. Your email cannot be empty and should contain the symbol \"@\".");
            }
            this.email = value;
        }
    }

    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public Person(string name, int age) : this(name, age, null) { }

    public override string ToString()
    {   
        return "My name is " +  this.name + " and I am " + this.age + " years old. You can link with me at: " + this.email;
    }
}
