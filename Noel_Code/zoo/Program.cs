using System;
using System.Collections.Generic;
using System.Linq;

namespace zoo
{

    public class Animal
    {
        public string name;
        public string type;
        public int multiplier;
        public Random random = new Random();

        public Animal()
        {
            this.name = "";
            this.type = "";
            this.multiplier = 0;
        }

        public virtual int Pet()
        {
            Console.WriteLine("I am an animal");
            return 0;
        }

        public virtual int Feed()
        {
            Console.WriteLine("I am an animal");
            return 0;
        }

        public virtual int Observe()
        {
            Console.WriteLine("I am an animal");
            return 0;
        }
    }

    public class Cat : Animal
    {
        public Cat(string nameIn)
        {
            this.name = nameIn;
            this.type = "cat";
            this.multiplier = 1;
        }

        public override int Pet()
        {
            int outcome = random.Next(0, (this.multiplier * 1) + 1);
            outcome = (outcome != this.multiplier * 1) ? -1 : this.multiplier * 1;
            Console.WriteLine($"When you pet {this.name} the {this.type} it {((outcome == -1) ? "scratches you" : "purrs")}.");
            return outcome;
        }

        public override int Feed()
        {
            int outcome = random.Next(0, (this.multiplier * 2) + 1);
            outcome = (outcome != this.multiplier * 2) ? -1 : this.multiplier * 2;
            Console.WriteLine($"When you feed {this.name} the {this.type} it {((outcome == -1) ? "sniffs the food and walks away" : "eats it all up")}.");
            return outcome;
        }

        public override int Observe()
        {
            int outcome = random.Next(0, (this.multiplier * 3) + 1);
            outcome = (outcome != this.multiplier * 3) ? -1 : this.multiplier * 3;
            Console.WriteLine($"When you observe {this.name} the {this.type} it {((outcome == -1) ? "arches its back and hisses at you" : "plays with a ball of string")}.");
            return outcome;
        }
    }

    public class Sheep : Animal
    {
        public Sheep(string nameIn)
        {
            this.name = nameIn;
            this.type = "sheep";
            this.multiplier = 2;
        }

        public override int Pet()
        {
            int outcome = random.Next(0, (this.multiplier * 1) + 1);
            outcome = (outcome != this.multiplier * 1) ? -1 : this.multiplier * 1;
            Console.WriteLine($"When you pet {this.name} the {this.type} it {((outcome == -1) ? "kicks you" : "baas")}.");
            return outcome;
        }

        public override int Feed()
        {
            int outcome = random.Next(0, (this.multiplier * 2) + 1);
            outcome = (outcome != this.multiplier * 2) ? -1 : this.multiplier * 2;
            Console.WriteLine($"When you feed {this.name} the {this.type} it {((outcome == -1) ? "gets colic and you have to call a vet" : "chews the grass thoughtfully")}.");
            return outcome;
        }

        public override int Observe()
        {
            int outcome = random.Next(0, (this.multiplier * 3) + 1);
            outcome = (outcome != this.multiplier * 3) ? -1 : this.multiplier * 3;
            Console.WriteLine($"When you observe {this.name} the {this.type} it {((outcome == -1) ? "jumps a fence and runs away" : "gambols around its field")}.");
            return outcome;
        }
    }

    public class Kangaroo : Animal
    {
        public Kangaroo(string nameIn)
        {
            this.name = nameIn;
            this.type = "kangaroo";
            this.multiplier = 3;
        }

        public override int Pet()
        {
            int outcome = random.Next(0, (this.multiplier * 1) + 1);
            outcome = (outcome != this.multiplier * 1) ? -1 : this.multiplier * 1;
            Console.WriteLine($"When you pet {this.name} the {this.type} it {((outcome == -1) ? "punches you" : "sings Waltzing Matilda")}.");
            return outcome;
        }

        public override int Feed()
        {
            int outcome = random.Next(0, (this.multiplier * 2) + 1);
            outcome = (outcome != this.multiplier * 2) ? -1 : this.multiplier * 2;
            Console.WriteLine($"When you feed {this.name} the {this.type} it {((outcome == -1) ? "bounds away" : "throws another shrimp on the barbie")}.");
            return outcome;
        }

        public override int Observe()
        {
            int outcome = random.Next(0, (this.multiplier * 3) + 1);
            outcome = (outcome != this.multiplier * 3) ? -1 : this.multiplier * 3;
            Console.WriteLine($"When you observe {this.name} the {this.type} it {((outcome == -1) ? "eats a crop" : "opens a tinnie and downs it")}.");
            return outcome;
        }
    }

    public class Horse : Animal
    {
        public Horse(string nameIn)
        {
            this.name = nameIn;
            this.type = "horse";
            this.multiplier = 4;
        }

        public override int Pet()
        {
            int outcome = random.Next(0, (this.multiplier * 1) + 1);
            outcome = (outcome != this.multiplier * 1) ? -1 : this.multiplier * 1;
            Console.WriteLine($"When you pet {this.name} the {this.type} it {((outcome == -1) ? "whinnies" : "neighs")}.");
            return outcome;
        }

        public override int Feed()
        {
            int outcome = random.Next(0, (this.multiplier * 2) + 1);
            outcome = (outcome != this.multiplier * 2) ? -1 : this.multiplier * 2;
            Console.WriteLine($"When you feed {this.name} the {this.type} it {((outcome == -1) ? "bolts and runs away" : "stops suddenly and eats grass")}.");
            return outcome;
        }

        public override int Observe()
        {
            int outcome = random.Next(0, (this.multiplier * 3) + 1);
            outcome = (outcome != this.multiplier * 3) ? -1 : this.multiplier * 3;
            Console.WriteLine($"When you observe {this.name} the {this.type} it {((outcome == -1) ? "rears up on it's hind legs" : "clears the fence at a gallop")}.");
            return outcome;
        }
    }

    public class Lion : Animal
    {
        public Lion(string nameIn)
        {
            this.name = nameIn;
            this.type = "lion";
            this.multiplier = 5;
        }

        public override int Pet()
        {
            int outcome = random.Next(0, (this.multiplier * 1) + 1);
            outcome = (outcome != this.multiplier * 1) ? -1 : this.multiplier * 1;
            Console.WriteLine($"When you pet {this.name} the {this.type} it {((outcome == -1) ? "mauls you" : "roars")}.");
            return outcome;
        }

        public override int Feed()
        {
            int outcome = random.Next(0, (this.multiplier * 2) + 1);
            outcome = (outcome != this.multiplier * 2) ? -1 : this.multiplier * 2;
            Console.WriteLine($"When you feed {this.name} the {this.type} it {((outcome == -1) ? "rips your arm off and plays with it" : "disembowls the wildebeast")}.");
            return outcome;
        }

        public override int Observe()
        {
            int outcome = random.Next(0, (this.multiplier * 3) + 1);
            outcome = (outcome != this.multiplier * 3) ? -1 : this.multiplier * 3;
            Console.WriteLine($"When you observe {this.name} the {this.type} it {((outcome == -1) ? "runs you down and rips your throat out" : "sleeps tonight")}.");
            return outcome;
        }
    }

    public class Zoo
    {
        static void Main(string[] args)
        {
            Zoo app = new Zoo();

            IDictionary<string, Animal> zoo = new Dictionary<string, Animal>()
            {
                { "cat"     , new Cat("Mittens")        },
                { "sheep"   , new Sheep("Dolly")        },
                { "kangaroo", new Kangaroo("Joey")      },
                { "horse"   , new Horse("Black Beauty") },
                { "lion"    , new Lion("Simba")         }
            };

            int total = 0;
            int score;
            for (int i = 0; i < 10; i++)
            {
                string animal;
                while (true)
                {
                    animal = app.getInput("Please select an animal: " + string.Join(", ", zoo.Keys.ToArray<string>())).ToLower();
                    if (zoo.ContainsKey(animal))
                    {
                        break;
                    }
                }
                while (true)
                {
                    string action = app.getInput($"Would you like to pet, feed or observe {zoo[animal].name} the {animal}?").ToLower();
                    if (action == "pet" || action == "feed" || action == "observe")
                    {
                        if (action == "pet")
                        {
                            score = zoo[animal].Pet();
                        }
                        else if (action == "feed")
                        {
                            score = zoo[animal].Feed();
                        }
                        else
                        {
                            score = zoo[animal].Observe();
                        }
                        total += score;
                        Console.WriteLine($"You scored {score}. Your total score is {total}.\r\n");
                        break;
                    }
                }
            }
            Console.WriteLine($"You scored {total}.");

            Console.ReadKey();
        }

        public string getInput(string prompt)
        {
            Console.WriteLine(prompt);
            string option = Console.ReadLine();
            //option = (option == "") ? " " : option.Substring(0, 1).ToLower();
            return option;
        }
    }
}