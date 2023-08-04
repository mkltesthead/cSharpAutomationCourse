namespace ModularProgramExample
{
    internal class ProductBook : AbstractProduct
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
}
