﻿using System.Diagnostics.CodeAnalysis;

namespace TestTestCMS.Web.UI.Components;

public partial class FormCheckbox
{
    [Parameter]
    public int Cols { get; set; } = 12;

    [Parameter]
    public string? Text { get; set; }

    protected override bool TryParseValueFromString(string? value, out bool result, [NotNullWhen(false)] out string? validationErrorMessage)
    {
        throw new NotSupportedException();
    }
}