namespace OnlineShoopingSystem
{
    // Create Abstract Class : Product
    public abstract class Product
    {
        public string? Name { get; set; }
        public double Price { get; set; }

        public abstract double CalculateTotalPrice(int quantity);

        public virtual string? DisplayProductDetails()
        {
            return $"Name: {Name}\nPrice: {Price}";
        }
    }

    // Extend the Product class to concrete classes
    public class Book : Product
    {
        public string? Author { get; set; }

        public override double CalculateTotalPrice(int quantity)
        {
            return Price * quantity * 1.1; // sales tax
        }

        public override string? DisplayProductDetails()
        {
            return base.DisplayProductDetails() + $"\nAuthor: {Author}";
        }
    }

    public class Clothing : Product
    {
        public string? Brand { get; set; }

        public string? size { get; set; }
        public override double CalculateTotalPrice(int quantity)
        {
            return Price * quantity * 1.1; // sales tax
        }
        public string? GetSize()
        {
            return size;
        }

        public override string? DisplayProductDetails()
        {
            return base.DisplayProductDetails() + $"\nBrand: {Brand}+ $\"\\nSize: {{size}}";
        }
    }

    //Create an interface called IPurchasable
    public interface IPurchasable
    {
        double CalculateTotalPrice(int quantity);
        string? DisplayProductDetails();
        int Quantity { get; set; }
    }

    //Implement the IPurchasable interface in concrete classes
    public class BookPurchasable : IPurchasable
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public string? Author { get; set; }
        public int Quantity { get; set; }

        public double CalculateTotalPrice(int quantity)
        {
            return Price * quantity * 1.1;
        }

        public string? DisplayProductDetails()
        {
            return $"Name: {Name}\nPrice: {Price}\nAuthor: {Author}\nQuantity: {Quantity}";
        }
    }


    public class ClothingPurchasable : IPurchasable
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public string? Brand { get; set; }
        public string? size { get; set; }
        public int Quantity { get; set; }

        public double CalculateTotalPrice(int quantity)
        {
            return Price * quantity * 1.1; // Include 10% tax
        }

        //reate the output to display the product details on the screen
        public string? DisplayProductDetails()
        {
            return $"Name: {Name}\nPrice: {Price}\nBrand: {Brand}\nSize: {size}\nQuantity: {Quantity}";
        }
    }


    class OnlineShopingSystem
    {
        static void Main(string[] args)
        {
            List<IPurchasable> products = new List<IPurchasable>();

            // Add some predefined products
            products.Add(new BookPurchasable()
            {
                Name = "Harry Potter",
                Price = 24.99,
                Author = "J K Rowling",
                Quantity = 7
            });

            products.Add(new ClothingPurchasable()
            {
                Name = "T Shirts",
                Price = 399.99,
                Brand = "Gap",
                size = "M",
                Quantity = 5
            }); ;

            Console.WriteLine("Product Options:");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {products[i].DisplayProductDetails()}");
            }
            Console.WriteLine();

            Console.WriteLine("Select a Product:");
            Console.Write("Enter the product number to select: ");
            int productNumber = int.Parse(Console.ReadLine());

            if (productNumber < 1 || productNumber > products.Count)
            {
                Console.WriteLine("Invalid product number. Exiting the program.");
                return;
            }

            IPurchasable selectedProduct = products[productNumber - 1];

            Console.WriteLine();
            Console.WriteLine("Selected Product Details:");
            Console.WriteLine(selectedProduct.DisplayProductDetails());

            Console.Write("Enter the quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            selectedProduct.Quantity = quantity;

            Console.WriteLine();
            Console.WriteLine("Product Details With Price:");
            Console.WriteLine(selectedProduct.DisplayProductDetails());
            Console.WriteLine($"Total Price for {quantity} items (including tax): {Math.Round(selectedProduct.CalculateTotalPrice(quantity), 2)}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}

