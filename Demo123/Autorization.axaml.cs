using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Demo123.DataSource;
using Demo123.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo123;

public partial class Autorization : Window
{
    private User User { get; set; }
    public Autorization()
    {
        InitializeComponent();
        goOut.Click += GoOut_Click;
        addPropusk.Click += AddPropusk_Click;
        User = new User();
        
        SetData();
    }
    public Autorization(User user)
    {
        InitializeComponent();
        goOut.Click += GoOut_Click;
        addPropusk.Click += AddPropusk_Click;
        User = user;

        SetData();
    }

    private void AddPropusk_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ChangeWindow changeWindow = new ChangeWindow();
        changeWindow.Show();
        Close();
    } 

    private void GoOut_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        Close();
    } 
    private void SetData()
    {
        propuskLB.ItemsSource = DataSource.Helper.DataBase.Solousers.Include(x => x.User);
        if(propuskLB.ItemCount > 0)
        {
            attention.IsVisible = false;
        }
    }
}