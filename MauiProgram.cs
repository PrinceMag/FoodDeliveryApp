using MauiIcons.Cupertino;
using MauiIcons.Fluent;
using MauiIcons.Material;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace FoodApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseFluentMauiIcons()
            .UseMaterialMauiIcons()
            .UseCupertinoMauiIcons()
            .ConfigureSyncfusionCore()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("SpaceGrotesk-Bold.otf", "SpaceB");
                fonts.AddFont("SpaceGrotesk-Regular.otf", "SpaceR");
                fonts.AddFont("SpaceGrotesk-Medium.otf", "SpaceM");
                fonts.AddFont("SpaceGrotesk-SemiBold.otf", "SpaceSB");
                fonts.AddFont("Roboto-Regular.ttf", "RobotoR");
                fonts.AddFont("Roboto-Light.ttf", "RobotoL");
                fonts.AddFont("fontello.ttf", "Icons");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}