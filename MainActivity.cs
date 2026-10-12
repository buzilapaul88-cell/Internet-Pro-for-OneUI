using Android.App;
using Android.Content.PM;
using Avalonia.Android;
using InternetPro.Platforms.Shared;

namespace InternetPro.Platforms.Android;

[Activity(
    Label = "Internet Pro",
    MainLauncher = true,
    ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.UiMode)]
public sealed class MainActivity : AvaloniaMainActivity<App>
{
}