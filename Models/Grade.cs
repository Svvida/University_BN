using System;
using System.Collections.Generic;

namespace University_BN.Models;

public partial class Grade
{
    public int Id { get; set; }

    public string GradeEu { get; set; } = null!;

    public string GradeUsa { get; set; } = null!;

    public decimal Value { get; set; }
}
