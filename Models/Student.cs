using System;
using System.Collections.Generic;

namespace University_BN.Models;

public partial class Student
{
    public int Id { get; set; }

    public int AddressId { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public DateOnly DateOfBirth { get; set; }

    public string Pesel { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public int? AccountId { get; set; }

    public virtual UsersAccount? Account { get; set; } = null!;

    public virtual StudentsAddress Address { get; set; } = null!;


}
