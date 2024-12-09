using System;
using System.Collections.Generic;

namespace Demo123.Models;

public partial class Department
{
    public int DepId { get; set; }

    public string? DepName { get; set; }

    public virtual ICollection<Employe> Employes { get; set; } = new List<Employe>();

    public virtual ICollection<Solouser> Solousers { get; set; } = new List<Solouser>();
}
