// See https://aka.ms/new-console-template for more information

#pragma warning disable

namespace CodeTesting;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.AnimalSpeak(new Cat());
    }

    void AnimalSpeak(IAnimal animal)
    {
        Console.WriteLine(animal.Speak());
    }
}

public interface IAnimal
{
    string Name { get; set; }
    string Speak();
}

public class Dog : IAnimal
{
    public string Name { get; set; }

    public string Speak()
    {
        return "Woof";
    }

    public Dog()
    {
        Name = "Dog";
    }
}

class Cat : IAnimal
{
    public string Name { get; set; }

    public string Speak()
    {
        return "Meow";
    }

    public Cat()
    {
        Name = "Cat";
    }
}