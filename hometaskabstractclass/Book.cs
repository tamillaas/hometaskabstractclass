

namespace hometaskabstractclass;

internal class Book : Product
{
    public Book(int id, string name, int price, string genre) : base(id, name, price)
    {
        Genre = genre;
    }

    public string Genre { get; set; }

    public void Detail()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name}, Price: {Price}, Genre: {Genre}");
    }
}
