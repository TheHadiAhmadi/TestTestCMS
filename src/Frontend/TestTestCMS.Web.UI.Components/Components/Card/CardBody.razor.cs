namespace TestTestCMS.Web.UI.Components;

public partial class CardBody
{
    [Parameter]
    public RenderFragment ChildContent { get; set; } = default!;
}
