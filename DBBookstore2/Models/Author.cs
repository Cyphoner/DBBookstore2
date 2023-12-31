﻿using System;
using System.Collections.Generic;

namespace DBBookstore2.Models;

public partial class Author
{
    public int AuthorId { get; set; }

    public string? AuthorFirstName { get; set; }

    public string? AuthorLastName { get; set; }

    public int? AuthorBirthDate { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
