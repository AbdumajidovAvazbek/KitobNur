using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KitobNur.Desktop.Pages
{
    /// <summary>
    /// Interaction logic for Kitob.xaml
    /// </summary>
    public partial class Kitob : Page
    {
        public Kitob()
        {
            InitializeComponent();
        }
        private void KitobQoshishButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new KitobQoshish());
        }
        private void QidirishButtin_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new KitobQidirish());
        }
        private void KitoblarButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new KitobQoshish());
        }
        private void OrtgaButton_Click(object sender, RoutedEventArgs e)
        {
            // Create a new instance of MainWindow
            MainWindow mainWindow = new MainWindow();

            // Show the new MainWindow
            mainWindow.Show();

            // Get the parent window of the current page
            Window parentWindow = Window.GetWindow(this);

            // Close the current MainWindow
            parentWindow.Close();
        }









    }
}
