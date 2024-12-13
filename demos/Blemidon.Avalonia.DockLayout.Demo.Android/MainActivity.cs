using Android.App;
using Android.Content.PM;
using Avalonia;
using Avalonia.Android;

namespace Blemidon.Avalonia.DockLayout.Demo.Android;

[Activity(
    Label = "Blemidon.Avalonia.DockLayout.Demo.Android",
    Theme = "@style/MyTheme.NoActionBar",
    Icon = "@drawable/icon",
    MainLauncher = true,
    ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.UiMode)]
public class MainActivity : AvaloniaMainActivity<App>
{
    protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
    {
        return base.CustomizeAppBuilder(builder)
            .WithInterFont();
    }
}
