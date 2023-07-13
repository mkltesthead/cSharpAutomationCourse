using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace CarRentalAppTests
{
    public class PolymorphicCarRentalApplicationTests
    {
        [Fact]
        public void DisplayDetails_ShouldReturnCorrectDetailsForAllVehicles()
        {
            // Arrange
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Car("Sedan", 4, 12.5),
                new Motorcycle("Sport Bike", "Manual", 1000),
                new Bicycle("Mountain Bike", 21, "Aluminum")
            };

            string expectedDetails =
                "Car: Sedan\n" +
                "Number of doors: 4\n" +
                "Fuel efficiency: 12.5 km/l\n\n" +
                "Motorcycle: Sport Bike\n" +
                "Transmission type: Manual\n" +
                "Engine displacement: 1000 cc\n\n" +
                "Bicycle: Mountain Bike\n" +
                "Number of gears: 21\n" +
                "Frame material: Aluminum\n\n";

            // Act
            using (var consoleOutput = new ConsoleOutput())
            {
                PolymorphicCarRentalApplication.Main();
                string actualDetails = consoleOutput.GetOutput();

                // Assert
                Assert.Equal(expectedDetails, actualDetails);
            }
        }
    }
}
}