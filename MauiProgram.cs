using MAUI_WORKSHOP.ViewModel;
using Microsoft.Extensions.Logging;

namespace MAUI_WORKSHOP;

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
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainViewModel>(); //Registro el sistema (MainPage.cs) en la dependencia de servicios. Al ser singleton solo se creera una vez

		return builder.Build();
	}
}
