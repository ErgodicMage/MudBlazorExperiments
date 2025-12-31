using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace ErgodicMage.MudNavigationPanelSSR.Authentication;

public static class AuthenticationExtensions
{
    public static IServiceCollection AddNavigationAuthentication(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddAuthentication();
        serviceCollection.AddAuthorization();
        serviceCollection.AddCascadingAuthenticationState();
        serviceCollection.AddScoped<ProtectedSessionStorage>();
        serviceCollection.AddScoped<AuthenticationStateProvider, NavigationAuthenticationStateProvider>();
        serviceCollection.AddSingleton<INavigationUserService, SimpleNavigationUserService>();

        return serviceCollection;
    }
}
