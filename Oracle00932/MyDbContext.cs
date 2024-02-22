using Microsoft.EntityFrameworkCore;

namespace Oracle00932;

internal class MyDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseOracle("Data Source=localhost:1521/ORCL;User Id=userId;Password=password;");
    }
}
