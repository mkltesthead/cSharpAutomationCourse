using System.Threading.Tasks.Sources;
using System.Xml.Linq;
using System;

namespace Zoo_Game
{


    class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a generic sound..");
        }

        public virtual void Eat()
        {
            Console.WriteLine("The animal is eating..");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("The animal is sleeping..");
        }

    }

    class Lion : Animal
    {
        public Lion(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} Lion Roars..");
        }


    }

    class Penguin : Animal
    {
        public Penguin(string name) : base(name) { }

        public override void Sleep()
        {
            Console.WriteLine($"{Name} penguin can sleep standing up on land..");
        }
    }

    class Elephant : Animal
    {
        public Elephant(string name) : base(name) { }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} Elephant Trumpets..");
        }
    }

    class Giraffe : Animal
    {
        public Giraffe(string name) : base(name) { }
        public override void Eat()
        {
            Console.WriteLine($"{Name} Giraffe extends its neck to eat..");
        }
    }
    class Fox : Animal
    {
        public Fox(string name) : base(name) { }
        public override void Eat()
        {
            Console.WriteLine($"{Name} Fox eats quietly..");
        }
    }

    class User
    {
        private int score;
        public void AnimalInteraction(Animal animal)
        {
            switch (animal)
            {
                case Lion:
                    animal.MakeSound();
                    break;
                case Penguin:
                    animal.Sleep();
                    break;
                case Giraffe:
                    animal.Eat();
                    break;
                case Elephant:
                    animal.MakeSound();
                    break;
                case Fox:
                    animal.Eat();
                    break;
                default:
                    Console.WriteLine("Animal does not exist..");
                    break;

            }
            score += 10;
        }

        public int GetScore()
        {
            return score;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion("Simba");
            Penguin penguin = new Penguin("Peng");
            Giraffe giraffe = new Giraffe("Grand");
            Elephant elephant = new Elephant("Dumbo");
            Fox fox = new Fox("Jimmy");

            //List<Animal> animals = new List<Animal>
            //{
            //    new Lion("Simba"),
            //    new Elephant("Dumbo"),
            //    new Penguin("Chilly")
            //};

            User user = new User();

            while (true)
            {


                Console.WriteLine("Select an animal to interact.....");
                Console.WriteLine();

                Console.WriteLine("1. Lion");

                Console.WriteLine("2. Giraffe");

                Console.WriteLine("3. Penguin");

                Console.WriteLine("4. Elephant");

                Console.WriteLine("5. Fox");

                Console.WriteLine("6. Exit");



                Console.Write("Enter your choice (1-6): ");

                int choice = Convert.ToInt32(Console.ReadLine());



                switch (choice)

                {

                    case 1:

                        user.AnimalInteraction(lion);

                        break;

                    case 2:

                        user.AnimalInteraction(giraffe);

                        break;

                    case 3:

                        user.AnimalInteraction(penguin);

                        break;
                    case 4:

                        user.AnimalInteraction(elephant);

                        break;

                    case 5:

                        user.AnimalInteraction(fox);

                        break;

                    case 6:

                        break;

                    default:

                        Console.WriteLine("Select correct option. Animal does not exist.");

                        break;



                }
                if (choice == 6)

                    break;

                int score = user.GetScore();

                Console.WriteLine("Your total score: " + score);
            }





            Console.WriteLine("Press any key to exit");

            Console.ReadKey();



        }





    }
}