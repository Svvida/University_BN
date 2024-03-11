using System;
using System.Collections.Generic;

namespace University_BN.Models;

public partial class EmployeesAddress
{
    public int Id { get; set; }

    public string Country { get; set; } = null!;

    public string City { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public string Street { get; set; } = null!;

    public string BuildingNumber { get; set; } = null!;

    public string ApartmentNumber { get; set; } = null!;

    public virtual Employee? Employee { get; set; }
}
