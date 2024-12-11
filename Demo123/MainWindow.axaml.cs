using System.Collections.Generic;
using System.Linq;
using Avalonia.Controls;
using Demo123.Models;

namespace Demo123
{
    public partial class MainWindow : Window
    {
        private List<User> users = DataSource.Helper.DataBase.Users.ToList();
        public MainWindow()
        {
            InitializeComponent();
            Guest.Click += Guest_Click;
            Welcome.Click += Welcome_Click;
        }

        private void Welcome_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            string login = loginTB.Text;
            string password = passwordTB.Text;

            foreach (User user in users)
            {
                if (user.Login == login && user.Password == password)
                {
                    Autorization autorization = new Autorization(user);
                    autorization.Show();
                    Close();
                }
                else
                {
                    ahtung.IsVisible = true;
                }
            }
        } 

        private void Guest_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
                Autorization autorization = new Autorization();
                autorization.Show();
                Close();
        } 
    }
}