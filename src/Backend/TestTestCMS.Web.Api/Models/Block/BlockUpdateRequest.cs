namespace TestTestCMS.Web.Api.Models;

public class BlockUpdateRequest
{
    [Required]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; } = default!;

    [Required]
    public string Category { get; set; } = default!;

    public string? Description { get; set; } = default!;

    [Required]
    public string Content { get; set; } = default!;
}