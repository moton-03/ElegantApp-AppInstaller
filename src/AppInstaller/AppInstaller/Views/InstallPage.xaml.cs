using AppInstaller.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace AppInstaller.Views;

public sealed partial class InstallPage : Page
{
    public InstallViewModel ViewModel
    {
        get;
    }

    public InstallPage()
    {
        ViewModel = App.GetService<InstallViewModel>();
        InitializeComponent();
    }
}
