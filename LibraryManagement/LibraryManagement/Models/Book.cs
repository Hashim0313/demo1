using System;
using System.Collections.Generic;

namespace LibraryManagement.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string? Bookname { get; set; }

    public string? Author { get; set; }

    public decimal? Price { get; set; }
}
