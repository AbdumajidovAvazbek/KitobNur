using System.Windows;
using System.Windows.Controls;

namespace KitobNur.Desktop.Pages
{
    /// <summary>
    /// Interaction logic for KitobQidirish.xaml
    /// </summary>
    public partial class KitobQidirish : Page
    {
        public KitobQidirish()
        {
            InitializeComponent();
        }

        private void QidirishButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement search functionality based on NameTextBox and AuthorTextBox values
            string? name = KitobNomi.Text;
            string author = Muallifi.Text;
            // Perform search operations here
        }

        private void OrtgaButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate back to the Book page

            MainFrame.Navigate(new Kitob());
        }
    }
}
