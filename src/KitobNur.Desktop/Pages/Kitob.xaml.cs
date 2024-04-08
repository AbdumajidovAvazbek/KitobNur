using AutoMapper;
using KitobNur.Data.IRepositories;
using KitobNur.Domain.Entities.Books;
using KitobNur.Domain.Entities.Categories;
using KitobNur.Service.Interfaces.Books;
using KitobNur.Service.Services.Books;
using Microsoft.Extensions.DependencyInjection;
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
        private IMapper _mapper;
        private IBookRepository _bookRepository;
        private IRepository<Category, int> _categoryRepository;
        private IServiceProvider _serviceProvider;
        public Kitob(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            // Assign the serviceProvider parameter to the _serviceProvider field
            _serviceProvider = serviceProvider;
        }
        private void KitobQoshishButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new KitobQoshish());
        }
        private void QidirishButtin_Click(object sender, RoutedEventArgs e)
        {
            // Assuming _mapper, _bookRepository, and _categoryRepository are properly instantiated
            var bookService = new BookService(_mapper, _bookRepository, _categoryRepository); // Instantiate BookService

            // Pass the instantiated BookService to KitobQidirish constructor
            MainFrame.Navigate(new KitobQidirish(bookService,_serviceProvider));
        }


        private void KitoblarButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new KitobQoshish());
        }
        private void OrtgaButton_Click(object sender, RoutedEventArgs e)
        {
            // Create a new instance of MainWindow with the required IServiceProvider parameter
            MainWindow mainWindow = new MainWindow(); // Assuming ServiceProvider is a property in your App class

            // Show the new MainWindow
            mainWindow.Show();

            // Get the parent window of the current page
            Window parentWindow = Window.GetWindow(this);

            // Close the current MainWindow
            parentWindow.Close();
        }

    }
}
