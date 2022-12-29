using AppInstaller.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace AppInstaller.Views;

public sealed partial class UpgradePage : Page
{
    public UpgradeViewModel ViewModel
    {
        get;
    }

    public UpgradePage()
    {
        ViewModel = App.GetService<UpgradeViewModel>();
        InitializeComponent();
    }
}
