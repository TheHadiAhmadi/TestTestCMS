﻿namespace TestTestCMS.Repositories.LiteDb;

public class RoleRepository(ILiteDBContext liteDbContext, IApiExecutionContext apiExecutionContext) : SiteAssociatedRepository<Role>(liteDbContext, apiExecutionContext), IRoleRepository
{
}
