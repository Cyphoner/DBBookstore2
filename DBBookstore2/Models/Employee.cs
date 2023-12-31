using System;
using System.Collections.Generic;

namespace DBBookstore2.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? EmployeeFirstName { get; set; }

    public string? EmployeeLastName { get; set; }

    public string? EmployeeEmail { get; set; }

    public int? StoreId { get; set; }

    public virtual Store? Store { get; set; }
}
