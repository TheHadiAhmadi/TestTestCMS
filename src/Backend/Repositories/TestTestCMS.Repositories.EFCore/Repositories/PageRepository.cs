namespace TestTestCMS.Repositories.EFCore;

public class PageRepository(TestTestCMSDbContext dbContext, IMapper mapper, IApiExecutionContext apiExecutionContext) : SiteAssociatedRepository<Page, PageModel>(dbContext, mapper, apiExecutionContext), IPageRepository
{
}
