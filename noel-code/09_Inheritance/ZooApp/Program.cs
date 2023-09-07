using System;

class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public virtual void Interact()
    {
        Console.WriteLine("You observe the animal closely.");
    }

    public virtual void Eat()
    {
        Console.WriteLine("The animal is eating.");
    }

    public virtual void Sleep()
    {
        Console.WriteLine("The animal is sleeping.");
    }
}

class Lion : Animal
{
    public override void Eat()
    {
        Console.WriteLine("The lion settles in to eat its rare steak.");
    }
}

class Giraffe : Animal
{
    public override void Eat()
    {
        Console.WriteLine("The giraffe munches on leaves from the tall tree.");
    }
}

class Elephant : Animal
{
    public override void Sleep()
    {
        Console.WriteLine("The elephant lies down and takes a nap.");
    }
}

class ZooKeeper
{
    private int score;

    public void VisitAnimal(Animal animal)
    {
        animal.Interact();
        if (animal is Lion lion)
        {
            lion.Eat();
        }
        else if (animal is Giraffe giraffe)
        {
            giraffe.Eat();
        }
        else if (animal is Elephant elephant)
        {
            elephant.Sleep();
        }
        else
        {
            Console.WriteLine("Unknown animal type.");
        }
        score += 10;
    }

    public int GetScore()
    {
        return score;
    }
}

class ZooApp
{
    static void Main(string[] args)
    {
        Lion lion = new Lion { Name = "Leo", Age = 5 };
        Giraffe giraffe = new Giraffe { Name = "Gerry", Age = 3 };
        Elephant elephant = new Elephant { Name = "Ellie", Age = 10 };

        ZooKeeper zooKeeper = new ZooKeeper();

        Console.WriteLine("Welcome to the Zoo!");

        while (true)
        {
            Console.WriteLine("\nSelect an animal to observe:");
            Console.WriteLine("1. Lion (Age: " + lion.Age + ")");
            Console.WriteLine("2. Giraffe (Age: " + giraffe.Age + ")");
            Console.WriteLine("3. Elephant (Age: " + elephant.Age + ")");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                zooKeeper.VisitAnimal(lion);
            }
            else if (choice == "2")
            {
                zooKeeper.VisitAnimal(giraffe);
            }
            else if (choice == "3")
            {
                zooKeeper.VisitAnimal(elephant);
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        int score = zooKeeper.GetScore();
        Console.WriteLine("Your total score: " + score);

        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }
}