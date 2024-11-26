using Microsoft.JSInterop;

namespace TestTestCMS.Web.UI;

public partial class SiteBuilderToolbarDropdown : IAsyncDisposable
{
    [Inject]
    public IJSRuntime JS { get; set; } = default!;

    private IJSObjectReference Module { get; set; } = default!;

    private DotNetObjectReference<SiteBuilderToolbarDropdown>? DotNetRef { get; set; } = default!;

    async ValueTask IAsyncDisposable.DisposeAsync()
    {

        if (Module is not null)
        {
            await Module.DisposeAsync();
        }

        DotNetRef?.Dispose();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender)
            return;

        DotNetRef = DotNetObjectReference.Create(this);
        Module = await JS.InvokeAsync<IJSObjectReference>("import", "/_content/TestTestCMS.Web.UI/Components/SiteBuilderToolbarDropdown.razor.js");

        await Module.InvokeVoidAsync("initialize", DotNetRef);
    }
}
