using System.Diagnostics;
using AppInstaller.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace AppInstaller.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();

        AppListUpdate();
    }

    void AppListUpdate()
    {

    }
}
