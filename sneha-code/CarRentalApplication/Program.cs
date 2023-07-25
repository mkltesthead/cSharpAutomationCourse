namespace CarRentalApplication
{
    public abstract class Vehicle
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public double RentalFee { get; set; }
        public Vehicle(string name, int duration)
        {
            Name = name;
            Duration = duration;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetDuration()
        {
            return Duration;
        }

        public abstract void DisplayDetails();

        public abstract double GetRentalCharges(int Duration);
    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public double FuelEfficiency { get; set; }
        public double rentalFee = 75;

        public Car(string name, int duration, int doors, double efficiency) : base(name, duration)
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

        public override double GetRentalCharges(int duration)
        {
            return rentalFee * duration;
        }
    }

    public class Motorcycle : Vehicle
    {
        public string TransmissionType { get; set; }
        public int EngineDisplacement { get; set; }
        public double rentalFee = 50;

        public Motorcycle(string name, int duration, string transmission, int displacement) : base(name, duration)
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

        public override double GetRentalCharges(int duration)
        {

            return rentalFee * duration;
        }
    }

    public class Bicycle : Vehicle
    {
        public int NumberOfGears { get; set; }
        public string FrameMaterial { get; set; }
        public double rentalFee = 25;
        public Bicycle(string name, int duration, int gears, string material) : base(name, duration)
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

        public override double GetRentalCharges(int duration)
        {

            return rentalFee * duration;
        }
    }

    public class PolymorphicCarRentalApplication
    {
        public static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            // Create instances of vehicles
            Car car1 = new Car("Sedan", 10, 4, 12.5);
            Motorcycle motorcycle1 = new Motorcycle("Sport Bike", 20, "Manual", 1000);
            Bicycle bicycle1 = new Bicycle("Mountain Bike", 30, 21, "Aluminum");

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
            int selectedVehicleChoice;
            selectedVehicleChoice = Convert.ToInt32(Console.ReadLine());
            if (selectedVehicleChoice < 1 && selectedVehicleChoice > vehicles.Count)
            {
                Console.WriteLine("Invalid input. Please enter a valid vehicle number.");
                Console.Write("Enter the number of the vehicle you would like to rent: ");
            }

            Vehicle selectedVehicle = vehicles[selectedVehicleChoice - 1];

            Console.WriteLine();
            Console.WriteLine("Vehicle Details:");
            selectedVehicle.DisplayDetails();

            Console.WriteLine($"Rental Price: ${selectedVehicle.GetRentalCharges(selectedVehicle.GetDuration())}");

            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
