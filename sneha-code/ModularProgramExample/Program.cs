namespace ModularProgramExample
{
    class OnlineShopingSystem
    {
        static void Main(string[] args)
        {
            List<IPurchase> products = new List<IPurchase>();

            // Add some predefined products
            products.Add(new BookPurchase()
            {
                Name = "Harry Potter",
                Price = 24.99,
                Author = "J K Rowling",
                Quantity = 7
            });

            products.Add(new ClothingPurchase()
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

            IPurchase selectedProduct = products[productNumber - 1];

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

