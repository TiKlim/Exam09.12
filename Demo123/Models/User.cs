using System;
using System.Collections.Generic;
using Avalonia.Media.Imaging;

namespace Demo123.Models;

public partial class User
{
    public int Id { get; set; }

    public string? UserSurname { get; set; }

    public string? UserName { get; set; }

    public string? UserPatronymic { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? Organization { get; set; }

    public string? Description { get; set; }

    public string? PassSeries { get; set; }

    public string? PassNumber { get; set; }

    public string? UserImage { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<Solouser> Solousers { get; set; } = new List<Solouser>();
    public Bitmap Picture => UserImage != null ? new Bitmap(@$"Assets\{UserImage}") : new Bitmap(@"Assets\User.jpg");
}
