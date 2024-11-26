namespace TestTestCMS.Repositories.EFCore;

public class LayoutRepository(TestTestCMSDbContext dbContext, IMapper mapper, IApiExecutionContext apiExecutionContext) : SiteAssociatedRepository<Layout, LayoutModel>(dbContext, mapper, apiExecutionContext), ILayoutRepository;
