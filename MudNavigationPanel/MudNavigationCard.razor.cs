using Microsoft.AspNetCore.Components;
using MudBlazor;
using MudBlazor.Utilities;

namespace ErgodicMage.MudNavigationPanel;
public partial class MudNavigationCard : MudComponentBase
{
    [Parameter]
    public string? Title { get; set; }
    [Parameter]
    public string? Icon { get; set; }
    [Parameter]
    public string? Href { get; set; }
    [Parameter]
    public string? Height { get; set; }
    [Parameter]
    public string? Width { get; set; }
    [Parameter]
    public string? BackgroundColor { get; set; }
    [Parameter]
    public Color TitleColor { get; set; } = Color.Primary;
    [Parameter]
    public Color IconColor { get; set; } = Color.Primary;
    [Parameter]
    public Size IconSize { get; set; } = Size.Large;

    protected string Stylename => new StyleBuilder()
            .AddStyle("background", BackgroundColor, !string.IsNullOrEmpty(BackgroundColor))
            .AddStyle("height", Height, !string.IsNullOrEmpty(Height))
            .AddStyle("width", Width, !string.IsNullOrEmpty(Width))
            .AddStyle(Style)
            .Build();

    void OnClick()
    {
        if (!string.IsNullOrEmpty(Href))
            NavigationManager.NavigateTo(Href);
    }

}