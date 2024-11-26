using TestTestCMS.Services.Models;

namespace TestTestCMS.Web.Api.Models;

public class PluginUpdateOrdersRequest
{
    [Required]
    public List<PluginOrder> PluginOrders { get; set; } = [];
}
