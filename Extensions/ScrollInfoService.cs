namespace PortfolioWebsite.Extensions;

using System;
using Microsoft.JSInterop;

public class ScrollInfoService : IScrollInfoService
{
    public event EventHandler<int>? OnScroll;

    public ScrollInfoService(IJSRuntime jsRuntime)
    {
        RegisterServiceViaJsRuntime(jsRuntime);
    }

    private void RegisterServiceViaJsRuntime(IJSRuntime jsRuntime)
    {
        jsRuntime.InvokeVoidAsync("RegisterScrollInfoService", DotNetObjectReference.Create(this));
    }

    public int YValue { get; private set; }

    [JSInvokable("OnScroll")]
    public void JsOnScroll(int yValue)
    {
        YValue = yValue;
        OnScroll?.Invoke(this, yValue);
    }

    public async Task<int?> GetTopYById(IJSRuntime JS, string componentId) => await JS.InvokeAsync<int?>("getMarginHeight", componentId);
}

public interface IScrollInfoService
{
    event EventHandler<int> OnScroll;
    int YValue { get; }

    Task<int?> GetTopYById(IJSRuntime JS, string componentId);
}

