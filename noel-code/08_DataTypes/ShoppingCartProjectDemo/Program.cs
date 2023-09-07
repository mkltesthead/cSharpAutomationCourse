using System;
using System.Collections.Generic;
using System.Text;

public class Cart
{
    private List<string> items;
    private List<double> prices;
    private double total;

    public Cart()
    {
        items = new List<string>();
        prices = new List<double>();
        total = 0.0;
    }

    public void AddItem(string item, double price)
    {
        items.Add(item);
        prices.Add(price);
        total += price;
    }

    public string GenerateReceipt()
    {
        StringBuilder receipt = new StringBuilder();

        receipt.Append("----- Receipt -----\n");
        for (int i = 0; i < items.Count; i++)
        {
            receipt.Append(items[i]).Append("\t$").Append(prices[i]).Append("\n");
        }
        receipt.Append("\nTotal: $").Append(total);

        return receipt.ToString();
    }
}

public class ShoppingCartProjectDemo
{
    public static void Main(string[] args)
    {
        Cart myCart = new Cart();

        myCart.AddItem("Maono PM500 Microphone", 120.99);
        myCart.AddItem("Focusrite Scarlett 8i6 Digital Interface", 299.99);
        myCart.AddItem("Presonus Faderport Controller", 199.99);

        string receipt = myCart.GenerateReceipt();
        Console.WriteLine(receipt);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}