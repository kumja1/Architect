using Fluxor;
using MudBlazor;
using Microsoft.AspNetCore.Components;
namespace JSON_UI_Editor.Layout;

public partial class NavMenu 
{
    [Inject] private IDispatcher Dispatcher { get; set; }
    [Inject] private IState<ThemeState> ThemeState { get; set; }

    private string ButtonIcon => ThemeState.Value.IsDarkMode ? Icons.Material.Filled.DarkMode : Icons.Material.Filled.LightMode;

    private void ToggleTheme()
    {
        Dispatcher.Dispatch(new ToggleThemeAction());
    }
   
}
