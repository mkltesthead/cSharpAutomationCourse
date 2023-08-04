namespace ModularProgramExample
{
    public class BookPurchase : IPurchase
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

}
