using System.Windows.Controls;

using MaterialDesignsWpf.ViewModels;

namespace MaterialDesignsWpf.Views
{
    public partial class SettingsPage : Page
    {
        public SettingsPage(SettingsViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
