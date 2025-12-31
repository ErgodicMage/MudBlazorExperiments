namespace ErgodicMage.MudNavigationPanelSSR.Authentication;

public sealed class SimpleNavigationUserService : INavigationUserService
{
    private readonly List<NavigationUser> _users;
    public SimpleNavigationUserService()
    {
        _users = new()
        {
            //new("Anonymous", "Anonymous", "Anonymous@navigate.com", NavigationRoles.Anonymous),
            new("User", "User", "User@navigate.com", NavigationRoles.User),
            new("Admin", "Admin", "Admin@navigate.com", NavigationRoles.Admin)
        };
    }

    public Task<NavigationUser?> GetUser(string? username) =>
        Task.FromResult<NavigationUser?>(_users.FirstOrDefault(u => u.UserName == username));
}
