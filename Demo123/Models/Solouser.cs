using System;
using System.Collections.Generic;

namespace Demo123.Models;

public partial class Solouser
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public DateOnly? ApplicationStart { get; set; }

    public DateOnly? ApplicationFinish { get; set; }

    public int? IdDepartment { get; set; }

    public int? EmployeId { get; set; }

    public string? PassportScreen { get; set; }

    public virtual Employe? Employe { get; set; }

    public virtual Department? IdDepartmentNavigation { get; set; }

    public virtual User? User { get; set; }
}
