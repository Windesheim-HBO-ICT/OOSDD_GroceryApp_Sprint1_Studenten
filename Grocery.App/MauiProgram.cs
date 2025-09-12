using Grocery.Core.Services;
using Grocery.App.ViewModels;
using Grocery.App.Views;
using Microsoft.Extensions.Logging;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Data.Repositories;

namespace Grocery.App
{
    public static class MauiProgram
    {
        // Entry point for configuring and creating the Maui application
        public static MauiApp CreateMauiApp()
        {
            // Create a new MauiApp builder
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>() // Set the main application class
                .ConfigureFonts(fonts =>
                {
                    // Register custom fonts
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            // Enable debug logging in debug mode
            builder.Logging.AddDebug();
#endif
            // Register services and repositories for dependency injection
            builder.Services.AddSingleton<IGroceryListService, GroceryListService>();
            builder.Services.AddSingleton<IGroceryListItemsService, GroceryListItemsService>();
            builder.Services.AddSingleton<IProductService, ProductService>();
            builder.Services.AddSingleton<IGroceryListRepository, GroceryListRepository>();
            builder.Services.AddSingleton<IGroceryListItemsRepository, GroceryListItemsRepository>();
            builder.Services.AddSingleton<IProductRepository, ProductRepository>();

            // Register views and their corresponding view models for navigation
            builder.Services.AddTransient<GroceryListsView>().AddTransient<GroceryListViewModel>();
            builder.Services.AddTransient<GroceryListItemsView>().AddTransient<GroceryListItemsViewModel>();
            builder.Services.AddTransient<ProductView>().AddTransient<ProductViewModel>();

            // Build and return the configured MauiApp
            return builder.Build();
        }
    }
}
