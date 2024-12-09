using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Demo123.Models;

namespace Demo123;

public partial class FormWindow : Window
{
    private User User { get; set; }
    public FormWindow()
    {
        InitializeComponent();
        User = new User();
        SetData();
    }
    public FormWindow(User user)
    {
        InitializeComponent();
        User = user;
        SetData();
    }


    private void SetData()
    {
    }
}