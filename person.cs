using System;

class Person
{
    // Funny Properties
    public string Name { get; set; }
    public int Age { get; set; }

    // Funny Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Fix Method to display person details
    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {Name} and I am {Age} years old.");
    }
}

class Program
{
    static void Main()
    {
        // Creating a Person object
        Person person1 = new Person("Alice", 25);
        person1.Introduce();
    }
}
