namespace ErgodicMage.MudNavigationPanelSSR.Authentication;

public interface INavigationUserService
{
    Task<NavigationUser?> GetUser(string? username);
}