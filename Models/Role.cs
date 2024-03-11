using System;
using System.Collections.Generic;

namespace University_BN.Models;

public partial class Role
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<UsersAccount> UsersAccounts { get; set; } = new List<UsersAccount>();
}
