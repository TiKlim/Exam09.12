using System;
using System.Collections.Generic;

namespace Demo123.Models;

public partial class Employe
{
    public int EmpId { get; set; }

    public string? EmpSurname { get; set; }

    public string? EmpName { get; set; }

    public string? EmpPatronymic { get; set; }

    public int? Department { get; set; }

    public virtual Department? DepartmentNavigation { get; set; }

    public virtual ICollection<Solouser> Solousers { get; set; } = new List<Solouser>();
}
