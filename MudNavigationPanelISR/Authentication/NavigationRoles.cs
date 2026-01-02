namespace ErgodicMage.MudNavigationPanelISR.Authentication;

public static class NavigationRoles
{
    public const string Anonymous = "Anonymous";
    public const string User = "User";
    public const string Admin = "Admin";
    public const string AuthRoles = $"{User},{Admin}";
    public const string AllRoles = $"{Anonymous},{User},{Admin}";
}
