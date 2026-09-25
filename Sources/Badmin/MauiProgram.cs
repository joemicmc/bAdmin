namespace Badmin
{
	using Badmin.ViewModels;
	using Badmin.Views;

	using CommunityToolkit.Maui;

	using Microsoft.Extensions.Logging;

	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.UseMauiCommunityToolkit()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				});

#if DEBUG
			builder.Logging.AddDebug();
#endif
			builder.Services.AddSingleton<TableViewModel>();
			builder.Services.AddSingleton<SessionViewModel>();
			builder.Services.AddSingleton<PlayersViewModel>();

			builder.Services.AddTransientWithShellRoute<EditPlayerView, EditPlayerViewModel>("player");

			return builder.Build();
		}
	}
}
