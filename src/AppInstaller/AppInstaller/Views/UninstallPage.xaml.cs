using AppInstaller.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace AppInstaller.Views;

public sealed partial class UninstallPage : Page
{
    public UninstallViewModel ViewModel
    {
        get;
    }

    public UninstallPage()
    {
        ViewModel = App.GetService<UninstallViewModel>();
        InitializeComponent();
    }
}
