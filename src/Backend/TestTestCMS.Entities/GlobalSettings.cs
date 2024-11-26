﻿namespace TestTestCMS.Entities;

public class GlobalSettings : AuditableEntity
{
    public List<string> SuperAdmins { get; set; } = [];
}

public class FileUploadConfig
{
    public long MaxSize { get; set; } = default!;
    public int MaxCount { get; set; } = default!;
    public string AllowedExtensions { get; set; } = default!;
}
