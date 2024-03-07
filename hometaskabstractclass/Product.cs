

namespace hometaskabstractclass;

internal class Product
{
    public Product(int id, string name, int price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public int Count { get; set; }
    private object Detail(string name, int price, int count)
    {
        return name + price + count;
    }
   


}
