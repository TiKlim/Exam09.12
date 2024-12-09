using System.Collections.Generic;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Demo123.Models;

namespace Demo123;

public partial class ChangeWindow : Window
{
    private List<User> users = DataSource.Helper.DataBase.Users.ToList();
    public ChangeWindow()
    {
        InitializeComponent();
        back.Click += Back_Click;
        soloUser.Click += SoloUser_Click;
    }

    private void SoloUser_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        foreach (User user in users)
        {
            FormWindow formWindow = new FormWindow(user!);
            formWindow.Show();
            Close();
        }
    } 

    private void Back_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Autorization autorization = new Autorization();
        autorization.Show();
        Close();
    } 
}