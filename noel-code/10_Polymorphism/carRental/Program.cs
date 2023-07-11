using System;

abstract class Vehicle
{
    public string name { get; set; }
    public abstract string getName();
    public abstract void displayDetails();
}

class Car : Vehicle
{
    public int doorCount;
    public double fuelEfficiency;

    public Car(string nameIn, int doorCountIn, double fuelEfficiencyIn)
    {
        this.name = nameIn;
        this.doorCount = doorCountIn;
        this.fuelEfficiency = fuelEfficiencyIn;
    }
    public override string getName()
    {
        return name;
    }

    public override void displayDetails()
    {
        Console.WriteLine(string.Join("\r\n", new string[] {
            $"Name: {name}",
            $"Number of doors: {doorCount}",
            $"Fuel efficiency: {fuelEfficiency} litres per 100 km"
        }));
    }
}

class Motorcycle : Vehicle
{
    public string transmissionType;
    public double engineDisplacement;

    public Motorcycle(string nameIn, string transmissionTypeIn, double engineDisplacementIn)
    {
        this.name = nameIn;
        this.transmissionType = transmissionTypeIn;
        this.engineDisplacement = engineDisplacementIn;
    }
    public override string getName()
    {
        return name;
    }

    public override void displayDetails()
    {
        Console.WriteLine(string.Join("\r\n", new string[] {
            $"Name: {name}",
            $"Transmission type: {transmissionType}",
            $"Engine displacement: {engineDisplacement} litres"
        }));
    }
}

class Bicycle : Vehicle
{
    public int gearCount;
    public string frameMaterial;

    public Bicycle(string nameIn, int gearCountIn, string frameMaterialIn)
    {
        this.name = nameIn;
        this.gearCount = gearCountIn;
        this.frameMaterial = frameMaterialIn;
    }
    public override string getName()
    {
        return name;
    }

    public override void displayDetails()
    {
        Console.WriteLine(string.Join("\r\n", new string[] {
            $"Name: {name}",
            $"Number of gears: {gearCount}",
            $"Frame material: {frameMaterial}"
        }));
    }
}

namespace carRental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = {
                new Car("Ford Fiesta", 5, 10.5),
                new Motorcycle("Kawasaki Hyabusa", "manual", 3.5),
                new Bicycle("Raleigh Chopper", 21, "carbon fibre")
            };

            foreach (var vehicle in vehicles)
            {
                vehicle.displayDetails();
                Console.WriteLine();
            }
        }
    }
}
