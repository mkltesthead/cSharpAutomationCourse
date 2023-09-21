namespace Car_Rental_Application
{

    abstract class Vehicle
    {
        public string Name { get; set; }
        public int Distance { get; set; }
        public Vehicle(string Name, int distance)
        {
            this.Name = Name;
            this.Distance = distance;

        }
        public string GetName() { return Name; }
        public int GetDistance() { return Distance; }
        public abstract void DisplayDetails();

        public abstract double VehicleRent(int Distance);


    }

    class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public double FuelEfficiency { get; set; }

        public int RentalFeePerKM = 14;
        public Car(string name, int distance, int doors, double efficiency) : base(name, distance)

        {

            NumberOfDoors = doors;

            FuelEfficiency = efficiency;

        }



        public override void DisplayDetails()

        {

            Console.WriteLine($"Car name is: {Name}");
            Console.WriteLine($"Fuel efficiency of car is: {FuelEfficiency} km/l");
            Console.WriteLine($"Number of doors of car are: {NumberOfDoors}");

            Console.WriteLine();

        }



        public override double VehicleRent(int distance)

        {

            return RentalFeePerKM * distance;

        }


    }

    class Motorcycle : Vehicle
    {
        public string TransmissionType { get; set; }

        public int EngineDisplacement { get; set; }

        public int RentalFeePerKM = 10;
        public Motorcycle(string name, int distance, string transmission, int displacement) : base(name, distance)

        {

            TransmissionType = transmission;

            EngineDisplacement = displacement;

        }

        public override void DisplayDetails()

        {

            Console.WriteLine($"Motorcycle name is: {Name}");

            Console.WriteLine($"Transmission type of motorcycle is: {TransmissionType}");

            Console.WriteLine($"Engine displacement in cc is: {EngineDisplacement} cc");

            Console.WriteLine();

        }

        public override double VehicleRent(int distance)
        {
            return RentalFeePerKM * distance;

        }
    }

    class Bicycle : Vehicle
    {
        public int NumberOfGears { get; set; }

        public string FrameMaterial { get; set; }

        public int RentalFeePerKM = 5;

        public Bicycle(string Name, int distance, int gears, string material) : base(Name, distance)
        {
            NumberOfGears = gears;

            FrameMaterial = material;
        }

        public override void DisplayDetails()

        {

            Console.WriteLine($"Bicycle name is: {Name}");

            Console.WriteLine($"Number of gears of bicycle are: {NumberOfGears}");

            Console.WriteLine($"Frame material of bicycle is made of: {FrameMaterial}");

            Console.WriteLine();

        }


        public override double VehicleRent(int distance)
        {
            return RentalFeePerKM * distance;

        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Vehicle> availableVehicles = new List<Vehicle>();
            availableVehicles.Add(new Car("SUV", 500, 4, 16.5));
            availableVehicles.Add(new Motorcycle("Royal Enfield Bullet 350", 100, "Manual", 350));
            availableVehicles.Add(new Bicycle("Mountain Bike", 50, 7, "Titanium"));


            Console.WriteLine("Available Vehicles");

            for (int i = 0; i < availableVehicles.Count; i++)
            {
                Console.WriteLine($"{i + 1} {availableVehicles[i].GetName()}");
            }

            Console.WriteLine();

            Console.WriteLine("Select vehicle from above list of vehicles to view details");

            int selectedVehicle = Convert.ToInt32(Console.ReadLine());

            Vehicle choice = availableVehicles[selectedVehicle - 1];
            Console.WriteLine("Vehicle Details");

            choice.DisplayDetails();

            double rent = choice.VehicleRent(choice.GetDistance());

            Console.WriteLine();
            Console.WriteLine($"Rent of {choice.GetName()} is : {rent}");


        }
    }
}

