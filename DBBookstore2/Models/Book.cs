using System;
using System.Collections.Generic;

namespace DBBookstore2.Models;

public partial class Book
{
    public string Isbn13 { get; set; } = null!;

    public string? BookTitle { get; set; }

    public string? BookLanguage { get; set; }

    public decimal? BookPrice { get; set; }

    public int? BookDate { get; set; }

    public int? AuthorId { get; set; }

    public virtual Author? Author { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<StockBalance> StockBalances { get; set; } = new List<StockBalance>();
}
