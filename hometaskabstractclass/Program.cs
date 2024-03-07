namespace hometaskabstractclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region Task 2
            Product2 product = new Product2();

            product.Name = "Qumarbaz";
            product.Count = 30;
            product.Price = 8;

            product.Detail();
            product.Discount(10);

        #endregion
        #region Task 3
        TakeAgaing:
            bool isCount = int.TryParse(Console.ReadLine(), out int count);

            if (!isCount)
            {
                goto TakeAgaing;
            }

            Book[] books = new Book[count];

            for (int i = 0; i < books.Length; i++)
            {
            TakeIdAgain:
                Console.WriteLine("Enter Id:");
                bool isId = int.TryParse(Console.ReadLine(), out int id);

                if (!isId)
                {
                    goto TakeIdAgain;
                }

                Console.WriteLine("Enter Name:");
                string name = Console.ReadLine();
            TakePriceAgain:
                Console.WriteLine("Enter Price:");
                bool isPrice = int.TryParse(Console.ReadLine(), out int price);

                if (!isPrice)
                {
                    goto TakePriceAgain;
                }
                //Console.WriteLine("Enter Book Count:");
                //int bookCount = int.Parse(Console.ReadLine());

                Console.WriteLine("Genre");
                string genre = Console.ReadLine();

                books[i] = new Book(id, name, price, genre);

            }

            foreach (var item in books)
            {
                item.Detail();
            }
            #endregion
        }
    }
}
