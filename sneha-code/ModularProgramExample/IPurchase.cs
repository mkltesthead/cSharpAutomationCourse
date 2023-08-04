namespace ModularProgramExample
{
    public interface IPurchase
    {
        double CalculateTotalPrice(int quantity);
        string? DisplayProductDetails();
        int Quantity { get; set; }
    }
}
