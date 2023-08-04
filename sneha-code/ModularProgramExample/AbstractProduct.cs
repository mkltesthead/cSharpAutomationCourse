namespace ModularProgramExample
{
    public abstract class AbstractProduct
    {
        // Create Abstract Class : Product

        public string? Name { get; set; }
        public double Price { get; set; }

        public abstract double CalculateTotalPrice(int quantity);

        public virtual string? DisplayProductDetails()
        {
            return $"Name: {Name}\nPrice: {Price}";
        }


    }
}
