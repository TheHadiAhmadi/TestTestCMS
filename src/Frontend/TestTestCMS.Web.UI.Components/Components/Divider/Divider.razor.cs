namespace TestTestCMS.Web.UI.Components;

public partial class Divider
{
    [Parameter]
    public RenderFragment ChildContent { get; set; } = default!;
}