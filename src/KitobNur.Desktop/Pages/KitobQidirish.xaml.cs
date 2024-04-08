using System;
using System.Windows;
using System.Windows.Controls;
using KitobNur.Service.Interfaces.Books;

namespace KitobNur.Desktop.Pages
{
    public partial class KitobQidirish : Page
    {
        private readonly IBookService _bookService;
        private readonly IServiceProvider _serviceProvider;

        public KitobQidirish(IBookService bookService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _bookService = bookService;
            _serviceProvider = serviceProvider;
        }



        private async void QidirishButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string author = Muallifi.Text;
                if (!string.IsNullOrEmpty(author))
                {
                    var bookResult = await _bookService.RetrieveByAuthorAsync(author);
                    if (bookResult != null)
                    {
                        // Navigate to ViewBookPage and pass the bookResult
                        NavigationService.Navigate(new ViewBookPage(bookResult));
                    }
                    else
                    {
                        MessageBox.Show("Book not found!");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter an author name!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void OrtgaButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate back to the previous page
            MainFrame.Navigate(new Kitob(_serviceProvider));
        }
    }
}
