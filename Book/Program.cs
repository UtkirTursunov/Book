namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book()
            {
                Name = "Atomic Habits",
                Author = "James Clear",
                Price = 45,
                Genre = "Self-help",
                PublishYear = 2018
            };

            book.DisplayInfo();
            book.DiscountPrice(50);
            Console.WriteLine();
            book.DisplayInfo();
        }
    }
}
