using System.Windows.Controls;

using MaterialDesignsWpf.ViewModels;

namespace MaterialDesignsWpf.Views
{
    public partial class LiquidsPage : Page
    {
        public LiquidsPage(LiquidsViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
