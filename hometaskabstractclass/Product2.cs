

namespace hometaskabstractclass;

class Product2
{
   

    public string Name { get; set; }
    public int Price { get; set; }
    public int Count { get; set; }

    public void Detail()
    {
        Console.WriteLine($"Name: {Name}, Price: {Price}, Count: {Count}");
    }
    public void Discount(double precent)
    {
        
        double salePrice = Price - (Price * precent / 100);
        Console.WriteLine($"{salePrice} Discount Price");
    }
}