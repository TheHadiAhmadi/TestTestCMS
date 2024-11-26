﻿namespace TestTestCMS.Repositories.LiteDb;

public class PageRepository : SiteAssociatedRepository<Page>, IPageRepository
{
    public PageRepository(ILiteDBContext liteDbContext, IApiExecutionContext apiExecutionContext) : base(liteDbContext, apiExecutionContext)
    {
    }
}
