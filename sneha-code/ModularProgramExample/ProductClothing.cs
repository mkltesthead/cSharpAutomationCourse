namespace ModularProgramExample
{
    public class Clothing : AbstractProduct
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

}
