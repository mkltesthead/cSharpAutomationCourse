using System;
using System.Collections.Generic;

namespace CarRentalApplication
{
    public abstract class Vehicle
    {
        public string Name { get; set; }

        public Vehicle(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public abstract void DisplayDetails();

        public abstract decimal GetRentalPrice();
    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public double FuelEfficiency { get; set; }

        public Car(string name, int doors, double efficiency) : base(name)
        {
            NumberOfDoors = doors;
            FuelEfficiency = efficiency;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Car: {Name}");
            Console.WriteLine($"Number of doors: {NumberOfDoors}");
            Console.WriteLine($"Fuel efficiency: {FuelEfficiency} km/l");
            Console.WriteLine();
        }

        public override decimal GetRentalPrice()
        {
            return 75;
        }
    }

    public class Motorcycle : Vehicle
    {
        public string TransmissionType { get; set; }
        public int EngineDisplacement { get; set; }

        public Motorcycle(string name, string transmission, int displacement) : base(name)
        {
            TransmissionType = transmission;
            EngineDisplacement = displacement;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Motorcycle: {Name}");
            Console.WriteLine($"Transmission type: {TransmissionType}");
            Console.WriteLine($"Engine displacement: {EngineDisplacement} cc");
            Console.WriteLine();
        }

        public override decimal GetRentalPrice()
        {
            return 50;
        }
    }

    public class Bicycle : Vehicle
    {
        public int NumberOfGears { get; set; }
        public string FrameMaterial { get; set; }

        public Bicycle(string name, int gears, string material) : base(name)
        {
            NumberOfGears = gears;
            FrameMaterial = material;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Bicycle: {Name}");
            Console.WriteLine($"Number of gears: {NumberOfGears}");
            Console.WriteLine($"Frame material: {FrameMaterial}");
            Console.WriteLine();
        }

        public override decimal GetRentalPrice()
        {
            return 25;
        }
    }

    public class PolymorphicCarRentalApplication
    {
        public static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            // Create instances of vehicles
            Car car1 = new Car("Sedan", 4, 12.5);
            Motorcycle motorcycle1 = new Motorcycle("Sport Bike", "Manual", 1000);
            Bicycle bicycle1 = new Bicycle("Mountain Bike", 21, "Aluminum");

            // Add vehicles to the list
            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(bicycle1);

            Console.WriteLine("Welcome to the Car Rental Application!");

            // Display available vehicles
            Console.WriteLine("Available Vehicles:");
            for (int i = 0; i < vehicles.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {vehicles[i].GetName()}");
            }

            Console.WriteLine();

            // Prompt user to select a vehicle
            Console.Write("Enter the number of the vehicle you would like to rent: ");
            int selectedVehicleIndex;
            while (!int.TryParse(Console.ReadLine(), out selectedVehicleIndex) || selectedVehicleIndex < 1 || selectedVehicleIndex > vehicles.Count)
            {
                Console.WriteLine("Invalid input. Please enter a valid vehicle number.");
                Console.Write("Enter the number of the vehicle you would like to rent: ");
            }

            Vehicle selectedVehicle = vehicles[selectedVehicleIndex - 1];

            Console.WriteLine();
            Console.WriteLine("Vehicle Details:");
            selectedVehicle.DisplayDetails();

            Console.WriteLine($"Rental Price: ${selectedVehicle.GetRentalPrice()}");

            Console.ReadLine();
        }
    }
}
