using System;

namespace FinalExamPrep
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof woof");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Animal myAnimal = new Dog();
            myAnimal.MakeSound();

            Console.WriteLine("Press any Key to exit");
            Console.ReadKey();
        }
    }
}
