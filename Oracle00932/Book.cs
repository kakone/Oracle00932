using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace Oracle00932;

public class Book
{
    public int Id { get; set; }

    [Unicode(false)]
    [MaxLength(255)]
    public string Title { get; set; }

    [Unicode(false)]
    [MaxLength(50)]
    public string AuthorFirstName { get; set; }

    [Unicode(false)]
    [MaxLength(50)]
    public string AuthorLastName { get; set; }

    [DataType(DataType.Date)]
    public DateTimeOffset ReleaseDate { get; set; }
}
