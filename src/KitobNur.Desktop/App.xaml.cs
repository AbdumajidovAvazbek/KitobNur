using AutoMapper;
using KitobNur.Data.IRepositories;
using KitobNur.Data.Repositories;
using KitobNur.Desktop;
using KitobNur.Domain.Entities.Books;
using KitobNur.Domain.Entities.Categories;
using KitobNur.Service.Interfaces.Books;
using KitobNur.Service.Interfaces.Categories;
using KitobNur.Service.Services.Books;
using KitobNur.Service.Services.Categories;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

public partial class App : Application
{
    private static IServiceProvider _serviceProvider;

    public static IServiceProvider ServiceProvider => _serviceProvider;

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        // Setup DI container
        var services = new ServiceCollection();
        ConfigureServices(services);

        // Build the service provider
        _serviceProvider = services.BuildServiceProvider();

        // Create the main window and pass the service provider
        var mainWindow = new MainWindow();
        mainWindow.Show();
    }

    private void ConfigureServices(IServiceCollection services)
    {
        // Register your services and dependencies here
        services.AddSingleton<IMapper, Mapper>();
        services.AddScoped<IRepository<Book, long>, Repository<Book, long>>();
        services.AddScoped<IRepository<Category, int>, Repository<Category, int>>();
        services.AddScoped<IBookService, BookService>();
        services.AddScoped<ICategoryService, CategoryService>();
        // Add other services as needed...
    }
}
