namespace TestTestCMS.Web.UI.Components;

public partial class TabHeader
{
    [Parameter]
    public RenderFragment ChildContent { get; set; } = default!;
}
