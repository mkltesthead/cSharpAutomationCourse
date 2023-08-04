namespace ModularProgramExample
{
    public class ClothingPurchase : IPurchase
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
}
