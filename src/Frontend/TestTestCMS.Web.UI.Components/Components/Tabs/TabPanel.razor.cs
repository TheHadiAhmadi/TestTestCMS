namespace TestTestCMS.Web.UI.Components;

public partial class TabPanel
{
    [CSSProperty]
    public bool Active => Name == Parent?.Value;

    [Parameter]
    public string Name { get; set; } = default!;

    [Parameter]
    public RenderFragment ChildContent { get; set; } = default!;

    [CascadingParameter]
    public Tabs? Parent { get; set; }
}