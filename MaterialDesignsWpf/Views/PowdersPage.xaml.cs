using System.Windows.Controls;

using MaterialDesignsWpf.ViewModels;

namespace MaterialDesignsWpf.Views
{
    public partial class PowdersPage : Page
    {
        public PowdersPage(PowdersViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
