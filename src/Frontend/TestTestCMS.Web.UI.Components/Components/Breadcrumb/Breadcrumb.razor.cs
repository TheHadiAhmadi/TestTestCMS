﻿namespace TestTestCMS.Web.UI.Components;

public partial class Breadcrumb
{
    [Parameter]
    public RenderFragment ChildContent { get; set; } = default!;
}