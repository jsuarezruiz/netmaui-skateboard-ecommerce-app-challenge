using Microsoft.Extensions.Logging;
using SkateboardApp.Services;
using SkateboardApp.ViewModels;
using SkateboardApp.Views;

namespace SkateboardApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Mesa-Grande.ttf", "MesaGrande");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<BasketService>();
        builder.Services.AddSingleton<CheckoutViewModel>();
        builder.Services.AddSingleton<CheckoutView>();

        builder.Services.AddTransient<CustomizeViewModel>();
        builder.Services.AddTransient<CustomizeView>();

        return builder.Build();
	}
}
