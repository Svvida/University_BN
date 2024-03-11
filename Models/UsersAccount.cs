using System;
using System.Collections.Generic;

namespace University_BN.Models;

public partial class UsersAccount
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string Email { get; set; } = null!;

    public bool State { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual Student? Student { get; set; }

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
}
