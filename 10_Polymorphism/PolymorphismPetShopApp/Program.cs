using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("unknown animal sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("woof");
    }

    public void Fetch()
    {
        Console.WriteLine("fetch is fun!");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("meow");
    }

    public void Scratch()
    {
        Console.WriteLine("I am a cat. I scratch things.");
    }
}

class PolymorphismPetShopApp
{
    static void Main(string[] args)
    {
        Dog buford = new Dog();
        buford.Fetch();
        buford.MakeSound();

        Console.WriteLine("**********");

        Cat chleo = new Cat();
        chleo.Scratch();
        chleo.MakeSound();

        Console.WriteLine("**********");

        Animal sven = new Animal(); // Upcasting
        sven.MakeSound();

        Console.WriteLine("**********");

        // Downcasting
        sven = new Dog();
        ((Dog)sven).Fetch();
        sven.MakeSound();

        Console.WriteLine("**********");

        sven = new Cat();
        sven.MakeSound();
        ((Cat)sven).Scratch();

        Console.WriteLine("**********");

        Feed(sven);
        Feed(buford);
        Feed(chleo);

        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }

    static void Feed(Animal animal)
    {
        if (animal is Dog)
        {
            Console.WriteLine("You have fed the dog dog food. Great work!");
        }
        else if (animal is Cat)
        {
            Console.WriteLine("You are feeding the cat cat food. Great work!");
        }
        else
        {
            Console.WriteLine("You are feeding the animal food. Great work!");
        }
    }
}
