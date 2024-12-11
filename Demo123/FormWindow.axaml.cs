using System;
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
        start.SelectedDate = DateTime.Now;
        finish.SelectedDate = DateTime.Now;
        dateOfBirth.SelectedDate = DateTime.Now;
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