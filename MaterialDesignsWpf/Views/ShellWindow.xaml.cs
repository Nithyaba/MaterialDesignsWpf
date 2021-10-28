using System.Windows.Controls;

using MahApps.Metro.Controls;

using MaterialDesignsWpf.Contracts.Views;
using MaterialDesignsWpf.ViewModels;

namespace MaterialDesignsWpf.Views
{
    public partial class ShellWindow : MetroWindow, IShellWindow
    {
        public ShellWindow(ShellViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }

       public Frame GetNavigationFrame()
         => shellFrame;

        public void ShowWindow()
            => Show();

        public void CloseWindow()
            => Close();
    }
}
