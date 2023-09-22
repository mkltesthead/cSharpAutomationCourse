using System.Diagnostics;
using System.Xml.Linq;

namespace Shopping_System
{

    abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public abstract string DisplayDetails();

        public abstract double CalculatePrice();


    }

    interface IPurchasable
    {
        int Quantity { get; set; }
        double CalculateTotalPrice();
        string DisplayProductDetails();
    }


    class Electronic : Product
    {
        public double ShippingCost { get; set; }
        public int Quantity { get; set; }

        public static double GST = 1.2;

        public Electronic(int id, string name, double price, double shippingCost, int quantity)
            : base(id, name, price)
        {
            ShippingCost = shippingCost;
            Quantity = quantity;
        }

        public override string DisplayDetails()
        {
            return $"Id : {Id}\t Name: {Name}\t Price: {Price}\t Quantity: {Quantity}\t ShippingCost: {ShippingCost}";
        }

        public override double CalculatePrice()
        {
            return (Price * Quantity * GST) + ShippingCost;
        }
    }

    class Apparel : Product
    {
        public int Quantity { get; set; }

        public static double GST = 1.8;

        public Apparel(int id, string name, double price, int quantity)
              : base(id, name, price)
        {
            Quantity = quantity;
        }

        public override string DisplayDetails()
        {
            return $"Id : {Id}\t Name: {Name}\t Price: {Price}\t Quantity: {Quantity}";
        }

        public override double CalculatePrice()
        {
            return Price * Quantity * GST;
        }


    }

    class Laptop : IPurchasable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double ShippingCost { get; set; }
        public int Quantity { get; set; }

        public static double GST = 1.2;
        public double CalculateTotalPrice()
        {
            return (Price * Quantity * GST) + ShippingCost;
        }

        public string DisplayProductDetails()
        {
            return $"Id : {Id}\t Name: {Name}\t Price: {Price}\t Quantity: {Quantity}\t ShippingCost: {ShippingCost}";
        }
    }

    class Clothing : IPurchasable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public int Quantity { get; set; }

        public int Size { get; set; }

        public static double GST = 1.8;
        public double CalculateTotalPrice()
        {
            return Price * Quantity * GST;
        }

        public string DisplayProductDetails()
        {
            return $"Id : {Id}\t Name: {Name}\t Price: {Price}\t Quantity: {Quantity}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPurchasable> products = new List<IPurchasable>();


            products.Add(new Laptop()
            {
                Id = 1,

                Name = "Dell Vistro",

                Price = 50000,
                ShippingCost = 150,

                Quantity = 6

            });

            products.Add(new Clothing()
            {
                Id = 2,
                Name = "Jeans",
                Price = 2000,
                Size = 34,
                Quantity = 4,
            });
            Console.WriteLine("Shopping Cart Contents:");
            Console.WriteLine();

            for (int i = 0; i < products.Count; i++)

            {

                Console.WriteLine($"[{i + 1}] {products[i].DisplayProductDetails()}");

            }

            Console.WriteLine();





            Console.Write("Enter the product id to purchase the product: ");

            int productNumber = int.Parse(Console.ReadLine());



            if (productNumber < 1 || productNumber > products.Count)

            {

                Console.WriteLine("Product number is not correct. Please try again");

                return;

            }



            IPurchasable selectedProduct = products[productNumber - 1];



            Console.WriteLine();

            Console.WriteLine("Details of selected product:");

            Console.WriteLine(selectedProduct.DisplayProductDetails());

            while (true)
            {



                Console.Write("Quantity of product to purchase: ");

                int quantity = int.Parse(Console.ReadLine());





                if (quantity > selectedProduct.Quantity)
                {
                    Console.WriteLine("No enough quantity available. Please enter quantity again");
                    continue;
                }
                else
                {
                    selectedProduct.Quantity = quantity;
                }



                Console.WriteLine();

                Console.WriteLine("Product Details With Price:");

                Console.WriteLine(selectedProduct.DisplayProductDetails());

                Console.WriteLine($"Total amount to pay for {quantity} item : {selectedProduct.CalculateTotalPrice()}");


                Console.WriteLine("Thank you for shopping with us!");

                Console.WriteLine("Press any key to exit...");

                Console.ReadKey();
            }








        }
    }
}