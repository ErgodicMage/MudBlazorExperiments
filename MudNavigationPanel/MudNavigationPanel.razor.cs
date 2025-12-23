using Microsoft.AspNetCore.Components;
using MudBlazor;
using MudBlazor.Utilities;

namespace ErgodicMage.MudNavigationPanel
{
    public partial class MudNavigationPanel
    {
        [Parameter]
        public List<MudNavigationCardSettings>? CardSettings { get; set; }
        [Parameter]
        public string? BackgroundColor { get; set; }
        [Parameter]
        public string? CardBackgroundColor { get; set; }
        [Parameter]
        public string? CardHeight { get; set; }
        [Parameter]
        public string? CardWidth { get; set; }
        [Parameter]
        public Color CardTitleColor { get; set; } = Color.Default;
        [Parameter]
        public Color CardIconColor { get; set; } = Color.Default;
        [Parameter]
        public Size CardIconSize { get; set; }

        protected string Stylename => new StyleBuilder()
            .AddStyle("background", BackgroundColor, !string.IsNullOrEmpty(BackgroundColor))
            .AddStyle(Style)
            .Build();

    }
}