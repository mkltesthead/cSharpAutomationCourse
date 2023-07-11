using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks.");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows.");
    }
}

class PolymorphismAnimalSounds
{
    static void Main(string[] args)
    {
        Animal animal1 = new Animal();
        Animal animal2 = new Dog();
        Animal animal3 = new Cat();

        animal1.MakeSound(); // Output: The animal makes a sound.
        animal2.MakeSound(); // Output: The dog barks.
        animal3.MakeSound(); // Output: The cat meows.
    }
}
