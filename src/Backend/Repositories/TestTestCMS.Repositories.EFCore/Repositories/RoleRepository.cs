namespace TestTestCMS.Repositories.EFCore;

public class RoleRepository(TestTestCMSDbContext dbContext, IMapper mapper, IApiExecutionContext apiExecutionContext) : SiteAssociatedRepository<Role, RoleModel>(dbContext, mapper, apiExecutionContext), IRoleRepository;
