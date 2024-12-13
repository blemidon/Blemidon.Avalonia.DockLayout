using ReactiveUI.Fody.Helpers;

namespace Blemidon.Avalonia.DockLayout.Demo.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [Reactive]
    public string Greeting { get; set; } = "Welcome to Avalonia!";
}
