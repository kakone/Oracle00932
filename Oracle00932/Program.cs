using System;
using System.Linq;

namespace Oracle00932;

internal class Program
{
    private static void Main()
    {
        using var dbContext = new MyDbContext();
        var author = (from b in dbContext.Books
                      select b.AuthorFirstName + " " + b.AuthorLastName).FirstOrDefault();
        Console.WriteLine($"Author: {author}");
    }
}
