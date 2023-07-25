class Animal
{
    public string? Name { get; set; }

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
        Console.WriteLine("The giraffe munches on leaves.");
    }
}

class Elephant : Animal
{
    public override void Sleep()
    {
        Console.WriteLine("The elephant lies down and takes a nap.");
    }
}

class Snake : Animal
{
    public override void Interact()
    {
        Console.WriteLine("The snake slides and hisses");
    }
}

class Fox : Animal
{
    public override void Interact()
    {
        Console.WriteLine("The fox sneaks in quietly");
    }
}

class ZooKeeper
{
    private int score;

    public void VisitAnimal(Animal animal)
    {

        switch (animal)
        {

            case Lion:
                animal.Eat();
                break;
            case Giraffe:
                animal.Eat();
                break;
            case Elephant:
                animal.Sleep();
                break;
            case Snake:
                animal.Interact();
                break;
            case Fox:
                animal.Interact();
                break;
            default:
                Console.WriteLine("Unknown animal type.");
                break;

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
        Lion lion = new Lion { Name = "David" };
        Giraffe giraffe = new Giraffe { Name = "Jerry" };
        Elephant elephant = new Elephant { Name = "Mustafa" };
        Snake snake = new Snake { Name = "Sally" };
        Fox fox = new Fox { Name = "Pluto" };

        ZooKeeper zooKeeper = new ZooKeeper();

        Console.WriteLine("Welcome to the Zoo!");

        while (true)
        {
            Console.WriteLine("\nSelect an animal to observe:");
            Console.WriteLine("1. Lion");
            Console.WriteLine("2. Giraffe");
            Console.WriteLine("3. Elephant");
            Console.WriteLine("4. Snake");
            Console.WriteLine("5. Fox");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice (1-6): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    zooKeeper.VisitAnimal(lion);
                    break;
                case 2:
                    zooKeeper.VisitAnimal(giraffe);
                    break;
                case 3:
                    zooKeeper.VisitAnimal(elephant);
                    break;
                case 4:
                    zooKeeper.VisitAnimal(snake);
                    break;
                case 5:
                    zooKeeper.VisitAnimal(fox);
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Invalid Choice.Please try again.");
                    break;

            }
            if (choice == 6)
                break;
        }

        int score = zooKeeper.GetScore();
        Console.WriteLine("Your total score: " + score);

        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }
}