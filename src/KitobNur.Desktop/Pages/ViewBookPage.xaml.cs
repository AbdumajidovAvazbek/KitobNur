using System.Windows.Controls;
using KitobNur.Service.Dtos.Books;

namespace KitobNur.Desktop.Pages
{
    public partial class ViewBookPage : Page
    {
        public ViewBookPage(BookForResultDto bookResult)
        {
            InitializeComponent();
            BookCard.DataContext = bookResult; // Set the DataContext of BookCard to the retrieved book data
        }
    }
}
