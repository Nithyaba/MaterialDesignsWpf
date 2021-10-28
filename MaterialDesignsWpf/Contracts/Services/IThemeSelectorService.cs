using System;

using MaterialDesignsWpf.Models;

namespace MaterialDesignsWpf.Contracts.Services
{
    public interface IThemeSelectorService
    {
        void InitializeTheme();

        void SetTheme(AppTheme theme);

        AppTheme GetCurrentTheme();
    }
}
