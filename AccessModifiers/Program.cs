namespace AccessModifiers;
using DemoLibrary;

public class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();

        person.SavePerson();

        Console.ReadLine();
    }
}
