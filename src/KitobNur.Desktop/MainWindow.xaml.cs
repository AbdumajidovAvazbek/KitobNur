using KitobNur.Desktop.Pages;
using KitobNur.Service.Interfaces.Books;
using KitobNur.Service.Services.Books;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using System.Windows.Controls;

namespace KitobNur.Desktop
{
    public partial class MainWindow : Window
    {
        private readonly IServiceProvider _serviceProvider;

        public MainWindow()
        {
            InitializeComponent();

            // Assign the serviceProvider parameter to the _serviceProvider field
        }

        // Handle Button 1 click event
        private void KitobButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the Kitob page
            MainFrame.Navigate(new Pages.Kitob(_serviceProvider));
        }



        // Handle Button 2 click event
        private void KitobxonButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the Kitob page
           // MainFrame.Navigate(new Uri("Books/Kitob.xaml", UriKind.Relative));
        }


        // Handle Button 3 click event
        private void ChallangeButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the Kitob page
          //  this.Content = new KitobNur.Desktop.Books.Kitob();
        }
    }
}
