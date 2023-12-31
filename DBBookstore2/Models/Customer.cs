using System;
using System.Collections.Generic;

namespace DBBookstore2.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public int? PhoneNumber { get; set; }
}
