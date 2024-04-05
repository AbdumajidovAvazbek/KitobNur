using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;

namespace KitobNur.Desktop.Pages
{
    public partial class KitobQoshish : Page
    {
        public KitobQoshish()
        {
            InitializeComponent();
        }

        private void BrowseImageButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                ImagePathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void OrtgaButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle Ortga button click event
            // Implement navigation logic to go back
        }

        private void SaqlashButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle Saqlash button click event
            // Implement logic to save book details, including the image path
        }
    }
}
