using Fluxor;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace JSON_UI_Editor.Layout;
public partial class MainLayout  {
    
        [Inject] private IState<ThemeState> ThemeState { get; set; }
        [Inject] private IDispatcher Dispatcher { get; set; }
        
        private MudTheme Theme = new()
        {
            Palette = new PaletteLight
            {
                AppbarBackground = Colors.Shades.White,
                AppbarText = Colors.Shades.Black,
                TextPrimary = Colors.Shades.Black,
                Primary = Colors.Shades.Black,
                Background = Colors.Shades.White,
                Secondary = Colors.Shades.White
            },
    
            PaletteDark = new PaletteDark
            {
                AppbarText = Colors.Shades.White,
                Primary = Colors.Shades.White,
                Background = Colors.Shades.Black,
                TextPrimary = Colors.Shades.White,
                Secondary = Colors.Shades.Black,
            }
        };
}