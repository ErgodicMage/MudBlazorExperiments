# Mud Navigation Panel ISR WebApp

## Purpose
Basically is a demo app for the [**MudNavigationPanel**](https://github.com/ErgodicMage/MudBlazorExperiments) component. It also contains a simple authentication/authorization ability. The app is just a shell and doesn't implement and real functionality. As I mentioned elsewhere, I'm new to Blazor and welcome any suggestions and/or criticisms.

#### Thanks to Coding Droplets
The simple authentication and authorization originally came from [Coding Droplets](https://github.com/codingdroplets/BlazorServerAuthenticationAndAuthorization) and easily worked for me. I was able to quickly figure out how it worked and implement without too much head scratching. I did end up refactoring the code somewhat to match my style but it's still the same implementation. Thank you Coding Droplets for a good example of how to do this.

## Authentication and Authorization
The use of A and A is configurable in this app. If you want to run it without then set UseAuthentication to false (or remove it) from the appsettings.json file. If you do then different cards will display in the Home page. Note that if set to false the Program.cs will not add in the needed dependencies.

Note that I also use Page routing authorization such as in Adminstration page so the navigation panel there (yet to be implemented) doesn't need to have UseAuthorization set there.

#### Question
Do I need to implement CascadingAuthenticationState and AuthorizeRouteView in Routes.razor? I'm unsure how the Routes.razor file actually works with routing and A and A. I need to learn more about routing in Blazor.

## Roles
I hard coded the roles in NavigationRoles.cs though it could be written to be configurable. Though I'm not sure how I would implement NavigationRoles.AuthRoles and NavigationRoles.AllRoles, maybe as a function.

## Users
SimpleNavigationUserService.cs hard codes User and Admin users along with email and password. Of course in real production it would be a lookup (database most likely) on username to get the information and role while authentication would be handled with a IsP (right acronym?).

To login as the different users look in SimpleNavigationUserService.cs for the allowed usernames and passwords.

## Login
I'm not sure at this point (hey I'm new to web apps) if the password can be determined in the Login page. Do I need more to encrypt it and make sure it can't be cracked?

## Interactive Server Render mode
This is used in ISR mode (hence ISR in the name of course), but can it or should it also be done in interactive webassembly and/or interactive auto modes?

## Things I don't like
It's functional but ugly, well IMO Blazor apps tend to look ugly to me anyways.

## Futue enhancements
The list of card settings in the panel pages are hard coded. They could be read from appsettings.json, other json config files or even from a database. If so then Home and Administration pages would be implemented with the card settings inject into them instead of hard coded on initialization. I don't need that for this simple demonstration but it would be better practice to do so in a real production app.