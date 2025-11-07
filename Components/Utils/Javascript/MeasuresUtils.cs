using Microsoft.JSInterop;

namespace PortfolioWebsite.Components.Utils.Javascript;

public static class Measures
{

    [JSInvokable("measures.innerHeight")]
    public static async Task<int> InnerHeight(this IJSRuntime JS)
    {
        return await JS.InvokeAsync<int>("measures.innerHeight");
    }
    
}