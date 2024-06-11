using Fluxor;

public static class Reducers
{
    [ReducerMethod(typeof(ToggleThemeAction))]
    public static ThemeState ReduceToggleThemeAction(ThemeState state) => new(!state.IsDarkMode);
}