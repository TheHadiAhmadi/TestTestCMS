namespace FluentCMS.Web.UI.Components;

public partial class Modal : IAsyncDisposable
{
    [Inject]
    public IJSRuntime? JS { get; set; }

    public ElementReference element;

    private IJSObjectReference module = default!;

    private bool open;

    [Parameter]
    [CSSProperty]
    public bool Open
    {
        get
        {
            return open;
        }
        set
        {
            if (value == open) return;

            open = value;

            module.InvokeVoidAsync(open ? "open" : "close", DotNetObjectReference.Create(this), element);
        }
    }

    [Parameter]
    public EventCallback<bool> OpenChanged { get; set; }

    [Parameter]
    [CSSProperty]
    public ModalSize Size { get; set; } = ModalSize.Medium;

    [Parameter]
    public bool Static { get; set; }

    [Parameter]
    public EventCallback OnClose { get; set; }

    [JSInvokable]
    public async void Close()
    {
        await OpenChanged.InvokeAsync(Open = false);

        await OnClose.InvokeAsync();
    }

    public async ValueTask DisposeAsync()
    {
        await module.InvokeVoidAsync("close", DotNetObjectReference.Create(this), element);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender) return;

        module = await JS.InvokeAsync<IJSObjectReference>("import", "/_content/FluentCMS.Web.UI.Components/Components/Modal/Modal.razor.js");

        await module.InvokeVoidAsync("initialize", DotNetObjectReference.Create(this), element, new { Static });
    }
}