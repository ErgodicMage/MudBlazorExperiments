# Mud Navigation Panel

This is my first component in Blazor so it could very well need lots of improvements

## Purpose
Personally I don't like the NavMenu layout in Blazor, I think it's ugly and gets in the way, even with a drawer toggle. Instead i wanted a navigation panel that I could reuse in different areas of the app. So I wrote this component.

#### First Blazor component
This is the first time I have written a Blazor component, so most likely it needs a lot of refactoring to make it better. Also, since I have no experience with FE work or designing FEs it still looks fairly ugly but provides the user experience I'm looking for. If anyone sees this, please feel free to open a github issue and leave comments and criticisms!

#### Why MudBlazor
Being new to Blazor and FE development I needed a bunch of components to simplify my development. MudBlazor fit's most of the needs I had when first experimenting with it. The [documentation and examples](https://mudblazor.com/docs/overview) are good and allowed me to get started quickly without using a bunch of css (which I'm not good with). Also Mud's StyleBuilder came in handy and simplified styling when I needed it. There is also a ClassBuilder which I haven't used so far, but expect it to be handy also.

## Approaches to the navigation 'cards'
At first I looked at using [MudCards](https://mudblazor.com/components/card#api) but it looked like the MudCardActions only applied to to specific areas of the card, not the whole card. Please correct me if I was wrong about that.

I then tried using a MudPaper which did work but lacked the visual interaction I thought it should have. For example it lacked the ability to change on hover, of course I could have written the css to do so but I'm bad at css and didn't want to do so.

I settled on customizing the [MudButton](https://mudblazor.com/components/button#filled-buttons) which seems to work and provides the visuals and functionality I want. I don't have to add the extras that I would have needed with the MudPaper approach.

If there is a better method please feel free to open an issue and leave a suggestion.

## Panel
The MudNavigationPanel is the overall container of the MudNavigationCards. It sets the layout of the cards as well as customizing colors and sizes if desired. By itself it's fairly simple and easy to use, supply a list of **MudNavigationCardSettings**, supply the colors and sizes of the cards and it will display the panel.

## Card Settings
The **MudNavigationCardSettings" gives the details of what each card should display. Optional title and icon, the href of the page to navigate to and any authorization roles. With these settings different panels can be displayed for different purposes.

## Authorization
The **MudNavigationPanel** has the ability to display cards based upon the user's authorization role. By default it does not use authorization, but can do so by setting UseAuthorization. Set the specific card authorization role by setting Role in the **MudNavigationCardSettings**.

The **MudNavigationPanel** does not define any authorization roles nor does it handle any aurhentication. It is up to the application to supply authorization and define the roles to be used.

## What I don't like
As I said it's still kind of ugly because I'm not a FE developer. I welcome any suggestions to making it look better.

In **MudNavigationPanel** I have separate code for using authorization and not using it. They both do the same thing with the exception of wrapping the <AuthorizeView></AuthorizeView>. I'm not sure how to improve the .razor so that I'm not duplicating something so simple.

## Future enhancements
The **MudNavigationCards** displays icons, it should be possible to also display images. Should it allow both icons and images?

The panel controls many card settings such as colors and card sizes. This is good because all cards are similar at the cost of not being individually customizable. Add ability to customize each button likely with more options in **MudNavigationCardSettings**.

Finally **MudNavigation*** leads to longer naming than I prefer. Rename everything to **MudNav*** like the NavMenu does.