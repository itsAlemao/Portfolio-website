using Microsoft.JSInterop;

namespace PortfolioWebsite.Components.Utils;

public static class JSUtils
{
    public static async Task SwitchThemeAsync(IJSRuntime JS)
    {
        await JS.InvokeVoidAsync("themeUtils.switchTheme");
    }

}