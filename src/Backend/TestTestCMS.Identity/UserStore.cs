using Microsoft.AspNetCore.Identity;

namespace TestTestCMS.Identity;

public partial class UserStore(IUserRepository repository) : IProtectedUserStore<User>
{

}
