﻿namespace TestTestCMS.Web.Api.Models;

public class GlobalSettingsUpdateRequest
{
    public IEnumerable<string> SuperAdmins { get; set; } = [];
}
