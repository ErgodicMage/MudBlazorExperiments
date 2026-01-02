using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace ErgodicMage.MudNavigationPanelISR.Authentication;

public class NavigationAuthenticationStateProvider : AuthenticationStateProvider
{
    private readonly ProtectedSessionStorage _sessionStorage;

    public NavigationAuthenticationStateProvider(ProtectedSessionStorage sessionStorage)
    {
        _sessionStorage = sessionStorage;
    }

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        try
        {
            var userSessionStorageResult = await _sessionStorage.GetAsync<UserSession>("UserSession");
            var userSession = userSessionStorageResult.Success ? userSessionStorageResult.Value : null;

            ClaimsPrincipal claims = userSession is null ? GetAnonymousClaims() : GetUserClaims(userSession);
            return await Task.FromResult(new AuthenticationState(claims));
        }
        catch
        {
            return await Task.FromResult(new AuthenticationState(GetAnonymousClaims()));
        }
    }

    private ClaimsPrincipal GetAnonymousClaims() =>
        new (new ClaimsIdentity(new List<Claim>
        {
            new (ClaimTypes.Role, NavigationRoles.Anonymous)
        }));

    private ClaimsPrincipal GetUserClaims(UserSession userSession) =>
        new (new ClaimsIdentity(new List<Claim>
        {
            new (ClaimTypes.Name, userSession.UserName),
            new (ClaimTypes.Email, userSession.Email),
            new (ClaimTypes.Role, userSession.Role)
        }));

    public async Task UpdateAuthenticationState(UserSession? userSession)
    {
        await (userSession is null ? _sessionStorage.DeleteAsync("UserSession") : _sessionStorage.SetAsync("UserSession", userSession));

        ClaimsPrincipal claims = userSession is null ? GetAnonymousClaims() : GetUserClaims(userSession);

        NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claims)));
    }

    public async Task<UserSession?> GetUserSession()
    {
        var userSessionStorageResult = await _sessionStorage.GetAsync<UserSession>("UserSession");
        return userSessionStorageResult.Success ? userSessionStorageResult.Value : null;
    }
}
