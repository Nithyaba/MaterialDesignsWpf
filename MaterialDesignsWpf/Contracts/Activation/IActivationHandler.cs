using System.Threading.Tasks;

namespace MaterialDesignsWpf.Contracts.Activation
{
    public interface IActivationHandler
    {
        bool CanHandle();

        Task HandleAsync();
    }
}
