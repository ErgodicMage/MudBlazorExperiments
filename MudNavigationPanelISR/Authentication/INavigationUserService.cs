namespace ErgodicMage.MudNavigationPanelISR.Authentication;

public interface INavigationUserService
{
    Task<NavigationUser?> GetUser(string? username);
}