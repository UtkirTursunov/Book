using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book;

public class Book
{
    private string _author;
    private decimal _price;
    
    public string Author
    {
        get { return _author; }
        set { _author = value; }
    }
    public decimal Price
    {
        get { return _price; }
        set { _price = value; }
    }
    public string Name { get; set; }
    public int PublishYear { get; set; }
    public string Genre { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Book name: {Name}");
        Console.WriteLine($"It's author: {Author}");
        Console.WriteLine($"Price of book: {Price}");
        Console.WriteLine($"Publish year: {PublishYear}");
        Console.WriteLine(($"Genre: {Genre}"));
    }
    
    public void DiscountPrice(decimal percentage)
    {
        if (percentage > 0 && percentage < 100)
        {
            _price = _price * (percentage / 100);
        }
    }
}
    
