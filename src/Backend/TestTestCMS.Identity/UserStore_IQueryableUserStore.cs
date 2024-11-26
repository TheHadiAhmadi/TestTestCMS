using Microsoft.AspNetCore.Identity;

namespace TestTestCMS.Identity;

public partial class UserStore : IQueryableUserStore<User>
{
    public IQueryable<User> Users => repository.AsQueryable();
}
