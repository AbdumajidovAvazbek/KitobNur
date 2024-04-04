using KitobNur.Desktop.Pages;
using System.Windows;
using System.Windows.Controls;

namespace KitobNur.Desktop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Handle Button 1 click event
        private void KitobButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the Kitob page
            MainFrame.Navigate(new Pages.Kitob());
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
