namespace TestTestCMS.Web.UI.Components;

public partial class DropdownMenu
{
    [Parameter]
    public RenderFragment ChildContent { get; set; } = default!;
}
