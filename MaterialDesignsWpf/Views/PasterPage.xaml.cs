using System.Windows.Controls;

using MaterialDesignsWpf.ViewModels;

namespace MaterialDesignsWpf.Views
{
    public partial class PasterPage : Page
    {
        public PasterPage(PasterViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
